namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlphaAnimation : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlphaAnimation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool willChangeTransformationMatrix()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.AlphaAnimation.staticClass, "willChangeTransformationMatrix", "()Z", ref global::android.view.animation.AlphaAnimation._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool willChangeBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.AlphaAnimation.staticClass, "willChangeBounds", "()Z", ref global::android.view.animation.AlphaAnimation._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AlphaAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V", ref global::android.view.animation.AlphaAnimation._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public AlphaAnimation(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AlphaAnimation._m3.native == global::System.IntPtr.Zero)
				global::android.view.animation.AlphaAnimation._m3 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public AlphaAnimation(float arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AlphaAnimation._m4.native == global::System.IntPtr.Zero)
				global::android.view.animation.AlphaAnimation._m4 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AlphaAnimation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AlphaAnimation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AlphaAnimation"));
		}
	}
}
