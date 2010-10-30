namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlphaAnimation : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlphaAnimation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix15570;
		public override bool willChangeTransformationMatrix()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.AlphaAnimation.staticClass, "willChangeTransformationMatrix", "()Z", ref global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix15570);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds15571;
		public override bool willChangeBounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.animation.AlphaAnimation.staticClass, "willChangeBounds", "()Z", ref global::android.view.animation.AlphaAnimation._willChangeBounds15571);
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation15572;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.AlphaAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V", ref global::android.view.animation.AlphaAnimation._applyTransformation15572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AlphaAnimation15573;
		public AlphaAnimation(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AlphaAnimation._AlphaAnimation15573.native == global::System.IntPtr.Zero)
				global::android.view.animation.AlphaAnimation._AlphaAnimation15573 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._AlphaAnimation15573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlphaAnimation15574;
		public AlphaAnimation(float arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AlphaAnimation._AlphaAnimation15574.native == global::System.IntPtr.Zero)
				global::android.view.animation.AlphaAnimation._AlphaAnimation15574 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._AlphaAnimation15574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AlphaAnimation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AlphaAnimation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AlphaAnimation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
