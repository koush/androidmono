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
		internal static global::MonoJavaBridge.MethodId _getName6432;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.Sensor._getName6432.native == global::System.IntPtr.Zero)
				global::android.hardware.Sensor._getName6432 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getName6432) as java.lang.String;
		}
		public new int Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType6433;
		public virtual int getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.Sensor._getType6433.native == global::System.IntPtr.Zero)
				global::android.hardware.Sensor._getType6433 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getType", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getType6433);
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion6434;
		public virtual int getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.Sensor._getVersion6434.native == global::System.IntPtr.Zero)
				global::android.hardware.Sensor._getVersion6434 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getVersion", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVersion6434);
		}
		public new global::java.lang.String Vendor
		{
			get
			{
				return getVendor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVendor6435;
		public virtual global::java.lang.String getVendor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.Sensor._getVendor6435.native == global::System.IntPtr.Zero)
				global::android.hardware.Sensor._getVendor6435 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getVendor", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVendor6435) as java.lang.String;
		}
		public new float MaximumRange
		{
			get
			{
				return getMaximumRange();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumRange6436;
		public virtual float getMaximumRange()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.Sensor._getMaximumRange6436.native == global::System.IntPtr.Zero)
				global::android.hardware.Sensor._getMaximumRange6436 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getMaximumRange", "()F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getMaximumRange6436);
		}
		public new float Resolution
		{
			get
			{
				return getResolution();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResolution6437;
		public virtual float getResolution()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.Sensor._getResolution6437.native == global::System.IntPtr.Zero)
				global::android.hardware.Sensor._getResolution6437 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getResolution", "()F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getResolution6437);
		}
		public new float Power
		{
			get
			{
				return getPower();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPower6438;
		public virtual float getPower()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.Sensor._getPower6438.native == global::System.IntPtr.Zero)
				global::android.hardware.Sensor._getPower6438 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getPower", "()F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getPower6438);
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
		internal static void InitJNI()
		{
		}
	}
}
