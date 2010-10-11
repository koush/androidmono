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
		internal static global::MonoJavaBridge.MethodId _getName4364;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Sensor._getName4364)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getName4364)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType4365;
		public virtual int getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Sensor._getType4365);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getType4365);
		}
		internal static global::MonoJavaBridge.MethodId _getVersion4366;
		public virtual int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Sensor._getVersion4366);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVersion4366);
		}
		internal static global::MonoJavaBridge.MethodId _getVendor4367;
		public virtual global::java.lang.String getVendor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Sensor._getVendor4367)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVendor4367)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumRange4368;
		public virtual float getMaximumRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Sensor._getMaximumRange4368);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getMaximumRange4368);
		}
		internal static global::MonoJavaBridge.MethodId _getResolution4369;
		public virtual float getResolution() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Sensor._getResolution4369);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getResolution4369);
		}
		internal static global::MonoJavaBridge.MethodId _getPower4370;
		public virtual float getPower() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Sensor._getPower4370);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getPower4370);
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
			global::android.hardware.Sensor._getName4364 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getName", "()Ljava/lang/String;");
			global::android.hardware.Sensor._getType4365 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getType", "()I");
			global::android.hardware.Sensor._getVersion4366 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getVersion", "()I");
			global::android.hardware.Sensor._getVendor4367 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getVendor", "()Ljava/lang/String;");
			global::android.hardware.Sensor._getMaximumRange4368 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getMaximumRange", "()F");
			global::android.hardware.Sensor._getResolution4369 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getResolution", "()F");
			global::android.hardware.Sensor._getPower4370 = @__env.GetMethodIDNoThrow(global::android.hardware.Sensor.staticClass, "getPower", "()F");
		}
	}
}
