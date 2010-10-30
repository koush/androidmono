namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputConnectionWrapper : java.lang.Object, InputConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputConnectionWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSelection15892;
		public virtual bool setSelection(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._setSelection15892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit15893;
		public virtual bool beginBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._beginBatchEdit15893);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit15894;
		public virtual bool endBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._endBatchEdit15894);
		}
		public new global::android.view.inputmethod.InputConnection Target
		{
			set
			{
				setTarget(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTarget15895;
		public virtual void setTarget(android.view.inputmethod.InputConnection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._setTarget15895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextBeforeCursor15896;
		public virtual global::java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getTextBeforeCursor15896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getTextAfterCursor15897;
		public virtual global::java.lang.CharSequence getTextAfterCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getTextAfterCursor15897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getCursorCapsMode15898;
		public virtual int getCursorCapsMode(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getCursorCapsMode15898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExtractedText15899;
		public virtual global::android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getExtractedText15899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.inputmethod.ExtractedText;
		}
		internal static global::MonoJavaBridge.MethodId _deleteSurroundingText15900;
		public virtual bool deleteSurroundingText(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._deleteSurroundingText15900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setComposingText15901;
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._setComposingText15901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool setComposingText(string arg0, int arg1)
		{
			return setComposingText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _finishComposingText15902;
		public virtual bool finishComposingText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._finishComposingText15902);
		}
		internal static global::MonoJavaBridge.MethodId _commitText15903;
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._commitText15903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool commitText(string arg0, int arg1)
		{
			return commitText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _commitCompletion15904;
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._commitCompletion15904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performEditorAction15905;
		public virtual bool performEditorAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._performEditorAction15905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuAction15906;
		public virtual bool performContextMenuAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._performContextMenuAction15906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyEvent15907;
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._sendKeyEvent15907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyStates15908;
		public virtual bool clearMetaKeyStates(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._clearMetaKeyStates15908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reportFullscreenMode15909;
		public virtual bool reportFullscreenMode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._reportFullscreenMode15909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performPrivateCommand15910;
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._performPrivateCommand15910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _InputConnectionWrapper15911;
		public InputConnectionWrapper(android.view.inputmethod.InputConnection arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._InputConnectionWrapper15911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InputConnectionWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputConnectionWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputConnectionWrapper"));
			global::android.view.inputmethod.InputConnectionWrapper._setSelection15892 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setSelection", "(II)Z");
			global::android.view.inputmethod.InputConnectionWrapper._beginBatchEdit15893 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "beginBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnectionWrapper._endBatchEdit15894 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "endBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnectionWrapper._setTarget15895 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setTarget", "(Landroid/view/inputmethod/InputConnection;)V");
			global::android.view.inputmethod.InputConnectionWrapper._getTextBeforeCursor15896 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnectionWrapper._getTextAfterCursor15897 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnectionWrapper._getCursorCapsMode15898 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getCursorCapsMode", "(I)I");
			global::android.view.inputmethod.InputConnectionWrapper._getExtractedText15899 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;");
			global::android.view.inputmethod.InputConnectionWrapper._deleteSurroundingText15900 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "deleteSurroundingText", "(II)Z");
			global::android.view.inputmethod.InputConnectionWrapper._setComposingText15901 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._finishComposingText15902 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "finishComposingText", "()Z");
			global::android.view.inputmethod.InputConnectionWrapper._commitText15903 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._commitCompletion15904 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z");
			global::android.view.inputmethod.InputConnectionWrapper._performEditorAction15905 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performEditorAction", "(I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._performContextMenuAction15906 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performContextMenuAction", "(I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._sendKeyEvent15907 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.inputmethod.InputConnectionWrapper._clearMetaKeyStates15908 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "clearMetaKeyStates", "(I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._reportFullscreenMode15909 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "reportFullscreenMode", "(Z)Z");
			global::android.view.inputmethod.InputConnectionWrapper._performPrivateCommand15910 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.view.inputmethod.InputConnectionWrapper._InputConnectionWrapper15911 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
