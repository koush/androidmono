namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketException()
		{
			InitJNI();
		}
		protected SocketException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SocketException16075;
		public SocketException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketException.staticClass, global::java.net.SocketException._SocketException16075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SocketException16076;
		public SocketException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.SocketException.staticClass, global::java.net.SocketException._SocketException16076);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.SocketException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/SocketException"));
			global::java.net.SocketException._SocketException16075 = @__env.GetMethodIDNoThrow(global::java.net.SocketException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.SocketException._SocketException16076 = @__env.GetMethodIDNoThrow(global::java.net.SocketException.staticClass, "<init>", "()V");
		}
	}
}
