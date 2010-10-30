namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClipboardManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClipboardManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setText12721;
		public virtual void setText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.ClipboardManager.staticClass, global::android.text.ClipboardManager._setText12721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getText12722;
		public virtual global::java.lang.CharSequence getText()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.ClipboardManager.staticClass, global::android.text.ClipboardManager._getText12722)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _hasText12723;
		public virtual bool hasText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.ClipboardManager.staticClass, global::android.text.ClipboardManager._hasText12723);
		}
		static ClipboardManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.ClipboardManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/ClipboardManager"));
			global::android.text.ClipboardManager._setText12721 = @__env.GetMethodIDNoThrow(global::android.text.ClipboardManager.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.text.ClipboardManager._getText12722 = @__env.GetMethodIDNoThrow(global::android.text.ClipboardManager.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.text.ClipboardManager._hasText12723 = @__env.GetMethodIDNoThrow(global::android.text.ClipboardManager.staticClass, "hasText", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
