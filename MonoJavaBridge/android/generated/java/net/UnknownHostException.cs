namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownHostException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnknownHostException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UnknownHostException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.UnknownHostException._m0.native == global::System.IntPtr.Zero)
				global::java.net.UnknownHostException._m0 = @__env.GetMethodIDNoThrow(global::java.net.UnknownHostException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownHostException.staticClass, global::java.net.UnknownHostException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnknownHostException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.UnknownHostException._m1.native == global::System.IntPtr.Zero)
				global::java.net.UnknownHostException._m1 = @__env.GetMethodIDNoThrow(global::java.net.UnknownHostException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownHostException.staticClass, global::java.net.UnknownHostException._m1);
			Init(@__env, handle);
		}
		static UnknownHostException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.UnknownHostException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/UnknownHostException"));
		}
	}
}
