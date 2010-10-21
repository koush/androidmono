namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class UrlInterceptRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UrlInterceptRegistry()
		{
			InitJNI();
		}
		internal UrlInterceptRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPluginData16028;
		public static global::android.webkit.PluginData getPluginData(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._getPluginData16028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.PluginData;
		}
		internal static global::MonoJavaBridge.MethodId _setUrlInterceptDisabled16029;
		public static void setUrlInterceptDisabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._setUrlInterceptDisabled16029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _urlInterceptDisabled16030;
		public static bool urlInterceptDisabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._urlInterceptDisabled16030);
		}
		internal static global::MonoJavaBridge.MethodId _registerHandler16031;
		public static bool registerHandler(android.webkit.UrlInterceptHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._registerHandler16031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterHandler16032;
		public static bool unregisterHandler(android.webkit.UrlInterceptHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._unregisterHandler16032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSurrogate16033;
		public static global::android.webkit.CacheManager.CacheResult getSurrogate(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._getSurrogate16033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.CacheManager.CacheResult;
		}
		internal static global::MonoJavaBridge.MethodId _UrlInterceptRegistry16034;
		public UrlInterceptRegistry()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._UrlInterceptRegistry16034);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.UrlInterceptRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/UrlInterceptRegistry"));
			global::android.webkit.UrlInterceptRegistry._getPluginData16028 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "getPluginData", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/PluginData;");
			global::android.webkit.UrlInterceptRegistry._setUrlInterceptDisabled16029 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "setUrlInterceptDisabled", "(Z)V");
			global::android.webkit.UrlInterceptRegistry._urlInterceptDisabled16030 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "urlInterceptDisabled", "()Z");
			global::android.webkit.UrlInterceptRegistry._registerHandler16031 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "registerHandler", "(Landroid/webkit/UrlInterceptHandler;)Z");
			global::android.webkit.UrlInterceptRegistry._unregisterHandler16032 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "unregisterHandler", "(Landroid/webkit/UrlInterceptHandler;)Z");
			global::android.webkit.UrlInterceptRegistry._getSurrogate16033 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "getSurrogate", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;");
			global::android.webkit.UrlInterceptRegistry._UrlInterceptRegistry16034 = @__env.GetMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "<init>", "()V");
		}
	}
}
