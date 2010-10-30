namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScrollView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScrollView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17675;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._onTouchEvent17675.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._onTouchEvent17675 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onTouchEvent17675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17676;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._dispatchKeyEvent17676.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._dispatchKeyEvent17676 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._dispatchKeyEvent17676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17677;
		public override void addView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._addView17677.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._addView17677 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView17677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17678;
		public override void addView(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._addView17678.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._addView17678 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView17678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17679;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._addView17679.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._addView17679 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView17679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17680;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._addView17680.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._addView17680 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._addView17680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17681;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._onSizeChanged17681.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._onSizeChanged17681 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onSizeChanged17681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo17682;
		public override void scrollTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._scrollTo17682.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._scrollTo17682 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "scrollTo", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._scrollTo17682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll17683;
		public override void computeScroll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._computeScroll17683.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._computeScroll17683 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeScroll", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScroll17683);
		}
		protected new float TopFadingEdgeStrength
		{
			get
			{
				return getTopFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopFadingEdgeStrength17684;
		protected override float getTopFadingEdgeStrength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._getTopFadingEdgeStrength17684.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._getTopFadingEdgeStrength17684 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "getTopFadingEdgeStrength", "()F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getTopFadingEdgeStrength17684);
		}
		protected new float BottomFadingEdgeStrength
		{
			get
			{
				return getBottomFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomFadingEdgeStrength17685;
		protected override float getBottomFadingEdgeStrength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._getBottomFadingEdgeStrength17685.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._getBottomFadingEdgeStrength17685 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "getBottomFadingEdgeStrength", "()F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getBottomFadingEdgeStrength17685);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange17686;
		protected override int computeVerticalScrollRange()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._computeVerticalScrollRange17686.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._computeVerticalScrollRange17686 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeVerticalScrollRange", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeVerticalScrollRange17686);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset17687;
		protected override int computeVerticalScrollOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._computeVerticalScrollOffset17687.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._computeVerticalScrollOffset17687 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeVerticalScrollOffset", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeVerticalScrollOffset17687);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17688;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._onLayout17688.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._onLayout17688 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onLayout17688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout17689;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._requestLayout17689.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._requestLayout17689 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "requestLayout", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestLayout17689);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17690;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._onMeasure17690.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._onMeasure17690 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onMeasure", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onMeasure17690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus17691;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._requestChildFocus17691.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._requestChildFocus17691 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildFocus17691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen17692;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._requestChildRectangleOnScreen17692.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._requestChildRectangleOnScreen17692 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._requestChildRectangleOnScreen17692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent17693;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._onInterceptTouchEvent17693.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._onInterceptTouchEvent17693 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onInterceptTouchEvent17693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants17694;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._onRequestFocusInDescendants17694.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._onRequestFocusInDescendants17694 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._onRequestFocusInDescendants17694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild17695;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._measureChild17695.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._measureChild17695 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChild17695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins17696;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._measureChildWithMargins17696.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._measureChildWithMargins17696 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._measureChildWithMargins17696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount17697;
		public virtual int getMaxScrollAmount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._getMaxScrollAmount17697.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._getMaxScrollAmount17697 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "getMaxScrollAmount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._getMaxScrollAmount17697);
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy17698;
		public virtual void smoothScrollBy(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._smoothScrollBy17698.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._smoothScrollBy17698 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollBy17698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fling17699;
		public virtual void fling(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._fling17699.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._fling17699 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "fling", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fling17699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillViewport17700;
		public virtual bool isFillViewport()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._isFillViewport17700.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._isFillViewport17700 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "isFillViewport", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isFillViewport17700);
		}
		public new bool FillViewport
		{
			set
			{
				setFillViewport(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFillViewport17701;
		public virtual void setFillViewport(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._setFillViewport17701.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._setFillViewport17701 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "setFillViewport", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setFillViewport17701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollingEnabled17702;
		public virtual bool isSmoothScrollingEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._isSmoothScrollingEnabled17702.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._isSmoothScrollingEnabled17702 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._isSmoothScrollingEnabled17702);
		}
		public new bool SmoothScrollingEnabled
		{
			set
			{
				setSmoothScrollingEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollingEnabled17703;
		public virtual void setSmoothScrollingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._setSmoothScrollingEnabled17703.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._setSmoothScrollingEnabled17703 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._setSmoothScrollingEnabled17703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeKeyEvent17704;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._executeKeyEvent17704.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._executeKeyEvent17704 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._executeKeyEvent17704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageScroll17705;
		public virtual bool pageScroll(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._pageScroll17705.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._pageScroll17705 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "pageScroll", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._pageScroll17705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fullScroll17706;
		public virtual bool fullScroll(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._fullScroll17706.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._fullScroll17706 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "fullScroll", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._fullScroll17706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _arrowScroll17707;
		public virtual bool arrowScroll(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._arrowScroll17707.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._arrowScroll17707 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "arrowScroll", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._arrowScroll17707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollTo17708;
		public virtual void smoothScrollTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._smoothScrollTo17708.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._smoothScrollTo17708 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._smoothScrollTo17708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollDeltaToGetChildRectOnScreen17709;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen17709.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen17709 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ScrollView.staticClass, global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen17709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ScrollView17710;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._ScrollView17710.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._ScrollView17710 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView17710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScrollView17711;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._ScrollView17711.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._ScrollView17711 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView17711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScrollView17712;
		public ScrollView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._ScrollView17712.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._ScrollView17712 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._ScrollView17712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ScrollView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ScrollView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ScrollView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
