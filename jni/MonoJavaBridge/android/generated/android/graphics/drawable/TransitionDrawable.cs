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
		internal static global::MonoJavaBridge.MethodId _draw6214;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._draw6214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._draw6214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startTransition6215;
		public virtual void startTransition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._startTransition6215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._startTransition6215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetTransition6216;
		public virtual void resetTransition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._resetTransition6216);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._resetTransition6216);
		}
		internal static global::MonoJavaBridge.MethodId _reverseTransition6217;
		public virtual void reverseTransition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._reverseTransition6217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._reverseTransition6217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCrossFadeEnabled6218;
		public virtual void setCrossFadeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled6218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled6218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCrossFadeEnabled6219;
		public virtual bool isCrossFadeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled6219);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled6219);
		}
		internal static global::MonoJavaBridge.MethodId _TransitionDrawable6220;
		public TransitionDrawable(android.graphics.drawable.Drawable[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._TransitionDrawable6220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.TransitionDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/TransitionDrawable"));
			global::android.graphics.drawable.TransitionDrawable._draw6214 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.TransitionDrawable._startTransition6215 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "startTransition", "(I)V");
			global::android.graphics.drawable.TransitionDrawable._resetTransition6216 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "resetTransition", "()V");
			global::android.graphics.drawable.TransitionDrawable._reverseTransition6217 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "reverseTransition", "(I)V");
			global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled6218 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "setCrossFadeEnabled", "(Z)V");
			global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled6219 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "isCrossFadeEnabled", "()Z");
			global::android.graphics.drawable.TransitionDrawable._TransitionDrawable6220 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "<init>", "([Landroid/graphics/drawable/Drawable;)V");
		}
	}
}
