namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputConnection_))]
	public interface InputConnection  : global::MonoJavaBridge.IJavaObject 
	{
		bool setSelection(int arg0, int arg1);
		bool beginBatchEdit();
		bool endBatchEdit();
		global::java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1);
		global::java.lang.CharSequence getTextAfterCursor(int arg0, int arg1);
		int getCursorCapsMode(int arg0);
		global::android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1);
		bool deleteSurroundingText(int arg0, int arg1);
		bool setComposingText(java.lang.CharSequence arg0, int arg1);
		bool finishComposingText();
		bool commitText(java.lang.CharSequence arg0, int arg1);
		bool commitCompletion(android.view.inputmethod.CompletionInfo arg0);
		bool performEditorAction(int arg0);
		bool performContextMenuAction(int arg0);
		bool sendKeyEvent(android.view.KeyEvent arg0);
		bool clearMetaKeyStates(int arg0);
		bool reportFullscreenMode(bool arg0);
		bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.inputmethod.InputConnection))]
	public sealed partial class InputConnection_ : java.lang.Object, InputConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputConnection_()
		{
			InitJNI();
		}
		internal InputConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSelection10706;
		 bool android.view.inputmethod.InputConnection.setSelection(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._setSelection10706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._setSelection10706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit10707;
		 bool android.view.inputmethod.InputConnection.beginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._beginBatchEdit10707);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._beginBatchEdit10707);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit10708;
		 bool android.view.inputmethod.InputConnection.endBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._endBatchEdit10708);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._endBatchEdit10708);
		}
		internal static global::MonoJavaBridge.MethodId _getTextBeforeCursor10709;
		 global::java.lang.CharSequence android.view.inputmethod.InputConnection.getTextBeforeCursor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._getTextBeforeCursor10709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._getTextBeforeCursor10709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getTextAfterCursor10710;
		 global::java.lang.CharSequence android.view.inputmethod.InputConnection.getTextAfterCursor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._getTextAfterCursor10710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._getTextAfterCursor10710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getCursorCapsMode10711;
		 int android.view.inputmethod.InputConnection.getCursorCapsMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._getCursorCapsMode10711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._getCursorCapsMode10711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExtractedText10712;
		 global::android.view.inputmethod.ExtractedText android.view.inputmethod.InputConnection.getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._getExtractedText10712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.inputmethod.ExtractedText;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._getExtractedText10712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.inputmethod.ExtractedText;
		}
		internal static global::MonoJavaBridge.MethodId _deleteSurroundingText10713;
		 bool android.view.inputmethod.InputConnection.deleteSurroundingText(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._deleteSurroundingText10713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._deleteSurroundingText10713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setComposingText10714;
		 bool android.view.inputmethod.InputConnection.setComposingText(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._setComposingText10714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._setComposingText10714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _finishComposingText10715;
		 bool android.view.inputmethod.InputConnection.finishComposingText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._finishComposingText10715);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._finishComposingText10715);
		}
		internal static global::MonoJavaBridge.MethodId _commitText10716;
		 bool android.view.inputmethod.InputConnection.commitText(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._commitText10716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._commitText10716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _commitCompletion10717;
		 bool android.view.inputmethod.InputConnection.commitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._commitCompletion10717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._commitCompletion10717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performEditorAction10718;
		 bool android.view.inputmethod.InputConnection.performEditorAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._performEditorAction10718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._performEditorAction10718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuAction10719;
		 bool android.view.inputmethod.InputConnection.performContextMenuAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._performContextMenuAction10719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._performContextMenuAction10719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyEvent10720;
		 bool android.view.inputmethod.InputConnection.sendKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._sendKeyEvent10720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._sendKeyEvent10720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyStates10721;
		 bool android.view.inputmethod.InputConnection.clearMetaKeyStates(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._clearMetaKeyStates10721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._clearMetaKeyStates10721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reportFullscreenMode10722;
		 bool android.view.inputmethod.InputConnection.reportFullscreenMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._reportFullscreenMode10722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._reportFullscreenMode10722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performPrivateCommand10723;
		 bool android.view.inputmethod.InputConnection.performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._performPrivateCommand10723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._performPrivateCommand10723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputConnection"));
			global::android.view.inputmethod.InputConnection_._setSelection10706 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "setSelection", "(II)Z");
			global::android.view.inputmethod.InputConnection_._beginBatchEdit10707 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "beginBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnection_._endBatchEdit10708 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "endBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnection_._getTextBeforeCursor10709 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnection_._getTextAfterCursor10710 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnection_._getCursorCapsMode10711 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "getCursorCapsMode", "(I)I");
			global::android.view.inputmethod.InputConnection_._getExtractedText10712 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;");
			global::android.view.inputmethod.InputConnection_._deleteSurroundingText10713 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "deleteSurroundingText", "(II)Z");
			global::android.view.inputmethod.InputConnection_._setComposingText10714 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnection_._finishComposingText10715 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "finishComposingText", "()Z");
			global::android.view.inputmethod.InputConnection_._commitText10716 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnection_._commitCompletion10717 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z");
			global::android.view.inputmethod.InputConnection_._performEditorAction10718 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "performEditorAction", "(I)Z");
			global::android.view.inputmethod.InputConnection_._performContextMenuAction10719 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "performContextMenuAction", "(I)Z");
			global::android.view.inputmethod.InputConnection_._sendKeyEvent10720 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.inputmethod.InputConnection_._clearMetaKeyStates10721 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "clearMetaKeyStates", "(I)Z");
			global::android.view.inputmethod.InputConnection_._reportFullscreenMode10722 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "reportFullscreenMode", "(Z)Z");
			global::android.view.inputmethod.InputConnection_._performPrivateCommand10723 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
		}
	}
}
