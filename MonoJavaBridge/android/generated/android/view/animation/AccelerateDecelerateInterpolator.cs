namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccelerateDecelerateInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccelerateDecelerateInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual float getInterpolation(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "getInterpolation", "(F)F", ref global::android.view.animation.AccelerateDecelerateInterpolator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AccelerateDecelerateInterpolator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AccelerateDecelerateInterpolator._m1.native == global::System.IntPtr.Zero)
				global::android.view.animation.AccelerateDecelerateInterpolator._m1 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._m1);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AccelerateDecelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AccelerateDecelerateInterpolator._m2.native == global::System.IntPtr.Zero)
				global::android.view.animation.AccelerateDecelerateInterpolator._m2 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
