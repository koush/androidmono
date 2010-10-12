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
		internal static global::MonoJavaBridge.MethodId _values5439;
		public static global::android.net.wifi.SupplicantState[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.wifi.SupplicantState>(@__env.CallStaticObjectMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._values5439)) as android.net.wifi.SupplicantState[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf5440;
		public static global::android.net.wifi.SupplicantState valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._valueOf5440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.wifi.SupplicantState;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5441;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.SupplicantState._writeToParcel5441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._writeToParcel5441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5442;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.SupplicantState._describeContents5442);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._describeContents5442);
		}
		internal static global::MonoJavaBridge.MethodId _isValidState5443;
		public static bool isValidState(android.net.wifi.SupplicantState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.net.wifi.SupplicantState.staticClass, global::android.net.wifi.SupplicantState._isValidState5443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.FieldId _ASSOCIATED5444;
		public static global::android.net.wifi.SupplicantState ASSOCIATED
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ASSOCIATING5445;
		public static global::android.net.wifi.SupplicantState ASSOCIATING
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _COMPLETED5446;
		public static global::android.net.wifi.SupplicantState COMPLETED
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DISCONNECTED5447;
		public static global::android.net.wifi.SupplicantState DISCONNECTED
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DORMANT5448;
		public static global::android.net.wifi.SupplicantState DORMANT
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FOUR_WAY_HANDSHAKE5449;
		public static global::android.net.wifi.SupplicantState FOUR_WAY_HANDSHAKE
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GROUP_HANDSHAKE5450;
		public static global::android.net.wifi.SupplicantState GROUP_HANDSHAKE
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _INACTIVE5451;
		public static global::android.net.wifi.SupplicantState INACTIVE
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _INVALID5452;
		public static global::android.net.wifi.SupplicantState INVALID
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SCANNING5453;
		public static global::android.net.wifi.SupplicantState SCANNING
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		internal static global::MonoJavaBridge.FieldId _UNINITIALIZED5454;
		public static global::android.net.wifi.SupplicantState UNINITIALIZED
		{
			get
			{
				return default(global::android.net.wifi.SupplicantState);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.SupplicantState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/SupplicantState"));
			global::android.net.wifi.SupplicantState._values5439 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "values", "()[Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._valueOf5440 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/wifi/SupplicantState;");
			global::android.net.wifi.SupplicantState._writeToParcel5441 = @__env.GetMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.wifi.SupplicantState._describeContents5442 = @__env.GetMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "describeContents", "()I");
			global::android.net.wifi.SupplicantState._isValidState5443 = @__env.GetStaticMethodIDNoThrow(global::android.net.wifi.SupplicantState.staticClass, "isValidState", "(Landroid/net/wifi/SupplicantState;)Z");
		}
	}
}
