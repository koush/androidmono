namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZoomControls : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZoomControls(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomControls.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.ZoomControls._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool hasFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomControls.staticClass, "hasFocus", "()Z", ref global::android.widget.ZoomControls._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void show()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomControls.staticClass, "show", "()V", ref global::android.widget.ZoomControls._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void hide()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomControls.staticClass, "hide", "()V", ref global::android.widget.ZoomControls._m3);
		}
		public new long ZoomSpeed
		{
			set
			{
				setZoomSpeed(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setZoomSpeed(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomControls.staticClass, "setZoomSpeed", "(J)V", ref global::android.widget.ZoomControls._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View.OnClickListener OnZoomInClickListener
		{
			set
			{
				setOnZoomInClickListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setOnZoomInClickListener(android.view.View.OnClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomControls.staticClass, "setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V", ref global::android.widget.ZoomControls._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnZoomInClickListener(global::android.view.View.OnClickListenerDelegate arg0)
		{
			setOnZoomInClickListener((global::android.view.View.OnClickListenerDelegateWrapper)arg0);
		}
		public new global::android.view.View.OnClickListener OnZoomOutClickListener
		{
			set
			{
				setOnZoomOutClickListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setOnZoomOutClickListener(android.view.View.OnClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomControls.staticClass, "setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V", ref global::android.widget.ZoomControls._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnZoomOutClickListener(global::android.view.View.OnClickListenerDelegate arg0)
		{
			setOnZoomOutClickListener((global::android.view.View.OnClickListenerDelegateWrapper)arg0);
		}
		public new bool IsZoomInEnabled
		{
			set
			{
				setIsZoomInEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setIsZoomInEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomControls.staticClass, "setIsZoomInEnabled", "(Z)V", ref global::android.widget.ZoomControls._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool IsZoomOutEnabled
		{
			set
			{
				setIsZoomOutEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setIsZoomOutEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomControls.staticClass, "setIsZoomOutEnabled", "(Z)V", ref global::android.widget.ZoomControls._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ZoomControls(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ZoomControls._m9.native == global::System.IntPtr.Zero)
				global::android.widget.ZoomControls._m9 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ZoomControls(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ZoomControls._m10.native == global::System.IntPtr.Zero)
				global::android.widget.ZoomControls._m10 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ZoomControls()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomControls.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomControls"));
		}
		internal static void InitJNI()
		{
		}
	}
}
