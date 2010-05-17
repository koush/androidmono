namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ZoomButtonsController : java.lang.Object, android.view.View.OnTouchListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static ZoomButtonsController() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ZoomButtonsController), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ZoomButtonsController(@__env); 
			} 
		} 
		protected ZoomButtonsController(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnZoomListener 
		{ 
			void onVisibilityChanged(bool arg0); 
			void onZoom(bool arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible10532; 
		public virtual void setVisible(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				@__env.CallVoidMethod(this, _setVisible10532, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomButtonsController.staticClass, _setVisible10532, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVisible10533; 
		public virtual bool isVisible() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				return @__env.CallBooleanMethod(this, _isVisible10533); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ZoomButtonsController.staticClass, _isVisible10533); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContainer10534; 
		public virtual android.view.ViewGroup getContainer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup>(@__env, @__env.CallObjectMethodPtr(this, _getContainer10534)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ZoomButtonsController.staticClass, _getContainer10534)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable10535; 
		public virtual void setFocusable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				@__env.CallVoidMethod(this, _setFocusable10535, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomButtonsController.staticClass, _setFocusable10535, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouch10536; 
		public virtual bool onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				return @__env.CallBooleanMethod(this, _onTouch10536, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ZoomButtonsController.staticClass, _onTouch10536, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZoomControls10537; 
		public virtual android.view.View getZoomControls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getZoomControls10537)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ZoomButtonsController.staticClass, _getZoomControls10537)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZoomSpeed10538; 
		public virtual void setZoomSpeed(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				@__env.CallVoidMethod(this, _setZoomSpeed10538, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomButtonsController.staticClass, _setZoomSpeed10538, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZoomInEnabled10539; 
		public virtual void setZoomInEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				@__env.CallVoidMethod(this, _setZoomInEnabled10539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomButtonsController.staticClass, _setZoomInEnabled10539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZoomOutEnabled10540; 
		public virtual void setZoomOutEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				@__env.CallVoidMethod(this, _setZoomOutEnabled10540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomButtonsController.staticClass, _setZoomOutEnabled10540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnZoomListener10541; 
		public virtual void setOnZoomListener(android.widget.ZoomButtonsController.OnZoomListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				@__env.CallVoidMethod(this, _setOnZoomListener10541, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomButtonsController.staticClass, _setOnZoomListener10541, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAutoDismissed10542; 
		public virtual bool isAutoDismissed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				return @__env.CallBooleanMethod(this, _isAutoDismissed10542); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ZoomButtonsController.staticClass, _isAutoDismissed10542); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAutoDismissed10543; 
		public virtual void setAutoDismissed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButtonsController)) 
				@__env.CallVoidMethod(this, _setAutoDismissed10543, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomButtonsController.staticClass, _setAutoDismissed10543, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ZoomButtonsController10544; 
		public ZoomButtonsController(android.view.View arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ZoomButtonsController.staticClass, _ZoomButtonsController10544, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ZoomButtonsController.staticClass = @__class; 
			global::android.widget.ZoomButtonsController._setVisible10532 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setVisible", "(Z)V"); 
			global::android.widget.ZoomButtonsController._isVisible10533 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "isVisible", "()Z"); 
			global::android.widget.ZoomButtonsController._getContainer10534 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "getContainer", "()Landroid/view/ViewGroup;"); 
			global::android.widget.ZoomButtonsController._setFocusable10535 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setFocusable", "(Z)V"); 
			global::android.widget.ZoomButtonsController._onTouch10536 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"); 
			global::android.widget.ZoomButtonsController._getZoomControls10537 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "getZoomControls", "()Landroid/view/View;"); 
			global::android.widget.ZoomButtonsController._setZoomSpeed10538 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setZoomSpeed", "(J)V"); 
			global::android.widget.ZoomButtonsController._setZoomInEnabled10539 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setZoomInEnabled", "(Z)V"); 
			global::android.widget.ZoomButtonsController._setZoomOutEnabled10540 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setZoomOutEnabled", "(Z)V"); 
			global::android.widget.ZoomButtonsController._setOnZoomListener10541 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V"); 
			global::android.widget.ZoomButtonsController._isAutoDismissed10542 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "isAutoDismissed", "()Z"); 
			global::android.widget.ZoomButtonsController._setAutoDismissed10543 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setAutoDismissed", "(Z)V"); 
			global::android.widget.ZoomButtonsController._ZoomButtonsController10544 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "<init>", "(Landroid/view/View;)V"); 
		} 
	} 
} 
