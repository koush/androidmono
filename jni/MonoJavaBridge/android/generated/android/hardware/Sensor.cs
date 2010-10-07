namespace android.hardware
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Sensor : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Sensor()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Sensor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.hardware.Sensor(@__env);
			}
		}
		protected Sensor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName4162;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Sensor._getName4162));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getName4162));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getType4163;
		public virtual int getType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.hardware.Sensor._getType4163);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getType4163);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVersion4164;
		public virtual int getVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.hardware.Sensor._getVersion4164);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVersion4164);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVendor4165;
		public virtual global::java.lang.String getVendor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Sensor._getVendor4165));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVendor4165));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumRange4166;
		public virtual float getMaximumRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.hardware.Sensor._getMaximumRange4166);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getMaximumRange4166);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResolution4167;
		public virtual float getResolution() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.hardware.Sensor._getResolution4167);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getResolution4167);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPower4168;
		public virtual float getPower() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.hardware.Sensor._getPower4168);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getPower4168);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.hardware.Sensor.staticClass = @__class;
			global::android.hardware.Sensor._getName4162 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getName", "()Ljava/lang/String;");
			global::android.hardware.Sensor._getType4163 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getType", "()I");
			global::android.hardware.Sensor._getVersion4164 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getVersion", "()I");
			global::android.hardware.Sensor._getVendor4165 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getVendor", "()Ljava/lang/String;");
			global::android.hardware.Sensor._getMaximumRange4166 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getMaximumRange", "()F");
			global::android.hardware.Sensor._getResolution4167 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getResolution", "()F");
			global::android.hardware.Sensor._getPower4168 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getPower", "()F");
		}
	}
}
