#include "com_koushikdutta_monojavabridge_MonoBridge.h"
         #include <mono/metadata/metadata.h>
#include <mono/metadata/debug-helpers.h>
#include <mono/metadata/class-internals.h>
#include <mono/metadata/mono-debug.h>

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

MonoDomain *g_Domain;
MonoAssembly *g_Assembly;
MonoImage *g_Image;
MonoMethod *g_Prelink;
MonoMethod *g_LoadAssembly;
JavaVM *g_JavaVM;

typedef void* pointer;

pointer *mono_objectpointer_conversion(pointer p)
{
    return p;
}

void callfunc(char* ff)//, JNIEnv* env)
{
    LOGI("callfunc thread: %d", (int)pthread_self());
    LOGI(ff);
    //(*env)->FindClass(env, ff);
    LOGI("done");
}

void logcat_print(char* p)
{
    LOGI(p);
}

JNIEXPORT void JNICALL Java_com_koushikdutta_monojavabridge_MonoBridge_prelink
  (JNIEnv *env, jclass clazz, jstring className)
{
    void *args[1];
    args[0] = &className;
    mono_runtime_invoke(g_Prelink, NULL, args, NULL);
}

JNIEXPORT void JNICALL Java_com_koushikdutta_monojavabridge_MonoBridge_loadAssembly
  (JNIEnv *env, jclass clazz, jstring assembly)
{
    void *args[1];
    args[0] = &assembly;
    mono_runtime_invoke(g_LoadAssembly, NULL, args, NULL);
}

jint JNI_OnLoad(JavaVM* vm, void* reserved)
{
#ifdef PLATFORM_ANDROID
    LOGI("JNI_OnLoad...");
#endif
	g_JavaVM = vm;
	MonoDomain *domain;

	mono_debug_init (MONO_DEBUG_FORMAT_MONO);
 
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
        return JNI_VERSION_1_4;
    }

    mono_add_internal_call("MonoJavaBridge.JavaBridge::mono_object_to_pointer(object)", mono_objectpointer_conversion);
    mono_add_internal_call("MonoJavaBridge.JavaBridge::mono_pointer_to_object(intptr)", mono_objectpointer_conversion);
    mono_add_internal_call("MonoJavaBridge.JavaBridge::log(intptr)", logcat_print);

    MonoImage *image = mono_assembly_get_image(assembly);
    MonoMethodDesc* desc = mono_method_desc_new ("MonoJavaBridge.JavaBridge:Initialize(intptr)", 1);
    MonoMethod* method = mono_method_desc_search_in_image (desc, image);
    mono_method_desc_free(desc);
    pointer args[1];
    args[0] = &g_JavaVM;
    mono_runtime_invoke(method, NULL, args, NULL);

    desc = mono_method_desc_new ("MonoJavaBridge.JavaBridge:Prelink(intptr)", 1);
    g_Prelink = mono_method_desc_search_in_image (desc, image);
    mono_method_desc_free(desc);

    desc = mono_method_desc_new ("MonoJavaBridge.JavaBridge:LoadAssembly(intptr)", 1);
    g_LoadAssembly = mono_method_desc_search_in_image (desc, image);
    mono_method_desc_free(desc);

    return JNI_VERSION_1_4;
}