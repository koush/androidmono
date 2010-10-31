namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SensorEvent : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SensorEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _values2497;
		public float[] values
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.GetObjectField(this.JvmHandle, _values2497)) as float[];
			}
		}
		internal static global::MonoJavaBridge.FieldId _sensor2498;
		public global::android.hardware.Sensor sensor
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _sensor2498)) as android.hardware.Sensor;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _accuracy2499;
		public int accuracy
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _accuracy2499);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _timestamp2500;
		public long timestamp
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _timestamp2500);
			}
			set
			{
			}
		}
		static SensorEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorEvent"));
			global::android.hardware.SensorEvent._values2497 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "values", "[F");
			global::android.hardware.SensorEvent._sensor2498 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "sensor", "Landroid/hardware/Sensor;");
			global::android.hardware.SensorEvent._accuracy2499 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "accuracy", "I");
			global::android.hardware.SensorEvent._timestamp2500 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "timestamp", "J");
		}
	}
}
