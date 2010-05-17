namespace android.hardware 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Sensor : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Sensor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.hardware.Sensor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getName3719; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName3719)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Sensor.staticClass, _getName3719)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType3720; 
		public virtual int getType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallIntMethod(this, _getType3720); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.hardware.Sensor.staticClass, _getType3720); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVersion3721; 
		public virtual int getVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallIntMethod(this, _getVersion3721); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.hardware.Sensor.staticClass, _getVersion3721); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVendor3722; 
		public virtual java.lang.String getVendor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getVendor3722)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Sensor.staticClass, _getVendor3722)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumRange3723; 
		public virtual float getMaximumRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallFloatMethod(this, _getMaximumRange3723); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.Sensor.staticClass, _getMaximumRange3723); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResolution3724; 
		public virtual float getResolution() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallFloatMethod(this, _getResolution3724); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.Sensor.staticClass, _getResolution3724); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPower3725; 
		public virtual float getPower() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Sensor)) 
				return @__env.CallFloatMethod(this, _getPower3725); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.hardware.Sensor.staticClass, _getPower3725); 
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
			global::android.hardware.Sensor._getName3719 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getName", "()Ljava/lang/String;"); 
			global::android.hardware.Sensor._getType3720 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getType", "()I"); 
			global::android.hardware.Sensor._getVersion3721 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getVersion", "()I"); 
			global::android.hardware.Sensor._getVendor3722 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getVendor", "()Ljava/lang/String;"); 
			global::android.hardware.Sensor._getMaximumRange3723 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getMaximumRange", "()F"); 
			global::android.hardware.Sensor._getResolution3724 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getResolution", "()F"); 
			global::android.hardware.Sensor._getPower3725 = @__env.GetMethodID(global::android.hardware.Sensor.staticClass, "getPower", "()F"); 
		} 
	} 
} 
