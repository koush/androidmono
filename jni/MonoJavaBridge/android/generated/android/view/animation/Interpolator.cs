namespace android.view.animation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.animation.Interpolator_))]
	public interface Interpolator  : global::MonoJavaBridge.IJavaObject 
	{
		float getInterpolation(float arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Interpolator))]
	public sealed partial class Interpolator_ : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Interpolator_()
		{
			InitJNI();
		}
		internal Interpolator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation10016;
		 float android.view.animation.Interpolator.getInterpolation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.Interpolator_._getInterpolation10016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.Interpolator_.staticClass, global::android.view.animation.Interpolator_._getInterpolation10016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Interpolator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Interpolator"));
			global::android.view.animation.Interpolator_._getInterpolation10016 = @__env.GetMethodIDNoThrow(global::android.view.animation.Interpolator_.staticClass, "getInterpolation", "(F)F");
		}
	}
}
