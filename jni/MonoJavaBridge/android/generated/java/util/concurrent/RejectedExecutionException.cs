namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RejectedExecutionException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RejectedExecutionException()
		{
			InitJNI();
		}
		protected RejectedExecutionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException21414;
		public RejectedExecutionException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException21414);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException21415;
		public RejectedExecutionException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException21415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException21416;
		public RejectedExecutionException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException21416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException21417;
		public RejectedExecutionException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException21417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.RejectedExecutionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/RejectedExecutionException"));
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException21414 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "()V");
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException21415 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException21416 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException21417 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
