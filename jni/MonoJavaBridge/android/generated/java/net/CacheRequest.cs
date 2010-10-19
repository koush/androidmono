namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.CacheRequest_))]
	public abstract partial class CacheRequest : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CacheRequest()
		{
			InitJNI();
		}
		protected CacheRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBody15686;
		public abstract global::java.io.OutputStream getBody();
		internal static global::MonoJavaBridge.MethodId _abort15687;
		public abstract void abort();
		internal static global::MonoJavaBridge.MethodId _CacheRequest15688;
		public CacheRequest()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.CacheRequest.staticClass, global::java.net.CacheRequest._CacheRequest15688);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheRequest"));
			global::java.net.CacheRequest._getBody15686 = @__env.GetMethodIDNoThrow(global::java.net.CacheRequest.staticClass, "getBody", "()Ljava/io/OutputStream;");
			global::java.net.CacheRequest._abort15687 = @__env.GetMethodIDNoThrow(global::java.net.CacheRequest.staticClass, "abort", "()V");
			global::java.net.CacheRequest._CacheRequest15688 = @__env.GetMethodIDNoThrow(global::java.net.CacheRequest.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.CacheRequest))]
	public sealed partial class CacheRequest_ : java.net.CacheRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CacheRequest_()
		{
			InitJNI();
		}
		internal CacheRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBody15689;
		public override global::java.io.OutputStream getBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.CacheRequest_._getBody15689)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.CacheRequest_.staticClass, global::java.net.CacheRequest_._getBody15689)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _abort15690;
		public override void abort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.CacheRequest_._abort15690);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.CacheRequest_.staticClass, global::java.net.CacheRequest_._abort15690);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.CacheRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/CacheRequest"));
			global::java.net.CacheRequest_._getBody15689 = @__env.GetMethodIDNoThrow(global::java.net.CacheRequest_.staticClass, "getBody", "()Ljava/io/OutputStream;");
			global::java.net.CacheRequest_._abort15690 = @__env.GetMethodIDNoThrow(global::java.net.CacheRequest_.staticClass, "abort", "()V");
		}
	}
}
