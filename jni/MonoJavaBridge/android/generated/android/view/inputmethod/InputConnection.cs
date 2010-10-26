namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.inputmethod.InputConnection_))]
	public partial interface InputConnection  : global::MonoJavaBridge.IJavaObject 
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
	internal sealed partial class InputConnection_ : java.lang.Object, InputConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputConnection_()
		{
			InitJNI();
		}
		internal InputConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSelection15872;
		 bool android.view.inputmethod.InputConnection.setSelection(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._setSelection15872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._setSelection15872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit15873;
		 bool android.view.inputmethod.InputConnection.beginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._beginBatchEdit15873);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._beginBatchEdit15873);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit15874;
		 bool android.view.inputmethod.InputConnection.endBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._endBatchEdit15874);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._endBatchEdit15874);
		}
		internal static global::MonoJavaBridge.MethodId _getTextBeforeCursor15875;
		 global::java.lang.CharSequence android.view.inputmethod.InputConnection.getTextBeforeCursor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._getTextBeforeCursor15875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._getTextBeforeCursor15875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getTextAfterCursor15876;
		 global::java.lang.CharSequence android.view.inputmethod.InputConnection.getTextAfterCursor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._getTextAfterCursor15876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._getTextAfterCursor15876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getCursorCapsMode15877;
		 int android.view.inputmethod.InputConnection.getCursorCapsMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._getCursorCapsMode15877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._getCursorCapsMode15877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExtractedText15878;
		 global::android.view.inputmethod.ExtractedText android.view.inputmethod.InputConnection.getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._getExtractedText15878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.inputmethod.ExtractedText;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._getExtractedText15878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.inputmethod.ExtractedText;
		}
		internal static global::MonoJavaBridge.MethodId _deleteSurroundingText15879;
		 bool android.view.inputmethod.InputConnection.deleteSurroundingText(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._deleteSurroundingText15879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._deleteSurroundingText15879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setComposingText15880;
		 bool android.view.inputmethod.InputConnection.setComposingText(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._setComposingText15880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._setComposingText15880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _finishComposingText15881;
		 bool android.view.inputmethod.InputConnection.finishComposingText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._finishComposingText15881);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._finishComposingText15881);
		}
		internal static global::MonoJavaBridge.MethodId _commitText15882;
		 bool android.view.inputmethod.InputConnection.commitText(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._commitText15882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._commitText15882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _commitCompletion15883;
		 bool android.view.inputmethod.InputConnection.commitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._commitCompletion15883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._commitCompletion15883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performEditorAction15884;
		 bool android.view.inputmethod.InputConnection.performEditorAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._performEditorAction15884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._performEditorAction15884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuAction15885;
		 bool android.view.inputmethod.InputConnection.performContextMenuAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._performContextMenuAction15885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._performContextMenuAction15885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyEvent15886;
		 bool android.view.inputmethod.InputConnection.sendKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._sendKeyEvent15886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._sendKeyEvent15886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyStates15887;
		 bool android.view.inputmethod.InputConnection.clearMetaKeyStates(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._clearMetaKeyStates15887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._clearMetaKeyStates15887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reportFullscreenMode15888;
		 bool android.view.inputmethod.InputConnection.reportFullscreenMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._reportFullscreenMode15888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._reportFullscreenMode15888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performPrivateCommand15889;
		 bool android.view.inputmethod.InputConnection.performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_._performPrivateCommand15889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnection_.staticClass, global::android.view.inputmethod.InputConnection_._performPrivateCommand15889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputConnection"));
			global::android.view.inputmethod.InputConnection_._setSelection15872 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "setSelection", "(II)Z");
			global::android.view.inputmethod.InputConnection_._beginBatchEdit15873 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "beginBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnection_._endBatchEdit15874 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "endBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnection_._getTextBeforeCursor15875 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnection_._getTextAfterCursor15876 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnection_._getCursorCapsMode15877 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "getCursorCapsMode", "(I)I");
			global::android.view.inputmethod.InputConnection_._getExtractedText15878 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;");
			global::android.view.inputmethod.InputConnection_._deleteSurroundingText15879 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "deleteSurroundingText", "(II)Z");
			global::android.view.inputmethod.InputConnection_._setComposingText15880 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnection_._finishComposingText15881 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "finishComposingText", "()Z");
			global::android.view.inputmethod.InputConnection_._commitText15882 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnection_._commitCompletion15883 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z");
			global::android.view.inputmethod.InputConnection_._performEditorAction15884 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "performEditorAction", "(I)Z");
			global::android.view.inputmethod.InputConnection_._performContextMenuAction15885 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "performContextMenuAction", "(I)Z");
			global::android.view.inputmethod.InputConnection_._sendKeyEvent15886 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.inputmethod.InputConnection_._clearMetaKeyStates15887 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "clearMetaKeyStates", "(I)Z");
			global::android.view.inputmethod.InputConnection_._reportFullscreenMode15888 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "reportFullscreenMode", "(Z)Z");
			global::android.view.inputmethod.InputConnection_._performPrivateCommand15889 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnection_.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
		}
	}
}
