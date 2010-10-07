namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AccelerateInterpolator : java.lang.Object, Interpolator
	{
		internal static global::java.lang.Class staticClass;
		static AccelerateInterpolator()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.AccelerateInterpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.animation.AccelerateInterpolator(@__env);
			}
		}
		protected AccelerateInterpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolation9544;
		public virtual float getInterpolation(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.animation.AccelerateInterpolator._getInterpolation9544, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._getInterpolation9544, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AccelerateInterpolator9545;
		public AccelerateInterpolator()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9545, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AccelerateInterpolator9546;
		public AccelerateInterpolator(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9546, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AccelerateInterpolator9547;
		public AccelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9547, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.animation.AccelerateInterpolator.staticClass = @__class;
			global::android.view.animation.AccelerateInterpolator._getInterpolation9544 = @__env.GetMethodID(global::android.view.animation.AccelerateInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9545 = @__env.GetMethodID(global::android.view.animation.AccelerateInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9546 = @__env.GetMethodID(global::android.view.animation.AccelerateInterpolator.staticClass, "<init>", "(F)V");
			global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9547 = @__env.GetMethodID(global::android.view.animation.AccelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
