namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WifiConfiguration : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WifiConfiguration()
		{
			InitJNI();
		}
		protected WifiConfiguration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AuthAlgorithm : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AuthAlgorithm()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.FieldId _strings7961;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass, _strings7961)) as java.lang.String[];
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$AuthAlgorithm"));
				global::android.net.wifi.WifiConfiguration.AuthAlgorithm._strings7961 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class GroupCipher : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static GroupCipher()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.FieldId _strings7967;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass, _strings7967)) as java.lang.String[];
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$GroupCipher"));
				global::android.net.wifi.WifiConfiguration.GroupCipher._strings7967 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class KeyMgmt : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static KeyMgmt()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.FieldId _strings7973;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass, _strings7973)) as java.lang.String[];
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$KeyMgmt"));
				global::android.net.wifi.WifiConfiguration.KeyMgmt._strings7973 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class PairwiseCipher : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PairwiseCipher()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.FieldId _strings7978;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass, _strings7978)) as java.lang.String[];
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$PairwiseCipher"));
				global::android.net.wifi.WifiConfiguration.PairwiseCipher._strings7978 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Protocol : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Protocol()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.FieldId _strings7982;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.Protocol.staticClass, _strings7982)) as java.lang.String[];
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.Protocol.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$Protocol"));
				global::android.net.wifi.WifiConfiguration.Protocol._strings7982 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.Protocol.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Status : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Status()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.FieldId _strings7986;
			public static global::java.lang.String[] strings
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::android.net.wifi.WifiConfiguration.Status.staticClass, _strings7986)) as java.lang.String[];
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$Status"));
				global::android.net.wifi.WifiConfiguration.Status._strings7986 = @__env.GetStaticFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.Status.staticClass, "strings", "[Ljava/lang/String;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString7987;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration._toString7987)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._toString7987)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7988;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration._writeToParcel7988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._writeToParcel7988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7989;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration._describeContents7989);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._describeContents7989);
		}
		internal static global::MonoJavaBridge.MethodId _WifiConfiguration7990;
		public WifiConfiguration()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._WifiConfiguration7990);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _networkId7991;
		public int networkId
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _networkId7991);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _status7992;
		public int status
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _status7992);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _SSID7993;
		public global::java.lang.String SSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _SSID7993)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _BSSID7994;
		public global::java.lang.String BSSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _BSSID7994)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _preSharedKey7995;
		public global::java.lang.String preSharedKey
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _preSharedKey7995)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _wepKeys7996;
		public global::java.lang.String[] wepKeys
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _wepKeys7996)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _wepTxKeyIndex7997;
		public int wepTxKeyIndex
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _wepTxKeyIndex7997);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _priority7998;
		public int priority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _priority7998);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hiddenSSID7999;
		public bool hiddenSSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _hiddenSSID7999);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedKeyManagement8000;
		public global::java.util.BitSet allowedKeyManagement
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedKeyManagement8000)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedProtocols8001;
		public global::java.util.BitSet allowedProtocols
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedProtocols8001)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedAuthAlgorithms8002;
		public global::java.util.BitSet allowedAuthAlgorithms
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedAuthAlgorithms8002)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedPairwiseCiphers8003;
		public global::java.util.BitSet allowedPairwiseCiphers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedPairwiseCiphers8003)) as java.util.BitSet;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedGroupCiphers8004;
		public global::java.util.BitSet allowedGroupCiphers
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _allowedGroupCiphers8004)) as java.util.BitSet;
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.WifiConfiguration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration"));
			global::android.net.wifi.WifiConfiguration._toString7987 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._writeToParcel7988 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.wifi.WifiConfiguration._describeContents7989 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "describeContents", "()I");
			global::android.net.wifi.WifiConfiguration._WifiConfiguration7990 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "<init>", "()V");
			global::android.net.wifi.WifiConfiguration._networkId7991 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "networkId", "I");
			global::android.net.wifi.WifiConfiguration._status7992 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "status", "I");
			global::android.net.wifi.WifiConfiguration._SSID7993 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "SSID", "Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._BSSID7994 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "BSSID", "Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._preSharedKey7995 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "preSharedKey", "Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._wepKeys7996 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "wepKeys", "[Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._wepTxKeyIndex7997 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "wepTxKeyIndex", "I");
			global::android.net.wifi.WifiConfiguration._priority7998 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "priority", "I");
			global::android.net.wifi.WifiConfiguration._hiddenSSID7999 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "hiddenSSID", "Z");
			global::android.net.wifi.WifiConfiguration._allowedKeyManagement8000 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedKeyManagement", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedProtocols8001 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedProtocols", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedAuthAlgorithms8002 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedAuthAlgorithms", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedPairwiseCiphers8003 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedPairwiseCiphers", "Ljava/util/BitSet;");
			global::android.net.wifi.WifiConfiguration._allowedGroupCiphers8004 = @__env.GetFieldIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "allowedGroupCiphers", "Ljava/util/BitSet;");
		}
	}
}
