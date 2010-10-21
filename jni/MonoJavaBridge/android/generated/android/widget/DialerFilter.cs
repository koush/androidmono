namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DialerFilter : android.widget.RelativeLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialerFilter()
		{
			InitJNI();
		}
		protected DialerFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _append16867;
		public virtual void append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._append16867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._append16867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMode16868;
		public virtual void setMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._setMode16868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setMode16868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Mode
		{
			get
			{
				return getMode();
			}
			set
			{
				setMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMode16869;
		public virtual int getMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.DialerFilter._getMode16869);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getMode16869);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16870;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter._onKeyDown16870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyDown16870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp16871;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter._onKeyUp16871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyUp16871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged16872;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._onFocusChanged16872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFocusChanged16872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate16873;
		protected override void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._onFinishInflate16873);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFinishInflate16873);
		}
		internal static global::MonoJavaBridge.MethodId _isQwertyKeyboard16874;
		public virtual bool isQwertyKeyboard() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter._isQwertyKeyboard16874);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._isQwertyKeyboard16874);
		}
		public new string Letters
		{
			get
			{
				return getLetters().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLetters16875;
		public virtual global::java.lang.CharSequence getLetters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.DialerFilter._getLetters16875)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getLetters16875)) as java.lang.CharSequence;
		}
		public new string Digits
		{
			get
			{
				return getDigits().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDigits16876;
		public virtual global::java.lang.CharSequence getDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.DialerFilter._getDigits16876)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getDigits16876)) as java.lang.CharSequence;
		}
		public new string FilterText
		{
			get
			{
				return getFilterText().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilterText16877;
		public virtual global::java.lang.CharSequence getFilterText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.DialerFilter._getFilterText16877)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getFilterText16877)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _clearText16878;
		public virtual void clearText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._clearText16878);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._clearText16878);
		}
		internal static global::MonoJavaBridge.MethodId _setLettersWatcher16879;
		public virtual void setLettersWatcher(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._setLettersWatcher16879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setLettersWatcher16879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDigitsWatcher16880;
		public virtual void setDigitsWatcher(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._setDigitsWatcher16880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setDigitsWatcher16880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterWatcher16881;
		public virtual void setFilterWatcher(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._setFilterWatcher16881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setFilterWatcher16881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeFilterWatcher16882;
		public virtual void removeFilterWatcher(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._removeFilterWatcher16882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._removeFilterWatcher16882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onModeChange16883;
		protected virtual void onModeChange(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._onModeChange16883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onModeChange16883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DialerFilter16884;
		public DialerFilter(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter16884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DialerFilter16885;
		public DialerFilter(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter16885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int DIGITS_AND_LETTERS
		{
			get
			{
				return 1;
			}
		}
		public static int DIGITS_AND_LETTERS_NO_DIGITS
		{
			get
			{
				return 2;
			}
		}
		public static int DIGITS_AND_LETTERS_NO_LETTERS
		{
			get
			{
				return 3;
			}
		}
		public static int DIGITS_ONLY
		{
			get
			{
				return 4;
			}
		}
		public static int LETTERS_ONLY
		{
			get
			{
				return 5;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.DialerFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DialerFilter"));
			global::android.widget.DialerFilter._append16867 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "append", "(Ljava/lang/String;)V");
			global::android.widget.DialerFilter._setMode16868 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setMode", "(I)V");
			global::android.widget.DialerFilter._getMode16869 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getMode", "()I");
			global::android.widget.DialerFilter._onKeyDown16870 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onKeyUp16871 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onFocusChanged16872 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.DialerFilter._onFinishInflate16873 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onFinishInflate", "()V");
			global::android.widget.DialerFilter._isQwertyKeyboard16874 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "isQwertyKeyboard", "()Z");
			global::android.widget.DialerFilter._getLetters16875 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getLetters", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getDigits16876 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getDigits", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getFilterText16877 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getFilterText", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._clearText16878 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "clearText", "()V");
			global::android.widget.DialerFilter._setLettersWatcher16879 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setLettersWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setDigitsWatcher16880 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setDigitsWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setFilterWatcher16881 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._removeFilterWatcher16882 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "removeFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._onModeChange16883 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onModeChange", "(II)V");
			global::android.widget.DialerFilter._DialerFilter16884 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.DialerFilter._DialerFilter16885 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
