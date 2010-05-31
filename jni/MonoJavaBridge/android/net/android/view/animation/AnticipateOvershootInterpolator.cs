namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AnticipateOvershootInterpolator : java.lang.Object, Interpolator
	{ 
		internal static global::java.lang.Class staticClass; 
		static AnticipateOvershootInterpolator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.AnticipateOvershootInterpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.animation.AnticipateOvershootInterpolator(@__env); 
			} 
		} 
		protected AnticipateOvershootInterpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolation8929; 
		public virtual float getInterpolation(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.view.animation.AnticipateOvershootInterpolator._getInterpolation8929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._getInterpolation8929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnticipateOvershootInterpolator8930; 
		public AnticipateOvershootInterpolator()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator8930, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnticipateOvershootInterpolator8931; 
		public AnticipateOvershootInterpolator(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator8931, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnticipateOvershootInterpolator8932; 
		public AnticipateOvershootInterpolator(float arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator8932, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnticipateOvershootInterpolator8933; 
		public AnticipateOvershootInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator8933, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.AnticipateOvershootInterpolator.staticClass = @__class; 
			global::android.view.animation.AnticipateOvershootInterpolator._getInterpolation8929 = @__env.GetMethodID(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "getInterpolation", "(F)F"); 
			global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator8930 = @__env.GetMethodID(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "()V"); 
			global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator8931 = @__env.GetMethodID(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "(F)V"); 
			global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator8932 = @__env.GetMethodID(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "(FF)V"); 
			global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator8933 = @__env.GetMethodID(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
