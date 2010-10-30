namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScrollView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScrollView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.ScrollView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.widget.ScrollView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void addView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;)V", ref global::android.widget.ScrollView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void addView(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;I)V", ref global::android.widget.ScrollView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.ScrollView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.ScrollView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.ScrollView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void scrollTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "scrollTo", "(II)V", ref global::android.widget.ScrollView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void computeScroll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "computeScroll", "()V", ref global::android.widget.ScrollView._m8);
		}
		protected new float TopFadingEdgeStrength
		{
			get
			{
				return getTopFadingEdgeStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override float getTopFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.ScrollView.staticClass, "getTopFadingEdgeStrength", "()F", ref global::android.widget.ScrollView._m9);
		}
		protected new float BottomFadingEdgeStrength
		{
			get
			{
				return getBottomFadingEdgeStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override float getBottomFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.ScrollView.staticClass, "getBottomFadingEdgeStrength", "()F", ref global::android.widget.ScrollView._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ScrollView.staticClass, "computeVerticalScrollRange", "()I", ref global::android.widget.ScrollView._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected override int computeVerticalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ScrollView.staticClass, "computeVerticalScrollOffset", "()I", ref global::android.widget.ScrollView._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.ScrollView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "requestLayout", "()V", ref global::android.widget.ScrollView._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "onMeasure", "(II)V", ref global::android.widget.ScrollView._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void requestChildFocus(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.widget.ScrollView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", ref global::android.widget.ScrollView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override bool onInterceptTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.ScrollView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected override bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z", ref global::android.widget.ScrollView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected override void measureChild(android.view.View arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "measureChild", "(Landroid/view/View;II)V", ref global::android.widget.ScrollView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		protected override void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V", ref global::android.widget.ScrollView._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int MaxScrollAmount
		{
			get
			{
				return getMaxScrollAmount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getMaxScrollAmount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ScrollView.staticClass, "getMaxScrollAmount", "()I", ref global::android.widget.ScrollView._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void smoothScrollBy(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "smoothScrollBy", "(II)V", ref global::android.widget.ScrollView._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void fling(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "fling", "(I)V", ref global::android.widget.ScrollView._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool isFillViewport()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "isFillViewport", "()Z", ref global::android.widget.ScrollView._m25);
		}
		public new bool FillViewport
		{
			set
			{
				setFillViewport(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setFillViewport(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "setFillViewport", "(Z)V", ref global::android.widget.ScrollView._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool isSmoothScrollingEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "isSmoothScrollingEnabled", "()Z", ref global::android.widget.ScrollView._m27);
		}
		public new bool SmoothScrollingEnabled
		{
			set
			{
				setSmoothScrollingEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setSmoothScrollingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "setSmoothScrollingEnabled", "(Z)V", ref global::android.widget.ScrollView._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool executeKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.widget.ScrollView._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool pageScroll(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "pageScroll", "(I)Z", ref global::android.widget.ScrollView._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool fullScroll(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "fullScroll", "(I)Z", ref global::android.widget.ScrollView._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual bool arrowScroll(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ScrollView.staticClass, "arrowScroll", "(I)Z", ref global::android.widget.ScrollView._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void smoothScrollTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ScrollView.staticClass, "smoothScrollTo", "(II)V", ref global::android.widget.ScrollView._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		protected virtual int computeScrollDeltaToGetChildRectOnScreen(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ScrollView.staticClass, "computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I", ref global::android.widget.ScrollView._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._m35.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._m35 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public ScrollView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._m36.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._m36 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public ScrollView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ScrollView._m37.native == global::System.IntPtr.Zero)
				global::android.widget.ScrollView._m37 = @__env.GetMethodIDNoThrow(global::android.widget.ScrollView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ScrollView.staticClass, global::android.widget.ScrollView._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
