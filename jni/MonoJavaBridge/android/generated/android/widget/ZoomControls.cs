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
		internal static global::MonoJavaBridge.MethodId _onTouchEvent13018;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls._onTouchEvent13018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._onTouchEvent13018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus13019;
		public override bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls._hasFocus13019);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hasFocus13019);
		}
		internal static global::MonoJavaBridge.MethodId _show13020;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._show13020);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._show13020);
		}
		internal static global::MonoJavaBridge.MethodId _hide13021;
		public virtual void hide() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._hide13021);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hide13021);
		}
		internal static global::MonoJavaBridge.MethodId _setZoomSpeed13022;
		public virtual void setZoomSpeed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setZoomSpeed13022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setZoomSpeed13022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnZoomInClickListener13023;
		public virtual void setOnZoomInClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setOnZoomInClickListener13023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomInClickListener13023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnZoomOutClickListener13024;
		public virtual void setOnZoomOutClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setOnZoomOutClickListener13024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomOutClickListener13024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIsZoomInEnabled13025;
		public virtual void setIsZoomInEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setIsZoomInEnabled13025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomInEnabled13025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIsZoomOutEnabled13026;
		public virtual void setIsZoomOutEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setIsZoomOutEnabled13026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomOutEnabled13026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZoomControls13027;
		public ZoomControls(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls13027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZoomControls13028;
		public ZoomControls(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls13028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomControls.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomControls"));
			global::android.widget.ZoomControls._onTouchEvent13018 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomControls._hasFocus13019 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "hasFocus", "()Z");
			global::android.widget.ZoomControls._show13020 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "show", "()V");
			global::android.widget.ZoomControls._hide13021 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "hide", "()V");
			global::android.widget.ZoomControls._setZoomSpeed13022 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomControls._setOnZoomInClickListener13023 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setOnZoomOutClickListener13024 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setIsZoomInEnabled13025 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setIsZoomInEnabled", "(Z)V");
			global::android.widget.ZoomControls._setIsZoomOutEnabled13026 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setIsZoomOutEnabled", "(Z)V");
			global::android.widget.ZoomControls._ZoomControls13027 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ZoomControls._ZoomControls13028 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
