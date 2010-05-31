namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BounceInterpolator : java.lang.Object, Interpolator
	{
		internal static global::java.lang.Class staticClass;
		static BounceInterpolator()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.BounceInterpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.animation.BounceInterpolator(@__env);
			}
		}
		protected BounceInterpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolation8934;
		public virtual float getInterpolation(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.animation.BounceInterpolator._getInterpolation8934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.BounceInterpolator.staticClass, global::android.view.animation.BounceInterpolator._getInterpolation8934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BounceInterpolator8935;
		public BounceInterpolator()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.BounceInterpolator.staticClass, global::android.view.animation.BounceInterpolator._BounceInterpolator8935, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _BounceInterpolator8936;
		public BounceInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.BounceInterpolator.staticClass, global::android.view.animation.BounceInterpolator._BounceInterpolator8936, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.animation.BounceInterpolator.staticClass = @__class;
			global::android.view.animation.BounceInterpolator._getInterpolation8934 = @__env.GetMethodID(global::android.view.animation.BounceInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.BounceInterpolator._BounceInterpolator8935 = @__env.GetMethodID(global::android.view.animation.BounceInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.BounceInterpolator._BounceInterpolator8936 = @__env.GetMethodID(global::android.view.animation.BounceInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
