namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ScrollingMovementMethod : java.lang.Object, MovementMethod
	{ 
		internal static global::java.lang.Class staticClass; 
		static ScrollingMovementMethod() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.ScrollingMovementMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.ScrollingMovementMethod(@__env); 
			} 
		} 
		protected ScrollingMovementMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6861; 
		public static android.text.method.MovementMethod getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.ScrollingMovementMethod.staticClass, _getInstance6861)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initialize6862; 
		public virtual void initialize(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				@__env.CallVoidMethod(this, _initialize6862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _initialize6862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _left6863; 
		protected virtual bool left(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _left6863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _left6863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _right6864; 
		protected virtual bool right(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _right6864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _right6864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown6865; 
		public virtual bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _onKeyDown6865, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _onKeyDown6865, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp6866; 
		public virtual bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _onKeyUp6866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _onKeyUp6866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent6867; 
		public virtual bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent6867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _onTouchEvent6867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent6868; 
		public virtual bool onTrackballEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent6868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _onTrackballEvent6868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _up6869; 
		protected virtual bool up(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _up6869, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _up6869, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _down6870; 
		protected virtual bool down(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _down6870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _down6870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyOther6871; 
		public virtual bool onKeyOther(android.widget.TextView arg0, android.text.Spannable arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _onKeyOther6871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _onKeyOther6871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTakeFocus6872; 
		public virtual void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				@__env.CallVoidMethod(this, _onTakeFocus6872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _onTakeFocus6872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canSelectArbitrarily6873; 
		public virtual bool canSelectArbitrarily() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ScrollingMovementMethod)) 
				return @__env.CallBooleanMethod(this, _canSelectArbitrarily6873); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.ScrollingMovementMethod.staticClass, _canSelectArbitrarily6873); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ScrollingMovementMethod6874; 
		public ScrollingMovementMethod()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.ScrollingMovementMethod.staticClass, _ScrollingMovementMethod6874, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.ScrollingMovementMethod.staticClass = @__class; 
			global::android.text.method.ScrollingMovementMethod._getInstance6861 = @__env.GetStaticMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "getInstance", "()Landroid/text/method/MovementMethod;"); 
			global::android.text.method.ScrollingMovementMethod._initialize6862 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V"); 
			global::android.text.method.ScrollingMovementMethod._left6863 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z"); 
			global::android.text.method.ScrollingMovementMethod._right6864 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z"); 
			global::android.text.method.ScrollingMovementMethod._onKeyDown6865 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.ScrollingMovementMethod._onKeyUp6866 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.ScrollingMovementMethod._onTouchEvent6867 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z"); 
			global::android.text.method.ScrollingMovementMethod._onTrackballEvent6868 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z"); 
			global::android.text.method.ScrollingMovementMethod._up6869 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z"); 
			global::android.text.method.ScrollingMovementMethod._down6870 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z"); 
			global::android.text.method.ScrollingMovementMethod._onKeyOther6871 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z"); 
			global::android.text.method.ScrollingMovementMethod._onTakeFocus6872 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V"); 
			global::android.text.method.ScrollingMovementMethod._canSelectArbitrarily6873 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "canSelectArbitrarily", "()Z"); 
			global::android.text.method.ScrollingMovementMethod._ScrollingMovementMethod6874 = @__env.GetMethodID(global::android.text.method.ScrollingMovementMethod.staticClass, "<init>", "()V"); 
		} 
	} 
} 
