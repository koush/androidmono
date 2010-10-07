namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AlphaAnimation : android.view.animation.Animation
	{
		internal new static global::java.lang.Class staticClass;
		static AlphaAnimation()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.AlphaAnimation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.animation.AlphaAnimation(@__env);
			}
		}
		protected AlphaAnimation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _willChangeTransformationMatrix9548;
		public override bool willChangeTransformationMatrix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix9548);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix9548);
		}
		internal static global::net.sf.jni4net.jni.MethodId _willChangeBounds9549;
		public override bool willChangeBounds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.animation.AlphaAnimation._willChangeBounds9549);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._willChangeBounds9549);
		}
		internal static global::net.sf.jni4net.jni.MethodId _applyTransformation9550;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.AlphaAnimation._applyTransformation9550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._applyTransformation9550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AlphaAnimation9551;
		public AlphaAnimation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._AlphaAnimation9551, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AlphaAnimation9552;
		public AlphaAnimation(float arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._AlphaAnimation9552, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.animation.AlphaAnimation.staticClass = @__class;
			global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix9548 = @__env.GetMethodID(global::android.view.animation.AlphaAnimation.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.AlphaAnimation._willChangeBounds9549 = @__env.GetMethodID(global::android.view.animation.AlphaAnimation.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.AlphaAnimation._applyTransformation9550 = @__env.GetMethodID(global::android.view.animation.AlphaAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.AlphaAnimation._AlphaAnimation9551 = @__env.GetMethodID(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.AlphaAnimation._AlphaAnimation9552 = @__env.GetMethodID(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(FF)V");
		}
	}
}
