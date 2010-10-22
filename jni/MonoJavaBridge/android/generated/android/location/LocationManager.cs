namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocationManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocationManager()
		{
			InitJNI();
		}
		protected LocationManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProvider6906;
		public virtual global::android.location.LocationProvider getProvider(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationManager._getProvider6906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.location.LocationProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getProvider6906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.location.LocationProvider;
		}
		internal static global::MonoJavaBridge.MethodId _getProviders6907;
		public virtual global::java.util.List getProviders(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationManager._getProviders6907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getProviders6907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getProviders6908;
		public virtual global::java.util.List getProviders(android.location.Criteria arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationManager._getProviders6908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getProviders6908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		public new global::java.util.List AllProviders
		{
			get
			{
				return getAllProviders();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllProviders6909;
		public virtual global::java.util.List getAllProviders() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationManager._getAllProviders6909)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getAllProviders6909)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getBestProvider6910;
		public virtual global::java.lang.String getBestProvider(android.location.Criteria arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationManager._getBestProvider6910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getBestProvider6910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _requestLocationUpdates6911;
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.location.LocationListener arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._requestLocationUpdates6911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._requestLocationUpdates6911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _requestLocationUpdates6912;
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.location.LocationListener arg3, android.os.Looper arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._requestLocationUpdates6912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._requestLocationUpdates6912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLocationUpdates6913;
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.app.PendingIntent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._requestLocationUpdates6913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._requestLocationUpdates6913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeUpdates6914;
		public virtual void removeUpdates(android.location.LocationListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._removeUpdates6914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeUpdates6914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeUpdates6915;
		public virtual void removeUpdates(android.app.PendingIntent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._removeUpdates6915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeUpdates6915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addProximityAlert6916;
		public virtual void addProximityAlert(double arg0, double arg1, float arg2, long arg3, android.app.PendingIntent arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._addProximityAlert6916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._addProximityAlert6916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _removeProximityAlert6917;
		public virtual void removeProximityAlert(android.app.PendingIntent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._removeProximityAlert6917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeProximityAlert6917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isProviderEnabled6918;
		public virtual bool isProviderEnabled(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationManager._isProviderEnabled6918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._isProviderEnabled6918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLastKnownLocation6919;
		public virtual global::android.location.Location getLastKnownLocation(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationManager._getLastKnownLocation6919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.location.Location;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getLastKnownLocation6919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.location.Location;
		}
		internal static global::MonoJavaBridge.MethodId _addTestProvider6920;
		public virtual void addTestProvider(java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, int arg8, int arg9) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._addTestProvider6920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._addTestProvider6920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
		}
		internal static global::MonoJavaBridge.MethodId _removeTestProvider6921;
		public virtual void removeTestProvider(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._removeTestProvider6921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeTestProvider6921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTestProviderLocation6922;
		public virtual void setTestProviderLocation(java.lang.String arg0, android.location.Location arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._setTestProviderLocation6922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._setTestProviderLocation6922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearTestProviderLocation6923;
		public virtual void clearTestProviderLocation(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._clearTestProviderLocation6923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._clearTestProviderLocation6923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTestProviderEnabled6924;
		public virtual void setTestProviderEnabled(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._setTestProviderEnabled6924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._setTestProviderEnabled6924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearTestProviderEnabled6925;
		public virtual void clearTestProviderEnabled(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._clearTestProviderEnabled6925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._clearTestProviderEnabled6925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTestProviderStatus6926;
		public virtual void setTestProviderStatus(java.lang.String arg0, int arg1, android.os.Bundle arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._setTestProviderStatus6926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._setTestProviderStatus6926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clearTestProviderStatus6927;
		public virtual void clearTestProviderStatus(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._clearTestProviderStatus6927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._clearTestProviderStatus6927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addGpsStatusListener6928;
		public virtual bool addGpsStatusListener(android.location.GpsStatus.Listener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationManager._addGpsStatusListener6928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._addGpsStatusListener6928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGpsStatusListener6929;
		public virtual void removeGpsStatusListener(android.location.GpsStatus.Listener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._removeGpsStatusListener6929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeGpsStatusListener6929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addNmeaListener6930;
		public virtual bool addNmeaListener(android.location.GpsStatus.NmeaListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationManager._addNmeaListener6930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._addNmeaListener6930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNmeaListener6931;
		public virtual void removeNmeaListener(android.location.GpsStatus.NmeaListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationManager._removeNmeaListener6931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeNmeaListener6931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGpsStatus6932;
		public virtual global::android.location.GpsStatus getGpsStatus(android.location.GpsStatus arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.location.GpsStatus>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationManager._getGpsStatus6932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.location.GpsStatus;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.location.GpsStatus>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getGpsStatus6932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.location.GpsStatus;
		}
		internal static global::MonoJavaBridge.MethodId _sendExtraCommand6933;
		public virtual bool sendExtraCommand(java.lang.String arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationManager._sendExtraCommand6933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._sendExtraCommand6933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationManager"));
			global::android.location.LocationManager._getProvider6906 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "getProvider", "(Ljava/lang/String;)Landroid/location/LocationProvider;");
			global::android.location.LocationManager._getProviders6907 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "getProviders", "(Z)Ljava/util/List;");
			global::android.location.LocationManager._getProviders6908 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "getProviders", "(Landroid/location/Criteria;Z)Ljava/util/List;");
			global::android.location.LocationManager._getAllProviders6909 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "getAllProviders", "()Ljava/util/List;");
			global::android.location.LocationManager._getBestProvider6910 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "getBestProvider", "(Landroid/location/Criteria;Z)Ljava/lang/String;");
			global::android.location.LocationManager._requestLocationUpdates6911 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;)V");
			global::android.location.LocationManager._requestLocationUpdates6912 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;Landroid/os/Looper;)V");
			global::android.location.LocationManager._requestLocationUpdates6913 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/app/PendingIntent;)V");
			global::android.location.LocationManager._removeUpdates6914 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "removeUpdates", "(Landroid/location/LocationListener;)V");
			global::android.location.LocationManager._removeUpdates6915 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "removeUpdates", "(Landroid/app/PendingIntent;)V");
			global::android.location.LocationManager._addProximityAlert6916 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "addProximityAlert", "(DDFJLandroid/app/PendingIntent;)V");
			global::android.location.LocationManager._removeProximityAlert6917 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "removeProximityAlert", "(Landroid/app/PendingIntent;)V");
			global::android.location.LocationManager._isProviderEnabled6918 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "isProviderEnabled", "(Ljava/lang/String;)Z");
			global::android.location.LocationManager._getLastKnownLocation6919 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "getLastKnownLocation", "(Ljava/lang/String;)Landroid/location/Location;");
			global::android.location.LocationManager._addTestProvider6920 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "addTestProvider", "(Ljava/lang/String;ZZZZZZZII)V");
			global::android.location.LocationManager._removeTestProvider6921 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "removeTestProvider", "(Ljava/lang/String;)V");
			global::android.location.LocationManager._setTestProviderLocation6922 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "setTestProviderLocation", "(Ljava/lang/String;Landroid/location/Location;)V");
			global::android.location.LocationManager._clearTestProviderLocation6923 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "clearTestProviderLocation", "(Ljava/lang/String;)V");
			global::android.location.LocationManager._setTestProviderEnabled6924 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "setTestProviderEnabled", "(Ljava/lang/String;Z)V");
			global::android.location.LocationManager._clearTestProviderEnabled6925 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "clearTestProviderEnabled", "(Ljava/lang/String;)V");
			global::android.location.LocationManager._setTestProviderStatus6926 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "setTestProviderStatus", "(Ljava/lang/String;ILandroid/os/Bundle;J)V");
			global::android.location.LocationManager._clearTestProviderStatus6927 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "clearTestProviderStatus", "(Ljava/lang/String;)V");
			global::android.location.LocationManager._addGpsStatusListener6928 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "addGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)Z");
			global::android.location.LocationManager._removeGpsStatusListener6929 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "removeGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)V");
			global::android.location.LocationManager._addNmeaListener6930 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "addNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)Z");
			global::android.location.LocationManager._removeNmeaListener6931 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "removeNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)V");
			global::android.location.LocationManager._getGpsStatus6932 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "getGpsStatus", "(Landroid/location/GpsStatus;)Landroid/location/GpsStatus;");
			global::android.location.LocationManager._sendExtraCommand6933 = @__env.GetMethodIDNoThrow(global::android.location.LocationManager.staticClass, "sendExtraCommand", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Z");
		}
	}
}
