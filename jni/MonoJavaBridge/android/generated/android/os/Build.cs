namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Build : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Build()
		{
			InitJNI();
		}
		protected Build(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class VERSION : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static VERSION()
			{
				InitJNI();
			}
			protected VERSION(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _VERSION6166;
			public VERSION()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.VERSION.staticClass, global::android.os.Build.VERSION._VERSION6166);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _INCREMENTAL6167;
			public static global::java.lang.String INCREMENTAL
			{
				get
				{
					return default(global::java.lang.String);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RELEASE6168;
			public static global::java.lang.String RELEASE
			{
				get
				{
					return default(global::java.lang.String);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SDK6169;
			public static global::java.lang.String SDK
			{
				get
				{
					return default(global::java.lang.String);
				}
			}
			public static int SDK_INT
			{
				get
				{
					return 0;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CODENAME6170;
			public static global::java.lang.String CODENAME
			{
				get
				{
					return default(global::java.lang.String);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Build.VERSION.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build$VERSION"));
				global::android.os.Build.VERSION._VERSION6166 = @__env.GetMethodIDNoThrow(global::android.os.Build.VERSION.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class VERSION_CODES : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static VERSION_CODES()
			{
				InitJNI();
			}
			protected VERSION_CODES(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _VERSION_CODES6171;
			public VERSION_CODES()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.VERSION_CODES.staticClass, global::android.os.Build.VERSION_CODES._VERSION_CODES6171);
				Init(@__env, handle);
			}
			public static int CUR_DEVELOPMENT
			{
				get
				{
					return 10000;
				}
			}
			public static int BASE
			{
				get
				{
					return 1;
				}
			}
			public static int BASE_1_1
			{
				get
				{
					return 2;
				}
			}
			public static int CUPCAKE
			{
				get
				{
					return 3;
				}
			}
			public static int DONUT
			{
				get
				{
					return 4;
				}
			}
			public static int ECLAIR
			{
				get
				{
					return 5;
				}
			}
			public static int ECLAIR_0_1
			{
				get
				{
					return 6;
				}
			}
			public static int ECLAIR_MR1
			{
				get
				{
					return 7;
				}
			}
			public static int FROYO
			{
				get
				{
					return 8;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Build.VERSION_CODES.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build$VERSION_CODES"));
				global::android.os.Build.VERSION_CODES._VERSION_CODES6171 = @__env.GetMethodIDNoThrow(global::android.os.Build.VERSION_CODES.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _Build6172;
		public Build()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.staticClass, global::android.os.Build._Build6172);
			Init(@__env, handle);
		}
		public static global::java.lang.String UNKNOWN
		{
			get
			{
				return "unknown";
			}
		}
		internal static global::MonoJavaBridge.FieldId _ID6173;
		public static global::java.lang.String ID
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DISPLAY6174;
		public static global::java.lang.String DISPLAY
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _PRODUCT6175;
		public static global::java.lang.String PRODUCT
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DEVICE6176;
		public static global::java.lang.String DEVICE
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOARD6177;
		public static global::java.lang.String BOARD
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CPU_ABI6178;
		public static global::java.lang.String CPU_ABI
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CPU_ABI26179;
		public static global::java.lang.String CPU_ABI2
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _MANUFACTURER6180;
		public static global::java.lang.String MANUFACTURER
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _BRAND6181;
		public static global::java.lang.String BRAND
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _MODEL6182;
		public static global::java.lang.String MODEL
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOOTLOADER6183;
		public static global::java.lang.String BOOTLOADER
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _RADIO6184;
		public static global::java.lang.String RADIO
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HARDWARE6185;
		public static global::java.lang.String HARDWARE
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE6186;
		public static global::java.lang.String TYPE
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TAGS6187;
		public static global::java.lang.String TAGS
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINGERPRINT6188;
		public static global::java.lang.String FINGERPRINT
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		public static long TIME
		{
			get
			{
				return 0L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _USER6189;
		public static global::java.lang.String USER
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOST6190;
		public static global::java.lang.String HOST
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Build.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build"));
			global::android.os.Build._Build6172 = @__env.GetMethodIDNoThrow(global::android.os.Build.staticClass, "<init>", "()V");
		}
	}
}
