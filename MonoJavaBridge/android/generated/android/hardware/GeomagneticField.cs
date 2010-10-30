namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GeomagneticField : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GeomagneticField(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new float Y
		{
			get
			{
				return getY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getY6424;
		public virtual float getY()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getY6424);
		}
		public new float X
		{
			get
			{
				return getX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getX6425;
		public virtual float getX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getX6425);
		}
		public new float Z
		{
			get
			{
				return getZ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZ6426;
		public virtual float getZ()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getZ6426);
		}
		public new float Declination
		{
			get
			{
				return getDeclination();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclination6427;
		public virtual float getDeclination()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getDeclination6427);
		}
		public new float Inclination
		{
			get
			{
				return getInclination();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInclination6428;
		public virtual float getInclination()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getInclination6428);
		}
		public new float HorizontalStrength
		{
			get
			{
				return getHorizontalStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalStrength6429;
		public virtual float getHorizontalStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getHorizontalStrength6429);
		}
		public new float FieldStrength
		{
			get
			{
				return getFieldStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldStrength6430;
		public virtual float getFieldStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getFieldStrength6430);
		}
		internal static global::MonoJavaBridge.MethodId _GeomagneticField6431;
		public GeomagneticField(float arg0, float arg1, float arg2, long arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._GeomagneticField6431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static GeomagneticField()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.GeomagneticField.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/GeomagneticField"));
			global::android.hardware.GeomagneticField._getY6424 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getY", "()F");
			global::android.hardware.GeomagneticField._getX6425 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getX", "()F");
			global::android.hardware.GeomagneticField._getZ6426 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getZ", "()F");
			global::android.hardware.GeomagneticField._getDeclination6427 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getDeclination", "()F");
			global::android.hardware.GeomagneticField._getInclination6428 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getInclination", "()F");
			global::android.hardware.GeomagneticField._getHorizontalStrength6429 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getHorizontalStrength", "()F");
			global::android.hardware.GeomagneticField._getFieldStrength6430 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getFieldStrength", "()F");
			global::android.hardware.GeomagneticField._GeomagneticField6431 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "<init>", "(FFFJ)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
