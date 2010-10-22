namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WifiInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WifiInfo()
		{
			InitJNI();
		}
		protected WifiInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString8005;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._toString8005)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._toString8005)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8006;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._writeToParcel8006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._writeToParcel8006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8007;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._describeContents8007);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._describeContents8007);
		}
		public new global::java.lang.String SSID
		{
			get
			{
				return getSSID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSSID8008;
		public virtual global::java.lang.String getSSID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getSSID8008)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getSSID8008)) as java.lang.String;
		}
		public new global::java.lang.String BSSID
		{
			get
			{
				return getBSSID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBSSID8009;
		public virtual global::java.lang.String getBSSID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getBSSID8009)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getBSSID8009)) as java.lang.String;
		}
		public new int Rssi
		{
			get
			{
				return getRssi();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRssi8010;
		public virtual int getRssi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getRssi8010);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getRssi8010);
		}
		public new int LinkSpeed
		{
			get
			{
				return getLinkSpeed();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLinkSpeed8011;
		public virtual int getLinkSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getLinkSpeed8011);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getLinkSpeed8011);
		}
		public new global::java.lang.String MacAddress
		{
			get
			{
				return getMacAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMacAddress8012;
		public virtual global::java.lang.String getMacAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getMacAddress8012)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getMacAddress8012)) as java.lang.String;
		}
		public new int NetworkId
		{
			get
			{
				return getNetworkId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkId8013;
		public virtual int getNetworkId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getNetworkId8013);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getNetworkId8013);
		}
		public new global::android.net.wifi.SupplicantState SupplicantState
		{
			get
			{
				return getSupplicantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSupplicantState8014;
		public virtual global::android.net.wifi.SupplicantState getSupplicantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getSupplicantState8014)) as android.net.wifi.SupplicantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getSupplicantState8014)) as android.net.wifi.SupplicantState;
		}
		public new int IpAddress
		{
			get
			{
				return getIpAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIpAddress8015;
		public virtual int getIpAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getIpAddress8015);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getIpAddress8015);
		}
		public new bool HiddenSSID
		{
			get
			{
				return getHiddenSSID();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHiddenSSID8016;
		public virtual bool getHiddenSSID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getHiddenSSID8016);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getHiddenSSID8016);
		}
		internal static global::MonoJavaBridge.MethodId _getDetailedStateOf8017;
		public static global::android.net.NetworkInfo.DetailedState getDetailedStateOf(android.net.wifi.SupplicantState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getDetailedStateOf8017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.DetailedState;
		}
		public static global::java.lang.String LINK_SPEED_UNITS
		{
			get
			{
				return "Mbps";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.WifiInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiInfo"));
			global::android.net.wifi.WifiInfo._toString8005 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.wifi.WifiInfo._writeToParcel8006 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.wifi.WifiInfo._describeContents8007 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "describeContents", "()I");
			global::android.net.wifi.WifiInfo._getSSID8008 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getSSID", "()Ljava/lang/String;");
			global::android.net.wifi.WifiInfo._getBSSID8009 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getBSSID", "()Ljava/lang/String;");
			global::android.net.wifi.WifiInfo._getRssi8010 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getRssi", "()I");
			global::android.net.wifi.WifiInfo._getLinkSpeed8011 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getLinkSpeed", "()I");
			global::android.net.wifi.WifiInfo._getMacAddress8012 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getMacAddress", "()Ljava/lang/String;");
			global::android.net.wifi.WifiInfo._getNetworkId8013 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getNetworkId", "()I");
			global::android.net.wifi.WifiInfo._getSupplicantState8014 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getSupplicantState", "()Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.WifiInfo._getIpAddress8015 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getIpAddress", "()I");
			global::android.net.wifi.WifiInfo._getHiddenSSID8016 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getHiddenSSID", "()Z");
			global::android.net.wifi.WifiInfo._getDetailedStateOf8017 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getDetailedStateOf", "(Landroid/net/wifi/SupplicantState;)Landroid/net/NetworkInfo$DetailedState;");
		}
	}
}
