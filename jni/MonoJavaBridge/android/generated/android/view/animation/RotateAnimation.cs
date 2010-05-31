namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RotateAnimation : android.view.animation.Animation
	{
		internal new static global::java.lang.Class staticClass;
		static RotateAnimation()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.RotateAnimation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.animation.RotateAnimation(@__env);
			}
		}
		protected RotateAnimation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _initialize8992;
		public override void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.RotateAnimation._initialize8992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._initialize8992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _applyTransformation8993;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.RotateAnimation._applyTransformation8993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._applyTransformation8993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RotateAnimation8994;
		public RotateAnimation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._RotateAnimation8994, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RotateAnimation8995;
		public RotateAnimation(float arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._RotateAnimation8995, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RotateAnimation8996;
		public RotateAnimation(float arg0, float arg1, float arg2, float arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._RotateAnimation8996, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RotateAnimation8997;
		public RotateAnimation(float arg0, float arg1, int arg2, float arg3, int arg4, float arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._RotateAnimation8997, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.animation.RotateAnimation.staticClass = @__class;
			global::android.view.animation.RotateAnimation._initialize8992 = @__env.GetMethodID(global::android.view.animation.RotateAnimation.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.RotateAnimation._applyTransformation8993 = @__env.GetMethodID(global::android.view.animation.RotateAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.RotateAnimation._RotateAnimation8994 = @__env.GetMethodID(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.RotateAnimation._RotateAnimation8995 = @__env.GetMethodID(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(FF)V");
			global::android.view.animation.RotateAnimation._RotateAnimation8996 = @__env.GetMethodID(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(FFFF)V");
			global::android.view.animation.RotateAnimation._RotateAnimation8997 = @__env.GetMethodID(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(FFIFIF)V");
		}
	}
}
