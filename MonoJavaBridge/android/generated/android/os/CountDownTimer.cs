namespace android.os
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.os.CountDownTimer_))]
	public abstract partial class CountDownTimer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CountDownTimer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.os.CountDownTimer start()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.CountDownTimer.staticClass, "start", "()Landroid/os/CountDownTimer;", ref global::android.os.CountDownTimer._m0) as android.os.CountDownTimer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.CountDownTimer.staticClass, "cancel", "()V", ref global::android.os.CountDownTimer._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void onTick(long arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void onFinish();
		private static global::MonoJavaBridge.MethodId _m4;
		public CountDownTimer(long arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.CountDownTimer._m4.native == global::System.IntPtr.Zero)
				global::android.os.CountDownTimer._m4 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "<init>", "(JJ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CountDownTimer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.CountDownTimer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/CountDownTimer"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.CountDownTimer))]
	internal sealed partial class CountDownTimer_ : android.os.CountDownTimer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CountDownTimer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onTick(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.CountDownTimer_.staticClass, "onTick", "(J)V", ref global::android.os.CountDownTimer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onFinish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.CountDownTimer_.staticClass, "onFinish", "()V", ref global::android.os.CountDownTimer_._m1);
		}
		static CountDownTimer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.CountDownTimer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/CountDownTimer"));
		}
	}
}
