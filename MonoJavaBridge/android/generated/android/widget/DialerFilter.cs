namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DialerFilter : android.widget.RelativeLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialerFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _append16964;
		public virtual void append(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._append16964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMode16965;
		public virtual void setMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setMode16965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMode16966;
		public virtual int getMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getMode16966);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16967;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyDown16967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp16968;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyUp16968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged16969;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFocusChanged16969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate16970;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFinishInflate16970);
		}
		internal static global::MonoJavaBridge.MethodId _isQwertyKeyboard16971;
		public virtual bool isQwertyKeyboard()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._isQwertyKeyboard16971);
		}
		public new string Letters
		{
			get
			{
				return getLetters().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLetters16972;
		public virtual global::java.lang.CharSequence getLetters()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getLetters16972)) as java.lang.CharSequence;
		}
		public new string Digits
		{
			get
			{
				return getDigits().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDigits16973;
		public virtual global::java.lang.CharSequence getDigits()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getDigits16973)) as java.lang.CharSequence;
		}
		public new string FilterText
		{
			get
			{
				return getFilterText().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilterText16974;
		public virtual global::java.lang.CharSequence getFilterText()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getFilterText16974)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _clearText16975;
		public virtual void clearText()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._clearText16975);
		}
		public new global::android.text.TextWatcher LettersWatcher
		{
			set
			{
				setLettersWatcher(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLettersWatcher16976;
		public virtual void setLettersWatcher(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setLettersWatcher16976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.TextWatcher DigitsWatcher
		{
			set
			{
				setDigitsWatcher(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDigitsWatcher16977;
		public virtual void setDigitsWatcher(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setDigitsWatcher16977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.TextWatcher FilterWatcher
		{
			set
			{
				setFilterWatcher(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFilterWatcher16978;
		public virtual void setFilterWatcher(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setFilterWatcher16978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeFilterWatcher16979;
		public virtual void removeFilterWatcher(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._removeFilterWatcher16979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onModeChange16980;
		protected virtual void onModeChange(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onModeChange16980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DialerFilter16981;
		public DialerFilter(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter16981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DialerFilter16982;
		public DialerFilter(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter16982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		static DialerFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.DialerFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/DialerFilter"));
			global::android.widget.DialerFilter._append16964 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "append", "(Ljava/lang/String;)V");
			global::android.widget.DialerFilter._setMode16965 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setMode", "(I)V");
			global::android.widget.DialerFilter._getMode16966 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getMode", "()I");
			global::android.widget.DialerFilter._onKeyDown16967 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onKeyUp16968 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onFocusChanged16969 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.DialerFilter._onFinishInflate16970 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onFinishInflate", "()V");
			global::android.widget.DialerFilter._isQwertyKeyboard16971 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "isQwertyKeyboard", "()Z");
			global::android.widget.DialerFilter._getLetters16972 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getLetters", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getDigits16973 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getDigits", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getFilterText16974 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getFilterText", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._clearText16975 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "clearText", "()V");
			global::android.widget.DialerFilter._setLettersWatcher16976 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setLettersWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setDigitsWatcher16977 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setDigitsWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setFilterWatcher16978 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._removeFilterWatcher16979 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "removeFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._onModeChange16980 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onModeChange", "(II)V");
			global::android.widget.DialerFilter._DialerFilter16981 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.DialerFilter._DialerFilter16982 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
