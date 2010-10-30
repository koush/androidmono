namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExtractEditText : android.widget.EditText
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExtractEditText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus6583;
		public override bool hasFocus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._hasFocus6583.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._hasFocus6583 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "hasFocus", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasFocus6583);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus6584;
		public override bool hasWindowFocus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._hasWindowFocus6584.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._hasWindowFocus6584 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "hasWindowFocus", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasWindowFocus6584);
		}
		internal static global::MonoJavaBridge.MethodId _performClick6585;
		public override bool performClick()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._performClick6585.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._performClick6585 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "performClick", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._performClick6585);
		}
		internal static global::MonoJavaBridge.MethodId _isFocused6586;
		public override bool isFocused()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._isFocused6586.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._isFocused6586 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "isFocused", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isFocused6586);
		}
		public new global::android.view.inputmethod.ExtractedText ExtractedText
		{
			set
			{
				setExtractedText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setExtractedText6587;
		public override void setExtractedText(android.view.inputmethod.ExtractedText arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._setExtractedText6587.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._setExtractedText6587 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._setExtractedText6587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSelectionChanged6588;
		protected override void onSelectionChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._onSelectionChanged6588.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._onSelectionChanged6588 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "onSelectionChanged", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onSelectionChanged6588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isInputMethodTarget6589;
		public override bool isInputMethodTarget()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._isInputMethodTarget6589.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._isInputMethodTarget6589 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "isInputMethodTarget", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isInputMethodTarget6589);
		}
		internal static global::MonoJavaBridge.MethodId _onTextContextMenuItem6590;
		public override bool onTextContextMenuItem(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem6590.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem6590 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "onTextContextMenuItem", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem6590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInternalChanges6591;
		public virtual void startInternalChanges()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._startInternalChanges6591.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._startInternalChanges6591 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "startInternalChanges", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._startInternalChanges6591);
		}
		internal static global::MonoJavaBridge.MethodId _finishInternalChanges6592;
		public virtual void finishInternalChanges()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._finishInternalChanges6592.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._finishInternalChanges6592 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "finishInternalChanges", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._finishInternalChanges6592);
		}
		internal static global::MonoJavaBridge.MethodId _hasVerticalScrollBar6593;
		public virtual bool hasVerticalScrollBar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar6593.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar6593 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "hasVerticalScrollBar", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar6593);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractEditText6594;
		public ExtractEditText(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._ExtractEditText6594.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._ExtractEditText6594 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText6594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractEditText6595;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._ExtractEditText6595.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._ExtractEditText6595 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText6595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractEditText6596;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.inputmethodservice.ExtractEditText._ExtractEditText6596.native == global::System.IntPtr.Zero)
				global::android.inputmethodservice.ExtractEditText._ExtractEditText6596 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText6596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
