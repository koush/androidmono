namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoRouteToHostException : java.net.SocketException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoRouteToHostException()
		{
			InitJNI();
		}
		protected NoRouteToHostException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoRouteToHostException21531;
		public NoRouteToHostException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.NoRouteToHostException.staticClass, global::java.net.NoRouteToHostException._NoRouteToHostException21531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoRouteToHostException21532;
		public NoRouteToHostException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.NoRouteToHostException.staticClass, global::java.net.NoRouteToHostException._NoRouteToHostException21532);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.NoRouteToHostException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/NoRouteToHostException"));
			global::java.net.NoRouteToHostException._NoRouteToHostException21531 = @__env.GetMethodIDNoThrow(global::java.net.NoRouteToHostException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.NoRouteToHostException._NoRouteToHostException21532 = @__env.GetMethodIDNoThrow(global::java.net.NoRouteToHostException.staticClass, "<init>", "()V");
		}
	}
}
