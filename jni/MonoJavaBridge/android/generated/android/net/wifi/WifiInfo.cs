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
		internal static global::MonoJavaBridge.MethodId _toString5479;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._toString5479)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._toString5479)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5480;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._writeToParcel5480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._writeToParcel5480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5481;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._describeContents5481);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._describeContents5481);
		}
		internal static global::MonoJavaBridge.MethodId _getSSID5482;
		public virtual global::java.lang.String getSSID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getSSID5482)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getSSID5482)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBSSID5483;
		public virtual global::java.lang.String getBSSID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getBSSID5483)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getBSSID5483)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRssi5484;
		public virtual int getRssi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getRssi5484);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getRssi5484);
		}
		internal static global::MonoJavaBridge.MethodId _getLinkSpeed5485;
		public virtual int getLinkSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getLinkSpeed5485);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getLinkSpeed5485);
		}
		internal static global::MonoJavaBridge.MethodId _getMacAddress5486;
		public virtual global::java.lang.String getMacAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getMacAddress5486)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getMacAddress5486)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkId5487;
		public virtual int getNetworkId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getNetworkId5487);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getNetworkId5487);
		}
		internal static global::MonoJavaBridge.MethodId _getSupplicantState5488;
		public virtual global::android.net.wifi.SupplicantState getSupplicantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getSupplicantState5488)) as android.net.wifi.SupplicantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getSupplicantState5488)) as android.net.wifi.SupplicantState;
		}
		internal static global::MonoJavaBridge.MethodId _getIpAddress5489;
		public virtual int getIpAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getIpAddress5489);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getIpAddress5489);
		}
		internal static global::MonoJavaBridge.MethodId _getHiddenSSID5490;
		public virtual bool getHiddenSSID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiInfo._getHiddenSSID5490);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getHiddenSSID5490);
		}
		internal static global::MonoJavaBridge.MethodId _getDetailedStateOf5491;
		public static global::android.net.NetworkInfo.DetailedState getDetailedStateOf(android.net.wifi.SupplicantState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getDetailedStateOf5491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.DetailedState;
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
			global::android.net.wifi.WifiInfo._toString5479 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.wifi.WifiInfo._writeToParcel5480 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.wifi.WifiInfo._describeContents5481 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "describeContents", "()I");
			global::android.net.wifi.WifiInfo._getSSID5482 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getSSID", "()Ljava/lang/String;");
			global::android.net.wifi.WifiInfo._getBSSID5483 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getBSSID", "()Ljava/lang/String;");
			global::android.net.wifi.WifiInfo._getRssi5484 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getRssi", "()I");
			global::android.net.wifi.WifiInfo._getLinkSpeed5485 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getLinkSpeed", "()I");
			global::android.net.wifi.WifiInfo._getMacAddress5486 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getMacAddress", "()Ljava/lang/String;");
			global::android.net.wifi.WifiInfo._getNetworkId5487 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getNetworkId", "()I");
			global::android.net.wifi.WifiInfo._getSupplicantState5488 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getSupplicantState", "()Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.WifiInfo._getIpAddress5489 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getIpAddress", "()I");
			global::android.net.wifi.WifiInfo._getHiddenSSID5490 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getHiddenSSID", "()Z");
			global::android.net.wifi.WifiInfo._getDetailedStateOf5491 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.WifiInfo.staticClass, "getDetailedStateOf", "(Landroid/net/wifi/SupplicantState;)Landroid/net/NetworkInfo$DetailedState;");
		}
	}
}
