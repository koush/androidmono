namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkMovementMethod : android.text.method.ScrollingMovementMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinkMovementMethod()
		{
			InitJNI();
		}
		protected LinkMovementMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.MovementMethod Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance8626;
		public static global::android.text.method.MovementMethod getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallStaticObjectMethod(android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._getInstance8626)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _initialize8627;
		public override void initialize(android.widget.TextView arg0, android.text.Spannable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod._initialize8627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._initialize8627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _left8628;
		protected override bool left(android.widget.TextView arg0, android.text.Spannable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod._left8628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._left8628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _right8629;
		protected override bool right(android.widget.TextView arg0, android.text.Spannable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod._right8629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._right8629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown8630;
		public override bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod._onKeyDown8630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._onKeyDown8630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp8631;
		public override bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod._onKeyUp8631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._onKeyUp8631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent8632;
		public override bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod._onTouchEvent8632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._onTouchEvent8632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _up8633;
		protected override bool up(android.widget.TextView arg0, android.text.Spannable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod._up8633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._up8633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _down8634;
		protected override bool down(android.widget.TextView arg0, android.text.Spannable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod._down8634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._down8634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTakeFocus8635;
		public override void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod._onTakeFocus8635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._onTakeFocus8635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _LinkMovementMethod8636;
		public LinkMovementMethod()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._LinkMovementMethod8636);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.LinkMovementMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/LinkMovementMethod"));
			global::android.text.method.LinkMovementMethod._getInstance8626 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "getInstance", "()Landroid/text/method/MovementMethod;");
			global::android.text.method.LinkMovementMethod._initialize8627 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V");
			global::android.text.method.LinkMovementMethod._left8628 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			global::android.text.method.LinkMovementMethod._right8629 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			global::android.text.method.LinkMovementMethod._onKeyDown8630 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.LinkMovementMethod._onKeyUp8631 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.LinkMovementMethod._onTouchEvent8632 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			global::android.text.method.LinkMovementMethod._up8633 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			global::android.text.method.LinkMovementMethod._down8634 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			global::android.text.method.LinkMovementMethod._onTakeFocus8635 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V");
			global::android.text.method.LinkMovementMethod._LinkMovementMethod8636 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "<init>", "()V");
		}
	}
}
