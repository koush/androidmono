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
		internal static global::MonoJavaBridge.MethodId _append11722;
		public virtual void append(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._append11722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._append11722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMode11723;
		public virtual void setMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._setMode11723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setMode11723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMode11724;
		public virtual int getMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.DialerFilter._getMode11724);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getMode11724);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown11725;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter._onKeyDown11725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyDown11725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp11726;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter._onKeyUp11726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyUp11726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged11727;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._onFocusChanged11727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFocusChanged11727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate11728;
		protected override void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._onFinishInflate11728);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFinishInflate11728);
		}
		internal static global::MonoJavaBridge.MethodId _isQwertyKeyboard11729;
		public virtual bool isQwertyKeyboard() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter._isQwertyKeyboard11729);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._isQwertyKeyboard11729);
		}
		public new string Letters
		{
			get
			{
				return getLetters().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLetters11730;
		public virtual global::java.lang.CharSequence getLetters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.DialerFilter._getLetters11730)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getLetters11730)) as java.lang.CharSequence;
		}
		public new string Digits
		{
			get
			{
				return getDigits().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDigits11731;
		public virtual global::java.lang.CharSequence getDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.DialerFilter._getDigits11731)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getDigits11731)) as java.lang.CharSequence;
		}
		public new string FilterText
		{
			get
			{
				return getFilterText().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilterText11732;
		public virtual global::java.lang.CharSequence getFilterText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.DialerFilter._getFilterText11732)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getFilterText11732)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _clearText11733;
		public virtual void clearText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._clearText11733);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._clearText11733);
		}
		internal static global::MonoJavaBridge.MethodId _setLettersWatcher11734;
		public virtual void setLettersWatcher(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._setLettersWatcher11734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setLettersWatcher11734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDigitsWatcher11735;
		public virtual void setDigitsWatcher(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._setDigitsWatcher11735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setDigitsWatcher11735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterWatcher11736;
		public virtual void setFilterWatcher(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._setFilterWatcher11736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setFilterWatcher11736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeFilterWatcher11737;
		public virtual void removeFilterWatcher(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._removeFilterWatcher11737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._removeFilterWatcher11737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onModeChange11738;
		protected virtual void onModeChange(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.DialerFilter._onModeChange11738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onModeChange11738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DialerFilter11739;
		public DialerFilter(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter11739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DialerFilter11740;
		public DialerFilter(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter11740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::android.widget.DialerFilter._append11722 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "append", "(Ljava/lang/String;)V");
			global::android.widget.DialerFilter._setMode11723 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setMode", "(I)V");
			global::android.widget.DialerFilter._getMode11724 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getMode", "()I");
			global::android.widget.DialerFilter._onKeyDown11725 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onKeyUp11726 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onFocusChanged11727 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.DialerFilter._onFinishInflate11728 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onFinishInflate", "()V");
			global::android.widget.DialerFilter._isQwertyKeyboard11729 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "isQwertyKeyboard", "()Z");
			global::android.widget.DialerFilter._getLetters11730 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getLetters", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getDigits11731 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getDigits", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getFilterText11732 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "getFilterText", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._clearText11733 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "clearText", "()V");
			global::android.widget.DialerFilter._setLettersWatcher11734 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setLettersWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setDigitsWatcher11735 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setDigitsWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setFilterWatcher11736 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "setFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._removeFilterWatcher11737 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "removeFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._onModeChange11738 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "onModeChange", "(II)V");
			global::android.widget.DialerFilter._DialerFilter11739 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.DialerFilter._DialerFilter11740 = @__env.GetMethodIDNoThrow(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
