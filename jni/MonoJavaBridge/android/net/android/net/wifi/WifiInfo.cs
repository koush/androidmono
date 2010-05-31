namespace android.net.wifi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WifiInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WifiInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.wifi.WifiInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.wifi.WifiInfo(@__env); 
			} 
		} 
		protected WifiInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4897; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.wifi.WifiInfo._toString4897)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._toString4897)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4898; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.wifi.WifiInfo._writeToParcel4898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._writeToParcel4898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4899; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.wifi.WifiInfo._describeContents4899); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._describeContents4899); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSSID4900; 
		public virtual global::java.lang.String getSSID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.wifi.WifiInfo._getSSID4900)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getSSID4900)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBSSID4901; 
		public virtual global::java.lang.String getBSSID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.wifi.WifiInfo._getBSSID4901)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getBSSID4901)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRssi4902; 
		public virtual int getRssi() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.wifi.WifiInfo._getRssi4902); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getRssi4902); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLinkSpeed4903; 
		public virtual int getLinkSpeed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.wifi.WifiInfo._getLinkSpeed4903); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getLinkSpeed4903); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMacAddress4904; 
		public virtual global::java.lang.String getMacAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.wifi.WifiInfo._getMacAddress4904)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getMacAddress4904)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkId4905; 
		public virtual int getNetworkId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.wifi.WifiInfo._getNetworkId4905); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getNetworkId4905); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSupplicantState4906; 
		public virtual global::android.net.wifi.SupplicantState getSupplicantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.SupplicantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.wifi.WifiInfo._getSupplicantState4906)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.SupplicantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getSupplicantState4906)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIpAddress4907; 
		public virtual int getIpAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.wifi.WifiInfo._getIpAddress4907); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getIpAddress4907); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHiddenSSID4908; 
		public virtual bool getHiddenSSID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.wifi.WifiInfo._getHiddenSSID4908); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getHiddenSSID4908); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDetailedStateOf4909; 
		public static global::android.net.NetworkInfo.DetailedState getDetailedStateOf(android.net.wifi.SupplicantState arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.DetailedState>(@__env, @__env.CallStaticObjectMethodPtr(android.net.wifi.WifiInfo.staticClass, global::android.net.wifi.WifiInfo._getDetailedStateOf4909, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		public static global::java.lang.String LINK_SPEED_UNITS
		{ 
			get 
			{ 
				return "Mbps"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.wifi.WifiInfo.staticClass = @__class; 
			global::android.net.wifi.WifiInfo._toString4897 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiInfo._writeToParcel4898 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.wifi.WifiInfo._describeContents4899 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "describeContents", "()I"); 
			global::android.net.wifi.WifiInfo._getSSID4900 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getSSID", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiInfo._getBSSID4901 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getBSSID", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiInfo._getRssi4902 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getRssi", "()I"); 
			global::android.net.wifi.WifiInfo._getLinkSpeed4903 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getLinkSpeed", "()I"); 
			global::android.net.wifi.WifiInfo._getMacAddress4904 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getMacAddress", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiInfo._getNetworkId4905 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getNetworkId", "()I"); 
			global::android.net.wifi.WifiInfo._getSupplicantState4906 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getSupplicantState", "()Landroid/net/wifi/SupplicantState;"); 
			global::android.net.wifi.WifiInfo._getIpAddress4907 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getIpAddress", "()I"); 
			global::android.net.wifi.WifiInfo._getHiddenSSID4908 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getHiddenSSID", "()Z"); 
			global::android.net.wifi.WifiInfo._getDetailedStateOf4909 = @__env.GetStaticMethodID(global::android.net.wifi.WifiInfo.staticClass, "getDetailedStateOf", "(Landroid/net/wifi/SupplicantState;)Landroid/net/NetworkInfo$DetailedState;"); 
		} 
	} 
} 
