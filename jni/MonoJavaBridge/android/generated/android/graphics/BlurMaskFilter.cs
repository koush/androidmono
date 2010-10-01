namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BlurMaskFilter : android.graphics.MaskFilter
	{
		internal new static global::java.lang.Class staticClass;
		static BlurMaskFilter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.BlurMaskFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.BlurMaskFilter(@__env);
			}
		}
		protected BlurMaskFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Blur : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Blur()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.BlurMaskFilter.Blur), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.BlurMaskFilter.Blur(@__env);
				}
			}
			internal Blur(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values2785;
			public static global::android.graphics.BlurMaskFilter.Blur[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BlurMaskFilter.Blur.staticClass, global::android.graphics.BlurMaskFilter.Blur._values2785));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2786;
			public static global::android.graphics.BlurMaskFilter.Blur valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.BlurMaskFilter.Blur>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BlurMaskFilter.Blur.staticClass, global::android.graphics.BlurMaskFilter.Blur._valueOf2786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _INNER2787;
			public static global::android.graphics.BlurMaskFilter.Blur INNER
			{
				get
				{
					return default(global::android.graphics.BlurMaskFilter.Blur);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL2788;
			public static global::android.graphics.BlurMaskFilter.Blur NORMAL
			{
				get
				{
					return default(global::android.graphics.BlurMaskFilter.Blur);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _OUTER2789;
			public static global::android.graphics.BlurMaskFilter.Blur OUTER
			{
				get
				{
					return default(global::android.graphics.BlurMaskFilter.Blur);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SOLID2790;
			public static global::android.graphics.BlurMaskFilter.Blur SOLID
			{
				get
				{
					return default(global::android.graphics.BlurMaskFilter.Blur);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.BlurMaskFilter.Blur.staticClass = @__class;
				global::android.graphics.BlurMaskFilter.Blur._values2785 = @__env.GetStaticMethodID(global::android.graphics.BlurMaskFilter.Blur.staticClass, "values", "()[Landroid/graphics/BlurMaskFilter/Blur;");
				global::android.graphics.BlurMaskFilter.Blur._valueOf2786 = @__env.GetStaticMethodID(global::android.graphics.BlurMaskFilter.Blur.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/BlurMaskFilter$Blur;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _BlurMaskFilter2791;
		public BlurMaskFilter(float arg0, android.graphics.BlurMaskFilter.Blur arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.BlurMaskFilter.staticClass, global::android.graphics.BlurMaskFilter._BlurMaskFilter2791, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.BlurMaskFilter.staticClass = @__class;
			global::android.graphics.BlurMaskFilter._BlurMaskFilter2791 = @__env.GetMethodID(global::android.graphics.BlurMaskFilter.staticClass, "<init>", "(FLandroid/graphics/BlurMaskFilter$Blur;)V");
		}
	}
}
