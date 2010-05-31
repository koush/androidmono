namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ZoomButtonsController : java.lang.Object, android.view.View.OnTouchListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static ZoomButtonsController() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ZoomButtonsController), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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

		public partial class OnZoomListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnZoomListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnZoomListener : java.lang.Object, OnZoomListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnZoomListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ZoomButtonsController.__OnZoomListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.ZoomButtonsController.__OnZoomListener(@__env); 
				} 
			} 
			internal __OnZoomListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onVisibilityChanged11351; 
			 void android.widget.ZoomButtonsController.OnZoomListener.onVisibilityChanged(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController.__OnZoomListener._onVisibilityChanged11351, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass, global::android.widget.ZoomButtonsController.__OnZoomListener._onVisibilityChanged11351, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onZoom11352; 
			 void android.widget.ZoomButtonsController.OnZoomListener.onZoom(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController.__OnZoomListener._onZoom11352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass, global::android.widget.ZoomButtonsController.__OnZoomListener._onZoom11352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass = @__class; 
				global::android.widget.ZoomButtonsController.__OnZoomListener._onVisibilityChanged11351 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass, "android.widget.ZoomButtonsController.OnZoomListener.onVisibilityChanged", "(Z)V"); 
				global::android.widget.ZoomButtonsController.__OnZoomListener._onZoom11352 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass, "android.widget.ZoomButtonsController.OnZoomListener.onZoom", "(Z)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible11353; 
		public virtual void setVisible(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setVisible11353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setVisible11353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVisible11354; 
		public virtual bool isVisible() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomButtonsController._isVisible11354); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isVisible11354); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContainer11355; 
		public virtual global::android.view.ViewGroup getContainer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ZoomButtonsController._getContainer11355)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getContainer11355)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable11356; 
		public virtual void setFocusable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setFocusable11356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setFocusable11356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouch11357; 
		public virtual bool onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomButtonsController._onTouch11357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._onTouch11357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZoomControls11358; 
		public virtual global::android.view.View getZoomControls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ZoomButtonsController._getZoomControls11358)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getZoomControls11358)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZoomSpeed11359; 
		public virtual void setZoomSpeed(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setZoomSpeed11359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomSpeed11359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZoomInEnabled11360; 
		public virtual void setZoomInEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setZoomInEnabled11360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomInEnabled11360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZoomOutEnabled11361; 
		public virtual void setZoomOutEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setZoomOutEnabled11361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomOutEnabled11361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnZoomListener11362; 
		public virtual void setOnZoomListener(android.widget.ZoomButtonsController.OnZoomListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setOnZoomListener11362, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setOnZoomListener11362, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAutoDismissed11363; 
		public virtual bool isAutoDismissed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomButtonsController._isAutoDismissed11363); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isAutoDismissed11363); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAutoDismissed11364; 
		public virtual void setAutoDismissed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setAutoDismissed11364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setAutoDismissed11364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ZoomButtonsController11365; 
		public ZoomButtonsController(android.view.View arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._ZoomButtonsController11365, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ZoomButtonsController.staticClass = @__class; 
			global::android.widget.ZoomButtonsController._setVisible11353 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setVisible", "(Z)V"); 
			global::android.widget.ZoomButtonsController._isVisible11354 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "isVisible", "()Z"); 
			global::android.widget.ZoomButtonsController._getContainer11355 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "getContainer", "()Landroid/view/ViewGroup;"); 
			global::android.widget.ZoomButtonsController._setFocusable11356 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setFocusable", "(Z)V"); 
			global::android.widget.ZoomButtonsController._onTouch11357 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"); 
			global::android.widget.ZoomButtonsController._getZoomControls11358 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "getZoomControls", "()Landroid/view/View;"); 
			global::android.widget.ZoomButtonsController._setZoomSpeed11359 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setZoomSpeed", "(J)V"); 
			global::android.widget.ZoomButtonsController._setZoomInEnabled11360 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setZoomInEnabled", "(Z)V"); 
			global::android.widget.ZoomButtonsController._setZoomOutEnabled11361 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setZoomOutEnabled", "(Z)V"); 
			global::android.widget.ZoomButtonsController._setOnZoomListener11362 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V"); 
			global::android.widget.ZoomButtonsController._isAutoDismissed11363 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "isAutoDismissed", "()Z"); 
			global::android.widget.ZoomButtonsController._setAutoDismissed11364 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setAutoDismissed", "(Z)V"); 
			global::android.widget.ZoomButtonsController._ZoomButtonsController11365 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "<init>", "(Landroid/view/View;)V"); 
		} 
	} 
} 
