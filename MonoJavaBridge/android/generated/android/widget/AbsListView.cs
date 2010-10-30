namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.AbsListView_))]
	public abstract partial class AbsListView : android.widget.AdapterView, android.text.TextWatcher, android.view.ViewTreeObserver.OnGlobalLayoutListener, android.widget.Filter.FilterListener, android.view.ViewTreeObserver.OnTouchModeChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbsListView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16467;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.LayoutParams._LayoutParams16467.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.LayoutParams._LayoutParams16467 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams16467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16468;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.LayoutParams._LayoutParams16468.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.LayoutParams._LayoutParams16468 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams16468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16469;
			public LayoutParams(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.LayoutParams._LayoutParams16469.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.LayoutParams._LayoutParams16469 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(III)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams16469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16470;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.LayoutParams._LayoutParams16470.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.LayoutParams._LayoutParams16470 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams16470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$LayoutParams"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.AbsListView.OnScrollListener_))]
		public partial interface OnScrollListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3);
			void onScrollStateChanged(android.widget.AbsListView arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsListView.OnScrollListener))]
		internal sealed partial class OnScrollListener_ : java.lang.Object, OnScrollListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnScrollListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScroll16471;
			void android.widget.AbsListView.OnScrollListener.onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScroll", "(Landroid/widget/AbsListView;III)V", ref global::android.widget.AbsListView.OnScrollListener_._onScroll16471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onScrollStateChanged16472;
			void android.widget.AbsListView.OnScrollListener.onScrollStateChanged(android.widget.AbsListView arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", ref global::android.widget.AbsListView.OnScrollListener_._onScrollStateChanged16472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnScrollListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.OnScrollListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$OnScrollListener"));
			}
			internal static void InitJNI()
			{
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
		internal sealed partial class RecyclerListener_ : java.lang.Object, RecyclerListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal RecyclerListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onMovedToScrapHeap16476;
			void android.widget.AbsListView.RecyclerListener.onMovedToScrapHeap(android.view.View arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.RecyclerListener_.staticClass, "onMovedToScrapHeap", "(Landroid/view/View;)V", ref global::android.widget.AbsListView.RecyclerListener_._onMovedToScrapHeap16476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static RecyclerListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.RecyclerListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$RecyclerListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void RecyclerListenerDelegate(android.view.View arg0);

		internal partial class RecyclerListenerDelegateWrapper : java.lang.Object, RecyclerListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected RecyclerListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _RecyclerListenerDelegateWrapper16477;
			public RecyclerListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.RecyclerListenerDelegateWrapper._RecyclerListenerDelegateWrapper16477.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.RecyclerListenerDelegateWrapper._RecyclerListenerDelegateWrapper16477 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.RecyclerListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.RecyclerListenerDelegateWrapper.staticClass, global::android.widget.AbsListView.RecyclerListenerDelegateWrapper._RecyclerListenerDelegateWrapper16477);
				Init(@__env, handle);
			}
			static RecyclerListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.RecyclerListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView_RecyclerListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class RecyclerListenerDelegateWrapper
		{
			private RecyclerListenerDelegate myDelegate;
			public void onMovedToScrapHeap(android.view.View arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator RecyclerListenerDelegateWrapper(RecyclerListenerDelegate d)
			{
				global::android.widget.AbsListView.RecyclerListenerDelegateWrapper ret = new global::android.widget.AbsListView.RecyclerListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _draw16478;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.AbsListView._draw16478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState16479;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.AbsListView._onRestoreInstanceState16479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState16480;
		public virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.AbsListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.AbsListView._onSaveInstanceState16480) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16481;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AbsListView._onKeyDown16481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp16482;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AbsListView._onKeyUp16482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent16483;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.AbsListView._onTouchEvent16483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged16484;
		public override void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.widget.AbsListView._onWindowFocusChanged16484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16485;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.AbsListView._onAttachedToWindow16485);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16486;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.AbsListView._onDetachedFromWindow16486);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged16487;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.AbsListView._onFocusChanged16487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed16488;
		protected override void dispatchSetPressed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "dispatchSetPressed", "(Z)V", ref global::android.widget.AbsListView._dispatchSetPressed16488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables16489;
		public override void addTouchables(java.util.ArrayList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V", ref global::android.widget.AbsListView._addTouchables16489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDisplayHint16490;
		protected override void onDisplayHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onDisplayHint", "(I)V", ref global::android.widget.AbsListView._onDisplayHint16490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection16491;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.inputmethod.InputConnection>(this, global::android.widget.AbsListView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;", ref global::android.widget.AbsListView._onCreateInputConnection16491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _checkInputConnectionProxy16492;
		public override bool checkInputConnectionProxy(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z", ref global::android.widget.AbsListView._checkInputConnectionProxy16492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContextMenuInfo16493;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu_ContextMenuInfo>(this, global::android.widget.AbsListView.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", ref global::android.widget.AbsListView._getContextMenuInfo16493) as android.view.ContextMenu_ContextMenuInfo;
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged16494;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.AbsListView._onSizeChanged16494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw16495;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.AbsListView._dispatchDraw16495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect16496;
		public override void getFocusedRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V", ref global::android.widget.AbsListView._getFocusedRect16496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength16497;
		protected override float getTopFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.AbsListView.staticClass, "getTopFadingEdgeStrength", "()F", ref global::android.widget.AbsListView._getTopFadingEdgeStrength16497);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength16498;
		protected override float getBottomFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.AbsListView.staticClass, "getBottomFadingEdgeStrength", "()F", ref global::android.widget.AbsListView._getBottomFadingEdgeStrength16498);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange16499;
		protected override int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "computeVerticalScrollRange", "()I", ref global::android.widget.AbsListView._computeVerticalScrollRange16499);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset16500;
		protected override int computeVerticalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "computeVerticalScrollOffset", "()I", ref global::android.widget.AbsListView._computeVerticalScrollOffset16500);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent16501;
		protected override int computeVerticalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "computeVerticalScrollExtent", "()I", ref global::android.widget.AbsListView._computeVerticalScrollExtent16501);
		}
		internal static global::MonoJavaBridge.MethodId _getSolidColor16502;
		public override int getSolidColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getSolidColor", "()I", ref global::android.widget.AbsListView._getSolidColor16502);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout16503;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.AbsListView._onLayout16503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable16504;
		public virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.AbsListView._verifyDrawable16504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16505;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "drawableStateChanged", "()V", ref global::android.widget.AbsListView._drawableStateChanged16505);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState16506;
		protected override int[] onCreateDrawableState(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.widget.AbsListView.staticClass, "onCreateDrawableState", "(I)[I", ref global::android.widget.AbsListView._onCreateDrawableState16506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout16507;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "requestLayout", "()V", ref global::android.widget.AbsListView._requestLayout16507);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16508;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onMeasure", "(II)V", ref global::android.widget.AbsListView._onMeasure16508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild16509;
		public override bool showContextMenuForChild(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z", ref global::android.widget.AbsListView._showContextMenuForChild16509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent16510;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.AbsListView._onInterceptTouchEvent16510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams16511;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.AbsListView._checkLayoutParams16511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams16512;
		public virtual global::android.widget.AbsListView.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;", ref global::android.widget.AbsListView._generateLayoutParams16512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.AbsListView.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams16513;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.AbsListView._generateLayoutParams16513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _getSelectedView16514;
		public override global::android.view.View getSelectedView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsListView.staticClass, "getSelectedView", "()Landroid/view/View;", ref global::android.widget.AbsListView._getSelectedView16514) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged16515;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.widget.AbsListView._onTextChanged16515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _layoutChildren16516;
		protected virtual void layoutChildren()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "layoutChildren", "()V", ref global::android.widget.AbsListView._layoutChildren16516);
		}
		internal static global::MonoJavaBridge.MethodId _setCacheColorHint16517;
		public virtual void setCacheColorHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setCacheColorHint", "(I)V", ref global::android.widget.AbsListView._setCacheColorHint16517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFastScrollEnabled16518;
		public virtual void setFastScrollEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setFastScrollEnabled", "(Z)V", ref global::android.widget.AbsListView._setFastScrollEnabled16518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFastScrollEnabled16519;
		public virtual bool isFastScrollEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isFastScrollEnabled", "()Z", ref global::android.widget.AbsListView._isFastScrollEnabled16519);
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollbarEnabled16520;
		public virtual void setSmoothScrollbarEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setSmoothScrollbarEnabled", "(Z)V", ref global::android.widget.AbsListView._setSmoothScrollbarEnabled16520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollbarEnabled16521;
		public virtual bool isSmoothScrollbarEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isSmoothScrollbarEnabled", "()Z", ref global::android.widget.AbsListView._isSmoothScrollbarEnabled16521);
		}
		internal static global::MonoJavaBridge.MethodId _setOnScrollListener16522;
		public virtual void setOnScrollListener(android.widget.AbsListView.OnScrollListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V", ref global::android.widget.AbsListView._setOnScrollListener16522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isScrollingCacheEnabled16523;
		public virtual bool isScrollingCacheEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isScrollingCacheEnabled", "()Z", ref global::android.widget.AbsListView._isScrollingCacheEnabled16523);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollingCacheEnabled16524;
		public virtual void setScrollingCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setScrollingCacheEnabled", "(Z)V", ref global::android.widget.AbsListView._setScrollingCacheEnabled16524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextFilterEnabled16525;
		public virtual void setTextFilterEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setTextFilterEnabled", "(Z)V", ref global::android.widget.AbsListView._setTextFilterEnabled16525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTextFilterEnabled16526;
		public virtual bool isTextFilterEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isTextFilterEnabled", "()Z", ref global::android.widget.AbsListView._isTextFilterEnabled16526);
		}
		internal static global::MonoJavaBridge.MethodId _isStackFromBottom16527;
		public virtual bool isStackFromBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isStackFromBottom", "()Z", ref global::android.widget.AbsListView._isStackFromBottom16527);
		}
		internal static global::MonoJavaBridge.MethodId _setStackFromBottom16528;
		public virtual void setStackFromBottom(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setStackFromBottom", "(Z)V", ref global::android.widget.AbsListView._setStackFromBottom16528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterText16529;
		public virtual void setFilterText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setFilterText", "(Ljava/lang/String;)V", ref global::android.widget.AbsListView._setFilterText16529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextFilter16530;
		public virtual global::java.lang.CharSequence getTextFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.AbsListView.staticClass, "getTextFilter", "()Ljava/lang/CharSequence;", ref global::android.widget.AbsListView._getTextFilter16530) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingTop16531;
		public virtual int getListPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getListPaddingTop", "()I", ref global::android.widget.AbsListView._getListPaddingTop16531);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingBottom16532;
		public virtual int getListPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getListPaddingBottom", "()I", ref global::android.widget.AbsListView._getListPaddingBottom16532);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingLeft16533;
		public virtual int getListPaddingLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getListPaddingLeft", "()I", ref global::android.widget.AbsListView._getListPaddingLeft16533);
		}
		internal static global::MonoJavaBridge.MethodId _getListPaddingRight16534;
		public virtual int getListPaddingRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getListPaddingRight", "()I", ref global::android.widget.AbsListView._getListPaddingRight16534);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawSelectorOnTop16535;
		public virtual void setDrawSelectorOnTop(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setDrawSelectorOnTop", "(Z)V", ref global::android.widget.AbsListView._setDrawSelectorOnTop16535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelector16536;
		public virtual void setSelector(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setSelector", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.AbsListView._setSelector16536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSelector16537;
		public virtual void setSelector(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setSelector", "(I)V", ref global::android.widget.AbsListView._setSelector16537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSelector16538;
		public virtual global::android.graphics.drawable.Drawable getSelector()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsListView.staticClass, "getSelector", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.AbsListView._getSelector16538) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setScrollIndicators16539;
		public virtual void setScrollIndicators(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.widget.AbsListView._setScrollIndicators16539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToPosition16540;
		public virtual int pointToPosition(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "pointToPosition", "(II)I", ref global::android.widget.AbsListView._pointToPosition16540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _pointToRowId16541;
		public virtual long pointToRowId(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.AbsListView.staticClass, "pointToRowId", "(II)J", ref global::android.widget.AbsListView._pointToRowId16541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchModeChanged16542;
		public virtual void onTouchModeChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onTouchModeChanged", "(Z)V", ref global::android.widget.AbsListView._onTouchModeChanged16542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollToPosition16543;
		public virtual void smoothScrollToPosition(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(I)V", ref global::android.widget.AbsListView._smoothScrollToPosition16543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollToPosition16544;
		public virtual void smoothScrollToPosition(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(II)V", ref global::android.widget.AbsListView._smoothScrollToPosition16544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy16545;
		public virtual void smoothScrollBy(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "smoothScrollBy", "(II)V", ref global::android.widget.AbsListView._smoothScrollBy16545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateViews16546;
		public virtual void invalidateViews()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "invalidateViews", "()V", ref global::android.widget.AbsListView._invalidateViews16546);
		}
		internal static global::MonoJavaBridge.MethodId _handleDataChanged16547;
		protected virtual void handleDataChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "handleDataChanged", "()V", ref global::android.widget.AbsListView._handleDataChanged16547);
		}
		internal static global::MonoJavaBridge.MethodId _isInFilterMode16548;
		protected virtual bool isInFilterMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isInFilterMode", "()Z", ref global::android.widget.AbsListView._isInFilterMode16548);
		}
		internal static global::MonoJavaBridge.MethodId _clearTextFilter16549;
		public virtual void clearTextFilter()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "clearTextFilter", "()V", ref global::android.widget.AbsListView._clearTextFilter16549);
		}
		internal static global::MonoJavaBridge.MethodId _hasTextFilter16550;
		public virtual bool hasTextFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "hasTextFilter", "()Z", ref global::android.widget.AbsListView._hasTextFilter16550);
		}
		internal static global::MonoJavaBridge.MethodId _onGlobalLayout16551;
		public virtual void onGlobalLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onGlobalLayout", "()V", ref global::android.widget.AbsListView._onGlobalLayout16551);
		}
		internal static global::MonoJavaBridge.MethodId _beforeTextChanged16552;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.widget.AbsListView._beforeTextChanged16552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _afterTextChanged16553;
		public virtual void afterTextChanged(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V", ref global::android.widget.AbsListView._afterTextChanged16553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFilterComplete16554;
		public virtual void onFilterComplete(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onFilterComplete", "(I)V", ref global::android.widget.AbsListView._onFilterComplete16554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTranscriptMode16555;
		public virtual void setTranscriptMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setTranscriptMode", "(I)V", ref global::android.widget.AbsListView._setTranscriptMode16555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTranscriptMode16556;
		public virtual int getTranscriptMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getTranscriptMode", "()I", ref global::android.widget.AbsListView._getTranscriptMode16556);
		}
		internal static global::MonoJavaBridge.MethodId _getCacheColorHint16557;
		public virtual int getCacheColorHint()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getCacheColorHint", "()I", ref global::android.widget.AbsListView._getCacheColorHint16557);
		}
		internal static global::MonoJavaBridge.MethodId _reclaimViews16558;
		public virtual void reclaimViews(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "reclaimViews", "(Ljava/util/List;)V", ref global::android.widget.AbsListView._reclaimViews16558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRecyclerListener16559;
		public virtual void setRecyclerListener(android.widget.AbsListView.RecyclerListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V", ref global::android.widget.AbsListView._setRecyclerListener16559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setRecyclerListener(global::android.widget.AbsListView.RecyclerListenerDelegate arg0)
		{
			setRecyclerListener((global::android.widget.AbsListView.RecyclerListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView16560;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsListView._AbsListView16560.native == global::System.IntPtr.Zero)
				global::android.widget.AbsListView._AbsListView16560 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView16560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView16561;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsListView._AbsListView16561.native == global::System.IntPtr.Zero)
				global::android.widget.AbsListView._AbsListView16561 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView16561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsListView16562;
		public AbsListView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsListView._AbsListView16562.native == global::System.IntPtr.Zero)
				global::android.widget.AbsListView._AbsListView16562 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView16562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		static AbsListView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsListView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsListView))]
	internal sealed partial class AbsListView_ : android.widget.AbsListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbsListView_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter16566;
		public override void setAdapter(android.widget.Adapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView_.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V", ref global::android.widget.AbsListView_._setAdapter16566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAdapter16567;
		public override global::android.widget.Adapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.Adapter>(this, global::android.widget.AbsListView_.staticClass, "getAdapter", "()Landroid/widget/Adapter;", ref global::android.widget.AbsListView_._getAdapter16567) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection16568;
		public override void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView_.staticClass, "setSelection", "(I)V", ref global::android.widget.AbsListView_._setSelection16568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AbsListView_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsListView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
