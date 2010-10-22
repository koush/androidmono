namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Sensor : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Sensor()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getName6407;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Sensor._getName6407)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getName6407)) as java.lang.String;
		}
		public new int Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType6408;
		public virtual int getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Sensor._getType6408);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getType6408);
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion6409;
		public virtual int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Sensor._getVersion6409);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVersion6409);
		}
		public new global::java.lang.String Vendor
		{
			get
			{
				return getVendor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVendor6410;
		public virtual global::java.lang.String getVendor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Sensor._getVendor6410)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVendor6410)) as java.lang.String;
		}
		public new float MaximumRange
		{
			get
			{
				return getMaximumRange();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumRange6411;
		public virtual float getMaximumRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Sensor._getMaximumRange6411);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getMaximumRange6411);
		}
		public new float Resolution
		{
			get
			{
				return getResolution();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResolution6412;
		public virtual float getResolution() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Sensor._getResolution6412);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getResolution6412);
		}
		public new float Power
		{
			get
			{
				return getPower();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPower6413;
		public virtual float getPower() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Sensor._getPower6413);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getPower6413);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.Sensor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Sensor"));
			global::android.hardware.Sensor._getName6407 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getName", "()Ljava/lang/String;");
			global::android.hardware.Sensor._getType6408 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getType", "()I");
			global::android.hardware.Sensor._getVersion6409 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getVersion", "()I");
			global::android.hardware.Sensor._getVendor6410 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getVendor", "()Ljava/lang/String;");
			global::android.hardware.Sensor._getMaximumRange6411 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getMaximumRange", "()F");
			global::android.hardware.Sensor._getResolution6412 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getResolution", "()F");
			global::android.hardware.Sensor._getPower6413 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getPower", "()F");
		}
	}
}
