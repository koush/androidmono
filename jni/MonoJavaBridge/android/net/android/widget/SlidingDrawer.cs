namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SlidingDrawer : android.view.ViewGroup
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SlidingDrawer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.SlidingDrawer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnDrawerOpenListener 
		{ 
			void onDrawerOpened(); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnDrawerScrollListener 
		{ 
			void onScrollStarted(); 
			void onScrollEnded(); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lock10076; 
		public virtual void @lock() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _lock10076); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _lock10076); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close10077; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _close10077); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _close10077); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _open10078; 
		public virtual void open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _open10078); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _open10078); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContent10079; 
		public virtual android.view.View getContent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getContent10079)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SlidingDrawer.staticClass, _getContent10079)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unlock10080; 
		public virtual void unlock() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _unlock10080); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _unlock10080); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toggle10081; 
		public virtual void toggle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _toggle10081); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _toggle10081); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10082; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent10082, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.SlidingDrawer.staticClass, _onTouchEvent10082, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw10083; 
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _dispatchDraw10083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _dispatchDraw10083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10084; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _onLayout10084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _onLayout10084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate10085; 
		protected override void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _onFinishInflate10085); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _onFinishInflate10085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10086; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _onMeasure10086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _onMeasure10086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent10087; 
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				return @__env.CallBooleanMethod(this, _onInterceptTouchEvent10087, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.SlidingDrawer.staticClass, _onInterceptTouchEvent10087, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _animateToggle10088; 
		public virtual void animateToggle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _animateToggle10088); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _animateToggle10088); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _animateClose10089; 
		public virtual void animateClose() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _animateClose10089); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _animateClose10089); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _animateOpen10090; 
		public virtual void animateOpen() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _animateOpen10090); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _animateOpen10090); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDrawerOpenListener10091; 
		public virtual void setOnDrawerOpenListener(android.widget.SlidingDrawer.OnDrawerOpenListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _setOnDrawerOpenListener10091, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _setOnDrawerOpenListener10091, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDrawerCloseListener10092; 
		public virtual void setOnDrawerCloseListener(android.widget.SlidingDrawer.OnDrawerCloseListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _setOnDrawerCloseListener10092, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _setOnDrawerCloseListener10092, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDrawerScrollListener10093; 
		public virtual void setOnDrawerScrollListener(android.widget.SlidingDrawer.OnDrawerScrollListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				@__env.CallVoidMethod(this, _setOnDrawerScrollListener10093, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SlidingDrawer.staticClass, _setOnDrawerScrollListener10093, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHandle10094; 
		public virtual android.view.View getHandle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getHandle10094)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.SlidingDrawer.staticClass, _getHandle10094)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpened10095; 
		public virtual bool isOpened() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				return @__env.CallBooleanMethod(this, _isOpened10095); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.SlidingDrawer.staticClass, _isOpened10095); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMoving10096; 
		public virtual bool isMoving() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SlidingDrawer)) 
				return @__env.CallBooleanMethod(this, _isMoving10096); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.SlidingDrawer.staticClass, _isMoving10096); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SlidingDrawer10097; 
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SlidingDrawer.staticClass, _SlidingDrawer10097, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SlidingDrawer10098; 
		public SlidingDrawer(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SlidingDrawer.staticClass, _SlidingDrawer10098, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
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
			global::android.widget.SlidingDrawer._lock10076 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "@lock", "()V"); 
			global::android.widget.SlidingDrawer._close10077 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "close", "()V"); 
			global::android.widget.SlidingDrawer._open10078 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "open", "()V"); 
			global::android.widget.SlidingDrawer._getContent10079 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "getContent", "()Landroid/view/View;"); 
			global::android.widget.SlidingDrawer._unlock10080 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "unlock", "()V"); 
			global::android.widget.SlidingDrawer._toggle10081 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "toggle", "()V"); 
			global::android.widget.SlidingDrawer._onTouchEvent10082 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.SlidingDrawer._dispatchDraw10083 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.SlidingDrawer._onLayout10084 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.SlidingDrawer._onFinishInflate10085 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onFinishInflate", "()V"); 
			global::android.widget.SlidingDrawer._onMeasure10086 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.SlidingDrawer._onInterceptTouchEvent10087 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.SlidingDrawer._animateToggle10088 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "animateToggle", "()V"); 
			global::android.widget.SlidingDrawer._animateClose10089 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "animateClose", "()V"); 
			global::android.widget.SlidingDrawer._animateOpen10090 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "animateOpen", "()V"); 
			global::android.widget.SlidingDrawer._setOnDrawerOpenListener10091 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V"); 
			global::android.widget.SlidingDrawer._setOnDrawerCloseListener10092 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V"); 
			global::android.widget.SlidingDrawer._setOnDrawerScrollListener10093 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V"); 
			global::android.widget.SlidingDrawer._getHandle10094 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "getHandle", "()Landroid/view/View;"); 
			global::android.widget.SlidingDrawer._isOpened10095 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "isOpened", "()Z"); 
			global::android.widget.SlidingDrawer._isMoving10096 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "isMoving", "()Z"); 
			global::android.widget.SlidingDrawer._SlidingDrawer10097 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.SlidingDrawer._SlidingDrawer10098 = @__env.GetMethodID(global::android.widget.SlidingDrawer.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
