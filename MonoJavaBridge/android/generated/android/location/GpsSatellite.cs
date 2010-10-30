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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.GpsSatellite.staticClass, "getPrn", "()I", ref global::android.location.GpsSatellite._getPrn6868);
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
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.GpsSatellite.staticClass, "getSnr", "()F", ref global::android.location.GpsSatellite._getSnr6869);
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
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.GpsSatellite.staticClass, "getElevation", "()F", ref global::android.location.GpsSatellite._getElevation6870);
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
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.GpsSatellite.staticClass, "getAzimuth", "()F", ref global::android.location.GpsSatellite._getAzimuth6871);
		}
		internal static global::MonoJavaBridge.MethodId _hasEphemeris6872;
		public bool hasEphemeris()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.GpsSatellite.staticClass, "hasEphemeris", "()Z", ref global::android.location.GpsSatellite._hasEphemeris6872);
		}
		internal static global::MonoJavaBridge.MethodId _hasAlmanac6873;
		public bool hasAlmanac()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.GpsSatellite.staticClass, "hasAlmanac", "()Z", ref global::android.location.GpsSatellite._hasAlmanac6873);
		}
		internal static global::MonoJavaBridge.MethodId _usedInFix6874;
		public bool usedInFix()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.GpsSatellite.staticClass, "usedInFix", "()Z", ref global::android.location.GpsSatellite._usedInFix6874);
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
