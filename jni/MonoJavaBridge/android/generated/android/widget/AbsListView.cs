namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbsListView : android.widget.AdapterView, android.text.TextWatcher, android.view.ViewTreeObserver.OnGlobalLayoutListener, android.widget.Filter.FilterListener, android.view.ViewTreeObserver.OnTouchModeChangeListener
	{
		internal new static global::java.lang.Class staticClass;
		static AbsListView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AbsListView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbsListView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public new class LayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::java.lang.Class staticClass;
			static LayoutParams()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AbsListView.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.AbsListView.LayoutParams(@__env);
				}
			}
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10348;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams10348, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10349;
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams10349, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10350;
			public LayoutParams(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams10350, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10351;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams10351, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AbsListView.LayoutParams.staticClass = @__class;
				global::android.widget.AbsListView.LayoutParams._LayoutParams10348 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams10349 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams10350 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(III)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams10351 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnScrollListener 
		{
			void onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3);
			void onScrollStateChanged(android.widget.AbsListView arg0, int arg1);
		}

		public partial class OnScrollListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnScrollListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnScrollListener : java.lang.Object, OnScrollListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnScrollListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AbsListView.__OnScrollListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.AbsListView.__OnScrollListener(@__env);
				}
			}
			internal __OnScrollListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScroll10352;
			 void android.widget.AbsListView.OnScrollListener.onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.AbsListView.__OnScrollListener._onScroll10352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.__OnScrollListener.staticClass, global::android.widget.AbsListView.__OnScrollListener._onScroll10352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScrollStateChanged10353;
			 void android.widget.AbsListView.OnScrollListener.onScrollStateChanged(android.widget.AbsListView arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.AbsListView.__OnScrollListener._onScrollStateChanged10353, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.__OnScrollListener.staticClass, global::android.widget.AbsListView.__OnScrollListener._onScrollStateChanged10353, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AbsListView.__OnScrollListener.staticClass = @__class;
				global::android.widget.AbsListView.__OnScrollListener._onScroll10352 = @__env.GetMethodID(global::android.widget.AbsListView.__OnScrollListener.staticClass, "android.widget.AbsListView.OnScrollListener.onScroll", "(Landroid/widget/AbsListView;III)V");
				global::android.widget.AbsListView.__OnScrollListener._onScrollStateChanged10353 = @__env.GetMethodID(global::android.widget.AbsListView.__OnScrollListener.staticClass, "android.widget.AbsListView.OnScrollListener.onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public static class OnScrollListenerConstants 
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
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface RecyclerListener 
		{
			void onMovedToScrapHeap(android.view.View arg0);
		}

		public partial class RecyclerListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __RecyclerListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __RecyclerListener : java.lang.Object, RecyclerListener
		{
			internal static global::java.lang.Class staticClass;
			static __RecyclerListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.AbsListView.__RecyclerListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.AbsListView.__RecyclerListener(@__env);
				}
			}
			internal __RecyclerListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onMovedToScrapHeap10354;
			 void android.widget.AbsListView.RecyclerListener.onMovedToScrapHeap(android.view.View arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.AbsListView.__RecyclerListener._onMovedToScrapHeap10354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.__RecyclerListener.staticClass, global::android.widget.AbsListView.__RecyclerListener._onMovedToScrapHeap10354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AbsListView.__RecyclerListener.staticClass = @__class;
				global::android.widget.AbsListView.__RecyclerListener._onMovedToScrapHeap10354 = @__env.GetMethodID(global::android.widget.AbsListView.__RecyclerListener.staticClass, "android.widget.AbsListView.RecyclerListener.onMovedToScrapHeap", "(Landroid/view/View;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw10355;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._draw10355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._draw10355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10356;
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onRestoreInstanceState10356, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onRestoreInstanceState10356, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10357;
		public virtual new global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._onSaveInstanceState10357));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSaveInstanceState10357));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10358;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._onKeyDown10358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyDown10358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10359;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._onKeyUp10359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyUp10359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10360;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._onTouchEvent10360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchEvent10360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged10361;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onWindowFocusChanged10361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onWindowFocusChanged10361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow10362;
		protected override void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onAttachedToWindow10362);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onAttachedToWindow10362);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10363;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onDetachedFromWindow10363);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onDetachedFromWindow10363);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged10364;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onFocusChanged10364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFocusChanged10364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed10365;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._dispatchSetPressed10365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchSetPressed10365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addTouchables10366;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._addTouchables10366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._addTouchables10366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDisplayHint10367;
		protected override void onDisplayHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onDisplayHint10367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onDisplayHint10367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection10368;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._onCreateInputConnection10368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateInputConnection10368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkInputConnectionProxy10369;
		public override bool checkInputConnectionProxy(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._checkInputConnectionProxy10369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkInputConnectionProxy10369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContextMenuInfo10370;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._getContextMenuInfo10370));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getContextMenuInfo10370));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged10371;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onSizeChanged10371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSizeChanged10371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw10372;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._dispatchDraw10372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchDraw10372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedRect10373;
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._getFocusedRect10373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getFocusedRect10373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopFadingEdgeStrength10374;
		protected override float getTopFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.AbsListView._getTopFadingEdgeStrength10374);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTopFadingEdgeStrength10374);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomFadingEdgeStrength10375;
		protected override float getBottomFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.AbsListView._getBottomFadingEdgeStrength10375);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getBottomFadingEdgeStrength10375);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange10376;
		protected override int computeVerticalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._computeVerticalScrollRange10376);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollRange10376);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset10377;
		protected override int computeVerticalScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._computeVerticalScrollOffset10377);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollOffset10377);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent10378;
		protected override int computeVerticalScrollExtent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._computeVerticalScrollExtent10378);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollExtent10378);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSolidColor10379;
		public override int getSolidColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getSolidColor10379);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSolidColor10379);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10380;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onLayout10380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onLayout10380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable10381;
		public virtual new bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._verifyDrawable10381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._verifyDrawable10381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged10382;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._drawableStateChanged10382);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._drawableStateChanged10382);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState10383;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._onCreateDrawableState10383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateDrawableState10383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout10384;
		public override void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._requestLayout10384);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._requestLayout10384);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10385;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onMeasure10385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onMeasure10385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenuForChild10386;
		public override bool showContextMenuForChild(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._showContextMenuForChild10386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._showContextMenuForChild10386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent10387;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._onInterceptTouchEvent10387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onInterceptTouchEvent10387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams10388;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._checkLayoutParams10388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkLayoutParams10388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10389;
		public virtual new global::android.widget.AbsListView.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.AbsListView.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._generateLayoutParams10389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.AbsListView.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams10389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10390;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._generateLayoutParams10390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams10390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedView10391;
		public override global::android.view.View getSelectedView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._getSelectedView10391));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelectedView10391));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged10392;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onTextChanged10392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTextChanged10392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		public void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::net.sf.jni4net.jni.MethodId _layoutChildren10393;
		protected virtual void layoutChildren() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._layoutChildren10393);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._layoutChildren10393);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCacheColorHint10394;
		public virtual void setCacheColorHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setCacheColorHint10394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setCacheColorHint10394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFastScrollEnabled10395;
		public virtual void setFastScrollEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setFastScrollEnabled10395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFastScrollEnabled10395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFastScrollEnabled10396;
		public virtual bool isFastScrollEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isFastScrollEnabled10396);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isFastScrollEnabled10396);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSmoothScrollbarEnabled10397;
		public virtual void setSmoothScrollbarEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setSmoothScrollbarEnabled10397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSmoothScrollbarEnabled10397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSmoothScrollbarEnabled10398;
		public virtual bool isSmoothScrollbarEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isSmoothScrollbarEnabled10398);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isSmoothScrollbarEnabled10398);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnScrollListener10399;
		public virtual void setOnScrollListener(android.widget.AbsListView.OnScrollListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setOnScrollListener10399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setOnScrollListener10399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isScrollingCacheEnabled10400;
		public virtual bool isScrollingCacheEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isScrollingCacheEnabled10400);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isScrollingCacheEnabled10400);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScrollingCacheEnabled10401;
		public virtual void setScrollingCacheEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setScrollingCacheEnabled10401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollingCacheEnabled10401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextFilterEnabled10402;
		public virtual void setTextFilterEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setTextFilterEnabled10402, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTextFilterEnabled10402, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isTextFilterEnabled10403;
		public virtual bool isTextFilterEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isTextFilterEnabled10403);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isTextFilterEnabled10403);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStackFromBottom10404;
		public virtual bool isStackFromBottom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isStackFromBottom10404);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isStackFromBottom10404);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStackFromBottom10405;
		public virtual void setStackFromBottom(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setStackFromBottom10405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setStackFromBottom10405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterText10406;
		public virtual void setFilterText(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setFilterText10406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFilterText10406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextFilter10407;
		public virtual global::java.lang.CharSequence getTextFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._getTextFilter10407));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTextFilter10407));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingTop10408;
		public virtual int getListPaddingTop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getListPaddingTop10408);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingTop10408);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingBottom10409;
		public virtual int getListPaddingBottom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getListPaddingBottom10409);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingBottom10409);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingLeft10410;
		public virtual int getListPaddingLeft() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getListPaddingLeft10410);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingLeft10410);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingRight10411;
		public virtual int getListPaddingRight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getListPaddingRight10411);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingRight10411);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDrawSelectorOnTop10412;
		public virtual void setDrawSelectorOnTop(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setDrawSelectorOnTop10412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setDrawSelectorOnTop10412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelector10413;
		public virtual void setSelector(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setSelector10413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector10413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelector10414;
		public virtual void setSelector(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setSelector10414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector10414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelector10415;
		public virtual global::android.graphics.drawable.Drawable getSelector() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._getSelector10415));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelector10415));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScrollIndicators10416;
		public virtual void setScrollIndicators(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setScrollIndicators10416, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollIndicators10416, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pointToPosition10417;
		public virtual int pointToPosition(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._pointToPosition10417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToPosition10417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pointToRowId10418;
		public virtual long pointToRowId(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.AbsListView._pointToRowId10418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToRowId10418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchModeChanged10419;
		public virtual void onTouchModeChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onTouchModeChanged10419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchModeChanged10419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollToPosition10420;
		public virtual void smoothScrollToPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._smoothScrollToPosition10420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollToPosition10420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollToPosition10421;
		public virtual void smoothScrollToPosition(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._smoothScrollToPosition10421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollToPosition10421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollBy10422;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._smoothScrollBy10422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._smoothScrollBy10422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateViews10423;
		public virtual void invalidateViews() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._invalidateViews10423);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._invalidateViews10423);
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleDataChanged10424;
		protected virtual void handleDataChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._handleDataChanged10424);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._handleDataChanged10424);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInFilterMode10425;
		protected virtual bool isInFilterMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isInFilterMode10425);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isInFilterMode10425);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearTextFilter10426;
		public virtual void clearTextFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._clearTextFilter10426);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._clearTextFilter10426);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasTextFilter10427;
		public virtual bool hasTextFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._hasTextFilter10427);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._hasTextFilter10427);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGlobalLayout10428;
		public virtual void onGlobalLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onGlobalLayout10428);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onGlobalLayout10428);
		}
		internal static global::net.sf.jni4net.jni.MethodId _beforeTextChanged10429;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._beforeTextChanged10429, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._beforeTextChanged10429, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		public void beforeTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			beforeTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::net.sf.jni4net.jni.MethodId _afterTextChanged10430;
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._afterTextChanged10430, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._afterTextChanged10430, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFilterComplete10431;
		public virtual void onFilterComplete(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onFilterComplete10431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFilterComplete10431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTranscriptMode10432;
		public virtual void setTranscriptMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setTranscriptMode10432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTranscriptMode10432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTranscriptMode10433;
		public virtual int getTranscriptMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getTranscriptMode10433);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTranscriptMode10433);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCacheColorHint10434;
		public virtual int getCacheColorHint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getCacheColorHint10434);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getCacheColorHint10434);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reclaimViews10435;
		public virtual void reclaimViews(java.util.List arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._reclaimViews10435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._reclaimViews10435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRecyclerListener10436;
		public virtual void setRecyclerListener(android.widget.AbsListView.RecyclerListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setRecyclerListener10436, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setRecyclerListener10436, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsListView10437;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView10437, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsListView10438;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView10438, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsListView10439;
		public AbsListView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView10439, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.AbsListView.staticClass = @__class;
			global::android.widget.AbsListView._draw10355 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._onRestoreInstanceState10356 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.AbsListView._onSaveInstanceState10357 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.AbsListView._onKeyDown10358 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onKeyUp10359 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onTouchEvent10360 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._onWindowFocusChanged10361 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.AbsListView._onAttachedToWindow10362 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AbsListView._onDetachedFromWindow10363 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AbsListView._onFocusChanged10364 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.AbsListView._dispatchSetPressed10365 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.widget.AbsListView._addTouchables10366 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.widget.AbsListView._onDisplayHint10367 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onDisplayHint", "(I)V");
			global::android.widget.AbsListView._onCreateInputConnection10368 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.AbsListView._checkInputConnectionProxy10369 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._getContextMenuInfo10370 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.widget.AbsListView._onSizeChanged10371 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AbsListView._dispatchDraw10372 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._getFocusedRect10373 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.AbsListView._getTopFadingEdgeStrength10374 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._getBottomFadingEdgeStrength10375 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._computeVerticalScrollRange10376 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.AbsListView._computeVerticalScrollOffset10377 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.AbsListView._computeVerticalScrollExtent10378 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.AbsListView._getSolidColor10379 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getSolidColor", "()I");
			global::android.widget.AbsListView._onLayout10380 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AbsListView._verifyDrawable10381 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.AbsListView._drawableStateChanged10382 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.AbsListView._onCreateDrawableState10383 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.AbsListView._requestLayout10384 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "requestLayout", "()V");
			global::android.widget.AbsListView._onMeasure10385 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsListView._showContextMenuForChild10386 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._onInterceptTouchEvent10387 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._checkLayoutParams10388 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.AbsListView._generateLayoutParams10389 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;");
			global::android.widget.AbsListView._generateLayoutParams10390 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsListView._getSelectedView10391 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AbsListView._onTextChanged10392 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._layoutChildren10393 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "layoutChildren", "()V");
			global::android.widget.AbsListView._setCacheColorHint10394 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.AbsListView._setFastScrollEnabled10395 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setFastScrollEnabled", "(Z)V");
			global::android.widget.AbsListView._isFastScrollEnabled10396 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isFastScrollEnabled", "()Z");
			global::android.widget.AbsListView._setSmoothScrollbarEnabled10397 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setSmoothScrollbarEnabled", "(Z)V");
			global::android.widget.AbsListView._isSmoothScrollbarEnabled10398 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isSmoothScrollbarEnabled", "()Z");
			global::android.widget.AbsListView._setOnScrollListener10399 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V");
			global::android.widget.AbsListView._isScrollingCacheEnabled10400 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isScrollingCacheEnabled", "()Z");
			global::android.widget.AbsListView._setScrollingCacheEnabled10401 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setScrollingCacheEnabled", "(Z)V");
			global::android.widget.AbsListView._setTextFilterEnabled10402 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setTextFilterEnabled", "(Z)V");
			global::android.widget.AbsListView._isTextFilterEnabled10403 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isTextFilterEnabled", "()Z");
			global::android.widget.AbsListView._isStackFromBottom10404 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isStackFromBottom", "()Z");
			global::android.widget.AbsListView._setStackFromBottom10405 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setStackFromBottom", "(Z)V");
			global::android.widget.AbsListView._setFilterText10406 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setFilterText", "(Ljava/lang/String;)V");
			global::android.widget.AbsListView._getTextFilter10407 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getTextFilter", "()Ljava/lang/CharSequence;");
			global::android.widget.AbsListView._getListPaddingTop10408 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingTop", "()I");
			global::android.widget.AbsListView._getListPaddingBottom10409 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingBottom", "()I");
			global::android.widget.AbsListView._getListPaddingLeft10410 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingLeft", "()I");
			global::android.widget.AbsListView._getListPaddingRight10411 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingRight", "()I");
			global::android.widget.AbsListView._setDrawSelectorOnTop10412 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setDrawSelectorOnTop", "(Z)V");
			global::android.widget.AbsListView._setSelector10413 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setSelector", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AbsListView._setSelector10414 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setSelector", "(I)V");
			global::android.widget.AbsListView._getSelector10415 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getSelector", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.AbsListView._setScrollIndicators10416 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.AbsListView._pointToPosition10417 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "pointToPosition", "(II)I");
			global::android.widget.AbsListView._pointToRowId10418 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "pointToRowId", "(II)J");
			global::android.widget.AbsListView._onTouchModeChanged10419 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onTouchModeChanged", "(Z)V");
			global::android.widget.AbsListView._smoothScrollToPosition10420 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(I)V");
			global::android.widget.AbsListView._smoothScrollToPosition10421 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "smoothScrollToPosition", "(II)V");
			global::android.widget.AbsListView._smoothScrollBy10422 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.AbsListView._invalidateViews10423 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "invalidateViews", "()V");
			global::android.widget.AbsListView._handleDataChanged10424 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "handleDataChanged", "()V");
			global::android.widget.AbsListView._isInFilterMode10425 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isInFilterMode", "()Z");
			global::android.widget.AbsListView._clearTextFilter10426 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "clearTextFilter", "()V");
			global::android.widget.AbsListView._hasTextFilter10427 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "hasTextFilter", "()Z");
			global::android.widget.AbsListView._onGlobalLayout10428 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onGlobalLayout", "()V");
			global::android.widget.AbsListView._beforeTextChanged10429 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._afterTextChanged10430 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.widget.AbsListView._onFilterComplete10431 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onFilterComplete", "(I)V");
			global::android.widget.AbsListView._setTranscriptMode10432 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setTranscriptMode", "(I)V");
			global::android.widget.AbsListView._getTranscriptMode10433 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getTranscriptMode", "()I");
			global::android.widget.AbsListView._getCacheColorHint10434 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getCacheColorHint", "()I");
			global::android.widget.AbsListView._reclaimViews10435 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "reclaimViews", "(Ljava/util/List;)V");
			global::android.widget.AbsListView._setRecyclerListener10436 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V");
			global::android.widget.AbsListView._AbsListView10437 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsListView._AbsListView10438 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsListView._AbsListView10439 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
