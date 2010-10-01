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
			internal static global::net.sf.jni4net.jni.MethodId _onDrawerClosed10862;
			 void android.widget.SlidingDrawer.OnDrawerCloseListener.onDrawerClosed() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerCloseListener._onDrawerClosed10862);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerCloseListener.staticClass, global::android.widget.SlidingDrawer.__OnDrawerCloseListener._onDrawerClosed10862);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SlidingDrawer.__OnDrawerCloseListener.staticClass = @__class;
				global::android.widget.SlidingDrawer.__OnDrawerCloseListener._onDrawerClosed10862 = @__env.GetMethodID(global::android.widget.SlidingDrawer.__OnDrawerCloseListener.staticClass, "android.widget.SlidingDrawer.OnDrawerCloseListener.onDrawerClosed", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onDrawerOpened10863;
			 void android.widget.SlidingDrawer.OnDrawerOpenListener.onDrawerOpened() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerOpenListener._onDrawerOpened10863);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerOpenListener.staticClass, global::android.widget.SlidingDrawer.__OnDrawerOpenListener._onDrawerOpened10863);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SlidingDrawer.__OnDrawerOpenListener.staticClass = @__class;
				global::android.widget.SlidingDrawer.__OnDrawerOpenListener._onDrawerOpened10863 = @__env.GetMethodID(global::android.widget.SlidingDrawer.__OnDrawerOpenListener.staticClass, "android.widget.SlidingDrawer.OnDrawerOpenListener.onDrawerOpened", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onScrollStarted10864;
			 void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollStarted() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollStarted10864);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass, global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollStarted10864);
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScrollEnded10865;
			 void android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollEnded() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollEnded10865);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass, global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollEnded10865);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass = @__class;
				global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollStarted10864 = @__env.GetMethodID(global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass, "android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollStarted", "()V");
				global::android.widget.SlidingDrawer.__OnDrawerScrollListener._onScrollEnded10865 = @__env.GetMethodID(global::android.widget.SlidingDrawer.__OnDrawerScrollListener.staticClass, "android.widget.SlidingDrawer.OnDrawerScrollListener.onScrollEnded", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _lock10866;
		public virtual void @lock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._lock10866);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._lock10866);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close10867;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._close10867);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._close10867);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContent10868;
		public virtual global::android.view.View getContent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SlidingDrawer._getContent10868));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getContent10868));
		}
		internal static global::net.sf.jni4net.jni.MethodId _open10869;
		public virtual void open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._open10869);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._open10869);
		}
		internal static global::net.sf.jni4net.jni.MethodId _unlock10870;
		public virtual void unlock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._unlock10870);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._unlock10870);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toggle10871;
		public virtual void toggle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._toggle10871);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._toggle10871);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10872;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SlidingDrawer._onTouchEvent10872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onTouchEvent10872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw10873;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._dispatchDraw10873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._dispatchDraw10873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10874;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._onLayout10874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onLayout10874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate10875;
		protected override void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._onFinishInflate10875);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onFinishInflate10875);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10876;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._onMeasure10876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onMeasure10876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent10877;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SlidingDrawer._onInterceptTouchEvent10877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._onInterceptTouchEvent10877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _animateToggle10878;
		public virtual void animateToggle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._animateToggle10878);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateToggle10878);
		}
		internal static global::net.sf.jni4net.jni.MethodId _animateClose10879;
		public virtual void animateClose() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._animateClose10879);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateClose10879);
		}
		internal static global::net.sf.jni4net.jni.MethodId _animateOpen10880;
		public virtual void animateOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._animateOpen10880);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._animateOpen10880);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDrawerOpenListener10881;
		public virtual void setOnDrawerOpenListener(android.widget.SlidingDrawer.OnDrawerOpenListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._setOnDrawerOpenListener10881, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerOpenListener10881, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDrawerCloseListener10882;
		public virtual void setOnDrawerCloseListener(android.widget.SlidingDrawer.OnDrawerCloseListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._setOnDrawerCloseListener10882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerCloseListener10882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDrawerScrollListener10883;
		public virtual void setOnDrawerScrollListener(android.widget.SlidingDrawer.OnDrawerScrollListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.SlidingDrawer._setOnDrawerScrollListener10883, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._setOnDrawerScrollListener10883, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHandle10884;
		public virtual global::android.view.View getHandle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.SlidingDrawer._getHandle10884));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._getHandle10884));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpened10885;
		public virtual bool isOpened() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SlidingDrawer._isOpened10885);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isOpened10885);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMoving10886;
		public virtual bool isMoving() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.SlidingDrawer._isMoving10886);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._isMoving10886);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SlidingDrawer10887;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer10887, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SlidingDrawer10888;
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.SlidingDrawer.staticClass, global::android.widget.SlidingDrawer._SlidingDrawer10888, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
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
			global::android.widget.SlidingDrawer._lock10866 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "@lock", "()V");
			global::android.widget.SlidingDrawer._close10867 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "close", "()V");
			global::android.widget.SlidingDrawer._getContent10868 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "getContent", "()Landroid/view/View;");
			global::android.widget.SlidingDrawer._open10869 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "open", "()V");
			global::android.widget.SlidingDrawer._unlock10870 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "unlock", "()V");
			global::android.widget.SlidingDrawer._toggle10871 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "toggle", "()V");
			global::android.widget.SlidingDrawer._onTouchEvent10872 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.SlidingDrawer._dispatchDraw10873 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.SlidingDrawer._onLayout10874 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.SlidingDrawer._onFinishInflate10875 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onFinishInflate", "()V");
			global::android.widget.SlidingDrawer._onMeasure10876 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onMeasure", "(II)V");
			global::android.widget.SlidingDrawer._onInterceptTouchEvent10877 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.SlidingDrawer._animateToggle10878 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "animateToggle", "()V");
			global::android.widget.SlidingDrawer._animateClose10879 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "animateClose", "()V");
			global::android.widget.SlidingDrawer._animateOpen10880 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "animateOpen", "()V");
			global::android.widget.SlidingDrawer._setOnDrawerOpenListener10881 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V");
			global::android.widget.SlidingDrawer._setOnDrawerCloseListener10882 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V");
			global::android.widget.SlidingDrawer._setOnDrawerScrollListener10883 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V");
			global::android.widget.SlidingDrawer._getHandle10884 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "getHandle", "()Landroid/view/View;");
			global::android.widget.SlidingDrawer._isOpened10885 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "isOpened", "()Z");
			global::android.widget.SlidingDrawer._isMoving10886 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "isMoving", "()Z");
			global::android.widget.SlidingDrawer._SlidingDrawer10887 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.SlidingDrawer._SlidingDrawer10888 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
