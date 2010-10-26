namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrowKeyMovementMethod : java.lang.Object, MovementMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ArrowKeyMovementMethod()
		{
			InitJNI();
		}
		protected ArrowKeyMovementMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.MovementMethod Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13246;
		public static global::android.text.method.MovementMethod getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallStaticObjectMethod(android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._getInstance13246)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _initialize13247;
		public virtual void initialize(android.widget.TextView arg0, android.text.Spannable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod._initialize13247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._initialize13247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown13248;
		public virtual bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod._onKeyDown13248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._onKeyDown13248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp13249;
		public virtual bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod._onKeyUp13249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._onKeyUp13249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent13250;
		public virtual bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod._onTouchEvent13250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._onTouchEvent13250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent13251;
		public virtual bool onTrackballEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod._onTrackballEvent13251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._onTrackballEvent13251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyOther13252;
		public virtual bool onKeyOther(android.widget.TextView arg0, android.text.Spannable arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod._onKeyOther13252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._onKeyOther13252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTakeFocus13253;
		public virtual void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod._onTakeFocus13253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._onTakeFocus13253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canSelectArbitrarily13254;
		public virtual bool canSelectArbitrarily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod._canSelectArbitrarily13254);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._canSelectArbitrarily13254);
		}
		internal static global::MonoJavaBridge.MethodId _ArrowKeyMovementMethod13255;
		public ArrowKeyMovementMethod()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.ArrowKeyMovementMethod.staticClass, global::android.text.method.ArrowKeyMovementMethod._ArrowKeyMovementMethod13255);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.ArrowKeyMovementMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/ArrowKeyMovementMethod"));
			global::android.text.method.ArrowKeyMovementMethod._getInstance13246 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "getInstance", "()Landroid/text/method/MovementMethod;");
			global::android.text.method.ArrowKeyMovementMethod._initialize13247 = @__env.GetMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V");
			global::android.text.method.ArrowKeyMovementMethod._onKeyDown13248 = @__env.GetMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.ArrowKeyMovementMethod._onKeyUp13249 = @__env.GetMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.ArrowKeyMovementMethod._onTouchEvent13250 = @__env.GetMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			global::android.text.method.ArrowKeyMovementMethod._onTrackballEvent13251 = @__env.GetMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			global::android.text.method.ArrowKeyMovementMethod._onKeyOther13252 = @__env.GetMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.ArrowKeyMovementMethod._onTakeFocus13253 = @__env.GetMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V");
			global::android.text.method.ArrowKeyMovementMethod._canSelectArbitrarily13254 = @__env.GetMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "canSelectArbitrarily", "()Z");
			global::android.text.method.ArrowKeyMovementMethod._ArrowKeyMovementMethod13255 = @__env.GetMethodIDNoThrow(global::android.text.method.ArrowKeyMovementMethod.staticClass, "<init>", "()V");
		}
	}
}
