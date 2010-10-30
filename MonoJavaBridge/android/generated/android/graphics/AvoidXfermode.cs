namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AvoidXfermode : android.graphics.Xfermode
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AvoidXfermode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			public static global::android.graphics.AvoidXfermode.Mode[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.AvoidXfermode.Mode._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.AvoidXfermode.Mode._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "values", "()[Landroid/graphics/AvoidXfermode/Mode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.AvoidXfermode.Mode>(@__env.CallStaticObjectMethod(android.graphics.AvoidXfermode.Mode.staticClass, global::android.graphics.AvoidXfermode.Mode._m0)) as android.graphics.AvoidXfermode.Mode[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.AvoidXfermode.Mode valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.AvoidXfermode.Mode._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.AvoidXfermode.Mode._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/AvoidXfermode$Mode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.AvoidXfermode.Mode>(@__env.CallStaticObjectMethod(android.graphics.AvoidXfermode.Mode.staticClass, global::android.graphics.AvoidXfermode.Mode._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.AvoidXfermode.Mode;
			}
			internal static global::MonoJavaBridge.FieldId _AVOID2235;
			public static global::android.graphics.AvoidXfermode.Mode AVOID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.AvoidXfermode.Mode>(@__env.GetStaticObjectField(global::android.graphics.AvoidXfermode.Mode.staticClass, _AVOID2235)) as android.graphics.AvoidXfermode.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TARGET2236;
			public static global::android.graphics.AvoidXfermode.Mode TARGET
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.AvoidXfermode.Mode>(@__env.GetStaticObjectField(global::android.graphics.AvoidXfermode.Mode.staticClass, _TARGET2236)) as android.graphics.AvoidXfermode.Mode;
				}
			}
			static Mode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.AvoidXfermode.Mode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/AvoidXfermode$Mode"));
				global::android.graphics.AvoidXfermode.Mode._AVOID2235 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "AVOID", "Landroid/graphics/AvoidXfermode$Mode;");
				global::android.graphics.AvoidXfermode.Mode._TARGET2236 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "TARGET", "Landroid/graphics/AvoidXfermode$Mode;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AvoidXfermode(int arg0, int arg1, android.graphics.AvoidXfermode.Mode arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.AvoidXfermode._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.AvoidXfermode._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.AvoidXfermode.staticClass, "<init>", "(IILandroid/graphics/AvoidXfermode$Mode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.AvoidXfermode.staticClass, global::android.graphics.AvoidXfermode._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AvoidXfermode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.AvoidXfermode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/AvoidXfermode"));
		}
		internal static void InitJNI()
		{
		}
	}
}
