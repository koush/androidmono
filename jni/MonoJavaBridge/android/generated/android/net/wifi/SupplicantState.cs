namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SupplicantState : java.lang.Enum, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SupplicantState()
		{
			InitJNI();
		}
		internal SupplicantState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values7941;
		public static global::android.net.wifi.SupplicantState[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.wifi.SupplicantState>(@__env.CallStaticObjectMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._values7941)) as android.net.wifi.SupplicantState[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf7942;
		public static global::android.net.wifi.SupplicantState valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.CallStaticObjectMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._valueOf7942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.SupplicantState;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7943;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.SupplicantState._writeToParcel7943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._writeToParcel7943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7944;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.SupplicantState._describeContents7944);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._describeContents7944);
		}
		internal static global::MonoJavaBridge.MethodId _isValidState7945;
		public static bool isValidState(android.net.wifi.SupplicantState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._isValidState7945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.FieldId _ASSOCIATED7946;
		public static global::android.net.wifi.SupplicantState ASSOCIATED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _ASSOCIATED7946)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ASSOCIATING7947;
		public static global::android.net.wifi.SupplicantState ASSOCIATING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _ASSOCIATING7947)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _COMPLETED7948;
		public static global::android.net.wifi.SupplicantState COMPLETED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _COMPLETED7948)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DISCONNECTED7949;
		public static global::android.net.wifi.SupplicantState DISCONNECTED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _DISCONNECTED7949)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DORMANT7950;
		public static global::android.net.wifi.SupplicantState DORMANT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _DORMANT7950)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FOUR_WAY_HANDSHAKE7951;
		public static global::android.net.wifi.SupplicantState FOUR_WAY_HANDSHAKE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _FOUR_WAY_HANDSHAKE7951)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GROUP_HANDSHAKE7952;
		public static global::android.net.wifi.SupplicantState GROUP_HANDSHAKE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _GROUP_HANDSHAKE7952)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INACTIVE7953;
		public static global::android.net.wifi.SupplicantState INACTIVE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _INACTIVE7953)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INVALID7954;
		public static global::android.net.wifi.SupplicantState INVALID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _INVALID7954)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SCANNING7955;
		public static global::android.net.wifi.SupplicantState SCANNING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _SCANNING7955)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _UNINITIALIZED7956;
		public static global::android.net.wifi.SupplicantState UNINITIALIZED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _UNINITIALIZED7956)) as android.net.wifi.SupplicantState;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.SupplicantState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/SupplicantState"));
			global::android.net.wifi.SupplicantState._values7941 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "values", "()[Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._valueOf7942 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._writeToParcel7943 = @__env.GetMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.wifi.SupplicantState._describeContents7944 = @__env.GetMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "describeContents", "()I");
			global::android.net.wifi.SupplicantState._isValidState7945 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "isValidState", "(Landroid/net/wifi/SupplicantState;)Z");
			global::android.net.wifi.SupplicantState._ASSOCIATED7946 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "ASSOCIATED", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._ASSOCIATING7947 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "ASSOCIATING", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._COMPLETED7948 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "COMPLETED", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._DISCONNECTED7949 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "DISCONNECTED", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._DORMANT7950 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "DORMANT", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._FOUR_WAY_HANDSHAKE7951 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "FOUR_WAY_HANDSHAKE", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._GROUP_HANDSHAKE7952 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "GROUP_HANDSHAKE", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._INACTIVE7953 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "INACTIVE", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._INVALID7954 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "INVALID", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._SCANNING7955 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "SCANNING", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._UNINITIALIZED7956 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "UNINITIALIZED", "Landroid/net/wifi/SupplicantState;");
		}
	}
}
