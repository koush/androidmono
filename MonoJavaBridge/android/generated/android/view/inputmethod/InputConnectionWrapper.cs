namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputConnectionWrapper : java.lang.Object, InputConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputConnectionWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool setSelection(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setSelection", "(II)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool beginBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "beginBatchEdit", "()Z", ref global::android.view.inputmethod.InputConnectionWrapper._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool endBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "endBatchEdit", "()Z", ref global::android.view.inputmethod.InputConnectionWrapper._m2);
		}
		public new global::android.view.inputmethod.InputConnection Target
		{
			set
			{
				setTarget(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setTarget(android.view.inputmethod.InputConnection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setTarget", "(Landroid/view/inputmethod/InputConnection;)V", ref global::android.view.inputmethod.InputConnectionWrapper._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.InputConnectionWrapper._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.CharSequence getTextAfterCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.InputConnectionWrapper._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getCursorCapsMode(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getCursorCapsMode", "(I)I", ref global::android.view.inputmethod.InputConnectionWrapper._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;", ref global::android.view.inputmethod.InputConnectionWrapper._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.inputmethod.ExtractedText;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool deleteSurroundingText(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "deleteSurroundingText", "(II)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool setComposingText(string arg0, int arg1)
		{
			return setComposingText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool finishComposingText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "finishComposingText", "()Z", ref global::android.view.inputmethod.InputConnectionWrapper._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool commitText(string arg0, int arg1)
		{
			return commitText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool performEditorAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performEditorAction", "(I)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool performContextMenuAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performContextMenuAction", "(I)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool clearMetaKeyStates(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "clearMetaKeyStates", "(I)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool reportFullscreenMode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "reportFullscreenMode", "(Z)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.InputConnectionWrapper.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.view.inputmethod.InputConnectionWrapper._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public InputConnectionWrapper(android.view.inputmethod.InputConnection arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.InputConnectionWrapper._m19.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.InputConnectionWrapper._m19 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.InputConnectionWrapper.staticClass, "<init>", "(Landroid/view/inputmethod/InputConnection;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.InputConnectionWrapper.staticClass, global::android.view.inputmethod.InputConnectionWrapper._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InputConnectionWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.InputConnectionWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/InputConnectionWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
