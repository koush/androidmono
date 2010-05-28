namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class GpsSatellite : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GpsSatellite() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.GpsSatellite), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getPrn4262; 
		public int getPrn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallIntMethod(this, global::android.location.GpsSatellite._getPrn4262); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getPrn4262); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSnr4263; 
		public float getSnr() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallFloatMethod(this, global::android.location.GpsSatellite._getSnr4263); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getSnr4263); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getElevation4264; 
		public float getElevation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallFloatMethod(this, global::android.location.GpsSatellite._getElevation4264); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getElevation4264); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAzimuth4265; 
		public float getAzimuth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallFloatMethod(this, global::android.location.GpsSatellite._getAzimuth4265); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getAzimuth4265); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasEphemeris4266; 
		public bool hasEphemeris() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallBooleanMethod(this, global::android.location.GpsSatellite._hasEphemeris4266); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasEphemeris4266); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAlmanac4267; 
		public bool hasAlmanac() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallBooleanMethod(this, global::android.location.GpsSatellite._hasAlmanac4267); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasAlmanac4267); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _usedInFix4268; 
		public bool usedInFix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsSatellite)) 
				return @__env.CallBooleanMethod(this, global::android.location.GpsSatellite._usedInFix4268); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._usedInFix4268); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.GpsSatellite.staticClass = @__class; 
			global::android.location.GpsSatellite._getPrn4262 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getPrn", "()I"); 
			global::android.location.GpsSatellite._getSnr4263 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getSnr", "()F"); 
			global::android.location.GpsSatellite._getElevation4264 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getElevation", "()F"); 
			global::android.location.GpsSatellite._getAzimuth4265 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getAzimuth", "()F"); 
			global::android.location.GpsSatellite._hasEphemeris4266 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "hasEphemeris", "()Z"); 
			global::android.location.GpsSatellite._hasAlmanac4267 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "hasAlmanac", "()Z"); 
			global::android.location.GpsSatellite._usedInFix4268 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "usedInFix", "()Z"); 
		} 
	} 
} 
