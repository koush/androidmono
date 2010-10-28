namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransitionDrawable : android.graphics.drawable.LayerDrawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TransitionDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw6233;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._draw6233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._draw6233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startTransition6234;
		public virtual void startTransition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._startTransition6234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._startTransition6234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetTransition6235;
		public virtual void resetTransition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._resetTransition6235);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._resetTransition6235);
		}
		internal static global::MonoJavaBridge.MethodId _reverseTransition6236;
		public virtual void reverseTransition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._reverseTransition6236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._reverseTransition6236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CrossFadeEnabled
		{
			set
			{
				setCrossFadeEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCrossFadeEnabled6237;
		public virtual void setCrossFadeEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled6237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled6237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCrossFadeEnabled6238;
		public virtual bool isCrossFadeEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled6238);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled6238);
		}
		internal static global::MonoJavaBridge.MethodId _TransitionDrawable6239;
		public TransitionDrawable(android.graphics.drawable.Drawable[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._TransitionDrawable6239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TransitionDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.TransitionDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/TransitionDrawable"));
			global::android.graphics.drawable.TransitionDrawable._draw6233 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.TransitionDrawable._startTransition6234 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "startTransition", "(I)V");
			global::android.graphics.drawable.TransitionDrawable._resetTransition6235 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "resetTransition", "()V");
			global::android.graphics.drawable.TransitionDrawable._reverseTransition6236 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "reverseTransition", "(I)V");
			global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled6237 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "setCrossFadeEnabled", "(Z)V");
			global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled6238 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "isCrossFadeEnabled", "()Z");
			global::android.graphics.drawable.TransitionDrawable._TransitionDrawable6239 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "<init>", "([Landroid/graphics/drawable/Drawable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
