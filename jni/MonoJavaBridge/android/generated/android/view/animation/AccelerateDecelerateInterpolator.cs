namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AccelerateDecelerateInterpolator : java.lang.Object, Interpolator
	{
		internal static global::java.lang.Class staticClass;
		static AccelerateDecelerateInterpolator()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.AccelerateDecelerateInterpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.animation.AccelerateDecelerateInterpolator(@__env);
			}
		}
		protected AccelerateDecelerateInterpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolation8835;
		public virtual float getInterpolation(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.animation.AccelerateDecelerateInterpolator._getInterpolation8835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._getInterpolation8835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AccelerateDecelerateInterpolator8836;
		public AccelerateDecelerateInterpolator()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator8836, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AccelerateDecelerateInterpolator8837;
		public AccelerateDecelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator8837, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.animation.AccelerateDecelerateInterpolator.staticClass = @__class;
			global::android.view.animation.AccelerateDecelerateInterpolator._getInterpolation8835 = @__env.GetMethodID(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator8836 = @__env.GetMethodID(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator8837 = @__env.GetMethodID(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
