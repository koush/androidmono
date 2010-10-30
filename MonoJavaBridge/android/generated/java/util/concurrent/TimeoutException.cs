namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimeoutException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimeoutException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _TimeoutException27521;
		public TimeoutException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.TimeoutException._TimeoutException27521.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.TimeoutException._TimeoutException27521 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeoutException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.TimeoutException.staticClass, global::java.util.concurrent.TimeoutException._TimeoutException27521);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimeoutException27522;
		public TimeoutException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.TimeoutException._TimeoutException27522.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.TimeoutException._TimeoutException27522 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeoutException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.TimeoutException.staticClass, global::java.util.concurrent.TimeoutException._TimeoutException27522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TimeoutException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.TimeoutException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/TimeoutException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
