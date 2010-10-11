namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GpsSatellite : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GpsSatellite()
		{
			InitJNI();
		}
		internal GpsSatellite(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPrn4716;
		public int getPrn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.GpsSatellite._getPrn4716);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getPrn4716);
		}
		internal static global::MonoJavaBridge.MethodId _getSnr4717;
		public float getSnr() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.GpsSatellite._getSnr4717);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getSnr4717);
		}
		internal static global::MonoJavaBridge.MethodId _getElevation4718;
		public float getElevation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.GpsSatellite._getElevation4718);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getElevation4718);
		}
		internal static global::MonoJavaBridge.MethodId _getAzimuth4719;
		public float getAzimuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.GpsSatellite._getAzimuth4719);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getAzimuth4719);
		}
		internal static global::MonoJavaBridge.MethodId _hasEphemeris4720;
		public bool hasEphemeris() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite._hasEphemeris4720);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasEphemeris4720);
		}
		internal static global::MonoJavaBridge.MethodId _hasAlmanac4721;
		public bool hasAlmanac() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite._hasAlmanac4721);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasAlmanac4721);
		}
		internal static global::MonoJavaBridge.MethodId _usedInFix4722;
		public bool usedInFix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite._usedInFix4722);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._usedInFix4722);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.GpsSatellite.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsSatellite"));
			global::android.location.GpsSatellite._getPrn4716 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getPrn", "()I");
			global::android.location.GpsSatellite._getSnr4717 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getSnr", "()F");
			global::android.location.GpsSatellite._getElevation4718 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getElevation", "()F");
			global::android.location.GpsSatellite._getAzimuth4719 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getAzimuth", "()F");
			global::android.location.GpsSatellite._hasEphemeris4720 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "hasEphemeris", "()Z");
			global::android.location.GpsSatellite._hasAlmanac4721 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "hasAlmanac", "()Z");
			global::android.location.GpsSatellite._usedInFix4722 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "usedInFix", "()Z");
		}
	}
}
