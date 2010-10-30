namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownServiceException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnknownServiceException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UnknownServiceException21993;
		public UnknownServiceException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.UnknownServiceException._UnknownServiceException21993.native == global::System.IntPtr.Zero)
				global::java.net.UnknownServiceException._UnknownServiceException21993 = @__env.GetMethodIDNoThrow(global::java.net.UnknownServiceException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownServiceException.staticClass, global::java.net.UnknownServiceException._UnknownServiceException21993);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnknownServiceException21994;
		public UnknownServiceException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.UnknownServiceException._UnknownServiceException21994.native == global::System.IntPtr.Zero)
				global::java.net.UnknownServiceException._UnknownServiceException21994 = @__env.GetMethodIDNoThrow(global::java.net.UnknownServiceException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.UnknownServiceException.staticClass, global::java.net.UnknownServiceException._UnknownServiceException21994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnknownServiceException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.UnknownServiceException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/UnknownServiceException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
