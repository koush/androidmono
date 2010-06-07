#include "com_koushikdutta_monojavabridge_MonoBridge.h"
#include <mono/metadata/metadata.h>
#include <mono/metadata/debug-helpers.h>
#include <mono/metadata/class-internals.h>
#include <mono/metadata/mono-debug.h>

#include <mono/mini/debugger-agent.h>

#ifdef PLATFORM_ANDROID
#include <android/log.h>

#ifndef LOG_TAG
#define LOG_TAG "Mono"
#endif

#ifndef LOGI
#define LOGI(...) ((void)LOG(LOG_INFO, LOG_TAG, __VA_ARGS__))
#endif

#ifndef LOG
#define LOG(priority, tag, ...) \
    LOG_PRI(ANDROID_##priority, tag, __VA_ARGS__)
#endif

/*
 * Log macro that allows you to specify a number for the priority.
 */
#ifndef LOG_PRI
#define LOG_PRI(priority, tag, ...) \
    __android_log_print(priority, tag, __VA_ARGS__)
#endif


#define MONOJAVABRIDGE_DLL "/data/data/com.koushikdutta.mono/MonoJavaBridge.dll"
#else
#define MONOJAVABRIDGE_DLL "MonoJavaBridge.dll"
#define LOGI printf
#endif

typedef void* pointer;

MonoDomain *g_Domain;
MonoAssembly *g_Assembly;
MonoImage *g_Image;
MonoMethod *g_Link;
MonoMethod *g_LoadAssembly;
JavaVM *g_JavaVM;

void logcat_print(char* p)
{
    LOGI(p);
}

JNIEXPORT void JNICALL Java_com_koushikdutta_monojavabridge_MonoBridge_run
  (JNIEnv *env, jclass clazz, jstring assembly)
{
    printf("Running mono assembly...");
    int length = (*env)->GetStringLength(env, assembly);
    const jbyte *str = (*env)->GetStringUTFChars(env, assembly, NULL);
    pointer args[2];
    args[0] = "thing";
    args[1] = str;
    mono_main(2, args);
    
    (*env)->ReleaseStringUTFChars(env, assembly, str);
}


JNIEXPORT void JNICALL Java_com_koushikdutta_monojavabridge_MonoBridge_link
    (JNIEnv *env, jclass clazz, jclass cls, jstring methodName, jstring methodSignature, jstring methodParameters)
{
    void *args[4];
    args[0] = &cls;
    args[1] = &methodName;
    args[2] = &methodSignature;
    args[3] = &methodParameters;
    mono_runtime_invoke(g_Link, NULL, args, NULL);
}

JNIEXPORT void JNICALL Java_com_koushikdutta_monojavabridge_MonoBridge_loadAssembly
    (JNIEnv *env, jclass clazz, jstring assembly)
{
    void *args[1];
    args[0] = &assembly;
    mono_runtime_invoke(g_LoadAssembly, NULL, args, NULL);
}

JNIEXPORT jboolean JNICALL Java_com_koushikdutta_monojavabridge_MonoBridge_initializeMono
  (JNIEnv *env, jclass clazz, jstring homeDir, jstring debuggerAgentOptions)
{
#ifdef PLATFORM_ANDROID
    if (debuggerAgentOptions != NULL)
    {
        LOGI("Debugger enabled...");
        int length = (*env)->GetStringLength(env, debuggerAgentOptions);
        const jbyte *str = (*env)->GetStringUTFChars(env, debuggerAgentOptions, NULL);
        mono_debugger_agent_parse_options(str);
        (*env)->ReleaseStringUTFChars(env, debuggerAgentOptions, str);
    }
#endif

    if (homeDir != NULL)
    {
        LOGI("Debugger enabled...");
        int length = (*env)->GetStringLength(env, homeDir);
        const jbyte *str = (*env)->GetStringUTFChars(env, homeDir, NULL);
        setenv("HOME", str, 1);
        (*env)->ReleaseStringUTFChars(env, homeDir, str);
    }
    
    guint32 opt = mono_parse_default_optimizations(NULL);
	mono_set_defaults (0, opt);
    mono_debug_init (MONO_DEBUG_FORMAT_MONO);
    
    setenv("MONO_PATH", "/data/data/com.koushikdutta.mono/", 0);
	MonoDomain *domain;

#ifdef PLATFORM_ANDROID
    LOGI("mono_jit_init...");
#endif
	domain = mono_jit_init (MONOJAVABRIDGE_DLL);
    MonoAssembly *assembly;

#ifdef PLATFORM_ANDROID
    LOGI("mono_domain_assembly_open...", NULL);
#endif
    assembly = mono_domain_assembly_open (domain, MONOJAVABRIDGE_DLL);
    if (!assembly)
    {
        printf("Unable to load MonoJavaBridge.dll.");
        return FALSE;
    }

    mono_add_internal_call("MonoJavaBridge.JavaBridge::log(intptr)", logcat_print);

    MonoImage *image = mono_assembly_get_image(assembly);
    MonoMethodDesc* desc = mono_method_desc_new ("MonoJavaBridge.JavaBridge:Initialize(intptr)", 1);
    MonoMethod* method = mono_method_desc_search_in_image (desc, image);
    mono_method_desc_free(desc);
    pointer args[1];
    args[0] = &g_JavaVM;
    mono_runtime_invoke(method, NULL, args, NULL);

    desc = mono_method_desc_new ("MonoJavaBridge.JavaBridge:Link(intptr,intptr,intptr,intptr)", 1);
    g_Link = mono_method_desc_search_in_image (desc, image);
    mono_method_desc_free(desc);

    desc = mono_method_desc_new ("MonoJavaBridge.JavaBridge:LoadAssembly(intptr)", 1);
    g_LoadAssembly = mono_method_desc_search_in_image (desc, image);
    mono_method_desc_free(desc);
    
    return TRUE;
}

jint JNI_OnLoad(JavaVM* vm, void* reserved)
{
	g_JavaVM = vm;
#ifdef PLATFORM_ANDROID
    LOGI("JNI_OnLoad...");
#endif
    return JNI_VERSION_1_4;
}