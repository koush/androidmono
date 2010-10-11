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
			internal static global::MonoJavaBridge.MethodId _LayoutParams10697;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams10697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams10698;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams10698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams10699;
			public LayoutParams(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams10699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams10700;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams10700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$LayoutParams"));
				global::android.widget.AbsListView.LayoutParams._LayoutParams10697 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams10698 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams10699 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(III)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams10700 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AbsListView.OnScrollListener_))]
		public interface OnScrollListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onScroll10701;
			 void android.widget.AbsListView.OnScrollListener.onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_._onScroll10701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_.staticClass, global::android.widget.AbsListView.OnScrollListener_._onScroll10701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onScrollStateChanged10702;
			 void android.widget.AbsListView.OnScrollListener.onScrollStateChanged(android.widget.AbsListView arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged10702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_.staticClass, global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged10702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.OnScrollListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$OnScrollListener"));
				global::android.widget.AbsListView.OnScrollListener_._onScroll10701 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScroll", "(Landroid/widget/AbsListView;III)V");
				global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged10702 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
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
		public interface RecyclerListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onMovedToScrapHeap10703;
			 void android.widget.AbsListView.RecyclerListener.onMovedToScrapHeap(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap10703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.RecyclerListener_.staticClass, global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap10703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.RecyclerListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$RecyclerListener"));
				global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap10703 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.RecyclerListener_.staticClass, "onMovedToScrapHeap", "(Landroid/view/View;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _draw10704;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._draw10704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._draw10704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState10705;
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onRestoreInstanceState10705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onRestoreInstanceState10705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState10706;
		public virtual new global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._onSaveInstanceState10706)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSaveInstanceState10706)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown10707;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onKeyDown10707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyDown10707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp10708;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onKeyUp10708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyUp10708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent10709;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onTouchEvent10709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchEvent10709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged10710;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onWindowFocusChanged10710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onWindowFocusChanged10710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow10711;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onAttachedToWindow10711);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onAttachedToWindow10711);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow10712;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onDetachedFromWindow10712);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onDetachedFromWindow10712);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged10713;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onFocusChanged10713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFocusChanged10713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed10714;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._dispatchSetPressed10714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchSetPressed10714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables10715;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._addTouchables10715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._addTouchables10715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint10716;
		protected override void onDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onDisplayHint10716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onDisplayHint10716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection10717;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._onCreateInputConnection10717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateInputConnection10717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _checkInputConnectionProxy10718;
		public override bool checkInputConnectionProxy(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._checkInputConnectionProxy10718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkInputConnectionProxy10718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo10719;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getContextMenuInfo10719)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getContextMenuInfo10719)) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged10720;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onSizeChanged10720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSizeChanged10720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw10721;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._dispatchDraw10721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchDraw10721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect10722;
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._getFocusedRect10722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getFocusedRect10722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength10723;
		protected override float getTopFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.AbsListView._getTopFadingEdgeStrength10723);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTopFadingEdgeStrength10723);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength10724;
		protected override float getBottomFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.AbsListView._getBottomFadingEdgeStrength10724);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getBottomFadingEdgeStrength10724);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange10725;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._computeVerticalScrollRange10725);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollRange10725);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset10726;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._computeVerticalScrollOffset10726);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollOffset10726);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent10727;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._computeVerticalScrollExtent10727);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollExtent10727);
		}
		internal static global::MonoJavaBridge.MethodId _getSolidColor10728;
		public override int getSolidColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getSolidColor10728);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSolidColor10728);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout10729;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onLayout10729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onLayout10729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable10730;
		public virtual new bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._verifyDrawable10730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._verifyDrawable10730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged10731;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._drawableStateChanged10731);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._drawableStateChanged10731);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState10732;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._onCreateDrawableState10732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateDrawableState10732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout10733;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._requestLayout10733);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._requestLayout10733);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure10734;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onMeasure10734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onMeasure10734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild10735;
		public override bool showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._showContextMenuForChild10735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._showContextMenuForChild10735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent10736;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onInterceptTouchEvent10736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onInterceptTouchEvent10736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams10737;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._checkLayoutParams10737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkLayoutParams10737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams10738;
		public virtual new global::android.widget.AbsListView.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._generateLayoutParams10738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.AbsListView.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams10738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.AbsListView.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams10739;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._generateLayoutParams10739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams10739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView10740;
		public override global::android.view.View getSelectedView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getSelectedView10740)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelectedView10740)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged10741;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onTextChanged10741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTextChanged10741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _layoutChildren10742;
		protected virtual void layoutChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._layoutChildren10742);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._layoutChildren10742);
		}
		internal static global::MonoJavaBridge.MethodId _setCacheColorHint10743;
		public virtual void setCacheColorHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setCacheColorHint10743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setCacheColorHint10743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFastScrollEnabled10744;
		public virtual void setFastScrollEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setFastScrollEnabled10744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFastScrollEnabled10744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFastScrollEnabled10745;
		public virtual bool isFastScrollEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isFastScrollEnabled10745);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isFastScrollEnabled10745);
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollbarEnabled10746;
		public virtual void setSmoothScrollbarEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setSmoothScrollbarEnabled10746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSmoothScrollbarEnabled10746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollbarEnabled10747;
		public virtual bool isSmoothScrollbarEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isSmoothScrollbarEnabled10747);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isSmoothScrollbarEnabled10747);
		}
		internal static global::MonoJavaBridge.MethodId _setOnScrollListener10748;
		public virtual void setOnScrollListener(android.widget.AbsListView.OnScrollListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setOnScrollListener10748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setOnScrollListener10748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isScrollingCacheEnabled10749;
		public virtual bool isScrollingCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isScrollingCacheEnabled10749);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isScrollingCacheEnabled10749);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollingCacheEnabled10750;
		public virtual void setScrollingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setScrollingCacheEnabled10750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollingCacheEnabled10750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextFilterEnabled10751;
		public virtual void setTextFilterEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setTextFilterEnabled10751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTextFilterEnabled10751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTextFilterEnabled10752;
		public virtual bool isTextFilterEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isTextFilterEnabled10752);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isTextFilterEnabled10752);
		}
		internal static global::MonoJavaBridge.MethodId _isStackFromBottom10753;
		public virtual bool isStackFromBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isStackFromBottom10753);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isStackFromBottom10753);
		}
		internal static global::MonoJavaBridge.MethodId _setStackFromBottom10754;
		public virtual void setStackFromBottom(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setStackFromBottom10754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setStackFromBottom10754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterText10755;
		public virtual void setFilterText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setFilterText10755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFilterText10755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextFilter10756;
		public virtual global::java.lang.CharSequence getTextFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getTextFilter10756)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTextFilter10756)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingTop10757;
		public virtual int getListPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingTop10757);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingTop10757);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingBottom10758;
		public virtual int getListPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingBottom10758);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingBottom10758);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingLeft10759;
		public virtual int getListPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingLeft10759);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingLeft10759);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingRight10760;
		public virtual int getListPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingRight10760);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingRight10760);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawSelectorOnTop10761;
		public virtual void setDrawSelectorOnTop(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setDrawSelectorOnTop10761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setDrawSelectorOnTop10761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelector10762;
		public virtual void setSelector(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setSelector10762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector10762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelector10763;
		public virtual void setSelector(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setSelector10763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector10763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSelector10764;
		public virtual global::android.graphics.drawable.Drawable getSelector() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getSelector10764)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelector10764)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setScrollIndicators10765;
		public virtual void setScrollIndicators(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setScrollIndicators10765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollIndicators10765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToPosition10766;
		public virtual int pointToPosition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._pointToPosition10766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToPosition10766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToRowId10767;
		public virtual long pointToRowId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.AbsListView._pointToRowId10767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToRowId10767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchModeChanged10768;
		public virtual void onTouchModeChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onTouchModeChanged10768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchModeChanged10768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollToPosition10769;
		public virtual void smoothScrollToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._smoothScrollToPosition10769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollToPosition10769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollToPosition10770;
		public virtual void smoothScrollToPosition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._smoothScrollToPosition10770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollToPosition10770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy10771;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._smoothScrollBy10771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollBy10771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateViews10772;
		public virtual void invalidateViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._invalidateViews10772);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._invalidateViews10772);
		}
		internal static global::MonoJavaBridge.MethodId _handleDataChanged10773;
		protected virtual void handleDataChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._handleDataChanged10773);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._handleDataChanged10773);
		}
		internal static global::MonoJavaBridge.MethodId _isInFilterMode10774;
		protected virtual bool isInFilterMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isInFilterMode10774);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isInFilterMode10774);
		}
		internal static global::MonoJavaBridge.MethodId _clearTextFilter10775;
		public virtual void clearTextFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._clearTextFilter10775);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._clearTextFilter10775);
		}
		internal static global::MonoJavaBridge.MethodId _hasTextFilter10776;
		public virtual bool hasTextFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._hasTextFilter10776);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._hasTextFilter10776);
		}
		internal static global::MonoJavaBridge.MethodId _onGlobalLayout10777;
		public virtual void onGlobalLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onGlobalLayout10777);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onGlobalLayout10777);
		}
		internal static global::MonoJavaBridge.MethodId _beforeTextChanged10778;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._beforeTextChanged10778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._beforeTextChanged10778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _afterTextChanged10779;
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._afterTextChanged10779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._afterTextChanged10779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFilterComplete10780;
		public virtual void onFilterComplete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onFilterComplete10780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFilterComplete10780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTranscriptMode10781;
		public virtual void setTranscriptMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setTranscriptMode10781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTranscriptMode10781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTranscriptMode10782;
		public virtual int getTranscriptMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getTranscriptMode10782);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTranscriptMode10782);
		}
		internal static global::MonoJavaBridge.MethodId _getCacheColorHint10783;
		public virtual int getCacheColorHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getCacheColorHint10783);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getCacheColorHint10783);
		}
		internal static global::MonoJavaBridge.MethodId _reclaimViews10784;
		public virtual void reclaimViews(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._reclaimViews10784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._reclaimViews10784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRecyclerListener10785;
		public virtual void setRecyclerListener(android.widget.AbsListView.RecyclerListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setRecyclerListener10785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setRecyclerListener10785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView10786;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView10786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView10787;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView10787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView10788;
		public AbsListView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView10788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.AbsListView._draw10704 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._onRestoreInstanceState10705 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.AbsListView._onSaveInstanceState10706 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.AbsListView._onKeyDown10707 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onKeyUp10708 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onTouchEvent10709 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._onWindowFocusChanged10710 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.AbsListView._onAttachedToWindow10711 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AbsListView._onDetachedFromWindow10712 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AbsListView._onFocusChanged10713 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.AbsListView._dispatchSetPressed10714 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.widget.AbsListView._addTouchables10715 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.widget.AbsListView._onDisplayHint10716 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onDisplayHint", "(I)V");
			global::android.widget.AbsListView._onCreateInputConnection10717 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.AbsListView._checkInputConnectionProxy10718 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._getContextMenuInfo10719 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.widget.AbsListView._onSizeChanged10720 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AbsListView._dispatchDraw10721 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._getFocusedRect10722 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.AbsListView._getTopFadingEdgeStrength10723 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._getBottomFadingEdgeStrength10724 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._computeVerticalScrollRange10725 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.AbsListView._computeVerticalScrollOffset10726 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.AbsListView._computeVerticalScrollExtent10727 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.AbsListView._getSolidColor10728 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getSolidColor", "()I");
			global::android.widget.AbsListView._onLayout10729 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AbsListView._verifyDrawable10730 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.AbsListView._drawableStateChanged10731 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.AbsListView._onCreateDrawableState10732 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.AbsListView._requestLayout10733 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "requestLayout", "()V");
			global::android.widget.AbsListView._onMeasure10734 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsListView._showContextMenuForChild10735 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._onInterceptTouchEvent10736 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._checkLayoutParams10737 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.AbsListView._generateLayoutParams10738 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;");
			global::android.widget.AbsListView._generateLayoutParams10739 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsListView._getSelectedView10740 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AbsListView._onTextChanged10741 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._layoutChildren10742 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "layoutChildren", "()V");
			global::android.widget.AbsListView._setCacheColorHint10743 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.AbsListView._setFastScrollEnabled10744 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setFastScrollEnabled", "(Z)V");
			global::android.widget.AbsListView._isFastScrollEnabled10745 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isFastScrollEnabled", "()Z");
			global::android.widget.AbsListView._setSmoothScrollbarEnabled10746 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setSmoothScrollbarEnabled", "(Z)V");
			global::android.widget.AbsListView._isSmoothScrollbarEnabled10747 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isSmoothScrollbarEnabled", "()Z");
			global::android.widget.AbsListView._setOnScrollListener10748 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V");
			global::android.widget.AbsListView._isScrollingCacheEnabled10749 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isScrollingCacheEnabled", "()Z");
			global::android.widget.AbsListView._setScrollingCacheEnabled10750 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setScrollingCacheEnabled", "(Z)V");
			global::android.widget.AbsListView._setTextFilterEnabled10751 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setTextFilterEnabled", "(Z)V");
			global::android.widget.AbsListView._isTextFilterEnabled10752 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isTextFilterEnabled", "()Z");
			global::android.widget.AbsListView._isStackFromBottom10753 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isStackFromBottom", "()Z");
			global::android.widget.AbsListView._setStackFromBottom10754 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setStackFromBottom", "(Z)V");
			global::android.widget.AbsListView._setFilterText10755 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setFilterText", "(Ljava/lang/String;)V");
			global::android.widget.AbsListView._getTextFilter10756 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getTextFilter", "()Ljava/lang/CharSequence;");
			global::android.widget.AbsListView._getListPaddingTop10757 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingTop", "()I");
			global::android.widget.AbsListView._getListPaddingBottom10758 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingBottom", "()I");
			global::android.widget.AbsListView._getListPaddingLeft10759 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingLeft", "()I");
			global::android.widget.AbsListView._getListPaddingRight10760 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingRight", "()I");
			global::android.widget.AbsListView._setDrawSelectorOnTop10761 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setDrawSelectorOnTop", "(Z)V");
			global::android.widget.AbsListView._setSelector10762 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setSelector", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AbsListView._setSelector10763 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setSelector", "(I)V");
			global::android.widget.AbsListView._getSelector10764 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getSelector", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.AbsListView._setScrollIndicators10765 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.AbsListView._pointToPosition10766 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "pointToPosition", "(II)I");
			global::android.widget.AbsListView._pointToRowId10767 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "pointToRowId", "(II)J");
			global::android.widget.AbsListView._onTouchModeChanged10768 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onTouchModeChanged", "(Z)V");
			global::android.widget.AbsListView._smoothScrollToPosition10769 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(I)V");
			global::android.widget.AbsListView._smoothScrollToPosition10770 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(II)V");
			global::android.widget.AbsListView._smoothScrollBy10771 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.AbsListView._invalidateViews10772 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "invalidateViews", "()V");
			global::android.widget.AbsListView._handleDataChanged10773 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "handleDataChanged", "()V");
			global::android.widget.AbsListView._isInFilterMode10774 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isInFilterMode", "()Z");
			global::android.widget.AbsListView._clearTextFilter10775 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "clearTextFilter", "()V");
			global::android.widget.AbsListView._hasTextFilter10776 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "hasTextFilter", "()Z");
			global::android.widget.AbsListView._onGlobalLayout10777 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onGlobalLayout", "()V");
			global::android.widget.AbsListView._beforeTextChanged10778 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._afterTextChanged10779 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.widget.AbsListView._onFilterComplete10780 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onFilterComplete", "(I)V");
			global::android.widget.AbsListView._setTranscriptMode10781 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setTranscriptMode", "(I)V");
			global::android.widget.AbsListView._getTranscriptMode10782 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getTranscriptMode", "()I");
			global::android.widget.AbsListView._getCacheColorHint10783 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getCacheColorHint", "()I");
			global::android.widget.AbsListView._reclaimViews10784 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "reclaimViews", "(Ljava/util/List;)V");
			global::android.widget.AbsListView._setRecyclerListener10785 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V");
			global::android.widget.AbsListView._AbsListView10786 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsListView._AbsListView10787 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsListView._AbsListView10788 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;)V");
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
		internal static global::MonoJavaBridge.MethodId _setAdapter10789;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView_._setAdapter10789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView_.staticClass, global::android.widget.AbsListView_._setAdapter10789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter10790;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView_._getAdapter10790)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView_.staticClass, global::android.widget.AbsListView_._getAdapter10790)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection10791;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView_._setSelection10791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView_.staticClass, global::android.widget.AbsListView_._setSelection10791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsListView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView"));
			global::android.widget.AbsListView_._setAdapter10789 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView_.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AbsListView_._getAdapter10790 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView_.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AbsListView_._setSelection10791 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView_.staticClass, "setSelection", "(I)V");
		}
	}
}
