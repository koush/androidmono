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
			private static global::MonoJavaBridge.MethodId _m0;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.LayoutParams._m0.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.LayoutParams._m0 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.LayoutParams._m1.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.LayoutParams._m1 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public LayoutParams(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.LayoutParams._m2.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.LayoutParams._m2 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(III)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.LayoutParams._m3.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.LayoutParams._m3 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$LayoutParams"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.AbsListView.OnScrollListener.onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScroll", "(Landroid/widget/AbsListView;III)V", ref global::android.widget.AbsListView.OnScrollListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.widget.AbsListView.OnScrollListener.onScrollStateChanged(android.widget.AbsListView arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.OnScrollListener_.staticClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", ref global::android.widget.AbsListView.OnScrollListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnScrollListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.OnScrollListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$OnScrollListener"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.AbsListView.RecyclerListener.onMovedToScrapHeap(android.view.View arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.RecyclerListener_.staticClass, "onMovedToScrapHeap", "(Landroid/view/View;)V", ref global::android.widget.AbsListView.RecyclerListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static RecyclerListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.RecyclerListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView$RecyclerListener"));
			}
		}

		public delegate void RecyclerListenerDelegate(android.view.View arg0);

		internal partial class RecyclerListenerDelegateWrapper : java.lang.Object, RecyclerListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected RecyclerListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public RecyclerListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsListView.RecyclerListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.AbsListView.RecyclerListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.RecyclerListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.RecyclerListenerDelegateWrapper.staticClass, global::android.widget.AbsListView.RecyclerListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static RecyclerListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsListView.RecyclerListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView_RecyclerListenerDelegateWrapper"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.AbsListView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.AbsListView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.AbsListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.AbsListView._m2) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AbsListView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.AbsListView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.AbsListView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.widget.AbsListView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.AbsListView._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.AbsListView._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.AbsListView._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override void dispatchSetPressed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "dispatchSetPressed", "(Z)V", ref global::android.widget.AbsListView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override void addTouchables(java.util.ArrayList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V", ref global::android.widget.AbsListView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected override void onDisplayHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onDisplayHint", "(I)V", ref global::android.widget.AbsListView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.inputmethod.InputConnection>(this, global::android.widget.AbsListView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;", ref global::android.widget.AbsListView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.inputmethod.InputConnection;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override bool checkInputConnectionProxy(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z", ref global::android.widget.AbsListView._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu_ContextMenuInfo>(this, global::android.widget.AbsListView.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", ref global::android.widget.AbsListView._m15) as android.view.ContextMenu_ContextMenuInfo;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.AbsListView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.AbsListView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override void getFocusedRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V", ref global::android.widget.AbsListView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected override float getTopFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.AbsListView.staticClass, "getTopFadingEdgeStrength", "()F", ref global::android.widget.AbsListView._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected override float getBottomFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.AbsListView.staticClass, "getBottomFadingEdgeStrength", "()F", ref global::android.widget.AbsListView._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		protected override int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "computeVerticalScrollRange", "()I", ref global::android.widget.AbsListView._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected override int computeVerticalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "computeVerticalScrollOffset", "()I", ref global::android.widget.AbsListView._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected override int computeVerticalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "computeVerticalScrollExtent", "()I", ref global::android.widget.AbsListView._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override int getSolidColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getSolidColor", "()I", ref global::android.widget.AbsListView._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.AbsListView._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.AbsListView._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "drawableStateChanged", "()V", ref global::android.widget.AbsListView._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		protected override int[] onCreateDrawableState(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.widget.AbsListView.staticClass, "onCreateDrawableState", "(I)[I", ref global::android.widget.AbsListView._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "requestLayout", "()V", ref global::android.widget.AbsListView._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onMeasure", "(II)V", ref global::android.widget.AbsListView._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override bool showContextMenuForChild(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z", ref global::android.widget.AbsListView._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.AbsListView._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.AbsListView._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::android.widget.AbsListView.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;", ref global::android.widget.AbsListView._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.AbsListView.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.AbsListView._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public override global::android.view.View getSelectedView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsListView.staticClass, "getSelectedView", "()Landroid/view/View;", ref global::android.widget.AbsListView._m36) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.widget.AbsListView._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		protected virtual void layoutChildren()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "layoutChildren", "()V", ref global::android.widget.AbsListView._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void setCacheColorHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setCacheColorHint", "(I)V", ref global::android.widget.AbsListView._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void setFastScrollEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setFastScrollEnabled", "(Z)V", ref global::android.widget.AbsListView._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual bool isFastScrollEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isFastScrollEnabled", "()Z", ref global::android.widget.AbsListView._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual void setSmoothScrollbarEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setSmoothScrollbarEnabled", "(Z)V", ref global::android.widget.AbsListView._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual bool isSmoothScrollbarEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isSmoothScrollbarEnabled", "()Z", ref global::android.widget.AbsListView._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void setOnScrollListener(android.widget.AbsListView.OnScrollListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V", ref global::android.widget.AbsListView._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual bool isScrollingCacheEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isScrollingCacheEnabled", "()Z", ref global::android.widget.AbsListView._m45);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual void setScrollingCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setScrollingCacheEnabled", "(Z)V", ref global::android.widget.AbsListView._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual void setTextFilterEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setTextFilterEnabled", "(Z)V", ref global::android.widget.AbsListView._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual bool isTextFilterEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isTextFilterEnabled", "()Z", ref global::android.widget.AbsListView._m48);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual bool isStackFromBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isStackFromBottom", "()Z", ref global::android.widget.AbsListView._m49);
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual void setStackFromBottom(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setStackFromBottom", "(Z)V", ref global::android.widget.AbsListView._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual void setFilterText(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setFilterText", "(Ljava/lang/String;)V", ref global::android.widget.AbsListView._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual global::java.lang.CharSequence getTextFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.AbsListView.staticClass, "getTextFilter", "()Ljava/lang/CharSequence;", ref global::android.widget.AbsListView._m52) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual int getListPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getListPaddingTop", "()I", ref global::android.widget.AbsListView._m53);
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual int getListPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getListPaddingBottom", "()I", ref global::android.widget.AbsListView._m54);
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual int getListPaddingLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getListPaddingLeft", "()I", ref global::android.widget.AbsListView._m55);
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual int getListPaddingRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getListPaddingRight", "()I", ref global::android.widget.AbsListView._m56);
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual void setDrawSelectorOnTop(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setDrawSelectorOnTop", "(Z)V", ref global::android.widget.AbsListView._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual void setSelector(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setSelector", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.AbsListView._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual void setSelector(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setSelector", "(I)V", ref global::android.widget.AbsListView._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual global::android.graphics.drawable.Drawable getSelector()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsListView.staticClass, "getSelector", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.AbsListView._m60) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual void setScrollIndicators(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.widget.AbsListView._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual int pointToPosition(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "pointToPosition", "(II)I", ref global::android.widget.AbsListView._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual long pointToRowId(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.AbsListView.staticClass, "pointToRowId", "(II)J", ref global::android.widget.AbsListView._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual void onTouchModeChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onTouchModeChanged", "(Z)V", ref global::android.widget.AbsListView._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual void smoothScrollToPosition(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(I)V", ref global::android.widget.AbsListView._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual void smoothScrollToPosition(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(II)V", ref global::android.widget.AbsListView._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual void smoothScrollBy(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "smoothScrollBy", "(II)V", ref global::android.widget.AbsListView._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual void invalidateViews()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "invalidateViews", "()V", ref global::android.widget.AbsListView._m68);
		}
		private static global::MonoJavaBridge.MethodId _m69;
		protected virtual void handleDataChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "handleDataChanged", "()V", ref global::android.widget.AbsListView._m69);
		}
		private static global::MonoJavaBridge.MethodId _m70;
		protected virtual bool isInFilterMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "isInFilterMode", "()Z", ref global::android.widget.AbsListView._m70);
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual void clearTextFilter()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "clearTextFilter", "()V", ref global::android.widget.AbsListView._m71);
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual bool hasTextFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsListView.staticClass, "hasTextFilter", "()Z", ref global::android.widget.AbsListView._m72);
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual void onGlobalLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onGlobalLayout", "()V", ref global::android.widget.AbsListView._m73);
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.widget.AbsListView._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual void afterTextChanged(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V", ref global::android.widget.AbsListView._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual void onFilterComplete(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "onFilterComplete", "(I)V", ref global::android.widget.AbsListView._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual void setTranscriptMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setTranscriptMode", "(I)V", ref global::android.widget.AbsListView._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public virtual int getTranscriptMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getTranscriptMode", "()I", ref global::android.widget.AbsListView._m78);
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public virtual int getCacheColorHint()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.AbsListView.staticClass, "getCacheColorHint", "()I", ref global::android.widget.AbsListView._m79);
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public virtual void reclaimViews(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "reclaimViews", "(Ljava/util/List;)V", ref global::android.widget.AbsListView._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public virtual void setRecyclerListener(android.widget.AbsListView.RecyclerListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView.staticClass, "setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V", ref global::android.widget.AbsListView._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setRecyclerListener(global::android.widget.AbsListView.RecyclerListenerDelegate arg0)
		{
			setRecyclerListener((global::android.widget.AbsListView.RecyclerListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsListView._m82.native == global::System.IntPtr.Zero)
				global::android.widget.AbsListView._m82 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsListView._m83.native == global::System.IntPtr.Zero)
				global::android.widget.AbsListView._m83 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public AbsListView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsListView._m84.native == global::System.IntPtr.Zero)
				global::android.widget.AbsListView._m84 = @__env.GetMethodIDNoThrow(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.AbsListView))]
	internal sealed partial class AbsListView_ : android.widget.AbsListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbsListView_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setAdapter(android.widget.Adapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView_.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V", ref global::android.widget.AbsListView_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::android.widget.Adapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.Adapter>(this, global::android.widget.AbsListView_.staticClass, "getAdapter", "()Landroid/widget/Adapter;", ref global::android.widget.AbsListView_._m1) as android.widget.Adapter;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsListView_.staticClass, "setSelection", "(I)V", ref global::android.widget.AbsListView_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AbsListView_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsListView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsListView"));
		}
	}
}
