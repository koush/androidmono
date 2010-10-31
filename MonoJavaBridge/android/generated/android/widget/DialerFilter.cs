namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DialerFilter : android.widget.RelativeLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialerFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void append(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "append", "(Ljava/lang/String;)V", ref global::android.widget.DialerFilter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "setMode", "(I)V", ref global::android.widget.DialerFilter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.DialerFilter.staticClass, "getMode", "()I", ref global::android.widget.DialerFilter._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.DialerFilter.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.DialerFilter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.DialerFilter.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.DialerFilter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.DialerFilter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "onFinishInflate", "()V", ref global::android.widget.DialerFilter._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isQwertyKeyboard()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.DialerFilter.staticClass, "isQwertyKeyboard", "()Z", ref global::android.widget.DialerFilter._m7);
		}
		public new string Letters
		{
			get
			{
				return getLetters().toString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.CharSequence getLetters()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.DialerFilter.staticClass, "getLetters", "()Ljava/lang/CharSequence;", ref global::android.widget.DialerFilter._m8) as java.lang.CharSequence;
		}
		public new string Digits
		{
			get
			{
				return getDigits().toString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.CharSequence getDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.DialerFilter.staticClass, "getDigits", "()Ljava/lang/CharSequence;", ref global::android.widget.DialerFilter._m9) as java.lang.CharSequence;
		}
		public new string FilterText
		{
			get
			{
				return getFilterText().toString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.CharSequence getFilterText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.DialerFilter.staticClass, "getFilterText", "()Ljava/lang/CharSequence;", ref global::android.widget.DialerFilter._m10) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void clearText()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "clearText", "()V", ref global::android.widget.DialerFilter._m11);
		}
		public new global::android.text.TextWatcher LettersWatcher
		{
			set
			{
				setLettersWatcher(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setLettersWatcher(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "setLettersWatcher", "(Landroid/text/TextWatcher;)V", ref global::android.widget.DialerFilter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.TextWatcher DigitsWatcher
		{
			set
			{
				setDigitsWatcher(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setDigitsWatcher(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "setDigitsWatcher", "(Landroid/text/TextWatcher;)V", ref global::android.widget.DialerFilter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.TextWatcher FilterWatcher
		{
			set
			{
				setFilterWatcher(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setFilterWatcher(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "setFilterWatcher", "(Landroid/text/TextWatcher;)V", ref global::android.widget.DialerFilter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void removeFilterWatcher(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "removeFilterWatcher", "(Landroid/text/TextWatcher;)V", ref global::android.widget.DialerFilter._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected virtual void onModeChange(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.DialerFilter.staticClass, "onModeChange", "(II)V", ref global::android.widget.DialerFilter._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public DialerFilter(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.DialerFilter._m17.native == global::System.IntPtr.Zero)
				global::android.widget.DialerFilter._m17 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public DialerFilter(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.DialerFilter._m18.native == global::System.IntPtr.Zero)
				global::android.widget.DialerFilter._m18 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		}
	}
}
