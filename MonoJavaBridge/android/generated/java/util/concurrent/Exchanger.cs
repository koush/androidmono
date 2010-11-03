namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Exchanger : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Exchanger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object exchange(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.Exchanger.staticClass, "exchange", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.concurrent.Exchanger._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object exchange(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.Exchanger.staticClass, "exchange", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.Exchanger._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public Exchanger() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Exchanger._m2.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Exchanger._m2 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Exchanger.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Exchanger.staticClass, global::java.util.concurrent.Exchanger._m2);
			Init(@__env, handle);
		}
		static Exchanger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Exchanger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Exchanger"));
		}
	}
}
