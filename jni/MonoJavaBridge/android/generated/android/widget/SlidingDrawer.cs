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
			internal static global::MonoJavaBridge.MethodId _onDrawerClosed12506;
			 void android.widget.SlidingDrawer.OnDrawerCloseListener.onDrawerClosed() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerCloseListener_._onDrawerClosed12506);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass, global::android.widget.SlidingDrawer.OnDrawerCloseListener_._onDrawerClosed12506);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerCloseListener"));
				global::android.widget.SlidingDrawer.OnDrawerCloseListener_._onDrawerClosed12506 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerCloseListener_.staticClass, "onDrawerClosed", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onDrawerOpened12507;
			 void android.widget.SlidingDrawer.OnDrawerOpenListener.onDrawerOpened() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerOpenListener_._onDrawerOpened12507);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass, global::android.widget.SlidingDrawer.OnDrawerOpenListener_._onDrawerOpened12507);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerOpenListener"));
				global::android.widget.SlidingDrawer.OnDrawerOpenListener_._onDrawerOpened12507 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerOpenListener_.staticClass, "onDrawerOpened", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onScrollStarted12508;
			 void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollStarted() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollStarted12508);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollStarted12508);
			}
			internal static global::MonoJavaBridge.MethodId _onScrollEnded12509;
			 void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollEnded() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollEnded12509);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollEnded12509);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/SlidingDrawer$OnDrawerScrollListener"));
				global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollStarted12508 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, "onScrollStarted", "()V");
				global::android.widget.SlidingDrawer.OnDrawerScrollListener_._onScrollEnded12509 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.OnDrawerScrollListener_.staticClass, "onScrollEnded", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _lock12510;
		public virtual void @lock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._lock12510);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._lock12510);
		}
		internal static global::MonoJavaBridge.MethodId _close12511;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._close12511);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._close12511);
		}
		public new global::android.view.View Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent12512;
		public virtual global::android.view.View getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SlidingDrawer._getContent12512)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getContent12512)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _open12513;
		public virtual void open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._open12513);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._open12513);
		}
		internal static global::MonoJavaBridge.MethodId _unlock12514;
		public virtual void unlock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._unlock12514);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._unlock12514);
		}
		internal static global::MonoJavaBridge.MethodId _toggle12515;
		public virtual void toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._toggle12515);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._toggle12515);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent12516;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onTouchEvent12516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onTouchEvent12516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw12517;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._dispatchDraw12517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._dispatchDraw12517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout12518;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onLayout12518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onLayout12518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate12519;
		protected override void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onFinishInflate12519);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onFinishInflate12519);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12520;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onMeasure12520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onMeasure12520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent12521;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer._onInterceptTouchEvent12521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onInterceptTouchEvent12521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _animateToggle12522;
		public virtual void animateToggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._animateToggle12522);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateToggle12522);
		}
		internal static global::MonoJavaBridge.MethodId _animateClose12523;
		public virtual void animateClose() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._animateClose12523);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateClose12523);
		}
		internal static global::MonoJavaBridge.MethodId _animateOpen12524;
		public virtual void animateOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._animateOpen12524);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateOpen12524);
		}
		internal static global::MonoJavaBridge.MethodId _setOnDrawerOpenListener12525;
		public virtual void setOnDrawerOpenListener(android.widget.SlidingDrawer.OnDrawerOpenListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._setOnDrawerOpenListener12525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerOpenListener12525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDrawerCloseListener12526;
		public virtual void setOnDrawerCloseListener(android.widget.SlidingDrawer.OnDrawerCloseListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._setOnDrawerCloseListener12526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerCloseListener12526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDrawerScrollListener12527;
		public virtual void setOnDrawerScrollListener(android.widget.SlidingDrawer.OnDrawerScrollListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer._setOnDrawerScrollListener12527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerScrollListener12527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View Handle
		{
			get
			{
				return getHandle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHandle12528;
		public virtual global::android.view.View getHandle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.SlidingDrawer._getHandle12528)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getHandle12528)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _isOpened12529;
		public virtual bool isOpened() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer._isOpened12529);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isOpened12529);
		}
		internal static global::MonoJavaBridge.MethodId _isMoving12530;
		public virtual bool isMoving() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer._isMoving12530);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isMoving12530);
		}
		internal static global::MonoJavaBridge.MethodId _SlidingDrawer12531;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer12531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SlidingDrawer12532;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer12532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::android.widget.SlidingDrawer._lock12510 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "@lock", "()V");
			global::android.widget.SlidingDrawer._close12511 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "close", "()V");
			global::android.widget.SlidingDrawer._getContent12512 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "getContent", "()Landroid/view/View;");
			global::android.widget.SlidingDrawer._open12513 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "open", "()V");
			global::android.widget.SlidingDrawer._unlock12514 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "unlock", "()V");
			global::android.widget.SlidingDrawer._toggle12515 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "toggle", "()V");
			global::android.widget.SlidingDrawer._onTouchEvent12516 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.SlidingDrawer._dispatchDraw12517 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.SlidingDrawer._onLayout12518 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.SlidingDrawer._onFinishInflate12519 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onFinishInflate", "()V");
			global::android.widget.SlidingDrawer._onMeasure12520 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onMeasure", "(II)V");
			global::android.widget.SlidingDrawer._onInterceptTouchEvent12521 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.SlidingDrawer._animateToggle12522 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "animateToggle", "()V");
			global::android.widget.SlidingDrawer._animateClose12523 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "animateClose", "()V");
			global::android.widget.SlidingDrawer._animateOpen12524 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "animateOpen", "()V");
			global::android.widget.SlidingDrawer._setOnDrawerOpenListener12525 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V");
			global::android.widget.SlidingDrawer._setOnDrawerCloseListener12526 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V");
			global::android.widget.SlidingDrawer._setOnDrawerScrollListener12527 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V");
			global::android.widget.SlidingDrawer._getHandle12528 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "getHandle", "()Landroid/view/View;");
			global::android.widget.SlidingDrawer._isOpened12529 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "isOpened", "()Z");
			global::android.widget.SlidingDrawer._isMoving12530 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "isMoving", "()Z");
			global::android.widget.SlidingDrawer._SlidingDrawer12531 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.SlidingDrawer._SlidingDrawer12532 = @__env.GetMethodIDNoThrow(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
