namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZoomButtonsController : java.lang.Object, android.view.View.OnTouchListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZoomButtonsController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ZoomButtonsController.OnZoomListener_))]
		public partial interface OnZoomListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onVisibilityChanged(bool arg0);
			void onZoom(bool arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ZoomButtonsController.OnZoomListener))]
		internal sealed partial class OnZoomListener_ : java.lang.Object, OnZoomListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnZoomListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.ZoomButtonsController.OnZoomListener.onVisibilityChanged(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, "onVisibilityChanged", "(Z)V", ref global::android.widget.ZoomButtonsController.OnZoomListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.widget.ZoomButtonsController.OnZoomListener.onZoom(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, "onZoom", "(Z)V", ref global::android.widget.ZoomButtonsController.OnZoomListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnZoomListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButtonsController$OnZoomListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		public new bool Visible
		{
			set
			{
				setVisible(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setVisible(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, "setVisible", "(Z)V", ref global::android.widget.ZoomButtonsController._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool isVisible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, "isVisible", "()Z", ref global::android.widget.ZoomButtonsController._m1);
		}
		public new global::android.view.ViewGroup Container
		{
			get
			{
				return getContainer();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.view.ViewGroup getContainer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ZoomButtonsController.staticClass, "getContainer", "()Landroid/view/ViewGroup;", ref global::android.widget.ZoomButtonsController._m2) as android.view.ViewGroup;
		}
		public new bool Focusable
		{
			set
			{
				setFocusable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setFocusable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, "setFocusable", "(Z)V", ref global::android.widget.ZoomButtonsController._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool onTouch(android.view.View arg0, android.view.MotionEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", ref global::android.widget.ZoomButtonsController._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.View ZoomControls
		{
			get
			{
				return getZoomControls();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.view.View getZoomControls()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ZoomButtonsController.staticClass, "getZoomControls", "()Landroid/view/View;", ref global::android.widget.ZoomButtonsController._m5) as android.view.View;
		}
		public new long ZoomSpeed
		{
			set
			{
				setZoomSpeed(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setZoomSpeed(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, "setZoomSpeed", "(J)V", ref global::android.widget.ZoomButtonsController._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ZoomInEnabled
		{
			set
			{
				setZoomInEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setZoomInEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, "setZoomInEnabled", "(Z)V", ref global::android.widget.ZoomButtonsController._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ZoomOutEnabled
		{
			set
			{
				setZoomOutEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setZoomOutEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, "setZoomOutEnabled", "(Z)V", ref global::android.widget.ZoomButtonsController._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setOnZoomListener(android.widget.ZoomButtonsController.OnZoomListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, "setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V", ref global::android.widget.ZoomButtonsController._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isAutoDismissed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, "isAutoDismissed", "()Z", ref global::android.widget.ZoomButtonsController._m10);
		}
		public new bool AutoDismissed
		{
			set
			{
				setAutoDismissed(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setAutoDismissed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, "setAutoDismissed", "(Z)V", ref global::android.widget.ZoomButtonsController._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public ZoomButtonsController(android.view.View arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ZoomButtonsController._m12.native == global::System.IntPtr.Zero)
				global::android.widget.ZoomButtonsController._m12 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "<init>", "(Landroid/view/View;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ZoomButtonsController()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomButtonsController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButtonsController"));
		}
		internal static void InitJNI()
		{
		}
	}
}
