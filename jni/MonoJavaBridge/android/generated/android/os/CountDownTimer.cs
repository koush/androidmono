namespace android.os
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.os.CountDownTimer_))]
	public abstract partial class CountDownTimer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CountDownTimer()
		{
			InitJNI();
		}
		protected CountDownTimer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start9688;
		public virtual global::android.os.CountDownTimer start()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.CountDownTimer._start9688)) as android.os.CountDownTimer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._start9688)) as android.os.CountDownTimer;
		}
		internal static global::MonoJavaBridge.MethodId _cancel9689;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.CountDownTimer._cancel9689);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._cancel9689);
		}
		internal static global::MonoJavaBridge.MethodId _onTick9690;
		public abstract void onTick(long arg0);
		internal static global::MonoJavaBridge.MethodId _onFinish9691;
		public abstract void onFinish();
		internal static global::MonoJavaBridge.MethodId _CountDownTimer9692;
		public CountDownTimer(long arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._CountDownTimer9692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.CountDownTimer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/CountDownTimer"));
			global::android.os.CountDownTimer._start9688 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "start", "()Landroid/os/CountDownTimer;");
			global::android.os.CountDownTimer._cancel9689 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "cancel", "()V");
			global::android.os.CountDownTimer._onTick9690 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "onTick", "(J)V");
			global::android.os.CountDownTimer._onFinish9691 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "onFinish", "()V");
			global::android.os.CountDownTimer._CountDownTimer9692 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "<init>", "(JJ)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.CountDownTimer))]
	internal sealed partial class CountDownTimer_ : android.os.CountDownTimer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CountDownTimer_()
		{
			InitJNI();
		}
		internal CountDownTimer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTick9693;
		public override void onTick(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.CountDownTimer_._onTick9693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.CountDownTimer_.staticClass, global::android.os.CountDownTimer_._onTick9693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinish9694;
		public override void onFinish()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.CountDownTimer_._onFinish9694);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.CountDownTimer_.staticClass, global::android.os.CountDownTimer_._onFinish9694);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.CountDownTimer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/CountDownTimer"));
			global::android.os.CountDownTimer_._onTick9693 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer_.staticClass, "onTick", "(J)V");
			global::android.os.CountDownTimer_._onFinish9694 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer_.staticClass, "onFinish", "()V");
		}
	}
}
