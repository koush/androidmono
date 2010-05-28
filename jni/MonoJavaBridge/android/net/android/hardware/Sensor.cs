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
		internal static global::net.sf.jni4net.jni.MethodId _getName3930; 
		public virtual global::java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Sensor._getName3930)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getName3930)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType3931; 
		public virtual int getType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallIntMethod(this, global::android.hardware.Sensor._getType3931); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getType3931); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVersion3932; 
		public virtual int getVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallIntMethod(this, global::android.hardware.Sensor._getVersion3932); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVersion3932); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVendor3933; 
		public virtual global::java.lang.String getVendor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Sensor._getVendor3933)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getVendor3933)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumRange3934; 
		public virtual float getMaximumRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallFloatMethod(this, global::android.hardware.Sensor._getMaximumRange3934); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getMaximumRange3934); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResolution3935; 
		public virtual float getResolution() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallFloatMethod(this, global::android.hardware.Sensor._getResolution3935); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getResolution3935); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPower3936; 
		public virtual float getPower() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallFloatMethod(this, global::android.hardware.Sensor._getPower3936); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Sensor.staticClass, global::android.hardware.Sensor._getPower3936); 
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
			global::android.hardware.Sensor._getName3930 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getName", "()Ljava/lang/String;"); 
			global::android.hardware.Sensor._getType3931 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getType", "()I"); 
			global::android.hardware.Sensor._getVersion3932 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getVersion", "()I"); 
			global::android.hardware.Sensor._getVendor3933 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getVendor", "()Ljava/lang/String;"); 
			global::android.hardware.Sensor._getMaximumRange3934 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getMaximumRange", "()F"); 
			global::android.hardware.Sensor._getResolution3935 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getResolution", "()F"); 
			global::android.hardware.Sensor._getPower3936 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getPower", "()F"); 
		} 
	} 
} 
