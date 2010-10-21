namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimeoutException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimeoutException()
		{
			InitJNI();
		}
		protected TimeoutException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _TimeoutException27402;
		public TimeoutException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.TimeoutException.staticClass, global::java.util.concurrent.TimeoutException._TimeoutException27402);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TimeoutException27403;
		public TimeoutException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.TimeoutException.staticClass, global::java.util.concurrent.TimeoutException._TimeoutException27403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.TimeoutException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/TimeoutException"));
			global::java.util.concurrent.TimeoutException._TimeoutException27402 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeoutException.staticClass, "<init>", "()V");
			global::java.util.concurrent.TimeoutException._TimeoutException27403 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeoutException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
