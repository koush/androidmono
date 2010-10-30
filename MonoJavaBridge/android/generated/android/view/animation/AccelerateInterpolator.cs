namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccelerateInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccelerateInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15566;
		public virtual float getInterpolation(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.AccelerateInterpolator.staticClass, "getInterpolation", "(F)F", ref global::android.view.animation.AccelerateInterpolator._getInterpolation15566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateInterpolator15567;
		public AccelerateInterpolator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator15567.native == global::System.IntPtr.Zero)
				global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator15567 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateInterpolator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator15567);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateInterpolator15568;
		public AccelerateInterpolator(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator15568.native == global::System.IntPtr.Zero)
				global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator15568 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateInterpolator.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator15568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateInterpolator15569;
		public AccelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator15569.native == global::System.IntPtr.Zero)
				global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator15569 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator15569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AccelerateInterpolator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AccelerateInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AccelerateInterpolator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
