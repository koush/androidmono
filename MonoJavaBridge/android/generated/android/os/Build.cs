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
			internal static global::MonoJavaBridge.MethodId _VERSION9558;
			public VERSION() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.Build.VERSION._VERSION9558.native == global::System.IntPtr.Zero)
					global::android.os.Build.VERSION._VERSION9558 = @__env.GetMethodIDNoThrow(global::android.os.Build.VERSION.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.VERSION.staticClass, global::android.os.Build.VERSION._VERSION9558);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _INCREMENTAL9559;
			public static global::java.lang.String INCREMENTAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _INCREMENTAL9559)) as java.lang.String;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RELEASE9560;
			public static global::java.lang.String RELEASE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _RELEASE9560)) as java.lang.String;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SDK9561;
			public static global::java.lang.String SDK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _SDK9561)) as java.lang.String;
				}
			}
			public static int SDK_INT
			{
				get
				{
					return 0;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CODENAME9563;
			public static global::java.lang.String CODENAME
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.VERSION.staticClass, _CODENAME9563)) as java.lang.String;
				}
			}
			static VERSION()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Build.VERSION.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build$VERSION"));
				global::android.os.Build.VERSION._INCREMENTAL9559 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "INCREMENTAL", "Ljava/lang/String;");
				global::android.os.Build.VERSION._RELEASE9560 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "RELEASE", "Ljava/lang/String;");
				global::android.os.Build.VERSION._SDK9561 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "SDK", "Ljava/lang/String;");
				global::android.os.Build.VERSION._CODENAME9563 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.VERSION.staticClass, "CODENAME", "Ljava/lang/String;");
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
			internal static global::MonoJavaBridge.MethodId _VERSION_CODES9564;
			public VERSION_CODES() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.Build.VERSION_CODES._VERSION_CODES9564.native == global::System.IntPtr.Zero)
					global::android.os.Build.VERSION_CODES._VERSION_CODES9564 = @__env.GetMethodIDNoThrow(global::android.os.Build.VERSION_CODES.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.VERSION_CODES.staticClass, global::android.os.Build.VERSION_CODES._VERSION_CODES9564);
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
		internal static global::MonoJavaBridge.MethodId _Build9574;
		public Build() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Build._Build9574.native == global::System.IntPtr.Zero)
				global::android.os.Build._Build9574 = @__env.GetMethodIDNoThrow(global::android.os.Build.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Build.staticClass, global::android.os.Build._Build9574);
			Init(@__env, handle);
		}
		public static global::java.lang.String UNKNOWN
		{
			get
			{
				return "unknown";
			}
		}
		internal static global::MonoJavaBridge.FieldId _ID9576;
		public static global::java.lang.String ID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _ID9576)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DISPLAY9577;
		public static global::java.lang.String DISPLAY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _DISPLAY9577)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PRODUCT9578;
		public static global::java.lang.String PRODUCT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _PRODUCT9578)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DEVICE9579;
		public static global::java.lang.String DEVICE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _DEVICE9579)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOARD9580;
		public static global::java.lang.String BOARD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _BOARD9580)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CPU_ABI9581;
		public static global::java.lang.String CPU_ABI
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _CPU_ABI9581)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CPU_ABI29582;
		public static global::java.lang.String CPU_ABI2
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _CPU_ABI29582)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MANUFACTURER9583;
		public static global::java.lang.String MANUFACTURER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _MANUFACTURER9583)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BRAND9584;
		public static global::java.lang.String BRAND
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _BRAND9584)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MODEL9585;
		public static global::java.lang.String MODEL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _MODEL9585)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOOTLOADER9586;
		public static global::java.lang.String BOOTLOADER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _BOOTLOADER9586)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _RADIO9587;
		public static global::java.lang.String RADIO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _RADIO9587)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HARDWARE9588;
		public static global::java.lang.String HARDWARE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _HARDWARE9588)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE9589;
		public static global::java.lang.String TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _TYPE9589)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TAGS9590;
		public static global::java.lang.String TAGS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _TAGS9590)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FINGERPRINT9591;
		public static global::java.lang.String FINGERPRINT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _FINGERPRINT9591)) as java.lang.String;
			}
		}
		public static long TIME
		{
			get
			{
				return 0L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _USER9593;
		public static global::java.lang.String USER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _USER9593)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOST9594;
		public static global::java.lang.String HOST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.os.Build.staticClass, _HOST9594)) as java.lang.String;
			}
		}
		static Build()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Build.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Build"));
			global::android.os.Build._ID9576 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "ID", "Ljava/lang/String;");
			global::android.os.Build._DISPLAY9577 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "DISPLAY", "Ljava/lang/String;");
			global::android.os.Build._PRODUCT9578 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "PRODUCT", "Ljava/lang/String;");
			global::android.os.Build._DEVICE9579 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "DEVICE", "Ljava/lang/String;");
			global::android.os.Build._BOARD9580 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "BOARD", "Ljava/lang/String;");
			global::android.os.Build._CPU_ABI9581 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "CPU_ABI", "Ljava/lang/String;");
			global::android.os.Build._CPU_ABI29582 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "CPU_ABI2", "Ljava/lang/String;");
			global::android.os.Build._MANUFACTURER9583 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "MANUFACTURER", "Ljava/lang/String;");
			global::android.os.Build._BRAND9584 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "BRAND", "Ljava/lang/String;");
			global::android.os.Build._MODEL9585 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "MODEL", "Ljava/lang/String;");
			global::android.os.Build._BOOTLOADER9586 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "BOOTLOADER", "Ljava/lang/String;");
			global::android.os.Build._RADIO9587 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "RADIO", "Ljava/lang/String;");
			global::android.os.Build._HARDWARE9588 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "HARDWARE", "Ljava/lang/String;");
			global::android.os.Build._TYPE9589 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "TYPE", "Ljava/lang/String;");
			global::android.os.Build._TAGS9590 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "TAGS", "Ljava/lang/String;");
			global::android.os.Build._FINGERPRINT9591 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "FINGERPRINT", "Ljava/lang/String;");
			global::android.os.Build._USER9593 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "USER", "Ljava/lang/String;");
			global::android.os.Build._HOST9594 = @__env.GetStaticFieldIDNoThrow(global::android.os.Build.staticClass, "HOST", "Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
