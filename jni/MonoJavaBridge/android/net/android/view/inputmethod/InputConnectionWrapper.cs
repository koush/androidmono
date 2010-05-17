namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InputConnectionWrapper : java.lang.Object, InputConnection
	{ 
		internal static global::java.lang.Class staticClass; 
		static InputConnectionWrapper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.InputConnectionWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.inputmethod.InputConnectionWrapper(@__env); 
			} 
		} 
		protected InputConnectionWrapper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection8463; 
		public virtual bool setSelection(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _setSelection8463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _setSelection8463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginBatchEdit8464; 
		public virtual bool beginBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _beginBatchEdit8464); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _beginBatchEdit8464); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endBatchEdit8465; 
		public virtual bool endBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _endBatchEdit8465); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _endBatchEdit8465); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTarget8466; 
		public virtual void setTarget(android.view.inputmethod.InputConnection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				@__env.CallVoidMethod(this, _setTarget8466, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _setTarget8466, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextBeforeCursor8467; 
		public virtual java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTextBeforeCursor8467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _getTextBeforeCursor8467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextAfterCursor8468; 
		public virtual java.lang.CharSequence getTextAfterCursor(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTextAfterCursor8468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _getTextAfterCursor8468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursorCapsMode8469; 
		public virtual int getCursorCapsMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallIntMethod(this, _getCursorCapsMode8469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _getCursorCapsMode8469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtractedText8470; 
		public virtual android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallObjectMethodPtr(this, _getExtractedText8470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _getExtractedText8470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteSurroundingText8471; 
		public virtual bool deleteSurroundingText(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _deleteSurroundingText8471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _deleteSurroundingText8471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setComposingText8472; 
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _setComposingText8472, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _setComposingText8472, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishComposingText8473; 
		public virtual bool finishComposingText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _finishComposingText8473); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _finishComposingText8473); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _commitText8474; 
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _commitText8474, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _commitText8474, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _commitCompletion8475; 
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _commitCompletion8475, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _commitCompletion8475, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performEditorAction8476; 
		public virtual bool performEditorAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _performEditorAction8476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _performEditorAction8476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performContextMenuAction8477; 
		public virtual bool performContextMenuAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _performContextMenuAction8477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _performContextMenuAction8477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyEvent8478; 
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _sendKeyEvent8478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _sendKeyEvent8478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyStates8479; 
		public virtual bool clearMetaKeyStates(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _clearMetaKeyStates8479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _clearMetaKeyStates8479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reportFullscreenMode8480; 
		public virtual bool reportFullscreenMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _reportFullscreenMode8480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _reportFullscreenMode8480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performPrivateCommand8481; 
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.InputConnectionWrapper)) 
				return @__env.CallBooleanMethod(this, _performPrivateCommand8481, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.InputConnectionWrapper.staticClass, _performPrivateCommand8481, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InputConnectionWrapper8482; 
		public InputConnectionWrapper(android.view.inputmethod.InputConnection arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.InputConnectionWrapper.staticClass, _InputConnectionWrapper8482, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.InputConnectionWrapper.staticClass = @__class; 
			global::android.view.inputmethod.InputConnectionWrapper._setSelection8463 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setSelection", "(II)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._beginBatchEdit8464 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "beginBatchEdit", "()Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._endBatchEdit8465 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "endBatchEdit", "()Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._setTarget8466 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setTarget", "(Landroid/view/inputmethod/InputConnection;)V"); 
			global::android.view.inputmethod.InputConnectionWrapper._getTextBeforeCursor8467 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;"); 
			global::android.view.inputmethod.InputConnectionWrapper._getTextAfterCursor8468 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;"); 
			global::android.view.inputmethod.InputConnectionWrapper._getCursorCapsMode8469 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getCursorCapsMode", "(I)I"); 
			global::android.view.inputmethod.InputConnectionWrapper._getExtractedText8470 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;"); 
			global::android.view.inputmethod.InputConnectionWrapper._deleteSurroundingText8471 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "deleteSurroundingText", "(II)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._setComposingText8472 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._finishComposingText8473 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "finishComposingText", "()Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._commitText8474 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._commitCompletion8475 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._performEditorAction8476 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performEditorAction", "(I)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._performContextMenuAction8477 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performContextMenuAction", "(I)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._sendKeyEvent8478 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._clearMetaKeyStates8479 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "clearMetaKeyStates", "(I)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._reportFullscreenMode8480 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "reportFullscreenMode", "(Z)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._performPrivateCommand8481 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z"); 
			global::android.view.inputmethod.InputConnectionWrapper._InputConnectionWrapper8482 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Z)V"); 
		} 
	} 
} 
