namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WifiManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WifiManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MulticastLock : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MulticastLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected override void finalize()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, "finalize", "()V", ref global::android.net.wifi.WifiManager.MulticastLock._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.wifi.WifiManager.MulticastLock._m1) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void acquire()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, "acquire", "()V", ref global::android.net.wifi.WifiManager.MulticastLock._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual void release()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, "release", "()V", ref global::android.net.wifi.WifiManager.MulticastLock._m3);
			}
			public new bool ReferenceCounted
			{
				set
				{
					setReferenceCounted(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual void setReferenceCounted(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, "setReferenceCounted", "(Z)V", ref global::android.net.wifi.WifiManager.MulticastLock._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual bool isHeld()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, "isHeld", "()Z", ref global::android.net.wifi.WifiManager.MulticastLock._m5);
			}
			static MulticastLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiManager.MulticastLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager$MulticastLock"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class WifiLock : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected WifiLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected override void finalize()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, "finalize", "()V", ref global::android.net.wifi.WifiManager.WifiLock._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.wifi.WifiManager.WifiLock._m1) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void acquire()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, "acquire", "()V", ref global::android.net.wifi.WifiManager.WifiLock._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual void release()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, "release", "()V", ref global::android.net.wifi.WifiManager.WifiLock._m3);
			}
			public new bool ReferenceCounted
			{
				set
				{
					setReferenceCounted(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual void setReferenceCounted(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, "setReferenceCounted", "(Z)V", ref global::android.net.wifi.WifiManager.WifiLock._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual bool isHeld()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, "isHeld", "()Z", ref global::android.net.wifi.WifiManager.WifiLock._m5);
			}
			static WifiLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiManager.WifiLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager$WifiLock"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool reconnect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "reconnect", "()Z", ref global::android.net.wifi.WifiManager._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool disconnect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "disconnect", "()Z", ref global::android.net.wifi.WifiManager._m1);
		}
		public new global::java.util.List ConfiguredNetworks
		{
			get
			{
				return getConfiguredNetworks();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.List getConfiguredNetworks()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.net.wifi.WifiManager.staticClass, "getConfiguredNetworks", "()Ljava/util/List;", ref global::android.net.wifi.WifiManager._m2) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int addNetwork(android.net.wifi.WifiConfiguration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiManager.staticClass, "addNetwork", "(Landroid/net/wifi/WifiConfiguration;)I", ref global::android.net.wifi.WifiManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int updateNetwork(android.net.wifi.WifiConfiguration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiManager.staticClass, "updateNetwork", "(Landroid/net/wifi/WifiConfiguration;)I", ref global::android.net.wifi.WifiManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool removeNetwork(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "removeNetwork", "(I)Z", ref global::android.net.wifi.WifiManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool enableNetwork(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "enableNetwork", "(IZ)Z", ref global::android.net.wifi.WifiManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool disableNetwork(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "disableNetwork", "(I)Z", ref global::android.net.wifi.WifiManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool reassociate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "reassociate", "()Z", ref global::android.net.wifi.WifiManager._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool pingSupplicant()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "pingSupplicant", "()Z", ref global::android.net.wifi.WifiManager._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool startScan()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "startScan", "()Z", ref global::android.net.wifi.WifiManager._m10);
		}
		public new global::android.net.wifi.WifiInfo ConnectionInfo
		{
			get
			{
				return getConnectionInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.net.wifi.WifiInfo getConnectionInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, "getConnectionInfo", "()Landroid/net/wifi/WifiInfo;", ref global::android.net.wifi.WifiManager._m11) as android.net.wifi.WifiInfo;
		}
		public new global::java.util.List ScanResults
		{
			get
			{
				return getScanResults();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.List getScanResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.net.wifi.WifiManager.staticClass, "getScanResults", "()Ljava/util/List;", ref global::android.net.wifi.WifiManager._m12) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool saveConfiguration()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "saveConfiguration", "()Z", ref global::android.net.wifi.WifiManager._m13);
		}
		public new global::android.net.DhcpInfo DhcpInfo
		{
			get
			{
				return getDhcpInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.net.DhcpInfo getDhcpInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, "getDhcpInfo", "()Landroid/net/DhcpInfo;", ref global::android.net.wifi.WifiManager._m14) as android.net.DhcpInfo;
		}
		public new bool WifiEnabled
		{
			set
			{
				setWifiEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool setWifiEnabled(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "setWifiEnabled", "(Z)Z", ref global::android.net.wifi.WifiManager._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int WifiState
		{
			get
			{
				return getWifiState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getWifiState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiManager.staticClass, "getWifiState", "()I", ref global::android.net.wifi.WifiManager._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool isWifiEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, "isWifiEnabled", "()Z", ref global::android.net.wifi.WifiManager._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static int calculateSignalLevel(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._m18.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._m18 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "calculateSignalLevel", "(II)I");
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static int compareSignalLevel(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._m19.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._m19 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "compareSignalLevel", "(II)I");
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::android.net.wifi.WifiManager.WifiLock createWifiLock(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(ILjava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;", ref global::android.net.wifi.WifiManager._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.net.wifi.WifiManager.WifiLock;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::android.net.wifi.WifiManager.WifiLock createWifiLock(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;", ref global::android.net.wifi.WifiManager._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.wifi.WifiManager.WifiLock;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::android.net.wifi.WifiManager.MulticastLock createMulticastLock(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, "createMulticastLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$MulticastLock;", ref global::android.net.wifi.WifiManager._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.wifi.WifiManager.MulticastLock;
		}
		public static int ERROR_AUTHENTICATING
		{
			get
			{
				return 1;
			}
		}
		public static global::java.lang.String WIFI_STATE_CHANGED_ACTION
		{
			get
			{
				return "android.net.wifi.WIFI_STATE_CHANGED";
			}
		}
		public static global::java.lang.String EXTRA_WIFI_STATE
		{
			get
			{
				return "wifi_state";
			}
		}
		public static global::java.lang.String EXTRA_PREVIOUS_WIFI_STATE
		{
			get
			{
				return "previous_wifi_state";
			}
		}
		public static int WIFI_STATE_DISABLING
		{
			get
			{
				return 0;
			}
		}
		public static int WIFI_STATE_DISABLED
		{
			get
			{
				return 1;
			}
		}
		public static int WIFI_STATE_ENABLING
		{
			get
			{
				return 2;
			}
		}
		public static int WIFI_STATE_ENABLED
		{
			get
			{
				return 3;
			}
		}
		public static int WIFI_STATE_UNKNOWN
		{
			get
			{
				return 4;
			}
		}
		public static global::java.lang.String SUPPLICANT_CONNECTION_CHANGE_ACTION
		{
			get
			{
				return "android.net.wifi.supplicant.CONNECTION_CHANGE";
			}
		}
		public static global::java.lang.String EXTRA_SUPPLICANT_CONNECTED
		{
			get
			{
				return "connected";
			}
		}
		public static global::java.lang.String NETWORK_STATE_CHANGED_ACTION
		{
			get
			{
				return "android.net.wifi.STATE_CHANGE";
			}
		}
		public static global::java.lang.String EXTRA_NETWORK_INFO
		{
			get
			{
				return "networkInfo";
			}
		}
		public static global::java.lang.String EXTRA_BSSID
		{
			get
			{
				return "bssid";
			}
		}
		public static global::java.lang.String SUPPLICANT_STATE_CHANGED_ACTION
		{
			get
			{
				return "android.net.wifi.supplicant.STATE_CHANGE";
			}
		}
		public static global::java.lang.String EXTRA_NEW_STATE
		{
			get
			{
				return "newState";
			}
		}
		public static global::java.lang.String EXTRA_SUPPLICANT_ERROR
		{
			get
			{
				return "supplicantError";
			}
		}
		public static global::java.lang.String SCAN_RESULTS_AVAILABLE_ACTION
		{
			get
			{
				return "android.net.wifi.SCAN_RESULTS";
			}
		}
		public static global::java.lang.String RSSI_CHANGED_ACTION
		{
			get
			{
				return "android.net.wifi.RSSI_CHANGED";
			}
		}
		public static global::java.lang.String EXTRA_NEW_RSSI
		{
			get
			{
				return "newRssi";
			}
		}
		public static global::java.lang.String NETWORK_IDS_CHANGED_ACTION
		{
			get
			{
				return "android.net.wifi.NETWORK_IDS_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_PICK_WIFI_NETWORK
		{
			get
			{
				return "android.net.wifi.PICK_WIFI_NETWORK";
			}
		}
		public static int WIFI_MODE_FULL
		{
			get
			{
				return 1;
			}
		}
		public static int WIFI_MODE_SCAN_ONLY
		{
			get
			{
				return 2;
			}
		}
		static WifiManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.WifiManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager"));
		}
	}
}
