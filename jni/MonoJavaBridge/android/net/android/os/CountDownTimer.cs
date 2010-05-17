namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CountDownTimer : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CountDownTimer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.CountDownTimer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CountDownTimer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start5222; 
		public virtual android.os.CountDownTimer start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.CountDownTimer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.CountDownTimer>(@__env, @__env.CallObjectMethodPtr(this, _start5222)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.CountDownTimer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.CountDownTimer.staticClass, _start5222)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel5223; 
		public virtual void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.CountDownTimer)) 
				@__env.CallVoidMethod(this, _cancel5223); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.CountDownTimer.staticClass, _cancel5223); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTick5224; 
		public abstract void onTick(long arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _onFinish5225; 
		public abstract void onFinish(); 
		internal static global::net.sf.jni4net.jni.MethodId _CountDownTimer5226; 
		public CountDownTimer(long arg0, long arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.CountDownTimer.staticClass, _CountDownTimer5226, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.CountDownTimer.staticClass = @__class; 
			global::android.os.CountDownTimer._start5222 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "start", "()Landroid/os/CountDownTimer;"); 
			global::android.os.CountDownTimer._cancel5223 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "cancel", "()V"); 
			global::android.os.CountDownTimer._onTick5224 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "onTick", "(J)V"); 
			global::android.os.CountDownTimer._onFinish5225 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "onFinish", "()V"); 
			global::android.os.CountDownTimer._CountDownTimer5226 = @__env.GetMethodID(global::android.os.CountDownTimer.staticClass, "<init>", "(JJ)V"); 
		} 
	} 
} 
