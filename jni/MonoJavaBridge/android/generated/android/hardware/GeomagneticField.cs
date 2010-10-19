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
		internal static global::MonoJavaBridge.MethodId _getY4356;
		public virtual float getY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getY4356);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getY4356);
		}
		public new float X
		{
			get
			{
				return getX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getX4357;
		public virtual float getX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getX4357);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getX4357);
		}
		public new float Z
		{
			get
			{
				return getZ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZ4358;
		public virtual float getZ() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getZ4358);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getZ4358);
		}
		public new float Declination
		{
			get
			{
				return getDeclination();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclination4359;
		public virtual float getDeclination() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getDeclination4359);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getDeclination4359);
		}
		public new float Inclination
		{
			get
			{
				return getInclination();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInclination4360;
		public virtual float getInclination() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getInclination4360);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getInclination4360);
		}
		public new float HorizontalStrength
		{
			get
			{
				return getHorizontalStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalStrength4361;
		public virtual float getHorizontalStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getHorizontalStrength4361);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getHorizontalStrength4361);
		}
		public new float FieldStrength
		{
			get
			{
				return getFieldStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldStrength4362;
		public virtual float getFieldStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField._getFieldStrength4362);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getFieldStrength4362);
		}
		internal static global::MonoJavaBridge.MethodId _GeomagneticField4363;
		public GeomagneticField(float arg0, float arg1, float arg2, long arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._GeomagneticField4363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.GeomagneticField.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/GeomagneticField"));
			global::android.hardware.GeomagneticField._getY4356 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getY", "()F");
			global::android.hardware.GeomagneticField._getX4357 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getX", "()F");
			global::android.hardware.GeomagneticField._getZ4358 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getZ", "()F");
			global::android.hardware.GeomagneticField._getDeclination4359 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getDeclination", "()F");
			global::android.hardware.GeomagneticField._getInclination4360 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getInclination", "()F");
			global::android.hardware.GeomagneticField._getHorizontalStrength4361 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getHorizontalStrength", "()F");
			global::android.hardware.GeomagneticField._getFieldStrength4362 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "getFieldStrength", "()F");
			global::android.hardware.GeomagneticField._GeomagneticField4363 = @__env.GetMethodIDNoThrow(global::android.hardware.GeomagneticField.staticClass, "<init>", "(FFFJ)V");
		}
	}
}
