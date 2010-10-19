namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BrokenBarrierException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BrokenBarrierException()
		{
			InitJNI();
		}
		protected BrokenBarrierException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BrokenBarrierException21151;
		public BrokenBarrierException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.BrokenBarrierException.staticClass, global::java.util.concurrent.BrokenBarrierException._BrokenBarrierException21151);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BrokenBarrierException21152;
		public BrokenBarrierException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.BrokenBarrierException.staticClass, global::java.util.concurrent.BrokenBarrierException._BrokenBarrierException21152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.BrokenBarrierException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/BrokenBarrierException"));
			global::java.util.concurrent.BrokenBarrierException._BrokenBarrierException21151 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BrokenBarrierException.staticClass, "<init>", "()V");
			global::java.util.concurrent.BrokenBarrierException._BrokenBarrierException21152 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.BrokenBarrierException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
