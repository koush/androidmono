namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransitionDrawable : android.graphics.drawable.LayerDrawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TransitionDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.TransitionDrawable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void startTransition(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, "startTransition", "(I)V", ref global::android.graphics.drawable.TransitionDrawable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void resetTransition()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, "resetTransition", "()V", ref global::android.graphics.drawable.TransitionDrawable._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void reverseTransition(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, "reverseTransition", "(I)V", ref global::android.graphics.drawable.TransitionDrawable._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CrossFadeEnabled
		{
			set
			{
				setCrossFadeEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setCrossFadeEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, "setCrossFadeEnabled", "(Z)V", ref global::android.graphics.drawable.TransitionDrawable._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isCrossFadeEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, "isCrossFadeEnabled", "()Z", ref global::android.graphics.drawable.TransitionDrawable._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public TransitionDrawable(android.graphics.drawable.Drawable[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.TransitionDrawable._m6.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.TransitionDrawable._m6 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.TransitionDrawable.staticClass, "<init>", "([Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TransitionDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.TransitionDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/TransitionDrawable"));
		}
	}
}
