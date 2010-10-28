namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoRouteToHostException : java.net.SocketException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoRouteToHostException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoRouteToHostException21650;
		public NoRouteToHostException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.NoRouteToHostException.staticClass, global::java.net.NoRouteToHostException._NoRouteToHostException21650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoRouteToHostException21651;
		public NoRouteToHostException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.NoRouteToHostException.staticClass, global::java.net.NoRouteToHostException._NoRouteToHostException21651);
			Init(@__env, handle);
		}
		static NoRouteToHostException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.NoRouteToHostException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/NoRouteToHostException"));
			global::java.net.NoRouteToHostException._NoRouteToHostException21650 = @__env.GetMethodIDNoThrow(global::java.net.NoRouteToHostException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.NoRouteToHostException._NoRouteToHostException21651 = @__env.GetMethodIDNoThrow(global::java.net.NoRouteToHostException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
