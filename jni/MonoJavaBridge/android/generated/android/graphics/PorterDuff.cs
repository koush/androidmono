namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PorterDuff : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PorterDuff()
		{
			InitJNI();
		}
		protected PorterDuff(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Mode : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Mode()
			{
				InitJNI();
			}
			internal Mode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3643;
			public static global::android.graphics.PorterDuff.Mode[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.PorterDuff.Mode>(@__env.CallStaticObjectMethod(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._values3643)) as android.graphics.PorterDuff.Mode[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3644;
			public static global::android.graphics.PorterDuff.Mode valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._valueOf3644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PorterDuff.Mode;
			}
			internal static global::MonoJavaBridge.FieldId _CLEAR3645;
			public static global::android.graphics.PorterDuff.Mode CLEAR
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DARKEN3646;
			public static global::android.graphics.PorterDuff.Mode DARKEN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST3647;
			public static global::android.graphics.PorterDuff.Mode DST
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_ATOP3648;
			public static global::android.graphics.PorterDuff.Mode DST_ATOP
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_IN3649;
			public static global::android.graphics.PorterDuff.Mode DST_IN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_OUT3650;
			public static global::android.graphics.PorterDuff.Mode DST_OUT
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_OVER3651;
			public static global::android.graphics.PorterDuff.Mode DST_OVER
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _LIGHTEN3652;
			public static global::android.graphics.PorterDuff.Mode LIGHTEN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MULTIPLY3653;
			public static global::android.graphics.PorterDuff.Mode MULTIPLY
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SCREEN3654;
			public static global::android.graphics.PorterDuff.Mode SCREEN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC3655;
			public static global::android.graphics.PorterDuff.Mode SRC
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_ATOP3656;
			public static global::android.graphics.PorterDuff.Mode SRC_ATOP
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_IN3657;
			public static global::android.graphics.PorterDuff.Mode SRC_IN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_OUT3658;
			public static global::android.graphics.PorterDuff.Mode SRC_OUT
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_OVER3659;
			public static global::android.graphics.PorterDuff.Mode SRC_OVER
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _XOR3660;
			public static global::android.graphics.PorterDuff.Mode XOR
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.PorterDuff.Mode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuff$Mode"));
				global::android.graphics.PorterDuff.Mode._values3643 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "values", "()[Landroid/graphics/PorterDuff/Mode;");
				global::android.graphics.PorterDuff.Mode._valueOf3644 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/PorterDuff$Mode;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _PorterDuff3661;
		public PorterDuff()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PorterDuff.staticClass, global::android.graphics.PorterDuff._PorterDuff3661);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PorterDuff.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuff"));
			global::android.graphics.PorterDuff._PorterDuff3661 = @__env.GetMethodIDNoThrow(global::android.graphics.PorterDuff.staticClass, "<init>", "()V");
		}
	}
}
