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
		internal static global::MonoJavaBridge.MethodId _start6284;
		public virtual global::android.os.CountDownTimer start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.CountDownTimer._start6284)) as android.os.CountDownTimer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._start6284)) as android.os.CountDownTimer;
		}
		internal static global::MonoJavaBridge.MethodId _cancel6285;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.CountDownTimer._cancel6285);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._cancel6285);
		}
		internal static global::MonoJavaBridge.MethodId _onTick6286;
		public abstract void onTick(long arg0);
		internal static global::MonoJavaBridge.MethodId _onFinish6287;
		public abstract void onFinish();
		internal static global::MonoJavaBridge.MethodId _CountDownTimer6288;
		public CountDownTimer(long arg0, long arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._CountDownTimer6288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.CountDownTimer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/CountDownTimer"));
			global::android.os.CountDownTimer._start6284 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "start", "()Landroid/os/CountDownTimer;");
			global::android.os.CountDownTimer._cancel6285 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "cancel", "()V");
			global::android.os.CountDownTimer._onTick6286 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "onTick", "(J)V");
			global::android.os.CountDownTimer._onFinish6287 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "onFinish", "()V");
			global::android.os.CountDownTimer._CountDownTimer6288 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer.staticClass, "<init>", "(JJ)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.CountDownTimer))]
	public sealed partial class CountDownTimer_ : android.os.CountDownTimer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CountDownTimer_()
		{
			InitJNI();
		}
		internal CountDownTimer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTick6289;
		public override void onTick(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.CountDownTimer_._onTick6289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.CountDownTimer_.staticClass, global::android.os.CountDownTimer_._onTick6289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinish6290;
		public override void onFinish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.CountDownTimer_._onFinish6290);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.CountDownTimer_.staticClass, global::android.os.CountDownTimer_._onFinish6290);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.CountDownTimer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/CountDownTimer"));
			global::android.os.CountDownTimer_._onTick6289 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer_.staticClass, "onTick", "(J)V");
			global::android.os.CountDownTimer_._onFinish6290 = @__env.GetMethodIDNoThrow(global::android.os.CountDownTimer_.staticClass, "onFinish", "()V");
		}
	}
}
