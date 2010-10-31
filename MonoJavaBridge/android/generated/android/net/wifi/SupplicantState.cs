namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SupplicantState : java.lang.Enum, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SupplicantState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.net.wifi.SupplicantState[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.SupplicantState._m0.native == global::System.IntPtr.Zero)
				global::android.net.wifi.SupplicantState._m0 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "values", "()[Landroid/net/wifi/SupplicantState;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.wifi.SupplicantState>(@__env.CallStaticObjectMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._m0)) as android.net.wifi.SupplicantState[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.net.wifi.SupplicantState valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.SupplicantState._m1.native == global::System.IntPtr.Zero)
				global::android.net.wifi.SupplicantState._m1 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/wifi/SupplicantState;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.CallStaticObjectMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.SupplicantState;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.SupplicantState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.net.wifi.SupplicantState._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.SupplicantState.staticClass, "describeContents", "()I", ref global::android.net.wifi.SupplicantState._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool isValidState(android.net.wifi.SupplicantState arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.SupplicantState._m4.native == global::System.IntPtr.Zero)
				global::android.net.wifi.SupplicantState._m4 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "isValidState", "(Landroid/net/wifi/SupplicantState;)Z");
			return @__env.CallStaticBooleanMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.FieldId _ASSOCIATED3030;
		public static global::android.net.wifi.SupplicantState ASSOCIATED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _ASSOCIATED3030)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ASSOCIATING3031;
		public static global::android.net.wifi.SupplicantState ASSOCIATING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _ASSOCIATING3031)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _COMPLETED3032;
		public static global::android.net.wifi.SupplicantState COMPLETED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _COMPLETED3032)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DISCONNECTED3033;
		public static global::android.net.wifi.SupplicantState DISCONNECTED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _DISCONNECTED3033)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DORMANT3034;
		public static global::android.net.wifi.SupplicantState DORMANT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _DORMANT3034)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FOUR_WAY_HANDSHAKE3035;
		public static global::android.net.wifi.SupplicantState FOUR_WAY_HANDSHAKE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _FOUR_WAY_HANDSHAKE3035)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GROUP_HANDSHAKE3036;
		public static global::android.net.wifi.SupplicantState GROUP_HANDSHAKE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _GROUP_HANDSHAKE3036)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INACTIVE3037;
		public static global::android.net.wifi.SupplicantState INACTIVE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _INACTIVE3037)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INVALID3038;
		public static global::android.net.wifi.SupplicantState INVALID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _INVALID3038)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SCANNING3039;
		public static global::android.net.wifi.SupplicantState SCANNING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _SCANNING3039)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _UNINITIALIZED3040;
		public static global::android.net.wifi.SupplicantState UNINITIALIZED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _UNINITIALIZED3040)) as android.net.wifi.SupplicantState;
			}
		}
		static SupplicantState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.SupplicantState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/SupplicantState"));
			global::android.net.wifi.SupplicantState._ASSOCIATED3030 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "ASSOCIATED", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._ASSOCIATING3031 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "ASSOCIATING", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._COMPLETED3032 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "COMPLETED", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._DISCONNECTED3033 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "DISCONNECTED", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._DORMANT3034 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "DORMANT", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._FOUR_WAY_HANDSHAKE3035 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "FOUR_WAY_HANDSHAKE", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._GROUP_HANDSHAKE3036 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "GROUP_HANDSHAKE", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._INACTIVE3037 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "INACTIVE", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._INVALID3038 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "INVALID", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._SCANNING3039 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "SCANNING", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._UNINITIALIZED3040 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "UNINITIALIZED", "Landroid/net/wifi/SupplicantState;");
		}
	}
}
