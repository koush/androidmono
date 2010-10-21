namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SlidingDrawer : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SlidingDrawer()
		{
			InitJNI();
		}
		protected SlidingDrawer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SlidingDrawer.OnDrawerCloseListener_))]
		public interface OnDrawerCloseListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDrawerClosed();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SlidingDrawer.OnDrawerCloseListener))]
		public sealed partial class OnDrawerCloseListener_ : java.lang.Object, OnDrawerCloseListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDrawerCloseListener_()
			{
				InitJNI();
			}
			internal OnDrawerCloseListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDrawerClosed17691;
			 void android.widget.SlidingDrawer.OnDrawerCloseListener.onDrawerClosed() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerCloseListener_._onDrawerClosed17691);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass, global::android.widget.SlidingDrawer.OnDrawerCloseListener_._onDrawerClosed17691);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerCloseListener"));
				global::android.widget.SlidingDrawer.OnDrawerCloseListener_._onDrawerClosed17691 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass, "onDrawerClosed", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SlidingDrawer.OnDrawerOpenListener_))]
		public interface OnDrawerOpenListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDrawerOpened();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SlidingDrawer.OnDrawerOpenListener))]
		public sealed partial class OnDrawerOpenListener_ : java.lang.Object, OnDrawerOpenListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDrawerOpenListener_()
			{
				InitJNI();
			}
			internal OnDrawerOpenListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onDrawerOpened17692;
			 void android.widget.SlidingDrawer.OnDrawerOpenListener.onDrawerOpened() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerOpenListener_._onDrawerOpened17692);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass, global::android.widget.SlidingDrawer.OnDrawerOpenListener_._onDrawerOpened17692);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerOpenListener"));
				global::android.widget.SlidingDrawer.OnDrawerOpenListener_._onDrawerOpened17692 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass, "onDrawerOpened", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.SlidingDrawer.OnDrawerScrollListener_))]
		public interface OnDrawerScrollListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onScrollStarted();
			void onScrollEnded();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.SlidingDrawer.OnDrawerScrollListener))]
		public sealed partial class OnDrawerScrollListener_ : java.lang.Object, OnDrawerScrollListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDrawerScrollListener_()
			{
				InitJNI();
			}
			internal OnDrawerScrollListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScrollStarted17693;
			 void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollStarted() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollStarted17693);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollStarted17693);
			}
			internal static global::MonoJavaBridge.MethodId _onScrollEnded17694;
			 void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollEnded() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollEnded17694);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollEnded17694);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerScrollListener"));
				global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollStarted17693 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, "onScrollStarted", "()V");
				global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollEnded17694 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, "onScrollEnded", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _lock17695;
		public virtual void @lock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._lock17695);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._lock17695);
		}
		internal static global::MonoJavaBridge.MethodId _close17696;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._close17696);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._close17696);
		}
		public new global::android.view.View Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent17697;
		public virtual global::android.view.View getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SlidingDrawer._getContent17697)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getContent17697)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _open17698;
		public virtual void open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._open17698);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._open17698);
		}
		internal static global::MonoJavaBridge.MethodId _unlock17699;
		public virtual void unlock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._unlock17699);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._unlock17699);
		}
		internal static global::MonoJavaBridge.MethodId _toggle17700;
		public virtual void toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._toggle17700);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._toggle17700);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17701;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onTouchEvent17701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onTouchEvent17701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw17702;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._dispatchDraw17702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._dispatchDraw17702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17703;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onLayout17703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onLayout17703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate17704;
		protected override void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onFinishInflate17704);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onFinishInflate17704);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17705;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onMeasure17705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onMeasure17705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent17706;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onInterceptTouchEvent17706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onInterceptTouchEvent17706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _animateToggle17707;
		public virtual void animateToggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._animateToggle17707);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateToggle17707);
		}
		internal static global::MonoJavaBridge.MethodId _animateClose17708;
		public virtual void animateClose() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._animateClose17708);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateClose17708);
		}
		internal static global::MonoJavaBridge.MethodId _animateOpen17709;
		public virtual void animateOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._animateOpen17709);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateOpen17709);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDrawerOpenListener17710;
		public virtual void setOnDrawerOpenListener(android.widget.SlidingDrawer.OnDrawerOpenListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._setOnDrawerOpenListener17710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerOpenListener17710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDrawerCloseListener17711;
		public virtual void setOnDrawerCloseListener(android.widget.SlidingDrawer.OnDrawerCloseListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._setOnDrawerCloseListener17711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerCloseListener17711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDrawerScrollListener17712;
		public virtual void setOnDrawerScrollListener(android.widget.SlidingDrawer.OnDrawerScrollListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._setOnDrawerScrollListener17712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerScrollListener17712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View Handle
		{
			get
			{
				return getHandle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHandle17713;
		public virtual global::android.view.View getHandle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SlidingDrawer._getHandle17713)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getHandle17713)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isOpened17714;
		public virtual bool isOpened() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer._isOpened17714);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isOpened17714);
		}
		internal static global::MonoJavaBridge.MethodId _isMoving17715;
		public virtual bool isMoving() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer._isMoving17715);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isMoving17715);
		}
		internal static global::MonoJavaBridge.MethodId _SlidingDrawer17716;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer17716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SlidingDrawer17717;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer17717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.SlidingDrawer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer"));
			global::android.widget.SlidingDrawer._lock17695 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "@lock", "()V");
			global::android.widget.SlidingDrawer._close17696 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "close", "()V");
			global::android.widget.SlidingDrawer._getContent17697 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "getContent", "()Landroid/view/View;");
			global::android.widget.SlidingDrawer._open17698 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "open", "()V");
			global::android.widget.SlidingDrawer._unlock17699 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "unlock", "()V");
			global::android.widget.SlidingDrawer._toggle17700 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "toggle", "()V");
			global::android.widget.SlidingDrawer._onTouchEvent17701 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.SlidingDrawer._dispatchDraw17702 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.SlidingDrawer._onLayout17703 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.SlidingDrawer._onFinishInflate17704 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onFinishInflate", "()V");
			global::android.widget.SlidingDrawer._onMeasure17705 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onMeasure", "(II)V");
			global::android.widget.SlidingDrawer._onInterceptTouchEvent17706 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.SlidingDrawer._animateToggle17707 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "animateToggle", "()V");
			global::android.widget.SlidingDrawer._animateClose17708 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "animateClose", "()V");
			global::android.widget.SlidingDrawer._animateOpen17709 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "animateOpen", "()V");
			global::android.widget.SlidingDrawer._setOnDrawerOpenListener17710 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V");
			global::android.widget.SlidingDrawer._setOnDrawerCloseListener17711 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V");
			global::android.widget.SlidingDrawer._setOnDrawerScrollListener17712 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V");
			global::android.widget.SlidingDrawer._getHandle17713 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "getHandle", "()Landroid/view/View;");
			global::android.widget.SlidingDrawer._isOpened17714 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "isOpened", "()Z");
			global::android.widget.SlidingDrawer._isMoving17715 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "isMoving", "()Z");
			global::android.widget.SlidingDrawer._SlidingDrawer17716 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.SlidingDrawer._SlidingDrawer17717 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
