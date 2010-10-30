namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TranslateAnimation : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TranslateAnimation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initialize15771;
		public override void initialize(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.TranslateAnimation.staticClass, "initialize", "(IIII)V", ref global::android.view.animation.TranslateAnimation._initialize15771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation15772;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.TranslateAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V", ref global::android.view.animation.TranslateAnimation._applyTransformation15772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _TranslateAnimation15773;
		public TranslateAnimation(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.TranslateAnimation._TranslateAnimation15773.native == global::System.IntPtr.Zero)
				global::android.view.animation.TranslateAnimation._TranslateAnimation15773 = @__env.GetMethodIDNoThrow(global::android.view.animation.TranslateAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.TranslateAnimation.staticClass, global::android.view.animation.TranslateAnimation._TranslateAnimation15773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TranslateAnimation15774;
		public TranslateAnimation(float arg0, float arg1, float arg2, float arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.TranslateAnimation._TranslateAnimation15774.native == global::System.IntPtr.Zero)
				global::android.view.animation.TranslateAnimation._TranslateAnimation15774 = @__env.GetMethodIDNoThrow(global::android.view.animation.TranslateAnimation.staticClass, "<init>", "(FFFF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.TranslateAnimation.staticClass, global::android.view.animation.TranslateAnimation._TranslateAnimation15774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TranslateAnimation15775;
		public TranslateAnimation(int arg0, float arg1, int arg2, float arg3, int arg4, float arg5, int arg6, float arg7) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.TranslateAnimation._TranslateAnimation15775.native == global::System.IntPtr.Zero)
				global::android.view.animation.TranslateAnimation._TranslateAnimation15775 = @__env.GetMethodIDNoThrow(global::android.view.animation.TranslateAnimation.staticClass, "<init>", "(IFIFIFIF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.TranslateAnimation.staticClass, global::android.view.animation.TranslateAnimation._TranslateAnimation15775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		static TranslateAnimation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.TranslateAnimation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/TranslateAnimation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
