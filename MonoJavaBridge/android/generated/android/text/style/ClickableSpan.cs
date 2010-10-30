namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.ClickableSpan_))]
	public abstract partial class ClickableSpan : android.text.style.CharacterStyle, UpdateAppearance
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClickableSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick13464;
		public abstract void onClick(android.view.View arg0);
		internal static global::MonoJavaBridge.MethodId _updateDrawState13465;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ClickableSpan.staticClass, global::android.text.style.ClickableSpan._updateDrawState13465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ClickableSpan13466;
		public ClickableSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ClickableSpan.staticClass, global::android.text.style.ClickableSpan._ClickableSpan13466);
			Init(@__env, handle);
		}
		static ClickableSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ClickableSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ClickableSpan"));
			global::android.text.style.ClickableSpan._onClick13464 = @__env.GetMethodIDNoThrow(global::android.text.style.ClickableSpan.staticClass, "onClick", "(Landroid/view/View;)V");
			global::android.text.style.ClickableSpan._updateDrawState13465 = @__env.GetMethodIDNoThrow(global::android.text.style.ClickableSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ClickableSpan._ClickableSpan13466 = @__env.GetMethodIDNoThrow(global::android.text.style.ClickableSpan.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.ClickableSpan))]
	internal sealed partial class ClickableSpan_ : android.text.style.ClickableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ClickableSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick13467;
		public override void onClick(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.ClickableSpan_._onClick13467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ClickableSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ClickableSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ClickableSpan"));
			global::android.text.style.ClickableSpan_._onClick13467 = @__env.GetMethodIDNoThrow(global::android.text.style.ClickableSpan_.staticClass, "onClick", "(Landroid/view/View;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
