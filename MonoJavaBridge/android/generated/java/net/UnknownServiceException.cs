namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownServiceException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnknownServiceException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UnknownServiceException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.UnknownServiceException._m0.native == global::System.IntPtr.Zero)
				global::java.net.UnknownServiceException._m0 = @__env.GetMethodIDNoThrow(global::java.net.UnknownServiceException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownServiceException.staticClass, global::java.net.UnknownServiceException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UnknownServiceException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.UnknownServiceException._m1.native == global::System.IntPtr.Zero)
				global::java.net.UnknownServiceException._m1 = @__env.GetMethodIDNoThrow(global::java.net.UnknownServiceException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownServiceException.staticClass, global::java.net.UnknownServiceException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnknownServiceException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.UnknownServiceException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/UnknownServiceException"));
		}
	}
}
