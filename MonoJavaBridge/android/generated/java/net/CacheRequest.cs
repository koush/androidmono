namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.CacheRequest_))]
	public abstract partial class CacheRequest : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CacheRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBody21349;
		public abstract global::java.io.OutputStream getBody();
		internal static global::MonoJavaBridge.MethodId _abort21350;
		public abstract void abort();
		internal static global::MonoJavaBridge.MethodId _CacheRequest21351;
		public CacheRequest() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.CacheRequest._CacheRequest21351.native == global::System.IntPtr.Zero)
				global::java.net.CacheRequest._CacheRequest21351 = @__env.GetMethodIDNoThrow(global::java.net.CacheRequest.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.CacheRequest.staticClass, global::java.net.CacheRequest._CacheRequest21351);
			Init(@__env, handle);
		}
		static CacheRequest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheRequest"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.CacheRequest))]
	internal sealed partial class CacheRequest_ : java.net.CacheRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CacheRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBody21352;
		public override global::java.io.OutputStream getBody()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.CacheRequest_.staticClass, "getBody", "()Ljava/io/OutputStream;", ref global::java.net.CacheRequest_._getBody21352) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _abort21353;
		public override void abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.CacheRequest_.staticClass, "abort", "()V", ref global::java.net.CacheRequest_._abort21353);
		}
		static CacheRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheRequest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
