namespace android.net.wifi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WifiManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static WifiManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.wifi.WifiManager(@__env); 
			} 
		} 
		protected WifiManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class MulticastLock : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static MulticastLock() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiManager.MulticastLock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.wifi.WifiManager.MulticastLock(@__env); 
				} 
			} 
			protected MulticastLock(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toString4661; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.MulticastLock)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4661)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiManager.MulticastLock.staticClass, _toString4661)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _acquire4662; 
			public virtual void acquire() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.MulticastLock)) 
					@__env.CallVoidMethod(this, _acquire4662); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.net.wifi.WifiManager.MulticastLock.staticClass, _acquire4662); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _release4663; 
			public virtual void release() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.MulticastLock)) 
					@__env.CallVoidMethod(this, _release4663); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.net.wifi.WifiManager.MulticastLock.staticClass, _release4663); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setReferenceCounted4664; 
			public virtual void setReferenceCounted(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.MulticastLock)) 
					@__env.CallVoidMethod(this, _setReferenceCounted4664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.net.wifi.WifiManager.MulticastLock.staticClass, _setReferenceCounted4664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isHeld4665; 
			public virtual bool isHeld() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.MulticastLock)) 
					return @__env.CallBooleanMethod(this, _isHeld4665); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.MulticastLock.staticClass, _isHeld4665); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.wifi.WifiManager.MulticastLock.staticClass = @__class; 
				global::android.net.wifi.WifiManager.MulticastLock._toString4661 = @__env.GetMethodID(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.net.wifi.WifiManager.MulticastLock._acquire4662 = @__env.GetMethodID(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "acquire", "()V"); 
				global::android.net.wifi.WifiManager.MulticastLock._release4663 = @__env.GetMethodID(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "release", "()V"); 
				global::android.net.wifi.WifiManager.MulticastLock._setReferenceCounted4664 = @__env.GetMethodID(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "setReferenceCounted", "(Z)V"); 
				global::android.net.wifi.WifiManager.MulticastLock._isHeld4665 = @__env.GetMethodID(global::android.net.wifi.WifiManager.MulticastLock.staticClass, "isHeld", "()Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class WifiLock : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static WifiLock() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiManager.WifiLock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.wifi.WifiManager.WifiLock(@__env); 
				} 
			} 
			protected WifiLock(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toString4666; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.WifiLock)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4666)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiManager.WifiLock.staticClass, _toString4666)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _acquire4667; 
			public virtual void acquire() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.WifiLock)) 
					@__env.CallVoidMethod(this, _acquire4667); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.net.wifi.WifiManager.WifiLock.staticClass, _acquire4667); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _release4668; 
			public virtual void release() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.WifiLock)) 
					@__env.CallVoidMethod(this, _release4668); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.net.wifi.WifiManager.WifiLock.staticClass, _release4668); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setReferenceCounted4669; 
			public virtual void setReferenceCounted(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.WifiLock)) 
					@__env.CallVoidMethod(this, _setReferenceCounted4669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.net.wifi.WifiManager.WifiLock.staticClass, _setReferenceCounted4669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isHeld4670; 
			public virtual bool isHeld() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.wifi.WifiManager.WifiLock)) 
					return @__env.CallBooleanMethod(this, _isHeld4670); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.WifiLock.staticClass, _isHeld4670); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.wifi.WifiManager.WifiLock.staticClass = @__class; 
				global::android.net.wifi.WifiManager.WifiLock._toString4666 = @__env.GetMethodID(global::android.net.wifi.WifiManager.WifiLock.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.net.wifi.WifiManager.WifiLock._acquire4667 = @__env.GetMethodID(global::android.net.wifi.WifiManager.WifiLock.staticClass, "acquire", "()V"); 
				global::android.net.wifi.WifiManager.WifiLock._release4668 = @__env.GetMethodID(global::android.net.wifi.WifiManager.WifiLock.staticClass, "release", "()V"); 
				global::android.net.wifi.WifiManager.WifiLock._setReferenceCounted4669 = @__env.GetMethodID(global::android.net.wifi.WifiManager.WifiLock.staticClass, "setReferenceCounted", "(Z)V"); 
				global::android.net.wifi.WifiManager.WifiLock._isHeld4670 = @__env.GetMethodID(global::android.net.wifi.WifiManager.WifiLock.staticClass, "isHeld", "()Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disconnect4671; 
		public virtual bool disconnect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _disconnect4671); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _disconnect4671); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConfiguredNetworks4672; 
		public virtual java.util.List getConfiguredNetworks() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getConfiguredNetworks4672)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiManager.staticClass, _getConfiguredNetworks4672)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addNetwork4673; 
		public virtual int addNetwork(android.net.wifi.WifiConfiguration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallIntMethod(this, _addNetwork4673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.WifiManager.staticClass, _addNetwork4673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateNetwork4674; 
		public virtual int updateNetwork(android.net.wifi.WifiConfiguration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallIntMethod(this, _updateNetwork4674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.WifiManager.staticClass, _updateNetwork4674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeNetwork4675; 
		public virtual bool removeNetwork(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _removeNetwork4675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _removeNetwork4675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enableNetwork4676; 
		public virtual bool enableNetwork(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _enableNetwork4676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _enableNetwork4676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disableNetwork4677; 
		public virtual bool disableNetwork(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _disableNetwork4677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _disableNetwork4677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reconnect4678; 
		public virtual bool reconnect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _reconnect4678); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _reconnect4678); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reassociate4679; 
		public virtual bool reassociate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _reassociate4679); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _reassociate4679); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pingSupplicant4680; 
		public virtual bool pingSupplicant() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _pingSupplicant4680); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _pingSupplicant4680); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startScan4681; 
		public virtual bool startScan() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _startScan4681); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _startScan4681); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConnectionInfo4682; 
		public virtual android.net.wifi.WifiInfo getConnectionInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.WifiInfo>(@__env, @__env.CallObjectMethodPtr(this, _getConnectionInfo4682)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.WifiInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiManager.staticClass, _getConnectionInfo4682)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScanResults4683; 
		public virtual java.util.List getScanResults() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getScanResults4683)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiManager.staticClass, _getScanResults4683)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveConfiguration4684; 
		public virtual bool saveConfiguration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _saveConfiguration4684); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _saveConfiguration4684); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDhcpInfo4685; 
		public virtual android.net.DhcpInfo getDhcpInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.DhcpInfo>(@__env, @__env.CallObjectMethodPtr(this, _getDhcpInfo4685)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.DhcpInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiManager.staticClass, _getDhcpInfo4685)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWifiEnabled4686; 
		public virtual bool setWifiEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _setWifiEnabled4686, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _setWifiEnabled4686, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWifiState4687; 
		public virtual int getWifiState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallIntMethod(this, _getWifiState4687); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.WifiManager.staticClass, _getWifiState4687); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWifiEnabled4688; 
		public virtual bool isWifiEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return @__env.CallBooleanMethod(this, _isWifiEnabled4688); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiManager.staticClass, _isWifiEnabled4688); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calculateSignalLevel4689; 
		public static int calculateSignalLevel(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, _calculateSignalLevel4689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareSignalLevel4690; 
		public static int compareSignalLevel(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.net.wifi.WifiManager.staticClass, _compareSignalLevel4690, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createWifiLock4691; 
		public virtual android.net.wifi.WifiManager.WifiLock createWifiLock(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.WifiManager.WifiLock>(@__env, @__env.CallObjectMethodPtr(this, _createWifiLock4691, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.WifiManager.WifiLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiManager.staticClass, _createWifiLock4691, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createWifiLock4692; 
		public virtual android.net.wifi.WifiManager.WifiLock createWifiLock(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.WifiManager.WifiLock>(@__env, @__env.CallObjectMethodPtr(this, _createWifiLock4692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.WifiManager.WifiLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiManager.staticClass, _createWifiLock4692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createMulticastLock4693; 
		public virtual android.net.wifi.WifiManager.MulticastLock createMulticastLock(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.WifiManager.MulticastLock>(@__env, @__env.CallObjectMethodPtr(this, _createMulticastLock4693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.WifiManager.MulticastLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiManager.staticClass, _createMulticastLock4693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		public static int ERROR_AUTHENTICATING
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static java.lang.String WIFI_STATE_CHANGED_ACTION
		{ 
			get 
			{ 
				return "android.net.wifi.WIFI_STATE_CHANGED"; 
			} 
		} 
		public static java.lang.String EXTRA_WIFI_STATE
		{ 
			get 
			{ 
				return "wifi_state"; 
			} 
		} 
		public static java.lang.String EXTRA_PREVIOUS_WIFI_STATE
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
		public static java.lang.String SUPPLICANT_CONNECTION_CHANGE_ACTION
		{ 
			get 
			{ 
				return "android.net.wifi.supplicant.CONNECTION_CHANGE"; 
			} 
		} 
		public static java.lang.String EXTRA_SUPPLICANT_CONNECTED
		{ 
			get 
			{ 
				return "connected"; 
			} 
		} 
		public static java.lang.String NETWORK_STATE_CHANGED_ACTION
		{ 
			get 
			{ 
				return "android.net.wifi.STATE_CHANGE"; 
			} 
		} 
		public static java.lang.String EXTRA_NETWORK_INFO
		{ 
			get 
			{ 
				return "networkInfo"; 
			} 
		} 
		public static java.lang.String EXTRA_BSSID
		{ 
			get 
			{ 
				return "bssid"; 
			} 
		} 
		public static java.lang.String SUPPLICANT_STATE_CHANGED_ACTION
		{ 
			get 
			{ 
				return "android.net.wifi.supplicant.STATE_CHANGE"; 
			} 
		} 
		public static java.lang.String EXTRA_NEW_STATE
		{ 
			get 
			{ 
				return "newState"; 
			} 
		} 
		public static java.lang.String EXTRA_SUPPLICANT_ERROR
		{ 
			get 
			{ 
				return "supplicantError"; 
			} 
		} 
		public static java.lang.String SCAN_RESULTS_AVAILABLE_ACTION
		{ 
			get 
			{ 
				return "android.net.wifi.SCAN_RESULTS"; 
			} 
		} 
		public static java.lang.String RSSI_CHANGED_ACTION
		{ 
			get 
			{ 
				return "android.net.wifi.RSSI_CHANGED"; 
			} 
		} 
		public static java.lang.String EXTRA_NEW_RSSI
		{ 
			get 
			{ 
				return "newRssi"; 
			} 
		} 
		public static java.lang.String NETWORK_IDS_CHANGED_ACTION
		{ 
			get 
			{ 
				return "android.net.wifi.NETWORK_IDS_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_PICK_WIFI_NETWORK
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.wifi.WifiManager.staticClass = @__class; 
			global::android.net.wifi.WifiManager._disconnect4671 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "disconnect", "()Z"); 
			global::android.net.wifi.WifiManager._getConfiguredNetworks4672 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "getConfiguredNetworks", "()Ljava/util/List;"); 
			global::android.net.wifi.WifiManager._addNetwork4673 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "addNetwork", "(Landroid/net/wifi/WifiConfiguration;)I"); 
			global::android.net.wifi.WifiManager._updateNetwork4674 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "updateNetwork", "(Landroid/net/wifi/WifiConfiguration;)I"); 
			global::android.net.wifi.WifiManager._removeNetwork4675 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "removeNetwork", "(I)Z"); 
			global::android.net.wifi.WifiManager._enableNetwork4676 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "enableNetwork", "(IZ)Z"); 
			global::android.net.wifi.WifiManager._disableNetwork4677 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "disableNetwork", "(I)Z"); 
			global::android.net.wifi.WifiManager._reconnect4678 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "reconnect", "()Z"); 
			global::android.net.wifi.WifiManager._reassociate4679 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "reassociate", "()Z"); 
			global::android.net.wifi.WifiManager._pingSupplicant4680 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "pingSupplicant", "()Z"); 
			global::android.net.wifi.WifiManager._startScan4681 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "startScan", "()Z"); 
			global::android.net.wifi.WifiManager._getConnectionInfo4682 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "getConnectionInfo", "()Landroid/net/wifi/WifiInfo;"); 
			global::android.net.wifi.WifiManager._getScanResults4683 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "getScanResults", "()Ljava/util/List;"); 
			global::android.net.wifi.WifiManager._saveConfiguration4684 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "saveConfiguration", "()Z"); 
			global::android.net.wifi.WifiManager._getDhcpInfo4685 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "getDhcpInfo", "()Landroid/net/DhcpInfo;"); 
			global::android.net.wifi.WifiManager._setWifiEnabled4686 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "setWifiEnabled", "(Z)Z"); 
			global::android.net.wifi.WifiManager._getWifiState4687 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "getWifiState", "()I"); 
			global::android.net.wifi.WifiManager._isWifiEnabled4688 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "isWifiEnabled", "()Z"); 
			global::android.net.wifi.WifiManager._calculateSignalLevel4689 = @__env.GetStaticMethodID(global::android.net.wifi.WifiManager.staticClass, "calculateSignalLevel", "(II)I"); 
			global::android.net.wifi.WifiManager._compareSignalLevel4690 = @__env.GetStaticMethodID(global::android.net.wifi.WifiManager.staticClass, "compareSignalLevel", "(II)I"); 
			global::android.net.wifi.WifiManager._createWifiLock4691 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(ILjava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;"); 
			global::android.net.wifi.WifiManager._createWifiLock4692 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "createWifiLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;"); 
			global::android.net.wifi.WifiManager._createMulticastLock4693 = @__env.GetMethodID(global::android.net.wifi.WifiManager.staticClass, "createMulticastLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$MulticastLock;"); 
		} 
	} 
} 
