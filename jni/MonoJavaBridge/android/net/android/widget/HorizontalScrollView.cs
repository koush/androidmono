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
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10310; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._onTouchEvent10310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onTouchEvent10310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent10311; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._dispatchKeyEvent10311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._dispatchKeyEvent10311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10312; 
		public override void addView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._addView10312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView10312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10313; 
		public override void addView(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._addView10313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView10313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10314; 
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._addView10314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView10314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10315; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._addView10315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._addView10315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged10316; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._onSizeChanged10316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onSizeChanged10316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo10317; 
		public override void scrollTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._scrollTo10317, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._scrollTo10317, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll10318; 
		public override void computeScroll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._computeScroll10318); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScroll10318); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftFadingEdgeStrength10319; 
		protected override float getLeftFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallFloatMethod(this, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength10319); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength10319); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightFadingEdgeStrength10320; 
		protected override float getRightFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallFloatMethod(this, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength10320); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength10320); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange10321; 
		protected override int computeHorizontalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallIntMethod(this, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange10321); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeHorizontalScrollRange10321); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10322; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._onLayout10322, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onLayout10322, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout10323; 
		public override void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._requestLayout10323); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestLayout10323); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10324; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._onMeasure10324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onMeasure10324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus10325; 
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._requestChildFocus10325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildFocus10325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen10326; 
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen10326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen10326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent10327; 
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._onInterceptTouchEvent10327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onInterceptTouchEvent10327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocusInDescendants10328; 
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants10328, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._onRequestFocusInDescendants10328, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChild10329; 
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._measureChild10329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChild10329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChildWithMargins10330; 
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._measureChildWithMargins10330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._measureChildWithMargins10330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxScrollAmount10331; 
		public virtual int getMaxScrollAmount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallIntMethod(this, global::android.widget.HorizontalScrollView._getMaxScrollAmount10331); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._getMaxScrollAmount10331); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fling10332; 
		public virtual void fling(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._fling10332, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fling10332, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFillViewport10333; 
		public virtual bool isFillViewport() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._isFillViewport10333); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isFillViewport10333); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillViewport10334; 
		public virtual void setFillViewport(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._setFillViewport10334, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setFillViewport10334, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSmoothScrollingEnabled10335; 
		public virtual bool isSmoothScrollingEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled10335); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled10335); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSmoothScrollingEnabled10336; 
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled10336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled10336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _executeKeyEvent10337; 
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._executeKeyEvent10337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._executeKeyEvent10337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pageScroll10338; 
		public virtual bool pageScroll(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._pageScroll10338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._pageScroll10338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fullScroll10339; 
		public virtual bool fullScroll(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._fullScroll10339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._fullScroll10339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _arrowScroll10340; 
		public virtual bool arrowScroll(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, global::android.widget.HorizontalScrollView._arrowScroll10340, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._arrowScroll10340, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollBy10341; 
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._smoothScrollBy10341, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollBy10341, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollTo10342; 
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, global::android.widget.HorizontalScrollView._smoothScrollTo10342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._smoothScrollTo10342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScrollDeltaToGetChildRectOnScreen10343; 
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallIntMethod(this, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen10343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen10343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HorizontalScrollView10344; 
		public HorizontalScrollView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView10344, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HorizontalScrollView10345; 
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView10345, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HorizontalScrollView10346; 
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.HorizontalScrollView.staticClass, global::android.widget.HorizontalScrollView._HorizontalScrollView10346, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.HorizontalScrollView.staticClass = @__class; 
			global::android.widget.HorizontalScrollView._onTouchEvent10310 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.HorizontalScrollView._dispatchKeyEvent10311 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.HorizontalScrollView._addView10312 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;)V"); 
			global::android.widget.HorizontalScrollView._addView10313 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;I)V"); 
			global::android.widget.HorizontalScrollView._addView10314 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.HorizontalScrollView._addView10315 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.HorizontalScrollView._onSizeChanged10316 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.HorizontalScrollView._scrollTo10317 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "scrollTo", "(II)V"); 
			global::android.widget.HorizontalScrollView._computeScroll10318 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeScroll", "()V"); 
			global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength10319 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "getLeftFadingEdgeStrength", "()F"); 
			global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength10320 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "getRightFadingEdgeStrength", "()F"); 
			global::android.widget.HorizontalScrollView._computeHorizontalScrollRange10321 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollRange", "()I"); 
			global::android.widget.HorizontalScrollView._onLayout10322 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.HorizontalScrollView._requestLayout10323 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "requestLayout", "()V"); 
			global::android.widget.HorizontalScrollView._onMeasure10324 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.HorizontalScrollView._requestChildFocus10325 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen10326 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z"); 
			global::android.widget.HorizontalScrollView._onInterceptTouchEvent10327 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.HorizontalScrollView._onRequestFocusInDescendants10328 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z"); 
			global::android.widget.HorizontalScrollView._measureChild10329 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V"); 
			global::android.widget.HorizontalScrollView._measureChildWithMargins10330 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V"); 
			global::android.widget.HorizontalScrollView._getMaxScrollAmount10331 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "getMaxScrollAmount", "()I"); 
			global::android.widget.HorizontalScrollView._fling10332 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "fling", "(I)V"); 
			global::android.widget.HorizontalScrollView._isFillViewport10333 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "isFillViewport", "()Z"); 
			global::android.widget.HorizontalScrollView._setFillViewport10334 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "setFillViewport", "(Z)V"); 
			global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled10335 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "isSmoothScrollingEnabled", "()Z"); 
			global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled10336 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V"); 
			global::android.widget.HorizontalScrollView._executeKeyEvent10337 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.HorizontalScrollView._pageScroll10338 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "pageScroll", "(I)Z"); 
			global::android.widget.HorizontalScrollView._fullScroll10339 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "fullScroll", "(I)Z"); 
			global::android.widget.HorizontalScrollView._arrowScroll10340 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "arrowScroll", "(I)Z"); 
			global::android.widget.HorizontalScrollView._smoothScrollBy10341 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollBy", "(II)V"); 
			global::android.widget.HorizontalScrollView._smoothScrollTo10342 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollTo", "(II)V"); 
			global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen10343 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I"); 
			global::android.widget.HorizontalScrollView._HorizontalScrollView10344 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.HorizontalScrollView._HorizontalScrollView10345 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.HorizontalScrollView._HorizontalScrollView10346 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
