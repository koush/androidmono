namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.CacheRequest_))]
	public abstract partial class CacheRequest : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CacheRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.io.OutputStream getBody();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void abort();
		private static global::MonoJavaBridge.MethodId _m2;
		public CacheRequest() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.CacheRequest._m2.native == global::System.IntPtr.Zero)
				global::java.net.CacheRequest._m2 = @__env.GetMethodIDNoThrow(global::java.net.CacheRequest.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.CacheRequest.staticClass, global::java.net.CacheRequest._m2);
			Init(@__env, handle);
		}
		static CacheRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheRequest"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.CacheRequest))]
	internal sealed partial class CacheRequest_ : java.net.CacheRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CacheRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.io.OutputStream getBody()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.CacheRequest_.staticClass, "getBody", "()Ljava/io/OutputStream;", ref global::java.net.CacheRequest_._m0) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.CacheRequest_.staticClass, "abort", "()V", ref global::java.net.CacheRequest_._m1);
		}
		static CacheRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheRequest"));
		}
	}
}
