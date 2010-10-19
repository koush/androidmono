namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputConnectionWrapper : java.lang.Object, InputConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputConnectionWrapper()
		{
			InitJNI();
		}
		protected InputConnectionWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSelection10724;
		public virtual bool setSelection(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._setSelection10724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._setSelection10724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit10725;
		public virtual bool beginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._beginBatchEdit10725);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._beginBatchEdit10725);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit10726;
		public virtual bool endBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._endBatchEdit10726);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._endBatchEdit10726);
		}
		internal static global::MonoJavaBridge.MethodId _setTarget10727;
		public virtual void setTarget(android.view.inputmethod.InputConnection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._setTarget10727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._setTarget10727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextBeforeCursor10728;
		public virtual global::java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._getTextBeforeCursor10728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getTextBeforeCursor10728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getTextAfterCursor10729;
		public virtual global::java.lang.CharSequence getTextAfterCursor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._getTextAfterCursor10729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getTextAfterCursor10729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getCursorCapsMode10730;
		public virtual int getCursorCapsMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._getCursorCapsMode10730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getCursorCapsMode10730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExtractedText10731;
		public virtual global::android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._getExtractedText10731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.inputmethod.ExtractedText;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getExtractedText10731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.inputmethod.ExtractedText;
		}
		internal static global::MonoJavaBridge.MethodId _deleteSurroundingText10732;
		public virtual bool deleteSurroundingText(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._deleteSurroundingText10732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._deleteSurroundingText10732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setComposingText10733;
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._setComposingText10733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._setComposingText10733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool setComposingText(string arg0, int arg1)
		{
			return setComposingText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _finishComposingText10734;
		public virtual bool finishComposingText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._finishComposingText10734);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._finishComposingText10734);
		}
		internal static global::MonoJavaBridge.MethodId _commitText10735;
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._commitText10735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._commitText10735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool commitText(string arg0, int arg1)
		{
			return commitText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _commitCompletion10736;
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._commitCompletion10736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._commitCompletion10736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performEditorAction10737;
		public virtual bool performEditorAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._performEditorAction10737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._performEditorAction10737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuAction10738;
		public virtual bool performContextMenuAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._performContextMenuAction10738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._performContextMenuAction10738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyEvent10739;
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._sendKeyEvent10739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._sendKeyEvent10739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyStates10740;
		public virtual bool clearMetaKeyStates(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._clearMetaKeyStates10740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._clearMetaKeyStates10740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reportFullscreenMode10741;
		public virtual bool reportFullscreenMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._reportFullscreenMode10741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._reportFullscreenMode10741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performPrivateCommand10742;
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper._performPrivateCommand10742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._performPrivateCommand10742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _InputConnectionWrapper10743;
		public InputConnectionWrapper(android.view.inputmethod.InputConnection arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._InputConnectionWrapper10743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputConnectionWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputConnectionWrapper"));
			global::android.view.inputmethod.InputConnectionWrapper._setSelection10724 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setSelection", "(II)Z");
			global::android.view.inputmethod.InputConnectionWrapper._beginBatchEdit10725 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "beginBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnectionWrapper._endBatchEdit10726 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "endBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnectionWrapper._setTarget10727 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setTarget", "(Landroid/view/inputmethod/InputConnection;)V");
			global::android.view.inputmethod.InputConnectionWrapper._getTextBeforeCursor10728 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnectionWrapper._getTextAfterCursor10729 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnectionWrapper._getCursorCapsMode10730 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getCursorCapsMode", "(I)I");
			global::android.view.inputmethod.InputConnectionWrapper._getExtractedText10731 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;");
			global::android.view.inputmethod.InputConnectionWrapper._deleteSurroundingText10732 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "deleteSurroundingText", "(II)Z");
			global::android.view.inputmethod.InputConnectionWrapper._setComposingText10733 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._finishComposingText10734 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "finishComposingText", "()Z");
			global::android.view.inputmethod.InputConnectionWrapper._commitText10735 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._commitCompletion10736 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z");
			global::android.view.inputmethod.InputConnectionWrapper._performEditorAction10737 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performEditorAction", "(I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._performContextMenuAction10738 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performContextMenuAction", "(I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._sendKeyEvent10739 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.inputmethod.InputConnectionWrapper._clearMetaKeyStates10740 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "clearMetaKeyStates", "(I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._reportFullscreenMode10741 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "reportFullscreenMode", "(Z)Z");
			global::android.view.inputmethod.InputConnectionWrapper._performPrivateCommand10742 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.view.inputmethod.InputConnectionWrapper._InputConnectionWrapper10743 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Z)V");
		}
	}
}
