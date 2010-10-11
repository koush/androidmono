namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnticipateInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnticipateInterpolator()
		{
			InitJNI();
		}
		protected AnticipateInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation9979;
		public virtual float getInterpolation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.AnticipateInterpolator._getInterpolation9979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._getInterpolation9979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateInterpolator9980;
		public AnticipateInterpolator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator9980);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateInterpolator9981;
		public AnticipateInterpolator(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator9981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateInterpolator9982;
		public AnticipateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator9982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnticipateInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnticipateInterpolator"));
			global::android.view.animation.AnticipateInterpolator._getInterpolation9979 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator9980 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator9981 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateInterpolator.staticClass, "<init>", "(F)V");
			global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator9982 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
