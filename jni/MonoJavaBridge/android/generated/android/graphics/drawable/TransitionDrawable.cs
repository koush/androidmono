namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransitionDrawable : android.graphics.drawable.LayerDrawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TransitionDrawable()
		{
			InitJNI();
		}
		protected TransitionDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw4220;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._draw4220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._draw4220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startTransition4221;
		public virtual void startTransition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._startTransition4221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._startTransition4221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetTransition4222;
		public virtual void resetTransition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._resetTransition4222);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._resetTransition4222);
		}
		internal static global::MonoJavaBridge.MethodId _reverseTransition4223;
		public virtual void reverseTransition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._reverseTransition4223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._reverseTransition4223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCrossFadeEnabled4224;
		public virtual void setCrossFadeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled4224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled4224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCrossFadeEnabled4225;
		public virtual bool isCrossFadeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled4225);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled4225);
		}
		internal static global::MonoJavaBridge.MethodId _TransitionDrawable4226;
		public TransitionDrawable(android.graphics.drawable.Drawable[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._TransitionDrawable4226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.TransitionDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/TransitionDrawable"));
			global::android.graphics.drawable.TransitionDrawable._draw4220 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.TransitionDrawable._startTransition4221 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "startTransition", "(I)V");
			global::android.graphics.drawable.TransitionDrawable._resetTransition4222 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "resetTransition", "()V");
			global::android.graphics.drawable.TransitionDrawable._reverseTransition4223 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "reverseTransition", "(I)V");
			global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled4224 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "setCrossFadeEnabled", "(Z)V");
			global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled4225 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "isCrossFadeEnabled", "()Z");
			global::android.graphics.drawable.TransitionDrawable._TransitionDrawable4226 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "<init>", "([Landroid/graphics/drawable/Drawable;)V");
		}
	}
}
