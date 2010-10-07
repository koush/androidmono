namespace android.bluetooth
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class BluetoothAdapter : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static BluetoothAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.bluetooth.BluetoothAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _getAddress992;
		public global::java.lang.String getAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter._getAddress992));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getAddress992));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName993;
		public global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter._getName993));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getName993));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setName994;
		public bool setName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter._setName994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._setName994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getState995;
		public int getState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.bluetooth.BluetoothAdapter._getState995);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getState995);
		}
		internal static global::net.sf.jni4net.jni.MethodId _enable996;
		public bool enable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter._enable996);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._enable996);
		}
		internal static global::net.sf.jni4net.jni.MethodId _disable997;
		public bool disable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter._disable997);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._disable997);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled998;
		public bool isEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter._isEnabled998);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._isEnabled998);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultAdapter999;
		public static global::android.bluetooth.BluetoothAdapter getDefaultAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothAdapter>(@__env, @__env.CallStaticObjectMethodPtr(android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getDefaultAdapter999));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteDevice1000;
		public global::android.bluetooth.BluetoothDevice getRemoteDevice(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter._getRemoteDevice1000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getRemoteDevice1000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScanMode1001;
		public int getScanMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.bluetooth.BluetoothAdapter._getScanMode1001);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getScanMode1001);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startDiscovery1002;
		public bool startDiscovery() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter._startDiscovery1002);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._startDiscovery1002);
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelDiscovery1003;
		public bool cancelDiscovery() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter._cancelDiscovery1003);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._cancelDiscovery1003);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDiscovering1004;
		public bool isDiscovering() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.bluetooth.BluetoothAdapter._isDiscovering1004);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._isDiscovering1004);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBondedDevices1005;
		public global::java.util.Set getBondedDevices() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter._getBondedDevices1005));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._getBondedDevices1005));
		}
		internal static global::net.sf.jni4net.jni.MethodId _listenUsingRfcommWithServiceRecord1006;
		public global::android.bluetooth.BluetoothServerSocket listenUsingRfcommWithServiceRecord(java.lang.String arg0, java.util.UUID arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothServerSocket>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter._listenUsingRfcommWithServiceRecord1006, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothServerSocket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._listenUsingRfcommWithServiceRecord1006, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkBluetoothAddress1007;
		public static bool checkBluetoothAddress(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.bluetooth.BluetoothAdapter.staticClass, global::android.bluetooth.BluetoothAdapter._checkBluetoothAddress1007, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.bluetooth.BluetoothAdapter.staticClass = @__class;
			global::android.bluetooth.BluetoothAdapter._getAddress992 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getAddress", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothAdapter._getName993 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getName", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothAdapter._setName994 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "setName", "(Ljava/lang/String;)Z");
			global::android.bluetooth.BluetoothAdapter._getState995 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getState", "()I");
			global::android.bluetooth.BluetoothAdapter._enable996 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "enable", "()Z");
			global::android.bluetooth.BluetoothAdapter._disable997 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "disable", "()Z");
			global::android.bluetooth.BluetoothAdapter._isEnabled998 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "isEnabled", "()Z");
			global::android.bluetooth.BluetoothAdapter._getDefaultAdapter999 = @__env.GetStaticMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getDefaultAdapter", "()Landroid/bluetooth/BluetoothAdapter;");
			global::android.bluetooth.BluetoothAdapter._getRemoteDevice1000 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;");
			global::android.bluetooth.BluetoothAdapter._getScanMode1001 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getScanMode", "()I");
			global::android.bluetooth.BluetoothAdapter._startDiscovery1002 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "startDiscovery", "()Z");
			global::android.bluetooth.BluetoothAdapter._cancelDiscovery1003 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "cancelDiscovery", "()Z");
			global::android.bluetooth.BluetoothAdapter._isDiscovering1004 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "isDiscovering", "()Z");
			global::android.bluetooth.BluetoothAdapter._getBondedDevices1005 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "getBondedDevices", "()Ljava/util/Set;");
			global::android.bluetooth.BluetoothAdapter._listenUsingRfcommWithServiceRecord1006 = @__env.GetMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "listenUsingRfcommWithServiceRecord", "(Ljava/lang/String;Ljava/util/UUID;)Landroid/bluetooth/BluetoothServerSocket;");
			global::android.bluetooth.BluetoothAdapter._checkBluetoothAddress1007 = @__env.GetStaticMethodID(global::android.bluetooth.BluetoothAdapter.staticClass, "checkBluetoothAddress", "(Ljava/lang/String;)Z");
		}
	}
}
