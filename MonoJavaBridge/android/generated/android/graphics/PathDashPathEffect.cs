namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathDashPathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathDashPathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Style : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Style(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.PathDashPathEffect.Style[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.PathDashPathEffect.Style._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.PathDashPathEffect.Style._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "values", "()[Landroid/graphics/PathDashPathEffect/Style;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.PathDashPathEffect.Style>(@__env.CallStaticObjectMethod(android.graphics.PathDashPathEffect.Style.staticClass, global::android.graphics.PathDashPathEffect.Style._m0)) as android.graphics.PathDashPathEffect.Style[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.PathDashPathEffect.Style valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.PathDashPathEffect.Style._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.PathDashPathEffect.Style._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/PathDashPathEffect$Style;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PathDashPathEffect.Style>(@__env.CallStaticObjectMethod(android.graphics.PathDashPathEffect.Style.staticClass, global::android.graphics.PathDashPathEffect.Style._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PathDashPathEffect.Style;
			}
			internal static global::MonoJavaBridge.FieldId _MORPH2346;
			public static global::android.graphics.PathDashPathEffect.Style MORPH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PathDashPathEffect.Style>(@__env.GetStaticObjectField(global::android.graphics.PathDashPathEffect.Style.staticClass, _MORPH2346)) as android.graphics.PathDashPathEffect.Style;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ROTATE2347;
			public static global::android.graphics.PathDashPathEffect.Style ROTATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PathDashPathEffect.Style>(@__env.GetStaticObjectField(global::android.graphics.PathDashPathEffect.Style.staticClass, _ROTATE2347)) as android.graphics.PathDashPathEffect.Style;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TRANSLATE2348;
			public static global::android.graphics.PathDashPathEffect.Style TRANSLATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.PathDashPathEffect.Style>(@__env.GetStaticObjectField(global::android.graphics.PathDashPathEffect.Style.staticClass, _TRANSLATE2348)) as android.graphics.PathDashPathEffect.Style;
				}
			}
			static Style()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.PathDashPathEffect.Style.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PathDashPathEffect$Style"));
				global::android.graphics.PathDashPathEffect.Style._MORPH2346 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "MORPH", "Landroid/graphics/PathDashPathEffect$Style;");
				global::android.graphics.PathDashPathEffect.Style._ROTATE2347 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "ROTATE", "Landroid/graphics/PathDashPathEffect$Style;");
				global::android.graphics.PathDashPathEffect.Style._TRANSLATE2348 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "TRANSLATE", "Landroid/graphics/PathDashPathEffect$Style;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public PathDashPathEffect(android.graphics.Path arg0, float arg1, float arg2, android.graphics.PathDashPathEffect.Style arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PathDashPathEffect._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.PathDashPathEffect._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.PathDashPathEffect.staticClass, "<init>", "(Landroid/graphics/Path;FFLandroid/graphics/PathDashPathEffect$Style;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathDashPathEffect.staticClass, global::android.graphics.PathDashPathEffect._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static PathDashPathEffect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PathDashPathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PathDashPathEffect"));
		}
		internal static void InitJNI()
		{
		}
	}
}
