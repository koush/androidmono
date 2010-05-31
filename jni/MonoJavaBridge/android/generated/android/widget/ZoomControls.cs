namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ZoomControls : android.widget.LinearLayout
	{
		internal new static global::java.lang.Class staticClass;
		static ZoomControls()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ZoomControls), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ZoomControls(@__env);
			}
		}
		protected ZoomControls(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11366;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomControls._onTouchEvent11366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._onTouchEvent11366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus11367;
		public override bool hasFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomControls._hasFocus11367);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hasFocus11367);
		}
		internal static global::net.sf.jni4net.jni.MethodId _show11368;
		public virtual void show() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._show11368);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._show11368);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hide11369;
		public virtual void hide() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._hide11369);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hide11369);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setZoomSpeed11370;
		public virtual void setZoomSpeed(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setZoomSpeed11370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setZoomSpeed11370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnZoomInClickListener11371;
		public virtual void setOnZoomInClickListener(android.view.View.OnClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setOnZoomInClickListener11371, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomInClickListener11371, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnZoomOutClickListener11372;
		public virtual void setOnZoomOutClickListener(android.view.View.OnClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setOnZoomOutClickListener11372, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomOutClickListener11372, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIsZoomInEnabled11373;
		public virtual void setIsZoomInEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setIsZoomInEnabled11373, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomInEnabled11373, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIsZoomOutEnabled11374;
		public virtual void setIsZoomOutEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setIsZoomOutEnabled11374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomOutEnabled11374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ZoomControls11375;
		public ZoomControls(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls11375, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ZoomControls11376;
		public ZoomControls(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls11376, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ZoomControls.staticClass = @__class;
			global::android.widget.ZoomControls._onTouchEvent11366 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomControls._hasFocus11367 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "hasFocus", "()Z");
			global::android.widget.ZoomControls._show11368 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "show", "()V");
			global::android.widget.ZoomControls._hide11369 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "hide", "()V");
			global::android.widget.ZoomControls._setZoomSpeed11370 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomControls._setOnZoomInClickListener11371 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setOnZoomOutClickListener11372 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setIsZoomInEnabled11373 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setIsZoomInEnabled", "(Z)V");
			global::android.widget.ZoomControls._setIsZoomOutEnabled11374 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setIsZoomOutEnabled", "(Z)V");
			global::android.widget.ZoomControls._ZoomControls11375 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ZoomControls._ZoomControls11376 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
