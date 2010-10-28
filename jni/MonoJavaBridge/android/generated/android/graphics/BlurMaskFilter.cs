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
			internal static global::MonoJavaBridge.MethodId _values5094;
			public static global::android.graphics.BlurMaskFilter.Blur[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.BlurMaskFilter.Blur>(@__env.CallStaticObjectMethod(android.graphics.BlurMaskFilter.Blur.staticClass, global::android.graphics.BlurMaskFilter.Blur._values5094)) as android.graphics.BlurMaskFilter.Blur[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5095;
			public static global::android.graphics.BlurMaskFilter.Blur valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.CallStaticObjectMethod(android.graphics.BlurMaskFilter.Blur.staticClass, global::android.graphics.BlurMaskFilter.Blur._valueOf5095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.BlurMaskFilter.Blur;
			}
			internal static global::MonoJavaBridge.FieldId _INNER5096;
			public static global::android.graphics.BlurMaskFilter.Blur INNER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.GetStaticObjectField(global::android.graphics.BlurMaskFilter.Blur.staticClass, _INNER5096)) as android.graphics.BlurMaskFilter.Blur;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL5097;
			public static global::android.graphics.BlurMaskFilter.Blur NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.GetStaticObjectField(global::android.graphics.BlurMaskFilter.Blur.staticClass, _NORMAL5097)) as android.graphics.BlurMaskFilter.Blur;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OUTER5098;
			public static global::android.graphics.BlurMaskFilter.Blur OUTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.GetStaticObjectField(global::android.graphics.BlurMaskFilter.Blur.staticClass, _OUTER5098)) as android.graphics.BlurMaskFilter.Blur;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SOLID5099;
			public static global::android.graphics.BlurMaskFilter.Blur SOLID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.BlurMaskFilter.Blur>(@__env.GetStaticObjectField(global::android.graphics.BlurMaskFilter.Blur.staticClass, _SOLID5099)) as android.graphics.BlurMaskFilter.Blur;
				}
			}
			static Blur()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.BlurMaskFilter.Blur.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BlurMaskFilter$Blur"));
				global::android.graphics.BlurMaskFilter.Blur._values5094 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "values", "()[Landroid/graphics/BlurMaskFilter/Blur;");
				global::android.graphics.BlurMaskFilter.Blur._valueOf5095 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/BlurMaskFilter$Blur;");
				global::android.graphics.BlurMaskFilter.Blur._INNER5096 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "INNER", "Landroid/graphics/BlurMaskFilter$Blur;");
				global::android.graphics.BlurMaskFilter.Blur._NORMAL5097 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "NORMAL", "Landroid/graphics/BlurMaskFilter$Blur;");
				global::android.graphics.BlurMaskFilter.Blur._OUTER5098 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "OUTER", "Landroid/graphics/BlurMaskFilter$Blur;");
				global::android.graphics.BlurMaskFilter.Blur._SOLID5099 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "SOLID", "Landroid/graphics/BlurMaskFilter$Blur;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _BlurMaskFilter5100;
		public BlurMaskFilter(float arg0, android.graphics.BlurMaskFilter.Blur arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BlurMaskFilter.staticClass, global::android.graphics.BlurMaskFilter._BlurMaskFilter5100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BlurMaskFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.BlurMaskFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BlurMaskFilter"));
			global::android.graphics.BlurMaskFilter._BlurMaskFilter5100 = @__env.GetMethodIDNoThrow(global::android.graphics.BlurMaskFilter.staticClass, "<init>", "(FLandroid/graphics/BlurMaskFilter$Blur;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
