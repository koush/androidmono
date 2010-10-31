namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class UrlInterceptRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal UrlInterceptRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.webkit.PluginData getPluginData(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.UrlInterceptRegistry._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.UrlInterceptRegistry._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "getPluginData", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/PluginData;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.PluginData>(@__env.CallStaticObjectMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.PluginData;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void setUrlInterceptDisabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.UrlInterceptRegistry._m1.native == global::System.IntPtr.Zero)
				global::android.webkit.UrlInterceptRegistry._m1 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "setUrlInterceptDisabled", "(Z)V");
			@__env.CallStaticVoidMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool urlInterceptDisabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.UrlInterceptRegistry._m2.native == global::System.IntPtr.Zero)
				global::android.webkit.UrlInterceptRegistry._m2 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "urlInterceptDisabled", "()Z");
			return @__env.CallStaticBooleanMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool registerHandler(android.webkit.UrlInterceptHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.UrlInterceptRegistry._m3.native == global::System.IntPtr.Zero)
				global::android.webkit.UrlInterceptRegistry._m3 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "registerHandler", "(Landroid/webkit/UrlInterceptHandler;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool unregisterHandler(android.webkit.UrlInterceptHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.UrlInterceptRegistry._m4.native == global::System.IntPtr.Zero)
				global::android.webkit.UrlInterceptRegistry._m4 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "unregisterHandler", "(Landroid/webkit/UrlInterceptHandler;)Z");
			return @__env.CallStaticBooleanMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.webkit.CacheManager.CacheResult getSurrogate(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.UrlInterceptRegistry._m5.native == global::System.IntPtr.Zero)
				global::android.webkit.UrlInterceptRegistry._m5 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "getSurrogate", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.webkit.CacheManager.CacheResult;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public UrlInterceptRegistry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.UrlInterceptRegistry._m6.native == global::System.IntPtr.Zero)
				global::android.webkit.UrlInterceptRegistry._m6 = @__env.GetMethodIDNoThrow(global::android.webkit.UrlInterceptRegistry.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.UrlInterceptRegistry.staticClass, global::android.webkit.UrlInterceptRegistry._m6);
			Init(@__env, handle);
		}
		static UrlInterceptRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.UrlInterceptRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/UrlInterceptRegistry"));
		}
	}
}
