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
		private static global::MonoJavaBridge.MethodId _m0;
		void android.hardware.SensorEventListener.onSensorChanged(android.hardware.SensorEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.SensorEventListener_.staticClass, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V", ref global::android.hardware.SensorEventListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.hardware.SensorEventListener.onAccuracyChanged(android.hardware.Sensor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.SensorEventListener_.staticClass, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", ref global::android.hardware.SensorEventListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static SensorEventListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorEventListener"));
		}
	}
}
