namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Build : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Build()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Build), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.Build(@__env);
			}
		}
		protected Build(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class VERSION : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static VERSION()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Build.VERSION), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.Build.VERSION(@__env);
				}
			}
			protected VERSION(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _VERSION5900;
			public VERSION()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.Build.VERSION.staticClass, global::android.os.Build.VERSION._VERSION5900, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _INCREMENTAL5901;
			public static global::java.lang.String INCREMENTAL
			{
				get
				{
					return default(global::java.lang.String);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RELEASE5902;
			public static global::java.lang.String RELEASE
			{
				get
				{
					return default(global::java.lang.String);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SDK5903;
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
			internal static global::net.sf.jni4net.jni.FieldId _CODENAME5904;
			public static global::java.lang.String CODENAME
			{
				get
				{
					return default(global::java.lang.String);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.Build.VERSION.staticClass = @__class;
				global::android.os.Build.VERSION._VERSION5900 = @__env.GetMethodID(global::android.os.Build.VERSION.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class VERSION_CODES : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static VERSION_CODES()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Build.VERSION_CODES), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.Build.VERSION_CODES(@__env);
				}
			}
			protected VERSION_CODES(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _VERSION_CODES5905;
			public VERSION_CODES()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.Build.VERSION_CODES.staticClass, global::android.os.Build.VERSION_CODES._VERSION_CODES5905, this);
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.Build.VERSION_CODES.staticClass = @__class;
				global::android.os.Build.VERSION_CODES._VERSION_CODES5905 = @__env.GetMethodID(global::android.os.Build.VERSION_CODES.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _Build5906;
		public Build()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Build.staticClass, global::android.os.Build._Build5906, this);
		}
		public static global::java.lang.String UNKNOWN
		{
			get
			{
				return "unknown";
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ID5907;
		public static global::java.lang.String ID
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _DISPLAY5908;
		public static global::java.lang.String DISPLAY
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _PRODUCT5909;
		public static global::java.lang.String PRODUCT
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _DEVICE5910;
		public static global::java.lang.String DEVICE
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _BOARD5911;
		public static global::java.lang.String BOARD
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CPU_ABI5912;
		public static global::java.lang.String CPU_ABI
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CPU_ABI25913;
		public static global::java.lang.String CPU_ABI2
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _MANUFACTURER5914;
		public static global::java.lang.String MANUFACTURER
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _BRAND5915;
		public static global::java.lang.String BRAND
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _MODEL5916;
		public static global::java.lang.String MODEL
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _BOOTLOADER5917;
		public static global::java.lang.String BOOTLOADER
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _RADIO5918;
		public static global::java.lang.String RADIO
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _HARDWARE5919;
		public static global::java.lang.String HARDWARE
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TYPE5920;
		public static global::java.lang.String TYPE
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TAGS5921;
		public static global::java.lang.String TAGS
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _FINGERPRINT5922;
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
		internal static global::net.sf.jni4net.jni.FieldId _USER5923;
		public static global::java.lang.String USER
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _HOST5924;
		public static global::java.lang.String HOST
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.Build.staticClass = @__class;
			global::android.os.Build._Build5906 = @__env.GetMethodID(global::android.os.Build.staticClass, "<init>", "()V");
		}
	}
}
