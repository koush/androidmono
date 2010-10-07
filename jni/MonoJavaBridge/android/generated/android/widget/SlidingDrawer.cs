namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SlidingDrawer : android.view.ViewGroup
	{
		internal new static global::java.lang.Class staticClass;
		static SlidingDrawer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SlidingDrawer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.SlidingDrawer(@__env);
			}
		}
		protected SlidingDrawer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnDrawerCloseListener 
		{
			void onDrawerClosed();
		}

		public partial class OnDrawerCloseListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnDrawerCloseListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnDrawerCloseListener : java.lang.Object, OnDrawerCloseListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnDrawerCloseListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SlidingDrawer.__OnDrawerCloseListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.SlidingDrawer.__OnDrawerCloseListener(@__env);
				}
			}
			internal __OnDrawerCloseListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDrawerClosed11573;
			 void android.widget.SlidingDrawer.OnDrawerCloseListener.onDrawerClosed() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerCloseListener._onDrawerClosed11573);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerCloseListener.staticClass, global::android.widget.SlidingDrawer.__OnDrawerCloseListener._onDrawerClosed11573);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SlidingDrawer.__OnDrawerCloseListener.staticClass = @__class;
				global::android.widget.SlidingDrawer.__OnDrawerCloseListener._onDrawerClosed11573 = @__env.GetMethodID(global::android.widget.SlidingDrawer.__OnDrawerCloseListener.staticClass, "android.widget.SlidingDrawer.OnDrawerCloseListener.onDrawerClosed", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnDrawerOpenListener 
		{
			void onDrawerOpened();
		}

		public partial class OnDrawerOpenListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnDrawerOpenListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnDrawerOpenListener : java.lang.Object, OnDrawerOpenListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnDrawerOpenListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SlidingDrawer.__OnDrawerOpenListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.SlidingDrawer.__OnDrawerOpenListener(@__env);
				}
			}
			internal __OnDrawerOpenListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDrawerOpened11574;
			 void android.widget.SlidingDrawer.OnDrawerOpenListener.onDrawerOpened() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerOpenListener._onDrawerOpened11574);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerOpenListener.staticClass, global::android.widget.SlidingDrawer.__OnDrawerOpenListener._onDrawerOpened11574);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SlidingDrawer.__OnDrawerOpenListener.staticClass = @__class;
				global::android.widget.SlidingDrawer.__OnDrawerOpenListener._onDrawerOpened11574 = @__env.GetMethodID(global::android.widget.SlidingDrawer.__OnDrawerOpenListener.staticClass, "android.widget.SlidingDrawer.OnDrawerOpenListener.onDrawerOpened", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnDrawerScrollListener 
		{
			void onScrollStarted();
			void onScrollEnded();
		}

		public partial class OnDrawerScrollListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnDrawerScrollListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnDrawerScrollListener : java.lang.Object, OnDrawerScrollListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnDrawerScrollListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.SlidingDrawer.__OnDrawerScrollListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.SlidingDrawer.__OnDrawerScrollListener(@__env);
				}
			}
			internal __OnDrawerScrollListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScrollStarted11575;
			 void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollStarted() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollStarted11575);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass, global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollStarted11575);
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScrollEnded11576;
			 void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollEnded() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollEnded11576);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass, global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollEnded11576);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass = @__class;
				global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollStarted11575 = @__env.GetMethodID(global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass, "android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollStarted", "()V");
				global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollEnded11576 = @__env.GetMethodID(global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass, "android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollEnded", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _lock11577;
		public virtual void @lock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._lock11577);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._lock11577);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close11578;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._close11578);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._close11578);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContent11579;
		public virtual global::android.view.View getContent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SlidingDrawer._getContent11579));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getContent11579));
		}
		internal static global::net.sf.jni4net.jni.MethodId _open11580;
		public virtual void open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._open11580);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._open11580);
		}
		internal static global::net.sf.jni4net.jni.MethodId _unlock11581;
		public virtual void unlock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._unlock11581);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._unlock11581);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toggle11582;
		public virtual void toggle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._toggle11582);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._toggle11582);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11583;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SlidingDrawer._onTouchEvent11583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onTouchEvent11583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw11584;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._dispatchDraw11584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._dispatchDraw11584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout11585;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._onLayout11585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onLayout11585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate11586;
		protected override void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._onFinishInflate11586);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onFinishInflate11586);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11587;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._onMeasure11587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onMeasure11587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent11588;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SlidingDrawer._onInterceptTouchEvent11588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onInterceptTouchEvent11588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _animateToggle11589;
		public virtual void animateToggle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._animateToggle11589);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateToggle11589);
		}
		internal static global::net.sf.jni4net.jni.MethodId _animateClose11590;
		public virtual void animateClose() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._animateClose11590);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateClose11590);
		}
		internal static global::net.sf.jni4net.jni.MethodId _animateOpen11591;
		public virtual void animateOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._animateOpen11591);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateOpen11591);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDrawerOpenListener11592;
		public virtual void setOnDrawerOpenListener(android.widget.SlidingDrawer.OnDrawerOpenListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._setOnDrawerOpenListener11592, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerOpenListener11592, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDrawerCloseListener11593;
		public virtual void setOnDrawerCloseListener(android.widget.SlidingDrawer.OnDrawerCloseListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._setOnDrawerCloseListener11593, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerCloseListener11593, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDrawerScrollListener11594;
		public virtual void setOnDrawerScrollListener(android.widget.SlidingDrawer.OnDrawerScrollListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._setOnDrawerScrollListener11594, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerScrollListener11594, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHandle11595;
		public virtual global::android.view.View getHandle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SlidingDrawer._getHandle11595));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getHandle11595));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpened11596;
		public virtual bool isOpened() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SlidingDrawer._isOpened11596);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isOpened11596);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMoving11597;
		public virtual bool isMoving() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SlidingDrawer._isMoving11597);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isMoving11597);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SlidingDrawer11598;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer11598, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SlidingDrawer11599;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer11599, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.SlidingDrawer.staticClass = @__class;
			global::android.widget.SlidingDrawer._lock11577 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "@lock", "()V");
			global::android.widget.SlidingDrawer._close11578 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "close", "()V");
			global::android.widget.SlidingDrawer._getContent11579 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "getContent", "()Landroid/view/View;");
			global::android.widget.SlidingDrawer._open11580 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "open", "()V");
			global::android.widget.SlidingDrawer._unlock11581 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "unlock", "()V");
			global::android.widget.SlidingDrawer._toggle11582 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "toggle", "()V");
			global::android.widget.SlidingDrawer._onTouchEvent11583 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.SlidingDrawer._dispatchDraw11584 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.SlidingDrawer._onLayout11585 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.SlidingDrawer._onFinishInflate11586 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onFinishInflate", "()V");
			global::android.widget.SlidingDrawer._onMeasure11587 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onMeasure", "(II)V");
			global::android.widget.SlidingDrawer._onInterceptTouchEvent11588 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.SlidingDrawer._animateToggle11589 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "animateToggle", "()V");
			global::android.widget.SlidingDrawer._animateClose11590 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "animateClose", "()V");
			global::android.widget.SlidingDrawer._animateOpen11591 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "animateOpen", "()V");
			global::android.widget.SlidingDrawer._setOnDrawerOpenListener11592 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V");
			global::android.widget.SlidingDrawer._setOnDrawerCloseListener11593 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V");
			global::android.widget.SlidingDrawer._setOnDrawerScrollListener11594 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V");
			global::android.widget.SlidingDrawer._getHandle11595 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "getHandle", "()Landroid/view/View;");
			global::android.widget.SlidingDrawer._isOpened11596 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "isOpened", "()Z");
			global::android.widget.SlidingDrawer._isMoving11597 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "isMoving", "()Z");
			global::android.widget.SlidingDrawer._SlidingDrawer11598 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.SlidingDrawer._SlidingDrawer11599 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
