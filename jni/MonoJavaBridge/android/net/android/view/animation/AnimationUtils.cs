namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AnimationUtils : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AnimationUtils() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.AnimationUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.animation.AnimationUtils(@__env); 
			} 
		} 
		protected AnimationUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _currentAnimationTimeMillis8917; 
		public static long currentAnimationTimeMillis() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.view.animation.AnimationUtils.staticClass, _currentAnimationTimeMillis8917); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadAnimation8918; 
		public static android.view.animation.Animation loadAnimation(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallStaticObjectMethodPtr(android.view.animation.AnimationUtils.staticClass, _loadAnimation8918, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadLayoutAnimation8919; 
		public static android.view.animation.LayoutAnimationController loadLayoutAnimation(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.LayoutAnimationController>(@__env, @__env.CallStaticObjectMethodPtr(android.view.animation.AnimationUtils.staticClass, _loadLayoutAnimation8919, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeInAnimation8920; 
		public static android.view.animation.Animation makeInAnimation(android.content.Context arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallStaticObjectMethodPtr(android.view.animation.AnimationUtils.staticClass, _makeInAnimation8920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeOutAnimation8921; 
		public static android.view.animation.Animation makeOutAnimation(android.content.Context arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallStaticObjectMethodPtr(android.view.animation.AnimationUtils.staticClass, _makeOutAnimation8921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeInChildBottomAnimation8922; 
		public static android.view.animation.Animation makeInChildBottomAnimation(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallStaticObjectMethodPtr(android.view.animation.AnimationUtils.staticClass, _makeInChildBottomAnimation8922, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadInterpolator8923; 
		public static android.view.animation.Interpolator loadInterpolator(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallStaticObjectMethodPtr(android.view.animation.AnimationUtils.staticClass, _loadInterpolator8923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnimationUtils8924; 
		public AnimationUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnimationUtils.staticClass, _AnimationUtils8924, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.AnimationUtils.staticClass = @__class; 
			global::android.view.animation.AnimationUtils._currentAnimationTimeMillis8917 = @__env.GetStaticMethodID(global::android.view.animation.AnimationUtils.staticClass, "currentAnimationTimeMillis", "()J"); 
			global::android.view.animation.AnimationUtils._loadAnimation8918 = @__env.GetStaticMethodID(global::android.view.animation.AnimationUtils.staticClass, "loadAnimation", "(Landroid/content/Context;I)Landroid/view/animation/Animation;"); 
			global::android.view.animation.AnimationUtils._loadLayoutAnimation8919 = @__env.GetStaticMethodID(global::android.view.animation.AnimationUtils.staticClass, "loadLayoutAnimation", "(Landroid/content/Context;I)Landroid/view/animation/LayoutAnimationController;"); 
			global::android.view.animation.AnimationUtils._makeInAnimation8920 = @__env.GetStaticMethodID(global::android.view.animation.AnimationUtils.staticClass, "makeInAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;"); 
			global::android.view.animation.AnimationUtils._makeOutAnimation8921 = @__env.GetStaticMethodID(global::android.view.animation.AnimationUtils.staticClass, "makeOutAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;"); 
			global::android.view.animation.AnimationUtils._makeInChildBottomAnimation8922 = @__env.GetStaticMethodID(global::android.view.animation.AnimationUtils.staticClass, "makeInChildBottomAnimation", "(Landroid/content/Context;)Landroid/view/animation/Animation;"); 
			global::android.view.animation.AnimationUtils._loadInterpolator8923 = @__env.GetStaticMethodID(global::android.view.animation.AnimationUtils.staticClass, "loadInterpolator", "(Landroid/content/Context;I)Landroid/view/animation/Interpolator;"); 
			global::android.view.animation.AnimationUtils._AnimationUtils8924 = @__env.GetMethodID(global::android.view.animation.AnimationUtils.staticClass, "<init>", "()V"); 
		} 
	} 
} 
