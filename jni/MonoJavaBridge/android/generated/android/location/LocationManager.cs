namespace android.location
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class LocationManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static LocationManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.LocationManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.location.LocationManager(@__env);
			}
		}
		protected LocationManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProvider4550;
		public virtual global::android.location.LocationProvider getProvider(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.LocationProvider>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.LocationManager._getProvider4550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.LocationProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getProvider4550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProviders4551;
		public virtual global::java.util.List getProviders(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.LocationManager._getProviders4551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getProviders4551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProviders4552;
		public virtual global::java.util.List getProviders(android.location.Criteria arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.LocationManager._getProviders4552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getProviders4552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllProviders4553;
		public virtual global::java.util.List getAllProviders() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.LocationManager._getAllProviders4553));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getAllProviders4553));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBestProvider4554;
		public virtual global::java.lang.String getBestProvider(android.location.Criteria arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.LocationManager._getBestProvider4554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getBestProvider4554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLocationUpdates4555;
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.location.LocationListener arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._requestLocationUpdates4555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._requestLocationUpdates4555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLocationUpdates4556;
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.location.LocationListener arg3, android.os.Looper arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._requestLocationUpdates4556, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._requestLocationUpdates4556, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLocationUpdates4557;
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.app.PendingIntent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._requestLocationUpdates4557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._requestLocationUpdates4557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeUpdates4558;
		public virtual void removeUpdates(android.location.LocationListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._removeUpdates4558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeUpdates4558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeUpdates4559;
		public virtual void removeUpdates(android.app.PendingIntent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._removeUpdates4559, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeUpdates4559, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addProximityAlert4560;
		public virtual void addProximityAlert(double arg0, double arg1, float arg2, long arg3, android.app.PendingIntent arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._addProximityAlert4560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._addProximityAlert4560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeProximityAlert4561;
		public virtual void removeProximityAlert(android.app.PendingIntent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._removeProximityAlert4561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeProximityAlert4561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isProviderEnabled4562;
		public virtual bool isProviderEnabled(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.LocationManager._isProviderEnabled4562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._isProviderEnabled4562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLastKnownLocation4563;
		public virtual global::android.location.Location getLastKnownLocation(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.Location>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.LocationManager._getLastKnownLocation4563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.Location>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getLastKnownLocation4563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addTestProvider4564;
		public virtual void addTestProvider(java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, int arg8, int arg9) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._addTestProvider4564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._addTestProvider4564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeTestProvider4565;
		public virtual void removeTestProvider(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._removeTestProvider4565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeTestProvider4565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTestProviderLocation4566;
		public virtual void setTestProviderLocation(java.lang.String arg0, android.location.Location arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._setTestProviderLocation4566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._setTestProviderLocation4566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearTestProviderLocation4567;
		public virtual void clearTestProviderLocation(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._clearTestProviderLocation4567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._clearTestProviderLocation4567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTestProviderEnabled4568;
		public virtual void setTestProviderEnabled(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._setTestProviderEnabled4568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._setTestProviderEnabled4568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearTestProviderEnabled4569;
		public virtual void clearTestProviderEnabled(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._clearTestProviderEnabled4569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._clearTestProviderEnabled4569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTestProviderStatus4570;
		public virtual void setTestProviderStatus(java.lang.String arg0, int arg1, android.os.Bundle arg2, long arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._setTestProviderStatus4570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._setTestProviderStatus4570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearTestProviderStatus4571;
		public virtual void clearTestProviderStatus(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._clearTestProviderStatus4571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._clearTestProviderStatus4571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addGpsStatusListener4572;
		public virtual bool addGpsStatusListener(android.location.GpsStatus.Listener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.LocationManager._addGpsStatusListener4572, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._addGpsStatusListener4572, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeGpsStatusListener4573;
		public virtual void removeGpsStatusListener(android.location.GpsStatus.Listener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._removeGpsStatusListener4573, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeGpsStatusListener4573, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addNmeaListener4574;
		public virtual bool addNmeaListener(android.location.GpsStatus.NmeaListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.LocationManager._addNmeaListener4574, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._addNmeaListener4574, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeNmeaListener4575;
		public virtual void removeNmeaListener(android.location.GpsStatus.NmeaListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.LocationManager._removeNmeaListener4575, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._removeNmeaListener4575, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGpsStatus4576;
		public virtual global::android.location.GpsStatus getGpsStatus(android.location.GpsStatus arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.GpsStatus>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.LocationManager._getGpsStatus4576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.GpsStatus>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._getGpsStatus4576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendExtraCommand4577;
		public virtual bool sendExtraCommand(java.lang.String arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.LocationManager._sendExtraCommand4577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.LocationManager.staticClass, global::android.location.LocationManager._sendExtraCommand4577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.location.LocationManager.staticClass = @__class;
			global::android.location.LocationManager._getProvider4550 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getProvider", "(Ljava/lang/String;)Landroid/location/LocationProvider;");
			global::android.location.LocationManager._getProviders4551 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getProviders", "(Z)Ljava/util/List;");
			global::android.location.LocationManager._getProviders4552 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getProviders", "(Landroid/location/Criteria;Z)Ljava/util/List;");
			global::android.location.LocationManager._getAllProviders4553 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getAllProviders", "()Ljava/util/List;");
			global::android.location.LocationManager._getBestProvider4554 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getBestProvider", "(Landroid/location/Criteria;Z)Ljava/lang/String;");
			global::android.location.LocationManager._requestLocationUpdates4555 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;)V");
			global::android.location.LocationManager._requestLocationUpdates4556 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;Landroid/os/Looper;)V");
			global::android.location.LocationManager._requestLocationUpdates4557 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/app/PendingIntent;)V");
			global::android.location.LocationManager._removeUpdates4558 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeUpdates", "(Landroid/location/LocationListener;)V");
			global::android.location.LocationManager._removeUpdates4559 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeUpdates", "(Landroid/app/PendingIntent;)V");
			global::android.location.LocationManager._addProximityAlert4560 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "addProximityAlert", "(DDFJLandroid/app/PendingIntent;)V");
			global::android.location.LocationManager._removeProximityAlert4561 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeProximityAlert", "(Landroid/app/PendingIntent;)V");
			global::android.location.LocationManager._isProviderEnabled4562 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "isProviderEnabled", "(Ljava/lang/String;)Z");
			global::android.location.LocationManager._getLastKnownLocation4563 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getLastKnownLocation", "(Ljava/lang/String;)Landroid/location/Location;");
			global::android.location.LocationManager._addTestProvider4564 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "addTestProvider", "(Ljava/lang/String;ZZZZZZZII)V");
			global::android.location.LocationManager._removeTestProvider4565 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeTestProvider", "(Ljava/lang/String;)V");
			global::android.location.LocationManager._setTestProviderLocation4566 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "setTestProviderLocation", "(Ljava/lang/String;Landroid/location/Location;)V");
			global::android.location.LocationManager._clearTestProviderLocation4567 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "clearTestProviderLocation", "(Ljava/lang/String;)V");
			global::android.location.LocationManager._setTestProviderEnabled4568 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "setTestProviderEnabled", "(Ljava/lang/String;Z)V");
			global::android.location.LocationManager._clearTestProviderEnabled4569 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "clearTestProviderEnabled", "(Ljava/lang/String;)V");
			global::android.location.LocationManager._setTestProviderStatus4570 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "setTestProviderStatus", "(Ljava/lang/String;ILandroid/os/Bundle;J)V");
			global::android.location.LocationManager._clearTestProviderStatus4571 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "clearTestProviderStatus", "(Ljava/lang/String;)V");
			global::android.location.LocationManager._addGpsStatusListener4572 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "addGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)Z");
			global::android.location.LocationManager._removeGpsStatusListener4573 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)V");
			global::android.location.LocationManager._addNmeaListener4574 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "addNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)Z");
			global::android.location.LocationManager._removeNmeaListener4575 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)V");
			global::android.location.LocationManager._getGpsStatus4576 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getGpsStatus", "(Landroid/location/GpsStatus;)Landroid/location/GpsStatus;");
			global::android.location.LocationManager._sendExtraCommand4577 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "sendExtraCommand", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Z");
		}
	}
}
