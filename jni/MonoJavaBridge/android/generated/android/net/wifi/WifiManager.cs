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
			internal static global::MonoJavaBridge.MethodId _finalize5492;
			protected override void finalize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._finalize5492);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._finalize5492);
			}
			internal static global::MonoJavaBridge.MethodId _toString5493;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._toString5493)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._toString5493)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _acquire5494;
			public virtual void acquire() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._acquire5494);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._acquire5494);
			}
			internal static global::MonoJavaBridge.MethodId _release5495;
			public virtual void release() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._release5495);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._release5495);
			}
			internal static global::MonoJavaBridge.MethodId _setReferenceCounted5496;
			public virtual void setReferenceCounted(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted5496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted5496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isHeld5497;
			public virtual bool isHeld() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock._isHeld5497);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.MulticastLock.staticClass, global::android.net.wifi.WifiManager.MulticastLock._isHeld5497);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiManager.MulticastLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager$MulticastLock"));
				global::android.net.wifi.WifiManager.MulticastLock._finalize5492 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "finalize", "()V");
				global::android.net.wifi.WifiManager.MulticastLock._toString5493 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "toString", "()Ljava/lang/String;");
				global::android.net.wifi.WifiManager.MulticastLock._acquire5494 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "acquire", "()V");
				global::android.net.wifi.WifiManager.MulticastLock._release5495 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "release", "()V");
				global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted5496 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "setReferenceCounted", "(Z)V");
				global::android.net.wifi.WifiManager.MulticastLock._isHeld5497 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "isHeld", "()Z");
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
			internal static global::MonoJavaBridge.MethodId _finalize5498;
			protected override void finalize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._finalize5498);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._finalize5498);
			}
			internal static global::MonoJavaBridge.MethodId _toString5499;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._toString5499)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._toString5499)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _acquire5500;
			public virtual void acquire() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._acquire5500);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._acquire5500);
			}
			internal static global::MonoJavaBridge.MethodId _release5501;
			public virtual void release() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._release5501);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._release5501);
			}
			internal static global::MonoJavaBridge.MethodId _setReferenceCounted5502;
			public virtual void setReferenceCounted(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted5502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted5502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isHeld5503;
			public virtual bool isHeld() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock._isHeld5503);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.WifiLock.staticClass, global::android.net.wifi.WifiManager.WifiLock._isHeld5503);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiManager.WifiLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiManager$WifiLock"));
				global::android.net.wifi.WifiManager.WifiLock._finalize5498 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "finalize", "()V");
				global::android.net.wifi.WifiManager.WifiLock._toString5499 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "toString", "()Ljava/lang/String;");
				global::android.net.wifi.WifiManager.WifiLock._acquire5500 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "acquire", "()V");
				global::android.net.wifi.WifiManager.WifiLock._release5501 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "release", "()V");
				global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted5502 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "setReferenceCounted", "(Z)V");
				global::android.net.wifi.WifiManager.WifiLock._isHeld5503 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.WifiLock.staticClass, "isHeld", "()Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _reconnect5504;
		public virtual bool reconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._reconnect5504);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._reconnect5504);
		}
		internal static global::MonoJavaBridge.MethodId _disconnect5505;
		public virtual bool disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._disconnect5505);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._disconnect5505);
		}
		public new global::java.util.List ConfiguredNetworks
		{
			get
			{
				return getConfiguredNetworks();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConfiguredNetworks5506;
		public virtual global::java.util.List getConfiguredNetworks() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getConfiguredNetworks5506)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getConfiguredNetworks5506)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addNetwork5507;
		public virtual int addNetwork(android.net.wifi.WifiConfiguration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager._addNetwork5507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._addNetwork5507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateNetwork5508;
		public virtual int updateNetwork(android.net.wifi.WifiConfiguration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager._updateNetwork5508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._updateNetwork5508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeNetwork5509;
		public virtual bool removeNetwork(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._removeNetwork5509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._removeNetwork5509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enableNetwork5510;
		public virtual bool enableNetwork(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._enableNetwork5510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._enableNetwork5510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _disableNetwork5511;
		public virtual bool disableNetwork(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._disableNetwork5511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._disableNetwork5511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reassociate5512;
		public virtual bool reassociate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._reassociate5512);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._reassociate5512);
		}
		internal static global::MonoJavaBridge.MethodId _pingSupplicant5513;
		public virtual bool pingSupplicant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._pingSupplicant5513);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._pingSupplicant5513);
		}
		internal static global::MonoJavaBridge.MethodId _startScan5514;
		public virtual bool startScan() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._startScan5514);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._startScan5514);
		}
		public new global::android.net.wifi.WifiInfo ConnectionInfo
		{
			get
			{
				return getConnectionInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionInfo5515;
		public virtual global::android.net.wifi.WifiInfo getConnectionInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getConnectionInfo5515)) as android.net.wifi.WifiInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getConnectionInfo5515)) as android.net.wifi.WifiInfo;
		}
		public new global::java.util.List ScanResults
		{
			get
			{
				return getScanResults();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScanResults5516;
		public virtual global::java.util.List getScanResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getScanResults5516)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getScanResults5516)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _saveConfiguration5517;
		public virtual bool saveConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._saveConfiguration5517);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._saveConfiguration5517);
		}
		public new global::android.net.DhcpInfo DhcpInfo
		{
			get
			{
				return getDhcpInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDhcpInfo5518;
		public virtual global::android.net.DhcpInfo getDhcpInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getDhcpInfo5518)) as android.net.DhcpInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getDhcpInfo5518)) as android.net.DhcpInfo;
		}
		internal static global::MonoJavaBridge.MethodId _setWifiEnabled5519;
		public virtual bool setWifiEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._setWifiEnabled5519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._setWifiEnabled5519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int WifiState
		{
			get
			{
				return getWifiState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWifiState5520;
		public virtual int getWifiState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager._getWifiState5520);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._getWifiState5520);
		}
		internal static global::MonoJavaBridge.MethodId _isWifiEnabled5521;
		public virtual bool isWifiEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager._isWifiEnabled5521);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._isWifiEnabled5521);
		}
		internal static global::MonoJavaBridge.MethodId _calculateSignalLevel5522;
		public static int calculateSignalLevel(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._calculateSignalLevel5522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareSignalLevel5523;
		public static int compareSignalLevel(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._compareSignalLevel5523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createWifiLock5524;
		public virtual global::android.net.wifi.WifiManager.WifiLock createWifiLock(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._createWifiLock5524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.wifi.WifiManager.WifiLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._createWifiLock5524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.wifi.WifiManager.WifiLock;
		}
		internal static global::MonoJavaBridge.MethodId _createWifiLock5525;
		public virtual global::android.net.wifi.WifiManager.WifiLock createWifiLock(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._createWifiLock5525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.WifiManager.WifiLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._createWifiLock5525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.WifiManager.WifiLock;
		}
		internal static global::MonoJavaBridge.MethodId _createMulticastLock5526;
		public virtual global::android.net.wifi.WifiManager.MulticastLock createMulticastLock(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager._createMulticastLock5526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.WifiManager.MulticastLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiManager.staticClass, global::android.net.wifi.WifiManager._createMulticastLock5526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.WifiManager.MulticastLock;
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
			global::android.net.wifi.WifiManager._reconnect5504 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "reconnect", "()Z");
			global::android.net.wifi.WifiManager._disconnect5505 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "disconnect", "()Z");
			global::android.net.wifi.WifiManager._getConfiguredNetworks5506 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getConfiguredNetworks", "()Ljava/util/List;");
			global::android.net.wifi.WifiManager._addNetwork5507 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "addNetwork", "(Landroid/net/wifi/WifiConfiguration;)I");
			global::android.net.wifi.WifiManager._updateNetwork5508 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "updateNetwork", "(Landroid/net/wifi/WifiConfiguration;)I");
			global::android.net.wifi.WifiManager._removeNetwork5509 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "removeNetwork", "(I)Z");
			global::android.net.wifi.WifiManager._enableNetwork5510 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "enableNetwork", "(IZ)Z");
			global::android.net.wifi.WifiManager._disableNetwork5511 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "disableNetwork", "(I)Z");
			global::android.net.wifi.WifiManager._reassociate5512 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "reassociate", "()Z");
			global::android.net.wifi.WifiManager._pingSupplicant5513 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "pingSupplicant", "()Z");
			global::android.net.wifi.WifiManager._startScan5514 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "startScan", "()Z");
			global::android.net.wifi.WifiManager._getConnectionInfo5515 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getConnectionInfo", "()Landroid/net/wifi/WifiInfo;");
			global::android.net.wifi.WifiManager._getScanResults5516 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getScanResults", "()Ljava/util/List;");
			global::android.net.wifi.WifiManager._saveConfiguration5517 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "saveConfiguration", "()Z");
			global::android.net.wifi.WifiManager._getDhcpInfo5518 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getDhcpInfo", "()Landroid/net/DhcpInfo;");
			global::android.net.wifi.WifiManager._setWifiEnabled5519 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "setWifiEnabled", "(Z)Z");
			global::android.net.wifi.WifiManager._getWifiState5520 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "getWifiState", "()I");
			global::android.net.wifi.WifiManager._isWifiEnabled5521 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "isWifiEnabled", "()Z");
			global::android.net.wifi.WifiManager._calculateSignalLevel5522 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "calculateSignalLevel", "(II)I");
			global::android.net.wifi.WifiManager._compareSignalLevel5523 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "compareSignalLevel", "(II)I");
			global::android.net.wifi.WifiManager._createWifiLock5524 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(ILjava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;");
			global::android.net.wifi.WifiManager._createWifiLock5525 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;");
			global::android.net.wifi.WifiManager._createMulticastLock5526 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiManager.staticClass, "createMulticastLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$MulticastLock;");
		}
	}
}
