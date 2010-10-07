namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BaseInputConnection : java.lang.Object, InputConnection
	{
		internal static global::java.lang.Class staticClass;
		static BaseInputConnection()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.BaseInputConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _setSelection9731;
		public virtual bool setSelection(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._setSelection9731, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._setSelection9731, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _beginBatchEdit9732;
		public virtual bool beginBatchEdit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._beginBatchEdit9732);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._beginBatchEdit9732);
		}
		internal static global::net.sf.jni4net.jni.MethodId _endBatchEdit9733;
		public virtual bool endBatchEdit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._endBatchEdit9733);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._endBatchEdit9733);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextBeforeCursor9734;
		public virtual global::java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.BaseInputConnection._getTextBeforeCursor9734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getTextBeforeCursor9734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextAfterCursor9735;
		public virtual global::java.lang.CharSequence getTextAfterCursor(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.BaseInputConnection._getTextAfterCursor9735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getTextAfterCursor9735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCursorCapsMode9736;
		public virtual int getCursorCapsMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.inputmethod.BaseInputConnection._getCursorCapsMode9736, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getCursorCapsMode9736, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtractedText9737;
		public virtual global::android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.BaseInputConnection._getExtractedText9737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.inputmethod.ExtractedText>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getExtractedText9737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteSurroundingText9738;
		public virtual bool deleteSurroundingText(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._deleteSurroundingText9738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._deleteSurroundingText9738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setComposingText9739;
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._setComposingText9739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._setComposingText9739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		public bool setComposingText(string arg0, int arg1)
		{
			return setComposingText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishComposingText9740;
		public virtual bool finishComposingText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._finishComposingText9740);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._finishComposingText9740);
		}
		internal static global::net.sf.jni4net.jni.MethodId _commitText9741;
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._commitText9741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._commitText9741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		public bool commitText(string arg0, int arg1)
		{
			return commitText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _commitCompletion9742;
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._commitCompletion9742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._commitCompletion9742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performEditorAction9743;
		public virtual bool performEditorAction(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._performEditorAction9743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._performEditorAction9743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performContextMenuAction9744;
		public virtual bool performContextMenuAction(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._performContextMenuAction9744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._performContextMenuAction9744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyEvent9745;
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._sendKeyEvent9745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._sendKeyEvent9745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyStates9746;
		public virtual bool clearMetaKeyStates(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._clearMetaKeyStates9746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._clearMetaKeyStates9746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reportFullscreenMode9747;
		public virtual bool reportFullscreenMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._reportFullscreenMode9747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._reportFullscreenMode9747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performPrivateCommand9748;
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection._performPrivateCommand9748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._performPrivateCommand9748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeComposingSpans9749;
		public static void removeComposingSpans(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._removeComposingSpans9749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setComposingSpans9750;
		public static void setComposingSpans(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._setComposingSpans9750, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getComposingSpanStart9751;
		public static int getComposingSpanStart(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getComposingSpanStart9751, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getComposingSpanEnd9752;
		public static int getComposingSpanEnd(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getComposingSpanEnd9752, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEditable9753;
		public virtual global::android.text.Editable getEditable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.inputmethod.BaseInputConnection._getEditable9753));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._getEditable9753));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BaseInputConnection9754;
		public BaseInputConnection(android.view.View arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._BaseInputConnection9754, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.BaseInputConnection.staticClass = @__class;
			global::android.view.inputmethod.BaseInputConnection._setSelection9731 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "setSelection", "(II)Z");
			global::android.view.inputmethod.BaseInputConnection._beginBatchEdit9732 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "beginBatchEdit", "()Z");
			global::android.view.inputmethod.BaseInputConnection._endBatchEdit9733 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "endBatchEdit", "()Z");
			global::android.view.inputmethod.BaseInputConnection._getTextBeforeCursor9734 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.BaseInputConnection._getTextAfterCursor9735 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;");
			global::android.view.inputmethod.BaseInputConnection._getCursorCapsMode9736 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getCursorCapsMode", "(I)I");
			global::android.view.inputmethod.BaseInputConnection._getExtractedText9737 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;");
			global::android.view.inputmethod.BaseInputConnection._deleteSurroundingText9738 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "deleteSurroundingText", "(II)Z");
			global::android.view.inputmethod.BaseInputConnection._setComposingText9739 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.BaseInputConnection._finishComposingText9740 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "finishComposingText", "()Z");
			global::android.view.inputmethod.BaseInputConnection._commitText9741 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z");
			global::android.view.inputmethod.BaseInputConnection._commitCompletion9742 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z");
			global::android.view.inputmethod.BaseInputConnection._performEditorAction9743 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "performEditorAction", "(I)Z");
			global::android.view.inputmethod.BaseInputConnection._performContextMenuAction9744 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "performContextMenuAction", "(I)Z");
			global::android.view.inputmethod.BaseInputConnection._sendKeyEvent9745 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.inputmethod.BaseInputConnection._clearMetaKeyStates9746 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "clearMetaKeyStates", "(I)Z");
			global::android.view.inputmethod.BaseInputConnection._reportFullscreenMode9747 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "reportFullscreenMode", "(Z)Z");
			global::android.view.inputmethod.BaseInputConnection._performPrivateCommand9748 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.view.inputmethod.BaseInputConnection._removeComposingSpans9749 = @__env.GetStaticMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "removeComposingSpans", "(Landroid/text/Spannable;)V");
			global::android.view.inputmethod.BaseInputConnection._setComposingSpans9750 = @__env.GetStaticMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingSpans", "(Landroid/text/Spannable;)V");
			global::android.view.inputmethod.BaseInputConnection._getComposingSpanStart9751 = @__env.GetStaticMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanStart", "(Landroid/text/Spannable;)I");
			global::android.view.inputmethod.BaseInputConnection._getComposingSpanEnd9752 = @__env.GetStaticMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanEnd", "(Landroid/text/Spannable;)I");
			global::android.view.inputmethod.BaseInputConnection._getEditable9753 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "getEditable", "()Landroid/text/Editable;");
			global::android.view.inputmethod.BaseInputConnection._BaseInputConnection9754 = @__env.GetMethodID(global::android.view.inputmethod.BaseInputConnection.staticClass, "<init>", "(Landroid/view/View;Z)V");
		}
	}
}
