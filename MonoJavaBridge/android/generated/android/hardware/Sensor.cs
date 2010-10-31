namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Sensor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Sensor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Sensor.staticClass, "getName", "()Ljava/lang/String;", ref global::android.hardware.Sensor._m0) as java.lang.String;
		}
		public new int Type
		{
			get
			{
				return getType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Sensor.staticClass, "getType", "()I", ref global::android.hardware.Sensor._m1);
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Sensor.staticClass, "getVersion", "()I", ref global::android.hardware.Sensor._m2);
		}
		public new global::java.lang.String Vendor
		{
			get
			{
				return getVendor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getVendor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Sensor.staticClass, "getVendor", "()Ljava/lang/String;", ref global::android.hardware.Sensor._m3) as java.lang.String;
		}
		public new float MaximumRange
		{
			get
			{
				return getMaximumRange();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual float getMaximumRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Sensor.staticClass, "getMaximumRange", "()F", ref global::android.hardware.Sensor._m4);
		}
		public new float Resolution
		{
			get
			{
				return getResolution();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual float getResolution()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Sensor.staticClass, "getResolution", "()F", ref global::android.hardware.Sensor._m5);
		}
		public new float Power
		{
			get
			{
				return getPower();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual float getPower()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Sensor.staticClass, "getPower", "()F", ref global::android.hardware.Sensor._m6);
		}
		public static int TYPE_ACCELEROMETER
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_MAGNETIC_FIELD
		{
			get
			{
				return 2;
			}
		}
		public static int TYPE_ORIENTATION
		{
			get
			{
				return 3;
			}
		}
		public static int TYPE_GYROSCOPE
		{
			get
			{
				return 4;
			}
		}
		public static int TYPE_LIGHT
		{
			get
			{
				return 5;
			}
		}
		public static int TYPE_PRESSURE
		{
			get
			{
				return 6;
			}
		}
		public static int TYPE_TEMPERATURE
		{
			get
			{
				return 7;
			}
		}
		public static int TYPE_PROXIMITY
		{
			get
			{
				return 8;
			}
		}
		public static int TYPE_ALL
		{
			get
			{
				return -1;
			}
		}
		static Sensor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.Sensor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Sensor"));
		}
	}
}
