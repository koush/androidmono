namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExtractEditText : android.widget.EditText
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExtractEditText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool hasFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "hasFocus", "()Z", ref global::android.inputmethodservice.ExtractEditText._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool hasWindowFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "hasWindowFocus", "()Z", ref global::android.inputmethodservice.ExtractEditText._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool performClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "performClick", "()Z", ref global::android.inputmethodservice.ExtractEditText._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isFocused()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "isFocused", "()Z", ref global::android.inputmethodservice.ExtractEditText._m3);
		}
		public new global::android.view.inputmethod.ExtractedText ExtractedText
		{
			set
			{
				setExtractedText(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setExtractedText(android.view.inputmethod.ExtractedText arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V", ref global::android.inputmethodservice.ExtractEditText._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onSelectionChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "onSelectionChanged", "(II)V", ref global::android.inputmethodservice.ExtractEditText._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool isInputMethodTarget()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "isInputMethodTarget", "()Z", ref global::android.inputmethodservice.ExtractEditText._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool onTextContextMenuItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "onTextContextMenuItem", "(I)Z", ref global::android.inputmethodservice.ExtractEditText._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void startInternalChanges()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "startInternalChanges", "()V", ref global::android.inputmethodservice.ExtractEditText._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void finishInternalChanges()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "finishInternalChanges", "()V", ref global::android.inputmethodservice.ExtractEditText._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool hasVerticalScrollBar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, "hasVerticalScrollBar", "()Z", ref global::android.inputmethodservice.ExtractEditText._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public ExtractEditText(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._m11.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._m11 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._m12.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._m12 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._m13.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._m13 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ExtractEditText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.ExtractEditText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/ExtractEditText"));
		}
		internal static void InitJNI()
		{
		}
	}
}
