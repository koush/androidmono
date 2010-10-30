namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccelerateDecelerateInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccelerateDecelerateInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15563;
		public virtual float getInterpolation(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "getInterpolation", "(F)F", ref global::android.view.animation.AccelerateDecelerateInterpolator._getInterpolation15563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateDecelerateInterpolator15564;
		public AccelerateDecelerateInterpolator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15564.native == global::System.IntPtr.Zero)
				global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15564 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15564);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateDecelerateInterpolator15565;
		public AccelerateDecelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15565.native == global::System.IntPtr.Zero)
				global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15565 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AccelerateDecelerateInterpolator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AccelerateDecelerateInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AccelerateDecelerateInterpolator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
