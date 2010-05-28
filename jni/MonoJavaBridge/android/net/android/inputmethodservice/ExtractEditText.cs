namespace android.inputmethodservice 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ExtractEditText : android.widget.EditText
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ExtractEditText() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.inputmethodservice.ExtractEditText), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus3996; 
		public override bool hasFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._hasFocus3996); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasFocus3996); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasWindowFocus3997; 
		public override bool hasWindowFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._hasWindowFocus3997); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasWindowFocus3997); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performClick3998; 
		public override bool performClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._performClick3998); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._performClick3998); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFocused3999; 
		public override bool isFocused() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._isFocused3999); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isFocused3999); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtractedText4000; 
		public override void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText._setExtractedText4000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._setExtractedText4000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSelectionChanged4001; 
		protected override void onSelectionChanged(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText._onSelectionChanged4001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onSelectionChanged4001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputMethodTarget4002; 
		public override bool isInputMethodTarget() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._isInputMethodTarget4002); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isInputMethodTarget4002); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextContextMenuItem4003; 
		public override bool onTextContextMenuItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem4003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem4003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startInternalChanges4004; 
		public virtual void startInternalChanges() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText._startInternalChanges4004); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._startInternalChanges4004); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishInternalChanges4005; 
		public virtual void finishInternalChanges() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				@__env.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText._finishInternalChanges4005); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._finishInternalChanges4005); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasVerticalScrollBar4006; 
		public virtual bool hasVerticalScrollBar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.inputmethodservice.ExtractEditText)) 
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar4006); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar4006); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExtractEditText4007; 
		public ExtractEditText(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText4007, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExtractEditText4008; 
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText4008, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExtractEditText4009; 
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText4009, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.inputmethodservice.ExtractEditText.staticClass = @__class; 
			global::android.inputmethodservice.ExtractEditText._hasFocus3996 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "hasFocus", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._hasWindowFocus3997 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "hasWindowFocus", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._performClick3998 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "performClick", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._isFocused3999 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "isFocused", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._setExtractedText4000 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V"); 
			global::android.inputmethodservice.ExtractEditText._onSelectionChanged4001 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "onSelectionChanged", "(II)V"); 
			global::android.inputmethodservice.ExtractEditText._isInputMethodTarget4002 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "isInputMethodTarget", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem4003 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "onTextContextMenuItem", "(I)Z"); 
			global::android.inputmethodservice.ExtractEditText._startInternalChanges4004 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "startInternalChanges", "()V"); 
			global::android.inputmethodservice.ExtractEditText._finishInternalChanges4005 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "finishInternalChanges", "()V"); 
			global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar4006 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "hasVerticalScrollBar", "()Z"); 
			global::android.inputmethodservice.ExtractEditText._ExtractEditText4007 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.inputmethodservice.ExtractEditText._ExtractEditText4008 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.inputmethodservice.ExtractEditText._ExtractEditText4009 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
