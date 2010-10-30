namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GpsSatellite : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getPrn6868;
		public int getPrn()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.GpsSatellite._getPrn6868.native == global::System.IntPtr.Zero)
				global::android.location.GpsSatellite._getPrn6868 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getPrn", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getPrn6868);
		}
		public new float Snr
		{
			get
			{
				return getSnr();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSnr6869;
		public float getSnr()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.GpsSatellite._getSnr6869.native == global::System.IntPtr.Zero)
				global::android.location.GpsSatellite._getSnr6869 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getSnr", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getSnr6869);
		}
		public new float Elevation
		{
			get
			{
				return getElevation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getElevation6870;
		public float getElevation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.GpsSatellite._getElevation6870.native == global::System.IntPtr.Zero)
				global::android.location.GpsSatellite._getElevation6870 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getElevation", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getElevation6870);
		}
		public new float Azimuth
		{
			get
			{
				return getAzimuth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAzimuth6871;
		public float getAzimuth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.GpsSatellite._getAzimuth6871.native == global::System.IntPtr.Zero)
				global::android.location.GpsSatellite._getAzimuth6871 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "getAzimuth", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._getAzimuth6871);
		}
		internal static global::MonoJavaBridge.MethodId _hasEphemeris6872;
		public bool hasEphemeris()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.GpsSatellite._hasEphemeris6872.native == global::System.IntPtr.Zero)
				global::android.location.GpsSatellite._hasEphemeris6872 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "hasEphemeris", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasEphemeris6872);
		}
		internal static global::MonoJavaBridge.MethodId _hasAlmanac6873;
		public bool hasAlmanac()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.GpsSatellite._hasAlmanac6873.native == global::System.IntPtr.Zero)
				global::android.location.GpsSatellite._hasAlmanac6873 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "hasAlmanac", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._hasAlmanac6873);
		}
		internal static global::MonoJavaBridge.MethodId _usedInFix6874;
		public bool usedInFix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.GpsSatellite._usedInFix6874.native == global::System.IntPtr.Zero)
				global::android.location.GpsSatellite._usedInFix6874 = @__env.GetMethodIDNoThrow(global::android.location.GpsSatellite.staticClass, "usedInFix", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.GpsSatellite.staticClass, global::android.location.GpsSatellite._usedInFix6874);
		}
		static GpsSatellite()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.GpsSatellite.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsSatellite"));
		}
		internal static void InitJNI()
		{
		}
	}
}
