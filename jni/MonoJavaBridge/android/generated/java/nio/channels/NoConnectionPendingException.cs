namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoConnectionPendingException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoConnectionPendingException()
		{
			InitJNI();
		}
		protected NoConnectionPendingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoConnectionPendingException16801;
		public NoConnectionPendingException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NoConnectionPendingException.staticClass, global::java.nio.channels.NoConnectionPendingException._NoConnectionPendingException16801);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NoConnectionPendingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NoConnectionPendingException"));
			global::java.nio.channels.NoConnectionPendingException._NoConnectionPendingException16801 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NoConnectionPendingException.staticClass, "<init>", "()V");
		}
	}
}
