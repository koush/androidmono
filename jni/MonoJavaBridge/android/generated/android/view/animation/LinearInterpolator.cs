namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinearInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinearInterpolator()
		{
			InitJNI();
		}
		protected LinearInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15737;
		public virtual float getInterpolation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.LinearInterpolator._getInterpolation15737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.LinearInterpolator.staticClass, global::android.view.animation.LinearInterpolator._getInterpolation15737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LinearInterpolator15738;
		public LinearInterpolator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LinearInterpolator.staticClass, global::android.view.animation.LinearInterpolator._LinearInterpolator15738);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinearInterpolator15739;
		public LinearInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.LinearInterpolator.staticClass, global::android.view.animation.LinearInterpolator._LinearInterpolator15739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.LinearInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/LinearInterpolator"));
			global::android.view.animation.LinearInterpolator._getInterpolation15737 = @__env.GetMethodIDNoThrow(global::android.view.animation.LinearInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.LinearInterpolator._LinearInterpolator15738 = @__env.GetMethodIDNoThrow(global::android.view.animation.LinearInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.LinearInterpolator._LinearInterpolator15739 = @__env.GetMethodIDNoThrow(global::android.view.animation.LinearInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
