namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WifiInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WifiInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.wifi.WifiInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.net.wifi.WifiInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, "describeContents", "()I", ref global::android.net.wifi.WifiInfo._m2);
		}
		public new global::java.lang.String SSID
		{
			get
			{
				return getSSID();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getSSID()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiInfo.staticClass, "getSSID", "()Ljava/lang/String;", ref global::android.net.wifi.WifiInfo._m3) as java.lang.String;
		}
		public new global::java.lang.String BSSID
		{
			get
			{
				return getBSSID();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getBSSID()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiInfo.staticClass, "getBSSID", "()Ljava/lang/String;", ref global::android.net.wifi.WifiInfo._m4) as java.lang.String;
		}
		public new int Rssi
		{
			get
			{
				return getRssi();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getRssi()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, "getRssi", "()I", ref global::android.net.wifi.WifiInfo._m5);
		}
		public new int LinkSpeed
		{
			get
			{
				return getLinkSpeed();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getLinkSpeed()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, "getLinkSpeed", "()I", ref global::android.net.wifi.WifiInfo._m6);
		}
		public new global::java.lang.String MacAddress
		{
			get
			{
				return getMacAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getMacAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiInfo.staticClass, "getMacAddress", "()Ljava/lang/String;", ref global::android.net.wifi.WifiInfo._m7) as java.lang.String;
		}
		public new int NetworkId
		{
			get
			{
				return getNetworkId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getNetworkId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, "getNetworkId", "()I", ref global::android.net.wifi.WifiInfo._m8);
		}
		public new global::android.net.wifi.SupplicantState SupplicantState
		{
			get
			{
				return getSupplicantState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.net.wifi.SupplicantState getSupplicantState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.wifi.SupplicantState>(this, global::android.net.wifi.WifiInfo.staticClass, "getSupplicantState", "()Landroid/net/wifi/SupplicantState;", ref global::android.net.wifi.WifiInfo._m9) as android.net.wifi.SupplicantState;
		}
		public new int IpAddress
		{
			get
			{
				return getIpAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getIpAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, "getIpAddress", "()I", ref global::android.net.wifi.WifiInfo._m10);
		}
		public new bool HiddenSSID
		{
			get
			{
				return getHiddenSSID();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool getHiddenSSID()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.wifi.WifiInfo.staticClass, "getHiddenSSID", "()Z", ref global::android.net.wifi.WifiInfo._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::android.net.NetworkInfo.DetailedState getDetailedStateOf(android.net.wifi.SupplicantState arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiInfo._m12.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiInfo._m12 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getDetailedStateOf", "(Landroid/net/wifi/SupplicantState;)Landroid/net/NetworkInfo$DetailedState;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.DetailedState;
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
