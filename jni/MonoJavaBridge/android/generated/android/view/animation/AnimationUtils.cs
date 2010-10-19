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
		internal static global::MonoJavaBridge.MethodId _currentAnimationTimeMillis10517;
		public static long currentAnimationTimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._currentAnimationTimeMillis10517);
		}
		internal static global::MonoJavaBridge.MethodId _loadAnimation10518;
		public static global::android.view.animation.Animation loadAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._loadAnimation10518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _loadLayoutAnimation10519;
		public static global::android.view.animation.LayoutAnimationController loadLayoutAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._loadLayoutAnimation10519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.LayoutAnimationController;
		}
		internal static global::MonoJavaBridge.MethodId _makeInAnimation10520;
		public static global::android.view.animation.Animation makeInAnimation(android.content.Context arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._makeInAnimation10520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _makeOutAnimation10521;
		public static global::android.view.animation.Animation makeOutAnimation(android.content.Context arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._makeOutAnimation10521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _makeInChildBottomAnimation10522;
		public static global::android.view.animation.Animation makeInChildBottomAnimation(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._makeInChildBottomAnimation10522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _loadInterpolator10523;
		public static global::android.view.animation.Interpolator loadInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._loadInterpolator10523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Interpolator;
		}
		internal static global::MonoJavaBridge.MethodId _AnimationUtils10524;
		public AnimationUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._AnimationUtils10524);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnimationUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnimationUtils"));
			global::android.view.animation.AnimationUtils._currentAnimationTimeMillis10517 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "currentAnimationTimeMillis", "()J");
			global::android.view.animation.AnimationUtils._loadAnimation10518 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadAnimation", "(Landroid/content/Context;I)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._loadLayoutAnimation10519 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadLayoutAnimation", "(Landroid/content/Context;I)Landroid/view/animation/LayoutAnimationController;");
			global::android.view.animation.AnimationUtils._makeInAnimation10520 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeInAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._makeOutAnimation10521 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeOutAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._makeInChildBottomAnimation10522 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeInChildBottomAnimation", "(Landroid/content/Context;)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._loadInterpolator10523 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadInterpolator", "(Landroid/content/Context;I)Landroid/view/animation/Interpolator;");
			global::android.view.animation.AnimationUtils._AnimationUtils10524 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "<init>", "()V");
		}
	}
}
