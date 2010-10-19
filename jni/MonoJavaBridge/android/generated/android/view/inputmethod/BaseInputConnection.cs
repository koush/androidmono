namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BaseInputConnection : java.lang.Object, InputConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseInputConnection()
		{
			InitJNI();
		}
		protected BaseInputConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSelection10624;
		public virtual bool setSelection(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._setSelection10624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._setSelection10624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit10625;
		public virtual bool beginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._beginBatchEdit10625);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._beginBatchEdit10625);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit10626;
		public virtual bool endBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._endBatchEdit10626);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._endBatchEdit10626);
		}
		internal static global::MonoJavaBridge.MethodId _getTextBeforeCursor10627;
		public virtual global::java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._getTextBeforeCursor10627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getTextBeforeCursor10627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getTextAfterCursor10628;
		public virtual global::java.lang.CharSequence getTextAfterCursor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._getTextAfterCursor10628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getTextAfterCursor10628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getCursorCapsMode10629;
		public virtual int getCursorCapsMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._getCursorCapsMode10629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getCursorCapsMode10629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExtractedText10630;
		public virtual global::android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._getExtractedText10630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.inputmethod.ExtractedText;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getExtractedText10630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.inputmethod.ExtractedText;
		}
		internal static global::MonoJavaBridge.MethodId _deleteSurroundingText10631;
		public virtual bool deleteSurroundingText(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._deleteSurroundingText10631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._deleteSurroundingText10631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setComposingText10632;
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._setComposingText10632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._setComposingText10632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool setComposingText(string arg0, int arg1)
		{
			return setComposingText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _finishComposingText10633;
		public virtual bool finishComposingText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._finishComposingText10633);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._finishComposingText10633);
		}
		internal static global::MonoJavaBridge.MethodId _commitText10634;
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._commitText10634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._commitText10634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool commitText(string arg0, int arg1)
		{
			return commitText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _commitCompletion10635;
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._commitCompletion10635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._commitCompletion10635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performEditorAction10636;
		public virtual bool performEditorAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._performEditorAction10636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._performEditorAction10636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuAction10637;
		public virtual bool performContextMenuAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._performContextMenuAction10637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._performContextMenuAction10637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyEvent10638;
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._sendKeyEvent10638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._sendKeyEvent10638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyStates10639;
		public virtual bool clearMetaKeyStates(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._clearMetaKeyStates10639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._clearMetaKeyStates10639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reportFullscreenMode10640;
		public virtual bool reportFullscreenMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._reportFullscreenMode10640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._reportFullscreenMode10640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performPrivateCommand10641;
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._performPrivateCommand10641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._performPrivateCommand10641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeComposingSpans10642;
		public static void removeComposingSpans(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._removeComposingSpans10642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComposingSpans10643;
		public static void setComposingSpans(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._setComposingSpans10643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getComposingSpanStart10644;
		public static int getComposingSpanStart(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getComposingSpanStart10644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getComposingSpanEnd10645;
		public static int getComposingSpanEnd(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getComposingSpanEnd10645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.Editable Editable
		{
			get
			{
				return getEditable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditable10646;
		public virtual global::android.text.Editable getEditable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection._getEditable10646)) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getEditable10646)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _BaseInputConnection10647;
		public BaseInputConnection(android.view.View arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._BaseInputConnection10647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.BaseInputConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/BaseInputConnection"));
			global::android.view.inputmethod.BaseInputConnection._setSelection10624 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "setSelection", "(II)Z");
			global::android.view.inputmethod.BaseInputConnection._beginBatchEdit10625 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "beginBatchEdit", "()Z");
			global::android.view.inputmethod.BaseInputConnection._endBatchEdit10626 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "endBatchEdit", "()Z");
			global::android.view.inputmethod.BaseInputConnection._getTextBeforeCursor10627 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.BaseInputConnection._getTextAfterCursor10628 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.BaseInputConnection._getCursorCapsMode10629 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getCursorCapsMode", "(I)I");
			global::android.view.inputmethod.BaseInputConnection._getExtractedText10630 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;");
			global::android.view.inputmethod.BaseInputConnection._deleteSurroundingText10631 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "deleteSurroundingText", "(II)Z");
			global::android.view.inputmethod.BaseInputConnection._setComposingText10632 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.BaseInputConnection._finishComposingText10633 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "finishComposingText", "()Z");
			global::android.view.inputmethod.BaseInputConnection._commitText10634 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.BaseInputConnection._commitCompletion10635 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z");
			global::android.view.inputmethod.BaseInputConnection._performEditorAction10636 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "performEditorAction", "(I)Z");
			global::android.view.inputmethod.BaseInputConnection._performContextMenuAction10637 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "performContextMenuAction", "(I)Z");
			global::android.view.inputmethod.BaseInputConnection._sendKeyEvent10638 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.inputmethod.BaseInputConnection._clearMetaKeyStates10639 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "clearMetaKeyStates", "(I)Z");
			global::android.view.inputmethod.BaseInputConnection._reportFullscreenMode10640 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "reportFullscreenMode", "(Z)Z");
			global::android.view.inputmethod.BaseInputConnection._performPrivateCommand10641 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.view.inputmethod.BaseInputConnection._removeComposingSpans10642 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "removeComposingSpans", "(Landroid/text/Spannable;)V");
			global::android.view.inputmethod.BaseInputConnection._setComposingSpans10643 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingSpans", "(Landroid/text/Spannable;)V");
			global::android.view.inputmethod.BaseInputConnection._getComposingSpanStart10644 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanStart", "(Landroid/text/Spannable;)I");
			global::android.view.inputmethod.BaseInputConnection._getComposingSpanEnd10645 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanEnd", "(Landroid/text/Spannable;)I");
			global::android.view.inputmethod.BaseInputConnection._getEditable10646 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getEditable", "()Landroid/text/Editable;");
			global::android.view.inputmethod.BaseInputConnection._BaseInputConnection10647 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "<init>", "(Landroid/view/View;Z)V");
		}
	}
}
