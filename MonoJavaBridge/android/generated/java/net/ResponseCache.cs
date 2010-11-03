namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.ResponseCache_))]
	public abstract partial class ResponseCache : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResponseCache(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.net.CacheResponse get(java.net.URI arg0, java.lang.String arg1, java.util.Map arg2);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.net.CacheRequest put(java.net.URI arg0, java.net.URLConnection arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.net.ResponseCache getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ResponseCache._m2.native == global::System.IntPtr.Zero)
				global::java.net.ResponseCache._m2 = @__env.GetStaticMethodIDNoThrow(global::java.net.ResponseCache.staticClass, "getDefault", "()Ljava/net/ResponseCache;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.ResponseCache.staticClass, global::java.net.ResponseCache._m2)) as java.net.ResponseCache;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void setDefault(java.net.ResponseCache arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ResponseCache._m3.native == global::System.IntPtr.Zero)
				global::java.net.ResponseCache._m3 = @__env.GetStaticMethodIDNoThrow(global::java.net.ResponseCache.staticClass, "setDefault", "(Ljava/net/ResponseCache;)V");
			@__env.CallStaticVoidMethod(java.net.ResponseCache.staticClass, global::java.net.ResponseCache._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ResponseCache() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ResponseCache._m4.native == global::System.IntPtr.Zero)
				global::java.net.ResponseCache._m4 = @__env.GetMethodIDNoThrow(global::java.net.ResponseCache.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ResponseCache.staticClass, global::java.net.ResponseCache._m4);
			Init(@__env, handle);
		}
		static ResponseCache()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ResponseCache.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ResponseCache"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.ResponseCache))]
	internal sealed partial class ResponseCache_ : java.net.ResponseCache
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResponseCache_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.net.CacheResponse get(java.net.URI arg0, java.lang.String arg1, java.util.Map arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ResponseCache_.staticClass, "get", "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/CacheResponse;", ref global::java.net.ResponseCache_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.net.CacheResponse;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.net.CacheRequest put(java.net.URI arg0, java.net.URLConnection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ResponseCache_.staticClass, "put", "(Ljava/net/URI;Ljava/net/URLConnection;)Ljava/net/CacheRequest;", ref global::java.net.ResponseCache_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.CacheRequest;
		}
		static ResponseCache_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ResponseCache_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ResponseCache"));
		}
	}
}
