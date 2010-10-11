namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnimationUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnimationUtils()
		{
			InitJNI();
		}
		protected AnimationUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _currentAnimationTimeMillis9971;
		public static long currentAnimationTimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._currentAnimationTimeMillis9971);
		}
		internal static global::MonoJavaBridge.MethodId _loadAnimation9972;
		public static global::android.view.animation.Animation loadAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._loadAnimation9972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _loadLayoutAnimation9973;
		public static global::android.view.animation.LayoutAnimationController loadLayoutAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._loadLayoutAnimation9973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.LayoutAnimationController;
		}
		internal static global::MonoJavaBridge.MethodId _makeInAnimation9974;
		public static global::android.view.animation.Animation makeInAnimation(android.content.Context arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._makeInAnimation9974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _makeOutAnimation9975;
		public static global::android.view.animation.Animation makeOutAnimation(android.content.Context arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._makeOutAnimation9975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _makeInChildBottomAnimation9976;
		public static global::android.view.animation.Animation makeInChildBottomAnimation(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._makeInChildBottomAnimation9976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _loadInterpolator9977;
		public static global::android.view.animation.Interpolator loadInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._loadInterpolator9977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Interpolator;
		}
		internal static global::MonoJavaBridge.MethodId _AnimationUtils9978;
		public AnimationUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._AnimationUtils9978);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnimationUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnimationUtils"));
			global::android.view.animation.AnimationUtils._currentAnimationTimeMillis9971 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "currentAnimationTimeMillis", "()J");
			global::android.view.animation.AnimationUtils._loadAnimation9972 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadAnimation", "(Landroid/content/Context;I)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._loadLayoutAnimation9973 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadLayoutAnimation", "(Landroid/content/Context;I)Landroid/view/animation/LayoutAnimationController;");
			global::android.view.animation.AnimationUtils._makeInAnimation9974 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeInAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._makeOutAnimation9975 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeOutAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._makeInChildBottomAnimation9976 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeInChildBottomAnimation", "(Landroid/content/Context;)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._loadInterpolator9977 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadInterpolator", "(Landroid/content/Context;I)Landroid/view/animation/Interpolator;");
			global::android.view.animation.AnimationUtils._AnimationUtils9978 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "<init>", "()V");
		}
	}
}
