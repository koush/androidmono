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
			internal static global::MonoJavaBridge.FieldId _strings8001;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass, _strings8001)) as java.lang.String[];
				}
			}
			static AuthAlgorithm()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$AuthAlgorithm"));
				global::android.net.wifi.WifiConfiguration.AuthAlgorithm._strings8001 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass, "strings", "[Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.FieldId _strings8007;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass, _strings8007)) as java.lang.String[];
				}
			}
			static GroupCipher()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$GroupCipher"));
				global::android.net.wifi.WifiConfiguration.GroupCipher._strings8007 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass, "strings", "[Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.FieldId _strings8013;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass, _strings8013)) as java.lang.String[];
				}
			}
			static KeyMgmt()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$KeyMgmt"));
				global::android.net.wifi.WifiConfiguration.KeyMgmt._strings8013 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass, "strings", "[Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.FieldId _strings8018;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass, _strings8018)) as java.lang.String[];
				}
			}
			static PairwiseCipher()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$PairwiseCipher"));
				global::android.net.wifi.WifiConfiguration.PairwiseCipher._strings8018 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass, "strings", "[Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.FieldId _strings8022;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.Protocol.staticClass, _strings8022)) as java.lang.String[];
				}
			}
			static Protocol()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.Protocol.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$Protocol"));
				global::android.net.wifi.WifiConfiguration.Protocol._strings8022 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.Protocol.staticClass, "strings", "[Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.FieldId _strings8026;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.Status.staticClass, _strings8026)) as java.lang.String[];
				}
			}
			static Status()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$Status"));
				global::android.net.wifi.WifiConfiguration.Status._strings8026 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.Status.staticClass, "strings", "[Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString8027;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiConfiguration._toString8027.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiConfiguration._toString8027 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._toString8027) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8028;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiConfiguration._writeToParcel8028.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiConfiguration._writeToParcel8028 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._writeToParcel8028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8029;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiConfiguration._describeContents8029.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiConfiguration._describeContents8029 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._describeContents8029);
		}
		internal static global::MonoJavaBridge.MethodId _WifiConfiguration8030;
		public WifiConfiguration() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.WifiConfiguration._WifiConfiguration8030.native == global::System.IntPtr.Zero)
				global::android.net.wifi.WifiConfiguration._WifiConfiguration8030 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._WifiConfiguration8030);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _networkId8031;
		public int networkId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _networkId8031);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _status8032;
		public int status
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _status8032);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _SSID8033;
		public global::java.lang.String SSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _SSID8033)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _BSSID8034;
		public global::java.lang.String BSSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _BSSID8034)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _preSharedKey8035;
		public global::java.lang.String preSharedKey
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _preSharedKey8035)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _wepKeys8036;
		public global::java.lang.String[] wepKeys
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _wepKeys8036)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _wepTxKeyIndex8037;
		public int wepTxKeyIndex
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _wepTxKeyIndex8037);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _priority8038;
		public int priority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _priority8038);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hiddenSSID8039;
		public bool hiddenSSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _hiddenSSID8039);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedKeyManagement8040;
		public global::java.util.BitSet allowedKeyManagement
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedKeyManagement8040)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedProtocols8041;
		public global::java.util.BitSet allowedProtocols
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedProtocols8041)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedAuthAlgorithms8042;
		public global::java.util.BitSet allowedAuthAlgorithms
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedAuthAlgorithms8042)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedPairwiseCiphers8043;
		public global::java.util.BitSet allowedPairwiseCiphers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedPairwiseCiphers8043)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedGroupCiphers8044;
		public global::java.util.BitSet allowedGroupCiphers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedGroupCiphers8044)) as java.util.BitSet;
			}
			set
			{
			}
		}
		static WifiConfiguration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.WifiConfiguration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration"));
			global::android.net.wifi.WifiConfiguration._networkId8031 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "networkId", "I");
			global::android.net.wifi.WifiConfiguration._status8032 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "status", "I");
			global::android.net.wifi.WifiConfiguration._SSID8033 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "SSID", "Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._BSSID8034 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "BSSID", "Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._preSharedKey8035 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "preSharedKey", "Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._wepKeys8036 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "wepKeys", "[Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._wepTxKeyIndex8037 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "wepTxKeyIndex", "I");
			global::android.net.wifi.WifiConfiguration._priority8038 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "priority", "I");
			global::android.net.wifi.WifiConfiguration._hiddenSSID8039 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "hiddenSSID", "Z");
			global::android.net.wifi.WifiConfiguration._allowedKeyManagement8040 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedKeyManagement", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedProtocols8041 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedProtocols", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedAuthAlgorithms8042 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedAuthAlgorithms", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedPairwiseCiphers8043 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedPairwiseCiphers", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedGroupCiphers8044 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedGroupCiphers", "Ljava/util/BitSet;");
		}
		internal static void InitJNI()
		{
		}
	}
}
