namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BrokenBarrierException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BrokenBarrierException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public BrokenBarrierException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.BrokenBarrierException._m0.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.BrokenBarrierException._m0 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BrokenBarrierException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.BrokenBarrierException.staticClass, global::java.util.concurrent.BrokenBarrierException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public BrokenBarrierException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.BrokenBarrierException._m1.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.BrokenBarrierException._m1 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BrokenBarrierException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.BrokenBarrierException.staticClass, global::java.util.concurrent.BrokenBarrierException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BrokenBarrierException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.BrokenBarrierException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/BrokenBarrierException"));
		}
	}
}
