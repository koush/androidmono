namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WifiInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WifiInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString8045;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._toString8045.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._toString8045 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._toString8045) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8046;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._writeToParcel8046.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._writeToParcel8046 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._writeToParcel8046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8047;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._describeContents8047.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._describeContents8047 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._describeContents8047);
		}
		public new global::java.lang.String SSID
		{
			get
			{
				return getSSID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSSID8048;
		public virtual global::java.lang.String getSSID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getSSID8048.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getSSID8048 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getSSID", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getSSID8048) as java.lang.String;
		}
		public new global::java.lang.String BSSID
		{
			get
			{
				return getBSSID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBSSID8049;
		public virtual global::java.lang.String getBSSID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getBSSID8049.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getBSSID8049 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getBSSID", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getBSSID8049) as java.lang.String;
		}
		public new int Rssi
		{
			get
			{
				return getRssi();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRssi8050;
		public virtual int getRssi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getRssi8050.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getRssi8050 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getRssi", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getRssi8050);
		}
		public new int LinkSpeed
		{
			get
			{
				return getLinkSpeed();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLinkSpeed8051;
		public virtual int getLinkSpeed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getLinkSpeed8051.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getLinkSpeed8051 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getLinkSpeed", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getLinkSpeed8051);
		}
		public new global::java.lang.String MacAddress
		{
			get
			{
				return getMacAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMacAddress8052;
		public virtual global::java.lang.String getMacAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getMacAddress8052.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getMacAddress8052 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getMacAddress", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getMacAddress8052) as java.lang.String;
		}
		public new int NetworkId
		{
			get
			{
				return getNetworkId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkId8053;
		public virtual int getNetworkId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getNetworkId8053.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getNetworkId8053 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getNetworkId", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getNetworkId8053);
		}
		public new global::android.net.wifi.SupplicantState SupplicantState
		{
			get
			{
				return getSupplicantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSupplicantState8054;
		public virtual global::android.net.wifi.SupplicantState getSupplicantState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getSupplicantState8054.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getSupplicantState8054 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getSupplicantState", "()Landroid/net/wifi/SupplicantState;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.wifi.SupplicantState>(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getSupplicantState8054) as android.net.wifi.SupplicantState;
		}
		public new int IpAddress
		{
			get
			{
				return getIpAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIpAddress8055;
		public virtual int getIpAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getIpAddress8055.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getIpAddress8055 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getIpAddress", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getIpAddress8055);
		}
		public new bool HiddenSSID
		{
			get
			{
				return getHiddenSSID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHiddenSSID8056;
		public virtual bool getHiddenSSID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getHiddenSSID8056.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getHiddenSSID8056 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getHiddenSSID", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getHiddenSSID8056);
		}
		internal static global::MonoJavaBridge.MethodId _getDetailedStateOf8057;
		public static global::android.net.NetworkInfo.DetailedState getDetailedStateOf(android.net.wifi.SupplicantState arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._getDetailedStateOf8057.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._getDetailedStateOf8057 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getDetailedStateOf", "(Landroid/net/wifi/SupplicantState;)Landroid/net/NetworkInfo$DetailedState;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getDetailedStateOf8057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.DetailedState;
		}
		public static global::java.lang.String LINK_SPEED_UNITS
		{
			get
			{
				return "Mbps";
			}
		}
		static WifiInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.WifiInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiInfo"));
		}
		internal static void InitJNI()
		{
		}
	}
}
