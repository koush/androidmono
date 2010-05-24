namespace android.bluetooth 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class BluetoothAdapter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static BluetoothAdapter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.bluetooth.BluetoothAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.bluetooth.BluetoothAdapter(@__env); 
			} 
		} 
		internal BluetoothAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddress862; 
		public java.lang.String getAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAddress862)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothAdapter.staticClass, _getAddress862)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName863; 
		public java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName863)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothAdapter.staticClass, _getName863)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setName864; 
		public bool setName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return @__env.CallBooleanMethod(this, _setName864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothAdapter.staticClass, _setName864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState865; 
		public int getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return @__env.CallIntMethod(this, _getState865); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.bluetooth.BluetoothAdapter.staticClass, _getState865); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enable866; 
		public bool enable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return @__env.CallBooleanMethod(this, _enable866); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothAdapter.staticClass, _enable866); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disable867; 
		public bool disable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return @__env.CallBooleanMethod(this, _disable867); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothAdapter.staticClass, _disable867); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled868; 
		public bool isEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return @__env.CallBooleanMethod(this, _isEnabled868); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothAdapter.staticClass, _isEnabled868); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultAdapter869; 
		public static android.bluetooth.BluetoothAdapter getDefaultAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothAdapter>(@__env, @__env.CallStaticObjectMethodPtr(android.bluetooth.BluetoothAdapter.staticClass, _getDefaultAdapter869)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteDevice870; 
		public android.bluetooth.BluetoothDevice getRemoteDevice(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallObjectMethodPtr(this, _getRemoteDevice870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothAdapter.staticClass, _getRemoteDevice870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScanMode871; 
		public int getScanMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return @__env.CallIntMethod(this, _getScanMode871); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.bluetooth.BluetoothAdapter.staticClass, _getScanMode871); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startDiscovery872; 
		public bool startDiscovery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return @__env.CallBooleanMethod(this, _startDiscovery872); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothAdapter.staticClass, _startDiscovery872); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelDiscovery873; 
		public bool cancelDiscovery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return @__env.CallBooleanMethod(this, _cancelDiscovery873); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothAdapter.staticClass, _cancelDiscovery873); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDiscovering874; 
		public bool isDiscovering() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return @__env.CallBooleanMethod(this, _isDiscovering874); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothAdapter.staticClass, _isDiscovering874); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBondedDevices875; 
		public java.util.Set getBondedDevices() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _getBondedDevices875)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothAdapter.staticClass, _getBondedDevices875)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _listenUsingRfcommWithServiceRecord876; 
		public android.bluetooth.BluetoothServerSocket listenUsingRfcommWithServiceRecord(java.lang.String arg0, java.util.UUID arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothAdapter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothServerSocket>(@__env, @__env.CallObjectMethodPtr(this, _listenUsingRfcommWithServiceRecord876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothServerSocket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothAdapter.staticClass, _listenUsingRfcommWithServiceRecord876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkBluetoothAddress877; 
		public static bool checkBluetoothAddress(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.bluetooth.BluetoothAdapter.staticClass, _checkBluetoothAddress877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int ERROR
		{ 
			get 
			{ 
				return -2147483648; 
			} 
		} 
		public static java.lang.String ACTION_STATE_CHANGED
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.action.STATE_CHANGED"; 
			} 
		} 
		public static java.lang.String EXTRA_STATE
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.extra.STATE"; 
			} 
		} 
		public static java.lang.String EXTRA_PREVIOUS_STATE
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.extra.PREVIOUS_STATE"; 
			} 
		} 
		public static int STATE_OFF
		{ 
			get 
			{ 
				return 10; 
			} 
		} 
		public static int STATE_TURNING_ON
		{ 
			get 
			{ 
				return 11; 
			} 
		} 
		public static int STATE_ON
		{ 
			get 
			{ 
				return 12; 
			} 
		} 
		public static int STATE_TURNING_OFF
		{ 
			get 
			{ 
				return 13; 
			} 
		} 
		public static java.lang.String ACTION_REQUEST_DISCOVERABLE
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.action.REQUEST_DISCOVERABLE"; 
			} 
		} 
		public static java.lang.String EXTRA_DISCOVERABLE_DURATION
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.extra.DISCOVERABLE_DURATION"; 
			} 
		} 
		public static java.lang.String ACTION_REQUEST_ENABLE
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.action.REQUEST_ENABLE"; 
			} 
		} 
		public static java.lang.String ACTION_SCAN_MODE_CHANGED
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.action.SCAN_MODE_CHANGED"; 
			} 
		} 
		public static java.lang.String EXTRA_SCAN_MODE
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.extra.SCAN_MODE"; 
			} 
		} 
		public static java.lang.String EXTRA_PREVIOUS_SCAN_MODE
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.extra.PREVIOUS_SCAN_MODE"; 
			} 
		} 
		public static int SCAN_MODE_NONE
		{ 
			get 
			{ 
				return 20; 
			} 
		} 
		public static int SCAN_MODE_CONNECTABLE
		{ 
			get 
			{ 
				return 21; 
			} 
		} 
		public static int SCAN_MODE_CONNECTABLE_DISCOVERABLE
		{ 
			get 
			{ 
				return 23; 
			} 
		} 
		public static java.lang.String ACTION_DISCOVERY_STARTED
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.action.DISCOVERY_STARTED"; 
			} 
		} 
		public static java.lang.String ACTION_DISCOVERY_FINISHED
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.action.DISCOVERY_FINISHED"; 
			} 
		} 
		public static java.lang.String ACTION_LOCAL_NAME_CHANGED
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.action.LOCAL_NAME_CHANGED"; 
			} 
		} 
		public static java.lang.String EXTRA_LOCAL_NAME
		{ 
			get 
			{ 
				return "android.bluetooth.adapter.extra.LOCAL_NAME"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.bluetooth.BluetoothAdapter.staticClass = @__class; 
			global::android.bluetooth.BluetoothAdapter._getAddress862 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getAddress", "()Ljava/lang/String;"); 
			global::android.bluetooth.BluetoothAdapter._getName863 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getName", "()Ljava/lang/String;"); 
			global::android.bluetooth.BluetoothAdapter._setName864 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "setName", "(Ljava/lang/String;)Z"); 
			global::android.bluetooth.BluetoothAdapter._getState865 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getState", "()I"); 
			global::android.bluetooth.BluetoothAdapter._enable866 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "enable", "()Z"); 
			global::android.bluetooth.BluetoothAdapter._disable867 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "disable", "()Z"); 
			global::android.bluetooth.BluetoothAdapter._isEnabled868 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "isEnabled", "()Z"); 
			global::android.bluetooth.BluetoothAdapter._getDefaultAdapter869 = @__env.GetStaticMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getDefaultAdapter", "()Landroid/bluetooth/BluetoothAdapter;"); 
			global::android.bluetooth.BluetoothAdapter._getRemoteDevice870 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;"); 
			global::android.bluetooth.BluetoothAdapter._getScanMode871 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getScanMode", "()I"); 
			global::android.bluetooth.BluetoothAdapter._startDiscovery872 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "startDiscovery", "()Z"); 
			global::android.bluetooth.BluetoothAdapter._cancelDiscovery873 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "cancelDiscovery", "()Z"); 
			global::android.bluetooth.BluetoothAdapter._isDiscovering874 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "isDiscovering", "()Z"); 
			global::android.bluetooth.BluetoothAdapter._getBondedDevices875 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getBondedDevices", "()Ljava/util/Set;"); 
			global::android.bluetooth.BluetoothAdapter._listenUsingRfcommWithServiceRecord876 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "listenUsingRfcommWithServiceRecord", "(Ljava/lang/String;Ljava/util/UUID;)Landroid/bluetooth/BluetoothServerSocket;"); 
			global::android.bluetooth.BluetoothAdapter._checkBluetoothAddress877 = @__env.GetStaticMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "checkBluetoothAddress", "(Ljava/lang/String;)Z"); 
		} 
	} 
} 
