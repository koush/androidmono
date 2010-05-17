namespace android.hardware 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GeomagneticField : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GeomagneticField() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.hardware.GeomagneticField), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.hardware.GeomagneticField(@__env); 
			} 
		} 
		protected GeomagneticField(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getY3711; 
		public virtual float getY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, _getY3711); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.GeomagneticField.staticClass, _getY3711); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getX3712; 
		public virtual float getX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, _getX3712); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.GeomagneticField.staticClass, _getX3712); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZ3713; 
		public virtual float getZ() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, _getZ3713); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.GeomagneticField.staticClass, _getZ3713); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeclination3714; 
		public virtual float getDeclination() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, _getDeclination3714); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.GeomagneticField.staticClass, _getDeclination3714); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInclination3715; 
		public virtual float getInclination() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, _getInclination3715); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.GeomagneticField.staticClass, _getInclination3715); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalStrength3716; 
		public virtual float getHorizontalStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, _getHorizontalStrength3716); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.GeomagneticField.staticClass, _getHorizontalStrength3716); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFieldStrength3717; 
		public virtual float getFieldStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, _getFieldStrength3717); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.GeomagneticField.staticClass, _getFieldStrength3717); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GeomagneticField3718; 
		public GeomagneticField(float arg0, float arg1, float arg2, long arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.hardware.GeomagneticField.staticClass, _GeomagneticField3718, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.hardware.GeomagneticField.staticClass = @__class; 
			global::android.hardware.GeomagneticField._getY3711 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getY", "()F"); 
			global::android.hardware.GeomagneticField._getX3712 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getX", "()F"); 
			global::android.hardware.GeomagneticField._getZ3713 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getZ", "()F"); 
			global::android.hardware.GeomagneticField._getDeclination3714 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getDeclination", "()F"); 
			global::android.hardware.GeomagneticField._getInclination3715 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getInclination", "()F"); 
			global::android.hardware.GeomagneticField._getHorizontalStrength3716 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getHorizontalStrength", "()F"); 
			global::android.hardware.GeomagneticField._getFieldStrength3717 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getFieldStrength", "()F"); 
			global::android.hardware.GeomagneticField._GeomagneticField3718 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "<init>", "(FFFJ)V"); 
		} 
	} 
} 
