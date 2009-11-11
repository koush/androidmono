#include <jni.h>
#include <JNIHelp.h>
#include <stdint.h>
#include "com_koushikdutta_monodalvikbridge_MonoBridge.h"
#include "utils/Log.h"
#include <unistd.h>
#include <glib.h>

#include "bridge.h"

#define LOG_TAG "MonoDalvikInterop"

jmethodID g_handleInvoke;
jclass g_MonoBridgeClass;
JavaVM* g_JavaVM;

extern "C" void register_icalls();
extern "C" int         mono_main                      (int argc, char* argv[]);
#include "bridge.h"
EnsureMarshalBufferLengthFn g_EnsureMarshalBufferLength;
HandleInvokeFn g_HandleInvoke;
extern "C" void ves_icall_DalvikBridge_SetMonoHooks(EnsureMarshalBufferLengthFn ensureMarshalBufferLength, HandleInvokeFn handleInvoke)
{
	g_EnsureMarshalBufferLength = ensureMarshalBufferLength;
	g_HandleInvoke = handleInvoke;
	LOGI("Setting Mono hooks. %p %p\n", g_EnsureMarshalBufferLength, g_HandleInvoke);
}

// If objectId is 0, it implies it is a static method, and fullyQualifiedName must be provided
// If objectId is not 0, it is a non-static method, and fullyQualifiedName must be NULL
extern "C" void ves_icall_DalvikBridge_InvokeInternal(char *buffer)
{
	LOGI("Invoking Java method.\n");
	int bufferLength = *(int *)buffer;
	LOGI("Invoke buffer length: %d\n", bufferLength);
  JNIEnv* env;
  if (g_JavaVM->GetEnv((void**) &env, JNI_VERSION_1_4) == JNI_OK) {
  	env->CallStaticVoidMethod(g_MonoBridgeClass, g_handleInvoke, bufferLength);
  }
}


static JNINativeMethod sMethods[] = {
     /* name, signature, funcPtr */
    {"initializeRuntime", "()V", (void*)Java_com_koushikdutta_monodalvikbridge_MonoBridge_initializeRuntime},
    {"invokeInternal", "([BI)[B", (void*)Java_com_koushikdutta_monodalvikbridge_MonoBridge_invokeInternal},
    {"getInvokeBuffer", "([BI)V", (void*)Java_com_koushikdutta_monodalvikbridge_MonoBridge_getInvokeBuffer},
    {"setReturnBuffer", "([BI)V", (void*)Java_com_koushikdutta_monodalvikbridge_MonoBridge_setReturnBuffer},
};

/*
 * Class:     com_koushikdutta_mono_MonoRuntime
 * Method:    initializeRuntime
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_com_koushikdutta_monodalvikbridge_MonoBridge_initializeRuntime
  (JNIEnv *env, jclass clazz)
{
  LOGI("initializeRuntime");
	g_handleInvoke = env->GetStaticMethodID(clazz, "handleInvoke", "(I)V");
	g_MonoBridgeClass = clazz;

	char ** argv = (char **)malloc(sizeof(char *) * 2);
	argv[0] = "mono";
	argv[1] = "/data/data/com.koushikdutta.mono/MonoDalvikBridge.exe";
	chdir("/data/data/com.koushikdutta.mono/");
	//LOGI("Registering internal calls.\n");
	//register_icalls();
	LOGI("Starting mono main thread.\n");
	mono_main(2, argv);
	LOGI("mono main thread finished.\n");
}


/*
 * Class:     com_koushikdutta_mono_MonoRuntime
 * Method:    invokeInternal
 * Signature: ([BI)[B
 */
JNIEXPORT jbyteArray JNICALL Java_com_koushikdutta_monodalvikbridge_MonoBridge_invokeInternal
  (JNIEnv *env, jclass clazz, jbyteArray buffer, jint bufferLength)
{
	LOGI("Invoking Mono method. %p\n", g_EnsureMarshalBufferLength);
	int fullBufferLength = bufferLength + sizeof(int);
	char *marshalBuffer = g_EnsureMarshalBufferLength(fullBufferLength);
	LOGI("Retrieved Marshal Buffer %p of length %d\n", marshalBuffer, fullBufferLength);
	char *marshalBufferLength = (char*)&fullBufferLength;
	env->GetByteArrayRegion(buffer, 0, bufferLength, (jbyte *)(marshalBuffer + sizeof(int)));
	*(int *)(marshalBuffer) = fullBufferLength;
	marshalBuffer = g_HandleInvoke();
	
	int returnBufferLength = *(int *)marshalBuffer;
	LOGI("Return buffer length: %d\n", returnBufferLength);

	if (bufferLength < returnBufferLength)
	{
		buffer = env->NewByteArray(returnBufferLength);
	}

	env->SetByteArrayRegion(buffer, 0, returnBufferLength, (const jbyte*)marshalBuffer);

	return buffer;
}

/*
 * Class:     com_koushikdutta_monodalvikbridge_MonoBridge
 * Method:    getInvokeBuffer
 * Signature: ([BI)V
 */
JNIEXPORT void JNICALL Java_com_koushikdutta_monodalvikbridge_MonoBridge_getInvokeBuffer
  (JNIEnv *env, jclass clazz, jbyteArray invokeBuffer, jint bufferLength)
{
	LOGI("Copying marshal buffer of length %d\n", bufferLength);
	char *marshalBuffer = g_EnsureMarshalBufferLength(0);
	env->SetByteArrayRegion(invokeBuffer, 0, bufferLength, (jbyte *)marshalBuffer);
}

/*
 * Class:     com_koushikdutta_monodalvikbridge_MonoBridge
 * Method:    setReturnBuffer
 * Signature: ([BI)V
 */
JNIEXPORT void JNICALL Java_com_koushikdutta_monodalvikbridge_MonoBridge_setReturnBuffer
  (JNIEnv *env, jclass clazz, jbyteArray returnBuffer, jint returnBufferLength)
{
	int fullBufferLength = returnBufferLength + sizeof(int);
	char *marshalBuffer = g_EnsureMarshalBufferLength(fullBufferLength);
	env->GetByteArrayRegion(returnBuffer, 0, returnBufferLength, (jbyte*)(marshalBuffer + 4));
	LOGI("Copying marshal buffer of length %d\n", fullBufferLength);
	*(int *)marshalBuffer = fullBufferLength;
}

extern "C" jint JNI_OnLoad(JavaVM* vm, void* reserved)
{
	LOGI("Initializing JNI/PInvoke layer.\n");
	
  g_JavaVM = vm;
  JNIEnv* env;
  if (g_JavaVM->GetEnv((void**) &env, JNI_VERSION_1_4) != JNI_OK) {
    return -1;
  }

	LOGI("Registering native methods.\n");
	jniRegisterNativeMethods(env, "com/koushikdutta/monodalvikbridge/MonoBridge", sMethods, 4);

  return JNI_VERSION_1_4;
}
