namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectivityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnectivityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isNetworkTypeValid7618;
		public static bool isNetworkTypeValid(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.ConnectivityManager._isNetworkTypeValid7618.native == global::System.IntPtr.Zero)
				global::android.net.ConnectivityManager._isNetworkTypeValid7618 = @__env.GetStaticMethodIDNoThrow(global::android.net.ConnectivityManager.staticClass, "isNetworkTypeValid", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.net.ConnectivityManager.staticClass, global::android.net.ConnectivityManager._isNetworkTypeValid7618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkPreference7619;
		public virtual void setNetworkPreference(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.ConnectivityManager.staticClass, "setNetworkPreference", "(I)V", ref global::android.net.ConnectivityManager._setNetworkPreference7619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NetworkPreference
		{
			get
			{
				return getNetworkPreference();
			}
			set
			{
				setNetworkPreference(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkPreference7620;
		public virtual int getNetworkPreference()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.ConnectivityManager.staticClass, "getNetworkPreference", "()I", ref global::android.net.ConnectivityManager._getNetworkPreference7620);
		}
		public new global::android.net.NetworkInfo ActiveNetworkInfo
		{
			get
			{
				return getActiveNetworkInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActiveNetworkInfo7621;
		public virtual global::android.net.NetworkInfo getActiveNetworkInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.ConnectivityManager.staticClass, "getActiveNetworkInfo", "()Landroid/net/NetworkInfo;", ref global::android.net.ConnectivityManager._getActiveNetworkInfo7621) as android.net.NetworkInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkInfo7622;
		public virtual global::android.net.NetworkInfo getNetworkInfo(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.ConnectivityManager.staticClass, "getNetworkInfo", "(I)Landroid/net/NetworkInfo;", ref global::android.net.ConnectivityManager._getNetworkInfo7622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.NetworkInfo;
		}
		public new global::android.net.NetworkInfo[] AllNetworkInfo
		{
			get
			{
				return getAllNetworkInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllNetworkInfo7623;
		public virtual global::android.net.NetworkInfo[] getAllNetworkInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.net.NetworkInfo>(this, global::android.net.ConnectivityManager.staticClass, "getAllNetworkInfo", "()[Landroid/net/NetworkInfo;", ref global::android.net.ConnectivityManager._getAllNetworkInfo7623) as android.net.NetworkInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _startUsingNetworkFeature7624;
		public virtual int startUsingNetworkFeature(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.ConnectivityManager.staticClass, "startUsingNetworkFeature", "(ILjava/lang/String;)I", ref global::android.net.ConnectivityManager._startUsingNetworkFeature7624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopUsingNetworkFeature7625;
		public virtual int stopUsingNetworkFeature(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.ConnectivityManager.staticClass, "stopUsingNetworkFeature", "(ILjava/lang/String;)I", ref global::android.net.ConnectivityManager._stopUsingNetworkFeature7625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestRouteToHost7626;
		public virtual bool requestRouteToHost(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.ConnectivityManager.staticClass, "requestRouteToHost", "(II)Z", ref global::android.net.ConnectivityManager._requestRouteToHost7626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool BackgroundDataSetting
		{
			get
			{
				return getBackgroundDataSetting();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBackgroundDataSetting7627;
		public virtual bool getBackgroundDataSetting()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.ConnectivityManager.staticClass, "getBackgroundDataSetting", "()Z", ref global::android.net.ConnectivityManager._getBackgroundDataSetting7627);
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
		static ConnectivityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.ConnectivityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/ConnectivityManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
