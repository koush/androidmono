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
		internal static global::net.sf.jni4net.jni.MethodId _append10799;
		public virtual void append(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._append10799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._append10799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMode10800;
		public virtual void setMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._setMode10800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setMode10800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMode10801;
		public virtual int getMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.DialerFilter._getMode10801);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getMode10801);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10802;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.DialerFilter._onKeyDown10802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyDown10802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10803;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.DialerFilter._onKeyUp10803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onKeyUp10803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged10804;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._onFocusChanged10804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFocusChanged10804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate10805;
		protected override void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._onFinishInflate10805);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onFinishInflate10805);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isQwertyKeyboard10806;
		public virtual bool isQwertyKeyboard() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.DialerFilter._isQwertyKeyboard10806);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._isQwertyKeyboard10806);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLetters10807;
		public virtual global::java.lang.CharSequence getLetters() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.DialerFilter._getLetters10807));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getLetters10807));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDigits10808;
		public virtual global::java.lang.CharSequence getDigits() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.DialerFilter._getDigits10808));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getDigits10808));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilterText10809;
		public virtual global::java.lang.CharSequence getFilterText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.DialerFilter._getFilterText10809));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._getFilterText10809));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearText10810;
		public virtual void clearText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._clearText10810);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._clearText10810);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLettersWatcher10811;
		public virtual void setLettersWatcher(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._setLettersWatcher10811, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setLettersWatcher10811, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDigitsWatcher10812;
		public virtual void setDigitsWatcher(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._setDigitsWatcher10812, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setDigitsWatcher10812, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterWatcher10813;
		public virtual void setFilterWatcher(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._setFilterWatcher10813, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._setFilterWatcher10813, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeFilterWatcher10814;
		public virtual void removeFilterWatcher(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._removeFilterWatcher10814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._removeFilterWatcher10814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onModeChange10815;
		protected virtual void onModeChange(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DialerFilter._onModeChange10815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._onModeChange10815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DialerFilter10816;
		public DialerFilter(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter10816, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DialerFilter10817;
		public DialerFilter(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.DialerFilter.staticClass, global::android.widget.DialerFilter._DialerFilter10817, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
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
			global::android.widget.DialerFilter._append10799 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "append", "(Ljava/lang/String;)V");
			global::android.widget.DialerFilter._setMode10800 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setMode", "(I)V");
			global::android.widget.DialerFilter._getMode10801 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getMode", "()I");
			global::android.widget.DialerFilter._onKeyDown10802 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onKeyUp10803 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.DialerFilter._onFocusChanged10804 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.DialerFilter._onFinishInflate10805 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onFinishInflate", "()V");
			global::android.widget.DialerFilter._isQwertyKeyboard10806 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "isQwertyKeyboard", "()Z");
			global::android.widget.DialerFilter._getLetters10807 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getLetters", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getDigits10808 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getDigits", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._getFilterText10809 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getFilterText", "()Ljava/lang/CharSequence;");
			global::android.widget.DialerFilter._clearText10810 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "clearText", "()V");
			global::android.widget.DialerFilter._setLettersWatcher10811 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setLettersWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setDigitsWatcher10812 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setDigitsWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._setFilterWatcher10813 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._removeFilterWatcher10814 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "removeFilterWatcher", "(Landroid/text/TextWatcher;)V");
			global::android.widget.DialerFilter._onModeChange10815 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onModeChange", "(II)V");
			global::android.widget.DialerFilter._DialerFilter10816 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.DialerFilter._DialerFilter10817 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
