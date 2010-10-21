namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GeomagneticField : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GeomagneticField()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getY6399;
		public virtual float getY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getY6399);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getY6399);
		}
		public new float X
		{
			get
			{
				return getX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getX6400;
		public virtual float getX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getX6400);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getX6400);
		}
		public new float Z
		{
			get
			{
				return getZ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZ6401;
		public virtual float getZ() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getZ6401);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getZ6401);
		}
		public new float Declination
		{
			get
			{
				return getDeclination();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclination6402;
		public virtual float getDeclination() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getDeclination6402);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getDeclination6402);
		}
		public new float Inclination
		{
			get
			{
				return getInclination();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInclination6403;
		public virtual float getInclination() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getInclination6403);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getInclination6403);
		}
		public new float HorizontalStrength
		{
			get
			{
				return getHorizontalStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalStrength6404;
		public virtual float getHorizontalStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getHorizontalStrength6404);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getHorizontalStrength6404);
		}
		public new float FieldStrength
		{
			get
			{
				return getFieldStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldStrength6405;
		public virtual float getFieldStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getFieldStrength6405);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getFieldStrength6405);
		}
		internal static global::MonoJavaBridge.MethodId _GeomagneticField6406;
		public GeomagneticField(float arg0, float arg1, float arg2, long arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._GeomagneticField6406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.GeomagneticField.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/GeomagneticField"));
			global::android.hardware.GeomagneticField._getY6399 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getY", "()F");
			global::android.hardware.GeomagneticField._getX6400 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getX", "()F");
			global::android.hardware.GeomagneticField._getZ6401 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getZ", "()F");
			global::android.hardware.GeomagneticField._getDeclination6402 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getDeclination", "()F");
			global::android.hardware.GeomagneticField._getInclination6403 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getInclination", "()F");
			global::android.hardware.GeomagneticField._getHorizontalStrength6404 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getHorizontalStrength", "()F");
			global::android.hardware.GeomagneticField._getFieldStrength6405 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getFieldStrength", "()F");
			global::android.hardware.GeomagneticField._GeomagneticField6406 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "<init>", "(FFFJ)V");
		}
	}
}
