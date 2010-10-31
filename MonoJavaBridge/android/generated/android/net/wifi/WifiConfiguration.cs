namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WifiConfiguration : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WifiConfiguration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AuthAlgorithm : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AuthAlgorithm(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public static int OPEN
			{
				get
				{
					return 0;
				}
			}
			public static int SHARED
			{
				get
				{
					return 1;
				}
			}
			public static int LEAP
			{
				get
				{
					return 2;
				}
			}
			public static global::java.lang.String varName
			{
				get
				{
					return "auth_alg";
				}
			}
			internal static global::MonoJavaBridge.FieldId _strings3045;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass, _strings3045)) as java.lang.String[];
				}
			}
			static AuthAlgorithm()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$AuthAlgorithm"));
				global::android.net.wifi.WifiConfiguration.AuthAlgorithm._strings3045 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class GroupCipher : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected GroupCipher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public static int WEP40
			{
				get
				{
					return 0;
				}
			}
			public static int WEP104
			{
				get
				{
					return 1;
				}
			}
			public static int TKIP
			{
				get
				{
					return 2;
				}
			}
			public static int CCMP
			{
				get
				{
					return 3;
				}
			}
			public static global::java.lang.String varName
			{
				get
				{
					return "group";
				}
			}
			internal static global::MonoJavaBridge.FieldId _strings3051;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass, _strings3051)) as java.lang.String[];
				}
			}
			static GroupCipher()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$GroupCipher"));
				global::android.net.wifi.WifiConfiguration.GroupCipher._strings3051 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class KeyMgmt : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected KeyMgmt(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public static int NONE
			{
				get
				{
					return 0;
				}
			}
			public static int WPA_PSK
			{
				get
				{
					return 1;
				}
			}
			public static int WPA_EAP
			{
				get
				{
					return 2;
				}
			}
			public static int IEEE8021X
			{
				get
				{
					return 3;
				}
			}
			public static global::java.lang.String varName
			{
				get
				{
					return "key_mgmt";
				}
			}
			internal static global::MonoJavaBridge.FieldId _strings3057;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass, _strings3057)) as java.lang.String[];
				}
			}
			static KeyMgmt()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$KeyMgmt"));
				global::android.net.wifi.WifiConfiguration.KeyMgmt._strings3057 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class PairwiseCipher : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PairwiseCipher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public static int NONE
			{
				get
				{
					return 0;
				}
			}
			public static int TKIP
			{
				get
				{
					return 1;
				}
			}
			public static int CCMP
			{
				get
				{
					return 2;
				}
			}
			public static global::java.lang.String varName
			{
				get
				{
					return "pairwise";
				}
			}
			internal static global::MonoJavaBridge.FieldId _strings3062;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass, _strings3062)) as java.lang.String[];
				}
			}
			static PairwiseCipher()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$PairwiseCipher"));
				global::android.net.wifi.WifiConfiguration.PairwiseCipher._strings3062 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Protocol : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Protocol(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public static int WPA
			{
				get
				{
					return 0;
				}
			}
			public static int RSN
			{
				get
				{
					return 1;
				}
			}
			public static global::java.lang.String varName
			{
				get
				{
					return "proto";
				}
			}
			internal static global::MonoJavaBridge.FieldId _strings3066;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.Protocol.staticClass, _strings3066)) as java.lang.String[];
				}
			}
			static Protocol()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.Protocol.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$Protocol"));
				global::android.net.wifi.WifiConfiguration.Protocol._strings3066 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.Protocol.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Status : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Status(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public static int CURRENT
			{
				get
				{
					return 0;
				}
			}
			public static int DISABLED
			{
				get
				{
					return 1;
				}
			}
			public static int ENABLED
			{
				get
				{
					return 2;
				}
			}
			internal static global::MonoJavaBridge.FieldId _strings3070;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.Status.staticClass, _strings3070)) as java.lang.String[];
				}
			}
			static Status()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$Status"));
				global::android.net.wifi.WifiConfiguration.Status._strings3070 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.Status.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiConfiguration.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.wifi.WifiConfiguration._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiConfiguration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.net.wifi.WifiConfiguration._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiConfiguration.staticClass, "describeContents", "()I", ref global::android.net.wifi.WifiConfiguration._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public WifiConfiguration() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiConfiguration._m3.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiConfiguration._m3 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._m3);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _networkId3071;
		public int networkId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _networkId3071);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _status3072;
		public int status
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _status3072);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _SSID3073;
		public global::java.lang.String SSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _SSID3073)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _BSSID3074;
		public global::java.lang.String BSSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _BSSID3074)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _preSharedKey3075;
		public global::java.lang.String preSharedKey
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _preSharedKey3075)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _wepKeys3076;
		public global::java.lang.String[] wepKeys
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _wepKeys3076)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _wepTxKeyIndex3077;
		public int wepTxKeyIndex
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _wepTxKeyIndex3077);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _priority3078;
		public int priority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _priority3078);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hiddenSSID3079;
		public bool hiddenSSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _hiddenSSID3079);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedKeyManagement3080;
		public global::java.util.BitSet allowedKeyManagement
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedKeyManagement3080)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedProtocols3081;
		public global::java.util.BitSet allowedProtocols
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedProtocols3081)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedAuthAlgorithms3082;
		public global::java.util.BitSet allowedAuthAlgorithms
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedAuthAlgorithms3082)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedPairwiseCiphers3083;
		public global::java.util.BitSet allowedPairwiseCiphers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedPairwiseCiphers3083)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedGroupCiphers3084;
		public global::java.util.BitSet allowedGroupCiphers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedGroupCiphers3084)) as java.util.BitSet;
			}
			set
			{
			}
		}
		static WifiConfiguration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.WifiConfiguration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration"));
			global::android.net.wifi.WifiConfiguration._networkId3071 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "networkId", "I");
			global::android.net.wifi.WifiConfiguration._status3072 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "status", "I");
			global::android.net.wifi.WifiConfiguration._SSID3073 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "SSID", "Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._BSSID3074 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "BSSID", "Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._preSharedKey3075 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "preSharedKey", "Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._wepKeys3076 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "wepKeys", "[Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._wepTxKeyIndex3077 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "wepTxKeyIndex", "I");
			global::android.net.wifi.WifiConfiguration._priority3078 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "priority", "I");
			global::android.net.wifi.WifiConfiguration._hiddenSSID3079 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "hiddenSSID", "Z");
			global::android.net.wifi.WifiConfiguration._allowedKeyManagement3080 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedKeyManagement", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedProtocols3081 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedProtocols", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedAuthAlgorithms3082 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedAuthAlgorithms", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedPairwiseCiphers3083 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedPairwiseCiphers", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedGroupCiphers3084 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedGroupCiphers", "Ljava/util/BitSet;");
		}
	}
}
