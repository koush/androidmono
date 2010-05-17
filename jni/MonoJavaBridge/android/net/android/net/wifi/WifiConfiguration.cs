namespace android.net.wifi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WifiConfiguration : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WifiConfiguration() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiConfiguration), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.wifi.WifiConfiguration(@__env); 
			} 
		} 
		protected WifiConfiguration(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class AuthAlgorithm : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static AuthAlgorithm() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiConfiguration.AuthAlgorithm), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.wifi.WifiConfiguration.AuthAlgorithm(@__env); 
				} 
			} 
			protected AuthAlgorithm(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
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
			public static java.lang.String varName
			{ 
				get 
				{ 
					return "auth_alg"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4624; 
			public static java.lang.String[] strings
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.wifi.WifiConfiguration.AuthAlgorithm.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class GroupCipher : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static GroupCipher() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiConfiguration.GroupCipher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.wifi.WifiConfiguration.GroupCipher(@__env); 
				} 
			} 
			protected GroupCipher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
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
			public static java.lang.String varName
			{ 
				get 
				{ 
					return "group"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4625; 
			public static java.lang.String[] strings
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.wifi.WifiConfiguration.GroupCipher.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class KeyMgmt : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static KeyMgmt() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiConfiguration.KeyMgmt), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.wifi.WifiConfiguration.KeyMgmt(@__env); 
				} 
			} 
			protected KeyMgmt(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
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
			public static java.lang.String varName
			{ 
				get 
				{ 
					return "key_mgmt"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4626; 
			public static java.lang.String[] strings
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.wifi.WifiConfiguration.KeyMgmt.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class PairwiseCipher : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static PairwiseCipher() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiConfiguration.PairwiseCipher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.wifi.WifiConfiguration.PairwiseCipher(@__env); 
				} 
			} 
			protected PairwiseCipher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
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
			public static java.lang.String varName
			{ 
				get 
				{ 
					return "pairwise"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4627; 
			public static java.lang.String[] strings
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.wifi.WifiConfiguration.PairwiseCipher.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Protocol : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Protocol() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiConfiguration.Protocol), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.wifi.WifiConfiguration.Protocol(@__env); 
				} 
			} 
			protected Protocol(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
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
			public static java.lang.String varName
			{ 
				get 
				{ 
					return "proto"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4628; 
			public static java.lang.String[] strings
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.wifi.WifiConfiguration.Protocol.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Status : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Status() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.WifiConfiguration.Status), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.wifi.WifiConfiguration.Status(@__env); 
				} 
			} 
			protected Status(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
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
			internal static global::net.sf.jni4net.jni.FieldId _strings4629; 
			public static java.lang.String[] strings
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.wifi.WifiConfiguration.Status.staticClass = @__class; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4630; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiConfiguration)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4630)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.WifiConfiguration.staticClass, _toString4630)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4631; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiConfiguration)) 
				@__env.CallVoidMethod(this, _writeToParcel4631, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.wifi.WifiConfiguration.staticClass, _writeToParcel4631, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4632; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiConfiguration)) 
				return @__env.CallIntMethod(this, _describeContents4632); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.WifiConfiguration.staticClass, _describeContents4632); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WifiConfiguration4633; 
		public WifiConfiguration()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.wifi.WifiConfiguration.staticClass, _WifiConfiguration4633, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _networkId4634; 
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
		internal static global::net.sf.jni4net.jni.FieldId _status4635; 
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
		internal static global::net.sf.jni4net.jni.FieldId _SSID4636; 
		public java.lang.String SSID
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _BSSID4637; 
		public java.lang.String BSSID
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _preSharedKey4638; 
		public java.lang.String preSharedKey
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _wepKeys4639; 
		public java.lang.String[] wepKeys
		{ 
			get 
			{ 
				return default(java.lang.String[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _wepTxKeyIndex4640; 
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
		internal static global::net.sf.jni4net.jni.FieldId _priority4641; 
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
		internal static global::net.sf.jni4net.jni.FieldId _hiddenSSID4642; 
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
		internal static global::net.sf.jni4net.jni.FieldId _allowedKeyManagement4643; 
		public java.util.BitSet allowedKeyManagement
		{ 
			get 
			{ 
				return default(java.util.BitSet); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _allowedProtocols4644; 
		public java.util.BitSet allowedProtocols
		{ 
			get 
			{ 
				return default(java.util.BitSet); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _allowedAuthAlgorithms4645; 
		public java.util.BitSet allowedAuthAlgorithms
		{ 
			get 
			{ 
				return default(java.util.BitSet); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _allowedPairwiseCiphers4646; 
		public java.util.BitSet allowedPairwiseCiphers
		{ 
			get 
			{ 
				return default(java.util.BitSet); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _allowedGroupCiphers4647; 
		public java.util.BitSet allowedGroupCiphers
		{ 
			get 
			{ 
				return default(java.util.BitSet); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.wifi.WifiConfiguration.staticClass = @__class; 
			global::android.net.wifi.WifiConfiguration._toString4630 = @__env.GetMethodID(global::android.net.wifi.WifiConfiguration.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiConfiguration._writeToParcel4631 = @__env.GetMethodID(global::android.net.wifi.WifiConfiguration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.wifi.WifiConfiguration._describeContents4632 = @__env.GetMethodID(global::android.net.wifi.WifiConfiguration.staticClass, "describeContents", "()I"); 
			global::android.net.wifi.WifiConfiguration._WifiConfiguration4633 = @__env.GetMethodID(global::android.net.wifi.WifiConfiguration.staticClass, "<init>", "()V"); 
		} 
	} 
} 
