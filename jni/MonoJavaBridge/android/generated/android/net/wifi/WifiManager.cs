namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WifiManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WifiManager()
		{
			InitJNI();
		}
		protected WifiManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MulticastLock : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MulticastLock()
			{
				InitJNI();
			}
			protected MulticastLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finalize8019;
			protected override void finalize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._finalize8019);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._finalize8019);
			}
			internal static global::MonoJavaBridge.MethodId _toString8020;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._toString8020)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._toString8020)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _acquire8021;
			public virtual void acquire() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._acquire8021);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._acquire8021);
			}
			internal static global::MonoJavaBridge.MethodId _release8022;
			public virtual void release() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._release8022);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._release8022);
			}
			internal static global::MonoJavaBridge.MethodId _setReferenceCounted8023;
			public virtual void setReferenceCounted(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted8023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted8023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isHeld8024;
			public virtual bool isHeld() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._isHeld8024);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._isHeld8024);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiManager.MulticastLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager$MulticastLock"));
				global::android.net.wifi.WifiManager.MulticastLock._finalize8019 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "finalize", "()V");
				global::android.net.wifi.WifiManager.MulticastLock._toString8020 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "toString", "()Ljava/lang/String;");
				global::android.net.wifi.WifiManager.MulticastLock._acquire8021 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "acquire", "()V");
				global::android.net.wifi.WifiManager.MulticastLock._release8022 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "release", "()V");
				global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted8023 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "setReferenceCounted", "(Z)V");
				global::android.net.wifi.WifiManager.MulticastLock._isHeld8024 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "isHeld", "()Z");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class WifiLock : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static WifiLock()
			{
				InitJNI();
			}
			protected WifiLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finalize8025;
			protected override void finalize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._finalize8025);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._finalize8025);
			}
			internal static global::MonoJavaBridge.MethodId _toString8026;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._toString8026)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._toString8026)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _acquire8027;
			public virtual void acquire() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._acquire8027);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._acquire8027);
			}
			internal static global::MonoJavaBridge.MethodId _release8028;
			public virtual void release() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._release8028);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._release8028);
			}
			internal static global::MonoJavaBridge.MethodId _setReferenceCounted8029;
			public virtual void setReferenceCounted(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted8029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted8029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isHeld8030;
			public virtual bool isHeld() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._isHeld8030);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._isHeld8030);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiManager.WifiLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager$WifiLock"));
				global::android.net.wifi.WifiManager.WifiLock._finalize8025 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "finalize", "()V");
				global::android.net.wifi.WifiManager.WifiLock._toString8026 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "toString", "()Ljava/lang/String;");
				global::android.net.wifi.WifiManager.WifiLock._acquire8027 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "acquire", "()V");
				global::android.net.wifi.WifiManager.WifiLock._release8028 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "release", "()V");
				global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted8029 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "setReferenceCounted", "(Z)V");
				global::android.net.wifi.WifiManager.WifiLock._isHeld8030 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "isHeld", "()Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _reconnect8031;
		public virtual bool reconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._reconnect8031);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._reconnect8031);
		}
		internal static global::MonoJavaBridge.MethodId _disconnect8032;
		public virtual bool disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._disconnect8032);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._disconnect8032);
		}
		public new global::java.util.List ConfiguredNetworks
		{
			get
			{
				return getConfiguredNetworks();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConfiguredNetworks8033;
		public virtual global::java.util.List getConfiguredNetworks() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getConfiguredNetworks8033)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getConfiguredNetworks8033)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addNetwork8034;
		public virtual int addNetwork(android.net.wifi.WifiConfiguration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager._addNetwork8034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._addNetwork8034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateNetwork8035;
		public virtual int updateNetwork(android.net.wifi.WifiConfiguration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager._updateNetwork8035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._updateNetwork8035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNetwork8036;
		public virtual bool removeNetwork(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._removeNetwork8036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._removeNetwork8036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enableNetwork8037;
		public virtual bool enableNetwork(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._enableNetwork8037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._enableNetwork8037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _disableNetwork8038;
		public virtual bool disableNetwork(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._disableNetwork8038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._disableNetwork8038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reassociate8039;
		public virtual bool reassociate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._reassociate8039);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._reassociate8039);
		}
		internal static global::MonoJavaBridge.MethodId _pingSupplicant8040;
		public virtual bool pingSupplicant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._pingSupplicant8040);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._pingSupplicant8040);
		}
		internal static global::MonoJavaBridge.MethodId _startScan8041;
		public virtual bool startScan() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._startScan8041);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._startScan8041);
		}
		public new global::android.net.wifi.WifiInfo ConnectionInfo
		{
			get
			{
				return getConnectionInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionInfo8042;
		public virtual global::android.net.wifi.WifiInfo getConnectionInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getConnectionInfo8042)) as android.net.wifi.WifiInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getConnectionInfo8042)) as android.net.wifi.WifiInfo;
		}
		public new global::java.util.List ScanResults
		{
			get
			{
				return getScanResults();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScanResults8043;
		public virtual global::java.util.List getScanResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getScanResults8043)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getScanResults8043)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _saveConfiguration8044;
		public virtual bool saveConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._saveConfiguration8044);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._saveConfiguration8044);
		}
		public new global::android.net.DhcpInfo DhcpInfo
		{
			get
			{
				return getDhcpInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDhcpInfo8045;
		public virtual global::android.net.DhcpInfo getDhcpInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getDhcpInfo8045)) as android.net.DhcpInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getDhcpInfo8045)) as android.net.DhcpInfo;
		}
		internal static global::MonoJavaBridge.MethodId _setWifiEnabled8046;
		public virtual bool setWifiEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._setWifiEnabled8046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._setWifiEnabled8046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int WifiState
		{
			get
			{
				return getWifiState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWifiState8047;
		public virtual int getWifiState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getWifiState8047);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getWifiState8047);
		}
		internal static global::MonoJavaBridge.MethodId _isWifiEnabled8048;
		public virtual bool isWifiEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._isWifiEnabled8048);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._isWifiEnabled8048);
		}
		internal static global::MonoJavaBridge.MethodId _calculateSignalLevel8049;
		public static int calculateSignalLevel(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._calculateSignalLevel8049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareSignalLevel8050;
		public static int compareSignalLevel(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._compareSignalLevel8050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createWifiLock8051;
		public virtual global::android.net.wifi.WifiManager.WifiLock createWifiLock(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._createWifiLock8051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.wifi.WifiManager.WifiLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._createWifiLock8051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.wifi.WifiManager.WifiLock;
		}
		internal static global::MonoJavaBridge.MethodId _createWifiLock8052;
		public virtual global::android.net.wifi.WifiManager.WifiLock createWifiLock(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._createWifiLock8052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.WifiManager.WifiLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._createWifiLock8052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.WifiManager.WifiLock;
		}
		internal static global::MonoJavaBridge.MethodId _createMulticastLock8053;
		public virtual global::android.net.wifi.WifiManager.MulticastLock createMulticastLock(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._createMulticastLock8053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.WifiManager.MulticastLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._createMulticastLock8053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.WifiManager.MulticastLock;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.WifiManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager"));
			global::android.net.wifi.WifiManager._reconnect8031 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "reconnect", "()Z");
			global::android.net.wifi.WifiManager._disconnect8032 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "disconnect", "()Z");
			global::android.net.wifi.WifiManager._getConfiguredNetworks8033 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getConfiguredNetworks", "()Ljava/util/List;");
			global::android.net.wifi.WifiManager._addNetwork8034 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "addNetwork", "(Landroid/net/wifi/WifiConfiguration;)I");
			global::android.net.wifi.WifiManager._updateNetwork8035 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "updateNetwork", "(Landroid/net/wifi/WifiConfiguration;)I");
			global::android.net.wifi.WifiManager._removeNetwork8036 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "removeNetwork", "(I)Z");
			global::android.net.wifi.WifiManager._enableNetwork8037 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "enableNetwork", "(IZ)Z");
			global::android.net.wifi.WifiManager._disableNetwork8038 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "disableNetwork", "(I)Z");
			global::android.net.wifi.WifiManager._reassociate8039 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "reassociate", "()Z");
			global::android.net.wifi.WifiManager._pingSupplicant8040 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "pingSupplicant", "()Z");
			global::android.net.wifi.WifiManager._startScan8041 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "startScan", "()Z");
			global::android.net.wifi.WifiManager._getConnectionInfo8042 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getConnectionInfo", "()Landroid/net/wifi/WifiInfo;");
			global::android.net.wifi.WifiManager._getScanResults8043 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getScanResults", "()Ljava/util/List;");
			global::android.net.wifi.WifiManager._saveConfiguration8044 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "saveConfiguration", "()Z");
			global::android.net.wifi.WifiManager._getDhcpInfo8045 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getDhcpInfo", "()Landroid/net/DhcpInfo;");
			global::android.net.wifi.WifiManager._setWifiEnabled8046 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "setWifiEnabled", "(Z)Z");
			global::android.net.wifi.WifiManager._getWifiState8047 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getWifiState", "()I");
			global::android.net.wifi.WifiManager._isWifiEnabled8048 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "isWifiEnabled", "()Z");
			global::android.net.wifi.WifiManager._calculateSignalLevel8049 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "calculateSignalLevel", "(II)I");
			global::android.net.wifi.WifiManager._compareSignalLevel8050 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "compareSignalLevel", "(II)I");
			global::android.net.wifi.WifiManager._createWifiLock8051 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(ILjava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;");
			global::android.net.wifi.WifiManager._createWifiLock8052 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;");
			global::android.net.wifi.WifiManager._createMulticastLock8053 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "createMulticastLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$MulticastLock;");
		}
	}
}
