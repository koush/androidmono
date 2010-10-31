namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClipboardManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClipboardManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.ClipboardManager.staticClass, "setText", "(Ljava/lang/CharSequence;)V", ref global::android.text.ClipboardManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new string Text
		{
			get
			{
				return getText().toString();
			}
			set
			{
				setText((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.CharSequence getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.ClipboardManager.staticClass, "getText", "()Ljava/lang/CharSequence;", ref global::android.text.ClipboardManager._m1) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool hasText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.ClipboardManager.staticClass, "hasText", "()Z", ref global::android.text.ClipboardManager._m2);
		}
		static ClipboardManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.ClipboardManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/ClipboardManager"));
		}
	}
}
