namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class CountDownTimer : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CountDownTimer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.CountDownTimer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected CountDownTimer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _start6018;
		public virtual global::android.os.CountDownTimer start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.CountDownTimer>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.CountDownTimer._start6018));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.CountDownTimer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._start6018));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel6019;
		public virtual void cancel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.CountDownTimer._cancel6019);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._cancel6019);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTick6020;
		public abstract void onTick(long arg0);
		internal static global::net.sf.jni4net.jni.MethodId _onFinish6021;
		public abstract void onFinish();
		internal static global::net.sf.jni4net.jni.MethodId _CountDownTimer6022;
		public CountDownTimer(long arg0, long arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.CountDownTimer.staticClass, global::android.os.CountDownTimer._CountDownTimer6022, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.CountDownTimer.staticClass = @__class;
			global::android.os.CountDownTimer._start6018 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "start", "()Landroid/os/CountDownTimer;");
			global::android.os.CountDownTimer._cancel6019 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "cancel", "()V");
			global::android.os.CountDownTimer._onTick6020 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "onTick", "(J)V");
			global::android.os.CountDownTimer._onFinish6021 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "onFinish", "()V");
			global::android.os.CountDownTimer._CountDownTimer6022 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "<init>", "(JJ)V");
		}
	}
}
