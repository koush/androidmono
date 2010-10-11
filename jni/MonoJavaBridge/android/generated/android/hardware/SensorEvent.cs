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
		internal static global::MonoJavaBridge.FieldId _values4371;
		public float[] values
		{
			get
			{
				return default(float[]);
			}
		}
		internal static global::MonoJavaBridge.FieldId _sensor4372;
		public global::android.hardware.Sensor sensor
		{
			get
			{
				return default(global::android.hardware.Sensor);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _accuracy4373;
		public int accuracy
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _timestamp4374;
		public long timestamp
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorEvent"));
		}
	}
}
