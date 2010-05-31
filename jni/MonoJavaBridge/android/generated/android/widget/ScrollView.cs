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
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10739;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._onTouchEvent10739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onTouchEvent10739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent10740;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._dispatchKeyEvent10740, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._dispatchKeyEvent10740, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10741;
		public override void addView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._addView10741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView10741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10742;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._addView10742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView10742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10743;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._addView10743, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView10743, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10744;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._addView10744, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView10744, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged10745;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._onSizeChanged10745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onSizeChanged10745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo10746;
		public override void scrollTo(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._scrollTo10746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._scrollTo10746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll10747;
		public override void computeScroll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._computeScroll10747);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScroll10747);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopFadingEdgeStrength10748;
		protected override float getTopFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.ScrollView._getTopFadingEdgeStrength10748);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getTopFadingEdgeStrength10748);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomFadingEdgeStrength10749;
		protected override float getBottomFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.ScrollView._getBottomFadingEdgeStrength10749);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getBottomFadingEdgeStrength10749);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange10750;
		protected override int computeVerticalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ScrollView._computeVerticalScrollRange10750);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeVerticalScrollRange10750);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10751;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._onLayout10751, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onLayout10751, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout10752;
		public override void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._requestLayout10752);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestLayout10752);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10753;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._onMeasure10753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onMeasure10753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus10754;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._requestChildFocus10754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildFocus10754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen10755;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._requestChildRectangleOnScreen10755, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildRectangleOnScreen10755, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent10756;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._onInterceptTouchEvent10756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onInterceptTouchEvent10756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocusInDescendants10757;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._onRequestFocusInDescendants10757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onRequestFocusInDescendants10757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureChild10758;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._measureChild10758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChild10758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureChildWithMargins10759;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._measureChildWithMargins10759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChildWithMargins10759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxScrollAmount10760;
		public virtual int getMaxScrollAmount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ScrollView._getMaxScrollAmount10760);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getMaxScrollAmount10760);
		}
		internal static global::net.sf.jni4net.jni.MethodId _fling10761;
		public virtual void fling(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._fling10761, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fling10761, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFillViewport10762;
		public virtual bool isFillViewport() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._isFillViewport10762);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isFillViewport10762);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFillViewport10763;
		public virtual void setFillViewport(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._setFillViewport10763, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setFillViewport10763, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSmoothScrollingEnabled10764;
		public virtual bool isSmoothScrollingEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._isSmoothScrollingEnabled10764);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isSmoothScrollingEnabled10764);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSmoothScrollingEnabled10765;
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._setSmoothScrollingEnabled10765, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setSmoothScrollingEnabled10765, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _executeKeyEvent10766;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._executeKeyEvent10766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._executeKeyEvent10766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pageScroll10767;
		public virtual bool pageScroll(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._pageScroll10767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._pageScroll10767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fullScroll10768;
		public virtual bool fullScroll(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._fullScroll10768, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fullScroll10768, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _arrowScroll10769;
		public virtual bool arrowScroll(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ScrollView._arrowScroll10769, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._arrowScroll10769, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollBy10770;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._smoothScrollBy10770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollBy10770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollTo10771;
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ScrollView._smoothScrollTo10771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollTo10771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScrollDeltaToGetChildRectOnScreen10772;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen10772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen10772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScrollView10773;
		public ScrollView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView10773, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScrollView10774;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView10774, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScrollView10775;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView10775, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ScrollView.staticClass = @__class;
			global::android.widget.ScrollView._onTouchEvent10739 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ScrollView._dispatchKeyEvent10740 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ScrollView._addView10741 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.ScrollView._addView10742 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.ScrollView._addView10743 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ScrollView._addView10744 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ScrollView._onSizeChanged10745 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ScrollView._scrollTo10746 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "scrollTo", "(II)V");
			global::android.widget.ScrollView._computeScroll10747 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeScroll", "()V");
			global::android.widget.ScrollView._getTopFadingEdgeStrength10748 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.widget.ScrollView._getBottomFadingEdgeStrength10749 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.widget.ScrollView._computeVerticalScrollRange10750 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.ScrollView._onLayout10751 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.ScrollView._requestLayout10752 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "requestLayout", "()V");
			global::android.widget.ScrollView._onMeasure10753 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ScrollView._requestChildFocus10754 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.ScrollView._requestChildRectangleOnScreen10755 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.ScrollView._onInterceptTouchEvent10756 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ScrollView._onRequestFocusInDescendants10757 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.widget.ScrollView._measureChild10758 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.widget.ScrollView._measureChildWithMargins10759 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.widget.ScrollView._getMaxScrollAmount10760 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.ScrollView._fling10761 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "fling", "(I)V");
			global::android.widget.ScrollView._isFillViewport10762 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "isFillViewport", "()Z");
			global::android.widget.ScrollView._setFillViewport10763 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "setFillViewport", "(Z)V");
			global::android.widget.ScrollView._isSmoothScrollingEnabled10764 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			global::android.widget.ScrollView._setSmoothScrollingEnabled10765 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::android.widget.ScrollView._executeKeyEvent10766 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ScrollView._pageScroll10767 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "pageScroll", "(I)Z");
			global::android.widget.ScrollView._fullScroll10768 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "fullScroll", "(I)Z");
			global::android.widget.ScrollView._arrowScroll10769 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "arrowScroll", "(I)Z");
			global::android.widget.ScrollView._smoothScrollBy10770 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.ScrollView._smoothScrollTo10771 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen10772 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			global::android.widget.ScrollView._ScrollView10773 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ScrollView._ScrollView10774 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ScrollView._ScrollView10775 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
