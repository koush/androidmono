namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.ClickableSpan_))]
	public abstract partial class ClickableSpan : android.text.style.CharacterStyle, UpdateAppearance
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClickableSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void onClick(android.view.View arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ClickableSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.ClickableSpan._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public ClickableSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ClickableSpan._m2.native == global::System.IntPtr.Zero)
				global::android.text.style.ClickableSpan._m2 = @__env.GetMethodIDNoThrow(global::android.text.style.ClickableSpan.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ClickableSpan.staticClass, global::android.text.style.ClickableSpan._m2);
			Init(@__env, handle);
		}
		static ClickableSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ClickableSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ClickableSpan"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.ClickableSpan))]
	internal sealed partial class ClickableSpan_ : android.text.style.ClickableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ClickableSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ClickableSpan_.staticClass, "onClick", "(Landroid/view/View;)V", ref global::android.text.style.ClickableSpan_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ClickableSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ClickableSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ClickableSpan"));
		}
	}
}
