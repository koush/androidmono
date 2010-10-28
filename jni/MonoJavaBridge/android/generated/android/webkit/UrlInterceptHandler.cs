namespace android.webkit
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.UrlInterceptHandler_))]
	public partial interface UrlInterceptHandler  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.webkit.CacheManager.CacheResult service(java.lang.String arg0, java.util.Map arg1);
		global::android.webkit.PluginData getPluginData(java.lang.String arg0, java.util.Map arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.UrlInterceptHandler))]
	internal sealed partial class UrlInterceptHandler_ : java.lang.Object, UrlInterceptHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal UrlInterceptHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _service16112;
		global::android.webkit.CacheManager.CacheResult android.webkit.UrlInterceptHandler.service(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.UrlInterceptHandler_._service16112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.CacheManager.CacheResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.UrlInterceptHandler_.staticClass, global::android.webkit.UrlInterceptHandler_._service16112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.CacheManager.CacheResult;
		}
		internal static global::MonoJavaBridge.MethodId _getPluginData16113;
		global::android.webkit.PluginData android.webkit.UrlInterceptHandler.getPluginData(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.PluginData>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.UrlInterceptHandler_._getPluginData16113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.PluginData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.PluginData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.UrlInterceptHandler_.staticClass, global::android.webkit.UrlInterceptHandler_._getPluginData16113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.PluginData;
		}
		static UrlInterceptHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.UrlInterceptHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/UrlInterceptHandler"));
			global::android.webkit.UrlInterceptHandler_._service16112 = @__env.GetMethodIDNoThrow(global::android.webkit.UrlInterceptHandler_.staticClass, "service", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;");
			global::android.webkit.UrlInterceptHandler_._getPluginData16113 = @__env.GetMethodIDNoThrow(global::android.webkit.UrlInterceptHandler_.staticClass, "getPluginData", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/PluginData;");
		}
		internal static void InitJNI()
		{
		}
	}
}
