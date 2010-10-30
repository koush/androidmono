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
			internal static global::MonoJavaBridge.MethodId _onVisibilityChanged18310;
			void android.widget.ZoomButtonsController.OnZoomListener.onVisibilityChanged(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_._onVisibilityChanged18310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onZoom18311;
			void android.widget.ZoomButtonsController.OnZoomListener.onZoom(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_._onZoom18311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnZoomListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButtonsController$OnZoomListener"));
				global::android.widget.ZoomButtonsController.OnZoomListener_._onVisibilityChanged18310 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, "onVisibilityChanged", "(Z)V");
				global::android.widget.ZoomButtonsController.OnZoomListener_._onZoom18311 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, "onZoom", "(Z)V");
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
		internal static global::MonoJavaBridge.MethodId _setVisible18312;
		public virtual void setVisible(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setVisible18312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVisible18313;
		public virtual bool isVisible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isVisible18313);
		}
		public new global::android.view.ViewGroup Container
		{
			get
			{
				return getContainer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContainer18314;
		public virtual global::android.view.ViewGroup getContainer()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getContainer18314)) as android.view.ViewGroup;
		}
		public new bool Focusable
		{
			set
			{
				setFocusable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable18315;
		public virtual void setFocusable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setFocusable18315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouch18316;
		public virtual bool onTouch(android.view.View arg0, android.view.MotionEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._onTouch18316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.View ZoomControls
		{
			get
			{
				return getZoomControls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControls18317;
		public virtual global::android.view.View getZoomControls()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getZoomControls18317)) as android.view.View;
		}
		public new long ZoomSpeed
		{
			set
			{
				setZoomSpeed(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setZoomSpeed18318;
		public virtual void setZoomSpeed(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomSpeed18318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ZoomInEnabled
		{
			set
			{
				setZoomInEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setZoomInEnabled18319;
		public virtual void setZoomInEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomInEnabled18319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ZoomOutEnabled
		{
			set
			{
				setZoomOutEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setZoomOutEnabled18320;
		public virtual void setZoomOutEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomOutEnabled18320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnZoomListener18321;
		public virtual void setOnZoomListener(android.widget.ZoomButtonsController.OnZoomListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setOnZoomListener18321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoDismissed18322;
		public virtual bool isAutoDismissed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isAutoDismissed18322);
		}
		public new bool AutoDismissed
		{
			set
			{
				setAutoDismissed(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAutoDismissed18323;
		public virtual void setAutoDismissed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setAutoDismissed18323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZoomButtonsController18324;
		public ZoomButtonsController(android.view.View arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._ZoomButtonsController18324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ZoomButtonsController()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomButtonsController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButtonsController"));
			global::android.widget.ZoomButtonsController._setVisible18312 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setVisible", "(Z)V");
			global::android.widget.ZoomButtonsController._isVisible18313 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "isVisible", "()Z");
			global::android.widget.ZoomButtonsController._getContainer18314 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "getContainer", "()Landroid/view/ViewGroup;");
			global::android.widget.ZoomButtonsController._setFocusable18315 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setFocusable", "(Z)V");
			global::android.widget.ZoomButtonsController._onTouch18316 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomButtonsController._getZoomControls18317 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "getZoomControls", "()Landroid/view/View;");
			global::android.widget.ZoomButtonsController._setZoomSpeed18318 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomButtonsController._setZoomInEnabled18319 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setZoomInEnabled", "(Z)V");
			global::android.widget.ZoomButtonsController._setZoomOutEnabled18320 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setZoomOutEnabled", "(Z)V");
			global::android.widget.ZoomButtonsController._setOnZoomListener18321 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V");
			global::android.widget.ZoomButtonsController._isAutoDismissed18322 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "isAutoDismissed", "()Z");
			global::android.widget.ZoomButtonsController._setAutoDismissed18323 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setAutoDismissed", "(Z)V");
			global::android.widget.ZoomButtonsController._ZoomButtonsController18324 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "<init>", "(Landroid/view/View;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
