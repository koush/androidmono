namespace android.net.wifi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WifiInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WifiInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString4648; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4648)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiInfo.staticClass, _toString4648)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4649; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel4649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.wifi.WifiInfo.staticClass, _writeToParcel4649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4650; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return @__env.CallIntMethod(this, _describeContents4650); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.WifiInfo.staticClass, _describeContents4650); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSSID4651; 
		public virtual java.lang.String getSSID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSSID4651)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiInfo.staticClass, _getSSID4651)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBSSID4652; 
		public virtual java.lang.String getBSSID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getBSSID4652)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiInfo.staticClass, _getBSSID4652)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRssi4653; 
		public virtual int getRssi() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return @__env.CallIntMethod(this, _getRssi4653); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.WifiInfo.staticClass, _getRssi4653); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLinkSpeed4654; 
		public virtual int getLinkSpeed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return @__env.CallIntMethod(this, _getLinkSpeed4654); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.WifiInfo.staticClass, _getLinkSpeed4654); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMacAddress4655; 
		public virtual java.lang.String getMacAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getMacAddress4655)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiInfo.staticClass, _getMacAddress4655)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkId4656; 
		public virtual int getNetworkId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return @__env.CallIntMethod(this, _getNetworkId4656); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.WifiInfo.staticClass, _getNetworkId4656); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSupplicantState4657; 
		public virtual android.net.wifi.SupplicantState getSupplicantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.SupplicantState>(@__env, @__env.CallObjectMethodPtr(this, _getSupplicantState4657)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.SupplicantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiInfo.staticClass, _getSupplicantState4657)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIpAddress4658; 
		public virtual int getIpAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return @__env.CallIntMethod(this, _getIpAddress4658); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.WifiInfo.staticClass, _getIpAddress4658); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHiddenSSID4659; 
		public virtual bool getHiddenSSID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiInfo)) 
				return @__env.CallBooleanMethod(this, _getHiddenSSID4659); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.wifi.WifiInfo.staticClass, _getHiddenSSID4659); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDetailedStateOf4660; 
		public static android.net.NetworkInfo.DetailedState getDetailedStateOf(android.net.wifi.SupplicantState arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.DetailedState>(@__env, @__env.CallStaticObjectMethodPtr(android.net.wifi.WifiInfo.staticClass, _getDetailedStateOf4660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		public static java.lang.String LINK_SPEED_UNITS
		{ 
			get 
			{ 
				return "Mbps"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.wifi.WifiInfo.staticClass = @__class; 
			global::android.net.wifi.WifiInfo._toString4648 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiInfo._writeToParcel4649 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.wifi.WifiInfo._describeContents4650 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "describeContents", "()I"); 
			global::android.net.wifi.WifiInfo._getSSID4651 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getSSID", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiInfo._getBSSID4652 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getBSSID", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiInfo._getRssi4653 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getRssi", "()I"); 
			global::android.net.wifi.WifiInfo._getLinkSpeed4654 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getLinkSpeed", "()I"); 
			global::android.net.wifi.WifiInfo._getMacAddress4655 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getMacAddress", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiInfo._getNetworkId4656 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getNetworkId", "()I"); 
			global::android.net.wifi.WifiInfo._getSupplicantState4657 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getSupplicantState", "()Landroid/net/wifi/SupplicantState;"); 
			global::android.net.wifi.WifiInfo._getIpAddress4658 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getIpAddress", "()I"); 
			global::android.net.wifi.WifiInfo._getHiddenSSID4659 = @__env.GetMethodID(global::android.net.wifi.WifiInfo.staticClass, "getHiddenSSID", "()Z"); 
			global::android.net.wifi.WifiInfo._getDetailedStateOf4660 = @__env.GetStaticMethodID(global::android.net.wifi.WifiInfo.staticClass, "getDetailedStateOf", "(Landroid/net/wifi/SupplicantState;)Landroid/net/NetworkInfo$DetailedState;"); 
		} 
	} 
} 
