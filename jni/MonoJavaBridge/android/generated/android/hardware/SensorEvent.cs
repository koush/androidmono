namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SensorEvent : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SensorEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _values6448;
		public float[] values
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.GetObjectField(this.JvmHandle, _values6448)) as float[];
			}
		}
		internal static global::MonoJavaBridge.FieldId _sensor6449;
		public global::android.hardware.Sensor sensor
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _sensor6449)) as android.hardware.Sensor;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _accuracy6450;
		public int accuracy
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _accuracy6450);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _timestamp6451;
		public long timestamp
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _timestamp6451);
			}
			set
			{
			}
		}
		static SensorEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorEvent"));
			global::android.hardware.SensorEvent._values6448 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "values", "[F");
			global::android.hardware.SensorEvent._sensor6449 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "sensor", "Landroid/hardware/Sensor;");
			global::android.hardware.SensorEvent._accuracy6450 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "accuracy", "I");
			global::android.hardware.SensorEvent._timestamp6451 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "timestamp", "J");
		}
		internal static void InitJNI()
		{
		}
	}
}
