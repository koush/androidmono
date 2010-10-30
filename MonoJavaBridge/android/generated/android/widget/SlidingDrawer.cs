namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SlidingDrawer : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SlidingDrawer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SlidingDrawer.OnDrawerCloseListener_))]
		public partial interface OnDrawerCloseListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDrawerClosed();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SlidingDrawer.OnDrawerCloseListener))]
		internal sealed partial class OnDrawerCloseListener_ : java.lang.Object, OnDrawerCloseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnDrawerCloseListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDrawerClosed17802;
			void android.widget.SlidingDrawer.OnDrawerCloseListener.onDrawerClosed()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SlidingDrawer.OnDrawerCloseListener_._onDrawerClosed17802.native == global::System.IntPtr.Zero)
					global::android.widget.SlidingDrawer.OnDrawerCloseListener_._onDrawerClosed17802 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass, "onDrawerClosed", "()V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerCloseListener_._onDrawerClosed17802);
			}
			static OnDrawerCloseListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerCloseListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnDrawerCloseListenerDelegate();

		internal partial class OnDrawerCloseListenerDelegateWrapper : java.lang.Object, OnDrawerCloseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnDrawerCloseListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnDrawerCloseListenerDelegateWrapper17803;
			public OnDrawerCloseListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper._OnDrawerCloseListenerDelegateWrapper17803.native == global::System.IntPtr.Zero)
					global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper._OnDrawerCloseListenerDelegateWrapper17803 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper.staticClass, global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper._OnDrawerCloseListenerDelegateWrapper17803);
				Init(@__env, handle);
			}
			static OnDrawerCloseListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer_OnDrawerCloseListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnDrawerCloseListenerDelegateWrapper
		{
			private OnDrawerCloseListenerDelegate myDelegate;
			public void onDrawerClosed()
			{
				myDelegate();
			}
			public static implicit operator OnDrawerCloseListenerDelegateWrapper(OnDrawerCloseListenerDelegate d)
			{
				global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper ret = new global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SlidingDrawer.OnDrawerOpenListener_))]
		public partial interface OnDrawerOpenListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDrawerOpened();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SlidingDrawer.OnDrawerOpenListener))]
		internal sealed partial class OnDrawerOpenListener_ : java.lang.Object, OnDrawerOpenListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnDrawerOpenListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDrawerOpened17804;
			void android.widget.SlidingDrawer.OnDrawerOpenListener.onDrawerOpened()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SlidingDrawer.OnDrawerOpenListener_._onDrawerOpened17804.native == global::System.IntPtr.Zero)
					global::android.widget.SlidingDrawer.OnDrawerOpenListener_._onDrawerOpened17804 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass, "onDrawerOpened", "()V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerOpenListener_._onDrawerOpened17804);
			}
			static OnDrawerOpenListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerOpenListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnDrawerOpenListenerDelegate();

		internal partial class OnDrawerOpenListenerDelegateWrapper : java.lang.Object, OnDrawerOpenListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnDrawerOpenListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnDrawerOpenListenerDelegateWrapper17805;
			public OnDrawerOpenListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper._OnDrawerOpenListenerDelegateWrapper17805.native == global::System.IntPtr.Zero)
					global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper._OnDrawerOpenListenerDelegateWrapper17805 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper.staticClass, global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper._OnDrawerOpenListenerDelegateWrapper17805);
				Init(@__env, handle);
			}
			static OnDrawerOpenListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer_OnDrawerOpenListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnDrawerOpenListenerDelegateWrapper
		{
			private OnDrawerOpenListenerDelegate myDelegate;
			public void onDrawerOpened()
			{
				myDelegate();
			}
			public static implicit operator OnDrawerOpenListenerDelegateWrapper(OnDrawerOpenListenerDelegate d)
			{
				global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper ret = new global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SlidingDrawer.OnDrawerScrollListener_))]
		public partial interface OnDrawerScrollListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onScrollStarted();
			void onScrollEnded();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SlidingDrawer.OnDrawerScrollListener))]
		internal sealed partial class OnDrawerScrollListener_ : java.lang.Object, OnDrawerScrollListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnDrawerScrollListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScrollStarted17806;
			void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollStarted()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollStarted17806.native == global::System.IntPtr.Zero)
					global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollStarted17806 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, "onScrollStarted", "()V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollStarted17806);
			}
			internal static global::MonoJavaBridge.MethodId _onScrollEnded17807;
			void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollEnded()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollEnded17807.native == global::System.IntPtr.Zero)
					global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollEnded17807 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, "onScrollEnded", "()V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollEnded17807);
			}
			static OnDrawerScrollListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerScrollListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _lock17808;
		public virtual void @lock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._lock17808.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._lock17808 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "@lock", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._lock17808);
		}
		internal static global::MonoJavaBridge.MethodId _close17809;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._close17809.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._close17809 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._close17809);
		}
		public new global::android.view.View Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent17810;
		public virtual global::android.view.View getContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._getContent17810.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._getContent17810 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "getContent", "()Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getContent17810) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _open17811;
		public virtual void open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._open17811.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._open17811 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "open", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._open17811);
		}
		internal static global::MonoJavaBridge.MethodId _unlock17812;
		public virtual void unlock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._unlock17812.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._unlock17812 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "unlock", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._unlock17812);
		}
		internal static global::MonoJavaBridge.MethodId _toggle17813;
		public virtual void toggle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._toggle17813.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._toggle17813 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "toggle", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._toggle17813);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17814;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._onTouchEvent17814.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._onTouchEvent17814 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onTouchEvent17814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw17815;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._dispatchDraw17815.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._dispatchDraw17815 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._dispatchDraw17815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17816;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._onLayout17816.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._onLayout17816 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onLayout", "(ZIIII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onLayout17816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate17817;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._onFinishInflate17817.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._onFinishInflate17817 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onFinishInflate", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onFinishInflate17817);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17818;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._onMeasure17818.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._onMeasure17818 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onMeasure", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onMeasure17818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent17819;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._onInterceptTouchEvent17819.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._onInterceptTouchEvent17819 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onInterceptTouchEvent17819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _animateToggle17820;
		public virtual void animateToggle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._animateToggle17820.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._animateToggle17820 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "animateToggle", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateToggle17820);
		}
		internal static global::MonoJavaBridge.MethodId _animateClose17821;
		public virtual void animateClose()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._animateClose17821.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._animateClose17821 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "animateClose", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateClose17821);
		}
		internal static global::MonoJavaBridge.MethodId _animateOpen17822;
		public virtual void animateOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._animateOpen17822.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._animateOpen17822 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "animateOpen", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateOpen17822);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDrawerOpenListener17823;
		public virtual void setOnDrawerOpenListener(android.widget.SlidingDrawer.OnDrawerOpenListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._setOnDrawerOpenListener17823.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._setOnDrawerOpenListener17823 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerOpenListener17823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnDrawerOpenListener(global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegate arg0)
		{
			setOnDrawerOpenListener((global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDrawerCloseListener17824;
		public virtual void setOnDrawerCloseListener(android.widget.SlidingDrawer.OnDrawerCloseListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._setOnDrawerCloseListener17824.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._setOnDrawerCloseListener17824 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerCloseListener17824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnDrawerCloseListener(global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegate arg0)
		{
			setOnDrawerCloseListener((global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDrawerScrollListener17825;
		public virtual void setOnDrawerScrollListener(android.widget.SlidingDrawer.OnDrawerScrollListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._setOnDrawerScrollListener17825.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._setOnDrawerScrollListener17825 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerScrollListener17825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View Handle
		{
			get
			{
				return getHandle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHandle17826;
		public virtual global::android.view.View getHandle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._getHandle17826.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._getHandle17826 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "getHandle", "()Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getHandle17826) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isOpened17827;
		public virtual bool isOpened()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._isOpened17827.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._isOpened17827 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "isOpened", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isOpened17827);
		}
		internal static global::MonoJavaBridge.MethodId _isMoving17828;
		public virtual bool isMoving()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._isMoving17828.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._isMoving17828 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "isMoving", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isMoving17828);
		}
		internal static global::MonoJavaBridge.MethodId _SlidingDrawer17829;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._SlidingDrawer17829.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._SlidingDrawer17829 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer17829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SlidingDrawer17830;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._SlidingDrawer17830.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._SlidingDrawer17830 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer17830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int ORIENTATION_HORIZONTAL
		{
			get
			{
				return 0;
			}
		}
		public static int ORIENTATION_VERTICAL
		{
			get
			{
				return 1;
			}
		}
		static SlidingDrawer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SlidingDrawer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
