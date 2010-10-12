namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectivityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnectivityManager()
		{
			InitJNI();
		}
		protected ConnectivityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isNetworkTypeValid5123;
		public static bool isNetworkTypeValid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._isNetworkTypeValid5123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkPreference5124;
		public virtual void setNetworkPreference(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.ConnectivityManager._setNetworkPreference5124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._setNetworkPreference5124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkPreference5125;
		public virtual int getNetworkPreference() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.ConnectivityManager._getNetworkPreference5125);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getNetworkPreference5125);
		}
		internal static global::MonoJavaBridge.MethodId _getActiveNetworkInfo5126;
		public virtual global::android.net.NetworkInfo getActiveNetworkInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.ConnectivityManager._getActiveNetworkInfo5126)) as android.net.NetworkInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getActiveNetworkInfo5126)) as android.net.NetworkInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkInfo5127;
		public virtual global::android.net.NetworkInfo getNetworkInfo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.ConnectivityManager._getNetworkInfo5127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getNetworkInfo5127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAllNetworkInfo5128;
		public virtual global::android.net.NetworkInfo[] getAllNetworkInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.ConnectivityManager._getAllNetworkInfo5128)) as android.net.NetworkInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getAllNetworkInfo5128)) as android.net.NetworkInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _startUsingNetworkFeature5129;
		public virtual int startUsingNetworkFeature(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.ConnectivityManager._startUsingNetworkFeature5129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._startUsingNetworkFeature5129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopUsingNetworkFeature5130;
		public virtual int stopUsingNetworkFeature(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.ConnectivityManager._stopUsingNetworkFeature5130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._stopUsingNetworkFeature5130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestRouteToHost5131;
		public virtual bool requestRouteToHost(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.ConnectivityManager._requestRouteToHost5131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._requestRouteToHost5131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getBackgroundDataSetting5132;
		public virtual bool getBackgroundDataSetting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.ConnectivityManager._getBackgroundDataSetting5132);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._getBackgroundDataSetting5132);
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
		public static int TYPE_MOBILE_MMS
		{
			get
			{
				return 2;
			}
		}
		public static int TYPE_MOBILE_SUPL
		{
			get
			{
				return 3;
			}
		}
		public static int TYPE_MOBILE_DUN
		{
			get
			{
				return 4;
			}
		}
		public static int TYPE_MOBILE_HIPRI
		{
			get
			{
				return 5;
			}
		}
		public static int TYPE_WIMAX
		{
			get
			{
				return 6;
			}
		}
		public static int DEFAULT_NETWORK_PREFERENCE
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.ConnectivityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/ConnectivityManager"));
			global::android.net.ConnectivityManager._isNetworkTypeValid5123 = @__env.GetStaticMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "isNetworkTypeValid", "(I)Z");
			global::android.net.ConnectivityManager._setNetworkPreference5124 = @__env.GetMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "setNetworkPreference", "(I)V");
			global::android.net.ConnectivityManager._getNetworkPreference5125 = @__env.GetMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "getNetworkPreference", "()I");
			global::android.net.ConnectivityManager._getActiveNetworkInfo5126 = @__env.GetMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "getActiveNetworkInfo", "()Landroid/net/NetworkInfo;");
			global::android.net.ConnectivityManager._getNetworkInfo5127 = @__env.GetMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "getNetworkInfo", "(I)Landroid/net/NetworkInfo;");
			global::android.net.ConnectivityManager._getAllNetworkInfo5128 = @__env.GetMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "getAllNetworkInfo", "()[Landroid/net/NetworkInfo;");
			global::android.net.ConnectivityManager._startUsingNetworkFeature5129 = @__env.GetMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "startUsingNetworkFeature", "(ILjava/lang/String;)I");
			global::android.net.ConnectivityManager._stopUsingNetworkFeature5130 = @__env.GetMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "stopUsingNetworkFeature", "(ILjava/lang/String;)I");
			global::android.net.ConnectivityManager._requestRouteToHost5131 = @__env.GetMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "requestRouteToHost", "(II)Z");
			global::android.net.ConnectivityManager._getBackgroundDataSetting5132 = @__env.GetMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "getBackgroundDataSetting", "()Z");
		}
	}
}
