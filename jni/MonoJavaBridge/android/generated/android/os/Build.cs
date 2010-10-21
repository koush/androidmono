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
			internal static global::MonoJavaBridge.MethodId _VERSION9516;
			public VERSION()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.VERSION.staticClass, global::android.os.Build.VERSION._VERSION9516);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _INCREMENTAL9517;
			public static global::java.lang.String INCREMENTAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _INCREMENTAL9517)) as java.lang.String;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RELEASE9518;
			public static global::java.lang.String RELEASE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _RELEASE9518)) as java.lang.String;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SDK9519;
			public static global::java.lang.String SDK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _SDK9519)) as java.lang.String;
				}
			}
			public static int SDK_INT
			{
				get
				{
					return 0;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CODENAME9521;
			public static global::java.lang.String CODENAME
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _CODENAME9521)) as java.lang.String;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Build.VERSION.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build$VERSION"));
				global::android.os.Build.VERSION._VERSION9516 = @__env.GetMethodIDNoThrow(global::android.os.Build.VERSION.staticClass, "<init>", "()V");
				global::android.os.Build.VERSION._INCREMENTAL9517 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "INCREMENTAL", "Ljava/lang/String;");
				global::android.os.Build.VERSION._RELEASE9518 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "RELEASE", "Ljava/lang/String;");
				global::android.os.Build.VERSION._SDK9519 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "SDK", "Ljava/lang/String;");
				global::android.os.Build.VERSION._CODENAME9521 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "CODENAME", "Ljava/lang/String;");
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
			internal static global::MonoJavaBridge.MethodId _VERSION_CODES9522;
			public VERSION_CODES()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.VERSION_CODES.staticClass, global::android.os.Build.VERSION_CODES._VERSION_CODES9522);
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
				global::android.os.Build.VERSION_CODES._VERSION_CODES9522 = @__env.GetMethodIDNoThrow(global::android.os.Build.VERSION_CODES.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _Build9532;
		public Build()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.staticClass, global::android.os.Build._Build9532);
			Init(@__env, handle);
		}
		public static global::java.lang.String UNKNOWN
		{
			get
			{
				return "unknown";
			}
		}
		internal static global::MonoJavaBridge.FieldId _ID9534;
		public static global::java.lang.String ID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _ID9534)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DISPLAY9535;
		public static global::java.lang.String DISPLAY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _DISPLAY9535)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PRODUCT9536;
		public static global::java.lang.String PRODUCT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _PRODUCT9536)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DEVICE9537;
		public static global::java.lang.String DEVICE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _DEVICE9537)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOARD9538;
		public static global::java.lang.String BOARD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _BOARD9538)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CPU_ABI9539;
		public static global::java.lang.String CPU_ABI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _CPU_ABI9539)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CPU_ABI29540;
		public static global::java.lang.String CPU_ABI2
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _CPU_ABI29540)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MANUFACTURER9541;
		public static global::java.lang.String MANUFACTURER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _MANUFACTURER9541)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BRAND9542;
		public static global::java.lang.String BRAND
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _BRAND9542)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MODEL9543;
		public static global::java.lang.String MODEL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _MODEL9543)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOOTLOADER9544;
		public static global::java.lang.String BOOTLOADER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _BOOTLOADER9544)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _RADIO9545;
		public static global::java.lang.String RADIO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _RADIO9545)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HARDWARE9546;
		public static global::java.lang.String HARDWARE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _HARDWARE9546)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE9547;
		public static global::java.lang.String TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _TYPE9547)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TAGS9548;
		public static global::java.lang.String TAGS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _TAGS9548)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINGERPRINT9549;
		public static global::java.lang.String FINGERPRINT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _FINGERPRINT9549)) as java.lang.String;
			}
		}
		public static long TIME
		{
			get
			{
				return 0L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _USER9551;
		public static global::java.lang.String USER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _USER9551)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOST9552;
		public static global::java.lang.String HOST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _HOST9552)) as java.lang.String;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Build.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build"));
			global::android.os.Build._Build9532 = @__env.GetMethodIDNoThrow(global::android.os.Build.staticClass, "<init>", "()V");
			global::android.os.Build._ID9534 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "ID", "Ljava/lang/String;");
			global::android.os.Build._DISPLAY9535 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "DISPLAY", "Ljava/lang/String;");
			global::android.os.Build._PRODUCT9536 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "PRODUCT", "Ljava/lang/String;");
			global::android.os.Build._DEVICE9537 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "DEVICE", "Ljava/lang/String;");
			global::android.os.Build._BOARD9538 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "BOARD", "Ljava/lang/String;");
			global::android.os.Build._CPU_ABI9539 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "CPU_ABI", "Ljava/lang/String;");
			global::android.os.Build._CPU_ABI29540 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "CPU_ABI2", "Ljava/lang/String;");
			global::android.os.Build._MANUFACTURER9541 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "MANUFACTURER", "Ljava/lang/String;");
			global::android.os.Build._BRAND9542 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "BRAND", "Ljava/lang/String;");
			global::android.os.Build._MODEL9543 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "MODEL", "Ljava/lang/String;");
			global::android.os.Build._BOOTLOADER9544 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "BOOTLOADER", "Ljava/lang/String;");
			global::android.os.Build._RADIO9545 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "RADIO", "Ljava/lang/String;");
			global::android.os.Build._HARDWARE9546 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "HARDWARE", "Ljava/lang/String;");
			global::android.os.Build._TYPE9547 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "TYPE", "Ljava/lang/String;");
			global::android.os.Build._TAGS9548 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "TAGS", "Ljava/lang/String;");
			global::android.os.Build._FINGERPRINT9549 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "FINGERPRINT", "Ljava/lang/String;");
			global::android.os.Build._USER9551 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "USER", "Ljava/lang/String;");
			global::android.os.Build._HOST9552 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "HOST", "Ljava/lang/String;");
		}
	}
}
