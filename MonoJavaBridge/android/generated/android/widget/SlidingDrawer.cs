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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.SlidingDrawer.OnDrawerCloseListener.onDrawerClosed()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass, "onDrawerClosed", "()V", ref global::android.widget.SlidingDrawer.OnDrawerCloseListener_._m0);
			}
			static OnDrawerCloseListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerCloseListener"));
			}
		}

		public delegate void OnDrawerCloseListenerDelegate();

		internal partial class OnDrawerCloseListenerDelegateWrapper : java.lang.Object, OnDrawerCloseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnDrawerCloseListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnDrawerCloseListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper.staticClass, global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnDrawerCloseListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer_OnDrawerCloseListenerDelegateWrapper"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.SlidingDrawer.OnDrawerOpenListener.onDrawerOpened()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass, "onDrawerOpened", "()V", ref global::android.widget.SlidingDrawer.OnDrawerOpenListener_._m0);
			}
			static OnDrawerOpenListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerOpenListener"));
			}
		}

		public delegate void OnDrawerOpenListenerDelegate();

		internal partial class OnDrawerOpenListenerDelegateWrapper : java.lang.Object, OnDrawerOpenListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnDrawerOpenListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnDrawerOpenListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper.staticClass, global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnDrawerOpenListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer_OnDrawerOpenListenerDelegateWrapper"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollStarted()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, "onScrollStarted", "()V", ref global::android.widget.SlidingDrawer.OnDrawerScrollListener_._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollEnded()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, "onScrollEnded", "()V", ref global::android.widget.SlidingDrawer.OnDrawerScrollListener_._m1);
			}
			static OnDrawerScrollListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerScrollListener"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void @lock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "@lock", "()V", ref global::android.widget.SlidingDrawer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "close", "()V", ref global::android.widget.SlidingDrawer._m1);
		}
		public new global::android.view.View Content
		{
			get
			{
				return getContent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.view.View getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SlidingDrawer.staticClass, "getContent", "()Landroid/view/View;", ref global::android.widget.SlidingDrawer._m2) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void open()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "open", "()V", ref global::android.widget.SlidingDrawer._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void unlock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "unlock", "()V", ref global::android.widget.SlidingDrawer._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void toggle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "toggle", "()V", ref global::android.widget.SlidingDrawer._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.SlidingDrawer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.SlidingDrawer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.SlidingDrawer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "onFinishInflate", "()V", ref global::android.widget.SlidingDrawer._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "onMeasure", "(II)V", ref global::android.widget.SlidingDrawer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.SlidingDrawer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void animateToggle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "animateToggle", "()V", ref global::android.widget.SlidingDrawer._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void animateClose()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "animateClose", "()V", ref global::android.widget.SlidingDrawer._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void animateOpen()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "animateOpen", "()V", ref global::android.widget.SlidingDrawer._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setOnDrawerOpenListener(android.widget.SlidingDrawer.OnDrawerOpenListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V", ref global::android.widget.SlidingDrawer._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnDrawerOpenListener(global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegate arg0)
		{
			setOnDrawerOpenListener((global::android.widget.SlidingDrawer.OnDrawerOpenListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setOnDrawerCloseListener(android.widget.SlidingDrawer.OnDrawerCloseListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V", ref global::android.widget.SlidingDrawer._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnDrawerCloseListener(global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegate arg0)
		{
			setOnDrawerCloseListener((global::android.widget.SlidingDrawer.OnDrawerCloseListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setOnDrawerScrollListener(android.widget.SlidingDrawer.OnDrawerScrollListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, "setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V", ref global::android.widget.SlidingDrawer._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View Handle
		{
			get
			{
				return getHandle();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::android.view.View getHandle()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.SlidingDrawer.staticClass, "getHandle", "()Landroid/view/View;", ref global::android.widget.SlidingDrawer._m18) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isOpened()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, "isOpened", "()Z", ref global::android.widget.SlidingDrawer._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isMoving()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, "isMoving", "()Z", ref global::android.widget.SlidingDrawer._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._m21.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._m21 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.SlidingDrawer._m22.native == global::System.IntPtr.Zero)
				global::android.widget.SlidingDrawer._m22 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
	}
}
