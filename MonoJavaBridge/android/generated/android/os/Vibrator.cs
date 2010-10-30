namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Vibrator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Vibrator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Vibrator.staticClass, "cancel", "()V", ref global::android.os.Vibrator._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void vibrate(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Vibrator.staticClass, "vibrate", "(J)V", ref global::android.os.Vibrator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void vibrate(long[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Vibrator.staticClass, "vibrate", "([JI)V", ref global::android.os.Vibrator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Vibrator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Vibrator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Vibrator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
