namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BaseInputConnection : java.lang.Object, InputConnection
	{ 
		internal static global::java.lang.Class staticClass; 
		static BaseInputConnection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.inputmethod.BaseInputConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.inputmethod.BaseInputConnection(@__env); 
			} 
		} 
		protected BaseInputConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection8381; 
		public virtual bool setSelection(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _setSelection8381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _setSelection8381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginBatchEdit8382; 
		public virtual bool beginBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _beginBatchEdit8382); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _beginBatchEdit8382); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endBatchEdit8383; 
		public virtual bool endBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _endBatchEdit8383); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _endBatchEdit8383); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextBeforeCursor8384; 
		public virtual java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTextBeforeCursor8384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.BaseInputConnection.staticClass, _getTextBeforeCursor8384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextAfterCursor8385; 
		public virtual java.lang.CharSequence getTextAfterCursor(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTextAfterCursor8385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.BaseInputConnection.staticClass, _getTextAfterCursor8385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursorCapsMode8386; 
		public virtual int getCursorCapsMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallIntMethod(this, _getCursorCapsMode8386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _getCursorCapsMode8386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtractedText8387; 
		public virtual android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallObjectMethodPtr(this, _getExtractedText8387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.BaseInputConnection.staticClass, _getExtractedText8387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteSurroundingText8388; 
		public virtual bool deleteSurroundingText(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _deleteSurroundingText8388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _deleteSurroundingText8388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setComposingText8389; 
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _setComposingText8389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _setComposingText8389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishComposingText8390; 
		public virtual bool finishComposingText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _finishComposingText8390); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _finishComposingText8390); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _commitText8391; 
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _commitText8391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _commitText8391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _commitCompletion8392; 
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _commitCompletion8392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _commitCompletion8392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performEditorAction8393; 
		public virtual bool performEditorAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _performEditorAction8393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _performEditorAction8393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performContextMenuAction8394; 
		public virtual bool performContextMenuAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _performContextMenuAction8394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _performContextMenuAction8394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyEvent8395; 
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _sendKeyEvent8395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _sendKeyEvent8395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyStates8396; 
		public virtual bool clearMetaKeyStates(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _clearMetaKeyStates8396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _clearMetaKeyStates8396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reportFullscreenMode8397; 
		public virtual bool reportFullscreenMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _reportFullscreenMode8397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _reportFullscreenMode8397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performPrivateCommand8398; 
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return @__env.CallBooleanMethod(this, _performPrivateCommand8398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.inputmethod.BaseInputConnection.staticClass, _performPrivateCommand8398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeComposingSpans8399; 
		public static void removeComposingSpans(android.text.Spannable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, _removeComposingSpans8399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setComposingSpans8400; 
		public static void setComposingSpans(android.text.Spannable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, _setComposingSpans8400, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getComposingSpanStart8401; 
		public static int getComposingSpanStart(android.text.Spannable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, _getComposingSpanStart8401, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getComposingSpanEnd8402; 
		public static int getComposingSpanEnd(android.text.Spannable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, _getComposingSpanEnd8402, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEditable8403; 
		public virtual android.text.Editable getEditable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.inputmethod.BaseInputConnection)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _getEditable8403)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.inputmethod.BaseInputConnection.staticClass, _getEditable8403)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BaseInputConnection8404; 
		public BaseInputConnection(android.view.View arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.inputmethod.BaseInputConnection.staticClass, _BaseInputConnection8404, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.BaseInputConnection.staticClass = @__class; 
			global::android.view.inputmethod.BaseInputConnection._setSelection8381 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "setSelection", "(II)Z"); 
			global::android.view.inputmethod.BaseInputConnection._beginBatchEdit8382 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "beginBatchEdit", "()Z"); 
			global::android.view.inputmethod.BaseInputConnection._endBatchEdit8383 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "endBatchEdit", "()Z"); 
			global::android.view.inputmethod.BaseInputConnection._getTextBeforeCursor8384 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;"); 
			global::android.view.inputmethod.BaseInputConnection._getTextAfterCursor8385 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;"); 
			global::android.view.inputmethod.BaseInputConnection._getCursorCapsMode8386 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getCursorCapsMode", "(I)I"); 
			global::android.view.inputmethod.BaseInputConnection._getExtractedText8387 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;"); 
			global::android.view.inputmethod.BaseInputConnection._deleteSurroundingText8388 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "deleteSurroundingText", "(II)Z"); 
			global::android.view.inputmethod.BaseInputConnection._setComposingText8389 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z"); 
			global::android.view.inputmethod.BaseInputConnection._finishComposingText8390 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "finishComposingText", "()Z"); 
			global::android.view.inputmethod.BaseInputConnection._commitText8391 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z"); 
			global::android.view.inputmethod.BaseInputConnection._commitCompletion8392 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z"); 
			global::android.view.inputmethod.BaseInputConnection._performEditorAction8393 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "performEditorAction", "(I)Z"); 
			global::android.view.inputmethod.BaseInputConnection._performContextMenuAction8394 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "performContextMenuAction", "(I)Z"); 
			global::android.view.inputmethod.BaseInputConnection._sendKeyEvent8395 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.inputmethod.BaseInputConnection._clearMetaKeyStates8396 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "clearMetaKeyStates", "(I)Z"); 
			global::android.view.inputmethod.BaseInputConnection._reportFullscreenMode8397 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "reportFullscreenMode", "(Z)Z"); 
			global::android.view.inputmethod.BaseInputConnection._performPrivateCommand8398 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z"); 
			global::android.view.inputmethod.BaseInputConnection._removeComposingSpans8399 = @__env.GetStaticMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "removeComposingSpans", "(Landroid/text/Spannable;)V"); 
			global::android.view.inputmethod.BaseInputConnection._setComposingSpans8400 = @__env.GetStaticMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingSpans", "(Landroid/text/Spannable;)V"); 
			global::android.view.inputmethod.BaseInputConnection._getComposingSpanStart8401 = @__env.GetStaticMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanStart", "(Landroid/text/Spannable;)I"); 
			global::android.view.inputmethod.BaseInputConnection._getComposingSpanEnd8402 = @__env.GetStaticMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanEnd", "(Landroid/text/Spannable;)I"); 
			global::android.view.inputmethod.BaseInputConnection._getEditable8403 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getEditable", "()Landroid/text/Editable;"); 
			global::android.view.inputmethod.BaseInputConnection._BaseInputConnection8404 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "<init>", "(Landroid/view/View;Z)V"); 
		} 
	} 
} 
