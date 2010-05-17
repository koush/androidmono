namespace android.net.wifi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class SupplicantState : java.lang.Enum, android.os.Parcelable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SupplicantState() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.SupplicantState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _valueOf4608; 
		public static android.net.wifi.SupplicantState valueOf(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.wifi.SupplicantState>(@__env, @__env.CallStaticObjectMethodPtr(android.net.wifi.SupplicantState.staticClass, _valueOf4608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values4609; 
		public static android.net.wifi.SupplicantState[] values() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.net.wifi.SupplicantState.staticClass, _values4609)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4610; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.SupplicantState)) 
				@__env.CallVoidMethod(this, _writeToParcel4610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.wifi.SupplicantState.staticClass, _writeToParcel4610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4611; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.SupplicantState)) 
				return @__env.CallIntMethod(this, _describeContents4611); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.SupplicantState.staticClass, _describeContents4611); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isValidState4612; 
		public static bool isValidState(android.net.wifi.SupplicantState arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.net.wifi.SupplicantState.staticClass, _isValidState4612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ASSOCIATED4613; 
		public static android.net.wifi.SupplicantState ASSOCIATED
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ASSOCIATING4614; 
		public static android.net.wifi.SupplicantState ASSOCIATING
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _COMPLETED4615; 
		public static android.net.wifi.SupplicantState COMPLETED
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTED4616; 
		public static android.net.wifi.SupplicantState DISCONNECTED
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DORMANT4617; 
		public static android.net.wifi.SupplicantState DORMANT
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _FOUR_WAY_HANDSHAKE4618; 
		public static android.net.wifi.SupplicantState FOUR_WAY_HANDSHAKE
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _GROUP_HANDSHAKE4619; 
		public static android.net.wifi.SupplicantState GROUP_HANDSHAKE
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _INACTIVE4620; 
		public static android.net.wifi.SupplicantState INACTIVE
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _INVALID4621; 
		public static android.net.wifi.SupplicantState INVALID
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SCANNING4622; 
		public static android.net.wifi.SupplicantState SCANNING
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _UNINITIALIZED4623; 
		public static android.net.wifi.SupplicantState UNINITIALIZED
		{ 
			get 
			{ 
				return default(android.net.wifi.SupplicantState); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.wifi.SupplicantState.staticClass = @__class; 
			global::android.net.wifi.SupplicantState._valueOf4608 = @__env.GetStaticMethodID(global::android.net.wifi.SupplicantState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/wifi/SupplicantState;"); 
			global::android.net.wifi.SupplicantState._values4609 = @__env.GetStaticMethodID(global::android.net.wifi.SupplicantState.staticClass, "values", "()[Landroid/net/wifi/SupplicantState;"); 
			global::android.net.wifi.SupplicantState._writeToParcel4610 = @__env.GetMethodID(global::android.net.wifi.SupplicantState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.wifi.SupplicantState._describeContents4611 = @__env.GetMethodID(global::android.net.wifi.SupplicantState.staticClass, "describeContents", "()I"); 
			global::android.net.wifi.SupplicantState._isValidState4612 = @__env.GetStaticMethodID(global::android.net.wifi.SupplicantState.staticClass, "isValidState", "(Landroid/net/wifi/SupplicantState;)Z"); 
		} 
	} 
} 
