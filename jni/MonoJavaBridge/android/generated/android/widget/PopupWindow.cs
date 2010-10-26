namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PopupWindow : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PopupWindow()
		{
			InitJNI();
		}
		protected PopupWindow(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.PopupWindow.OnDismissListener_))]
		public partial interface OnDismissListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDismiss();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.PopupWindow.OnDismissListener))]
		internal sealed partial class OnDismissListener_ : java.lang.Object, OnDismissListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDismissListener_()
			{
				InitJNI();
			}
			internal OnDismissListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDismiss17439;
			 void android.widget.PopupWindow.OnDismissListener.onDismiss() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.OnDismissListener_._onDismiss17439);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.OnDismissListener_.staticClass, global::android.widget.PopupWindow.OnDismissListener_._onDismiss17439);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.PopupWindow.OnDismissListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow$OnDismissListener"));
				global::android.widget.PopupWindow.OnDismissListener_._onDismiss17439 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.OnDismissListener_.staticClass, "onDismiss", "()V");
			}
		}

		public delegate void OnDismissListenerDelegate();

		internal partial class OnDismissListenerDelegateWrapper : java.lang.Object, OnDismissListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDismissListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnDismissListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnDismissListenerDelegateWrapper17440;
			public OnDismissListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.OnDismissListenerDelegateWrapper.staticClass, global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper._OnDismissListenerDelegateWrapper17440);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow_OnDismissListenerDelegateWrapper"));
				global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper._OnDismissListenerDelegateWrapper17440 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnDismissListenerDelegateWrapper
		{
			private OnDismissListenerDelegate myDelegate;
			public void onDismiss()
			{
				myDelegate();
			}
			public static implicit operator OnDismissListenerDelegateWrapper(OnDismissListenerDelegate d)
			{
				global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper ret = new global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _update17441;
		public virtual void update(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _update17442;
		public virtual void update() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17442);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17442);
		}
		internal static global::MonoJavaBridge.MethodId _update17443;
		public virtual void update(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update17444;
		public virtual void update(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update17445;
		public virtual void update(int arg0, int arg1, int arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update17446;
		public virtual void update(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._update17446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._update17446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
			set
			{
				setWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth17447;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getWidth17447);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getWidth17447);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
			set
			{
				setHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight17448;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getHeight17448);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getHeight17448);
		}
		internal static global::MonoJavaBridge.MethodId _setContentView17449;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setContentView17449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setContentView17449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoftInputMode17450;
		public virtual void setSoftInputMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setSoftInputMode17450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setSoftInputMode17450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable17451;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setBackgroundDrawable17451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setBackgroundDrawable17451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable17452;
		public virtual void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setFocusable17452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setFocusable17452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFocusable17453;
		public virtual bool isFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isFocusable17453);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isFocusable17453);
		}
		public new global::android.graphics.drawable.Drawable Background
		{
			get
			{
				return getBackground();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBackground17454;
		public virtual global::android.graphics.drawable.Drawable getBackground() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.PopupWindow._getBackground17454)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getBackground17454)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _isShowing17455;
		public virtual bool isShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isShowing17455);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isShowing17455);
		}
		internal static global::MonoJavaBridge.MethodId _dismiss17456;
		public virtual void dismiss() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._dismiss17456);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._dismiss17456);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDismissListener17457;
		public virtual void setOnDismissListener(android.widget.PopupWindow.OnDismissListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setOnDismissListener17457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOnDismissListener17457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnDismissListener(global::android.widget.PopupWindow.OnDismissListenerDelegate arg0)
		{
			setOnDismissListener((global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHeight17458;
		public virtual void setHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setHeight17458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setHeight17458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWidth17459;
		public virtual void setWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setWidth17459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWidth17459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AnimationStyle
		{
			get
			{
				return getAnimationStyle();
			}
			set
			{
				setAnimationStyle(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnimationStyle17460;
		public virtual int getAnimationStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getAnimationStyle17460);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getAnimationStyle17460);
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoreCheekPress17461;
		public virtual void setIgnoreCheekPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setIgnoreCheekPress17461);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setIgnoreCheekPress17461);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationStyle17462;
		public virtual void setAnimationStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setAnimationStyle17462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setAnimationStyle17462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View ContentView
		{
			get
			{
				return getContentView();
			}
			set
			{
				setContentView(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentView17463;
		public virtual global::android.view.View getContentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.PopupWindow._getContentView17463)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getContentView17463)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setTouchInterceptor17464;
		public virtual void setTouchInterceptor(android.view.View.OnTouchListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setTouchInterceptor17464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchInterceptor17464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTouchInterceptor(global::android.view.View.OnTouchListenerDelegate arg0)
		{
			setTouchInterceptor((global::android.view.View.OnTouchListenerDelegateWrapper)arg0);
		}
		public new int InputMethodMode
		{
			get
			{
				return getInputMethodMode();
			}
			set
			{
				setInputMethodMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputMethodMode17465;
		public virtual int getInputMethodMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getInputMethodMode17465);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getInputMethodMode17465);
		}
		internal static global::MonoJavaBridge.MethodId _setInputMethodMode17466;
		public virtual void setInputMethodMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setInputMethodMode17466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setInputMethodMode17466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SoftInputMode
		{
			get
			{
				return getSoftInputMode();
			}
			set
			{
				setSoftInputMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSoftInputMode17467;
		public virtual int getSoftInputMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getSoftInputMode17467);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getSoftInputMode17467);
		}
		internal static global::MonoJavaBridge.MethodId _isTouchable17468;
		public virtual bool isTouchable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isTouchable17468);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isTouchable17468);
		}
		internal static global::MonoJavaBridge.MethodId _setTouchable17469;
		public virtual void setTouchable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setTouchable17469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setTouchable17469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isOutsideTouchable17470;
		public virtual bool isOutsideTouchable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isOutsideTouchable17470);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isOutsideTouchable17470);
		}
		internal static global::MonoJavaBridge.MethodId _setOutsideTouchable17471;
		public virtual void setOutsideTouchable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setOutsideTouchable17471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setOutsideTouchable17471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClippingEnabled17472;
		public virtual bool isClippingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isClippingEnabled17472);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isClippingEnabled17472);
		}
		internal static global::MonoJavaBridge.MethodId _setClippingEnabled17473;
		public virtual void setClippingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setClippingEnabled17473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setClippingEnabled17473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindowLayoutMode17474;
		public virtual void setWindowLayoutMode(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._setWindowLayoutMode17474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._setWindowLayoutMode17474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showAtLocation17475;
		public virtual void showAtLocation(android.view.View arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAtLocation17475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAtLocation17475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _showAsDropDown17476;
		public virtual void showAsDropDown(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAsDropDown17476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown17476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showAsDropDown17477;
		public virtual void showAsDropDown(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.PopupWindow._showAsDropDown17477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._showAsDropDown17477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isAboveAnchor17478;
		public virtual bool isAboveAnchor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow._isAboveAnchor17478);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._isAboveAnchor17478);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAvailableHeight17479;
		public virtual int getMaxAvailableHeight(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getMaxAvailableHeight17479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight17479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAvailableHeight17480;
		public virtual int getMaxAvailableHeight(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.PopupWindow._getMaxAvailableHeight17480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._getMaxAvailableHeight17480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17481;
		public PopupWindow(android.view.View arg0, int arg1, int arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17482;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17483;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17484;
		public PopupWindow()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17484);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17485;
		public PopupWindow(android.view.View arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17486;
		public PopupWindow(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17487;
		public PopupWindow(android.view.View arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PopupWindow17488;
		public PopupWindow(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._PopupWindow17488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int INPUT_METHOD_FROM_FOCUSABLE
		{
			get
			{
				return 0;
			}
		}
		public static int INPUT_METHOD_NEEDED
		{
			get
			{
				return 1;
			}
		}
		public static int INPUT_METHOD_NOT_NEEDED
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.PopupWindow.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow"));
			global::android.widget.PopupWindow._update17441 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(IIII)V");
			global::android.widget.PopupWindow._update17442 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "()V");
			global::android.widget.PopupWindow._update17443 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;IIII)V");
			global::android.widget.PopupWindow._update17444 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._update17445 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(IIIIZ)V");
			global::android.widget.PopupWindow._update17446 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "update", "(II)V");
			global::android.widget.PopupWindow._getWidth17447 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getWidth", "()I");
			global::android.widget.PopupWindow._getHeight17448 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getHeight", "()I");
			global::android.widget.PopupWindow._setContentView17449 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._setSoftInputMode17450 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setSoftInputMode", "(I)V");
			global::android.widget.PopupWindow._setBackgroundDrawable17451 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.PopupWindow._setFocusable17452 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setFocusable", "(Z)V");
			global::android.widget.PopupWindow._isFocusable17453 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isFocusable", "()Z");
			global::android.widget.PopupWindow._getBackground17454 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.PopupWindow._isShowing17455 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isShowing", "()Z");
			global::android.widget.PopupWindow._dismiss17456 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "dismiss", "()V");
			global::android.widget.PopupWindow._setOnDismissListener17457 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V");
			global::android.widget.PopupWindow._setHeight17458 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setHeight", "(I)V");
			global::android.widget.PopupWindow._setWidth17459 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setWidth", "(I)V");
			global::android.widget.PopupWindow._getAnimationStyle17460 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getAnimationStyle", "()I");
			global::android.widget.PopupWindow._setIgnoreCheekPress17461 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setIgnoreCheekPress", "()V");
			global::android.widget.PopupWindow._setAnimationStyle17462 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setAnimationStyle", "(I)V");
			global::android.widget.PopupWindow._getContentView17463 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getContentView", "()Landroid/view/View;");
			global::android.widget.PopupWindow._setTouchInterceptor17464 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V");
			global::android.widget.PopupWindow._getInputMethodMode17465 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getInputMethodMode", "()I");
			global::android.widget.PopupWindow._setInputMethodMode17466 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setInputMethodMode", "(I)V");
			global::android.widget.PopupWindow._getSoftInputMode17467 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getSoftInputMode", "()I");
			global::android.widget.PopupWindow._isTouchable17468 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isTouchable", "()Z");
			global::android.widget.PopupWindow._setTouchable17469 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setTouchable", "(Z)V");
			global::android.widget.PopupWindow._isOutsideTouchable17470 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isOutsideTouchable", "()Z");
			global::android.widget.PopupWindow._setOutsideTouchable17471 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setOutsideTouchable", "(Z)V");
			global::android.widget.PopupWindow._isClippingEnabled17472 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isClippingEnabled", "()Z");
			global::android.widget.PopupWindow._setClippingEnabled17473 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setClippingEnabled", "(Z)V");
			global::android.widget.PopupWindow._setWindowLayoutMode17474 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "setWindowLayoutMode", "(II)V");
			global::android.widget.PopupWindow._showAtLocation17475 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAtLocation", "(Landroid/view/View;III)V");
			global::android.widget.PopupWindow._showAsDropDown17476 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._showAsDropDown17477 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._isAboveAnchor17478 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "isAboveAnchor", "()Z");
			global::android.widget.PopupWindow._getMaxAvailableHeight17479 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;I)I");
			global::android.widget.PopupWindow._getMaxAvailableHeight17480 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;)I");
			global::android.widget.PopupWindow._PopupWindow17481 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;IIZ)V");
			global::android.widget.PopupWindow._PopupWindow17482 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.PopupWindow._PopupWindow17483 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.PopupWindow._PopupWindow17484 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "()V");
			global::android.widget.PopupWindow._PopupWindow17485 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;)V");
			global::android.widget.PopupWindow._PopupWindow17486 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(II)V");
			global::android.widget.PopupWindow._PopupWindow17487 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;II)V");
			global::android.widget.PopupWindow._PopupWindow17488 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
