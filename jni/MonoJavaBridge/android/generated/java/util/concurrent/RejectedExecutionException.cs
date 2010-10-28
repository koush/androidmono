namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RejectedExecutionException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RejectedExecutionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException27363;
		public RejectedExecutionException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27363);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException27364;
		public RejectedExecutionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException27365;
		public RejectedExecutionException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException27366;
		public RejectedExecutionException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RejectedExecutionException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.RejectedExecutionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/RejectedExecutionException"));
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27363 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "()V");
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27364 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27365 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27366 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
