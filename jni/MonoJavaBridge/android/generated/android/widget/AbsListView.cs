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
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9655;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams9655, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9656;
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams9656, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9657;
			public LayoutParams(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams9657, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9658;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.AbsListView.LayoutParams.staticClass, global::android.widget.AbsListView.LayoutParams._LayoutParams9658, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AbsListView.LayoutParams.staticClass = @__class;
				global::android.widget.AbsListView.LayoutParams._LayoutParams9655 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams9656 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams9657 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(III)V");
				global::android.widget.AbsListView.LayoutParams._LayoutParams9658 = @__env.GetMethodID(global::android.widget.AbsListView.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onScroll9659;
			 void android.widget.AbsListView.OnScrollListener.onScroll(android.widget.AbsListView arg0, int arg1, int arg2, int arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.AbsListView.__OnScrollListener._onScroll9659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.__OnScrollListener.staticClass, global::android.widget.AbsListView.__OnScrollListener._onScroll9659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScrollStateChanged9660;
			 void android.widget.AbsListView.OnScrollListener.onScrollStateChanged(android.widget.AbsListView arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.AbsListView.__OnScrollListener._onScrollStateChanged9660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.__OnScrollListener.staticClass, global::android.widget.AbsListView.__OnScrollListener._onScrollStateChanged9660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AbsListView.__OnScrollListener.staticClass = @__class;
				global::android.widget.AbsListView.__OnScrollListener._onScroll9659 = @__env.GetMethodID(global::android.widget.AbsListView.__OnScrollListener.staticClass, "android.widget.AbsListView.OnScrollListener.onScroll", "(Landroid/widget/AbsListView;III)V");
				global::android.widget.AbsListView.__OnScrollListener._onScrollStateChanged9660 = @__env.GetMethodID(global::android.widget.AbsListView.__OnScrollListener.staticClass, "android.widget.AbsListView.OnScrollListener.onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onMovedToScrapHeap9661;
			 void android.widget.AbsListView.RecyclerListener.onMovedToScrapHeap(android.view.View arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.AbsListView.__RecyclerListener._onMovedToScrapHeap9661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.__RecyclerListener.staticClass, global::android.widget.AbsListView.__RecyclerListener._onMovedToScrapHeap9661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.AbsListView.__RecyclerListener.staticClass = @__class;
				global::android.widget.AbsListView.__RecyclerListener._onMovedToScrapHeap9661 = @__env.GetMethodID(global::android.widget.AbsListView.__RecyclerListener.staticClass, "android.widget.AbsListView.RecyclerListener.onMovedToScrapHeap", "(Landroid/view/View;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw9662;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._draw9662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._draw9662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState9663;
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onRestoreInstanceState9663, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onRestoreInstanceState9663, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState9664;
		public virtual new global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._onSaveInstanceState9664));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSaveInstanceState9664));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown9665;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._onKeyDown9665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyDown9665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp9666;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._onKeyUp9666, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onKeyUp9666, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent9667;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._onTouchEvent9667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchEvent9667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged9668;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onWindowFocusChanged9668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onWindowFocusChanged9668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow9669;
		protected override void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onAttachedToWindow9669);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onAttachedToWindow9669);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow9670;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onDetachedFromWindow9670);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onDetachedFromWindow9670);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged9671;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onFocusChanged9671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFocusChanged9671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed9672;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._dispatchSetPressed9672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchSetPressed9672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addTouchables9673;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._addTouchables9673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._addTouchables9673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection9674;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._onCreateInputConnection9674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateInputConnection9674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkInputConnectionProxy9675;
		public override bool checkInputConnectionProxy(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._checkInputConnectionProxy9675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkInputConnectionProxy9675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContextMenuInfo9676;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._getContextMenuInfo9676));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ContextMenu_ContextMenuInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getContextMenuInfo9676));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged9677;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onSizeChanged9677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onSizeChanged9677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw9678;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._dispatchDraw9678, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._dispatchDraw9678, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedRect9679;
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._getFocusedRect9679, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getFocusedRect9679, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopFadingEdgeStrength9680;
		protected override float getTopFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.AbsListView._getTopFadingEdgeStrength9680);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTopFadingEdgeStrength9680);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomFadingEdgeStrength9681;
		protected override float getBottomFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.AbsListView._getBottomFadingEdgeStrength9681);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getBottomFadingEdgeStrength9681);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange9682;
		protected override int computeVerticalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._computeVerticalScrollRange9682);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollRange9682);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset9683;
		protected override int computeVerticalScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._computeVerticalScrollOffset9683);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollOffset9683);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent9684;
		protected override int computeVerticalScrollExtent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._computeVerticalScrollExtent9684);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._computeVerticalScrollExtent9684);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSolidColor9685;
		public override int getSolidColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getSolidColor9685);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSolidColor9685);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9686;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onLayout9686, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onLayout9686, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable9687;
		public virtual new bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._verifyDrawable9687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._verifyDrawable9687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9688;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._drawableStateChanged9688);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._drawableStateChanged9688);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState9689;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._onCreateDrawableState9689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onCreateDrawableState9689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout9690;
		public override void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._requestLayout9690);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._requestLayout9690);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9691;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onMeasure9691, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onMeasure9691, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenuForChild9692;
		public override bool showContextMenuForChild(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._showContextMenuForChild9692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._showContextMenuForChild9692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent9693;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._onInterceptTouchEvent9693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onInterceptTouchEvent9693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams9694;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._checkLayoutParams9694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._checkLayoutParams9694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9695;
		public virtual new global::android.widget.AbsListView.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.AbsListView.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._generateLayoutParams9695, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.AbsListView.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams9695, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9696;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._generateLayoutParams9696, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._generateLayoutParams9696, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedView9697;
		public override global::android.view.View getSelectedView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._getSelectedView9697));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelectedView9697));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged9698;
		public virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onTextChanged9698, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTextChanged9698, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _layoutChildren9699;
		protected virtual void layoutChildren() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._layoutChildren9699);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._layoutChildren9699);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCacheColorHint9700;
		public virtual void setCacheColorHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setCacheColorHint9700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setCacheColorHint9700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFastScrollEnabled9701;
		public virtual void setFastScrollEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setFastScrollEnabled9701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFastScrollEnabled9701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFastScrollEnabled9702;
		public virtual bool isFastScrollEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isFastScrollEnabled9702);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isFastScrollEnabled9702);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSmoothScrollbarEnabled9703;
		public virtual void setSmoothScrollbarEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setSmoothScrollbarEnabled9703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSmoothScrollbarEnabled9703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSmoothScrollbarEnabled9704;
		public virtual bool isSmoothScrollbarEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isSmoothScrollbarEnabled9704);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isSmoothScrollbarEnabled9704);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnScrollListener9705;
		public virtual void setOnScrollListener(android.widget.AbsListView.OnScrollListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setOnScrollListener9705, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setOnScrollListener9705, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isScrollingCacheEnabled9706;
		public virtual bool isScrollingCacheEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isScrollingCacheEnabled9706);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isScrollingCacheEnabled9706);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScrollingCacheEnabled9707;
		public virtual void setScrollingCacheEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setScrollingCacheEnabled9707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollingCacheEnabled9707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextFilterEnabled9708;
		public virtual void setTextFilterEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setTextFilterEnabled9708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTextFilterEnabled9708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isTextFilterEnabled9709;
		public virtual bool isTextFilterEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isTextFilterEnabled9709);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isTextFilterEnabled9709);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStackFromBottom9710;
		public virtual bool isStackFromBottom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isStackFromBottom9710);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isStackFromBottom9710);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStackFromBottom9711;
		public virtual void setStackFromBottom(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setStackFromBottom9711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setStackFromBottom9711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterText9712;
		public virtual void setFilterText(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setFilterText9712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setFilterText9712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextFilter9713;
		public virtual global::java.lang.CharSequence getTextFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._getTextFilter9713));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTextFilter9713));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingTop9714;
		public virtual int getListPaddingTop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getListPaddingTop9714);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingTop9714);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingBottom9715;
		public virtual int getListPaddingBottom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getListPaddingBottom9715);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingBottom9715);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingLeft9716;
		public virtual int getListPaddingLeft() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getListPaddingLeft9716);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingLeft9716);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListPaddingRight9717;
		public virtual int getListPaddingRight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getListPaddingRight9717);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getListPaddingRight9717);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDrawSelectorOnTop9718;
		public virtual void setDrawSelectorOnTop(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setDrawSelectorOnTop9718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setDrawSelectorOnTop9718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelector9719;
		public virtual void setSelector(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setSelector9719, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector9719, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelector9720;
		public virtual void setSelector(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setSelector9720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setSelector9720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelector9721;
		public virtual global::android.graphics.drawable.Drawable getSelector() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.AbsListView._getSelector9721));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getSelector9721));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScrollIndicators9722;
		public virtual void setScrollIndicators(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setScrollIndicators9722, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setScrollIndicators9722, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pointToPosition9723;
		public virtual int pointToPosition(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._pointToPosition9723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToPosition9723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pointToRowId9724;
		public virtual long pointToRowId(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.AbsListView._pointToRowId9724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._pointToRowId9724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchModeChanged9725;
		public virtual void onTouchModeChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onTouchModeChanged9725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onTouchModeChanged9725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateViews9726;
		public virtual void invalidateViews() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._invalidateViews9726);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._invalidateViews9726);
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleDataChanged9727;
		protected virtual void handleDataChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._handleDataChanged9727);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._handleDataChanged9727);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInFilterMode9728;
		protected virtual bool isInFilterMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._isInFilterMode9728);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._isInFilterMode9728);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearTextFilter9729;
		public virtual void clearTextFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._clearTextFilter9729);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._clearTextFilter9729);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasTextFilter9730;
		public virtual bool hasTextFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.AbsListView._hasTextFilter9730);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._hasTextFilter9730);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGlobalLayout9731;
		public virtual void onGlobalLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onGlobalLayout9731);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onGlobalLayout9731);
		}
		internal static global::net.sf.jni4net.jni.MethodId _beforeTextChanged9732;
		public virtual void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._beforeTextChanged9732, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._beforeTextChanged9732, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _afterTextChanged9733;
		public virtual void afterTextChanged(android.text.Editable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._afterTextChanged9733, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._afterTextChanged9733, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFilterComplete9734;
		public virtual void onFilterComplete(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._onFilterComplete9734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._onFilterComplete9734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTranscriptMode9735;
		public virtual void setTranscriptMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setTranscriptMode9735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setTranscriptMode9735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTranscriptMode9736;
		public virtual int getTranscriptMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getTranscriptMode9736);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getTranscriptMode9736);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCacheColorHint9737;
		public virtual int getCacheColorHint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.AbsListView._getCacheColorHint9737);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._getCacheColorHint9737);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reclaimViews9738;
		public virtual void reclaimViews(java.util.List arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._reclaimViews9738, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._reclaimViews9738, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRecyclerListener9739;
		public virtual void setRecyclerListener(android.widget.AbsListView.RecyclerListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.AbsListView._setRecyclerListener9739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.AbsListView.staticClass, global::android.widget.AbsListView._setRecyclerListener9739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsListView9740;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView9740, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsListView9741;
		public AbsListView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView9741, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsListView9742;
		public AbsListView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.AbsListView.staticClass, global::android.widget.AbsListView._AbsListView9742, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
			global::android.widget.AbsListView._draw9662 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._onRestoreInstanceState9663 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.AbsListView._onSaveInstanceState9664 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.AbsListView._onKeyDown9665 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onKeyUp9666 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.AbsListView._onTouchEvent9667 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._onWindowFocusChanged9668 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.AbsListView._onAttachedToWindow9669 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.AbsListView._onDetachedFromWindow9670 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.AbsListView._onFocusChanged9671 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.AbsListView._dispatchSetPressed9672 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.widget.AbsListView._addTouchables9673 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.widget.AbsListView._onCreateInputConnection9674 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.AbsListView._checkInputConnectionProxy9675 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._getContextMenuInfo9676 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
			global::android.widget.AbsListView._onSizeChanged9677 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.AbsListView._dispatchDraw9678 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.AbsListView._getFocusedRect9679 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.AbsListView._getTopFadingEdgeStrength9680 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._getBottomFadingEdgeStrength9681 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.widget.AbsListView._computeVerticalScrollRange9682 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.AbsListView._computeVerticalScrollOffset9683 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.AbsListView._computeVerticalScrollExtent9684 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.AbsListView._getSolidColor9685 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getSolidColor", "()I");
			global::android.widget.AbsListView._onLayout9686 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AbsListView._verifyDrawable9687 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.AbsListView._drawableStateChanged9688 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.AbsListView._onCreateDrawableState9689 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.AbsListView._requestLayout9690 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "requestLayout", "()V");
			global::android.widget.AbsListView._onMeasure9691 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsListView._showContextMenuForChild9692 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.widget.AbsListView._onInterceptTouchEvent9693 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.AbsListView._checkLayoutParams9694 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.AbsListView._generateLayoutParams9695 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;");
			global::android.widget.AbsListView._generateLayoutParams9696 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsListView._getSelectedView9697 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getSelectedView", "()Landroid/view/View;");
			global::android.widget.AbsListView._onTextChanged9698 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._layoutChildren9699 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "layoutChildren", "()V");
			global::android.widget.AbsListView._setCacheColorHint9700 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setCacheColorHint", "(I)V");
			global::android.widget.AbsListView._setFastScrollEnabled9701 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setFastScrollEnabled", "(Z)V");
			global::android.widget.AbsListView._isFastScrollEnabled9702 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isFastScrollEnabled", "()Z");
			global::android.widget.AbsListView._setSmoothScrollbarEnabled9703 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setSmoothScrollbarEnabled", "(Z)V");
			global::android.widget.AbsListView._isSmoothScrollbarEnabled9704 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isSmoothScrollbarEnabled", "()Z");
			global::android.widget.AbsListView._setOnScrollListener9705 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V");
			global::android.widget.AbsListView._isScrollingCacheEnabled9706 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isScrollingCacheEnabled", "()Z");
			global::android.widget.AbsListView._setScrollingCacheEnabled9707 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setScrollingCacheEnabled", "(Z)V");
			global::android.widget.AbsListView._setTextFilterEnabled9708 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setTextFilterEnabled", "(Z)V");
			global::android.widget.AbsListView._isTextFilterEnabled9709 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isTextFilterEnabled", "()Z");
			global::android.widget.AbsListView._isStackFromBottom9710 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isStackFromBottom", "()Z");
			global::android.widget.AbsListView._setStackFromBottom9711 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setStackFromBottom", "(Z)V");
			global::android.widget.AbsListView._setFilterText9712 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setFilterText", "(Ljava/lang/String;)V");
			global::android.widget.AbsListView._getTextFilter9713 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getTextFilter", "()Ljava/lang/CharSequence;");
			global::android.widget.AbsListView._getListPaddingTop9714 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingTop", "()I");
			global::android.widget.AbsListView._getListPaddingBottom9715 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingBottom", "()I");
			global::android.widget.AbsListView._getListPaddingLeft9716 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingLeft", "()I");
			global::android.widget.AbsListView._getListPaddingRight9717 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getListPaddingRight", "()I");
			global::android.widget.AbsListView._setDrawSelectorOnTop9718 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setDrawSelectorOnTop", "(Z)V");
			global::android.widget.AbsListView._setSelector9719 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setSelector", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.AbsListView._setSelector9720 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setSelector", "(I)V");
			global::android.widget.AbsListView._getSelector9721 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getSelector", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.AbsListView._setScrollIndicators9722 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.AbsListView._pointToPosition9723 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "pointToPosition", "(II)I");
			global::android.widget.AbsListView._pointToRowId9724 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "pointToRowId", "(II)J");
			global::android.widget.AbsListView._onTouchModeChanged9725 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onTouchModeChanged", "(Z)V");
			global::android.widget.AbsListView._invalidateViews9726 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "invalidateViews", "()V");
			global::android.widget.AbsListView._handleDataChanged9727 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "handleDataChanged", "()V");
			global::android.widget.AbsListView._isInFilterMode9728 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "isInFilterMode", "()Z");
			global::android.widget.AbsListView._clearTextFilter9729 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "clearTextFilter", "()V");
			global::android.widget.AbsListView._hasTextFilter9730 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "hasTextFilter", "()Z");
			global::android.widget.AbsListView._onGlobalLayout9731 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onGlobalLayout", "()V");
			global::android.widget.AbsListView._beforeTextChanged9732 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.AbsListView._afterTextChanged9733 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "afterTextChanged", "(Landroid/text/Editable;)V");
			global::android.widget.AbsListView._onFilterComplete9734 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "onFilterComplete", "(I)V");
			global::android.widget.AbsListView._setTranscriptMode9735 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setTranscriptMode", "(I)V");
			global::android.widget.AbsListView._getTranscriptMode9736 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getTranscriptMode", "()I");
			global::android.widget.AbsListView._getCacheColorHint9737 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "getCacheColorHint", "()I");
			global::android.widget.AbsListView._reclaimViews9738 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "reclaimViews", "(Ljava/util/List;)V");
			global::android.widget.AbsListView._setRecyclerListener9739 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V");
			global::android.widget.AbsListView._AbsListView9740 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsListView._AbsListView9741 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsListView._AbsListView9742 = @__env.GetMethodID(global::android.widget.AbsListView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
	public static class AbsListViewExtensionMethods
	{
		public static void onTextChanged(this global::android.widget.AbsListView __this, string arg0, int arg1, int arg2, int arg3)
		{
			__this.onTextChanged((global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		public static void beforeTextChanged(this global::android.widget.AbsListView __this, string arg0, int arg1, int arg2, int arg3)
		{
			__this.beforeTextChanged((global::java.lang.String)arg0, arg1, arg2, arg3);
		}
	}
}
