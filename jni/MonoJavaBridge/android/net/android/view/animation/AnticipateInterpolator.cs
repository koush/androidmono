namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AnticipateInterpolator : java.lang.Object, Interpolator
	{ 
		internal static global::java.lang.Class staticClass; 
		static AnticipateInterpolator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.AnticipateInterpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.animation.AnticipateInterpolator(@__env); 
			} 
		} 
		protected AnticipateInterpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolation8925; 
		public virtual float getInterpolation(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.view.animation.AnticipateInterpolator._getInterpolation8925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._getInterpolation8925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnticipateInterpolator8926; 
		public AnticipateInterpolator()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator8926, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnticipateInterpolator8927; 
		public AnticipateInterpolator(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator8927, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnticipateInterpolator8928; 
		public AnticipateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator8928, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.AnticipateInterpolator.staticClass = @__class; 
			global::android.view.animation.AnticipateInterpolator._getInterpolation8925 = @__env.GetMethodID(global::android.view.animation.AnticipateInterpolator.staticClass, "getInterpolation", "(F)F"); 
			global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator8926 = @__env.GetMethodID(global::android.view.animation.AnticipateInterpolator.staticClass, "<init>", "()V"); 
			global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator8927 = @__env.GetMethodID(global::android.view.animation.AnticipateInterpolator.staticClass, "<init>", "(F)V"); 
			global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator8928 = @__env.GetMethodID(global::android.view.animation.AnticipateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
