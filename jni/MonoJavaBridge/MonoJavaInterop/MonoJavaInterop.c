#include "com_koushikdutta_monojavabridge_MonoBridge.h"
         #include <mono/metadata/metadata.h>
#include <mono/metadata/debug-helpers.h>
#include <mono/metadata/class-internals.h>


MonoDomain *g_Domain;
MonoAssembly *g_Assembly;
MonoImage *g_Image;
MonoMethod *g_Prelink;
JavaVM *g_JavaVM;

typedef void* pointer;

pointer *mono_objectpointer_conversion(pointer p)
{
  return p;
}

JNIEXPORT void JNICALL Java_com_koushikdutta_monojavabridge_MonoBridge_prelink
  (JNIEnv *env, jclass clazz, jstring className)
{
  void *args[1];
  args[0] = className;
  mono_runtime_invoke(g_Prelink, NULL, args, NULL);
}

jint JNI_OnLoad(JavaVM* vm, void* reserved)
{
	g_JavaVM = vm;
	MonoDomain *domain;
 
	domain = mono_jit_init ("MonoJavaBridge.dll");
  MonoAssembly *assembly;

  assembly = mono_domain_assembly_open (domain, "MonoJavaBridge.dll");
  if (!assembly)
  {
    printf("Unable to load MonoJavaBridge.dll.");
    return;
  }
  
  mono_add_internal_call("MonoJavaBridge.JavaBridge::mono_object_to_pointer(object)", mono_objectpointer_conversion);
  mono_add_internal_call("MonoJavaBridge.JavaBridge::mono_pointer_to_object(intptr)", mono_objectpointer_conversion);
  mono_add_internal_call("MonoJavaBridge.Foo::GetSelf", mono_objectpointer_conversion);
  
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

  return JNI_VERSION_1_4;
}