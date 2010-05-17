namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ScrollView : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ScrollView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ScrollView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent9963; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent9963, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _onTouchEvent9963, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent9964; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent9964, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _dispatchKeyEvent9964, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9965; 
		public override void addView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _addView9965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _addView9965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9966; 
		public override void addView(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _addView9966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _addView9966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9967; 
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _addView9967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _addView9967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9968; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _addView9968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _addView9968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged9969; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _onSizeChanged9969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _onSizeChanged9969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo9970; 
		public override void scrollTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _scrollTo9970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _scrollTo9970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll9971; 
		public override void computeScroll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _computeScroll9971); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _computeScroll9971); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopFadingEdgeStrength9972; 
		protected override float getTopFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallFloatMethod(this, _getTopFadingEdgeStrength9972); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.ScrollView.staticClass, _getTopFadingEdgeStrength9972); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomFadingEdgeStrength9973; 
		protected override float getBottomFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallFloatMethod(this, _getBottomFadingEdgeStrength9973); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.ScrollView.staticClass, _getBottomFadingEdgeStrength9973); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange9974; 
		protected override int computeVerticalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollRange9974); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ScrollView.staticClass, _computeVerticalScrollRange9974); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9975; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _onLayout9975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _onLayout9975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout9976; 
		public override void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _requestLayout9976); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _requestLayout9976); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9977; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _onMeasure9977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _onMeasure9977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus9978; 
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _requestChildFocus9978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _requestChildFocus9978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen9979; 
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _requestChildRectangleOnScreen9979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _requestChildRectangleOnScreen9979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent9980; 
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _onInterceptTouchEvent9980, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _onInterceptTouchEvent9980, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocusInDescendants9981; 
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _onRequestFocusInDescendants9981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _onRequestFocusInDescendants9981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChild9982; 
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _measureChild9982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _measureChild9982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChildWithMargins9983; 
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _measureChildWithMargins9983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _measureChildWithMargins9983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxScrollAmount9984; 
		public virtual int getMaxScrollAmount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallIntMethod(this, _getMaxScrollAmount9984); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ScrollView.staticClass, _getMaxScrollAmount9984); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fling9985; 
		public virtual void fling(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _fling9985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _fling9985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFillViewport9986; 
		public virtual bool isFillViewport() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _isFillViewport9986); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _isFillViewport9986); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillViewport9987; 
		public virtual void setFillViewport(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _setFillViewport9987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _setFillViewport9987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSmoothScrollingEnabled9988; 
		public virtual bool isSmoothScrollingEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _isSmoothScrollingEnabled9988); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _isSmoothScrollingEnabled9988); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSmoothScrollingEnabled9989; 
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _setSmoothScrollingEnabled9989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _setSmoothScrollingEnabled9989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _executeKeyEvent9990; 
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _executeKeyEvent9990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _executeKeyEvent9990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pageScroll9991; 
		public virtual bool pageScroll(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _pageScroll9991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _pageScroll9991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fullScroll9992; 
		public virtual bool fullScroll(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _fullScroll9992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _fullScroll9992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _arrowScroll9993; 
		public virtual bool arrowScroll(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallBooleanMethod(this, _arrowScroll9993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ScrollView.staticClass, _arrowScroll9993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollBy9994; 
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _smoothScrollBy9994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _smoothScrollBy9994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollTo9995; 
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				@__env.CallVoidMethod(this, _smoothScrollTo9995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ScrollView.staticClass, _smoothScrollTo9995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScrollDeltaToGetChildRectOnScreen9996; 
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ScrollView)) 
				return @__env.CallIntMethod(this, _computeScrollDeltaToGetChildRectOnScreen9996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ScrollView.staticClass, _computeScrollDeltaToGetChildRectOnScreen9996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ScrollView9997; 
		public ScrollView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ScrollView.staticClass, _ScrollView9997, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ScrollView9998; 
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ScrollView.staticClass, _ScrollView9998, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ScrollView9999; 
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ScrollView.staticClass, _ScrollView9999, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ScrollView.staticClass = @__class; 
			global::android.widget.ScrollView._onTouchEvent9963 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.ScrollView._dispatchKeyEvent9964 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.ScrollView._addView9965 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;)V"); 
			global::android.widget.ScrollView._addView9966 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;I)V"); 
			global::android.widget.ScrollView._addView9967 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.ScrollView._addView9968 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.ScrollView._onSizeChanged9969 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.ScrollView._scrollTo9970 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "scrollTo", "(II)V"); 
			global::android.widget.ScrollView._computeScroll9971 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeScroll", "()V"); 
			global::android.widget.ScrollView._getTopFadingEdgeStrength9972 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "getTopFadingEdgeStrength", "()F"); 
			global::android.widget.ScrollView._getBottomFadingEdgeStrength9973 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "getBottomFadingEdgeStrength", "()F"); 
			global::android.widget.ScrollView._computeVerticalScrollRange9974 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeVerticalScrollRange", "()I"); 
			global::android.widget.ScrollView._onLayout9975 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.ScrollView._requestLayout9976 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "requestLayout", "()V"); 
			global::android.widget.ScrollView._onMeasure9977 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.ScrollView._requestChildFocus9978 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.widget.ScrollView._requestChildRectangleOnScreen9979 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z"); 
			global::android.widget.ScrollView._onInterceptTouchEvent9980 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.ScrollView._onRequestFocusInDescendants9981 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z"); 
			global::android.widget.ScrollView._measureChild9982 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V"); 
			global::android.widget.ScrollView._measureChildWithMargins9983 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V"); 
			global::android.widget.ScrollView._getMaxScrollAmount9984 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "getMaxScrollAmount", "()I"); 
			global::android.widget.ScrollView._fling9985 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "fling", "(I)V"); 
			global::android.widget.ScrollView._isFillViewport9986 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "isFillViewport", "()Z"); 
			global::android.widget.ScrollView._setFillViewport9987 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "setFillViewport", "(Z)V"); 
			global::android.widget.ScrollView._isSmoothScrollingEnabled9988 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "isSmoothScrollingEnabled", "()Z"); 
			global::android.widget.ScrollView._setSmoothScrollingEnabled9989 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V"); 
			global::android.widget.ScrollView._executeKeyEvent9990 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.ScrollView._pageScroll9991 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "pageScroll", "(I)Z"); 
			global::android.widget.ScrollView._fullScroll9992 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "fullScroll", "(I)Z"); 
			global::android.widget.ScrollView._arrowScroll9993 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "arrowScroll", "(I)Z"); 
			global::android.widget.ScrollView._smoothScrollBy9994 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "smoothScrollBy", "(II)V"); 
			global::android.widget.ScrollView._smoothScrollTo9995 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "smoothScrollTo", "(II)V"); 
			global::android.widget.ScrollView._computeScrollDeltaToGetChildRectOnScreen9996 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I"); 
			global::android.widget.ScrollView._ScrollView9997 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.ScrollView._ScrollView9998 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ScrollView._ScrollView9999 = @__env.GetMethodID(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
