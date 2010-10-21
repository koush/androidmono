namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SensorEvent : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SensorEvent()
		{
			InitJNI();
		}
		protected SensorEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _values6423;
		public float[] values
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.GetObjectField(this.JvmHandle, _values6423)) as float[];
			}
		}
		internal static global::MonoJavaBridge.FieldId _sensor6424;
		public global::android.hardware.Sensor sensor
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _sensor6424)) as android.hardware.Sensor;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _accuracy6425;
		public int accuracy
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _accuracy6425);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _timestamp6426;
		public long timestamp
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _timestamp6426);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorEvent"));
			global::android.hardware.SensorEvent._values6423 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "values", "[F");
			global::android.hardware.SensorEvent._sensor6424 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "sensor", "Landroid/hardware/Sensor;");
			global::android.hardware.SensorEvent._accuracy6425 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "accuracy", "I");
			global::android.hardware.SensorEvent._timestamp6426 = @__env.GetFieldIDNoThrow(global::android.hardware.SensorEvent.staticClass, "timestamp", "J");
		}
	}
}
