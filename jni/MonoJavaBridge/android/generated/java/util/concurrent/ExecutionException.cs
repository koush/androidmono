namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExecutionException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExecutionException()
		{
			InitJNI();
		}
		protected ExecutionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ExecutionException27256;
		protected ExecutionException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutionException.staticClass, global::java.util.concurrent.ExecutionException._ExecutionException27256);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExecutionException27257;
		protected ExecutionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutionException.staticClass, global::java.util.concurrent.ExecutionException._ExecutionException27257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExecutionException27258;
		public ExecutionException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutionException.staticClass, global::java.util.concurrent.ExecutionException._ExecutionException27258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExecutionException27259;
		public ExecutionException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutionException.staticClass, global::java.util.concurrent.ExecutionException._ExecutionException27259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ExecutionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ExecutionException"));
			global::java.util.concurrent.ExecutionException._ExecutionException27256 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutionException.staticClass, "<init>", "()V");
			global::java.util.concurrent.ExecutionException._ExecutionException27257 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.concurrent.ExecutionException._ExecutionException27258 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutionException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.util.concurrent.ExecutionException._ExecutionException27259 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutionException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
