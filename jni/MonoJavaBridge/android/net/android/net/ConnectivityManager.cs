namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ConnectivityManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ConnectivityManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.ConnectivityManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _isNetworkTypeValid4612; 
		public static bool isNetworkTypeValid(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._isNetworkTypeValid4612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNetworkPreference4613; 
		public virtual void setNetworkPreference(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.ConnectivityManager._setNetworkPreference4613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._setNetworkPreference4613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkPreference4614; 
		public virtual int getNetworkPreference() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.ConnectivityManager._getNetworkPreference4614); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getNetworkPreference4614); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActiveNetworkInfo4615; 
		public virtual global::android.net.NetworkInfo getActiveNetworkInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.ConnectivityManager._getActiveNetworkInfo4615)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getActiveNetworkInfo4615)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkInfo4616; 
		public virtual global::android.net.NetworkInfo getNetworkInfo(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.ConnectivityManager._getNetworkInfo4616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getNetworkInfo4616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllNetworkInfo4617; 
		public virtual global::android.net.NetworkInfo[] getAllNetworkInfo() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.net.ConnectivityManager._getAllNetworkInfo4617)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getAllNetworkInfo4617)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startUsingNetworkFeature4618; 
		public virtual int startUsingNetworkFeature(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.ConnectivityManager._startUsingNetworkFeature4618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._startUsingNetworkFeature4618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopUsingNetworkFeature4619; 
		public virtual int stopUsingNetworkFeature(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.ConnectivityManager._stopUsingNetworkFeature4619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._stopUsingNetworkFeature4619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestRouteToHost4620; 
		public virtual bool requestRouteToHost(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.ConnectivityManager._requestRouteToHost4620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._requestRouteToHost4620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBackgroundDataSetting4621; 
		public virtual bool getBackgroundDataSetting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.ConnectivityManager._getBackgroundDataSetting4621); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getBackgroundDataSetting4621); 
		} 
		public static global::java.lang.String CONNECTIVITY_ACTION
		{ 
			get 
			{ 
				return "android.net.conn.CONNECTIVITY_CHANGE"; 
			} 
		} 
		public static global::java.lang.String EXTRA_NETWORK_INFO
		{ 
			get 
			{ 
				return "networkInfo"; 
			} 
		} 
		public static global::java.lang.String EXTRA_IS_FAILOVER
		{ 
			get 
			{ 
				return "isFailover"; 
			} 
		} 
		public static global::java.lang.String EXTRA_OTHER_NETWORK_INFO
		{ 
			get 
			{ 
				return "otherNetwork"; 
			} 
		} 
		public static global::java.lang.String EXTRA_NO_CONNECTIVITY
		{ 
			get 
			{ 
				return "noConnectivity"; 
			} 
		} 
		public static global::java.lang.String EXTRA_REASON
		{ 
			get 
			{ 
				return "reason"; 
			} 
		} 
		public static global::java.lang.String EXTRA_EXTRA_INFO
		{ 
			get 
			{ 
				return "extraInfo"; 
			} 
		} 
		public static global::java.lang.String ACTION_BACKGROUND_DATA_SETTING_CHANGED
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
			global::android.net.ConnectivityManager._isNetworkTypeValid4612 = @__env.GetStaticMethodID(global::android.net.ConnectivityManager.staticClass, "isNetworkTypeValid", "(I)Z"); 
			global::android.net.ConnectivityManager._setNetworkPreference4613 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "setNetworkPreference", "(I)V"); 
			global::android.net.ConnectivityManager._getNetworkPreference4614 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getNetworkPreference", "()I"); 
			global::android.net.ConnectivityManager._getActiveNetworkInfo4615 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getActiveNetworkInfo", "()Landroid/net/NetworkInfo;"); 
			global::android.net.ConnectivityManager._getNetworkInfo4616 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getNetworkInfo", "(I)Landroid/net/NetworkInfo;"); 
			global::android.net.ConnectivityManager._getAllNetworkInfo4617 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getAllNetworkInfo", "()[Landroid/net/NetworkInfo;"); 
			global::android.net.ConnectivityManager._startUsingNetworkFeature4618 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "startUsingNetworkFeature", "(ILjava/lang/String;)I"); 
			global::android.net.ConnectivityManager._stopUsingNetworkFeature4619 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "stopUsingNetworkFeature", "(ILjava/lang/String;)I"); 
			global::android.net.ConnectivityManager._requestRouteToHost4620 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "requestRouteToHost", "(II)Z"); 
			global::android.net.ConnectivityManager._getBackgroundDataSetting4621 = @__env.GetMethodID(global::android.net.ConnectivityManager.staticClass, "getBackgroundDataSetting", "()Z"); 
		} 
	} 
} 
