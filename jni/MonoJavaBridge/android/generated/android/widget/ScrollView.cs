namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScrollView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScrollView()
		{
			InitJNI();
		}
		protected ScrollView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17568;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._onTouchEvent17568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onTouchEvent17568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17569;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._dispatchKeyEvent17569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._dispatchKeyEvent17569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17570;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._addView17570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView17570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17571;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._addView17571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView17571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17572;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._addView17572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView17572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17573;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._addView17573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView17573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17574;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._onSizeChanged17574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onSizeChanged17574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo17575;
		public override void scrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._scrollTo17575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._scrollTo17575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll17576;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._computeScroll17576);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScroll17576);
		}
		protected new float TopFadingEdgeStrength
		{
			get
			{
				return getTopFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength17577;
		protected override float getTopFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.ScrollView._getTopFadingEdgeStrength17577);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getTopFadingEdgeStrength17577);
		}
		protected new float BottomFadingEdgeStrength
		{
			get
			{
				return getBottomFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength17578;
		protected override float getBottomFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.ScrollView._getBottomFadingEdgeStrength17578);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getBottomFadingEdgeStrength17578);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange17579;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ScrollView._computeVerticalScrollRange17579);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeVerticalScrollRange17579);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset17580;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ScrollView._computeVerticalScrollOffset17580);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeVerticalScrollOffset17580);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17581;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._onLayout17581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onLayout17581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout17582;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._requestLayout17582);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestLayout17582);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17583;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._onMeasure17583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onMeasure17583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus17584;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._requestChildFocus17584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildFocus17584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen17585;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._requestChildRectangleOnScreen17585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildRectangleOnScreen17585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent17586;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._onInterceptTouchEvent17586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onInterceptTouchEvent17586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants17587;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._onRequestFocusInDescendants17587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onRequestFocusInDescendants17587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild17588;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._measureChild17588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChild17588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins17589;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._measureChildWithMargins17589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChildWithMargins17589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount17590;
		public virtual int getMaxScrollAmount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ScrollView._getMaxScrollAmount17590);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getMaxScrollAmount17590);
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy17591;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._smoothScrollBy17591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollBy17591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fling17592;
		public virtual void fling(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._fling17592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fling17592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillViewport17593;
		public virtual bool isFillViewport() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._isFillViewport17593);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isFillViewport17593);
		}
		internal static global::MonoJavaBridge.MethodId _setFillViewport17594;
		public virtual void setFillViewport(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._setFillViewport17594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setFillViewport17594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollingEnabled17595;
		public virtual bool isSmoothScrollingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._isSmoothScrollingEnabled17595);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isSmoothScrollingEnabled17595);
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollingEnabled17596;
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._setSmoothScrollingEnabled17596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setSmoothScrollingEnabled17596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeKeyEvent17597;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._executeKeyEvent17597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._executeKeyEvent17597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageScroll17598;
		public virtual bool pageScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._pageScroll17598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._pageScroll17598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fullScroll17599;
		public virtual bool fullScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._fullScroll17599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fullScroll17599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _arrowScroll17600;
		public virtual bool arrowScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._arrowScroll17600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._arrowScroll17600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollTo17601;
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._smoothScrollTo17601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollTo17601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollDeltaToGetChildRectOnScreen17602;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen17602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen17602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ScrollView17603;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView17603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScrollView17604;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView17604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScrollView17605;
		public ScrollView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView17605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ScrollView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ScrollView"));
			global::android.widget.ScrollView._onTouchEvent17568 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ScrollView._dispatchKeyEvent17569 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ScrollView._addView17570 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.ScrollView._addView17571 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.ScrollView._addView17572 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ScrollView._addView17573 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ScrollView._onSizeChanged17574 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ScrollView._scrollTo17575 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "scrollTo", "(II)V");
			global::android.widget.ScrollView._computeScroll17576 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeScroll", "()V");
			global::android.widget.ScrollView._getTopFadingEdgeStrength17577 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.widget.ScrollView._getBottomFadingEdgeStrength17578 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.widget.ScrollView._computeVerticalScrollRange17579 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.ScrollView._computeVerticalScrollOffset17580 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.ScrollView._onLayout17581 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.ScrollView._requestLayout17582 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "requestLayout", "()V");
			global::android.widget.ScrollView._onMeasure17583 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ScrollView._requestChildFocus17584 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.ScrollView._requestChildRectangleOnScreen17585 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.ScrollView._onInterceptTouchEvent17586 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ScrollView._onRequestFocusInDescendants17587 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.widget.ScrollView._measureChild17588 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.widget.ScrollView._measureChildWithMargins17589 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.widget.ScrollView._getMaxScrollAmount17590 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.ScrollView._smoothScrollBy17591 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.ScrollView._fling17592 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "fling", "(I)V");
			global::android.widget.ScrollView._isFillViewport17593 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "isFillViewport", "()Z");
			global::android.widget.ScrollView._setFillViewport17594 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "setFillViewport", "(Z)V");
			global::android.widget.ScrollView._isSmoothScrollingEnabled17595 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			global::android.widget.ScrollView._setSmoothScrollingEnabled17596 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::android.widget.ScrollView._executeKeyEvent17597 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ScrollView._pageScroll17598 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "pageScroll", "(I)Z");
			global::android.widget.ScrollView._fullScroll17599 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "fullScroll", "(I)Z");
			global::android.widget.ScrollView._arrowScroll17600 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "arrowScroll", "(I)Z");
			global::android.widget.ScrollView._smoothScrollTo17601 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen17602 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			global::android.widget.ScrollView._ScrollView17603 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ScrollView._ScrollView17604 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ScrollView._ScrollView17605 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
