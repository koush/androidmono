namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface InputConnection 
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

	public partial class InputConnection_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __InputConnection.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __InputConnection : java.lang.Object, InputConnection
	{ 
		internal static global::java.lang.Class staticClass; 
		static __InputConnection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.__InputConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.inputmethod.__InputConnection(@__env); 
			} 
		} 
		internal __InputConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9106; 
		 bool android.view.inputmethod.InputConnection.setSelection(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._setSelection9106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._setSelection9106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginBatchEdit9107; 
		 bool android.view.inputmethod.InputConnection.beginBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._beginBatchEdit9107); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._beginBatchEdit9107); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endBatchEdit9108; 
		 bool android.view.inputmethod.InputConnection.endBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._endBatchEdit9108); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._endBatchEdit9108); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextBeforeCursor9109; 
		 global::java.lang.CharSequence android.view.inputmethod.InputConnection.getTextBeforeCursor(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.__InputConnection._getTextBeforeCursor9109, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._getTextBeforeCursor9109, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextAfterCursor9110; 
		 global::java.lang.CharSequence android.view.inputmethod.InputConnection.getTextAfterCursor(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.__InputConnection._getTextAfterCursor9110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._getTextAfterCursor9110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCursorCapsMode9111; 
		 int android.view.inputmethod.InputConnection.getCursorCapsMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.inputmethod.__InputConnection._getCursorCapsMode9111, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._getCursorCapsMode9111, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtractedText9112; 
		 global::android.view.inputmethod.ExtractedText android.view.inputmethod.InputConnection.getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.__InputConnection._getExtractedText9112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._getExtractedText9112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteSurroundingText9113; 
		 bool android.view.inputmethod.InputConnection.deleteSurroundingText(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._deleteSurroundingText9113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._deleteSurroundingText9113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setComposingText9114; 
		 bool android.view.inputmethod.InputConnection.setComposingText(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._setComposingText9114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._setComposingText9114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishComposingText9115; 
		 bool android.view.inputmethod.InputConnection.finishComposingText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._finishComposingText9115); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._finishComposingText9115); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _commitText9116; 
		 bool android.view.inputmethod.InputConnection.commitText(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._commitText9116, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._commitText9116, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _commitCompletion9117; 
		 bool android.view.inputmethod.InputConnection.commitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._commitCompletion9117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._commitCompletion9117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performEditorAction9118; 
		 bool android.view.inputmethod.InputConnection.performEditorAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._performEditorAction9118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._performEditorAction9118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performContextMenuAction9119; 
		 bool android.view.inputmethod.InputConnection.performContextMenuAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._performContextMenuAction9119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._performContextMenuAction9119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyEvent9120; 
		 bool android.view.inputmethod.InputConnection.sendKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._sendKeyEvent9120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._sendKeyEvent9120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyStates9121; 
		 bool android.view.inputmethod.InputConnection.clearMetaKeyStates(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._clearMetaKeyStates9121, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._clearMetaKeyStates9121, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reportFullscreenMode9122; 
		 bool android.view.inputmethod.InputConnection.reportFullscreenMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._reportFullscreenMode9122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._reportFullscreenMode9122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performPrivateCommand9123; 
		 bool android.view.inputmethod.InputConnection.performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.__InputConnection._performPrivateCommand9123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.__InputConnection.staticClass, global::android.view.inputmethod.__InputConnection._performPrivateCommand9123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.inputmethod.__InputConnection.staticClass = @__class; 
			global::android.view.inputmethod.__InputConnection._setSelection9106 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.setSelection", "(II)Z"); 
			global::android.view.inputmethod.__InputConnection._beginBatchEdit9107 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.beginBatchEdit", "()Z"); 
			global::android.view.inputmethod.__InputConnection._endBatchEdit9108 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.endBatchEdit", "()Z"); 
			global::android.view.inputmethod.__InputConnection._getTextBeforeCursor9109 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.getTextBeforeCursor", "(II)Ljava/lang/CharSequence;"); 
			global::android.view.inputmethod.__InputConnection._getTextAfterCursor9110 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.getTextAfterCursor", "(II)Ljava/lang/CharSequence;"); 
			global::android.view.inputmethod.__InputConnection._getCursorCapsMode9111 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.getCursorCapsMode", "(I)I"); 
			global::android.view.inputmethod.__InputConnection._getExtractedText9112 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;"); 
			global::android.view.inputmethod.__InputConnection._deleteSurroundingText9113 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.deleteSurroundingText", "(II)Z"); 
			global::android.view.inputmethod.__InputConnection._setComposingText9114 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.setComposingText", "(Ljava/lang/CharSequence;I)Z"); 
			global::android.view.inputmethod.__InputConnection._finishComposingText9115 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.finishComposingText", "()Z"); 
			global::android.view.inputmethod.__InputConnection._commitText9116 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.commitText", "(Ljava/lang/CharSequence;I)Z"); 
			global::android.view.inputmethod.__InputConnection._commitCompletion9117 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z"); 
			global::android.view.inputmethod.__InputConnection._performEditorAction9118 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.performEditorAction", "(I)Z"); 
			global::android.view.inputmethod.__InputConnection._performContextMenuAction9119 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.performContextMenuAction", "(I)Z"); 
			global::android.view.inputmethod.__InputConnection._sendKeyEvent9120 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.sendKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.inputmethod.__InputConnection._clearMetaKeyStates9121 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.clearMetaKeyStates", "(I)Z"); 
			global::android.view.inputmethod.__InputConnection._reportFullscreenMode9122 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.reportFullscreenMode", "(Z)Z"); 
			global::android.view.inputmethod.__InputConnection._performPrivateCommand9123 = @__env.GetMethodID(global::android.view.inputmethod.__InputConnection.staticClass, "android.view.inputmethod.InputConnection.performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z"); 
		} 
	} 
} 
