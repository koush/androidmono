namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RotateAnimation : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RotateAnimation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void initialize(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.RotateAnimation.staticClass, "initialize", "(IIII)V", ref global::android.view.animation.RotateAnimation._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.RotateAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V", ref global::android.view.animation.RotateAnimation._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public RotateAnimation(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.RotateAnimation._m2.native == global::System.IntPtr.Zero)
				global::android.view.animation.RotateAnimation._m2 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public RotateAnimation(float arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.RotateAnimation._m3.native == global::System.IntPtr.Zero)
				global::android.view.animation.RotateAnimation._m3 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public RotateAnimation(float arg0, float arg1, float arg2, float arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.RotateAnimation._m4.native == global::System.IntPtr.Zero)
				global::android.view.animation.RotateAnimation._m4 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(FFFF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public RotateAnimation(float arg0, float arg1, int arg2, float arg3, int arg4, float arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.RotateAnimation._m5.native == global::System.IntPtr.Zero)
				global::android.view.animation.RotateAnimation._m5 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(FFIFIF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		static RotateAnimation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.RotateAnimation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/RotateAnimation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
