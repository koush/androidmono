namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Vibrator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Vibrator()
		{
			InitJNI();
		}
		protected Vibrator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel6743;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Vibrator._cancel6743);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Vibrator.staticClass, global::android.os.Vibrator._cancel6743);
		}
		internal static global::MonoJavaBridge.MethodId _vibrate6744;
		public virtual void vibrate(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Vibrator._vibrate6744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Vibrator.staticClass, global::android.os.Vibrator._vibrate6744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _vibrate6745;
		public virtual void vibrate(long[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Vibrator._vibrate6745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Vibrator.staticClass, global::android.os.Vibrator._vibrate6745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Vibrator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Vibrator"));
			global::android.os.Vibrator._cancel6743 = @__env.GetMethodIDNoThrow(global::android.os.Vibrator.staticClass, "cancel", "()V");
			global::android.os.Vibrator._vibrate6744 = @__env.GetMethodIDNoThrow(global::android.os.Vibrator.staticClass, "vibrate", "(J)V");
			global::android.os.Vibrator._vibrate6745 = @__env.GetMethodIDNoThrow(global::android.os.Vibrator.staticClass, "vibrate", "([JI)V");
		}
	}
}
