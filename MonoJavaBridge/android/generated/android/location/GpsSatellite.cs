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
		private static global::MonoJavaBridge.MethodId _m0;
		public int getPrn()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.GpsSatellite.staticClass, "getPrn", "()I", ref global::android.location.GpsSatellite._m0);
		}
		public new float Snr
		{
			get
			{
				return getSnr();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public float getSnr()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.GpsSatellite.staticClass, "getSnr", "()F", ref global::android.location.GpsSatellite._m1);
		}
		public new float Elevation
		{
			get
			{
				return getElevation();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public float getElevation()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.GpsSatellite.staticClass, "getElevation", "()F", ref global::android.location.GpsSatellite._m2);
		}
		public new float Azimuth
		{
			get
			{
				return getAzimuth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public float getAzimuth()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.GpsSatellite.staticClass, "getAzimuth", "()F", ref global::android.location.GpsSatellite._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public bool hasEphemeris()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.GpsSatellite.staticClass, "hasEphemeris", "()Z", ref global::android.location.GpsSatellite._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool hasAlmanac()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.GpsSatellite.staticClass, "hasAlmanac", "()Z", ref global::android.location.GpsSatellite._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool usedInFix()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.GpsSatellite.staticClass, "usedInFix", "()Z", ref global::android.location.GpsSatellite._m6);
		}
		static GpsSatellite()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.GpsSatellite.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsSatellite"));
		}
	}
}
