namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZoomControls : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ZoomControls()
		{
			InitJNI();
		}
		protected ZoomControls(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent18207;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls._onTouchEvent18207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._onTouchEvent18207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus18208;
		public override bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls._hasFocus18208);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hasFocus18208);
		}
		internal static global::MonoJavaBridge.MethodId _show18209;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._show18209);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._show18209);
		}
		internal static global::MonoJavaBridge.MethodId _hide18210;
		public virtual void hide() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._hide18210);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hide18210);
		}
		internal static global::MonoJavaBridge.MethodId _setZoomSpeed18211;
		public virtual void setZoomSpeed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setZoomSpeed18211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setZoomSpeed18211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnZoomInClickListener18212;
		public virtual void setOnZoomInClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setOnZoomInClickListener18212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomInClickListener18212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnZoomOutClickListener18213;
		public virtual void setOnZoomOutClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setOnZoomOutClickListener18213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomOutClickListener18213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIsZoomInEnabled18214;
		public virtual void setIsZoomInEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setIsZoomInEnabled18214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomInEnabled18214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIsZoomOutEnabled18215;
		public virtual void setIsZoomOutEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setIsZoomOutEnabled18215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomOutEnabled18215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZoomControls18216;
		public ZoomControls(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls18216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZoomControls18217;
		public ZoomControls(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls18217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomControls.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomControls"));
			global::android.widget.ZoomControls._onTouchEvent18207 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomControls._hasFocus18208 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "hasFocus", "()Z");
			global::android.widget.ZoomControls._show18209 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "show", "()V");
			global::android.widget.ZoomControls._hide18210 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "hide", "()V");
			global::android.widget.ZoomControls._setZoomSpeed18211 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomControls._setOnZoomInClickListener18212 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setOnZoomOutClickListener18213 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setIsZoomInEnabled18214 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setIsZoomInEnabled", "(Z)V");
			global::android.widget.ZoomControls._setIsZoomOutEnabled18215 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setIsZoomOutEnabled", "(Z)V");
			global::android.widget.ZoomControls._ZoomControls18216 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ZoomControls._ZoomControls18217 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
