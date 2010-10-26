namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CancelledKeyException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CancelledKeyException()
		{
			InitJNI();
		}
		protected CancelledKeyException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CancelledKeyException22404;
		public CancelledKeyException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.CancelledKeyException.staticClass, global::java.nio.channels.CancelledKeyException._CancelledKeyException22404);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.CancelledKeyException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/CancelledKeyException"));
			global::java.nio.channels.CancelledKeyException._CancelledKeyException22404 = @__env.GetMethodIDNoThrow(global::java.nio.channels.CancelledKeyException.staticClass, "<init>", "()V");
		}
	}
}
