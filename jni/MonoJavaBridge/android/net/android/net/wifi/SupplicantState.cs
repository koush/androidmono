namespace android.net.wifi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class SupplicantState : java.lang.Enum, android.os.Parcelable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SupplicantState() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.wifi.SupplicantState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.wifi.SupplicantState(@__env); 
			} 
		} 
		internal SupplicantState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueOf4857; 
		public static global::android.net.wifi.SupplicantState valueOf(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.SupplicantState>(@__env, @__env.CallStaticObjectMethodPtr(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._valueOf4857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values4858; 
		public static global::android.net.wifi.SupplicantState[] values() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._values4858)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4859; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.wifi.SupplicantState._writeToParcel4859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._writeToParcel4859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4860; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.wifi.SupplicantState._describeContents4860); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._describeContents4860); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isValidState4861; 
		public static bool isValidState(android.net.wifi.SupplicantState arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._isValidState4861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ASSOCIATED4862; 
		public static global::android.net.wifi.SupplicantState ASSOCIATED
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ASSOCIATING4863; 
		public static global::android.net.wifi.SupplicantState ASSOCIATING
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _COMPLETED4864; 
		public static global::android.net.wifi.SupplicantState COMPLETED
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTED4865; 
		public static global::android.net.wifi.SupplicantState DISCONNECTED
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DORMANT4866; 
		public static global::android.net.wifi.SupplicantState DORMANT
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _FOUR_WAY_HANDSHAKE4867; 
		public static global::android.net.wifi.SupplicantState FOUR_WAY_HANDSHAKE
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _GROUP_HANDSHAKE4868; 
		public static global::android.net.wifi.SupplicantState GROUP_HANDSHAKE
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _INACTIVE4869; 
		public static global::android.net.wifi.SupplicantState INACTIVE
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _INVALID4870; 
		public static global::android.net.wifi.SupplicantState INVALID
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SCANNING4871; 
		public static global::android.net.wifi.SupplicantState SCANNING
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _UNINITIALIZED4872; 
		public static global::android.net.wifi.SupplicantState UNINITIALIZED
		{ 
			get 
			{ 
				return default(global::android.net.wifi.SupplicantState); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.wifi.SupplicantState.staticClass = @__class; 
			global::android.net.wifi.SupplicantState._valueOf4857 = @__env.GetStaticMethodID(global::android.net.wifi.SupplicantState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/wifi/SupplicantState;"); 
			global::android.net.wifi.SupplicantState._values4858 = @__env.GetStaticMethodID(global::android.net.wifi.SupplicantState.staticClass, "values", "()[Landroid/net/wifi/SupplicantState;"); 
			global::android.net.wifi.SupplicantState._writeToParcel4859 = @__env.GetMethodID(global::android.net.wifi.SupplicantState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.wifi.SupplicantState._describeContents4860 = @__env.GetMethodID(global::android.net.wifi.SupplicantState.staticClass, "describeContents", "()I"); 
			global::android.net.wifi.SupplicantState._isValidState4861 = @__env.GetStaticMethodID(global::android.net.wifi.SupplicantState.staticClass, "isValidState", "(Landroid/net/wifi/SupplicantState;)Z"); 
		} 
	} 
} 
