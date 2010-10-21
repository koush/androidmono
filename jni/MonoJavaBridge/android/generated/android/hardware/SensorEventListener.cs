namespace android.hardware
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.SensorEventListener_))]
	public interface SensorEventListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onSensorChanged(android.hardware.SensorEvent arg0);
		void onAccuracyChanged(android.hardware.Sensor arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.SensorEventListener))]
	public sealed partial class SensorEventListener_ : java.lang.Object, SensorEventListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SensorEventListener_()
		{
			InitJNI();
		}
		internal SensorEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onSensorChanged6427;
		 void android.hardware.SensorEventListener.onSensorChanged(android.hardware.SensorEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorEventListener_._onSensorChanged6427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.SensorEventListener_.staticClass, global::android.hardware.SensorEventListener_._onSensorChanged6427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAccuracyChanged6428;
		 void android.hardware.SensorEventListener.onAccuracyChanged(android.hardware.Sensor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorEventListener_._onAccuracyChanged6428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.SensorEventListener_.staticClass, global::android.hardware.SensorEventListener_._onAccuracyChanged6428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorEventListener"));
			global::android.hardware.SensorEventListener_._onSensorChanged6427 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorEventListener_.staticClass, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V");
			global::android.hardware.SensorEventListener_._onAccuracyChanged6428 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorEventListener_.staticClass, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V");
		}
	}
}
