namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class OvershootInterpolator : java.lang.Object, Interpolator
	{ 
		internal static global::java.lang.Class staticClass; 
		static OvershootInterpolator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.OvershootInterpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.animation.OvershootInterpolator(@__env); 
			} 
		} 
		protected OvershootInterpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolation8988; 
		public virtual float getInterpolation(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.OvershootInterpolator)) 
				return @__env.CallFloatMethod(this, global::android.view.animation.OvershootInterpolator._getInterpolation8988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.OvershootInterpolator.staticClass, global::android.view.animation.OvershootInterpolator._getInterpolation8988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OvershootInterpolator8989; 
		public OvershootInterpolator()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.OvershootInterpolator.staticClass, global::android.view.animation.OvershootInterpolator._OvershootInterpolator8989, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OvershootInterpolator8990; 
		public OvershootInterpolator(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.OvershootInterpolator.staticClass, global::android.view.animation.OvershootInterpolator._OvershootInterpolator8990, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OvershootInterpolator8991; 
		public OvershootInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.OvershootInterpolator.staticClass, global::android.view.animation.OvershootInterpolator._OvershootInterpolator8991, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.OvershootInterpolator.staticClass = @__class; 
			global::android.view.animation.OvershootInterpolator._getInterpolation8988 = @__env.GetMethodID(global::android.view.animation.OvershootInterpolator.staticClass, "getInterpolation", "(F)F"); 
			global::android.view.animation.OvershootInterpolator._OvershootInterpolator8989 = @__env.GetMethodID(global::android.view.animation.OvershootInterpolator.staticClass, "<init>", "()V"); 
			global::android.view.animation.OvershootInterpolator._OvershootInterpolator8990 = @__env.GetMethodID(global::android.view.animation.OvershootInterpolator.staticClass, "<init>", "(F)V"); 
			global::android.view.animation.OvershootInterpolator._OvershootInterpolator8991 = @__env.GetMethodID(global::android.view.animation.OvershootInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
