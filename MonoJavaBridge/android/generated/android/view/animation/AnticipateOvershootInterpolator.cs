namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnticipateOvershootInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnticipateOvershootInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15668;
		public virtual float getInterpolation(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "getInterpolation", "(F)F", ref global::android.view.animation.AnticipateOvershootInterpolator._getInterpolation15668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateOvershootInterpolator15669;
		public AnticipateOvershootInterpolator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15669.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15669 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15669);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateOvershootInterpolator15670;
		public AnticipateOvershootInterpolator(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15670.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15670 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateOvershootInterpolator15671;
		public AnticipateOvershootInterpolator(float arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15671.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15671 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "(FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateOvershootInterpolator15672;
		public AnticipateOvershootInterpolator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15672.native == global::System.IntPtr.Zero)
				global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15672 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator15672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AnticipateOvershootInterpolator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnticipateOvershootInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnticipateOvershootInterpolator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
