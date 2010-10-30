namespace android.view.inputmethod
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BaseInputConnection : java.lang.Object, InputConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BaseInputConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool setSelection(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "setSelection", "(II)Z", ref global::android.view.inputmethod.BaseInputConnection._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool beginBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "beginBatchEdit", "()Z", ref global::android.view.inputmethod.BaseInputConnection._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool endBatchEdit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "endBatchEdit", "()Z", ref global::android.view.inputmethod.BaseInputConnection._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.BaseInputConnection._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.CharSequence getTextAfterCursor(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getTextAfterCursor", "(II)Ljava/lang/CharSequence;", ref global::android.view.inputmethod.BaseInputConnection._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getCursorCapsMode(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getCursorCapsMode", "(I)I", ref global::android.view.inputmethod.BaseInputConnection._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/ExtractedText;", ref global::android.view.inputmethod.BaseInputConnection._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.inputmethod.ExtractedText;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool deleteSurroundingText(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "deleteSurroundingText", "(II)Z", ref global::android.view.inputmethod.BaseInputConnection._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool setComposingText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingText", "(Ljava/lang/CharSequence;I)Z", ref global::android.view.inputmethod.BaseInputConnection._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool setComposingText(string arg0, int arg1)
		{
			return setComposingText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool finishComposingText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "finishComposingText", "()Z", ref global::android.view.inputmethod.BaseInputConnection._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool commitText(java.lang.CharSequence arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "commitText", "(Ljava/lang/CharSequence;I)Z", ref global::android.view.inputmethod.BaseInputConnection._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool commitText(string arg0, int arg1)
		{
			return commitText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool commitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", ref global::android.view.inputmethod.BaseInputConnection._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool performEditorAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "performEditorAction", "(I)Z", ref global::android.view.inputmethod.BaseInputConnection._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool performContextMenuAction(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "performContextMenuAction", "(I)Z", ref global::android.view.inputmethod.BaseInputConnection._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool sendKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "sendKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.inputmethod.BaseInputConnection._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool clearMetaKeyStates(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "clearMetaKeyStates", "(I)Z", ref global::android.view.inputmethod.BaseInputConnection._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool reportFullscreenMode(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "reportFullscreenMode", "(Z)Z", ref global::android.view.inputmethod.BaseInputConnection._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.view.inputmethod.BaseInputConnection._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static void removeComposingSpans(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._m18.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._m18 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "removeComposingSpans", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::android.text.Spannable ComposingSpans
		{
			set
			{
				setComposingSpans(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void setComposingSpans(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._m19.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._m19 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "setComposingSpans", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static int getComposingSpanStart(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._m20.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._m20 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanStart", "(Landroid/text/Spannable;)I");
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static int getComposingSpanEnd(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._m21.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._m21 = @__env.GetStaticMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "getComposingSpanEnd", "(Landroid/text/Spannable;)I");
			return @__env.CallStaticIntMethod(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.Editable Editable
		{
			get
			{
				return getEditable();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::android.text.Editable getEditable()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.view.inputmethod.BaseInputConnection.staticClass, "getEditable", "()Landroid/text/Editable;", ref global::android.view.inputmethod.BaseInputConnection._m22) as android.text.Editable;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public BaseInputConnection(android.view.View arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.inputmethod.BaseInputConnection._m23.native == global::System.IntPtr.Zero)
				global::android.view.inputmethod.BaseInputConnection._m23 = @__env.GetMethodIDNoThrow(global::android.view.inputmethod.BaseInputConnection.staticClass, "<init>", "(Landroid/view/View;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.inputmethod.BaseInputConnection.staticClass, global::android.view.inputmethod.BaseInputConnection._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BaseInputConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.inputmethod.BaseInputConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/inputmethod/BaseInputConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
