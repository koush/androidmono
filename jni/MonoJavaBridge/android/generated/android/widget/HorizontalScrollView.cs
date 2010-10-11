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
		internal static global::MonoJavaBridge.MethodId _onTouchEvent11395;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onTouchEvent11395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onTouchEvent11395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent11396;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._dispatchKeyEvent11396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._dispatchKeyEvent11396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView11397;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView11397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView11398;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView11398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView11399;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView11399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView11400;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView11400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView11400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged11401;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onSizeChanged11401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onSizeChanged11401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo11402;
		public override void scrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._scrollTo11402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._scrollTo11402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll11403;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeScroll11403);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScroll11403);
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength11404;
		protected override float getLeftFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength11404);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength11404);
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength11405;
		protected override float getRightFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength11405);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength11405);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange11406;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange11406);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange11406);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset11407;
		protected override int computeHorizontalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset11407);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset11407);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout11408;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onLayout11408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onLayout11408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout11409;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._requestLayout11409);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestLayout11409);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11410;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onMeasure11410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onMeasure11410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus11411;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._requestChildFocus11411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildFocus11411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen11412;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen11412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen11412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent11413;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onInterceptTouchEvent11413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onInterceptTouchEvent11413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants11414;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants11414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants11414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild11415;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._measureChild11415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChild11415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins11416;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._measureChildWithMargins11416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChildWithMargins11416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount11417;
		public virtual int getMaxScrollAmount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._getMaxScrollAmount11417);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getMaxScrollAmount11417);
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy11418;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._smoothScrollBy11418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollBy11418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fling11419;
		public virtual void fling(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._fling11419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fling11419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillViewport11420;
		public virtual bool isFillViewport() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._isFillViewport11420);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isFillViewport11420);
		}
		internal static global::MonoJavaBridge.MethodId _setFillViewport11421;
		public virtual void setFillViewport(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._setFillViewport11421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setFillViewport11421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollingEnabled11422;
		public virtual bool isSmoothScrollingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled11422);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled11422);
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollingEnabled11423;
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled11423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled11423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeKeyEvent11424;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._executeKeyEvent11424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._executeKeyEvent11424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageScroll11425;
		public virtual bool pageScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._pageScroll11425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._pageScroll11425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fullScroll11426;
		public virtual bool fullScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._fullScroll11426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fullScroll11426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _arrowScroll11427;
		public virtual bool arrowScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._arrowScroll11427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._arrowScroll11427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollTo11428;
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._smoothScrollTo11428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollTo11428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollDeltaToGetChildRectOnScreen11429;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen11429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen11429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView11430;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView11430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView11431;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView11431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView11432;
		public HorizontalScrollView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView11432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HorizontalScrollView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HorizontalScrollView"));
			global::android.widget.HorizontalScrollView._onTouchEvent11395 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._dispatchKeyEvent11396 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._addView11397 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._addView11398 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.HorizontalScrollView._addView11399 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._addView11400 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._onSizeChanged11401 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.HorizontalScrollView._scrollTo11402 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "scrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScroll11403 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeScroll", "()V");
			global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength11404 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength11405 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollRange11406 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset11407 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.widget.HorizontalScrollView._onLayout11408 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.HorizontalScrollView._requestLayout11409 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestLayout", "()V");
			global::android.widget.HorizontalScrollView._onMeasure11410 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onMeasure", "(II)V");
			global::android.widget.HorizontalScrollView._requestChildFocus11411 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen11412 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.HorizontalScrollView._onInterceptTouchEvent11413 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._onRequestFocusInDescendants11414 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.widget.HorizontalScrollView._measureChild11415 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.widget.HorizontalScrollView._measureChildWithMargins11416 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.widget.HorizontalScrollView._getMaxScrollAmount11417 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.HorizontalScrollView._smoothScrollBy11418 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.HorizontalScrollView._fling11419 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "fling", "(I)V");
			global::android.widget.HorizontalScrollView._isFillViewport11420 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "isFillViewport", "()Z");
			global::android.widget.HorizontalScrollView._setFillViewport11421 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "setFillViewport", "(Z)V");
			global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled11422 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled11423 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::android.widget.HorizontalScrollView._executeKeyEvent11424 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._pageScroll11425 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "pageScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._fullScroll11426 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "fullScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._arrowScroll11427 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "arrowScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._smoothScrollTo11428 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen11429 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			global::android.widget.HorizontalScrollView._HorizontalScrollView11430 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView11431 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView11432 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
