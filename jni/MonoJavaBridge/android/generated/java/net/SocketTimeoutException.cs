namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketTimeoutException : java.io.InterruptedIOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketTimeoutException()
		{
			InitJNI();
		}
		protected SocketTimeoutException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SocketTimeoutException21836;
		public SocketTimeoutException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketTimeoutException.staticClass, global::java.net.SocketTimeoutException._SocketTimeoutException21836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SocketTimeoutException21837;
		public SocketTimeoutException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketTimeoutException.staticClass, global::java.net.SocketTimeoutException._SocketTimeoutException21837);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketTimeoutException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketTimeoutException"));
			global::java.net.SocketTimeoutException._SocketTimeoutException21836 = @__env.GetMethodIDNoThrow(global::java.net.SocketTimeoutException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.SocketTimeoutException._SocketTimeoutException21837 = @__env.GetMethodIDNoThrow(global::java.net.SocketTimeoutException.staticClass, "<init>", "()V");
		}
	}
}
