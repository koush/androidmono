namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Build : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Build(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class VERSION : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected VERSION(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public VERSION() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.Build.VERSION._m0.native == global::System.IntPtr.Zero)
					global::android.os.Build.VERSION._m0 = @__env.GetMethodIDNoThrow(global::android.os.Build.VERSION.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.VERSION.staticClass, global::android.os.Build.VERSION._m0);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _INCREMENTAL3912;
			public static global::java.lang.String INCREMENTAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _INCREMENTAL3912)) as java.lang.String;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RELEASE3913;
			public static global::java.lang.String RELEASE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _RELEASE3913)) as java.lang.String;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SDK3914;
			public static global::java.lang.String SDK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _SDK3914)) as java.lang.String;
				}
			}
			public static int SDK_INT
			{
				get
				{
					return 0;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CODENAME3916;
			public static global::java.lang.String CODENAME
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _CODENAME3916)) as java.lang.String;
				}
			}
			static VERSION()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Build.VERSION.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build$VERSION"));
				global::android.os.Build.VERSION._INCREMENTAL3912 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "INCREMENTAL", "Ljava/lang/String;");
				global::android.os.Build.VERSION._RELEASE3913 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "RELEASE", "Ljava/lang/String;");
				global::android.os.Build.VERSION._SDK3914 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "SDK", "Ljava/lang/String;");
				global::android.os.Build.VERSION._CODENAME3916 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "CODENAME", "Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class VERSION_CODES : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected VERSION_CODES(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public VERSION_CODES() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.Build.VERSION_CODES._m0.native == global::System.IntPtr.Zero)
					global::android.os.Build.VERSION_CODES._m0 = @__env.GetMethodIDNoThrow(global::android.os.Build.VERSION_CODES.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.VERSION_CODES.staticClass, global::android.os.Build.VERSION_CODES._m0);
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
			static VERSION_CODES()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Build.VERSION_CODES.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build$VERSION_CODES"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public Build() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Build._m0.native == global::System.IntPtr.Zero)
				global::android.os.Build._m0 = @__env.GetMethodIDNoThrow(global::android.os.Build.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.staticClass, global::android.os.Build._m0);
			Init(@__env, handle);
		}
		public static global::java.lang.String UNKNOWN
		{
			get
			{
				return "unknown";
			}
		}
		internal static global::MonoJavaBridge.FieldId _ID3927;
		public static global::java.lang.String ID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _ID3927)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DISPLAY3928;
		public static global::java.lang.String DISPLAY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _DISPLAY3928)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PRODUCT3929;
		public static global::java.lang.String PRODUCT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _PRODUCT3929)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DEVICE3930;
		public static global::java.lang.String DEVICE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _DEVICE3930)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOARD3931;
		public static global::java.lang.String BOARD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _BOARD3931)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CPU_ABI3932;
		public static global::java.lang.String CPU_ABI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _CPU_ABI3932)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CPU_ABI23933;
		public static global::java.lang.String CPU_ABI2
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _CPU_ABI23933)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MANUFACTURER3934;
		public static global::java.lang.String MANUFACTURER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _MANUFACTURER3934)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BRAND3935;
		public static global::java.lang.String BRAND
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _BRAND3935)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MODEL3936;
		public static global::java.lang.String MODEL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _MODEL3936)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOOTLOADER3937;
		public static global::java.lang.String BOOTLOADER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _BOOTLOADER3937)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _RADIO3938;
		public static global::java.lang.String RADIO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _RADIO3938)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HARDWARE3939;
		public static global::java.lang.String HARDWARE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _HARDWARE3939)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE3940;
		public static global::java.lang.String TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _TYPE3940)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TAGS3941;
		public static global::java.lang.String TAGS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _TAGS3941)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINGERPRINT3942;
		public static global::java.lang.String FINGERPRINT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _FINGERPRINT3942)) as java.lang.String;
			}
		}
		public static long TIME
		{
			get
			{
				return 0L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _USER3944;
		public static global::java.lang.String USER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _USER3944)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOST3945;
		public static global::java.lang.String HOST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _HOST3945)) as java.lang.String;
			}
		}
		static Build()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Build.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build"));
			global::android.os.Build._ID3927 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "ID", "Ljava/lang/String;");
			global::android.os.Build._DISPLAY3928 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "DISPLAY", "Ljava/lang/String;");
			global::android.os.Build._PRODUCT3929 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "PRODUCT", "Ljava/lang/String;");
			global::android.os.Build._DEVICE3930 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "DEVICE", "Ljava/lang/String;");
			global::android.os.Build._BOARD3931 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "BOARD", "Ljava/lang/String;");
			global::android.os.Build._CPU_ABI3932 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "CPU_ABI", "Ljava/lang/String;");
			global::android.os.Build._CPU_ABI23933 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "CPU_ABI2", "Ljava/lang/String;");
			global::android.os.Build._MANUFACTURER3934 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "MANUFACTURER", "Ljava/lang/String;");
			global::android.os.Build._BRAND3935 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "BRAND", "Ljava/lang/String;");
			global::android.os.Build._MODEL3936 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "MODEL", "Ljava/lang/String;");
			global::android.os.Build._BOOTLOADER3937 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "BOOTLOADER", "Ljava/lang/String;");
			global::android.os.Build._RADIO3938 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "RADIO", "Ljava/lang/String;");
			global::android.os.Build._HARDWARE3939 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "HARDWARE", "Ljava/lang/String;");
			global::android.os.Build._TYPE3940 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "TYPE", "Ljava/lang/String;");
			global::android.os.Build._TAGS3941 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "TAGS", "Ljava/lang/String;");
			global::android.os.Build._FINGERPRINT3942 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "FINGERPRINT", "Ljava/lang/String;");
			global::android.os.Build._USER3944 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "USER", "Ljava/lang/String;");
			global::android.os.Build._HOST3945 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "HOST", "Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
