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
			internal static global::MonoJavaBridge.FieldId _strings5455;
			public static global::java.lang.String[] strings
			{
				get
				{
					return default(global::java.lang.String[]);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$AuthAlgorithm"));
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
			internal static global::MonoJavaBridge.FieldId _strings5456;
			public static global::java.lang.String[] strings
			{
				get
				{
					return default(global::java.lang.String[]);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$GroupCipher"));
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
			internal static global::MonoJavaBridge.FieldId _strings5457;
			public static global::java.lang.String[] strings
			{
				get
				{
					return default(global::java.lang.String[]);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$KeyMgmt"));
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
			internal static global::MonoJavaBridge.FieldId _strings5458;
			public static global::java.lang.String[] strings
			{
				get
				{
					return default(global::java.lang.String[]);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$PairwiseCipher"));
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
			internal static global::MonoJavaBridge.FieldId _strings5459;
			public static global::java.lang.String[] strings
			{
				get
				{
					return default(global::java.lang.String[]);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.Protocol.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$Protocol"));
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
			internal static global::MonoJavaBridge.FieldId _strings5460;
			public static global::java.lang.String[] strings
			{
				get
				{
					return default(global::java.lang.String[]);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.wifi.WifiConfiguration.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration$Status"));
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString5461;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration._toString5461)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._toString5461)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5462;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration._writeToParcel5462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._writeToParcel5462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5463;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration._describeContents5463);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._describeContents5463);
		}
		internal static global::MonoJavaBridge.MethodId _WifiConfiguration5464;
		public WifiConfiguration()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._WifiConfiguration5464);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _networkId5465;
		public int networkId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _status5466;
		public int status
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _SSID5467;
		public global::java.lang.String SSID
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _BSSID5468;
		public global::java.lang.String BSSID
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _preSharedKey5469;
		public global::java.lang.String preSharedKey
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _wepKeys5470;
		public global::java.lang.String[] wepKeys
		{
			get
			{
				return default(global::java.lang.String[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _wepTxKeyIndex5471;
		public int wepTxKeyIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _priority5472;
		public int priority
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hiddenSSID5473;
		public bool hiddenSSID
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedKeyManagement5474;
		public global::java.util.BitSet allowedKeyManagement
		{
			get
			{
				return default(global::java.util.BitSet);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedProtocols5475;
		public global::java.util.BitSet allowedProtocols
		{
			get
			{
				return default(global::java.util.BitSet);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedAuthAlgorithms5476;
		public global::java.util.BitSet allowedAuthAlgorithms
		{
			get
			{
				return default(global::java.util.BitSet);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedPairwiseCiphers5477;
		public global::java.util.BitSet allowedPairwiseCiphers
		{
			get
			{
				return default(global::java.util.BitSet);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _allowedGroupCiphers5478;
		public global::java.util.BitSet allowedGroupCiphers
		{
			get
			{
				return default(global::java.util.BitSet);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.WifiConfiguration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/WifiConfiguration"));
			global::android.net.wifi.WifiConfiguration._toString5461 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.wifi.WifiConfiguration._writeToParcel5462 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.wifi.WifiConfiguration._describeContents5463 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "describeContents", "()I");
			global::android.net.wifi.WifiConfiguration._WifiConfiguration5464 = @__env.GetMethodIDNoThrow(global::android.net.wifi.WifiConfiguration.staticClass, "<init>", "()V");
		}
	}
}
