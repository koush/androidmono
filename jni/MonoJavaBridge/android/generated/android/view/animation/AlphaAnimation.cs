namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlphaAnimation : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlphaAnimation()
		{
			InitJNI();
		}
		protected AlphaAnimation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix15570;
		public override bool willChangeTransformationMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix15570);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix15570);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds15571;
		public override bool willChangeBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation._willChangeBounds15571);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._willChangeBounds15571);
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation15572;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation._applyTransformation15572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._applyTransformation15572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AlphaAnimation15573;
		public AlphaAnimation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._AlphaAnimation15573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlphaAnimation15574;
		public AlphaAnimation(float arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._AlphaAnimation15574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AlphaAnimation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AlphaAnimation"));
			global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix15570 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.AlphaAnimation._willChangeBounds15571 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.AlphaAnimation._applyTransformation15572 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.AlphaAnimation._AlphaAnimation15573 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.AlphaAnimation._AlphaAnimation15574 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(FF)V");
		}
	}
}
