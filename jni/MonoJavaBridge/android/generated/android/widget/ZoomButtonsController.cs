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
			internal static global::MonoJavaBridge.MethodId _onVisibilityChanged13003;
			 void android.widget.ZoomButtonsController.OnZoomListener.onVisibilityChanged(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_._onVisibilityChanged13003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, global::android.widget.ZoomButtonsController.OnZoomListener_._onVisibilityChanged13003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onZoom13004;
			 void android.widget.ZoomButtonsController.OnZoomListener.onZoom(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_._onZoom13004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, global::android.widget.ZoomButtonsController.OnZoomListener_._onZoom13004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButtonsController$OnZoomListener"));
				global::android.widget.ZoomButtonsController.OnZoomListener_._onVisibilityChanged13003 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, "onVisibilityChanged", "(Z)V");
				global::android.widget.ZoomButtonsController.OnZoomListener_._onZoom13004 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.OnZoomListener_.staticClass, "onZoom", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVisible13005;
		public virtual void setVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setVisible13005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setVisible13005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isVisible13006;
		public virtual bool isVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._isVisible13006);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isVisible13006);
		}
		public new global::android.view.ViewGroup Container
		{
			get
			{
				return getContainer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContainer13007;
		public virtual global::android.view.ViewGroup getContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._getContainer13007)) as android.view.ViewGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getContainer13007)) as android.view.ViewGroup;
		}
		internal static global::MonoJavaBridge.MethodId _setFocusable13008;
		public virtual void setFocusable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setFocusable13008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setFocusable13008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTouch13009;
		public virtual bool onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._onTouch13009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._onTouch13009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.View ZoomControls
		{
			get
			{
				return getZoomControls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControls13010;
		public virtual global::android.view.View getZoomControls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._getZoomControls13010)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getZoomControls13010)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setZoomSpeed13011;
		public virtual void setZoomSpeed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setZoomSpeed13011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomSpeed13011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZoomInEnabled13012;
		public virtual void setZoomInEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setZoomInEnabled13012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomInEnabled13012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZoomOutEnabled13013;
		public virtual void setZoomOutEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setZoomOutEnabled13013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomOutEnabled13013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnZoomListener13014;
		public virtual void setOnZoomListener(android.widget.ZoomButtonsController.OnZoomListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setOnZoomListener13014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setOnZoomListener13014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoDismissed13015;
		public virtual bool isAutoDismissed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._isAutoDismissed13015);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isAutoDismissed13015);
		}
		internal static global::MonoJavaBridge.MethodId _setAutoDismissed13016;
		public virtual void setAutoDismissed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController._setAutoDismissed13016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setAutoDismissed13016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZoomButtonsController13017;
		public ZoomButtonsController(android.view.View arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._ZoomButtonsController13017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomButtonsController.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButtonsController"));
			global::android.widget.ZoomButtonsController._setVisible13005 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setVisible", "(Z)V");
			global::android.widget.ZoomButtonsController._isVisible13006 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "isVisible", "()Z");
			global::android.widget.ZoomButtonsController._getContainer13007 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "getContainer", "()Landroid/view/ViewGroup;");
			global::android.widget.ZoomButtonsController._setFocusable13008 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setFocusable", "(Z)V");
			global::android.widget.ZoomButtonsController._onTouch13009 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomButtonsController._getZoomControls13010 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "getZoomControls", "()Landroid/view/View;");
			global::android.widget.ZoomButtonsController._setZoomSpeed13011 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomButtonsController._setZoomInEnabled13012 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setZoomInEnabled", "(Z)V");
			global::android.widget.ZoomButtonsController._setZoomOutEnabled13013 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setZoomOutEnabled", "(Z)V");
			global::android.widget.ZoomButtonsController._setOnZoomListener13014 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V");
			global::android.widget.ZoomButtonsController._isAutoDismissed13015 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "isAutoDismissed", "()Z");
			global::android.widget.ZoomButtonsController._setAutoDismissed13016 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "setAutoDismissed", "(Z)V");
			global::android.widget.ZoomButtonsController._ZoomButtonsController13017 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButtonsController.staticClass, "<init>", "(Landroid/view/View;)V");
		}
	}
}
