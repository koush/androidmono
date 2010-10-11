namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZoomButtonsController : java.lang.Object, android.view.View.OnTouchListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ZoomButtonsController()
		{
			InitJNI();
		}
		protected ZoomButtonsController(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ZoomButtonsController.OnZoomListener_))]
		public interface OnZoomListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onVisibilityChanged(bool arg0);
			void onZoom(bool arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ZoomButtonsController.OnZoomListener))]
		public sealed partial class OnZoomListener_ : java.lang.Object, OnZoomListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnZoomListener_()
			{
				InitJNI();
			}
			internal OnZoomListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onVisibilityChanged12457;
			 void android.widget.ZoomButtonsController.OnZoomListener.onVisibilityChanged(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_._onVisibilityChanged12457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, global::android.widget.ZoomButtonsController.OnZoomListener_._onVisibilityChanged12457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onZoom12458;
			 void android.widget.ZoomButtonsController.OnZoomListener.onZoom(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_._onZoom12458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, global::android.widget.ZoomButtonsController.OnZoomListener_._onZoom12458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButtonsController$OnZoomListener"));
				global::android.widget.ZoomButtonsController.OnZoomListener_._onVisibilityChanged12457 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, "onVisibilityChanged", "(Z)V");
				global::android.widget.ZoomButtonsController.OnZoomListener_._onZoom12458 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, "onZoom", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVisible12459;
		public virtual void setVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setVisible12459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setVisible12459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVisible12460;
		public virtual bool isVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._isVisible12460);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isVisible12460);
		}
		internal static global::MonoJavaBridge.MethodId _getContainer12461;
		public virtual global::android.view.ViewGroup getContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._getContainer12461)) as android.view.ViewGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getContainer12461)) as android.view.ViewGroup;
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable12462;
		public virtual void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setFocusable12462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setFocusable12462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouch12463;
		public virtual bool onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._onTouch12463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._onTouch12463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControls12464;
		public virtual global::android.view.View getZoomControls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._getZoomControls12464)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getZoomControls12464)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setZoomSpeed12465;
		public virtual void setZoomSpeed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setZoomSpeed12465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomSpeed12465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZoomInEnabled12466;
		public virtual void setZoomInEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setZoomInEnabled12466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomInEnabled12466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZoomOutEnabled12467;
		public virtual void setZoomOutEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setZoomOutEnabled12467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomOutEnabled12467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnZoomListener12468;
		public virtual void setOnZoomListener(android.widget.ZoomButtonsController.OnZoomListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setOnZoomListener12468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setOnZoomListener12468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoDismissed12469;
		public virtual bool isAutoDismissed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._isAutoDismissed12469);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isAutoDismissed12469);
		}
		internal static global::MonoJavaBridge.MethodId _setAutoDismissed12470;
		public virtual void setAutoDismissed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setAutoDismissed12470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setAutoDismissed12470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZoomButtonsController12471;
		public ZoomButtonsController(android.view.View arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._ZoomButtonsController12471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomButtonsController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButtonsController"));
			global::android.widget.ZoomButtonsController._setVisible12459 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setVisible", "(Z)V");
			global::android.widget.ZoomButtonsController._isVisible12460 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "isVisible", "()Z");
			global::android.widget.ZoomButtonsController._getContainer12461 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "getContainer", "()Landroid/view/ViewGroup;");
			global::android.widget.ZoomButtonsController._setFocusable12462 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setFocusable", "(Z)V");
			global::android.widget.ZoomButtonsController._onTouch12463 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomButtonsController._getZoomControls12464 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "getZoomControls", "()Landroid/view/View;");
			global::android.widget.ZoomButtonsController._setZoomSpeed12465 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomButtonsController._setZoomInEnabled12466 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setZoomInEnabled", "(Z)V");
			global::android.widget.ZoomButtonsController._setZoomOutEnabled12467 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setZoomOutEnabled", "(Z)V");
			global::android.widget.ZoomButtonsController._setOnZoomListener12468 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V");
			global::android.widget.ZoomButtonsController._isAutoDismissed12469 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "isAutoDismissed", "()Z");
			global::android.widget.ZoomButtonsController._setAutoDismissed12470 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setAutoDismissed", "(Z)V");
			global::android.widget.ZoomButtonsController._ZoomButtonsController12471 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "<init>", "(Landroid/view/View;)V");
		}
	}
}
