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
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent12085;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomControls._onTouchEvent12085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._onTouchEvent12085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus12086;
		public override bool hasFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ZoomControls._hasFocus12086);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hasFocus12086);
		}
		internal static global::net.sf.jni4net.jni.MethodId _show12087;
		public virtual void show() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._show12087);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._show12087);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hide12088;
		public virtual void hide() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._hide12088);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hide12088);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setZoomSpeed12089;
		public virtual void setZoomSpeed(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setZoomSpeed12089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setZoomSpeed12089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnZoomInClickListener12090;
		public virtual void setOnZoomInClickListener(android.view.View.OnClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setOnZoomInClickListener12090, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomInClickListener12090, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnZoomOutClickListener12091;
		public virtual void setOnZoomOutClickListener(android.view.View.OnClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setOnZoomOutClickListener12091, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomOutClickListener12091, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIsZoomInEnabled12092;
		public virtual void setIsZoomInEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setIsZoomInEnabled12092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomInEnabled12092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIsZoomOutEnabled12093;
		public virtual void setIsZoomOutEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ZoomControls._setIsZoomOutEnabled12093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomOutEnabled12093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ZoomControls12094;
		public ZoomControls(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls12094, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ZoomControls12095;
		public ZoomControls(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls12095, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ZoomControls.staticClass = @__class;
			global::android.widget.ZoomControls._onTouchEvent12085 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomControls._hasFocus12086 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "hasFocus", "()Z");
			global::android.widget.ZoomControls._show12087 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "show", "()V");
			global::android.widget.ZoomControls._hide12088 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "hide", "()V");
			global::android.widget.ZoomControls._setZoomSpeed12089 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomControls._setOnZoomInClickListener12090 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setOnZoomOutClickListener12091 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setIsZoomInEnabled12092 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setIsZoomInEnabled", "(Z)V");
			global::android.widget.ZoomControls._setIsZoomOutEnabled12093 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setIsZoomOutEnabled", "(Z)V");
			global::android.widget.ZoomControls._ZoomControls12094 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ZoomControls._ZoomControls12095 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
