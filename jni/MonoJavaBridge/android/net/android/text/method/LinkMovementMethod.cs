namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LinkMovementMethod : android.text.method.ScrollingMovementMethod
	{ 
		internal new static global::java.lang.Class staticClass; 
		static LinkMovementMethod() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.LinkMovementMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.LinkMovementMethod(@__env); 
			} 
		} 
		protected LinkMovementMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6801; 
		public static new android.text.method.MovementMethod getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.LinkMovementMethod.staticClass, _getInstance6801)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initialize6802; 
		public override void initialize(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.LinkMovementMethod)) 
				@__env.CallVoidMethod(this, _initialize6802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.LinkMovementMethod.staticClass, _initialize6802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _left6803; 
		protected override bool left(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.LinkMovementMethod)) 
				return @__env.CallBooleanMethod(this, _left6803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.LinkMovementMethod.staticClass, _left6803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _right6804; 
		protected override bool right(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.LinkMovementMethod)) 
				return @__env.CallBooleanMethod(this, _right6804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.LinkMovementMethod.staticClass, _right6804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown6805; 
		public override bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.LinkMovementMethod)) 
				return @__env.CallBooleanMethod(this, _onKeyDown6805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.LinkMovementMethod.staticClass, _onKeyDown6805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp6806; 
		public override bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.LinkMovementMethod)) 
				return @__env.CallBooleanMethod(this, _onKeyUp6806, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.LinkMovementMethod.staticClass, _onKeyUp6806, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent6807; 
		public override bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.LinkMovementMethod)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent6807, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.LinkMovementMethod.staticClass, _onTouchEvent6807, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _up6808; 
		protected override bool up(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.LinkMovementMethod)) 
				return @__env.CallBooleanMethod(this, _up6808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.LinkMovementMethod.staticClass, _up6808, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _down6809; 
		protected override bool down(android.widget.TextView arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.LinkMovementMethod)) 
				return @__env.CallBooleanMethod(this, _down6809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.LinkMovementMethod.staticClass, _down6809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTakeFocus6810; 
		public override void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.LinkMovementMethod)) 
				@__env.CallVoidMethod(this, _onTakeFocus6810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.LinkMovementMethod.staticClass, _onTakeFocus6810, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LinkMovementMethod6811; 
		public LinkMovementMethod()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.LinkMovementMethod.staticClass, _LinkMovementMethod6811, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.LinkMovementMethod.staticClass = @__class; 
			global::android.text.method.LinkMovementMethod._getInstance6801 = @__env.GetStaticMethodID(global::android.text.method.LinkMovementMethod.staticClass, "getInstance", "()Landroid/text/method/MovementMethod;"); 
			global::android.text.method.LinkMovementMethod._initialize6802 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V"); 
			global::android.text.method.LinkMovementMethod._left6803 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z"); 
			global::android.text.method.LinkMovementMethod._right6804 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z"); 
			global::android.text.method.LinkMovementMethod._onKeyDown6805 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.LinkMovementMethod._onKeyUp6806 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.LinkMovementMethod._onTouchEvent6807 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z"); 
			global::android.text.method.LinkMovementMethod._up6808 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z"); 
			global::android.text.method.LinkMovementMethod._down6809 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z"); 
			global::android.text.method.LinkMovementMethod._onTakeFocus6810 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V"); 
			global::android.text.method.LinkMovementMethod._LinkMovementMethod6811 = @__env.GetMethodID(global::android.text.method.LinkMovementMethod.staticClass, "<init>", "()V"); 
		} 
	} 
} 
