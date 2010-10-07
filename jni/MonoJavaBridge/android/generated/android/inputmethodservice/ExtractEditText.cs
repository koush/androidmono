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
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus4228;
		public override bool hasFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._hasFocus4228);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasFocus4228);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasWindowFocus4229;
		public override bool hasWindowFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._hasWindowFocus4229);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasWindowFocus4229);
		}
		internal static global::net.sf.jni4net.jni.MethodId _performClick4230;
		public override bool performClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._performClick4230);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._performClick4230);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFocused4231;
		public override bool isFocused() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._isFocused4231);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isFocused4231);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setExtractedText4232;
		public override void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText._setExtractedText4232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._setExtractedText4232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSelectionChanged4233;
		protected override void onSelectionChanged(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText._onSelectionChanged4233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onSelectionChanged4233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInputMethodTarget4234;
		public override bool isInputMethodTarget() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._isInputMethodTarget4234);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._isInputMethodTarget4234);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTextContextMenuItem4235;
		public override bool onTextContextMenuItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem4235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem4235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startInternalChanges4236;
		public virtual void startInternalChanges() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText._startInternalChanges4236);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._startInternalChanges4236);
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishInternalChanges4237;
		public virtual void finishInternalChanges() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.inputmethodservice.ExtractEditText._finishInternalChanges4237);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._finishInternalChanges4237);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasVerticalScrollBar4238;
		public virtual bool hasVerticalScrollBar() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar4238);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar4238);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExtractEditText4239;
		public ExtractEditText(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText4239, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExtractEditText4240;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText4240, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExtractEditText4241;
		public ExtractEditText(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.inputmethodservice.ExtractEditText.staticClass, global::android.inputmethodservice.ExtractEditText._ExtractEditText4241, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.inputmethodservice.ExtractEditText.staticClass = @__class;
			global::android.inputmethodservice.ExtractEditText._hasFocus4228 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "hasFocus", "()Z");
			global::android.inputmethodservice.ExtractEditText._hasWindowFocus4229 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "hasWindowFocus", "()Z");
			global::android.inputmethodservice.ExtractEditText._performClick4230 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "performClick", "()Z");
			global::android.inputmethodservice.ExtractEditText._isFocused4231 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "isFocused", "()Z");
			global::android.inputmethodservice.ExtractEditText._setExtractedText4232 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V");
			global::android.inputmethodservice.ExtractEditText._onSelectionChanged4233 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "onSelectionChanged", "(II)V");
			global::android.inputmethodservice.ExtractEditText._isInputMethodTarget4234 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "isInputMethodTarget", "()Z");
			global::android.inputmethodservice.ExtractEditText._onTextContextMenuItem4235 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "onTextContextMenuItem", "(I)Z");
			global::android.inputmethodservice.ExtractEditText._startInternalChanges4236 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "startInternalChanges", "()V");
			global::android.inputmethodservice.ExtractEditText._finishInternalChanges4237 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "finishInternalChanges", "()V");
			global::android.inputmethodservice.ExtractEditText._hasVerticalScrollBar4238 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "hasVerticalScrollBar", "()Z");
			global::android.inputmethodservice.ExtractEditText._ExtractEditText4239 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.inputmethodservice.ExtractEditText._ExtractEditText4240 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.inputmethodservice.ExtractEditText._ExtractEditText4241 = @__env.GetMethodID(global::android.inputmethodservice.ExtractEditText.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
