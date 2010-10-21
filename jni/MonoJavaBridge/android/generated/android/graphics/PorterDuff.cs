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
			internal static global::MonoJavaBridge.MethodId _values5624;
			public static global::android.graphics.PorterDuff.Mode[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.PorterDuff.Mode>(@__env.CallStaticObjectMethod(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._values5624)) as android.graphics.PorterDuff.Mode[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5625;
			public static global::android.graphics.PorterDuff.Mode valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._valueOf5625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PorterDuff.Mode;
			}
			internal static global::MonoJavaBridge.FieldId _CLEAR5626;
			public static global::android.graphics.PorterDuff.Mode CLEAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _CLEAR5626)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DARKEN5627;
			public static global::android.graphics.PorterDuff.Mode DARKEN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DARKEN5627)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST5628;
			public static global::android.graphics.PorterDuff.Mode DST
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST5628)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_ATOP5629;
			public static global::android.graphics.PorterDuff.Mode DST_ATOP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_ATOP5629)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_IN5630;
			public static global::android.graphics.PorterDuff.Mode DST_IN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_IN5630)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_OUT5631;
			public static global::android.graphics.PorterDuff.Mode DST_OUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_OUT5631)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DST_OVER5632;
			public static global::android.graphics.PorterDuff.Mode DST_OVER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _DST_OVER5632)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LIGHTEN5633;
			public static global::android.graphics.PorterDuff.Mode LIGHTEN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _LIGHTEN5633)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MULTIPLY5634;
			public static global::android.graphics.PorterDuff.Mode MULTIPLY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _MULTIPLY5634)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SCREEN5635;
			public static global::android.graphics.PorterDuff.Mode SCREEN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SCREEN5635)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC5636;
			public static global::android.graphics.PorterDuff.Mode SRC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC5636)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_ATOP5637;
			public static global::android.graphics.PorterDuff.Mode SRC_ATOP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_ATOP5637)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_IN5638;
			public static global::android.graphics.PorterDuff.Mode SRC_IN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_IN5638)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_OUT5639;
			public static global::android.graphics.PorterDuff.Mode SRC_OUT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_OUT5639)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SRC_OVER5640;
			public static global::android.graphics.PorterDuff.Mode SRC_OVER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _SRC_OVER5640)) as android.graphics.PorterDuff.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _XOR5641;
			public static global::android.graphics.PorterDuff.Mode XOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PorterDuff.Mode.staticClass, _XOR5641)) as android.graphics.PorterDuff.Mode;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.PorterDuff.Mode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuff$Mode"));
				global::android.graphics.PorterDuff.Mode._values5624 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "values", "()[Landroid/graphics/PorterDuff/Mode;");
				global::android.graphics.PorterDuff.Mode._valueOf5625 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._CLEAR5626 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "CLEAR", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DARKEN5627 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DARKEN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST5628 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_ATOP5629 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_ATOP", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_IN5630 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_IN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_OUT5631 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_OUT", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._DST_OVER5632 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "DST_OVER", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._LIGHTEN5633 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "LIGHTEN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._MULTIPLY5634 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "MULTIPLY", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SCREEN5635 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SCREEN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC5636 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_ATOP5637 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_ATOP", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_IN5638 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_IN", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_OUT5639 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_OUT", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._SRC_OVER5640 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "SRC_OVER", "Landroid/graphics/PorterDuff$Mode;");
				global::android.graphics.PorterDuff.Mode._XOR5641 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PorterDuff.Mode.staticClass, "XOR", "Landroid/graphics/PorterDuff$Mode;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _PorterDuff5642;
		public PorterDuff()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PorterDuff.staticClass, global::android.graphics.PorterDuff._PorterDuff5642);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PorterDuff.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuff"));
			global::android.graphics.PorterDuff._PorterDuff5642 = @__env.GetMethodIDNoThrow(global::android.graphics.PorterDuff.staticClass, "<init>", "()V");
		}
	}
}
