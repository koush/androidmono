namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class HorizontalScrollView : android.widget.FrameLayout
	{
		internal new static global::java.lang.Class staticClass;
		static HorizontalScrollView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.HorizontalScrollView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.HorizontalScrollView(@__env);
			}
		}
		protected HorizontalScrollView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11016;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._onTouchEvent11016, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onTouchEvent11016, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent11017;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._dispatchKeyEvent11017, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._dispatchKeyEvent11017, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11018;
		public override void addView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._addView11018, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11018, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11019;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._addView11019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11020;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._addView11020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11021;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._addView11021, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11021, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged11022;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._onSizeChanged11022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onSizeChanged11022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo11023;
		public override void scrollTo(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._scrollTo11023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._scrollTo11023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll11024;
		public override void computeScroll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._computeScroll11024);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScroll11024);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeftFadingEdgeStrength11025;
		protected override float getLeftFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength11025);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength11025);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRightFadingEdgeStrength11026;
		protected override float getRightFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength11026);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength11026);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange11027;
		protected override int computeHorizontalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange11027);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange11027);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollOffset11028;
		protected override int computeHorizontalScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset11028);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset11028);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout11029;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._onLayout11029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onLayout11029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout11030;
		public override void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._requestLayout11030);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestLayout11030);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11031;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._onMeasure11031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onMeasure11031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus11032;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._requestChildFocus11032, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildFocus11032, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen11033;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen11033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen11033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent11034;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._onInterceptTouchEvent11034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onInterceptTouchEvent11034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocusInDescendants11035;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants11035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants11035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureChild11036;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._measureChild11036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChild11036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureChildWithMargins11037;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._measureChildWithMargins11037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChildWithMargins11037, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxScrollAmount11038;
		public virtual int getMaxScrollAmount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.HorizontalScrollView._getMaxScrollAmount11038);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getMaxScrollAmount11038);
		}
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollBy11039;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._smoothScrollBy11039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollBy11039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fling11040;
		public virtual void fling(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._fling11040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fling11040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFillViewport11041;
		public virtual bool isFillViewport() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._isFillViewport11041);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isFillViewport11041);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFillViewport11042;
		public virtual void setFillViewport(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._setFillViewport11042, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setFillViewport11042, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSmoothScrollingEnabled11043;
		public virtual bool isSmoothScrollingEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled11043);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled11043);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSmoothScrollingEnabled11044;
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled11044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled11044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _executeKeyEvent11045;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._executeKeyEvent11045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._executeKeyEvent11045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pageScroll11046;
		public virtual bool pageScroll(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._pageScroll11046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._pageScroll11046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fullScroll11047;
		public virtual bool fullScroll(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._fullScroll11047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fullScroll11047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _arrowScroll11048;
		public virtual bool arrowScroll(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._arrowScroll11048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._arrowScroll11048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollTo11049;
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._smoothScrollTo11049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollTo11049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScrollDeltaToGetChildRectOnScreen11050;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen11050, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen11050, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HorizontalScrollView11051;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView11051, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HorizontalScrollView11052;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView11052, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HorizontalScrollView11053;
		public HorizontalScrollView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView11053, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.HorizontalScrollView.staticClass = @__class;
			global::android.widget.HorizontalScrollView._onTouchEvent11016 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._dispatchKeyEvent11017 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._addView11018 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._addView11019 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.HorizontalScrollView._addView11020 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._addView11021 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._onSizeChanged11022 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.HorizontalScrollView._scrollTo11023 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "scrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScroll11024 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeScroll", "()V");
			global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength11025 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength11026 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollRange11027 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset11028 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.widget.HorizontalScrollView._onLayout11029 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.HorizontalScrollView._requestLayout11030 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "requestLayout", "()V");
			global::android.widget.HorizontalScrollView._onMeasure11031 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onMeasure", "(II)V");
			global::android.widget.HorizontalScrollView._requestChildFocus11032 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen11033 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.HorizontalScrollView._onInterceptTouchEvent11034 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._onRequestFocusInDescendants11035 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.widget.HorizontalScrollView._measureChild11036 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.widget.HorizontalScrollView._measureChildWithMargins11037 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.widget.HorizontalScrollView._getMaxScrollAmount11038 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.HorizontalScrollView._smoothScrollBy11039 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.HorizontalScrollView._fling11040 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "fling", "(I)V");
			global::android.widget.HorizontalScrollView._isFillViewport11041 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "isFillViewport", "()Z");
			global::android.widget.HorizontalScrollView._setFillViewport11042 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "setFillViewport", "(Z)V");
			global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled11043 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled11044 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::android.widget.HorizontalScrollView._executeKeyEvent11045 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._pageScroll11046 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "pageScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._fullScroll11047 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "fullScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._arrowScroll11048 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "arrowScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._smoothScrollTo11049 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen11050 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			global::android.widget.HorizontalScrollView._HorizontalScrollView11051 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView11052 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView11053 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
