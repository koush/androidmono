namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnimationUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnimationUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static long currentAnimationTimeMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationUtils._m0.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "currentAnimationTimeMillis", "()J");
			return @__env.CallStaticLongMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.view.animation.Animation loadAnimation(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationUtils._m1.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadAnimation", "(Landroid/content/Context;I)Landroid/view/animation/Animation;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.view.animation.LayoutAnimationController loadLayoutAnimation(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationUtils._m2.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadLayoutAnimation", "(Landroid/content/Context;I)Landroid/view/animation/LayoutAnimationController;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.LayoutAnimationController;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::android.view.animation.Animation makeInAnimation(android.content.Context arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationUtils._m3.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeInAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::android.view.animation.Animation makeOutAnimation(android.content.Context arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationUtils._m4.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeOutAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.view.animation.Animation makeInChildBottomAnimation(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationUtils._m5.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationUtils._m5 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeInChildBottomAnimation", "(Landroid/content/Context;)Landroid/view/animation/Animation;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.view.animation.Interpolator loadInterpolator(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationUtils._m6.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationUtils._m6 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadInterpolator", "(Landroid/content/Context;I)Landroid/view/animation/Interpolator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Interpolator;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AnimationUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnimationUtils._m7.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnimationUtils._m7 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._m7);
			Init(@__env, handle);
		}
		static AnimationUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnimationUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnimationUtils"));
		}
	}
}
