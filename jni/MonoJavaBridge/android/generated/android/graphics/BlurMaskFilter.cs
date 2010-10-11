namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BlurMaskFilter : android.graphics.MaskFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BlurMaskFilter()
		{
			InitJNI();
		}
		protected BlurMaskFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Blur : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Blur()
			{
				InitJNI();
			}
			internal Blur(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3156;
			public static global::android.graphics.BlurMaskFilter.Blur[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.BlurMaskFilter.Blur>(@__env.CallStaticObjectMethod(android.graphics.BlurMaskFilter.Blur.staticClass, global::android.graphics.BlurMaskFilter.Blur._values3156)) as android.graphics.BlurMaskFilter.Blur[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3157;
			public static global::android.graphics.BlurMaskFilter.Blur valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BlurMaskFilter.Blur.staticClass, global::android.graphics.BlurMaskFilter.Blur._valueOf3157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.BlurMaskFilter.Blur;
			}
			internal static global::MonoJavaBridge.FieldId _INNER3158;
			public static global::android.graphics.BlurMaskFilter.Blur INNER
			{
				get
				{
					return default(global::android.graphics.BlurMaskFilter.Blur);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL3159;
			public static global::android.graphics.BlurMaskFilter.Blur NORMAL
			{
				get
				{
					return default(global::android.graphics.BlurMaskFilter.Blur);
				}
			}
			internal static global::MonoJavaBridge.FieldId _OUTER3160;
			public static global::android.graphics.BlurMaskFilter.Blur OUTER
			{
				get
				{
					return default(global::android.graphics.BlurMaskFilter.Blur);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SOLID3161;
			public static global::android.graphics.BlurMaskFilter.Blur SOLID
			{
				get
				{
					return default(global::android.graphics.BlurMaskFilter.Blur);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.BlurMaskFilter.Blur.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BlurMaskFilter$Blur"));
				global::android.graphics.BlurMaskFilter.Blur._values3156 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "values", "()[Landroid/graphics/BlurMaskFilter/Blur;");
				global::android.graphics.BlurMaskFilter.Blur._valueOf3157 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BlurMaskFilter.Blur.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/BlurMaskFilter$Blur;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _BlurMaskFilter3162;
		public BlurMaskFilter(float arg0, android.graphics.BlurMaskFilter.Blur arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BlurMaskFilter.staticClass, global::android.graphics.BlurMaskFilter._BlurMaskFilter3162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.BlurMaskFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BlurMaskFilter"));
			global::android.graphics.BlurMaskFilter._BlurMaskFilter3162 = @__env.GetMethodIDNoThrow(global::android.graphics.BlurMaskFilter.staticClass, "<init>", "(FLandroid/graphics/BlurMaskFilter$Blur;)V");
		}
	}
}
