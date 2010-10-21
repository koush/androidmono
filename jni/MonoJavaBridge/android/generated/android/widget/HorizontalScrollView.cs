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
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17101;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onTouchEvent17101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onTouchEvent17101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17102;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._dispatchKeyEvent17102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._dispatchKeyEvent17102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17103;
		public override void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView17103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView17103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17104;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView17104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView17104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17105;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView17105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView17105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17106;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._addView17106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView17106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17107;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onSizeChanged17107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onSizeChanged17107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo17108;
		public override void scrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._scrollTo17108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._scrollTo17108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll17109;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeScroll17109);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScroll17109);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength17110;
		protected override float getLeftFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength17110);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength17110);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength17111;
		protected override float getRightFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength17111);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength17111);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange17112;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange17112);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange17112);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset17113;
		protected override int computeHorizontalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset17113);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset17113);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17114;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onLayout17114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onLayout17114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout17115;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._requestLayout17115);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestLayout17115);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17116;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onMeasure17116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onMeasure17116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus17117;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._requestChildFocus17117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildFocus17117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen17118;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen17118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen17118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent17119;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onInterceptTouchEvent17119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onInterceptTouchEvent17119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants17120;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants17120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants17120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild17121;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._measureChild17121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChild17121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins17122;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._measureChildWithMargins17122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChildWithMargins17122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount17123;
		public virtual int getMaxScrollAmount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._getMaxScrollAmount17123);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getMaxScrollAmount17123);
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy17124;
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._smoothScrollBy17124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollBy17124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fling17125;
		public virtual void fling(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._fling17125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fling17125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillViewport17126;
		public virtual bool isFillViewport() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._isFillViewport17126);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isFillViewport17126);
		}
		internal static global::MonoJavaBridge.MethodId _setFillViewport17127;
		public virtual void setFillViewport(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._setFillViewport17127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setFillViewport17127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollingEnabled17128;
		public virtual bool isSmoothScrollingEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled17128);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled17128);
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollingEnabled17129;
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled17129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled17129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeKeyEvent17130;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._executeKeyEvent17130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._executeKeyEvent17130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageScroll17131;
		public virtual bool pageScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._pageScroll17131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._pageScroll17131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fullScroll17132;
		public virtual bool fullScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._fullScroll17132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fullScroll17132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _arrowScroll17133;
		public virtual bool arrowScroll(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._arrowScroll17133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._arrowScroll17133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollTo17134;
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._smoothScrollTo17134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollTo17134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollDeltaToGetChildRectOnScreen17135;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen17135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen17135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView17136;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView17136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView17137;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView17137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView17138;
		public HorizontalScrollView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView17138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HorizontalScrollView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HorizontalScrollView"));
			global::android.widget.HorizontalScrollView._onTouchEvent17101 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._dispatchKeyEvent17102 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._addView17103 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._addView17104 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.HorizontalScrollView._addView17105 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._addView17106 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._onSizeChanged17107 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.HorizontalScrollView._scrollTo17108 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "scrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScroll17109 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeScroll", "()V");
			global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength17110 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength17111 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollRange17112 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset17113 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.widget.HorizontalScrollView._onLayout17114 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.HorizontalScrollView._requestLayout17115 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestLayout", "()V");
			global::android.widget.HorizontalScrollView._onMeasure17116 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onMeasure", "(II)V");
			global::android.widget.HorizontalScrollView._requestChildFocus17117 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen17118 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.HorizontalScrollView._onInterceptTouchEvent17119 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._onRequestFocusInDescendants17120 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.widget.HorizontalScrollView._measureChild17121 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.widget.HorizontalScrollView._measureChildWithMargins17122 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.widget.HorizontalScrollView._getMaxScrollAmount17123 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.HorizontalScrollView._smoothScrollBy17124 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.HorizontalScrollView._fling17125 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "fling", "(I)V");
			global::android.widget.HorizontalScrollView._isFillViewport17126 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "isFillViewport", "()Z");
			global::android.widget.HorizontalScrollView._setFillViewport17127 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "setFillViewport", "(Z)V");
			global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled17128 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled17129 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::android.widget.HorizontalScrollView._executeKeyEvent17130 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._pageScroll17131 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "pageScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._fullScroll17132 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "fullScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._arrowScroll17133 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "arrowScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._smoothScrollTo17134 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen17135 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			global::android.widget.HorizontalScrollView._HorizontalScrollView17136 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView17137 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView17138 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
