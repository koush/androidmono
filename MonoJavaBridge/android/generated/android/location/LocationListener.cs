namespace android.location
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.location.LocationListener_))]
	public partial interface LocationListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onStatusChanged(java.lang.String arg0, int arg1, android.os.Bundle arg2);
		void onLocationChanged(android.location.Location arg0);
		void onProviderEnabled(java.lang.String arg0);
		void onProviderDisabled(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.location.LocationListener))]
	internal sealed partial class LocationListener_ : java.lang.Object, LocationListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LocationListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.location.LocationListener.onStatusChanged(java.lang.String arg0, int arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationListener_.staticClass, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", ref global::android.location.LocationListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.location.LocationListener.onLocationChanged(android.location.Location arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationListener_.staticClass, "onLocationChanged", "(Landroid/location/Location;)V", ref global::android.location.LocationListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.location.LocationListener.onProviderEnabled(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationListener_.staticClass, "onProviderEnabled", "(Ljava/lang/String;)V", ref global::android.location.LocationListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void android.location.LocationListener.onProviderDisabled(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationListener_.staticClass, "onProviderDisabled", "(Ljava/lang/String;)V", ref global::android.location.LocationListener_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static LocationListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
