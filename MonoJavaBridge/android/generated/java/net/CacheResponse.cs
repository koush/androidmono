namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.CacheResponse_))]
	public abstract partial class CacheResponse : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CacheResponse(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders21354;
		public abstract global::java.util.Map getHeaders();
		internal static global::MonoJavaBridge.MethodId _getBody21355;
		public abstract global::java.io.InputStream getBody();
		internal static global::MonoJavaBridge.MethodId _CacheResponse21356;
		public CacheResponse() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.CacheResponse._CacheResponse21356.native == global::System.IntPtr.Zero)
				global::java.net.CacheResponse._CacheResponse21356 = @__env.GetMethodIDNoThrow(global::java.net.CacheResponse.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.CacheResponse.staticClass, global::java.net.CacheResponse._CacheResponse21356);
			Init(@__env, handle);
		}
		static CacheResponse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheResponse.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheResponse"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.CacheResponse))]
	internal sealed partial class CacheResponse_ : java.net.CacheResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CacheResponse_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders21357;
		public override global::java.util.Map getHeaders()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.net.CacheResponse_.staticClass, "getHeaders", "()Ljava/util/Map;", ref global::java.net.CacheResponse_._getHeaders21357) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getBody21358;
		public override global::java.io.InputStream getBody()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.CacheResponse_.staticClass, "getBody", "()Ljava/io/InputStream;", ref global::java.net.CacheResponse_._getBody21358) as java.io.InputStream;
		}
		static CacheResponse_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheResponse_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheResponse"));
		}
		internal static void InitJNI()
		{
		}
	}
}
