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
			internal static global::MonoJavaBridge.MethodId _values5643;
			public static global::android.graphics.PorterDuff.Mode[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.PorterDuff.Mode>(@__env.CallStaticObjectMethod(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._values5643)) as android.graphics.PorterDuff.Mode[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5644;
			public static global::android.graphics.PorterDuff.Mode valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.CallStaticObjectMethod(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._valueOf5644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PorterDuff.Mode;
			}
			internal static global::MonoJavaBridge.FieldId _CLEAR5645;
			public static global::android.graphics.PorterDuff.Mode CLEAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _CLEAR5645)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DARKEN5646;
			public static global::android.graphics.PorterDuff.Mode DARKEN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DARKEN5646)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST5647;
			public static global::android.graphics.PorterDuff.Mode DST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST5647)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_ATOP5648;
			public static global::android.graphics.PorterDuff.Mode DST_ATOP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_ATOP5648)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_IN5649;
			public static global::android.graphics.PorterDuff.Mode DST_IN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_IN5649)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_OUT5650;
			public static global::android.graphics.PorterDuff.Mode DST_OUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_OUT5650)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_OVER5651;
			public static global::android.graphics.PorterDuff.Mode DST_OVER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_OVER5651)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LIGHTEN5652;
			public static global::android.graphics.PorterDuff.Mode LIGHTEN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _LIGHTEN5652)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MULTIPLY5653;
			public static global::android.graphics.PorterDuff.Mode MULTIPLY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _MULTIPLY5653)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SCREEN5654;
			public static global::android.graphics.PorterDuff.Mode SCREEN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SCREEN5654)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC5655;
			public static global::android.graphics.PorterDuff.Mode SRC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC5655)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_ATOP5656;
			public static global::android.graphics.PorterDuff.Mode SRC_ATOP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_ATOP5656)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_IN5657;
			public static global::android.graphics.PorterDuff.Mode SRC_IN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_IN5657)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_OUT5658;
			public static global::android.graphics.PorterDuff.Mode SRC_OUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_OUT5658)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_OVER5659;
			public static global::android.graphics.PorterDuff.Mode SRC_OVER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_OVER5659)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _XOR5660;
			public static global::android.graphics.PorterDuff.Mode XOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PorterDuff.Mode>(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _XOR5660)) as android.graphics.PorterDuff.Mode;
				}
			}
			static Mode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.PorterDuff.Mode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuff$Mode"));
				global::android.graphics.PorterDuff.Mode._values5643 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "values", "()[Landroid/graphics/PorterDuff/Mode;");
				global::android.graphics.PorterDuff.Mode._valueOf5644 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._CLEAR5645 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "CLEAR", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DARKEN5646 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DARKEN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST5647 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_ATOP5648 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_ATOP", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_IN5649 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_IN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_OUT5650 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_OUT", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_OVER5651 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_OVER", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._LIGHTEN5652 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "LIGHTEN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._MULTIPLY5653 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "MULTIPLY", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SCREEN5654 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SCREEN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC5655 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_ATOP5656 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_ATOP", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_IN5657 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_IN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_OUT5658 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_OUT", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_OVER5659 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_OVER", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._XOR5660 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "XOR", "Landroid/graphics/PorterDuff$Mode;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _PorterDuff5661;
		public PorterDuff() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PorterDuff.staticClass, global::android.graphics.PorterDuff._PorterDuff5661);
			Init(@__env, handle);
		}
		static PorterDuff()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PorterDuff.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuff"));
			global::android.graphics.PorterDuff._PorterDuff5661 = @__env.GetMethodIDNoThrow(global::android.graphics.PorterDuff.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
