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
			internal static global::MonoJavaBridge.MethodId _finalize8059;
			protected override void finalize()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.MulticastLock._finalize8059.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.MulticastLock._finalize8059 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "finalize", "()V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._finalize8059);
			}
			internal static global::MonoJavaBridge.MethodId _toString8060;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.MulticastLock._toString8060.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.MulticastLock._toString8060 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "toString", "()Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._toString8060) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _acquire8061;
			public virtual void acquire()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.MulticastLock._acquire8061.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.MulticastLock._acquire8061 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "acquire", "()V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._acquire8061);
			}
			internal static global::MonoJavaBridge.MethodId _release8062;
			public virtual void release()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.MulticastLock._release8062.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.MulticastLock._release8062 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "release", "()V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._release8062);
			}
			public new bool ReferenceCounted
			{
				set
				{
					setReferenceCounted(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setReferenceCounted8063;
			public virtual void setReferenceCounted(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted8063.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted8063 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "setReferenceCounted", "(Z)V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted8063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isHeld8064;
			public virtual bool isHeld()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.MulticastLock._isHeld8064.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.MulticastLock._isHeld8064 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "isHeld", "()Z");
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._isHeld8064);
			}
			static MulticastLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiManager.MulticastLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager$MulticastLock"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class WifiLock : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected WifiLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finalize8065;
			protected override void finalize()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.WifiLock._finalize8065.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.WifiLock._finalize8065 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "finalize", "()V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._finalize8065);
			}
			internal static global::MonoJavaBridge.MethodId _toString8066;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.WifiLock._toString8066.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.WifiLock._toString8066 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "toString", "()Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._toString8066) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _acquire8067;
			public virtual void acquire()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.WifiLock._acquire8067.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.WifiLock._acquire8067 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "acquire", "()V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._acquire8067);
			}
			internal static global::MonoJavaBridge.MethodId _release8068;
			public virtual void release()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.WifiLock._release8068.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.WifiLock._release8068 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "release", "()V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._release8068);
			}
			public new bool ReferenceCounted
			{
				set
				{
					setReferenceCounted(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setReferenceCounted8069;
			public virtual void setReferenceCounted(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted8069.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted8069 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "setReferenceCounted", "(Z)V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted8069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isHeld8070;
			public virtual bool isHeld()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.wifi.WifiManager.WifiLock._isHeld8070.native == global::System.IntPtr.Zero)
					global::android.net.wifi.WifiManager.WifiLock._isHeld8070 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "isHeld", "()Z");
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._isHeld8070);
			}
			static WifiLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiManager.WifiLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager$WifiLock"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _reconnect8071;
		public virtual bool reconnect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._reconnect8071.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._reconnect8071 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "reconnect", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._reconnect8071);
		}
		internal static global::MonoJavaBridge.MethodId _disconnect8072;
		public virtual bool disconnect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._disconnect8072.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._disconnect8072 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "disconnect", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._disconnect8072);
		}
		public new global::java.util.List ConfiguredNetworks
		{
			get
			{
				return getConfiguredNetworks();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConfiguredNetworks8073;
		public virtual global::java.util.List getConfiguredNetworks()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._getConfiguredNetworks8073.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._getConfiguredNetworks8073 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getConfiguredNetworks", "()Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getConfiguredNetworks8073) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addNetwork8074;
		public virtual int addNetwork(android.net.wifi.WifiConfiguration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._addNetwork8074.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._addNetwork8074 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "addNetwork", "(Landroid/net/wifi/WifiConfiguration;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._addNetwork8074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateNetwork8075;
		public virtual int updateNetwork(android.net.wifi.WifiConfiguration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._updateNetwork8075.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._updateNetwork8075 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "updateNetwork", "(Landroid/net/wifi/WifiConfiguration;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._updateNetwork8075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNetwork8076;
		public virtual bool removeNetwork(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._removeNetwork8076.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._removeNetwork8076 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "removeNetwork", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._removeNetwork8076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enableNetwork8077;
		public virtual bool enableNetwork(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._enableNetwork8077.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._enableNetwork8077 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "enableNetwork", "(IZ)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._enableNetwork8077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _disableNetwork8078;
		public virtual bool disableNetwork(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._disableNetwork8078.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._disableNetwork8078 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "disableNetwork", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._disableNetwork8078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reassociate8079;
		public virtual bool reassociate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._reassociate8079.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._reassociate8079 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "reassociate", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._reassociate8079);
		}
		internal static global::MonoJavaBridge.MethodId _pingSupplicant8080;
		public virtual bool pingSupplicant()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._pingSupplicant8080.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._pingSupplicant8080 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "pingSupplicant", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._pingSupplicant8080);
		}
		internal static global::MonoJavaBridge.MethodId _startScan8081;
		public virtual bool startScan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._startScan8081.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._startScan8081 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "startScan", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._startScan8081);
		}
		public new global::android.net.wifi.WifiInfo ConnectionInfo
		{
			get
			{
				return getConnectionInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionInfo8082;
		public virtual global::android.net.wifi.WifiInfo getConnectionInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._getConnectionInfo8082.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._getConnectionInfo8082 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getConnectionInfo", "()Landroid/net/wifi/WifiInfo;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getConnectionInfo8082) as android.net.wifi.WifiInfo;
		}
		public new global::java.util.List ScanResults
		{
			get
			{
				return getScanResults();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScanResults8083;
		public virtual global::java.util.List getScanResults()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._getScanResults8083.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._getScanResults8083 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getScanResults", "()Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getScanResults8083) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _saveConfiguration8084;
		public virtual bool saveConfiguration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._saveConfiguration8084.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._saveConfiguration8084 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "saveConfiguration", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._saveConfiguration8084);
		}
		public new global::android.net.DhcpInfo DhcpInfo
		{
			get
			{
				return getDhcpInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDhcpInfo8085;
		public virtual global::android.net.DhcpInfo getDhcpInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._getDhcpInfo8085.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._getDhcpInfo8085 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getDhcpInfo", "()Landroid/net/DhcpInfo;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getDhcpInfo8085) as android.net.DhcpInfo;
		}
		public new bool WifiEnabled
		{
			set
			{
				setWifiEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setWifiEnabled8086;
		public virtual bool setWifiEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._setWifiEnabled8086.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._setWifiEnabled8086 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "setWifiEnabled", "(Z)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._setWifiEnabled8086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int WifiState
		{
			get
			{
				return getWifiState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWifiState8087;
		public virtual int getWifiState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._getWifiState8087.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._getWifiState8087 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getWifiState", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getWifiState8087);
		}
		internal static global::MonoJavaBridge.MethodId _isWifiEnabled8088;
		public virtual bool isWifiEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._isWifiEnabled8088.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._isWifiEnabled8088 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "isWifiEnabled", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._isWifiEnabled8088);
		}
		internal static global::MonoJavaBridge.MethodId _calculateSignalLevel8089;
		public static int calculateSignalLevel(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._calculateSignalLevel8089.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._calculateSignalLevel8089 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "calculateSignalLevel", "(II)I");
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._calculateSignalLevel8089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareSignalLevel8090;
		public static int compareSignalLevel(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._compareSignalLevel8090.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._compareSignalLevel8090 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "compareSignalLevel", "(II)I");
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._compareSignalLevel8090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createWifiLock8091;
		public virtual global::android.net.wifi.WifiManager.WifiLock createWifiLock(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._createWifiLock8091.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._createWifiLock8091 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(ILjava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._createWifiLock8091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.net.wifi.WifiManager.WifiLock;
		}
		internal static global::MonoJavaBridge.MethodId _createWifiLock8092;
		public virtual global::android.net.wifi.WifiManager.WifiLock createWifiLock(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._createWifiLock8092.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._createWifiLock8092 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._createWifiLock8092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.wifi.WifiManager.WifiLock;
		}
		internal static global::MonoJavaBridge.MethodId _createMulticastLock8093;
		public virtual global::android.net.wifi.WifiManager.MulticastLock createMulticastLock(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiManager._createMulticastLock8093.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiManager._createMulticastLock8093 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "createMulticastLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$MulticastLock;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._createMulticastLock8093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.wifi.WifiManager.MulticastLock;
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
		internal static void InitJNI()
		{
		}
	}
}
