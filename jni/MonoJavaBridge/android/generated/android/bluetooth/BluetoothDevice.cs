namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothDevice : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BluetoothDevice()
		{
			InitJNI();
		}
		internal BluetoothDevice(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals2522;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._equals2522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._equals2522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString2523;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._toString2523)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._toString2523)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode2524;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._hashCode2524);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._hashCode2524);
		}
		public new global::java.lang.String Address
		{
			get
			{
				return getAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress2525;
		public global::java.lang.String getAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._getAddress2525)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._getAddress2525)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName2526;
		public global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._getName2526)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._getName2526)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2527;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._writeToParcel2527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._writeToParcel2527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2528;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._describeContents2528);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._describeContents2528);
		}
		public new int BondState
		{
			get
			{
				return getBondState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBondState2529;
		public int getBondState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._getBondState2529);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._getBondState2529);
		}
		public new global::android.bluetooth.BluetoothClass BluetoothClass
		{
			get
			{
				return getBluetoothClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBluetoothClass2530;
		public global::android.bluetooth.BluetoothClass getBluetoothClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.bluetooth.BluetoothClass>(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._getBluetoothClass2530)) as android.bluetooth.BluetoothClass;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.bluetooth.BluetoothClass>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._getBluetoothClass2530)) as android.bluetooth.BluetoothClass;
		}
		internal static global::MonoJavaBridge.MethodId _createRfcommSocketToServiceRecord2531;
		public global::android.bluetooth.BluetoothSocket createRfcommSocketToServiceRecord(java.util.UUID arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.bluetooth.BluetoothSocket>(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice._createRfcommSocketToServiceRecord2531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.bluetooth.BluetoothSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.bluetooth.BluetoothSocket>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothDevice.staticClass, global::android.bluetooth.BluetoothDevice._createRfcommSocketToServiceRecord2531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.bluetooth.BluetoothSocket;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR2549;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.bluetooth.BluetoothDevice.staticClass, _CREATOR2549)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothDevice.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothDevice"));
			global::android.bluetooth.BluetoothDevice._equals2522 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.bluetooth.BluetoothDevice._toString2523 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "toString", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothDevice._hashCode2524 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "hashCode", "()I");
			global::android.bluetooth.BluetoothDevice._getAddress2525 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "getAddress", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothDevice._getName2526 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "getName", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothDevice._writeToParcel2527 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.bluetooth.BluetoothDevice._describeContents2528 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "describeContents", "()I");
			global::android.bluetooth.BluetoothDevice._getBondState2529 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "getBondState", "()I");
			global::android.bluetooth.BluetoothDevice._getBluetoothClass2530 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "getBluetoothClass", "()Landroid/bluetooth/BluetoothClass;");
			global::android.bluetooth.BluetoothDevice._createRfcommSocketToServiceRecord2531 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "createRfcommSocketToServiceRecord", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothSocket;");
			global::android.bluetooth.BluetoothDevice._CREATOR2549 = @__env.GetStaticFieldIDNoThrow(global::android.bluetooth.BluetoothDevice.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
