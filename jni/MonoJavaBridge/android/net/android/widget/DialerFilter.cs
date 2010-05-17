namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DialerFilter : android.widget.RelativeLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DialerFilter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.DialerFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _append9378; 
		public virtual void append(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _append9378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _append9378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMode9379; 
		public virtual void setMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _setMode9379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _setMode9379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMode9380; 
		public virtual int getMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				return @__env.CallIntMethod(this, _getMode9380); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.DialerFilter.staticClass, _getMode9380); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown9381; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				return @__env.CallBooleanMethod(this, _onKeyDown9381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.DialerFilter.staticClass, _onKeyDown9381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp9382; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				return @__env.CallBooleanMethod(this, _onKeyUp9382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.DialerFilter.staticClass, _onKeyUp9382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged9383; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _onFocusChanged9383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _onFocusChanged9383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate9384; 
		protected override void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _onFinishInflate9384); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _onFinishInflate9384); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isQwertyKeyboard9385; 
		public virtual bool isQwertyKeyboard() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				return @__env.CallBooleanMethod(this, _isQwertyKeyboard9385); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.DialerFilter.staticClass, _isQwertyKeyboard9385); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLetters9386; 
		public virtual java.lang.CharSequence getLetters() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getLetters9386)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.DialerFilter.staticClass, _getLetters9386)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDigits9387; 
		public virtual java.lang.CharSequence getDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getDigits9387)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.DialerFilter.staticClass, _getDigits9387)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilterText9388; 
		public virtual java.lang.CharSequence getFilterText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getFilterText9388)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.DialerFilter.staticClass, _getFilterText9388)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearText9389; 
		public virtual void clearText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _clearText9389); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _clearText9389); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLettersWatcher9390; 
		public virtual void setLettersWatcher(android.text.TextWatcher arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _setLettersWatcher9390, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _setLettersWatcher9390, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDigitsWatcher9391; 
		public virtual void setDigitsWatcher(android.text.TextWatcher arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _setDigitsWatcher9391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _setDigitsWatcher9391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterWatcher9392; 
		public virtual void setFilterWatcher(android.text.TextWatcher arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _setFilterWatcher9392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _setFilterWatcher9392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeFilterWatcher9393; 
		public virtual void removeFilterWatcher(android.text.TextWatcher arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _removeFilterWatcher9393, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _removeFilterWatcher9393, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onModeChange9394; 
		protected virtual void onModeChange(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.DialerFilter)) 
				@__env.CallVoidMethod(this, _onModeChange9394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.DialerFilter.staticClass, _onModeChange9394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DialerFilter9395; 
		public DialerFilter(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.DialerFilter.staticClass, _DialerFilter9395, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DialerFilter9396; 
		public DialerFilter(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.DialerFilter.staticClass, _DialerFilter9396, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
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
			global::android.widget.DialerFilter._append9378 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "append", "(Ljava/lang/String;)V"); 
			global::android.widget.DialerFilter._setMode9379 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setMode", "(I)V"); 
			global::android.widget.DialerFilter._getMode9380 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getMode", "()I"); 
			global::android.widget.DialerFilter._onKeyDown9381 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.DialerFilter._onKeyUp9382 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.DialerFilter._onFocusChanged9383 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.widget.DialerFilter._onFinishInflate9384 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onFinishInflate", "()V"); 
			global::android.widget.DialerFilter._isQwertyKeyboard9385 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "isQwertyKeyboard", "()Z"); 
			global::android.widget.DialerFilter._getLetters9386 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getLetters", "()Ljava/lang/CharSequence;"); 
			global::android.widget.DialerFilter._getDigits9387 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getDigits", "()Ljava/lang/CharSequence;"); 
			global::android.widget.DialerFilter._getFilterText9388 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "getFilterText", "()Ljava/lang/CharSequence;"); 
			global::android.widget.DialerFilter._clearText9389 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "clearText", "()V"); 
			global::android.widget.DialerFilter._setLettersWatcher9390 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setLettersWatcher", "(Landroid/text/TextWatcher;)V"); 
			global::android.widget.DialerFilter._setDigitsWatcher9391 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setDigitsWatcher", "(Landroid/text/TextWatcher;)V"); 
			global::android.widget.DialerFilter._setFilterWatcher9392 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "setFilterWatcher", "(Landroid/text/TextWatcher;)V"); 
			global::android.widget.DialerFilter._removeFilterWatcher9393 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "removeFilterWatcher", "(Landroid/text/TextWatcher;)V"); 
			global::android.widget.DialerFilter._onModeChange9394 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "onModeChange", "(II)V"); 
			global::android.widget.DialerFilter._DialerFilter9395 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.DialerFilter._DialerFilter9396 = @__env.GetMethodID(global::android.widget.DialerFilter.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
