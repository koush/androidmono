namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RotateAnimation : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RotateAnimation()
		{
			InitJNI();
		}
		protected RotateAnimation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initialize15744;
		public override void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.RotateAnimation._initialize15744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._initialize15744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation15745;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.RotateAnimation._applyTransformation15745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._applyTransformation15745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RotateAnimation15746;
		public RotateAnimation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._RotateAnimation15746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RotateAnimation15747;
		public RotateAnimation(float arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._RotateAnimation15747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RotateAnimation15748;
		public RotateAnimation(float arg0, float arg1, float arg2, float arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._RotateAnimation15748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RotateAnimation15749;
		public RotateAnimation(float arg0, float arg1, int arg2, float arg3, int arg4, float arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.RotateAnimation.staticClass, global::android.view.animation.RotateAnimation._RotateAnimation15749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.RotateAnimation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/RotateAnimation"));
			global::android.view.animation.RotateAnimation._initialize15744 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.RotateAnimation._applyTransformation15745 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.RotateAnimation._RotateAnimation15746 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.RotateAnimation._RotateAnimation15747 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(FF)V");
			global::android.view.animation.RotateAnimation._RotateAnimation15748 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(FFFF)V");
			global::android.view.animation.RotateAnimation._RotateAnimation15749 = @__env.GetMethodIDNoThrow(global::android.view.animation.RotateAnimation.staticClass, "<init>", "(FFIFIF)V");
		}
	}
}
