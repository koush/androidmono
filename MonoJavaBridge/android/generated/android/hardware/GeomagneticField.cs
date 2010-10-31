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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual float getY()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, "getY", "()F", ref global::android.hardware.GeomagneticField._m0);
		}
		public new float X
		{
			get
			{
				return getX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual float getX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, "getX", "()F", ref global::android.hardware.GeomagneticField._m1);
		}
		public new float Z
		{
			get
			{
				return getZ();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual float getZ()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, "getZ", "()F", ref global::android.hardware.GeomagneticField._m2);
		}
		public new float Declination
		{
			get
			{
				return getDeclination();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual float getDeclination()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, "getDeclination", "()F", ref global::android.hardware.GeomagneticField._m3);
		}
		public new float Inclination
		{
			get
			{
				return getInclination();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual float getInclination()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, "getInclination", "()F", ref global::android.hardware.GeomagneticField._m4);
		}
		public new float HorizontalStrength
		{
			get
			{
				return getHorizontalStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual float getHorizontalStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, "getHorizontalStrength", "()F", ref global::android.hardware.GeomagneticField._m5);
		}
		public new float FieldStrength
		{
			get
			{
				return getFieldStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual float getFieldStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, "getFieldStrength", "()F", ref global::android.hardware.GeomagneticField._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public GeomagneticField(float arg0, float arg1, float arg2, long arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.GeomagneticField._m7.native == global::System.IntPtr.Zero)
				global::android.hardware.GeomagneticField._m7 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "<init>", "(FFFJ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static GeomagneticField()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.GeomagneticField.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/GeomagneticField"));
		}
	}
}
