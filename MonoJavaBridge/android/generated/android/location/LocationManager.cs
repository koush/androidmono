namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocationManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocationManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.location.LocationProvider getProvider(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.location.LocationManager.staticClass, "getProvider", "(Ljava/lang/String;)Landroid/location/LocationProvider;", ref global::android.location.LocationManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.location.LocationProvider;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.List getProviders(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.location.LocationManager.staticClass, "getProviders", "(Z)Ljava/util/List;", ref global::android.location.LocationManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.List getProviders(android.location.Criteria arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.location.LocationManager.staticClass, "getProviders", "(Landroid/location/Criteria;Z)Ljava/util/List;", ref global::android.location.LocationManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		public new global::java.util.List AllProviders
		{
			get
			{
				return getAllProviders();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.List getAllProviders()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.location.LocationManager.staticClass, "getAllProviders", "()Ljava/util/List;", ref global::android.location.LocationManager._m3) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getBestProvider(android.location.Criteria arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.LocationManager.staticClass, "getBestProvider", "(Landroid/location/Criteria;Z)Ljava/lang/String;", ref global::android.location.LocationManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.location.LocationListener arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;)V", ref global::android.location.LocationManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.location.LocationListener arg3, android.os.Looper arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;Landroid/os/Looper;)V", ref global::android.location.LocationManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.app.PendingIntent arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/app/PendingIntent;)V", ref global::android.location.LocationManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void removeUpdates(android.location.LocationListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "removeUpdates", "(Landroid/location/LocationListener;)V", ref global::android.location.LocationManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void removeUpdates(android.app.PendingIntent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "removeUpdates", "(Landroid/app/PendingIntent;)V", ref global::android.location.LocationManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void addProximityAlert(double arg0, double arg1, float arg2, long arg3, android.app.PendingIntent arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "addProximityAlert", "(DDFJLandroid/app/PendingIntent;)V", ref global::android.location.LocationManager._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void removeProximityAlert(android.app.PendingIntent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "removeProximityAlert", "(Landroid/app/PendingIntent;)V", ref global::android.location.LocationManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isProviderEnabled(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationManager.staticClass, "isProviderEnabled", "(Ljava/lang/String;)Z", ref global::android.location.LocationManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.location.Location getLastKnownLocation(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.location.LocationManager.staticClass, "getLastKnownLocation", "(Ljava/lang/String;)Landroid/location/Location;", ref global::android.location.LocationManager._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.location.Location;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void addTestProvider(java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, int arg8, int arg9)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "addTestProvider", "(Ljava/lang/String;ZZZZZZZII)V", ref global::android.location.LocationManager._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void removeTestProvider(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "removeTestProvider", "(Ljava/lang/String;)V", ref global::android.location.LocationManager._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setTestProviderLocation(java.lang.String arg0, android.location.Location arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "setTestProviderLocation", "(Ljava/lang/String;Landroid/location/Location;)V", ref global::android.location.LocationManager._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void clearTestProviderLocation(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "clearTestProviderLocation", "(Ljava/lang/String;)V", ref global::android.location.LocationManager._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setTestProviderEnabled(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "setTestProviderEnabled", "(Ljava/lang/String;Z)V", ref global::android.location.LocationManager._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void clearTestProviderEnabled(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "clearTestProviderEnabled", "(Ljava/lang/String;)V", ref global::android.location.LocationManager._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setTestProviderStatus(java.lang.String arg0, int arg1, android.os.Bundle arg2, long arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "setTestProviderStatus", "(Ljava/lang/String;ILandroid/os/Bundle;J)V", ref global::android.location.LocationManager._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void clearTestProviderStatus(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "clearTestProviderStatus", "(Ljava/lang/String;)V", ref global::android.location.LocationManager._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool addGpsStatusListener(android.location.GpsStatus.Listener arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationManager.staticClass, "addGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)Z", ref global::android.location.LocationManager._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool addGpsStatusListener(global::android.location.GpsStatus.ListenerDelegate arg0)
		{
			return addGpsStatusListener((global::android.location.GpsStatus.ListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void removeGpsStatusListener(android.location.GpsStatus.Listener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "removeGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)V", ref global::android.location.LocationManager._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeGpsStatusListener(global::android.location.GpsStatus.ListenerDelegate arg0)
		{
			removeGpsStatusListener((global::android.location.GpsStatus.ListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool addNmeaListener(android.location.GpsStatus.NmeaListener arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationManager.staticClass, "addNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)Z", ref global::android.location.LocationManager._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool addNmeaListener(global::android.location.GpsStatus.NmeaListenerDelegate arg0)
		{
			return addNmeaListener((global::android.location.GpsStatus.NmeaListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void removeNmeaListener(android.location.GpsStatus.NmeaListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.LocationManager.staticClass, "removeNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)V", ref global::android.location.LocationManager._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeNmeaListener(global::android.location.GpsStatus.NmeaListenerDelegate arg0)
		{
			removeNmeaListener((global::android.location.GpsStatus.NmeaListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::android.location.GpsStatus getGpsStatus(android.location.GpsStatus arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.location.GpsStatus>(this, global::android.location.LocationManager.staticClass, "getGpsStatus", "(Landroid/location/GpsStatus;)Landroid/location/GpsStatus;", ref global::android.location.LocationManager._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.location.GpsStatus;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool sendExtraCommand(java.lang.String arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationManager.staticClass, "sendExtraCommand", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.location.LocationManager._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static global::java.lang.String NETWORK_PROVIDER
		{
			get
			{
				return "network";
			}
		}
		public static global::java.lang.String GPS_PROVIDER
		{
			get
			{
				return "gps";
			}
		}
		public static global::java.lang.String PASSIVE_PROVIDER
		{
			get
			{
				return "passive";
			}
		}
		public static global::java.lang.String KEY_PROXIMITY_ENTERING
		{
			get
			{
				return "entering";
			}
		}
		public static global::java.lang.String KEY_STATUS_CHANGED
		{
			get
			{
				return "status";
			}
		}
		public static global::java.lang.String KEY_PROVIDER_ENABLED
		{
			get
			{
				return "providerEnabled";
			}
		}
		public static global::java.lang.String KEY_LOCATION_CHANGED
		{
			get
			{
				return "location";
			}
		}
		static LocationManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
