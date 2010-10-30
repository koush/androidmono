namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkMovementMethod : android.text.method.ScrollingMovementMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.method.MovementMethod getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "getInstance", "()Landroid/text/method/MovementMethod;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallStaticObjectMethod(android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._m0)) as android.text.method.MovementMethod;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void initialize(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.LinkMovementMethod.staticClass, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", ref global::android.text.method.LinkMovementMethod._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override bool left(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, "left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", ref global::android.text.method.LinkMovementMethod._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override bool right(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, "right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", ref global::android.text.method.LinkMovementMethod._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.LinkMovementMethod._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.LinkMovementMethod._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", ref global::android.text.method.LinkMovementMethod._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override bool up(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, "up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", ref global::android.text.method.LinkMovementMethod._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override bool down(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, "down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", ref global::android.text.method.LinkMovementMethod._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.LinkMovementMethod.staticClass, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", ref global::android.text.method.LinkMovementMethod._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public LinkMovementMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._m10.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._m10 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._m10);
			Init(@__env, handle);
		}
		static LinkMovementMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.LinkMovementMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/LinkMovementMethod"));
		}
		internal static void InitJNI()
		{
		}
	}
}
