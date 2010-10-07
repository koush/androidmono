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
		internal static global::net.sf.jni4net.jni.MethodId _getPrn4494;
		public int getPrn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.location.GpsSatellite._getPrn4494);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getPrn4494);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSnr4495;
		public float getSnr() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.location.GpsSatellite._getSnr4495);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getSnr4495);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getElevation4496;
		public float getElevation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.location.GpsSatellite._getElevation4496);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getElevation4496);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAzimuth4497;
		public float getAzimuth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.location.GpsSatellite._getAzimuth4497);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getAzimuth4497);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasEphemeris4498;
		public bool hasEphemeris() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.GpsSatellite._hasEphemeris4498);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasEphemeris4498);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasAlmanac4499;
		public bool hasAlmanac() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.GpsSatellite._hasAlmanac4499);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasAlmanac4499);
		}
		internal static global::net.sf.jni4net.jni.MethodId _usedInFix4500;
		public bool usedInFix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.GpsSatellite._usedInFix4500);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._usedInFix4500);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.location.GpsSatellite.staticClass = @__class;
			global::android.location.GpsSatellite._getPrn4494 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getPrn", "()I");
			global::android.location.GpsSatellite._getSnr4495 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getSnr", "()F");
			global::android.location.GpsSatellite._getElevation4496 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getElevation", "()F");
			global::android.location.GpsSatellite._getAzimuth4497 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "getAzimuth", "()F");
			global::android.location.GpsSatellite._hasEphemeris4498 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "hasEphemeris", "()Z");
			global::android.location.GpsSatellite._hasAlmanac4499 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "hasAlmanac", "()Z");
			global::android.location.GpsSatellite._usedInFix4500 = @__env.GetMethodID(global::android.location.GpsSatellite.staticClass, "usedInFix", "()Z");
		}
	}
}
