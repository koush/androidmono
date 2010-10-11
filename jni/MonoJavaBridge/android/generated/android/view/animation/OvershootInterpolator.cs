namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OvershootInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OvershootInterpolator()
		{
			InitJNI();
		}
		protected OvershootInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation10042;
		public virtual float getInterpolation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.OvershootInterpolator._getInterpolation10042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.OvershootInterpolator.staticClass, global::android.view.animation.OvershootInterpolator._getInterpolation10042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _OvershootInterpolator10043;
		public OvershootInterpolator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.OvershootInterpolator.staticClass, global::android.view.animation.OvershootInterpolator._OvershootInterpolator10043);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OvershootInterpolator10044;
		public OvershootInterpolator(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.OvershootInterpolator.staticClass, global::android.view.animation.OvershootInterpolator._OvershootInterpolator10044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OvershootInterpolator10045;
		public OvershootInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.OvershootInterpolator.staticClass, global::android.view.animation.OvershootInterpolator._OvershootInterpolator10045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.OvershootInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/OvershootInterpolator"));
			global::android.view.animation.OvershootInterpolator._getInterpolation10042 = @__env.GetMethodIDNoThrow(global::android.view.animation.OvershootInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.OvershootInterpolator._OvershootInterpolator10043 = @__env.GetMethodIDNoThrow(global::android.view.animation.OvershootInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.OvershootInterpolator._OvershootInterpolator10044 = @__env.GetMethodIDNoThrow(global::android.view.animation.OvershootInterpolator.staticClass, "<init>", "(F)V");
			global::android.view.animation.OvershootInterpolator._OvershootInterpolator10045 = @__env.GetMethodIDNoThrow(global::android.view.animation.OvershootInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
