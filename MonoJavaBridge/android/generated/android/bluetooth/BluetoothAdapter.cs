namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothAdapter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.String getAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.bluetooth.BluetoothAdapter.staticClass, "getAddress", "()Ljava/lang/String;", ref global::android.bluetooth.BluetoothAdapter._m0) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
			set
			{
				setName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.bluetooth.BluetoothAdapter.staticClass, "getName", "()Ljava/lang/String;", ref global::android.bluetooth.BluetoothAdapter._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public bool setName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, "setName", "(Ljava/lang/String;)Z", ref global::android.bluetooth.BluetoothAdapter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int State
		{
			get
			{
				return getState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, "getState", "()I", ref global::android.bluetooth.BluetoothAdapter._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public bool enable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, "enable", "()Z", ref global::android.bluetooth.BluetoothAdapter._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool disable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, "disable", "()Z", ref global::android.bluetooth.BluetoothAdapter._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool isEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, "isEnabled", "()Z", ref global::android.bluetooth.BluetoothAdapter._m6);
		}
		public static global::android.bluetooth.BluetoothAdapter DefaultAdapter
		{
			get
			{
				return getDefaultAdapter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.bluetooth.BluetoothAdapter getDefaultAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.bluetooth.BluetoothAdapter._m7.native == global::System.IntPtr.Zero)
				global::android.bluetooth.BluetoothAdapter._m7 = @__env.GetStaticMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "getDefaultAdapter", "()Landroid/bluetooth/BluetoothAdapter;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.bluetooth.BluetoothAdapter>(@__env.CallStaticObjectMethod(android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._m7)) as android.bluetooth.BluetoothAdapter;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::android.bluetooth.BluetoothDevice getRemoteDevice(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothDevice>(this, global::android.bluetooth.BluetoothAdapter.staticClass, "getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;", ref global::android.bluetooth.BluetoothAdapter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.bluetooth.BluetoothDevice;
		}
		public new int ScanMode
		{
			get
			{
				return getScanMode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int getScanMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, "getScanMode", "()I", ref global::android.bluetooth.BluetoothAdapter._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public bool startDiscovery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, "startDiscovery", "()Z", ref global::android.bluetooth.BluetoothAdapter._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public bool cancelDiscovery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, "cancelDiscovery", "()Z", ref global::android.bluetooth.BluetoothAdapter._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public bool isDiscovering()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, "isDiscovering", "()Z", ref global::android.bluetooth.BluetoothAdapter._m12);
		}
		public new global::java.util.Set BondedDevices
		{
			get
			{
				return getBondedDevices();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.util.Set getBondedDevices()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.bluetooth.BluetoothAdapter.staticClass, "getBondedDevices", "()Ljava/util/Set;", ref global::android.bluetooth.BluetoothAdapter._m13) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::android.bluetooth.BluetoothServerSocket listenUsingRfcommWithServiceRecord(java.lang.String arg0, java.util.UUID arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothServerSocket>(this, global::android.bluetooth.BluetoothAdapter.staticClass, "listenUsingRfcommWithServiceRecord", "(Ljava/lang/String;Ljava/util/UUID;)Landroid/bluetooth/BluetoothServerSocket;", ref global::android.bluetooth.BluetoothAdapter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.bluetooth.BluetoothServerSocket;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static bool checkBluetoothAddress(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.bluetooth.BluetoothAdapter._m15.native == global::System.IntPtr.Zero)
				global::android.bluetooth.BluetoothAdapter._m15 = @__env.GetStaticMethodIDNoThrow(global::android.bluetooth.BluetoothAdapter.staticClass, "checkBluetoothAddress", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		static BluetoothAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothAdapter"));
		}
	}
}
