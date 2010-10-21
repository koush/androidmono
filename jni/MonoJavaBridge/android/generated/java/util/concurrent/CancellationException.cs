namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CancellationException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CancellationException()
		{
			InitJNI();
		}
		protected CancellationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CancellationException26984;
		public CancellationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CancellationException.staticClass, global::java.util.concurrent.CancellationException._CancellationException26984);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CancellationException26985;
		public CancellationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CancellationException.staticClass, global::java.util.concurrent.CancellationException._CancellationException26985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CancellationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CancellationException"));
			global::java.util.concurrent.CancellationException._CancellationException26984 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CancellationException.staticClass, "<init>", "()V");
			global::java.util.concurrent.CancellationException._CancellationException26985 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CancellationException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
