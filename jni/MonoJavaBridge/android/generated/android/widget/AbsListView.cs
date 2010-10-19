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
			internal static global::MonoJavaBridge.MethodId _LayoutParams11243;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams11243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11244;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams11244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11245;
			public LayoutParams(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams11245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11246;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams11246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$LayoutParams"));
				global::android.widget.AbsListView.LayoutParams._LayoutParams11243 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams11244 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams11245 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(III)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams11246 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
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
			internal static global::MonoJavaBridge.MethodId _onScroll11247;
			 void android.widget.AbsListView.OnScrollListener.onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_._onScroll11247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_.staticClass, global::android.widget.AbsListView.OnScrollListener_._onScroll11247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onScrollStateChanged11248;
			 void android.widget.AbsListView.OnScrollListener.onScrollStateChanged(android.widget.AbsListView arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged11248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.OnScrollListener_.staticClass, global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged11248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.OnScrollListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$OnScrollListener"));
				global::android.widget.AbsListView.OnScrollListener_._onScroll11247 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScroll", "(Landroid/widget/AbsListView;III)V");
				global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged11248 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
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
			internal static global::MonoJavaBridge.MethodId _onMovedToScrapHeap11249;
			 void android.widget.AbsListView.RecyclerListener.onMovedToScrapHeap(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap11249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.RecyclerListener_.staticClass, global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap11249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.RecyclerListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$RecyclerListener"));
				global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap11249 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.RecyclerListener_.staticClass, "onMovedToScrapHeap", "(Landroid/view/View;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _draw11250;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._draw11250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._draw11250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState11251;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onRestoreInstanceState11251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onRestoreInstanceState11251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState11252;
		public virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._onSaveInstanceState11252)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSaveInstanceState11252)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown11253;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onKeyDown11253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyDown11253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp11254;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onKeyUp11254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyUp11254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent11255;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onTouchEvent11255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchEvent11255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged11256;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onWindowFocusChanged11256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onWindowFocusChanged11256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow11257;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onAttachedToWindow11257);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onAttachedToWindow11257);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow11258;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onDetachedFromWindow11258);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onDetachedFromWindow11258);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged11259;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onFocusChanged11259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFocusChanged11259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed11260;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._dispatchSetPressed11260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchSetPressed11260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables11261;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._addTouchables11261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._addTouchables11261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint11262;
		protected override void onDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onDisplayHint11262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onDisplayHint11262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection11263;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._onCreateInputConnection11263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateInputConnection11263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _checkInputConnectionProxy11264;
		public override bool checkInputConnectionProxy(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._checkInputConnectionProxy11264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkInputConnectionProxy11264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo11265;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getContextMenuInfo11265)) as android.view.ContextMenu_ContextMenuInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ContextMenu_ContextMenuInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getContextMenuInfo11265)) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged11266;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onSizeChanged11266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSizeChanged11266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw11267;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._dispatchDraw11267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchDraw11267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect11268;
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._getFocusedRect11268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getFocusedRect11268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength11269;
		protected override float getTopFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.AbsListView._getTopFadingEdgeStrength11269);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTopFadingEdgeStrength11269);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength11270;
		protected override float getBottomFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.AbsListView._getBottomFadingEdgeStrength11270);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getBottomFadingEdgeStrength11270);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange11271;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._computeVerticalScrollRange11271);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollRange11271);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset11272;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._computeVerticalScrollOffset11272);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollOffset11272);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent11273;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._computeVerticalScrollExtent11273);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollExtent11273);
		}
		internal static global::MonoJavaBridge.MethodId _getSolidColor11274;
		public override int getSolidColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getSolidColor11274);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSolidColor11274);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout11275;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onLayout11275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onLayout11275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable11276;
		public virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._verifyDrawable11276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._verifyDrawable11276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged11277;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._drawableStateChanged11277);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._drawableStateChanged11277);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState11278;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._onCreateDrawableState11278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateDrawableState11278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout11279;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._requestLayout11279);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._requestLayout11279);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11280;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onMeasure11280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onMeasure11280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild11281;
		public override bool showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._showContextMenuForChild11281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._showContextMenuForChild11281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent11282;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._onInterceptTouchEvent11282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onInterceptTouchEvent11282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams11283;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._checkLayoutParams11283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkLayoutParams11283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams11284;
		public virtual global::android.widget.AbsListView.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._generateLayoutParams11284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.AbsListView.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams11284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.AbsListView.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams11285;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._generateLayoutParams11285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams11285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView11286;
		public override global::android.view.View getSelectedView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getSelectedView11286)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelectedView11286)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged11287;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onTextChanged11287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTextChanged11287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _layoutChildren11288;
		protected virtual void layoutChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._layoutChildren11288);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._layoutChildren11288);
		}
		internal static global::MonoJavaBridge.MethodId _setCacheColorHint11289;
		public virtual void setCacheColorHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setCacheColorHint11289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setCacheColorHint11289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFastScrollEnabled11290;
		public virtual void setFastScrollEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setFastScrollEnabled11290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFastScrollEnabled11290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFastScrollEnabled11291;
		public virtual bool isFastScrollEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isFastScrollEnabled11291);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isFastScrollEnabled11291);
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollbarEnabled11292;
		public virtual void setSmoothScrollbarEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setSmoothScrollbarEnabled11292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSmoothScrollbarEnabled11292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollbarEnabled11293;
		public virtual bool isSmoothScrollbarEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isSmoothScrollbarEnabled11293);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isSmoothScrollbarEnabled11293);
		}
		internal static global::MonoJavaBridge.MethodId _setOnScrollListener11294;
		public virtual void setOnScrollListener(android.widget.AbsListView.OnScrollListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setOnScrollListener11294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setOnScrollListener11294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isScrollingCacheEnabled11295;
		public virtual bool isScrollingCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isScrollingCacheEnabled11295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isScrollingCacheEnabled11295);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollingCacheEnabled11296;
		public virtual void setScrollingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setScrollingCacheEnabled11296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollingCacheEnabled11296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextFilterEnabled11297;
		public virtual void setTextFilterEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setTextFilterEnabled11297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTextFilterEnabled11297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTextFilterEnabled11298;
		public virtual bool isTextFilterEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isTextFilterEnabled11298);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isTextFilterEnabled11298);
		}
		internal static global::MonoJavaBridge.MethodId _isStackFromBottom11299;
		public virtual bool isStackFromBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isStackFromBottom11299);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isStackFromBottom11299);
		}
		internal static global::MonoJavaBridge.MethodId _setStackFromBottom11300;
		public virtual void setStackFromBottom(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setStackFromBottom11300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setStackFromBottom11300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterText11301;
		public virtual void setFilterText(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setFilterText11301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFilterText11301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextFilter11302;
		public virtual global::java.lang.CharSequence getTextFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getTextFilter11302)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTextFilter11302)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingTop11303;
		public virtual int getListPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingTop11303);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingTop11303);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingBottom11304;
		public virtual int getListPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingBottom11304);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingBottom11304);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingLeft11305;
		public virtual int getListPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingLeft11305);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingLeft11305);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingRight11306;
		public virtual int getListPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getListPaddingRight11306);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingRight11306);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawSelectorOnTop11307;
		public virtual void setDrawSelectorOnTop(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setDrawSelectorOnTop11307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setDrawSelectorOnTop11307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelector11308;
		public virtual void setSelector(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setSelector11308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector11308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelector11309;
		public virtual void setSelector(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setSelector11309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector11309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSelector11310;
		public virtual global::android.graphics.drawable.Drawable getSelector() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView._getSelector11310)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelector11310)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setScrollIndicators11311;
		public virtual void setScrollIndicators(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setScrollIndicators11311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollIndicators11311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToPosition11312;
		public virtual int pointToPosition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._pointToPosition11312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToPosition11312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToRowId11313;
		public virtual long pointToRowId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.AbsListView._pointToRowId11313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToRowId11313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchModeChanged11314;
		public virtual void onTouchModeChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onTouchModeChanged11314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchModeChanged11314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollToPosition11315;
		public virtual void smoothScrollToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._smoothScrollToPosition11315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollToPosition11315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollToPosition11316;
		public virtual void smoothScrollToPosition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._smoothScrollToPosition11316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollToPosition11316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy11317;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._smoothScrollBy11317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollBy11317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateViews11318;
		public virtual void invalidateViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._invalidateViews11318);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._invalidateViews11318);
		}
		internal static global::MonoJavaBridge.MethodId _handleDataChanged11319;
		protected virtual void handleDataChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._handleDataChanged11319);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._handleDataChanged11319);
		}
		internal static global::MonoJavaBridge.MethodId _isInFilterMode11320;
		protected virtual bool isInFilterMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._isInFilterMode11320);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isInFilterMode11320);
		}
		internal static global::MonoJavaBridge.MethodId _clearTextFilter11321;
		public virtual void clearTextFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._clearTextFilter11321);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._clearTextFilter11321);
		}
		internal static global::MonoJavaBridge.MethodId _hasTextFilter11322;
		public virtual bool hasTextFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsListView._hasTextFilter11322);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._hasTextFilter11322);
		}
		internal static global::MonoJavaBridge.MethodId _onGlobalLayout11323;
		public virtual void onGlobalLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onGlobalLayout11323);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onGlobalLayout11323);
		}
		internal static global::MonoJavaBridge.MethodId _beforeTextChanged11324;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._beforeTextChanged11324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._beforeTextChanged11324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _afterTextChanged11325;
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._afterTextChanged11325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._afterTextChanged11325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFilterComplete11326;
		public virtual void onFilterComplete(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._onFilterComplete11326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFilterComplete11326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTranscriptMode11327;
		public virtual void setTranscriptMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setTranscriptMode11327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTranscriptMode11327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTranscriptMode11328;
		public virtual int getTranscriptMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getTranscriptMode11328);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTranscriptMode11328);
		}
		internal static global::MonoJavaBridge.MethodId _getCacheColorHint11329;
		public virtual int getCacheColorHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.AbsListView._getCacheColorHint11329);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getCacheColorHint11329);
		}
		internal static global::MonoJavaBridge.MethodId _reclaimViews11330;
		public virtual void reclaimViews(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._reclaimViews11330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._reclaimViews11330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRecyclerListener11331;
		public virtual void setRecyclerListener(android.widget.AbsListView.RecyclerListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView._setRecyclerListener11331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setRecyclerListener11331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView11332;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView11332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView11333;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView11333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView11334;
		public AbsListView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView11334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.AbsListView._draw11250 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._onRestoreInstanceState11251 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.AbsListView._onSaveInstanceState11252 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.AbsListView._onKeyDown11253 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onKeyUp11254 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onTouchEvent11255 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._onWindowFocusChanged11256 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.AbsListView._onAttachedToWindow11257 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AbsListView._onDetachedFromWindow11258 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AbsListView._onFocusChanged11259 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.AbsListView._dispatchSetPressed11260 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.widget.AbsListView._addTouchables11261 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.widget.AbsListView._onDisplayHint11262 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onDisplayHint", "(I)V");
			global::android.widget.AbsListView._onCreateInputConnection11263 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.AbsListView._checkInputConnectionProxy11264 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._getContextMenuInfo11265 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.widget.AbsListView._onSizeChanged11266 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AbsListView._dispatchDraw11267 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._getFocusedRect11268 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.AbsListView._getTopFadingEdgeStrength11269 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._getBottomFadingEdgeStrength11270 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._computeVerticalScrollRange11271 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.AbsListView._computeVerticalScrollOffset11272 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.AbsListView._computeVerticalScrollExtent11273 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.AbsListView._getSolidColor11274 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getSolidColor", "()I");
			global::android.widget.AbsListView._onLayout11275 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AbsListView._verifyDrawable11276 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.AbsListView._drawableStateChanged11277 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.AbsListView._onCreateDrawableState11278 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.AbsListView._requestLayout11279 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "requestLayout", "()V");
			global::android.widget.AbsListView._onMeasure11280 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsListView._showContextMenuForChild11281 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._onInterceptTouchEvent11282 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._checkLayoutParams11283 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.AbsListView._generateLayoutParams11284 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;");
			global::android.widget.AbsListView._generateLayoutParams11285 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsListView._getSelectedView11286 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AbsListView._onTextChanged11287 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._layoutChildren11288 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "layoutChildren", "()V");
			global::android.widget.AbsListView._setCacheColorHint11289 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.AbsListView._setFastScrollEnabled11290 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setFastScrollEnabled", "(Z)V");
			global::android.widget.AbsListView._isFastScrollEnabled11291 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isFastScrollEnabled", "()Z");
			global::android.widget.AbsListView._setSmoothScrollbarEnabled11292 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setSmoothScrollbarEnabled", "(Z)V");
			global::android.widget.AbsListView._isSmoothScrollbarEnabled11293 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isSmoothScrollbarEnabled", "()Z");
			global::android.widget.AbsListView._setOnScrollListener11294 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V");
			global::android.widget.AbsListView._isScrollingCacheEnabled11295 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isScrollingCacheEnabled", "()Z");
			global::android.widget.AbsListView._setScrollingCacheEnabled11296 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setScrollingCacheEnabled", "(Z)V");
			global::android.widget.AbsListView._setTextFilterEnabled11297 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setTextFilterEnabled", "(Z)V");
			global::android.widget.AbsListView._isTextFilterEnabled11298 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isTextFilterEnabled", "()Z");
			global::android.widget.AbsListView._isStackFromBottom11299 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isStackFromBottom", "()Z");
			global::android.widget.AbsListView._setStackFromBottom11300 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setStackFromBottom", "(Z)V");
			global::android.widget.AbsListView._setFilterText11301 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setFilterText", "(Ljava/lang/String;)V");
			global::android.widget.AbsListView._getTextFilter11302 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getTextFilter", "()Ljava/lang/CharSequence;");
			global::android.widget.AbsListView._getListPaddingTop11303 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingTop", "()I");
			global::android.widget.AbsListView._getListPaddingBottom11304 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingBottom", "()I");
			global::android.widget.AbsListView._getListPaddingLeft11305 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingLeft", "()I");
			global::android.widget.AbsListView._getListPaddingRight11306 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getListPaddingRight", "()I");
			global::android.widget.AbsListView._setDrawSelectorOnTop11307 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setDrawSelectorOnTop", "(Z)V");
			global::android.widget.AbsListView._setSelector11308 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setSelector", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AbsListView._setSelector11309 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setSelector", "(I)V");
			global::android.widget.AbsListView._getSelector11310 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getSelector", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.AbsListView._setScrollIndicators11311 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.AbsListView._pointToPosition11312 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "pointToPosition", "(II)I");
			global::android.widget.AbsListView._pointToRowId11313 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "pointToRowId", "(II)J");
			global::android.widget.AbsListView._onTouchModeChanged11314 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onTouchModeChanged", "(Z)V");
			global::android.widget.AbsListView._smoothScrollToPosition11315 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(I)V");
			global::android.widget.AbsListView._smoothScrollToPosition11316 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(II)V");
			global::android.widget.AbsListView._smoothScrollBy11317 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.AbsListView._invalidateViews11318 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "invalidateViews", "()V");
			global::android.widget.AbsListView._handleDataChanged11319 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "handleDataChanged", "()V");
			global::android.widget.AbsListView._isInFilterMode11320 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "isInFilterMode", "()Z");
			global::android.widget.AbsListView._clearTextFilter11321 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "clearTextFilter", "()V");
			global::android.widget.AbsListView._hasTextFilter11322 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "hasTextFilter", "()Z");
			global::android.widget.AbsListView._onGlobalLayout11323 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onGlobalLayout", "()V");
			global::android.widget.AbsListView._beforeTextChanged11324 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._afterTextChanged11325 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.widget.AbsListView._onFilterComplete11326 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "onFilterComplete", "(I)V");
			global::android.widget.AbsListView._setTranscriptMode11327 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setTranscriptMode", "(I)V");
			global::android.widget.AbsListView._getTranscriptMode11328 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getTranscriptMode", "()I");
			global::android.widget.AbsListView._getCacheColorHint11329 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "getCacheColorHint", "()I");
			global::android.widget.AbsListView._reclaimViews11330 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "reclaimViews", "(Ljava/util/List;)V");
			global::android.widget.AbsListView._setRecyclerListener11331 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V");
			global::android.widget.AbsListView._AbsListView11332 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsListView._AbsListView11333 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsListView._AbsListView11334 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;)V");
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
		internal static global::MonoJavaBridge.MethodId _setAdapter11335;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView_._setAdapter11335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView_.staticClass, global::android.widget.AbsListView_._setAdapter11335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter11336;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsListView_._getAdapter11336)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsListView_.staticClass, global::android.widget.AbsListView_._getAdapter11336)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection11337;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsListView_._setSelection11337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsListView_.staticClass, global::android.widget.AbsListView_._setSelection11337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsListView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView"));
			global::android.widget.AbsListView_._setAdapter11335 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView_.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.AbsListView_._getAdapter11336 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView_.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.AbsListView_._setSelection11337 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView_.staticClass, "setSelection", "(I)V");
		}
	}
}
