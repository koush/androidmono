namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BindException : java.net.SocketException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BindException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BindException21347;
		public BindException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.BindException._BindException21347.native == global::System.IntPtr.Zero)
				global::java.net.BindException._BindException21347 = @__env.GetMethodIDNoThrow(global::java.net.BindException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.BindException.staticClass, global::java.net.BindException._BindException21347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BindException21348;
		public BindException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.BindException._BindException21348.native == global::System.IntPtr.Zero)
				global::java.net.BindException._BindException21348 = @__env.GetMethodIDNoThrow(global::java.net.BindException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.BindException.staticClass, global::java.net.BindException._BindException21348);
			Init(@__env, handle);
		}
		static BindException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.BindException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/BindException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
