namespace android.inputmethodservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExtractEditText : android.widget.EditText
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExtractEditText()
		{
			InitJNI();
		}
		protected ExtractEditText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus6558;
		public override bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._hasFocus6558);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasFocus6558);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus6559;
		public override bool hasWindowFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._hasWindowFocus6559);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasWindowFocus6559);
		}
		internal static global::MonoJavaBridge.MethodId _performClick6560;
		public override bool performClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._performClick6560);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._performClick6560);
		}
		internal static global::MonoJavaBridge.MethodId _isFocused6561;
		public override bool isFocused() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._isFocused6561);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isFocused6561);
		}
		internal static global::MonoJavaBridge.MethodId _setExtractedText6562;
		public override void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._setExtractedText6562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._setExtractedText6562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSelectionChanged6563;
		protected override void onSelectionChanged(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._onSelectionChanged6563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onSelectionChanged6563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isInputMethodTarget6564;
		public override bool isInputMethodTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._isInputMethodTarget6564);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isInputMethodTarget6564);
		}
		internal static global::MonoJavaBridge.MethodId _onTextContextMenuItem6565;
		public override bool onTextContextMenuItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem6565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem6565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInternalChanges6566;
		public virtual void startInternalChanges() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._startInternalChanges6566);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._startInternalChanges6566);
		}
		internal static global::MonoJavaBridge.MethodId _finishInternalChanges6567;
		public virtual void finishInternalChanges() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._finishInternalChanges6567);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._finishInternalChanges6567);
		}
		internal static global::MonoJavaBridge.MethodId _hasVerticalScrollBar6568;
		public virtual bool hasVerticalScrollBar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar6568);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar6568);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractEditText6569;
		public ExtractEditText(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText6569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractEditText6570;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText6570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractEditText6571;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText6571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.ExtractEditText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/ExtractEditText"));
			global::android.inputmethodservice.ExtractEditText._hasFocus6558 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "hasFocus", "()Z");
			global::android.inputmethodservice.ExtractEditText._hasWindowFocus6559 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "hasWindowFocus", "()Z");
			global::android.inputmethodservice.ExtractEditText._performClick6560 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "performClick", "()Z");
			global::android.inputmethodservice.ExtractEditText._isFocused6561 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "isFocused", "()Z");
			global::android.inputmethodservice.ExtractEditText._setExtractedText6562 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V");
			global::android.inputmethodservice.ExtractEditText._onSelectionChanged6563 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "onSelectionChanged", "(II)V");
			global::android.inputmethodservice.ExtractEditText._isInputMethodTarget6564 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "isInputMethodTarget", "()Z");
			global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem6565 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "onTextContextMenuItem", "(I)Z");
			global::android.inputmethodservice.ExtractEditText._startInternalChanges6566 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "startInternalChanges", "()V");
			global::android.inputmethodservice.ExtractEditText._finishInternalChanges6567 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "finishInternalChanges", "()V");
			global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar6568 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "hasVerticalScrollBar", "()Z");
			global::android.inputmethodservice.ExtractEditText._ExtractEditText6569 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.inputmethodservice.ExtractEditText._ExtractEditText6570 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.inputmethodservice.ExtractEditText._ExtractEditText6571 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
