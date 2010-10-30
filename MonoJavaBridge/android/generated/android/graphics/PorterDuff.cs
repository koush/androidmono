namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PorterDuff : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PorterDuff(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Mode : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Mode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.PorterDuff.Mode[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.PorterDuff.Mode._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.PorterDuff.Mode._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "values", "()[Landroid/graphics/PorterDuff/Mode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.PorterDuff.Mode>(@__env.CallStaticObjectMethod(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._m0)) as android.graphics.PorterDuff.Mode[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.PorterDuff.Mode valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.PorterDuff.Mode._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.PorterDuff.Mode._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/PorterDuff$Mode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.CallStaticObjectMethod(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PorterDuff.Mode;
			}
			internal static global::MonoJavaBridge.FieldId _CLEAR2375;
			public static global::android.graphics.PorterDuff.Mode CLEAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _CLEAR2375)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DARKEN2376;
			public static global::android.graphics.PorterDuff.Mode DARKEN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DARKEN2376)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST2377;
			public static global::android.graphics.PorterDuff.Mode DST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST2377)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_ATOP2378;
			public static global::android.graphics.PorterDuff.Mode DST_ATOP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_ATOP2378)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_IN2379;
			public static global::android.graphics.PorterDuff.Mode DST_IN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_IN2379)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_OUT2380;
			public static global::android.graphics.PorterDuff.Mode DST_OUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_OUT2380)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_OVER2381;
			public static global::android.graphics.PorterDuff.Mode DST_OVER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_OVER2381)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LIGHTEN2382;
			public static global::android.graphics.PorterDuff.Mode LIGHTEN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _LIGHTEN2382)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MULTIPLY2383;
			public static global::android.graphics.PorterDuff.Mode MULTIPLY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _MULTIPLY2383)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SCREEN2384;
			public static global::android.graphics.PorterDuff.Mode SCREEN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SCREEN2384)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC2385;
			public static global::android.graphics.PorterDuff.Mode SRC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC2385)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_ATOP2386;
			public static global::android.graphics.PorterDuff.Mode SRC_ATOP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_ATOP2386)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_IN2387;
			public static global::android.graphics.PorterDuff.Mode SRC_IN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_IN2387)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_OUT2388;
			public static global::android.graphics.PorterDuff.Mode SRC_OUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_OUT2388)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_OVER2389;
			public static global::android.graphics.PorterDuff.Mode SRC_OVER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_OVER2389)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _XOR2390;
			public static global::android.graphics.PorterDuff.Mode XOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _XOR2390)) as android.graphics.PorterDuff.Mode;
				}
			}
			static Mode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.PorterDuff.Mode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuff$Mode"));
				global::android.graphics.PorterDuff.Mode._CLEAR2375 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "CLEAR", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DARKEN2376 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DARKEN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST2377 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_ATOP2378 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_ATOP", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_IN2379 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_IN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_OUT2380 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_OUT", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_OVER2381 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_OVER", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._LIGHTEN2382 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "LIGHTEN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._MULTIPLY2383 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "MULTIPLY", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SCREEN2384 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SCREEN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC2385 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_ATOP2386 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_ATOP", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_IN2387 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_IN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_OUT2388 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_OUT", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_OVER2389 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_OVER", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._XOR2390 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "XOR", "Landroid/graphics/PorterDuff$Mode;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public PorterDuff() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PorterDuff._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.PorterDuff._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.PorterDuff.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PorterDuff.staticClass, global::android.graphics.PorterDuff._m0);
			Init(@__env, handle);
		}
		static PorterDuff()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PorterDuff.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuff"));
		}
		internal static void InitJNI()
		{
		}
	}
}
