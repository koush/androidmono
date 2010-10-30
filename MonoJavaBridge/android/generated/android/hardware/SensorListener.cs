namespace android.hardware
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.SensorListener_))]
	public partial interface SensorListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onSensorChanged(int arg0, float[] arg1);
		void onAccuracyChanged(int arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.SensorListener))]
	internal sealed partial class SensorListener_ : java.lang.Object, SensorListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SensorListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onSensorChanged6454;
		void android.hardware.SensorListener.onSensorChanged(int arg0, float[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorListener_._onSensorChanged6454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onAccuracyChanged6455;
		void android.hardware.SensorListener.onAccuracyChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorListener_._onAccuracyChanged6455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static SensorListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorListener"));
			global::android.hardware.SensorListener_._onSensorChanged6454 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorListener_.staticClass, "onSensorChanged", "(I[F)V");
			global::android.hardware.SensorListener_._onAccuracyChanged6455 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorListener_.staticClass, "onAccuracyChanged", "(II)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
