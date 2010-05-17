namespace android.inputmethodservice 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ExtractEditText : android.widget.EditText
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ExtractEditText() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.inputmethodservice.ExtractEditText), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.inputmethodservice.ExtractEditText(@__env); 
			} 
		} 
		protected ExtractEditText(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus3781; 
		public override bool hasFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, _hasFocus3781); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _hasFocus3781); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasWindowFocus3782; 
		public override bool hasWindowFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, _hasWindowFocus3782); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _hasWindowFocus3782); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performClick3783; 
		public override bool performClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, _performClick3783); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _performClick3783); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocused3784; 
		public override bool isFocused() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, _isFocused3784); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _isFocused3784); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtractedText3785; 
		public override void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				@__env.CallVoidMethod(this, _setExtractedText3785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _setExtractedText3785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSelectionChanged3786; 
		protected override void onSelectionChanged(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				@__env.CallVoidMethod(this, _onSelectionChanged3786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _onSelectionChanged3786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputMethodTarget3787; 
		public override bool isInputMethodTarget() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, _isInputMethodTarget3787); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _isInputMethodTarget3787); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextContextMenuItem3788; 
		public override bool onTextContextMenuItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, _onTextContextMenuItem3788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _onTextContextMenuItem3788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startInternalChanges3789; 
		public virtual void startInternalChanges() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				@__env.CallVoidMethod(this, _startInternalChanges3789); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _startInternalChanges3789); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishInternalChanges3790; 
		public virtual void finishInternalChanges() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				@__env.CallVoidMethod(this, _finishInternalChanges3790); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _finishInternalChanges3790); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasVerticalScrollBar3791; 
		public virtual bool hasVerticalScrollBar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, _hasVerticalScrollBar3791); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.inputmethodservice.ExtractEditText.staticClass, _hasVerticalScrollBar3791); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExtractEditText3792; 
		public ExtractEditText(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, _ExtractEditText3792, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExtractEditText3793; 
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, _ExtractEditText3793, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExtractEditText3794; 
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, _ExtractEditText3794, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.inputmethodservice.ExtractEditText.staticClass = @__class; 
			global::android.inputmethodservice.ExtractEditText._hasFocus3781 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "hasFocus", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._hasWindowFocus3782 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "hasWindowFocus", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._performClick3783 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "performClick", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._isFocused3784 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "isFocused", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._setExtractedText3785 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V"); 
			global::android.inputmethodservice.ExtractEditText._onSelectionChanged3786 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "onSelectionChanged", "(II)V"); 
			global::android.inputmethodservice.ExtractEditText._isInputMethodTarget3787 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "isInputMethodTarget", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem3788 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "onTextContextMenuItem", "(I)Z"); 
			global::android.inputmethodservice.ExtractEditText._startInternalChanges3789 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "startInternalChanges", "()V"); 
			global::android.inputmethodservice.ExtractEditText._finishInternalChanges3790 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "finishInternalChanges", "()V"); 
			global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar3791 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "hasVerticalScrollBar", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._ExtractEditText3792 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.inputmethodservice.ExtractEditText._ExtractEditText3793 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.inputmethodservice.ExtractEditText._ExtractEditText3794 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
