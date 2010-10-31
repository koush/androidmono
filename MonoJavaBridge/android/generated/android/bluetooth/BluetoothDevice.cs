namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothDevice : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BluetoothDevice(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.bluetooth.BluetoothDevice._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.bluetooth.BluetoothDevice.staticClass, "toString", "()Ljava/lang/String;", ref global::android.bluetooth.BluetoothDevice._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, "hashCode", "()I", ref global::android.bluetooth.BluetoothDevice._m2);
		}
		public new global::java.lang.String Address
		{
			get
			{
				return getAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.String getAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.bluetooth.BluetoothDevice.staticClass, "getAddress", "()Ljava/lang/String;", ref global::android.bluetooth.BluetoothDevice._m3) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.bluetooth.BluetoothDevice.staticClass, "getName", "()Ljava/lang/String;", ref global::android.bluetooth.BluetoothDevice._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.bluetooth.BluetoothDevice._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, "describeContents", "()I", ref global::android.bluetooth.BluetoothDevice._m6);
		}
		public new int BondState
		{
			get
			{
				return getBondState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int getBondState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.bluetooth.BluetoothDevice.staticClass, "getBondState", "()I", ref global::android.bluetooth.BluetoothDevice._m7);
		}
		public new global::android.bluetooth.BluetoothClass BluetoothClass
		{
			get
			{
				return getBluetoothClass();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::android.bluetooth.BluetoothClass getBluetoothClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothClass>(this, global::android.bluetooth.BluetoothDevice.staticClass, "getBluetoothClass", "()Landroid/bluetooth/BluetoothClass;", ref global::android.bluetooth.BluetoothDevice._m8) as android.bluetooth.BluetoothClass;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::android.bluetooth.BluetoothSocket createRfcommSocketToServiceRecord(java.util.UUID arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothSocket>(this, global::android.bluetooth.BluetoothDevice.staticClass, "createRfcommSocketToServiceRecord", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothSocket;", ref global::android.bluetooth.BluetoothDevice._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.bluetooth.BluetoothSocket;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR1605;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.bluetooth.BluetoothDevice.staticClass, _CREATOR1605)) as android.os.Parcelable_Creator;
			}
		}
		static BluetoothDevice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothDevice.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothDevice"));
			global::android.bluetooth.BluetoothDevice._CREATOR1605 = @__env.GetStaticFieldIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
