namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HorizontalScrollView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HorizontalScrollView()
		{
			InitJNI();
		}
		protected HorizontalScrollView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent11941;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onTouchEvent11941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onTouchEvent11941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent11942;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._dispatchKeyEvent11942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._dispatchKeyEvent11942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView11943;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView11943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView11944;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView11944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView11945;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView11945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView11946;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView11946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged11947;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onSizeChanged11947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onSizeChanged11947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo11948;
		public override void scrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._scrollTo11948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._scrollTo11948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll11949;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeScroll11949);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScroll11949);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength11950;
		protected override float getLeftFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength11950);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength11950);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength11951;
		protected override float getRightFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength11951);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength11951);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange11952;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange11952);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange11952);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset11953;
		protected override int computeHorizontalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset11953);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset11953);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout11954;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onLayout11954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onLayout11954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout11955;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._requestLayout11955);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestLayout11955);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11956;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onMeasure11956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onMeasure11956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus11957;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._requestChildFocus11957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildFocus11957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen11958;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen11958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen11958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent11959;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onInterceptTouchEvent11959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onInterceptTouchEvent11959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants11960;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants11960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants11960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild11961;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._measureChild11961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChild11961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins11962;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._measureChildWithMargins11962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChildWithMargins11962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount11963;
		public virtual int getMaxScrollAmount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._getMaxScrollAmount11963);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getMaxScrollAmount11963);
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy11964;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._smoothScrollBy11964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollBy11964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fling11965;
		public virtual void fling(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._fling11965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fling11965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillViewport11966;
		public virtual bool isFillViewport() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._isFillViewport11966);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isFillViewport11966);
		}
		internal static global::MonoJavaBridge.MethodId _setFillViewport11967;
		public virtual void setFillViewport(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._setFillViewport11967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setFillViewport11967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollingEnabled11968;
		public virtual bool isSmoothScrollingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled11968);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled11968);
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollingEnabled11969;
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled11969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled11969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeKeyEvent11970;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._executeKeyEvent11970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._executeKeyEvent11970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageScroll11971;
		public virtual bool pageScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._pageScroll11971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._pageScroll11971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fullScroll11972;
		public virtual bool fullScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._fullScroll11972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fullScroll11972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _arrowScroll11973;
		public virtual bool arrowScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._arrowScroll11973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._arrowScroll11973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollTo11974;
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._smoothScrollTo11974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollTo11974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollDeltaToGetChildRectOnScreen11975;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen11975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen11975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView11976;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView11976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView11977;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView11977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView11978;
		public HorizontalScrollView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView11978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HorizontalScrollView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HorizontalScrollView"));
			global::android.widget.HorizontalScrollView._onTouchEvent11941 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._dispatchKeyEvent11942 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._addView11943 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._addView11944 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.HorizontalScrollView._addView11945 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._addView11946 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._onSizeChanged11947 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.HorizontalScrollView._scrollTo11948 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "scrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScroll11949 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeScroll", "()V");
			global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength11950 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength11951 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollRange11952 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset11953 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.widget.HorizontalScrollView._onLayout11954 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.HorizontalScrollView._requestLayout11955 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestLayout", "()V");
			global::android.widget.HorizontalScrollView._onMeasure11956 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onMeasure", "(II)V");
			global::android.widget.HorizontalScrollView._requestChildFocus11957 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen11958 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.HorizontalScrollView._onInterceptTouchEvent11959 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._onRequestFocusInDescendants11960 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.widget.HorizontalScrollView._measureChild11961 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.widget.HorizontalScrollView._measureChildWithMargins11962 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.widget.HorizontalScrollView._getMaxScrollAmount11963 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.HorizontalScrollView._smoothScrollBy11964 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.HorizontalScrollView._fling11965 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "fling", "(I)V");
			global::android.widget.HorizontalScrollView._isFillViewport11966 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "isFillViewport", "()Z");
			global::android.widget.HorizontalScrollView._setFillViewport11967 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "setFillViewport", "(Z)V");
			global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled11968 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled11969 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::android.widget.HorizontalScrollView._executeKeyEvent11970 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._pageScroll11971 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "pageScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._fullScroll11972 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "fullScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._arrowScroll11973 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "arrowScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._smoothScrollTo11974 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen11975 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			global::android.widget.HorizontalScrollView._HorizontalScrollView11976 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView11977 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView11978 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
