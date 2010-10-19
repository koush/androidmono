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
		internal static global::MonoJavaBridge.MethodId _onTouchEvent12383;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._onTouchEvent12383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onTouchEvent12383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent12384;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._dispatchKeyEvent12384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._dispatchKeyEvent12384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView12385;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._addView12385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView12385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView12386;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._addView12386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView12386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView12387;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._addView12387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView12387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView12388;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._addView12388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView12388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged12389;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._onSizeChanged12389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onSizeChanged12389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo12390;
		public override void scrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._scrollTo12390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._scrollTo12390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll12391;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._computeScroll12391);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScroll12391);
		}
		protected new float TopFadingEdgeStrength
		{
			get
			{
				return getTopFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength12392;
		protected override float getTopFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.ScrollView._getTopFadingEdgeStrength12392);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getTopFadingEdgeStrength12392);
		}
		protected new float BottomFadingEdgeStrength
		{
			get
			{
				return getBottomFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength12393;
		protected override float getBottomFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.ScrollView._getBottomFadingEdgeStrength12393);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getBottomFadingEdgeStrength12393);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange12394;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ScrollView._computeVerticalScrollRange12394);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeVerticalScrollRange12394);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset12395;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ScrollView._computeVerticalScrollOffset12395);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeVerticalScrollOffset12395);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout12396;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._onLayout12396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onLayout12396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout12397;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._requestLayout12397);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestLayout12397);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12398;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._onMeasure12398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onMeasure12398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus12399;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._requestChildFocus12399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildFocus12399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen12400;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._requestChildRectangleOnScreen12400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildRectangleOnScreen12400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent12401;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._onInterceptTouchEvent12401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onInterceptTouchEvent12401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants12402;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._onRequestFocusInDescendants12402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onRequestFocusInDescendants12402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild12403;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._measureChild12403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChild12403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins12404;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._measureChildWithMargins12404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChildWithMargins12404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount12405;
		public virtual int getMaxScrollAmount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ScrollView._getMaxScrollAmount12405);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getMaxScrollAmount12405);
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy12406;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._smoothScrollBy12406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollBy12406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fling12407;
		public virtual void fling(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._fling12407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fling12407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillViewport12408;
		public virtual bool isFillViewport() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._isFillViewport12408);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isFillViewport12408);
		}
		internal static global::MonoJavaBridge.MethodId _setFillViewport12409;
		public virtual void setFillViewport(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._setFillViewport12409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setFillViewport12409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollingEnabled12410;
		public virtual bool isSmoothScrollingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._isSmoothScrollingEnabled12410);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isSmoothScrollingEnabled12410);
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollingEnabled12411;
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._setSmoothScrollingEnabled12411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setSmoothScrollingEnabled12411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeKeyEvent12412;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._executeKeyEvent12412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._executeKeyEvent12412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageScroll12413;
		public virtual bool pageScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._pageScroll12413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._pageScroll12413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fullScroll12414;
		public virtual bool fullScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._fullScroll12414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fullScroll12414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _arrowScroll12415;
		public virtual bool arrowScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ScrollView._arrowScroll12415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._arrowScroll12415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollTo12416;
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ScrollView._smoothScrollTo12416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollTo12416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollDeltaToGetChildRectOnScreen12417;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen12417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen12417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ScrollView12418;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView12418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScrollView12419;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView12419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScrollView12420;
		public ScrollView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView12420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ScrollView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ScrollView"));
			global::android.widget.ScrollView._onTouchEvent12383 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ScrollView._dispatchKeyEvent12384 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ScrollView._addView12385 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.ScrollView._addView12386 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.ScrollView._addView12387 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ScrollView._addView12388 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ScrollView._onSizeChanged12389 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ScrollView._scrollTo12390 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "scrollTo", "(II)V");
			global::android.widget.ScrollView._computeScroll12391 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeScroll", "()V");
			global::android.widget.ScrollView._getTopFadingEdgeStrength12392 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "getTopFadingEdgeStrength", "()F");
			global::android.widget.ScrollView._getBottomFadingEdgeStrength12393 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "getBottomFadingEdgeStrength", "()F");
			global::android.widget.ScrollView._computeVerticalScrollRange12394 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.ScrollView._computeVerticalScrollOffset12395 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.ScrollView._onLayout12396 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.ScrollView._requestLayout12397 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "requestLayout", "()V");
			global::android.widget.ScrollView._onMeasure12398 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ScrollView._requestChildFocus12399 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.ScrollView._requestChildRectangleOnScreen12400 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.ScrollView._onInterceptTouchEvent12401 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ScrollView._onRequestFocusInDescendants12402 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.widget.ScrollView._measureChild12403 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.widget.ScrollView._measureChildWithMargins12404 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.widget.ScrollView._getMaxScrollAmount12405 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.ScrollView._smoothScrollBy12406 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.ScrollView._fling12407 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "fling", "(I)V");
			global::android.widget.ScrollView._isFillViewport12408 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "isFillViewport", "()Z");
			global::android.widget.ScrollView._setFillViewport12409 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "setFillViewport", "(Z)V");
			global::android.widget.ScrollView._isSmoothScrollingEnabled12410 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			global::android.widget.ScrollView._setSmoothScrollingEnabled12411 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::android.widget.ScrollView._executeKeyEvent12412 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.ScrollView._pageScroll12413 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "pageScroll", "(I)Z");
			global::android.widget.ScrollView._fullScroll12414 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "fullScroll", "(I)Z");
			global::android.widget.ScrollView._arrowScroll12415 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "arrowScroll", "(I)Z");
			global::android.widget.ScrollView._smoothScrollTo12416 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen12417 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			global::android.widget.ScrollView._ScrollView12418 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ScrollView._ScrollView12419 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ScrollView._ScrollView12420 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
