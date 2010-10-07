namespace android.hardware
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface SensorEventListener 
	{
		void onSensorChanged(android.hardware.SensorEvent arg0);
		void onAccuracyChanged(android.hardware.Sensor arg0, int arg1);
	}

	public partial class SensorEventListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __SensorEventListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __SensorEventListener : java.lang.Object, SensorEventListener
	{
		internal static global::java.lang.Class staticClass;
		static __SensorEventListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.__SensorEventListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.hardware.__SensorEventListener(@__env);
			}
		}
		internal __SensorEventListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSensorChanged4173;
		 void android.hardware.SensorEventListener.onSensorChanged(android.hardware.SensorEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.__SensorEventListener._onSensorChanged4173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.__SensorEventListener.staticClass, global::android.hardware.__SensorEventListener._onSensorChanged4173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAccuracyChanged4174;
		 void android.hardware.SensorEventListener.onAccuracyChanged(android.hardware.Sensor arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.__SensorEventListener._onAccuracyChanged4174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.__SensorEventListener.staticClass, global::android.hardware.__SensorEventListener._onAccuracyChanged4174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.hardware.__SensorEventListener.staticClass = @__class;
			global::android.hardware.__SensorEventListener._onSensorChanged4173 = @__env.GetMethodID(global::android.hardware.__SensorEventListener.staticClass, "android.hardware.SensorEventListener.onSensorChanged", "(Landroid/hardware/SensorEvent;)V");
			global::android.hardware.__SensorEventListener._onAccuracyChanged4174 = @__env.GetMethodID(global::android.hardware.__SensorEventListener.staticClass, "android.hardware.SensorEventListener.onAccuracyChanged", "(Landroid/hardware/Sensor;I)V");
		}
	}
}
