namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ZoomButton : android.widget.ImageButton, android.view.View.OnLongClickListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ZoomButton() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ZoomButton), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ZoomButton(@__env); 
			} 
		} 
		protected ZoomButton(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled10523; 
		public override void setEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButton)) 
				@__env.CallVoidMethod(this, _setEnabled10523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomButton.staticClass, _setEnabled10523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10524; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButton)) 
				return @__env.CallBooleanMethod(this, _onKeyUp10524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ZoomButton.staticClass, _onKeyUp10524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10525; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButton)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent10525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ZoomButton.staticClass, _onTouchEvent10525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchUnhandledMove10526; 
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButton)) 
				return @__env.CallBooleanMethod(this, _dispatchUnhandledMove10526, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ZoomButton.staticClass, _dispatchUnhandledMove10526, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLongClick10527; 
		public virtual bool onLongClick(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButton)) 
				return @__env.CallBooleanMethod(this, _onLongClick10527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.ZoomButton.staticClass, _onLongClick10527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZoomSpeed10528; 
		public virtual void setZoomSpeed(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ZoomButton)) 
				@__env.CallVoidMethod(this, _setZoomSpeed10528, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ZoomButton.staticClass, _setZoomSpeed10528, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ZoomButton10529; 
		public ZoomButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ZoomButton.staticClass, _ZoomButton10529, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ZoomButton10530; 
		public ZoomButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ZoomButton.staticClass, _ZoomButton10530, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ZoomButton10531; 
		public ZoomButton(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ZoomButton.staticClass, _ZoomButton10531, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ZoomButton.staticClass = @__class; 
			global::android.widget.ZoomButton._setEnabled10523 = @__env.GetMethodID(global::android.widget.ZoomButton.staticClass, "setEnabled", "(Z)V"); 
			global::android.widget.ZoomButton._onKeyUp10524 = @__env.GetMethodID(global::android.widget.ZoomButton.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.ZoomButton._onTouchEvent10525 = @__env.GetMethodID(global::android.widget.ZoomButton.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.ZoomButton._dispatchUnhandledMove10526 = @__env.GetMethodID(global::android.widget.ZoomButton.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z"); 
			global::android.widget.ZoomButton._onLongClick10527 = @__env.GetMethodID(global::android.widget.ZoomButton.staticClass, "onLongClick", "(Landroid/view/View;)Z"); 
			global::android.widget.ZoomButton._setZoomSpeed10528 = @__env.GetMethodID(global::android.widget.ZoomButton.staticClass, "setZoomSpeed", "(J)V"); 
			global::android.widget.ZoomButton._ZoomButton10529 = @__env.GetMethodID(global::android.widget.ZoomButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ZoomButton._ZoomButton10530 = @__env.GetMethodID(global::android.widget.ZoomButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.widget.ZoomButton._ZoomButton10531 = @__env.GetMethodID(global::android.widget.ZoomButton.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
