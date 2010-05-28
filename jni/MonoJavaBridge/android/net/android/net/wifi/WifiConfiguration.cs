namespace android.net.wifi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WifiConfiguration : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WifiConfiguration() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.wifi.WifiConfiguration), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.wifi.WifiConfiguration.AuthAlgorithm), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			public static global::java.lang.String varName
			{ 
				get 
				{ 
					return "auth_alg"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4873; 
			public static global::java.lang.String[] strings
			{ 
				get 
				{ 
					return default(global::java.lang.String[]); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.wifi.WifiConfiguration.GroupCipher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			public static global::java.lang.String varName
			{ 
				get 
				{ 
					return "group"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4874; 
			public static global::java.lang.String[] strings
			{ 
				get 
				{ 
					return default(global::java.lang.String[]); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.wifi.WifiConfiguration.KeyMgmt), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			public static global::java.lang.String varName
			{ 
				get 
				{ 
					return "key_mgmt"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4875; 
			public static global::java.lang.String[] strings
			{ 
				get 
				{ 
					return default(global::java.lang.String[]); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.wifi.WifiConfiguration.PairwiseCipher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			public static global::java.lang.String varName
			{ 
				get 
				{ 
					return "pairwise"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4876; 
			public static global::java.lang.String[] strings
			{ 
				get 
				{ 
					return default(global::java.lang.String[]); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.wifi.WifiConfiguration.Protocol), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			public static global::java.lang.String varName
			{ 
				get 
				{ 
					return "proto"; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _strings4877; 
			public static global::java.lang.String[] strings
			{ 
				get 
				{ 
					return default(global::java.lang.String[]); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.wifi.WifiConfiguration.Status), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.FieldId _strings4878; 
			public static global::java.lang.String[] strings
			{ 
				get 
				{ 
					return default(global::java.lang.String[]); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.wifi.WifiConfiguration.Status.staticClass = @__class; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4879; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiConfiguration)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.wifi.WifiConfiguration._toString4879)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._toString4879)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4880; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiConfiguration)) 
				@__env.CallVoidMethod(this, global::android.net.wifi.WifiConfiguration._writeToParcel4880, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._writeToParcel4880, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4881; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.WifiConfiguration)) 
				return @__env.CallIntMethod(this, global::android.net.wifi.WifiConfiguration._describeContents4881); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._describeContents4881); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WifiConfiguration4882; 
		public WifiConfiguration()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.wifi.WifiConfiguration.staticClass, global::android.net.wifi.WifiConfiguration._WifiConfiguration4882, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _networkId4883; 
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
		internal static global::net.sf.jni4net.jni.FieldId _status4884; 
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
		internal static global::net.sf.jni4net.jni.FieldId _SSID4885; 
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
		internal static global::net.sf.jni4net.jni.FieldId _BSSID4886; 
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
		internal static global::net.sf.jni4net.jni.FieldId _preSharedKey4887; 
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
		internal static global::net.sf.jni4net.jni.FieldId _wepKeys4888; 
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
		internal static global::net.sf.jni4net.jni.FieldId _wepTxKeyIndex4889; 
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
		internal static global::net.sf.jni4net.jni.FieldId _priority4890; 
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
		internal static global::net.sf.jni4net.jni.FieldId _hiddenSSID4891; 
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
		internal static global::net.sf.jni4net.jni.FieldId _allowedKeyManagement4892; 
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
		internal static global::net.sf.jni4net.jni.FieldId _allowedProtocols4893; 
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
		internal static global::net.sf.jni4net.jni.FieldId _allowedAuthAlgorithms4894; 
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
		internal static global::net.sf.jni4net.jni.FieldId _allowedPairwiseCiphers4895; 
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
		internal static global::net.sf.jni4net.jni.FieldId _allowedGroupCiphers4896; 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.wifi.WifiConfiguration.staticClass = @__class; 
			global::android.net.wifi.WifiConfiguration._toString4879 = @__env.GetMethodID(global::android.net.wifi.WifiConfiguration.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.wifi.WifiConfiguration._writeToParcel4880 = @__env.GetMethodID(global::android.net.wifi.WifiConfiguration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.wifi.WifiConfiguration._describeContents4881 = @__env.GetMethodID(global::android.net.wifi.WifiConfiguration.staticClass, "describeContents", "()I"); 
			global::android.net.wifi.WifiConfiguration._WifiConfiguration4882 = @__env.GetMethodID(global::android.net.wifi.WifiConfiguration.staticClass, "<init>", "()V"); 
		} 
	} 
} 
