namespace android.hardware 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GeomagneticField : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GeomagneticField() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.GeomagneticField), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getY3922; 
		public virtual float getY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, global::android.hardware.GeomagneticField._getY3922); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getY3922); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getX3923; 
		public virtual float getX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, global::android.hardware.GeomagneticField._getX3923); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getX3923); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZ3924; 
		public virtual float getZ() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, global::android.hardware.GeomagneticField._getZ3924); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getZ3924); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeclination3925; 
		public virtual float getDeclination() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, global::android.hardware.GeomagneticField._getDeclination3925); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getDeclination3925); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInclination3926; 
		public virtual float getInclination() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, global::android.hardware.GeomagneticField._getInclination3926); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getInclination3926); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHorizontalStrength3927; 
		public virtual float getHorizontalStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, global::android.hardware.GeomagneticField._getHorizontalStrength3927); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getHorizontalStrength3927); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFieldStrength3928; 
		public virtual float getFieldStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.GeomagneticField)) 
				return @__env.CallFloatMethod(this, global::android.hardware.GeomagneticField._getFieldStrength3928); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._getFieldStrength3928); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GeomagneticField3929; 
		public GeomagneticField(float arg0, float arg1, float arg2, long arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.hardware.GeomagneticField.staticClass, global::android.hardware.GeomagneticField._GeomagneticField3929, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.hardware.GeomagneticField.staticClass = @__class; 
			global::android.hardware.GeomagneticField._getY3922 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getY", "()F"); 
			global::android.hardware.GeomagneticField._getX3923 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getX", "()F"); 
			global::android.hardware.GeomagneticField._getZ3924 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getZ", "()F"); 
			global::android.hardware.GeomagneticField._getDeclination3925 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getDeclination", "()F"); 
			global::android.hardware.GeomagneticField._getInclination3926 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getInclination", "()F"); 
			global::android.hardware.GeomagneticField._getHorizontalStrength3927 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getHorizontalStrength", "()F"); 
			global::android.hardware.GeomagneticField._getFieldStrength3928 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "getFieldStrength", "()F"); 
			global::android.hardware.GeomagneticField._GeomagneticField3929 = @__env.GetMethodID(global::android.hardware.GeomagneticField.staticClass, "<init>", "(FFFJ)V"); 
		} 
	} 
} 
