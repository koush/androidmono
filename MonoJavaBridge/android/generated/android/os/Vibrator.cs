namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Vibrator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Vibrator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel10224;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Vibrator.staticClass, global::android.os.Vibrator._cancel10224);
		}
		internal static global::MonoJavaBridge.MethodId _vibrate10225;
		public virtual void vibrate(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Vibrator.staticClass, global::android.os.Vibrator._vibrate10225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _vibrate10226;
		public virtual void vibrate(long[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Vibrator.staticClass, global::android.os.Vibrator._vibrate10226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Vibrator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Vibrator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Vibrator"));
			global::android.os.Vibrator._cancel10224 = @__env.GetMethodIDNoThrow(global::android.os.Vibrator.staticClass, "cancel", "()V");
			global::android.os.Vibrator._vibrate10225 = @__env.GetMethodIDNoThrow(global::android.os.Vibrator.staticClass, "vibrate", "(J)V");
			global::android.os.Vibrator._vibrate10226 = @__env.GetMethodIDNoThrow(global::android.os.Vibrator.staticClass, "vibrate", "([JI)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
