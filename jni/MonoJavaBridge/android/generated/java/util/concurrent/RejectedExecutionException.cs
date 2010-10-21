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
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException27244;
		public RejectedExecutionException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27244);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException27245;
		public RejectedExecutionException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException27246;
		public RejectedExecutionException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RejectedExecutionException27247;
		public RejectedExecutionException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.RejectedExecutionException.staticClass, global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.RejectedExecutionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/RejectedExecutionException"));
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27244 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "()V");
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27245 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27246 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.util.concurrent.RejectedExecutionException._RejectedExecutionException27247 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
