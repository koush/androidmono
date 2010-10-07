namespace android.bluetooth
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class BluetoothDevice : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static BluetoothDevice()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.bluetooth.BluetoothDevice), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.bluetooth.BluetoothDevice(@__env);
			}
		}
		internal BluetoothDevice(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals1020;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.bluetooth.BluetoothDevice._equals1020, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._equals1020, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1021;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice._toString1021));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._toString1021));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1022;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.bluetooth.BluetoothDevice._hashCode1022);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._hashCode1022);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAddress1023;
		public global::java.lang.String getAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice._getAddress1023));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._getAddress1023));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName1024;
		public global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice._getName1024));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._getName1024));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1025;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.bluetooth.BluetoothDevice._writeToParcel1025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._writeToParcel1025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1026;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.bluetooth.BluetoothDevice._describeContents1026);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._describeContents1026);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBondState1027;
		public int getBondState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.bluetooth.BluetoothDevice._getBondState1027);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._getBondState1027);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBluetoothClass1028;
		public global::android.bluetooth.BluetoothClass getBluetoothClass() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothClass>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice._getBluetoothClass1028));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothClass>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._getBluetoothClass1028));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createRfcommSocketToServiceRecord1029;
		public global::android.bluetooth.BluetoothSocket createRfcommSocketToServiceRecord(java.util.UUID arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothSocket>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice._createRfcommSocketToServiceRecord1029, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothSocket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._createRfcommSocketToServiceRecord1029, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		public static int ERROR
		{
			get
			{
				return -2147483648;
			}
		}
		public static global::java.lang.String ACTION_FOUND
		{
			get
			{
				return "android.bluetooth.device.action.FOUND";
			}
		}
		public static global::java.lang.String ACTION_CLASS_CHANGED
		{
			get
			{
				return "android.bluetooth.device.action.CLASS_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_ACL_CONNECTED
		{
			get
			{
				return "android.bluetooth.device.action.ACL_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_ACL_DISCONNECT_REQUESTED
		{
			get
			{
				return "android.bluetooth.device.action.ACL_DISCONNECT_REQUESTED";
			}
		}
		public static global::java.lang.String ACTION_ACL_DISCONNECTED
		{
			get
			{
				return "android.bluetooth.device.action.ACL_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_NAME_CHANGED
		{
			get
			{
				return "android.bluetooth.device.action.NAME_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BOND_STATE_CHANGED
		{
			get
			{
				return "android.bluetooth.device.action.BOND_STATE_CHANGED";
			}
		}
		public static global::java.lang.String EXTRA_DEVICE
		{
			get
			{
				return "android.bluetooth.device.extra.DEVICE";
			}
		}
		public static global::java.lang.String EXTRA_NAME
		{
			get
			{
				return "android.bluetooth.device.extra.NAME";
			}
		}
		public static global::java.lang.String EXTRA_RSSI
		{
			get
			{
				return "android.bluetooth.device.extra.RSSI";
			}
		}
		public static global::java.lang.String EXTRA_CLASS
		{
			get
			{
				return "android.bluetooth.device.extra.CLASS";
			}
		}
		public static global::java.lang.String EXTRA_BOND_STATE
		{
			get
			{
				return "android.bluetooth.device.extra.BOND_STATE";
			}
		}
		public static global::java.lang.String EXTRA_PREVIOUS_BOND_STATE
		{
			get
			{
				return "android.bluetooth.device.extra.PREVIOUS_BOND_STATE";
			}
		}
		public static int BOND_NONE
		{
			get
			{
				return 10;
			}
		}
		public static int BOND_BONDING
		{
			get
			{
				return 11;
			}
		}
		public static int BOND_BONDED
		{
			get
			{
				return 12;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1030;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.bluetooth.BluetoothDevice.staticClass = @__class;
			global::android.bluetooth.BluetoothDevice._equals1020 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.bluetooth.BluetoothDevice._toString1021 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "toString", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothDevice._hashCode1022 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "hashCode", "()I");
			global::android.bluetooth.BluetoothDevice._getAddress1023 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "getAddress", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothDevice._getName1024 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "getName", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothDevice._writeToParcel1025 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.bluetooth.BluetoothDevice._describeContents1026 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "describeContents", "()I");
			global::android.bluetooth.BluetoothDevice._getBondState1027 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "getBondState", "()I");
			global::android.bluetooth.BluetoothDevice._getBluetoothClass1028 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "getBluetoothClass", "()Landroid/bluetooth/BluetoothClass;");
			global::android.bluetooth.BluetoothDevice._createRfcommSocketToServiceRecord1029 = @__env.GetMethodID(global::android.bluetooth.BluetoothDevice.staticClass, "createRfcommSocketToServiceRecord", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothSocket;");
		}
	}
}
