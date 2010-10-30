namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BlurMaskFilter : android.graphics.MaskFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BlurMaskFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Blur : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Blur(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.BlurMaskFilter.Blur[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.BlurMaskFilter.Blur._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.BlurMaskFilter.Blur._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "values", "()[Landroid/graphics/BlurMaskFilter/Blur;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.BlurMaskFilter.Blur>(@__env.CallStaticObjectMethod(android.graphics.BlurMaskFilter.Blur.staticClass, global::android.graphics.BlurMaskFilter.Blur._m0)) as android.graphics.BlurMaskFilter.Blur[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.BlurMaskFilter.Blur valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.BlurMaskFilter.Blur._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.BlurMaskFilter.Blur._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/BlurMaskFilter$Blur;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.CallStaticObjectMethod(android.graphics.BlurMaskFilter.Blur.staticClass, global::android.graphics.BlurMaskFilter.Blur._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.BlurMaskFilter.Blur;
			}
			internal static global::MonoJavaBridge.FieldId _INNER2260;
			public static global::android.graphics.BlurMaskFilter.Blur INNER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.GetStaticObjectField(global::android.graphics.BlurMaskFilter.Blur.staticClass, _INNER2260)) as android.graphics.BlurMaskFilter.Blur;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL2261;
			public static global::android.graphics.BlurMaskFilter.Blur NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.GetStaticObjectField(global::android.graphics.BlurMaskFilter.Blur.staticClass, _NORMAL2261)) as android.graphics.BlurMaskFilter.Blur;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OUTER2262;
			public static global::android.graphics.BlurMaskFilter.Blur OUTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.GetStaticObjectField(global::android.graphics.BlurMaskFilter.Blur.staticClass, _OUTER2262)) as android.graphics.BlurMaskFilter.Blur;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SOLID2263;
			public static global::android.graphics.BlurMaskFilter.Blur SOLID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.GetStaticObjectField(global::android.graphics.BlurMaskFilter.Blur.staticClass, _SOLID2263)) as android.graphics.BlurMaskFilter.Blur;
				}
			}
			static Blur()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.BlurMaskFilter.Blur.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BlurMaskFilter$Blur"));
				global::android.graphics.BlurMaskFilter.Blur._INNER2260 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "INNER", "Landroid/graphics/BlurMaskFilter$Blur;");
				global::android.graphics.BlurMaskFilter.Blur._NORMAL2261 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "NORMAL", "Landroid/graphics/BlurMaskFilter$Blur;");
				global::android.graphics.BlurMaskFilter.Blur._OUTER2262 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "OUTER", "Landroid/graphics/BlurMaskFilter$Blur;");
				global::android.graphics.BlurMaskFilter.Blur._SOLID2263 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "SOLID", "Landroid/graphics/BlurMaskFilter$Blur;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public BlurMaskFilter(float arg0, android.graphics.BlurMaskFilter.Blur arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BlurMaskFilter._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.BlurMaskFilter._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.BlurMaskFilter.staticClass, "<init>", "(FLandroid/graphics/BlurMaskFilter$Blur;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BlurMaskFilter.staticClass, global::android.graphics.BlurMaskFilter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BlurMaskFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.BlurMaskFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BlurMaskFilter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
