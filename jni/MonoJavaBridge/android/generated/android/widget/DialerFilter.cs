namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DialerFilter : android.widget.RelativeLayout
	{
		internal new static global::java.lang.Class staticClass;
		static DialerFilter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.DialerFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.DialerFilter(@__env);
			}
		}
		protected DialerFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _append10097;
		public virtual void append(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._append10097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._append10097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMode10098;
		public virtual void setMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._setMode10098, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setMode10098, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMode10099;
		public virtual int getMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.DialerFilter._getMode10099);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getMode10099);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10100;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.DialerFilter._onKeyDown10100, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyDown10100, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10101;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.DialerFilter._onKeyUp10101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyUp10101, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged10102;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._onFocusChanged10102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFocusChanged10102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate10103;
		protected override void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._onFinishInflate10103);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFinishInflate10103);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isQwertyKeyboard10104;
		public virtual bool isQwertyKeyboard() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.DialerFilter._isQwertyKeyboard10104);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._isQwertyKeyboard10104);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLetters10105;
		public virtual global::java.lang.CharSequence getLetters() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.DialerFilter._getLetters10105));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getLetters10105));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDigits10106;
		public virtual global::java.lang.CharSequence getDigits() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.DialerFilter._getDigits10106));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getDigits10106));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilterText10107;
		public virtual global::java.lang.CharSequence getFilterText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.DialerFilter._getFilterText10107));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getFilterText10107));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearText10108;
		public virtual void clearText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._clearText10108);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._clearText10108);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLettersWatcher10109;
		public virtual void setLettersWatcher(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._setLettersWatcher10109, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setLettersWatcher10109, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDigitsWatcher10110;
		public virtual void setDigitsWatcher(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._setDigitsWatcher10110, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setDigitsWatcher10110, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterWatcher10111;
		public virtual void setFilterWatcher(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._setFilterWatcher10111, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setFilterWatcher10111, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeFilterWatcher10112;
		public virtual void removeFilterWatcher(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._removeFilterWatcher10112, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._removeFilterWatcher10112, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onModeChange10113;
		protected virtual void onModeChange(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._onModeChange10113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onModeChange10113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DialerFilter10114;
		public DialerFilter(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter10114, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DialerFilter10115;
		public DialerFilter(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter10115, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.DialerFilter.staticClass = @__class;
			global::android.widget.DialerFilter._append10097 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "append", "(Ljava/lang/String;)V");
			global::android.widget.DialerFilter._setMode10098 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setMode", "(I)V");
			global::android.widget.DialerFilter._getMode10099 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getMode", "()I");
			global::android.widget.DialerFilter._onKeyDown10100 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onKeyUp10101 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onFocusChanged10102 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.DialerFilter._onFinishInflate10103 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onFinishInflate", "()V");
			global::android.widget.DialerFilter._isQwertyKeyboard10104 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "isQwertyKeyboard", "()Z");
			global::android.widget.DialerFilter._getLetters10105 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getLetters", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getDigits10106 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getDigits", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getFilterText10107 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getFilterText", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._clearText10108 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "clearText", "()V");
			global::android.widget.DialerFilter._setLettersWatcher10109 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setLettersWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setDigitsWatcher10110 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setDigitsWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setFilterWatcher10111 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._removeFilterWatcher10112 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "removeFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._onModeChange10113 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onModeChange", "(II)V");
			global::android.widget.DialerFilter._DialerFilter10114 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.DialerFilter._DialerFilter10115 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
