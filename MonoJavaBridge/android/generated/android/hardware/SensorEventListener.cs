namespace android.hardware
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.SensorEventListener_))]
	public partial interface SensorEventListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onSensorChanged(android.hardware.SensorEvent arg0);
		void onAccuracyChanged(android.hardware.Sensor arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.SensorEventListener))]
	internal sealed partial class SensorEventListener_ : java.lang.Object, SensorEventListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SensorEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onSensorChanged6452;
		void android.hardware.SensorEventListener.onSensorChanged(android.hardware.SensorEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorEventListener_._onSensorChanged6452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAccuracyChanged6453;
		void android.hardware.SensorEventListener.onAccuracyChanged(android.hardware.Sensor arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorEventListener_._onAccuracyChanged6453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static SensorEventListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorEventListener"));
			global::android.hardware.SensorEventListener_._onSensorChanged6452 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorEventListener_.staticClass, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V");
			global::android.hardware.SensorEventListener_._onAccuracyChanged6453 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorEventListener_.staticClass, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
