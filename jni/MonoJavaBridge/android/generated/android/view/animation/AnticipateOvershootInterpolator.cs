namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnticipateOvershootInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnticipateOvershootInterpolator()
		{
			InitJNI();
		}
		protected AnticipateOvershootInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation10529;
		public virtual float getInterpolation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.AnticipateOvershootInterpolator._getInterpolation10529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._getInterpolation10529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateOvershootInterpolator10530;
		public AnticipateOvershootInterpolator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator10530);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateOvershootInterpolator10531;
		public AnticipateOvershootInterpolator(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator10531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateOvershootInterpolator10532;
		public AnticipateOvershootInterpolator(float arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator10532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateOvershootInterpolator10533;
		public AnticipateOvershootInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateOvershootInterpolator.staticClass, global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator10533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnticipateOvershootInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnticipateOvershootInterpolator"));
			global::android.view.animation.AnticipateOvershootInterpolator._getInterpolation10529 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator10530 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator10531 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "(F)V");
			global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator10532 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "(FF)V");
			global::android.view.animation.AnticipateOvershootInterpolator._AnticipateOvershootInterpolator10533 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateOvershootInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
