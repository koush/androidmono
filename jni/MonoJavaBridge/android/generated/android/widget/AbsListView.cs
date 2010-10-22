namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AbsListView_))]
	public abstract partial class AbsListView : android.widget.AdapterView, android.text.TextWatcher, android.view.ViewTreeObserver.OnGlobalLayoutListener, android.widget.Filter.FilterListener, android.view.ViewTreeObserver.OnTouchModeChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsListView()
		{
			InitJNI();
		}
		protected AbsListView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16376;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams16376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16377;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams16377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16378;
			public LayoutParams(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams16378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16379;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams16379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$LayoutParams"));
				global::android.widget.AbsListView.LayoutParams._LayoutParams16376 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams16377 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams16378 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(III)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams16379 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AbsListView.OnScrollListener_))]
		public partial interface OnScrollListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3);
			void onScrollStateChanged(android.widget.AbsListView arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsListView.OnScrollListener))]
		public sealed partial class OnScrollListener_ : java.lang.Object, OnScrollListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnScrollListener_()
			{
				InitJNI();
			}
			internal OnScrollListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScroll16380;
			 void android.widget.AbsListView.OnScrollListener.onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_._onScroll16380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_.staticClass, global::android.widget.AbsListView.OnScrollListener_._onScroll16380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onScrollStateChanged16381;
			 void android.widget.AbsListView.OnScrollListener.onScrollStateChanged(android.widget.AbsListView arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged16381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_.staticClass, global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged16381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.OnScrollListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$OnScrollListener"));
				global::android.widget.AbsListView.OnScrollListener_._onScroll16380 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScroll", "(Landroid/widget/AbsListView;III)V");
				global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged16381 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class OnScrollListenerConstants 
		{
			public static int SCROLL_STATE_IDLE
			{
				get
				{
					return 0;
				}
			}
			public static int SCROLL_STATE_TOUCH_SCROLL
			{
				get
				{
					return 1;
				}
			}
			public static int SCROLL_STATE_FLING
			{
				get
				{
					return 2;
				}
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AbsListView.RecyclerListener_))]
		public partial interface RecyclerListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onMovedToScrapHeap(android.view.View arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsListView.RecyclerListener))]
		public sealed partial class RecyclerListener_ : java.lang.Object, RecyclerListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RecyclerListener_()
			{
				InitJNI();
			}
			internal RecyclerListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onMovedToScrapHeap16385;
			 void android.widget.AbsListView.RecyclerListener.onMovedToScrapHeap(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap16385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.RecyclerListener_.staticClass, global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap16385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.RecyclerListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$RecyclerListener"));
				global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap16385 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.RecyclerListener_.staticClass, "onMovedToScrapHeap", "(Landroid/view/View;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _draw16386;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._draw16386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._draw16386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16387;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onRestoreInstanceState16387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onRestoreInstanceState16387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16388;
		public virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._onSaveInstanceState16388)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSaveInstanceState16388)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16389;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onKeyDown16389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyDown16389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp16390;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onKeyUp16390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyUp16390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent16391;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onTouchEvent16391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchEvent16391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged16392;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onWindowFocusChanged16392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onWindowFocusChanged16392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16393;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onAttachedToWindow16393);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onAttachedToWindow16393);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16394;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onDetachedFromWindow16394);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onDetachedFromWindow16394);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged16395;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onFocusChanged16395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFocusChanged16395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed16396;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._dispatchSetPressed16396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchSetPressed16396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables16397;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._addTouchables16397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._addTouchables16397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint16398;
		protected override void onDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onDisplayHint16398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onDisplayHint16398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection16399;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._onCreateInputConnection16399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateInputConnection16399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _checkInputConnectionProxy16400;
		public override bool checkInputConnectionProxy(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._checkInputConnectionProxy16400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkInputConnectionProxy16400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo16401;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getContextMenuInfo16401)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getContextMenuInfo16401)) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged16402;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onSizeChanged16402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSizeChanged16402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw16403;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._dispatchDraw16403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchDraw16403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect16404;
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._getFocusedRect16404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getFocusedRect16404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength16405;
		protected override float getTopFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.AbsListView._getTopFadingEdgeStrength16405);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTopFadingEdgeStrength16405);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength16406;
		protected override float getBottomFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.AbsListView._getBottomFadingEdgeStrength16406);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getBottomFadingEdgeStrength16406);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange16407;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._computeVerticalScrollRange16407);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollRange16407);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset16408;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._computeVerticalScrollOffset16408);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollOffset16408);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent16409;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._computeVerticalScrollExtent16409);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollExtent16409);
		}
		internal static global::MonoJavaBridge.MethodId _getSolidColor16410;
		public override int getSolidColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getSolidColor16410);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSolidColor16410);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout16411;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onLayout16411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onLayout16411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable16412;
		public virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._verifyDrawable16412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._verifyDrawable16412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16413;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._drawableStateChanged16413);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._drawableStateChanged16413);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState16414;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._onCreateDrawableState16414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateDrawableState16414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout16415;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._requestLayout16415);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._requestLayout16415);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16416;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onMeasure16416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onMeasure16416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild16417;
		public override bool showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._showContextMenuForChild16417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._showContextMenuForChild16417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent16418;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onInterceptTouchEvent16418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onInterceptTouchEvent16418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams16419;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._checkLayoutParams16419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkLayoutParams16419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams16420;
		public virtual global::android.widget.AbsListView.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._generateLayoutParams16420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.AbsListView.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams16420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.AbsListView.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams16421;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._generateLayoutParams16421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams16421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView16422;
		public override global::android.view.View getSelectedView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getSelectedView16422)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelectedView16422)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged16423;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onTextChanged16423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTextChanged16423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _layoutChildren16424;
		protected virtual void layoutChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._layoutChildren16424);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._layoutChildren16424);
		}
		internal static global::MonoJavaBridge.MethodId _setCacheColorHint16425;
		public virtual void setCacheColorHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setCacheColorHint16425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setCacheColorHint16425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFastScrollEnabled16426;
		public virtual void setFastScrollEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setFastScrollEnabled16426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFastScrollEnabled16426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFastScrollEnabled16427;
		public virtual bool isFastScrollEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isFastScrollEnabled16427);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isFastScrollEnabled16427);
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollbarEnabled16428;
		public virtual void setSmoothScrollbarEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setSmoothScrollbarEnabled16428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSmoothScrollbarEnabled16428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollbarEnabled16429;
		public virtual bool isSmoothScrollbarEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isSmoothScrollbarEnabled16429);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isSmoothScrollbarEnabled16429);
		}
		internal static global::MonoJavaBridge.MethodId _setOnScrollListener16430;
		public virtual void setOnScrollListener(android.widget.AbsListView.OnScrollListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setOnScrollListener16430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setOnScrollListener16430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isScrollingCacheEnabled16431;
		public virtual bool isScrollingCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isScrollingCacheEnabled16431);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isScrollingCacheEnabled16431);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollingCacheEnabled16432;
		public virtual void setScrollingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setScrollingCacheEnabled16432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollingCacheEnabled16432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextFilterEnabled16433;
		public virtual void setTextFilterEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setTextFilterEnabled16433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTextFilterEnabled16433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTextFilterEnabled16434;
		public virtual bool isTextFilterEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isTextFilterEnabled16434);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isTextFilterEnabled16434);
		}
		internal static global::MonoJavaBridge.MethodId _isStackFromBottom16435;
		public virtual bool isStackFromBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isStackFromBottom16435);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isStackFromBottom16435);
		}
		internal static global::MonoJavaBridge.MethodId _setStackFromBottom16436;
		public virtual void setStackFromBottom(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setStackFromBottom16436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setStackFromBottom16436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterText16437;
		public virtual void setFilterText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setFilterText16437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFilterText16437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextFilter16438;
		public virtual global::java.lang.CharSequence getTextFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getTextFilter16438)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTextFilter16438)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingTop16439;
		public virtual int getListPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingTop16439);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingTop16439);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingBottom16440;
		public virtual int getListPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingBottom16440);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingBottom16440);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingLeft16441;
		public virtual int getListPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingLeft16441);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingLeft16441);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingRight16442;
		public virtual int getListPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingRight16442);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingRight16442);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawSelectorOnTop16443;
		public virtual void setDrawSelectorOnTop(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setDrawSelectorOnTop16443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setDrawSelectorOnTop16443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelector16444;
		public virtual void setSelector(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setSelector16444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector16444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelector16445;
		public virtual void setSelector(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setSelector16445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector16445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSelector16446;
		public virtual global::android.graphics.drawable.Drawable getSelector() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getSelector16446)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelector16446)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setScrollIndicators16447;
		public virtual void setScrollIndicators(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setScrollIndicators16447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollIndicators16447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToPosition16448;
		public virtual int pointToPosition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._pointToPosition16448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToPosition16448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToRowId16449;
		public virtual long pointToRowId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.AbsListView._pointToRowId16449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToRowId16449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchModeChanged16450;
		public virtual void onTouchModeChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onTouchModeChanged16450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchModeChanged16450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollToPosition16451;
		public virtual void smoothScrollToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._smoothScrollToPosition16451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollToPosition16451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollToPosition16452;
		public virtual void smoothScrollToPosition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._smoothScrollToPosition16452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollToPosition16452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy16453;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._smoothScrollBy16453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollBy16453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateViews16454;
		public virtual void invalidateViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._invalidateViews16454);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._invalidateViews16454);
		}
		internal static global::MonoJavaBridge.MethodId _handleDataChanged16455;
		protected virtual void handleDataChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._handleDataChanged16455);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._handleDataChanged16455);
		}
		internal static global::MonoJavaBridge.MethodId _isInFilterMode16456;
		protected virtual bool isInFilterMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isInFilterMode16456);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isInFilterMode16456);
		}
		internal static global::MonoJavaBridge.MethodId _clearTextFilter16457;
		public virtual void clearTextFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._clearTextFilter16457);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._clearTextFilter16457);
		}
		internal static global::MonoJavaBridge.MethodId _hasTextFilter16458;
		public virtual bool hasTextFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._hasTextFilter16458);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._hasTextFilter16458);
		}
		internal static global::MonoJavaBridge.MethodId _onGlobalLayout16459;
		public virtual void onGlobalLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onGlobalLayout16459);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onGlobalLayout16459);
		}
		internal static global::MonoJavaBridge.MethodId _beforeTextChanged16460;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._beforeTextChanged16460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._beforeTextChanged16460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _afterTextChanged16461;
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._afterTextChanged16461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._afterTextChanged16461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFilterComplete16462;
		public virtual void onFilterComplete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onFilterComplete16462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFilterComplete16462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTranscriptMode16463;
		public virtual void setTranscriptMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setTranscriptMode16463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTranscriptMode16463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTranscriptMode16464;
		public virtual int getTranscriptMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getTranscriptMode16464);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTranscriptMode16464);
		}
		internal static global::MonoJavaBridge.MethodId _getCacheColorHint16465;
		public virtual int getCacheColorHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getCacheColorHint16465);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getCacheColorHint16465);
		}
		internal static global::MonoJavaBridge.MethodId _reclaimViews16466;
		public virtual void reclaimViews(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._reclaimViews16466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._reclaimViews16466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRecyclerListener16467;
		public virtual void setRecyclerListener(android.widget.AbsListView.RecyclerListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setRecyclerListener16467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setRecyclerListener16467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView16468;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView16468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView16469;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView16469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView16470;
		public AbsListView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView16470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int TRANSCRIPT_MODE_DISABLED
		{
			get
			{
				return 0;
			}
		}
		public static int TRANSCRIPT_MODE_NORMAL
		{
			get
			{
				return 1;
			}
		}
		public static int TRANSCRIPT_MODE_ALWAYS_SCROLL
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsListView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView"));
			global::android.widget.AbsListView._draw16386 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._onRestoreInstanceState16387 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.AbsListView._onSaveInstanceState16388 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.AbsListView._onKeyDown16389 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onKeyUp16390 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onTouchEvent16391 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._onWindowFocusChanged16392 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.AbsListView._onAttachedToWindow16393 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AbsListView._onDetachedFromWindow16394 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AbsListView._onFocusChanged16395 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.AbsListView._dispatchSetPressed16396 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.widget.AbsListView._addTouchables16397 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.widget.AbsListView._onDisplayHint16398 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onDisplayHint", "(I)V");
			global::android.widget.AbsListView._onCreateInputConnection16399 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.AbsListView._checkInputConnectionProxy16400 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._getContextMenuInfo16401 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.widget.AbsListView._onSizeChanged16402 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AbsListView._dispatchDraw16403 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._getFocusedRect16404 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.AbsListView._getTopFadingEdgeStrength16405 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._getBottomFadingEdgeStrength16406 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._computeVerticalScrollRange16407 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.AbsListView._computeVerticalScrollOffset16408 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.AbsListView._computeVerticalScrollExtent16409 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.AbsListView._getSolidColor16410 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getSolidColor", "()I");
			global::android.widget.AbsListView._onLayout16411 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AbsListView._verifyDrawable16412 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.AbsListView._drawableStateChanged16413 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.AbsListView._onCreateDrawableState16414 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.AbsListView._requestLayout16415 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "requestLayout", "()V");
			global::android.widget.AbsListView._onMeasure16416 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsListView._showContextMenuForChild16417 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._onInterceptTouchEvent16418 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._checkLayoutParams16419 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.AbsListView._generateLayoutParams16420 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;");
			global::android.widget.AbsListView._generateLayoutParams16421 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsListView._getSelectedView16422 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AbsListView._onTextChanged16423 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._layoutChildren16424 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "layoutChildren", "()V");
			global::android.widget.AbsListView._setCacheColorHint16425 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.AbsListView._setFastScrollEnabled16426 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setFastScrollEnabled", "(Z)V");
			global::android.widget.AbsListView._isFastScrollEnabled16427 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isFastScrollEnabled", "()Z");
			global::android.widget.AbsListView._setSmoothScrollbarEnabled16428 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setSmoothScrollbarEnabled", "(Z)V");
			global::android.widget.AbsListView._isSmoothScrollbarEnabled16429 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isSmoothScrollbarEnabled", "()Z");
			global::android.widget.AbsListView._setOnScrollListener16430 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V");
			global::android.widget.AbsListView._isScrollingCacheEnabled16431 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isScrollingCacheEnabled", "()Z");
			global::android.widget.AbsListView._setScrollingCacheEnabled16432 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setScrollingCacheEnabled", "(Z)V");
			global::android.widget.AbsListView._setTextFilterEnabled16433 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setTextFilterEnabled", "(Z)V");
			global::android.widget.AbsListView._isTextFilterEnabled16434 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isTextFilterEnabled", "()Z");
			global::android.widget.AbsListView._isStackFromBottom16435 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isStackFromBottom", "()Z");
			global::android.widget.AbsListView._setStackFromBottom16436 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setStackFromBottom", "(Z)V");
			global::android.widget.AbsListView._setFilterText16437 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setFilterText", "(Ljava/lang/String;)V");
			global::android.widget.AbsListView._getTextFilter16438 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getTextFilter", "()Ljava/lang/CharSequence;");
			global::android.widget.AbsListView._getListPaddingTop16439 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingTop", "()I");
			global::android.widget.AbsListView._getListPaddingBottom16440 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingBottom", "()I");
			global::android.widget.AbsListView._getListPaddingLeft16441 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingLeft", "()I");
			global::android.widget.AbsListView._getListPaddingRight16442 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingRight", "()I");
			global::android.widget.AbsListView._setDrawSelectorOnTop16443 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setDrawSelectorOnTop", "(Z)V");
			global::android.widget.AbsListView._setSelector16444 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setSelector", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AbsListView._setSelector16445 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setSelector", "(I)V");
			global::android.widget.AbsListView._getSelector16446 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getSelector", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.AbsListView._setScrollIndicators16447 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.AbsListView._pointToPosition16448 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "pointToPosition", "(II)I");
			global::android.widget.AbsListView._pointToRowId16449 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "pointToRowId", "(II)J");
			global::android.widget.AbsListView._onTouchModeChanged16450 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onTouchModeChanged", "(Z)V");
			global::android.widget.AbsListView._smoothScrollToPosition16451 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(I)V");
			global::android.widget.AbsListView._smoothScrollToPosition16452 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(II)V");
			global::android.widget.AbsListView._smoothScrollBy16453 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.AbsListView._invalidateViews16454 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "invalidateViews", "()V");
			global::android.widget.AbsListView._handleDataChanged16455 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "handleDataChanged", "()V");
			global::android.widget.AbsListView._isInFilterMode16456 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isInFilterMode", "()Z");
			global::android.widget.AbsListView._clearTextFilter16457 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "clearTextFilter", "()V");
			global::android.widget.AbsListView._hasTextFilter16458 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "hasTextFilter", "()Z");
			global::android.widget.AbsListView._onGlobalLayout16459 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onGlobalLayout", "()V");
			global::android.widget.AbsListView._beforeTextChanged16460 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._afterTextChanged16461 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.widget.AbsListView._onFilterComplete16462 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onFilterComplete", "(I)V");
			global::android.widget.AbsListView._setTranscriptMode16463 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setTranscriptMode", "(I)V");
			global::android.widget.AbsListView._getTranscriptMode16464 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getTranscriptMode", "()I");
			global::android.widget.AbsListView._getCacheColorHint16465 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getCacheColorHint", "()I");
			global::android.widget.AbsListView._reclaimViews16466 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "reclaimViews", "(Ljava/util/List;)V");
			global::android.widget.AbsListView._setRecyclerListener16467 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V");
			global::android.widget.AbsListView._AbsListView16468 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsListView._AbsListView16469 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsListView._AbsListView16470 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsListView))]
	public sealed partial class AbsListView_ : android.widget.AbsListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsListView_()
		{
			InitJNI();
		}
		internal AbsListView_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16474;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView_._setAdapter16474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView_.staticClass, global::android.widget.AbsListView_._setAdapter16474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter16475;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView_._getAdapter16475)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView_.staticClass, global::android.widget.AbsListView_._getAdapter16475)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16476;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView_._setSelection16476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView_.staticClass, global::android.widget.AbsListView_._setSelection16476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsListView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView"));
			global::android.widget.AbsListView_._setAdapter16474 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView_.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AbsListView_._getAdapter16475 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView_.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AbsListView_._setSelection16476 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView_.staticClass, "setSelection", "(I)V");
		}
	}
}
