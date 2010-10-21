namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClipboardManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClipboardManager()
		{
			InitJNI();
		}
		protected ClipboardManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setText12663;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.ClipboardManager._setText12663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.ClipboardManager.staticClass, global::android.text.ClipboardManager._setText12663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getText12664;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.ClipboardManager._getText12664)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.ClipboardManager.staticClass, global::android.text.ClipboardManager._getText12664)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _hasText12665;
		public virtual bool hasText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.ClipboardManager._hasText12665);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.ClipboardManager.staticClass, global::android.text.ClipboardManager._hasText12665);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.ClipboardManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/ClipboardManager"));
			global::android.text.ClipboardManager._setText12663 = @__env.GetMethodIDNoThrow(global::android.text.ClipboardManager.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.text.ClipboardManager._getText12664 = @__env.GetMethodIDNoThrow(global::android.text.ClipboardManager.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.text.ClipboardManager._hasText12665 = @__env.GetMethodIDNoThrow(global::android.text.ClipboardManager.staticClass, "hasText", "()Z");
		}
	}
}
