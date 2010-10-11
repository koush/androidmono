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
		internal static global::MonoJavaBridge.MethodId _hasFocus4450;
		public override bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._hasFocus4450);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasFocus4450);
		}
		internal static global::MonoJavaBridge.MethodId _hasWindowFocus4451;
		public override bool hasWindowFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._hasWindowFocus4451);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasWindowFocus4451);
		}
		internal static global::MonoJavaBridge.MethodId _performClick4452;
		public override bool performClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._performClick4452);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._performClick4452);
		}
		internal static global::MonoJavaBridge.MethodId _isFocused4453;
		public override bool isFocused() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._isFocused4453);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isFocused4453);
		}
		internal static global::MonoJavaBridge.MethodId _setExtractedText4454;
		public override void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._setExtractedText4454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._setExtractedText4454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSelectionChanged4455;
		protected override void onSelectionChanged(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._onSelectionChanged4455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onSelectionChanged4455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isInputMethodTarget4456;
		public override bool isInputMethodTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._isInputMethodTarget4456);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isInputMethodTarget4456);
		}
		internal static global::MonoJavaBridge.MethodId _onTextContextMenuItem4457;
		public override bool onTextContextMenuItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem4457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem4457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInternalChanges4458;
		public virtual void startInternalChanges() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._startInternalChanges4458);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._startInternalChanges4458);
		}
		internal static global::MonoJavaBridge.MethodId _finishInternalChanges4459;
		public virtual void finishInternalChanges() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._finishInternalChanges4459);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._finishInternalChanges4459);
		}
		internal static global::MonoJavaBridge.MethodId _hasVerticalScrollBar4460;
		public virtual bool hasVerticalScrollBar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar4460);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar4460);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractEditText4461;
		public ExtractEditText(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText4461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractEditText4462;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText4462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExtractEditText4463;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText4463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.inputmethodservice.ExtractEditText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/inputmethodservice/ExtractEditText"));
			global::android.inputmethodservice.ExtractEditText._hasFocus4450 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "hasFocus", "()Z");
			global::android.inputmethodservice.ExtractEditText._hasWindowFocus4451 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "hasWindowFocus", "()Z");
			global::android.inputmethodservice.ExtractEditText._performClick4452 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "performClick", "()Z");
			global::android.inputmethodservice.ExtractEditText._isFocused4453 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "isFocused", "()Z");
			global::android.inputmethodservice.ExtractEditText._setExtractedText4454 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V");
			global::android.inputmethodservice.ExtractEditText._onSelectionChanged4455 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "onSelectionChanged", "(II)V");
			global::android.inputmethodservice.ExtractEditText._isInputMethodTarget4456 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "isInputMethodTarget", "()Z");
			global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem4457 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "onTextContextMenuItem", "(I)Z");
			global::android.inputmethodservice.ExtractEditText._startInternalChanges4458 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "startInternalChanges", "()V");
			global::android.inputmethodservice.ExtractEditText._finishInternalChanges4459 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "finishInternalChanges", "()V");
			global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar4460 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "hasVerticalScrollBar", "()Z");
			global::android.inputmethodservice.ExtractEditText._ExtractEditText4461 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.inputmethodservice.ExtractEditText._ExtractEditText4462 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.inputmethodservice.ExtractEditText._ExtractEditText4463 = @__env.GetMethodIDNoThrow(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
