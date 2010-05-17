namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ZoomControls : android.widget.LinearLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ZoomControls() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ZoomControls), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10545; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomControls)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent10545, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ZoomControls.staticClass, _onTouchEvent10545, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus10546; 
		public override bool hasFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomControls)) 
				return @__env.CallBooleanMethod(this, _hasFocus10546); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ZoomControls.staticClass, _hasFocus10546); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show10547; 
		public virtual void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomControls)) 
				@__env.CallVoidMethod(this, _show10547); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomControls.staticClass, _show10547); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hide10548; 
		public virtual void hide() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomControls)) 
				@__env.CallVoidMethod(this, _hide10548); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomControls.staticClass, _hide10548); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZoomSpeed10549; 
		public virtual void setZoomSpeed(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomControls)) 
				@__env.CallVoidMethod(this, _setZoomSpeed10549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomControls.staticClass, _setZoomSpeed10549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnZoomInClickListener10550; 
		public virtual void setOnZoomInClickListener(android.view.View.OnClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomControls)) 
				@__env.CallVoidMethod(this, _setOnZoomInClickListener10550, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomControls.staticClass, _setOnZoomInClickListener10550, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnZoomOutClickListener10551; 
		public virtual void setOnZoomOutClickListener(android.view.View.OnClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomControls)) 
				@__env.CallVoidMethod(this, _setOnZoomOutClickListener10551, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomControls.staticClass, _setOnZoomOutClickListener10551, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIsZoomInEnabled10552; 
		public virtual void setIsZoomInEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomControls)) 
				@__env.CallVoidMethod(this, _setIsZoomInEnabled10552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomControls.staticClass, _setIsZoomInEnabled10552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIsZoomOutEnabled10553; 
		public virtual void setIsZoomOutEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomControls)) 
				@__env.CallVoidMethod(this, _setIsZoomOutEnabled10553, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomControls.staticClass, _setIsZoomOutEnabled10553, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ZoomControls10554; 
		public ZoomControls(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ZoomControls.staticClass, _ZoomControls10554, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ZoomControls10555; 
		public ZoomControls(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ZoomControls.staticClass, _ZoomControls10555, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ZoomControls.staticClass = @__class; 
			global::android.widget.ZoomControls._onTouchEvent10545 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.ZoomControls._hasFocus10546 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "hasFocus", "()Z"); 
			global::android.widget.ZoomControls._show10547 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "show", "()V"); 
			global::android.widget.ZoomControls._hide10548 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "hide", "()V"); 
			global::android.widget.ZoomControls._setZoomSpeed10549 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setZoomSpeed", "(J)V"); 
			global::android.widget.ZoomControls._setOnZoomInClickListener10550 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V"); 
			global::android.widget.ZoomControls._setOnZoomOutClickListener10551 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V"); 
			global::android.widget.ZoomControls._setIsZoomInEnabled10552 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setIsZoomInEnabled", "(Z)V"); 
			global::android.widget.ZoomControls._setIsZoomOutEnabled10553 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "setIsZoomOutEnabled", "(Z)V"); 
			global::android.widget.ZoomControls._ZoomControls10554 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.ZoomControls._ZoomControls10555 = @__env.GetMethodID(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
