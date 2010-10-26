namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BindException : java.net.SocketException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BindException()
		{
			InitJNI();
		}
		protected BindException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BindException21346;
		public BindException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.BindException.staticClass, global::java.net.BindException._BindException21346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BindException21347;
		public BindException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.BindException.staticClass, global::java.net.BindException._BindException21347);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.BindException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/BindException"));
			global::java.net.BindException._BindException21346 = @__env.GetMethodIDNoThrow(global::java.net.BindException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.BindException._BindException21347 = @__env.GetMethodIDNoThrow(global::java.net.BindException.staticClass, "<init>", "()V");
		}
	}
}
