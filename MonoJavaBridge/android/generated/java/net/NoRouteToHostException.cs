namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoRouteToHostException : java.net.SocketException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoRouteToHostException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NoRouteToHostException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.NoRouteToHostException._m0.native == global::System.IntPtr.Zero)
				global::java.net.NoRouteToHostException._m0 = @__env.GetMethodIDNoThrow(global::java.net.NoRouteToHostException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.NoRouteToHostException.staticClass, global::java.net.NoRouteToHostException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NoRouteToHostException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.NoRouteToHostException._m1.native == global::System.IntPtr.Zero)
				global::java.net.NoRouteToHostException._m1 = @__env.GetMethodIDNoThrow(global::java.net.NoRouteToHostException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.NoRouteToHostException.staticClass, global::java.net.NoRouteToHostException._m1);
			Init(@__env, handle);
		}
		static NoRouteToHostException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.NoRouteToHostException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/NoRouteToHostException"));
		}
	}
}
