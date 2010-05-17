namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class GpsSatellite : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GpsSatellite() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.location.GpsSatellite), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.location.GpsSatellite(@__env); 
			} 
		} 
		internal GpsSatellite(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPrn4039; 
		public int getPrn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallIntMethod(this, _getPrn4039); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.location.GpsSatellite.staticClass, _getPrn4039); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSnr4040; 
		public float getSnr() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallFloatMethod(this, _getSnr4040); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.location.GpsSatellite.staticClass, _getSnr4040); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getElevation4041; 
		public float getElevation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallFloatMethod(this, _getElevation4041); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.location.GpsSatellite.staticClass, _getElevation4041); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAzimuth4042; 
		public float getAzimuth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallFloatMethod(this, _getAzimuth4042); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.location.GpsSatellite.staticClass, _getAzimuth4042); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasEphemeris4043; 
		public bool hasEphemeris() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallBooleanMethod(this, _hasEphemeris4043); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.GpsSatellite.staticClass, _hasEphemeris4043); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAlmanac4044; 
		public bool hasAlmanac() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallBooleanMethod(this, _hasAlmanac4044); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.GpsSatellite.staticClass, _hasAlmanac4044); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _usedInFix4045; 
		public bool usedInFix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallBooleanMethod(this, _usedInFix4045); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.GpsSatellite.staticClass, _usedInFix4045); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.GpsSatellite.staticClass = @__class; 
			global::android.location.GpsSatellite._getPrn4039 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getPrn", "()I"); 
			global::android.location.GpsSatellite._getSnr4040 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getSnr", "()F"); 
			global::android.location.GpsSatellite._getElevation4041 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getElevation", "()F"); 
			global::android.location.GpsSatellite._getAzimuth4042 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getAzimuth", "()F"); 
			global::android.location.GpsSatellite._hasEphemeris4043 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "hasEphemeris", "()Z"); 
			global::android.location.GpsSatellite._hasAlmanac4044 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "hasAlmanac", "()Z"); 
			global::android.location.GpsSatellite._usedInFix4045 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "usedInFix", "()Z"); 
		} 
	} 
} 
