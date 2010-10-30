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
		internal static global::MonoJavaBridge.MethodId _getInstance13299;
		public static global::android.text.method.MovementMethod getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._getInstance13299.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._getInstance13299 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "getInstance", "()Landroid/text/method/MovementMethod;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallStaticObjectMethod(android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._getInstance13299)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _initialize13300;
		public override void initialize(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._initialize13300.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._initialize13300 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._initialize13300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _left13301;
		protected override bool left(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._left13301.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._left13301 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._left13301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _right13302;
		protected override bool right(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._right13302.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._right13302 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._right13302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown13303;
		public override bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._onKeyDown13303.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._onKeyDown13303 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._onKeyDown13303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp13304;
		public override bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._onKeyUp13304.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._onKeyUp13304 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._onKeyUp13304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent13305;
		public override bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._onTouchEvent13305.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._onTouchEvent13305 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._onTouchEvent13305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _up13306;
		protected override bool up(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._up13306.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._up13306 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._up13306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _down13307;
		protected override bool down(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._down13307.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._down13307 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._down13307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTakeFocus13308;
		public override void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._onTakeFocus13308.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._onTakeFocus13308 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._onTakeFocus13308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _LinkMovementMethod13309;
		public LinkMovementMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.LinkMovementMethod._LinkMovementMethod13309.native == global::System.IntPtr.Zero)
				global::android.text.method.LinkMovementMethod._LinkMovementMethod13309 = @__env.GetMethodIDNoThrow(global::android.text.method.LinkMovementMethod.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.LinkMovementMethod.staticClass, global::android.text.method.LinkMovementMethod._LinkMovementMethod13309);
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
