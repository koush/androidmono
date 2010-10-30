namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScrollingMovementMethod : java.lang.Object, MovementMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScrollingMovementMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			if (global::android.text.method.ScrollingMovementMethod._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.ScrollingMovementMethod._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "getInstance", "()Landroid/text/method/MovementMethod;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallStaticObjectMethod(android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._m0)) as android.text.method.MovementMethod;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void initialize(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", ref global::android.text.method.ScrollingMovementMethod._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual bool left(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", ref global::android.text.method.ScrollingMovementMethod._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual bool right(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", ref global::android.text.method.ScrollingMovementMethod._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.ScrollingMovementMethod._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.ScrollingMovementMethod._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", ref global::android.text.method.ScrollingMovementMethod._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool onTrackballEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", ref global::android.text.method.ScrollingMovementMethod._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual bool up(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", ref global::android.text.method.ScrollingMovementMethod._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual bool down(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", ref global::android.text.method.ScrollingMovementMethod._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool onKeyOther(android.widget.TextView arg0, android.text.Spannable arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", ref global::android.text.method.ScrollingMovementMethod._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", ref global::android.text.method.ScrollingMovementMethod._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool canSelectArbitrarily()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.ScrollingMovementMethod.staticClass, "canSelectArbitrarily", "()Z", ref global::android.text.method.ScrollingMovementMethod._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public ScrollingMovementMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.ScrollingMovementMethod._m13.native == global::System.IntPtr.Zero)
				global::android.text.method.ScrollingMovementMethod._m13 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._m13);
			Init(@__env, handle);
		}
		static ScrollingMovementMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.ScrollingMovementMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/ScrollingMovementMethod"));
		}
		internal static void InitJNI()
		{
		}
	}
}
