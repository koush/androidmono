namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BounceInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BounceInterpolator()
		{
			InitJNI();
		}
		protected BounceInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15673;
		public virtual float getInterpolation(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.BounceInterpolator._getInterpolation15673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.BounceInterpolator.staticClass, global::android.view.animation.BounceInterpolator._getInterpolation15673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BounceInterpolator15674;
		public BounceInterpolator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.BounceInterpolator.staticClass, global::android.view.animation.BounceInterpolator._BounceInterpolator15674);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BounceInterpolator15675;
		public BounceInterpolator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.BounceInterpolator.staticClass, global::android.view.animation.BounceInterpolator._BounceInterpolator15675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.BounceInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/BounceInterpolator"));
			global::android.view.animation.BounceInterpolator._getInterpolation15673 = @__env.GetMethodIDNoThrow(global::android.view.animation.BounceInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.BounceInterpolator._BounceInterpolator15674 = @__env.GetMethodIDNoThrow(global::android.view.animation.BounceInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.BounceInterpolator._BounceInterpolator15675 = @__env.GetMethodIDNoThrow(global::android.view.animation.BounceInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
