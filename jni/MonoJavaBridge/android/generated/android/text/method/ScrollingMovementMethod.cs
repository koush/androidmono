namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScrollingMovementMethod : java.lang.Object, MovementMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScrollingMovementMethod()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getInstance13377;
		public static global::android.text.method.MovementMethod getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallStaticObjectMethod(android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._getInstance13377)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _initialize13378;
		public virtual void initialize(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._initialize13378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._initialize13378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _left13379;
		protected virtual bool left(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._left13379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._left13379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _right13380;
		protected virtual bool right(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._right13380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._right13380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown13381;
		public virtual bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._onKeyDown13381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._onKeyDown13381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp13382;
		public virtual bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._onKeyUp13382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._onKeyUp13382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent13383;
		public virtual bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._onTouchEvent13383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._onTouchEvent13383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent13384;
		public virtual bool onTrackballEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._onTrackballEvent13384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._onTrackballEvent13384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _up13385;
		protected virtual bool up(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._up13385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._up13385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _down13386;
		protected virtual bool down(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._down13386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._down13386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyOther13387;
		public virtual bool onKeyOther(android.widget.TextView arg0, android.text.Spannable arg1, android.view.KeyEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._onKeyOther13387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._onKeyOther13387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTakeFocus13388;
		public virtual void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._onTakeFocus13388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._onTakeFocus13388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canSelectArbitrarily13389;
		public virtual bool canSelectArbitrarily()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod._canSelectArbitrarily13389);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._canSelectArbitrarily13389);
		}
		internal static global::MonoJavaBridge.MethodId _ScrollingMovementMethod13390;
		public ScrollingMovementMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.ScrollingMovementMethod.staticClass, global::android.text.method.ScrollingMovementMethod._ScrollingMovementMethod13390);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.ScrollingMovementMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/ScrollingMovementMethod"));
			global::android.text.method.ScrollingMovementMethod._getInstance13377 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "getInstance", "()Landroid/text/method/MovementMethod;");
			global::android.text.method.ScrollingMovementMethod._initialize13378 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V");
			global::android.text.method.ScrollingMovementMethod._left13379 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			global::android.text.method.ScrollingMovementMethod._right13380 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			global::android.text.method.ScrollingMovementMethod._onKeyDown13381 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.ScrollingMovementMethod._onKeyUp13382 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.ScrollingMovementMethod._onTouchEvent13383 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			global::android.text.method.ScrollingMovementMethod._onTrackballEvent13384 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			global::android.text.method.ScrollingMovementMethod._up13385 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			global::android.text.method.ScrollingMovementMethod._down13386 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z");
			global::android.text.method.ScrollingMovementMethod._onKeyOther13387 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.ScrollingMovementMethod._onTakeFocus13388 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V");
			global::android.text.method.ScrollingMovementMethod._canSelectArbitrarily13389 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "canSelectArbitrarily", "()Z");
			global::android.text.method.ScrollingMovementMethod._ScrollingMovementMethod13390 = @__env.GetMethodIDNoThrow(global::android.text.method.ScrollingMovementMethod.staticClass, "<init>", "()V");
		}
	}
}
