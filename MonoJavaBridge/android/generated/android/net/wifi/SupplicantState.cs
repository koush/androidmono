namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SupplicantState : java.lang.Enum, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SupplicantState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values7981;
		public static global::android.net.wifi.SupplicantState[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.wifi.SupplicantState>(@__env.CallStaticObjectMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._values7981)) as android.net.wifi.SupplicantState[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf7982;
		public static global::android.net.wifi.SupplicantState valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.CallStaticObjectMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._valueOf7982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.SupplicantState;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7983;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._writeToParcel7983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7984;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._describeContents7984);
		}
		internal static global::MonoJavaBridge.MethodId _isValidState7985;
		public static bool isValidState(android.net.wifi.SupplicantState arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._isValidState7985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.FieldId _ASSOCIATED7986;
		public static global::android.net.wifi.SupplicantState ASSOCIATED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _ASSOCIATED7986)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ASSOCIATING7987;
		public static global::android.net.wifi.SupplicantState ASSOCIATING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _ASSOCIATING7987)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _COMPLETED7988;
		public static global::android.net.wifi.SupplicantState COMPLETED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _COMPLETED7988)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DISCONNECTED7989;
		public static global::android.net.wifi.SupplicantState DISCONNECTED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _DISCONNECTED7989)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DORMANT7990;
		public static global::android.net.wifi.SupplicantState DORMANT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _DORMANT7990)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FOUR_WAY_HANDSHAKE7991;
		public static global::android.net.wifi.SupplicantState FOUR_WAY_HANDSHAKE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _FOUR_WAY_HANDSHAKE7991)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GROUP_HANDSHAKE7992;
		public static global::android.net.wifi.SupplicantState GROUP_HANDSHAKE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _GROUP_HANDSHAKE7992)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INACTIVE7993;
		public static global::android.net.wifi.SupplicantState INACTIVE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _INACTIVE7993)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _INVALID7994;
		public static global::android.net.wifi.SupplicantState INVALID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _INVALID7994)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SCANNING7995;
		public static global::android.net.wifi.SupplicantState SCANNING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _SCANNING7995)) as android.net.wifi.SupplicantState;
			}
		}
		internal static global::MonoJavaBridge.FieldId _UNINITIALIZED7996;
		public static global::android.net.wifi.SupplicantState UNINITIALIZED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.wifi.SupplicantState>(@__env.GetStaticObjectField(global::android.net.wifi.SupplicantState.staticClass, _UNINITIALIZED7996)) as android.net.wifi.SupplicantState;
			}
		}
		static SupplicantState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.SupplicantState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/SupplicantState"));
			global::android.net.wifi.SupplicantState._values7981 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "values", "()[Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._valueOf7982 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._writeToParcel7983 = @__env.GetMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.wifi.SupplicantState._describeContents7984 = @__env.GetMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "describeContents", "()I");
			global::android.net.wifi.SupplicantState._isValidState7985 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "isValidState", "(Landroid/net/wifi/SupplicantState;)Z");
			global::android.net.wifi.SupplicantState._ASSOCIATED7986 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "ASSOCIATED", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._ASSOCIATING7987 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "ASSOCIATING", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._COMPLETED7988 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "COMPLETED", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._DISCONNECTED7989 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "DISCONNECTED", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._DORMANT7990 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "DORMANT", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._FOUR_WAY_HANDSHAKE7991 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "FOUR_WAY_HANDSHAKE", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._GROUP_HANDSHAKE7992 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "GROUP_HANDSHAKE", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._INACTIVE7993 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "INACTIVE", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._INVALID7994 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "INVALID", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._SCANNING7995 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "SCANNING", "Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._UNINITIALIZED7996 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "UNINITIALIZED", "Landroid/net/wifi/SupplicantState;");
		}
		internal static void InitJNI()
		{
		}
	}
}
