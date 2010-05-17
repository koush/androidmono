namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ConnectivityManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ConnectivityManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.ConnectivityManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.ConnectivityManager(@__env); 
			} 
		} 
		protected ConnectivityManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNetworkTypeValid4364; 
		public static bool isNetworkTypeValid(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.net.ConnectivityManager.staticClass, _isNetworkTypeValid4364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNetworkPreference4365; 
		public virtual void setNetworkPreference(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.ConnectivityManager)) 
				@__env.CallVoidMethod(this, _setNetworkPreference4365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.ConnectivityManager.staticClass, _setNetworkPreference4365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkPreference4366; 
		public virtual int getNetworkPreference() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.ConnectivityManager)) 
				return @__env.CallIntMethod(this, _getNetworkPreference4366); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.ConnectivityManager.staticClass, _getNetworkPreference4366); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActiveNetworkInfo4367; 
		public virtual android.net.NetworkInfo getActiveNetworkInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.ConnectivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo>(@__env, @__env.CallObjectMethodPtr(this, _getActiveNetworkInfo4367)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.ConnectivityManager.staticClass, _getActiveNetworkInfo4367)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkInfo4368; 
		public virtual android.net.NetworkInfo getNetworkInfo(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.ConnectivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo>(@__env, @__env.CallObjectMethodPtr(this, _getNetworkInfo4368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.ConnectivityManager.staticClass, _getNetworkInfo4368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllNetworkInfo4369; 
		public virtual android.net.NetworkInfo[] getAllNetworkInfo() 
		{ 
			if (GetType() == typeof(android.net.ConnectivityManager)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getAllNetworkInfo4369)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.ConnectivityManager.staticClass, _getAllNetworkInfo4369)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startUsingNetworkFeature4370; 
		public virtual int startUsingNetworkFeature(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.ConnectivityManager)) 
				return @__env.CallIntMethod(this, _startUsingNetworkFeature4370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.ConnectivityManager.staticClass, _startUsingNetworkFeature4370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopUsingNetworkFeature4371; 
		public virtual int stopUsingNetworkFeature(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.ConnectivityManager)) 
				return @__env.CallIntMethod(this, _stopUsingNetworkFeature4371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.ConnectivityManager.staticClass, _stopUsingNetworkFeature4371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestRouteToHost4372; 
		public virtual bool requestRouteToHost(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.ConnectivityManager)) 
				return @__env.CallBooleanMethod(this, _requestRouteToHost4372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.ConnectivityManager.staticClass, _requestRouteToHost4372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBackgroundDataSetting4373; 
		public virtual bool getBackgroundDataSetting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.ConnectivityManager)) 
				return @__env.CallBooleanMethod(this, _getBackgroundDataSetting4373); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.ConnectivityManager.staticClass, _getBackgroundDataSetting4373); 
		} 
		public static java.lang.String CONNECTIVITY_ACTION
		{ 
			get 
			{ 
				return "android.net.conn.CONNECTIVITY_CHANGE"; 
			} 
		} 
		public static java.lang.String EXTRA_NETWORK_INFO
		{ 
			get 
			{ 
				return "networkInfo"; 
			} 
		} 
		public static java.lang.String EXTRA_IS_FAILOVER
		{ 
			get 
			{ 
				return "isFailover"; 
			} 
		} 
		public static java.lang.String EXTRA_OTHER_NETWORK_INFO
		{ 
			get 
			{ 
				return "otherNetwork"; 
			} 
		} 
		public static java.lang.String EXTRA_NO_CONNECTIVITY
		{ 
			get 
			{ 
				return "noConnectivity"; 
			} 
		} 
		public static java.lang.String EXTRA_REASON
		{ 
			get 
			{ 
				return "reason"; 
			} 
		} 
		public static java.lang.String EXTRA_EXTRA_INFO
		{ 
			get 
			{ 
				return "extraInfo"; 
			} 
		} 
		public static java.lang.String ACTION_BACKGROUND_DATA_SETTING_CHANGED
		{ 
			get 
			{ 
				return "android.net.conn.BACKGROUND_DATA_SETTING_CHANGED"; 
			} 
		} 
		public static int TYPE_MOBILE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int TYPE_WIFI
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int DEFAULT_NETWORK_PREFERENCE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.ConnectivityManager.staticClass = @__class; 
			global::android.net.ConnectivityManager._isNetworkTypeValid4364 = @__env.GetStaticMethodID(global::android.net.ConnectivityManager.staticClass, "isNetworkTypeValid", "(I)Z"); 
			global::android.net.ConnectivityManager._setNetworkPreference4365 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "setNetworkPreference", "(I)V"); 
			global::android.net.ConnectivityManager._getNetworkPreference4366 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getNetworkPreference", "()I"); 
			global::android.net.ConnectivityManager._getActiveNetworkInfo4367 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getActiveNetworkInfo", "()Landroid/net/NetworkInfo;"); 
			global::android.net.ConnectivityManager._getNetworkInfo4368 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getNetworkInfo", "(I)Landroid/net/NetworkInfo;"); 
			global::android.net.ConnectivityManager._getAllNetworkInfo4369 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getAllNetworkInfo", "()[Landroid/net/NetworkInfo;"); 
			global::android.net.ConnectivityManager._startUsingNetworkFeature4370 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "startUsingNetworkFeature", "(ILjava/lang/String;)I"); 
			global::android.net.ConnectivityManager._stopUsingNetworkFeature4371 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "stopUsingNetworkFeature", "(ILjava/lang/String;)I"); 
			global::android.net.ConnectivityManager._requestRouteToHost4372 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "requestRouteToHost", "(II)Z"); 
			global::android.net.ConnectivityManager._getBackgroundDataSetting4373 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getBackgroundDataSetting", "()Z"); 
		} 
	} 
} 
