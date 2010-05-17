namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LocationManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LocationManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.location.LocationManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getProvider4089; 
		public virtual android.location.LocationProvider getProvider(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.LocationProvider>(@__env, @__env.CallObjectMethodPtr(this, _getProvider4089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.LocationProvider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.LocationManager.staticClass, _getProvider4089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProviders4090; 
		public virtual java.util.List getProviders(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getProviders4090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.LocationManager.staticClass, _getProviders4090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProviders4091; 
		public virtual java.util.List getProviders(android.location.Criteria arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getProviders4091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.LocationManager.staticClass, _getProviders4091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllProviders4092; 
		public virtual java.util.List getAllProviders() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getAllProviders4092)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.LocationManager.staticClass, _getAllProviders4092)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBestProvider4093; 
		public virtual java.lang.String getBestProvider(android.location.Criteria arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getBestProvider4093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.LocationManager.staticClass, _getBestProvider4093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLocationUpdates4094; 
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.location.LocationListener arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _requestLocationUpdates4094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _requestLocationUpdates4094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLocationUpdates4095; 
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.location.LocationListener arg3, android.os.Looper arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _requestLocationUpdates4095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _requestLocationUpdates4095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLocationUpdates4096; 
		public virtual void requestLocationUpdates(java.lang.String arg0, long arg1, float arg2, android.app.PendingIntent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _requestLocationUpdates4096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _requestLocationUpdates4096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeUpdates4097; 
		public virtual void removeUpdates(android.location.LocationListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _removeUpdates4097, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _removeUpdates4097, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeUpdates4098; 
		public virtual void removeUpdates(android.app.PendingIntent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _removeUpdates4098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _removeUpdates4098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addProximityAlert4099; 
		public virtual void addProximityAlert(double arg0, double arg1, float arg2, long arg3, android.app.PendingIntent arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _addProximityAlert4099, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _addProximityAlert4099, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeProximityAlert4100; 
		public virtual void removeProximityAlert(android.app.PendingIntent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _removeProximityAlert4100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _removeProximityAlert4100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isProviderEnabled4101; 
		public virtual bool isProviderEnabled(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return @__env.CallBooleanMethod(this, _isProviderEnabled4101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.LocationManager.staticClass, _isProviderEnabled4101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLastKnownLocation4102; 
		public virtual android.location.Location getLastKnownLocation(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.Location>(@__env, @__env.CallObjectMethodPtr(this, _getLastKnownLocation4102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.Location>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.LocationManager.staticClass, _getLastKnownLocation4102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTestProvider4103; 
		public virtual void addTestProvider(java.lang.String arg0, bool arg1, bool arg2, bool arg3, bool arg4, bool arg5, bool arg6, bool arg7, int arg8, int arg9) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _addTestProvider4103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _addTestProvider4103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeTestProvider4104; 
		public virtual void removeTestProvider(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _removeTestProvider4104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _removeTestProvider4104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTestProviderLocation4105; 
		public virtual void setTestProviderLocation(java.lang.String arg0, android.location.Location arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _setTestProviderLocation4105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _setTestProviderLocation4105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearTestProviderLocation4106; 
		public virtual void clearTestProviderLocation(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _clearTestProviderLocation4106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _clearTestProviderLocation4106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTestProviderEnabled4107; 
		public virtual void setTestProviderEnabled(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _setTestProviderEnabled4107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _setTestProviderEnabled4107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearTestProviderEnabled4108; 
		public virtual void clearTestProviderEnabled(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _clearTestProviderEnabled4108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _clearTestProviderEnabled4108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTestProviderStatus4109; 
		public virtual void setTestProviderStatus(java.lang.String arg0, int arg1, android.os.Bundle arg2, long arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _setTestProviderStatus4109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _setTestProviderStatus4109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearTestProviderStatus4110; 
		public virtual void clearTestProviderStatus(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _clearTestProviderStatus4110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _clearTestProviderStatus4110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addGpsStatusListener4111; 
		public virtual bool addGpsStatusListener(android.location.GpsStatus.Listener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return @__env.CallBooleanMethod(this, _addGpsStatusListener4111, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.LocationManager.staticClass, _addGpsStatusListener4111, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeGpsStatusListener4112; 
		public virtual void removeGpsStatusListener(android.location.GpsStatus.Listener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _removeGpsStatusListener4112, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _removeGpsStatusListener4112, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addNmeaListener4113; 
		public virtual bool addNmeaListener(android.location.GpsStatus.NmeaListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return @__env.CallBooleanMethod(this, _addNmeaListener4113, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.LocationManager.staticClass, _addNmeaListener4113, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeNmeaListener4114; 
		public virtual void removeNmeaListener(android.location.GpsStatus.NmeaListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				@__env.CallVoidMethod(this, _removeNmeaListener4114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.LocationManager.staticClass, _removeNmeaListener4114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGpsStatus4115; 
		public virtual android.location.GpsStatus getGpsStatus(android.location.GpsStatus arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.GpsStatus>(@__env, @__env.CallObjectMethodPtr(this, _getGpsStatus4115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.location.GpsStatus>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.LocationManager.staticClass, _getGpsStatus4115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendExtraCommand4116; 
		public virtual bool sendExtraCommand(java.lang.String arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.LocationManager)) 
				return @__env.CallBooleanMethod(this, _sendExtraCommand4116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.LocationManager.staticClass, _sendExtraCommand4116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		public static java.lang.String NETWORK_PROVIDER
		{ 
			get 
			{ 
				return "network"; 
			} 
		} 
		public static java.lang.String GPS_PROVIDER
		{ 
			get 
			{ 
				return "gps"; 
			} 
		} 
		public static java.lang.String KEY_PROXIMITY_ENTERING
		{ 
			get 
			{ 
				return "entering"; 
			} 
		} 
		public static java.lang.String KEY_STATUS_CHANGED
		{ 
			get 
			{ 
				return "status"; 
			} 
		} 
		public static java.lang.String KEY_PROVIDER_ENABLED
		{ 
			get 
			{ 
				return "providerEnabled"; 
			} 
		} 
		public static java.lang.String KEY_LOCATION_CHANGED
		{ 
			get 
			{ 
				return "location"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.LocationManager.staticClass = @__class; 
			global::android.location.LocationManager._getProvider4089 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getProvider", "(Ljava/lang/String;)Landroid/location/LocationProvider;"); 
			global::android.location.LocationManager._getProviders4090 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getProviders", "(Z)Ljava/util/List;"); 
			global::android.location.LocationManager._getProviders4091 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getProviders", "(Landroid/location/Criteria;Z)Ljava/util/List;"); 
			global::android.location.LocationManager._getAllProviders4092 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getAllProviders", "()Ljava/util/List;"); 
			global::android.location.LocationManager._getBestProvider4093 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getBestProvider", "(Landroid/location/Criteria;Z)Ljava/lang/String;"); 
			global::android.location.LocationManager._requestLocationUpdates4094 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;)V"); 
			global::android.location.LocationManager._requestLocationUpdates4095 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/location/LocationListener;Landroid/os/Looper;)V"); 
			global::android.location.LocationManager._requestLocationUpdates4096 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "requestLocationUpdates", "(Ljava/lang/String;JFLandroid/app/PendingIntent;)V"); 
			global::android.location.LocationManager._removeUpdates4097 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeUpdates", "(Landroid/location/LocationListener;)V"); 
			global::android.location.LocationManager._removeUpdates4098 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeUpdates", "(Landroid/app/PendingIntent;)V"); 
			global::android.location.LocationManager._addProximityAlert4099 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "addProximityAlert", "(DDFJLandroid/app/PendingIntent;)V"); 
			global::android.location.LocationManager._removeProximityAlert4100 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeProximityAlert", "(Landroid/app/PendingIntent;)V"); 
			global::android.location.LocationManager._isProviderEnabled4101 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "isProviderEnabled", "(Ljava/lang/String;)Z"); 
			global::android.location.LocationManager._getLastKnownLocation4102 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getLastKnownLocation", "(Ljava/lang/String;)Landroid/location/Location;"); 
			global::android.location.LocationManager._addTestProvider4103 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "addTestProvider", "(Ljava/lang/String;ZZZZZZZII)V"); 
			global::android.location.LocationManager._removeTestProvider4104 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeTestProvider", "(Ljava/lang/String;)V"); 
			global::android.location.LocationManager._setTestProviderLocation4105 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "setTestProviderLocation", "(Ljava/lang/String;Landroid/location/Location;)V"); 
			global::android.location.LocationManager._clearTestProviderLocation4106 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "clearTestProviderLocation", "(Ljava/lang/String;)V"); 
			global::android.location.LocationManager._setTestProviderEnabled4107 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "setTestProviderEnabled", "(Ljava/lang/String;Z)V"); 
			global::android.location.LocationManager._clearTestProviderEnabled4108 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "clearTestProviderEnabled", "(Ljava/lang/String;)V"); 
			global::android.location.LocationManager._setTestProviderStatus4109 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "setTestProviderStatus", "(Ljava/lang/String;ILandroid/os/Bundle;J)V"); 
			global::android.location.LocationManager._clearTestProviderStatus4110 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "clearTestProviderStatus", "(Ljava/lang/String;)V"); 
			global::android.location.LocationManager._addGpsStatusListener4111 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "addGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)Z"); 
			global::android.location.LocationManager._removeGpsStatusListener4112 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeGpsStatusListener", "(Landroid/location/GpsStatus$Listener;)V"); 
			global::android.location.LocationManager._addNmeaListener4113 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "addNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)Z"); 
			global::android.location.LocationManager._removeNmeaListener4114 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "removeNmeaListener", "(Landroid/location/GpsStatus$NmeaListener;)V"); 
			global::android.location.LocationManager._getGpsStatus4115 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "getGpsStatus", "(Landroid/location/GpsStatus;)Landroid/location/GpsStatus;"); 
			global::android.location.LocationManager._sendExtraCommand4116 = @__env.GetMethodID(global::android.location.LocationManager.staticClass, "sendExtraCommand", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Z"); 
		} 
	} 
} 
