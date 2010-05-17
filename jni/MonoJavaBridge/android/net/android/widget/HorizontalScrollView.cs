namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class HorizontalScrollView : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static HorizontalScrollView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.HorizontalScrollView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent9566; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent9566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _onTouchEvent9566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent9567; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent9567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _dispatchKeyEvent9567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9568; 
		public override void addView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _addView9568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _addView9568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9569; 
		public override void addView(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _addView9569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _addView9569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9570; 
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _addView9570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _addView9570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9571; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _addView9571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _addView9571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged9572; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _onSizeChanged9572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _onSizeChanged9572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scrollTo9573; 
		public override void scrollTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _scrollTo9573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _scrollTo9573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll9574; 
		public override void computeScroll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _computeScroll9574); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _computeScroll9574); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftFadingEdgeStrength9575; 
		protected override float getLeftFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallFloatMethod(this, _getLeftFadingEdgeStrength9575); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.HorizontalScrollView.staticClass, _getLeftFadingEdgeStrength9575); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightFadingEdgeStrength9576; 
		protected override float getRightFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallFloatMethod(this, _getRightFadingEdgeStrength9576); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.HorizontalScrollView.staticClass, _getRightFadingEdgeStrength9576); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange9577; 
		protected override int computeHorizontalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallIntMethod(this, _computeHorizontalScrollRange9577); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.HorizontalScrollView.staticClass, _computeHorizontalScrollRange9577); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9578; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _onLayout9578, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _onLayout9578, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout9579; 
		public override void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _requestLayout9579); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _requestLayout9579); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9580; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _onMeasure9580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _onMeasure9580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus9581; 
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _requestChildFocus9581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _requestChildFocus9581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen9582; 
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _requestChildRectangleOnScreen9582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _requestChildRectangleOnScreen9582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent9583; 
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _onInterceptTouchEvent9583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _onInterceptTouchEvent9583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocusInDescendants9584; 
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _onRequestFocusInDescendants9584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _onRequestFocusInDescendants9584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChild9585; 
		protected override void measureChild(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _measureChild9585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _measureChild9585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChildWithMargins9586; 
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _measureChildWithMargins9586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _measureChildWithMargins9586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxScrollAmount9587; 
		public virtual int getMaxScrollAmount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallIntMethod(this, _getMaxScrollAmount9587); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.HorizontalScrollView.staticClass, _getMaxScrollAmount9587); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fling9588; 
		public virtual void fling(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _fling9588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _fling9588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFillViewport9589; 
		public virtual bool isFillViewport() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _isFillViewport9589); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _isFillViewport9589); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillViewport9590; 
		public virtual void setFillViewport(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _setFillViewport9590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _setFillViewport9590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSmoothScrollingEnabled9591; 
		public virtual bool isSmoothScrollingEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _isSmoothScrollingEnabled9591); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _isSmoothScrollingEnabled9591); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSmoothScrollingEnabled9592; 
		public virtual void setSmoothScrollingEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _setSmoothScrollingEnabled9592, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _setSmoothScrollingEnabled9592, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _executeKeyEvent9593; 
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _executeKeyEvent9593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _executeKeyEvent9593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pageScroll9594; 
		public virtual bool pageScroll(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _pageScroll9594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _pageScroll9594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fullScroll9595; 
		public virtual bool fullScroll(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _fullScroll9595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _fullScroll9595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _arrowScroll9596; 
		public virtual bool arrowScroll(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallBooleanMethod(this, _arrowScroll9596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.HorizontalScrollView.staticClass, _arrowScroll9596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollBy9597; 
		public virtual void smoothScrollBy(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _smoothScrollBy9597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _smoothScrollBy9597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _smoothScrollTo9598; 
		public virtual void smoothScrollTo(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				@__env.CallVoidMethod(this, _smoothScrollTo9598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.HorizontalScrollView.staticClass, _smoothScrollTo9598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScrollDeltaToGetChildRectOnScreen9599; 
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.HorizontalScrollView)) 
				return @__env.CallIntMethod(this, _computeScrollDeltaToGetChildRectOnScreen9599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.HorizontalScrollView.staticClass, _computeScrollDeltaToGetChildRectOnScreen9599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HorizontalScrollView9600; 
		public HorizontalScrollView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.HorizontalScrollView.staticClass, _HorizontalScrollView9600, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HorizontalScrollView9601; 
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.HorizontalScrollView.staticClass, _HorizontalScrollView9601, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HorizontalScrollView9602; 
		public HorizontalScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.HorizontalScrollView.staticClass, _HorizontalScrollView9602, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.HorizontalScrollView.staticClass = @__class; 
			global::android.widget.HorizontalScrollView._onTouchEvent9566 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.HorizontalScrollView._dispatchKeyEvent9567 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.HorizontalScrollView._addView9568 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;)V"); 
			global::android.widget.HorizontalScrollView._addView9569 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;I)V"); 
			global::android.widget.HorizontalScrollView._addView9570 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.HorizontalScrollView._addView9571 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.HorizontalScrollView._onSizeChanged9572 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.widget.HorizontalScrollView._scrollTo9573 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "scrollTo", "(II)V"); 
			global::android.widget.HorizontalScrollView._computeScroll9574 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeScroll", "()V"); 
			global::android.widget.HorizontalScrollView._getLeftFadingEdgeStrength9575 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "getLeftFadingEdgeStrength", "()F"); 
			global::android.widget.HorizontalScrollView._getRightFadingEdgeStrength9576 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "getRightFadingEdgeStrength", "()F"); 
			global::android.widget.HorizontalScrollView._computeHorizontalScrollRange9577 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeHorizontalScrollRange", "()I"); 
			global::android.widget.HorizontalScrollView._onLayout9578 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.HorizontalScrollView._requestLayout9579 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "requestLayout", "()V"); 
			global::android.widget.HorizontalScrollView._onMeasure9580 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.HorizontalScrollView._requestChildFocus9581 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.widget.HorizontalScrollView._requestChildRectangleOnScreen9582 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z"); 
			global::android.widget.HorizontalScrollView._onInterceptTouchEvent9583 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.HorizontalScrollView._onRequestFocusInDescendants9584 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z"); 
			global::android.widget.HorizontalScrollView._measureChild9585 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V"); 
			global::android.widget.HorizontalScrollView._measureChildWithMargins9586 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V"); 
			global::android.widget.HorizontalScrollView._getMaxScrollAmount9587 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "getMaxScrollAmount", "()I"); 
			global::android.widget.HorizontalScrollView._fling9588 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "fling", "(I)V"); 
			global::android.widget.HorizontalScrollView._isFillViewport9589 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "isFillViewport", "()Z"); 
			global::android.widget.HorizontalScrollView._setFillViewport9590 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "setFillViewport", "(Z)V"); 
			global::android.widget.HorizontalScrollView._isSmoothScrollingEnabled9591 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "isSmoothScrollingEnabled", "()Z"); 
			global::android.widget.HorizontalScrollView._setSmoothScrollingEnabled9592 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V"); 
			global::android.widget.HorizontalScrollView._executeKeyEvent9593 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.widget.HorizontalScrollView._pageScroll9594 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "pageScroll", "(I)Z"); 
			global::android.widget.HorizontalScrollView._fullScroll9595 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "fullScroll", "(I)Z"); 
			global::android.widget.HorizontalScrollView._arrowScroll9596 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "arrowScroll", "(I)Z"); 
			global::android.widget.HorizontalScrollView._smoothScrollBy9597 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollBy", "(II)V"); 
			global::android.widget.HorizontalScrollView._smoothScrollTo9598 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "smoothScrollTo", "(II)V"); 
			global::android.widget.HorizontalScrollView._computeScrollDeltaToGetChildRectOnScreen9599 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I"); 
			global::android.widget.HorizontalScrollView._HorizontalScrollView9600 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.HorizontalScrollView._HorizontalScrollView9601 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.HorizontalScrollView._HorizontalScrollView9602 = @__env.GetMethodID(global::android.widget.HorizontalScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
