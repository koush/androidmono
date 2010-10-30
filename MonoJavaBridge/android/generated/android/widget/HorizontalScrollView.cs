namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HorizontalScrollView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HorizontalScrollView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17205;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onTouchEvent17205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent17206;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._dispatchKeyEvent17206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17207;
		public override void addView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView17207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17208;
		public override void addView(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView17208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17209;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView17209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17210;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView17210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17211;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onSizeChanged17211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _scrollTo17212;
		public override void scrollTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._scrollTo17212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll17213;
		public override void computeScroll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScroll17213);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength17214;
		protected override float getLeftFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength17214);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength17215;
		protected override float getRightFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength17215);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange17216;
		protected override int computeHorizontalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange17216);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollOffset17217;
		protected override int computeHorizontalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset17217);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17218;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onLayout17218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout17219;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestLayout17219);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17220;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onMeasure17220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus17221;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildFocus17221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen17222;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen17222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent17223;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onInterceptTouchEvent17223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants17224;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants17224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild17225;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChild17225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins17226;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChildWithMargins17226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxScrollAmount17227;
		public virtual int getMaxScrollAmount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getMaxScrollAmount17227);
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollBy17228;
		public virtual void smoothScrollBy(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollBy17228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fling17229;
		public virtual void fling(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fling17229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFillViewport17230;
		public virtual bool isFillViewport()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isFillViewport17230);
		}
		public new bool FillViewport
		{
			set
			{
				setFillViewport(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFillViewport17231;
		public virtual void setFillViewport(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setFillViewport17231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSmoothScrollingEnabled17232;
		public virtual bool isSmoothScrollingEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled17232);
		}
		public new bool SmoothScrollingEnabled
		{
			set
			{
				setSmoothScrollingEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSmoothScrollingEnabled17233;
		public virtual void setSmoothScrollingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled17233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeKeyEvent17234;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._executeKeyEvent17234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageScroll17235;
		public virtual bool pageScroll(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._pageScroll17235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fullScroll17236;
		public virtual bool fullScroll(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fullScroll17236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _arrowScroll17237;
		public virtual bool arrowScroll(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._arrowScroll17237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _smoothScrollTo17238;
		public virtual void smoothScrollTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollTo17238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeScrollDeltaToGetChildRectOnScreen17239;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen17239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView17240;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView17240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView17241;
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView17241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HorizontalScrollView17242;
		public HorizontalScrollView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView17242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HorizontalScrollView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HorizontalScrollView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HorizontalScrollView"));
			global::android.widget.HorizontalScrollView._onTouchEvent17205 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._dispatchKeyEvent17206 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._addView17207 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._addView17208 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.HorizontalScrollView._addView17209 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._addView17210 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.HorizontalScrollView._onSizeChanged17211 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.HorizontalScrollView._scrollTo17212 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "scrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScroll17213 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeScroll", "()V");
			global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength17214 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength17215 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollRange17216 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.HorizontalScrollView._computeHorizontalScrollOffset17217 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollOffset", "()I");
			global::android.widget.HorizontalScrollView._onLayout17218 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.HorizontalScrollView._requestLayout17219 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestLayout", "()V");
			global::android.widget.HorizontalScrollView._onMeasure17220 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onMeasure", "(II)V");
			global::android.widget.HorizontalScrollView._requestChildFocus17221 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen17222 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.widget.HorizontalScrollView._onInterceptTouchEvent17223 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.HorizontalScrollView._onRequestFocusInDescendants17224 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.widget.HorizontalScrollView._measureChild17225 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.widget.HorizontalScrollView._measureChildWithMargins17226 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.widget.HorizontalScrollView._getMaxScrollAmount17227 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "getMaxScrollAmount", "()I");
			global::android.widget.HorizontalScrollView._smoothScrollBy17228 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollBy", "(II)V");
			global::android.widget.HorizontalScrollView._fling17229 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "fling", "(I)V");
			global::android.widget.HorizontalScrollView._isFillViewport17230 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "isFillViewport", "()Z");
			global::android.widget.HorizontalScrollView._setFillViewport17231 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "setFillViewport", "(Z)V");
			global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled17232 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "isSmoothScrollingEnabled", "()Z");
			global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled17233 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V");
			global::android.widget.HorizontalScrollView._executeKeyEvent17234 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.widget.HorizontalScrollView._pageScroll17235 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "pageScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._fullScroll17236 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "fullScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._arrowScroll17237 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "arrowScroll", "(I)Z");
			global::android.widget.HorizontalScrollView._smoothScrollTo17238 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollTo", "(II)V");
			global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen17239 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I");
			global::android.widget.HorizontalScrollView._HorizontalScrollView17240 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView17241 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.HorizontalScrollView._HorizontalScrollView17242 = @__env.GetMethodIDNoThrow(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
