namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DecelerateInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DecelerateInterpolator()
		{
			InitJNI();
		}
		protected DecelerateInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15599;
		public virtual float getInterpolation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.DecelerateInterpolator._getInterpolation15599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.DecelerateInterpolator.staticClass, global::android.view.animation.DecelerateInterpolator._getInterpolation15599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DecelerateInterpolator15600;
		public DecelerateInterpolator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.DecelerateInterpolator.staticClass, global::android.view.animation.DecelerateInterpolator._DecelerateInterpolator15600);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecelerateInterpolator15601;
		public DecelerateInterpolator(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.DecelerateInterpolator.staticClass, global::android.view.animation.DecelerateInterpolator._DecelerateInterpolator15601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecelerateInterpolator15602;
		public DecelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.DecelerateInterpolator.staticClass, global::android.view.animation.DecelerateInterpolator._DecelerateInterpolator15602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.DecelerateInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/DecelerateInterpolator"));
			global::android.view.animation.DecelerateInterpolator._getInterpolation15599 = @__env.GetMethodIDNoThrow(global::android.view.animation.DecelerateInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.DecelerateInterpolator._DecelerateInterpolator15600 = @__env.GetMethodIDNoThrow(global::android.view.animation.DecelerateInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.DecelerateInterpolator._DecelerateInterpolator15601 = @__env.GetMethodIDNoThrow(global::android.view.animation.DecelerateInterpolator.staticClass, "<init>", "(F)V");
			global::android.view.animation.DecelerateInterpolator._DecelerateInterpolator15602 = @__env.GetMethodIDNoThrow(global::android.view.animation.DecelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
