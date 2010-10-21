namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothAdapter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BluetoothAdapter()
		{
			InitJNI();
		}
		internal BluetoothAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress2395;
		public global::java.lang.String getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._getAddress2395)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getAddress2395)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName2396;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._getName2396)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getName2396)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName2397;
		public bool setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._setName2397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._setName2397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int State
		{
			get
			{
				return getState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getState2398;
		public int getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._getState2398);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getState2398);
		}
		internal static global::MonoJavaBridge.MethodId _enable2399;
		public bool enable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._enable2399);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._enable2399);
		}
		internal static global::MonoJavaBridge.MethodId _disable2400;
		public bool disable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._disable2400);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._disable2400);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled2401;
		public bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._isEnabled2401);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._isEnabled2401);
		}
		public static global::android.bluetooth.BluetoothAdapter DefaultAdapter
		{
			get
			{
				return getDefaultAdapter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAdapter2402;
		public static global::android.bluetooth.BluetoothAdapter getDefaultAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getDefaultAdapter2402)) as android.bluetooth.BluetoothAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteDevice2403;
		public global::android.bluetooth.BluetoothDevice getRemoteDevice(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._getRemoteDevice2403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.bluetooth.BluetoothDevice;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getRemoteDevice2403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.bluetooth.BluetoothDevice;
		}
		public new int ScanMode
		{
			get
			{
				return getScanMode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScanMode2404;
		public int getScanMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._getScanMode2404);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getScanMode2404);
		}
		internal static global::MonoJavaBridge.MethodId _startDiscovery2405;
		public bool startDiscovery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._startDiscovery2405);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._startDiscovery2405);
		}
		internal static global::MonoJavaBridge.MethodId _cancelDiscovery2406;
		public bool cancelDiscovery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._cancelDiscovery2406);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._cancelDiscovery2406);
		}
		internal static global::MonoJavaBridge.MethodId _isDiscovering2407;
		public bool isDiscovering() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._isDiscovering2407);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._isDiscovering2407);
		}
		public new global::java.util.Set BondedDevices
		{
			get
			{
				return getBondedDevices();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBondedDevices2408;
		public global::java.util.Set getBondedDevices() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._getBondedDevices2408)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getBondedDevices2408)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _listenUsingRfcommWithServiceRecord2409;
		public global::android.bluetooth.BluetoothServerSocket listenUsingRfcommWithServiceRecord(java.lang.String arg0, java.util.UUID arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter._listenUsingRfcommWithServiceRecord2409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.bluetooth.BluetoothServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._listenUsingRfcommWithServiceRecord2409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.bluetooth.BluetoothServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _checkBluetoothAddress2410;
		public static bool checkBluetoothAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._checkBluetoothAddress2410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int ERROR
		{
			get
			{
				return -2147483648;
			}
		}
		public static global::java.lang.String ACTION_STATE_CHANGED
		{
			get
			{
				return "android.bluetooth.adapter.action.STATE_CHANGED";
			}
		}
		public static global::java.lang.String EXTRA_STATE
		{
			get
			{
				return "android.bluetooth.adapter.extra.STATE";
			}
		}
		public static global::java.lang.String EXTRA_PREVIOUS_STATE
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
		public static global::java.lang.String ACTION_REQUEST_DISCOVERABLE
		{
			get
			{
				return "android.bluetooth.adapter.action.REQUEST_DISCOVERABLE";
			}
		}
		public static global::java.lang.String EXTRA_DISCOVERABLE_DURATION
		{
			get
			{
				return "android.bluetooth.adapter.extra.DISCOVERABLE_DURATION";
			}
		}
		public static global::java.lang.String ACTION_REQUEST_ENABLE
		{
			get
			{
				return "android.bluetooth.adapter.action.REQUEST_ENABLE";
			}
		}
		public static global::java.lang.String ACTION_SCAN_MODE_CHANGED
		{
			get
			{
				return "android.bluetooth.adapter.action.SCAN_MODE_CHANGED";
			}
		}
		public static global::java.lang.String EXTRA_SCAN_MODE
		{
			get
			{
				return "android.bluetooth.adapter.extra.SCAN_MODE";
			}
		}
		public static global::java.lang.String EXTRA_PREVIOUS_SCAN_MODE
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
		public static global::java.lang.String ACTION_DISCOVERY_STARTED
		{
			get
			{
				return "android.bluetooth.adapter.action.DISCOVERY_STARTED";
			}
		}
		public static global::java.lang.String ACTION_DISCOVERY_FINISHED
		{
			get
			{
				return "android.bluetooth.adapter.action.DISCOVERY_FINISHED";
			}
		}
		public static global::java.lang.String ACTION_LOCAL_NAME_CHANGED
		{
			get
			{
				return "android.bluetooth.adapter.action.LOCAL_NAME_CHANGED";
			}
		}
		public static global::java.lang.String EXTRA_LOCAL_NAME
		{
			get
			{
				return "android.bluetooth.adapter.extra.LOCAL_NAME";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothAdapter"));
			global::android.bluetooth.BluetoothAdapter._getAddress2395 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "getAddress", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothAdapter._getName2396 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "getName", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothAdapter._setName2397 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "setName", "(Ljava/lang/String;)Z");
			global::android.bluetooth.BluetoothAdapter._getState2398 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "getState", "()I");
			global::android.bluetooth.BluetoothAdapter._enable2399 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "enable", "()Z");
			global::android.bluetooth.BluetoothAdapter._disable2400 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "disable", "()Z");
			global::android.bluetooth.BluetoothAdapter._isEnabled2401 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "isEnabled", "()Z");
			global::android.bluetooth.BluetoothAdapter._getDefaultAdapter2402 = @__env.GetStaticMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "getDefaultAdapter", "()Landroid/bluetooth/BluetoothAdapter;");
			global::android.bluetooth.BluetoothAdapter._getRemoteDevice2403 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;");
			global::android.bluetooth.BluetoothAdapter._getScanMode2404 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "getScanMode", "()I");
			global::android.bluetooth.BluetoothAdapter._startDiscovery2405 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "startDiscovery", "()Z");
			global::android.bluetooth.BluetoothAdapter._cancelDiscovery2406 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "cancelDiscovery", "()Z");
			global::android.bluetooth.BluetoothAdapter._isDiscovering2407 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "isDiscovering", "()Z");
			global::android.bluetooth.BluetoothAdapter._getBondedDevices2408 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "getBondedDevices", "()Ljava/util/Set;");
			global::android.bluetooth.BluetoothAdapter._listenUsingRfcommWithServiceRecord2409 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "listenUsingRfcommWithServiceRecord", "(Ljava/lang/String;Ljava/util/UUID;)Landroid/bluetooth/BluetoothServerSocket;");
			global::android.bluetooth.BluetoothAdapter._checkBluetoothAddress2410 = @__env.GetStaticMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "checkBluetoothAddress", "(Ljava/lang/String;)Z");
		}
	}
}
