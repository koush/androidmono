namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Gallery : android.widget.AbsSpinner, android.view.GestureDetector.OnGestureListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Gallery(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Gallery.LayoutParams._m0.native == global::System.IntPtr.Zero)
					global::android.widget.Gallery.LayoutParams._m0 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Gallery.LayoutParams._m1.native == global::System.IntPtr.Zero)
					global::android.widget.Gallery.LayoutParams._m1 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.Gallery.LayoutParams._m2.native == global::System.IntPtr.Zero)
					global::android.widget.Gallery.LayoutParams._m2 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.LayoutParams.staticClass, global::android.widget.Gallery.LayoutParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.Gallery.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Gallery$LayoutParams"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.Gallery._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.Gallery._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.Gallery._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.widget.Gallery._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Gravity
		{
			set
			{
				setGravity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setGravity", "(I)V", ref global::android.widget.Gallery._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool showContextMenu()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "showContextMenu", "()Z", ref global::android.widget.Gallery._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.Gallery._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void dispatchSetPressed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "dispatchSetPressed", "(Z)V", ref global::android.widget.Gallery._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.ContextMenu_ContextMenuInfo ContextMenuInfo
		{
			get
			{
				return getContextMenuInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu_ContextMenuInfo>(this, global::android.widget.Gallery.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", ref global::android.widget.Gallery._m8) as android.view.ContextMenu_ContextMenuInfo;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override int computeHorizontalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Gallery.staticClass, "computeHorizontalScrollRange", "()I", ref global::android.widget.Gallery._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override int computeHorizontalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Gallery.staticClass, "computeHorizontalScrollOffset", "()I", ref global::android.widget.Gallery._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override int computeHorizontalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Gallery.staticClass, "computeHorizontalScrollExtent", "()I", ref global::android.widget.Gallery._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.Gallery._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void dispatchSetSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "dispatchSetSelected", "(Z)V", ref global::android.widget.Gallery._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override bool showContextMenuForChild(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z", ref global::android.widget.Gallery._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected override int getChildDrawingOrder(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Gallery.staticClass, "getChildDrawingOrder", "(II)I", ref global::android.widget.Gallery._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected override bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z", ref global::android.widget.Gallery._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.Gallery._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.Gallery._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Gallery.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.Gallery._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Gallery.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.Gallery._m20) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void onLongPress(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V", ref global::android.widget.Gallery._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool onSingleTapUp(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.Gallery._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", ref global::android.widget.Gallery._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", ref global::android.widget.Gallery._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void onShowPress(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V", ref global::android.widget.Gallery._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool onDown(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Gallery.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.Gallery._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CallbackDuringFling
		{
			set
			{
				setCallbackDuringFling(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setCallbackDuringFling(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setCallbackDuringFling", "(Z)V", ref global::android.widget.Gallery._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AnimationDuration
		{
			set
			{
				setAnimationDuration(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setAnimationDuration(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setAnimationDuration", "(I)V", ref global::android.widget.Gallery._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Spacing
		{
			set
			{
				setSpacing(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void setSpacing(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setSpacing", "(I)V", ref global::android.widget.Gallery._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float UnselectedAlpha
		{
			set
			{
				setUnselectedAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setUnselectedAlpha(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Gallery.staticClass, "setUnselectedAlpha", "(F)V", ref global::android.widget.Gallery._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Gallery._m31.native == global::System.IntPtr.Zero)
				global::android.widget.Gallery._m31 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public Gallery(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Gallery._m32.native == global::System.IntPtr.Zero)
				global::android.widget.Gallery._m32 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public Gallery(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Gallery._m33.native == global::System.IntPtr.Zero)
				global::android.widget.Gallery._m33 = @__env.GetMethodIDNoThrow(global::android.widget.Gallery.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Gallery.staticClass, global::android.widget.Gallery._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Gallery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Gallery.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Gallery"));
		}
	}
}
