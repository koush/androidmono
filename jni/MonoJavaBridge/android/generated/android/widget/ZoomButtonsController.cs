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
			internal static global::net.sf.jni4net.jni.MethodId _onVisibilityChanged12070;
			 void android.widget.ZoomButtonsController.OnZoomListener.onVisibilityChanged(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController.__OnZoomListener._onVisibilityChanged12070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass, global::android.widget.ZoomButtonsController.__OnZoomListener._onVisibilityChanged12070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onZoom12071;
			 void android.widget.ZoomButtonsController.OnZoomListener.onZoom(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController.__OnZoomListener._onZoom12071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass, global::android.widget.ZoomButtonsController.__OnZoomListener._onZoom12071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass = @__class;
				global::android.widget.ZoomButtonsController.__OnZoomListener._onVisibilityChanged12070 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass, "android.widget.ZoomButtonsController.OnZoomListener.onVisibilityChanged", "(Z)V");
				global::android.widget.ZoomButtonsController.__OnZoomListener._onZoom12071 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.__OnZoomListener.staticClass, "android.widget.ZoomButtonsController.OnZoomListener.onZoom", "(Z)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible12072;
		public virtual void setVisible(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setVisible12072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setVisible12072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isVisible12073;
		public virtual bool isVisible() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomButtonsController._isVisible12073);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isVisible12073);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContainer12074;
		public virtual global::android.view.ViewGroup getContainer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ZoomButtonsController._getContainer12074));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getContainer12074));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFocusable12075;
		public virtual void setFocusable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setFocusable12075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setFocusable12075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouch12076;
		public virtual bool onTouch(android.view.View arg0, android.view.MotionEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomButtonsController._onTouch12076, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._onTouch12076, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getZoomControls12077;
		public virtual global::android.view.View getZoomControls() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ZoomButtonsController._getZoomControls12077));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._getZoomControls12077));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setZoomSpeed12078;
		public virtual void setZoomSpeed(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setZoomSpeed12078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomSpeed12078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setZoomInEnabled12079;
		public virtual void setZoomInEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setZoomInEnabled12079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomInEnabled12079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setZoomOutEnabled12080;
		public virtual void setZoomOutEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setZoomOutEnabled12080, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setZoomOutEnabled12080, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnZoomListener12081;
		public virtual void setOnZoomListener(android.widget.ZoomButtonsController.OnZoomListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setOnZoomListener12081, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setOnZoomListener12081, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAutoDismissed12082;
		public virtual bool isAutoDismissed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomButtonsController._isAutoDismissed12082);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._isAutoDismissed12082);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAutoDismissed12083;
		public virtual void setAutoDismissed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomButtonsController._setAutoDismissed12083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._setAutoDismissed12083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ZoomButtonsController12084;
		public ZoomButtonsController(android.view.View arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ZoomButtonsController.staticClass, global::android.widget.ZoomButtonsController._ZoomButtonsController12084, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ZoomButtonsController.staticClass = @__class;
			global::android.widget.ZoomButtonsController._setVisible12072 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setVisible", "(Z)V");
			global::android.widget.ZoomButtonsController._isVisible12073 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "isVisible", "()Z");
			global::android.widget.ZoomButtonsController._getContainer12074 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "getContainer", "()Landroid/view/ViewGroup;");
			global::android.widget.ZoomButtonsController._setFocusable12075 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setFocusable", "(Z)V");
			global::android.widget.ZoomButtonsController._onTouch12076 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomButtonsController._getZoomControls12077 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "getZoomControls", "()Landroid/view/View;");
			global::android.widget.ZoomButtonsController._setZoomSpeed12078 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomButtonsController._setZoomInEnabled12079 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setZoomInEnabled", "(Z)V");
			global::android.widget.ZoomButtonsController._setZoomOutEnabled12080 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setZoomOutEnabled", "(Z)V");
			global::android.widget.ZoomButtonsController._setOnZoomListener12081 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V");
			global::android.widget.ZoomButtonsController._isAutoDismissed12082 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "isAutoDismissed", "()Z");
			global::android.widget.ZoomButtonsController._setAutoDismissed12083 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "setAutoDismissed", "(Z)V");
			global::android.widget.ZoomButtonsController._ZoomButtonsController12084 = @__env.GetMethodID(global::android.widget.ZoomButtonsController.staticClass, "<init>", "(Landroid/view/View;)V");
		}
	}
}
