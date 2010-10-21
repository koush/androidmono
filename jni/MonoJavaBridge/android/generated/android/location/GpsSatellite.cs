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
		public new int Prn
		{
			get
			{
				return getPrn();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrn6843;
		public int getPrn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.GpsSatellite._getPrn6843);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getPrn6843);
		}
		public new float Snr
		{
			get
			{
				return getSnr();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSnr6844;
		public float getSnr() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.GpsSatellite._getSnr6844);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getSnr6844);
		}
		public new float Elevation
		{
			get
			{
				return getElevation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getElevation6845;
		public float getElevation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.GpsSatellite._getElevation6845);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getElevation6845);
		}
		public new float Azimuth
		{
			get
			{
				return getAzimuth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAzimuth6846;
		public float getAzimuth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.GpsSatellite._getAzimuth6846);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getAzimuth6846);
		}
		internal static global::MonoJavaBridge.MethodId _hasEphemeris6847;
		public bool hasEphemeris() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite._hasEphemeris6847);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasEphemeris6847);
		}
		internal static global::MonoJavaBridge.MethodId _hasAlmanac6848;
		public bool hasAlmanac() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite._hasAlmanac6848);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasAlmanac6848);
		}
		internal static global::MonoJavaBridge.MethodId _usedInFix6849;
		public bool usedInFix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite._usedInFix6849);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._usedInFix6849);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.GpsSatellite.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsSatellite"));
			global::android.location.GpsSatellite._getPrn6843 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getPrn", "()I");
			global::android.location.GpsSatellite._getSnr6844 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getSnr", "()F");
			global::android.location.GpsSatellite._getElevation6845 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getElevation", "()F");
			global::android.location.GpsSatellite._getAzimuth6846 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getAzimuth", "()F");
			global::android.location.GpsSatellite._hasEphemeris6847 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "hasEphemeris", "()Z");
			global::android.location.GpsSatellite._hasAlmanac6848 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "hasAlmanac", "()Z");
			global::android.location.GpsSatellite._usedInFix6849 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "usedInFix", "()Z");
		}
	}
}
