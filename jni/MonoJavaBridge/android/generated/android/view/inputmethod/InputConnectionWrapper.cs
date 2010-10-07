namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class InputConnectionWrapper : java.lang.Object, InputConnection
	{
		internal static global::java.lang.Class staticClass;
		static InputConnectionWrapper()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.InputConnectionWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9831;
		public virtual bool setSelection(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._setSelection9831, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._setSelection9831, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _beginBatchEdit9832;
		public virtual bool beginBatchEdit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._beginBatchEdit9832);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._beginBatchEdit9832);
		}
		internal static global::net.sf.jni4net.jni.MethodId _endBatchEdit9833;
		public virtual bool endBatchEdit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._endBatchEdit9833);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._endBatchEdit9833);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTarget9834;
		public virtual void setTarget(android.view.inputmethod.InputConnection arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.InputConnectionWrapper._setTarget9834, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._setTarget9834, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextBeforeCursor9835;
		public virtual global::java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputConnectionWrapper._getTextBeforeCursor9835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getTextBeforeCursor9835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextAfterCursor9836;
		public virtual global::java.lang.CharSequence getTextAfterCursor(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputConnectionWrapper._getTextAfterCursor9836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getTextAfterCursor9836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCursorCapsMode9837;
		public virtual int getCursorCapsMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.inputmethod.InputConnectionWrapper._getCursorCapsMode9837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getCursorCapsMode9837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtractedText9838;
		public virtual global::android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.InputConnectionWrapper._getExtractedText9838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._getExtractedText9838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteSurroundingText9839;
		public virtual bool deleteSurroundingText(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._deleteSurroundingText9839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._deleteSurroundingText9839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setComposingText9840;
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._setComposingText9840, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._setComposingText9840, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		public bool setComposingText(string arg0, int arg1)
		{
			return setComposingText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishComposingText9841;
		public virtual bool finishComposingText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._finishComposingText9841);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._finishComposingText9841);
		}
		internal static global::net.sf.jni4net.jni.MethodId _commitText9842;
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._commitText9842, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._commitText9842, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		public bool commitText(string arg0, int arg1)
		{
			return commitText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _commitCompletion9843;
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._commitCompletion9843, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._commitCompletion9843, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performEditorAction9844;
		public virtual bool performEditorAction(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._performEditorAction9844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._performEditorAction9844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performContextMenuAction9845;
		public virtual bool performContextMenuAction(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._performContextMenuAction9845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._performContextMenuAction9845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyEvent9846;
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._sendKeyEvent9846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._sendKeyEvent9846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyStates9847;
		public virtual bool clearMetaKeyStates(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._clearMetaKeyStates9847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._clearMetaKeyStates9847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reportFullscreenMode9848;
		public virtual bool reportFullscreenMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._reportFullscreenMode9848, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._reportFullscreenMode9848, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performPrivateCommand9849;
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper._performPrivateCommand9849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._performPrivateCommand9849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _InputConnectionWrapper9850;
		public InputConnectionWrapper(android.view.inputmethod.InputConnection arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._InputConnectionWrapper9850, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.InputConnectionWrapper.staticClass = @__class;
			global::android.view.inputmethod.InputConnectionWrapper._setSelection9831 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setSelection", "(II)Z");
			global::android.view.inputmethod.InputConnectionWrapper._beginBatchEdit9832 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "beginBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnectionWrapper._endBatchEdit9833 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "endBatchEdit", "()Z");
			global::android.view.inputmethod.InputConnectionWrapper._setTarget9834 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setTarget", "(Landroid/view/inputmethod/InputConnection;)V");
			global::android.view.inputmethod.InputConnectionWrapper._getTextBeforeCursor9835 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnectionWrapper._getTextAfterCursor9836 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.InputConnectionWrapper._getCursorCapsMode9837 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getCursorCapsMode", "(I)I");
			global::android.view.inputmethod.InputConnectionWrapper._getExtractedText9838 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;");
			global::android.view.inputmethod.InputConnectionWrapper._deleteSurroundingText9839 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "deleteSurroundingText", "(II)Z");
			global::android.view.inputmethod.InputConnectionWrapper._setComposingText9840 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._finishComposingText9841 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "finishComposingText", "()Z");
			global::android.view.inputmethod.InputConnectionWrapper._commitText9842 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._commitCompletion9843 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z");
			global::android.view.inputmethod.InputConnectionWrapper._performEditorAction9844 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performEditorAction", "(I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._performContextMenuAction9845 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performContextMenuAction", "(I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._sendKeyEvent9846 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.inputmethod.InputConnectionWrapper._clearMetaKeyStates9847 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "clearMetaKeyStates", "(I)Z");
			global::android.view.inputmethod.InputConnectionWrapper._reportFullscreenMode9848 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "reportFullscreenMode", "(Z)Z");
			global::android.view.inputmethod.InputConnectionWrapper._performPrivateCommand9849 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.view.inputmethod.InputConnectionWrapper._InputConnectionWrapper9850 = @__env.GetMethodID(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Z)V");
		}
	}
}
