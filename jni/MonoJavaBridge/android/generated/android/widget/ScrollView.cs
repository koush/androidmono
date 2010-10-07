namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ScrollView : android.widget.FrameLayout
	{
		internal new static global::java.lang.Class staticClass;
		static ScrollView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ScrollView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ScrollView(@__env);
			}
		}
		protected ScrollView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11451;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._onTouchEvent11451, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onTouchEvent11451, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent11452;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._dispatchKeyEvent11452, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._dispatchKeyEvent11452, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11453;
		public override void addView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._addView11453, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView11453, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11454;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._addView11454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView11454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11455;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._addView11455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView11455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11456;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._addView11456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView11456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged11457;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._onSizeChanged11457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onSizeChanged11457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo11458;
		public override void scrollTo(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._scrollTo11458, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._scrollTo11458, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll11459;
		public override void computeScroll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._computeScroll11459);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScroll11459);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopFadingEdgeStrength11460;
		protected override float getTopFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.ScrollView._getTopFadingEdgeStrength11460);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getTopFadingEdgeStrength11460);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomFadingEdgeStrength11461;
		protected override float getBottomFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.ScrollView._getBottomFadingEdgeStrength11461);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getBottomFadingEdgeStrength11461);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange11462;
		protected override int computeVerticalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ScrollView._computeVerticalScrollRange11462);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeVerticalScrollRange11462);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset11463;
		protected override int computeVerticalScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ScrollView._computeVerticalScrollOffset11463);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeVerticalScrollOffset11463);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout11464;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._onLayout11464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onLayout11464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout11465;
		public override void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._requestLayout11465);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestLayout11465);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11466;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._onMeasure11466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onMeasure11466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus11467;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._requestChildFocus11467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildFocus11467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen11468;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._requestChildRectangleOnScreen11468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildRectangleOnScreen11468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent11469;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._onInterceptTouchEvent11469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onInterceptTouchEvent11469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocusInDescendants11470;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._onRequestFocusInDescendants11470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onRequestFocusInDescendants11470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureChild11471;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._measureChild11471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChild11471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureChildWithMargins11472;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._measureChildWithMargins11472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChildWithMargins11472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxScrollAmount11473;
		public virtual int getMaxScrollAmount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ScrollView._getMaxScrollAmount11473);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getMaxScrollAmount11473);
		}
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollBy11474;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._smoothScrollBy11474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollBy11474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fling11475;
		public virtual void fling(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._fling11475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fling11475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFillViewport11476;
		public virtual bool isFillViewport() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._isFillViewport11476);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isFillViewport11476);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFillViewport11477;
		public virtual void setFillViewport(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._setFillViewport11477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setFillViewport11477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSmoothScrollingEnabled11478;
		public virtual bool isSmoothScrollingEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._isSmoothScrollingEnabled11478);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isSmoothScrollingEnabled11478);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSmoothScrollingEnabled11479;
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._setSmoothScrollingEnabled11479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setSmoothScrollingEnabled11479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _executeKeyEvent11480;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._executeKeyEvent11480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._executeKeyEvent11480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pageScroll11481;
		public virtual bool pageScroll(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._pageScroll11481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._pageScroll11481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fullScroll11482;
		public virtual bool fullScroll(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._fullScroll11482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fullScroll11482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _arrowScroll11483;
		public virtual bool arrowScroll(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._arrowScroll11483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._arrowScroll11483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollTo11484;
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._smoothScrollTo11484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollTo11484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScrollDeltaToGetChildRectOnScreen11485;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen11485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen11485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScrollView11486;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView11486, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScrollView11487;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView11487, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScrollView11488;
		public ScrollView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView11488, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ScrollView.staticClass = @__class;
			global::android.widget.ScrollView._onTouchEvent11451 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ScrollView._dispatchKeyEvent11452 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ScrollView._addView11453 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.ScrollView._addView11454 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.ScrollView._addView11455 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ScrollView._addView11456 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ScrollView._onSizeChanged11457 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ScrollView._scrollTo11458 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "scrollTo", "(II)V");
			global::android.widget.ScrollView._computeScroll11459 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeScroll", "()V");
			global::android.widget.ScrollView._getTopFadingEdgeStrength11460 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.widget.ScrollView._getBottomFadingEdgeStrength11461 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.widget.ScrollView._computeVerticalScrollRange11462 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.ScrollView._computeVerticalScrollOffset11463 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.ScrollView._onLayout11464 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.ScrollView._requestLayout11465 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "requestLayout", "()V");
			global::android.widget.ScrollView._onMeasure11466 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ScrollView._requestChildFocus11467 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.ScrollView._requestChildRectangleOnScreen11468 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.ScrollView._onInterceptTouchEvent11469 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ScrollView._onRequestFocusInDescendants11470 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.widget.ScrollView._measureChild11471 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.widget.ScrollView._measureChildWithMargins11472 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.widget.ScrollView._getMaxScrollAmount11473 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.ScrollView._smoothScrollBy11474 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.ScrollView._fling11475 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "fling", "(I)V");
			global::android.widget.ScrollView._isFillViewport11476 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "isFillViewport", "()Z");
			global::android.widget.ScrollView._setFillViewport11477 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "setFillViewport", "(Z)V");
			global::android.widget.ScrollView._isSmoothScrollingEnabled11478 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			global::android.widget.ScrollView._setSmoothScrollingEnabled11479 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::android.widget.ScrollView._executeKeyEvent11480 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ScrollView._pageScroll11481 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "pageScroll", "(I)Z");
			global::android.widget.ScrollView._fullScroll11482 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "fullScroll", "(I)Z");
			global::android.widget.ScrollView._arrowScroll11483 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "arrowScroll", "(I)Z");
			global::android.widget.ScrollView._smoothScrollTo11484 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen11485 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			global::android.widget.ScrollView._ScrollView11486 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ScrollView._ScrollView11487 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ScrollView._ScrollView11488 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
