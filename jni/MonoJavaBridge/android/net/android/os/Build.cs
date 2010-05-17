namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Build : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Build() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Build), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Build.VERSION), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _VERSION5112; 
			public VERSION()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.os.Build.VERSION.staticClass, _VERSION5112, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _INCREMENTAL5113; 
			public static java.lang.String INCREMENTAL
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RELEASE5114; 
			public static java.lang.String RELEASE
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SDK5115; 
			public static java.lang.String SDK
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
			} 
			public static int SDK_INT
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CODENAME5116; 
			public static java.lang.String CODENAME
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.Build.VERSION.staticClass = @__class; 
				global::android.os.Build.VERSION._VERSION5112 = @__env.GetMethodID(global::android.os.Build.VERSION.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class VERSION_CODES : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static VERSION_CODES() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Build.VERSION_CODES), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _VERSION_CODES5117; 
			public VERSION_CODES()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.os.Build.VERSION_CODES.staticClass, _VERSION_CODES5117, this); 
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.Build.VERSION_CODES.staticClass = @__class; 
				global::android.os.Build.VERSION_CODES._VERSION_CODES5117 = @__env.GetMethodID(global::android.os.Build.VERSION_CODES.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Build5118; 
		public Build()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Build.staticClass, _Build5118, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ID5119; 
		public static java.lang.String ID
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DISPLAY5120; 
		public static java.lang.String DISPLAY
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _PRODUCT5121; 
		public static java.lang.String PRODUCT
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DEVICE5122; 
		public static java.lang.String DEVICE
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _BOARD5123; 
		public static java.lang.String BOARD
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CPU_ABI5124; 
		public static java.lang.String CPU_ABI
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _MANUFACTURER5125; 
		public static java.lang.String MANUFACTURER
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _BRAND5126; 
		public static java.lang.String BRAND
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _MODEL5127; 
		public static java.lang.String MODEL
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TYPE5128; 
		public static java.lang.String TYPE
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TAGS5129; 
		public static java.lang.String TAGS
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _FINGERPRINT5130; 
		public static java.lang.String FINGERPRINT
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		public static long TIME
		{ 
			get 
			{ 
				return 0L; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _USER5131; 
		public static java.lang.String USER
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _HOST5132; 
		public static java.lang.String HOST
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Build.staticClass = @__class; 
			global::android.os.Build._Build5118 = @__env.GetMethodID(global::android.os.Build.staticClass, "<init>", "()V"); 
		} 
	} 
} 
