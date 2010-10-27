namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectException : java.net.SocketException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnectException()
		{
			InitJNI();
		}
		protected ConnectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ConnectException21358;
		public ConnectException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ConnectException.staticClass, global::java.net.ConnectException._ConnectException21358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConnectException21359;
		public ConnectException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ConnectException.staticClass, global::java.net.ConnectException._ConnectException21359);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ConnectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ConnectException"));
			global::java.net.ConnectException._ConnectException21358 = @__env.GetMethodIDNoThrow(global::java.net.ConnectException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.ConnectException._ConnectException21359 = @__env.GetMethodIDNoThrow(global::java.net.ConnectException.staticClass, "<init>", "()V");
		}
	}
}
