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
		internal InputConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool android.view.inputmethod.InputConnection.setSelection(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "setSelection", "(II)Z", ref global::android.view.inputmethod.InputConnection_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool android.view.inputmethod.InputConnection.beginBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "beginBatchEdit", "()Z", ref global::android.view.inputmethod.InputConnection_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool android.view.inputmethod.InputConnection.endBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "endBatchEdit", "()Z", ref global::android.view.inputmethod.InputConnection_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.CharSequence android.view.inputmethod.InputConnection.getTextBeforeCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.InputConnection_.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.InputConnection_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.CharSequence android.view.inputmethod.InputConnection.getTextAfterCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.InputConnection_.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.InputConnection_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int android.view.inputmethod.InputConnection.getCursorCapsMode(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "getCursorCapsMode", "(I)I", ref global::android.view.inputmethod.InputConnection_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::android.view.inputmethod.ExtractedText android.view.inputmethod.InputConnection.getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;", ref global::android.view.inputmethod.InputConnection_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.inputmethod.ExtractedText;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool android.view.inputmethod.InputConnection.deleteSurroundingText(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "deleteSurroundingText", "(II)Z", ref global::android.view.inputmethod.InputConnection_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool android.view.inputmethod.InputConnection.setComposingText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z", ref global::android.view.inputmethod.InputConnection_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool android.view.inputmethod.InputConnection.finishComposingText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "finishComposingText", "()Z", ref global::android.view.inputmethod.InputConnection_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		bool android.view.inputmethod.InputConnection.commitText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z", ref global::android.view.inputmethod.InputConnection_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool android.view.inputmethod.InputConnection.commitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", ref global::android.view.inputmethod.InputConnection_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		bool android.view.inputmethod.InputConnection.performEditorAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "performEditorAction", "(I)Z", ref global::android.view.inputmethod.InputConnection_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool android.view.inputmethod.InputConnection.performContextMenuAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "performContextMenuAction", "(I)Z", ref global::android.view.inputmethod.InputConnection_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		bool android.view.inputmethod.InputConnection.sendKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.inputmethod.InputConnection_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		bool android.view.inputmethod.InputConnection.clearMetaKeyStates(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "clearMetaKeyStates", "(I)Z", ref global::android.view.inputmethod.InputConnection_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool android.view.inputmethod.InputConnection.reportFullscreenMode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "reportFullscreenMode", "(Z)Z", ref global::android.view.inputmethod.InputConnection_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool android.view.inputmethod.InputConnection.performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnection_.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.view.inputmethod.InputConnection_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static InputConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
