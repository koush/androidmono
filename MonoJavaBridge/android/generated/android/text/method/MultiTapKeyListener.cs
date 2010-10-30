namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MultiTapKeyListener : android.text.method.BaseKeyListener, SpanWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MultiTapKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13343;
		public static global::android.text.method.MultiTapKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MultiTapKeyListener._getInstance13343.native == global::System.IntPtr.Zero)
				global::android.text.method.MultiTapKeyListener._getInstance13343 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MultiTapKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/MultiTapKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._getInstance13343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.method.MultiTapKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown13344;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MultiTapKeyListener._onKeyDown13344.native == global::System.IntPtr.Zero)
				global::android.text.method.MultiTapKeyListener._onKeyDown13344 = @__env.GetMethodIDNoThrow(global::android.text.method.MultiTapKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._onKeyDown13344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType13345;
		public override int getInputType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MultiTapKeyListener._getInputType13345.native == global::System.IntPtr.Zero)
				global::android.text.method.MultiTapKeyListener._getInputType13345 = @__env.GetMethodIDNoThrow(global::android.text.method.MultiTapKeyListener.staticClass, "getInputType", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._getInputType13345);
		}
		internal static global::MonoJavaBridge.MethodId _onSpanAdded13346;
		public virtual void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MultiTapKeyListener._onSpanAdded13346.native == global::System.IntPtr.Zero)
				global::android.text.method.MultiTapKeyListener._onSpanAdded13346 = @__env.GetMethodIDNoThrow(global::android.text.method.MultiTapKeyListener.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._onSpanAdded13346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanRemoved13347;
		public virtual void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MultiTapKeyListener._onSpanRemoved13347.native == global::System.IntPtr.Zero)
				global::android.text.method.MultiTapKeyListener._onSpanRemoved13347 = @__env.GetMethodIDNoThrow(global::android.text.method.MultiTapKeyListener.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._onSpanRemoved13347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanChanged13348;
		public virtual void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MultiTapKeyListener._onSpanChanged13348.native == global::System.IntPtr.Zero)
				global::android.text.method.MultiTapKeyListener._onSpanChanged13348 = @__env.GetMethodIDNoThrow(global::android.text.method.MultiTapKeyListener.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._onSpanChanged13348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _MultiTapKeyListener13349;
		public MultiTapKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MultiTapKeyListener._MultiTapKeyListener13349.native == global::System.IntPtr.Zero)
				global::android.text.method.MultiTapKeyListener._MultiTapKeyListener13349 = @__env.GetMethodIDNoThrow(global::android.text.method.MultiTapKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.MultiTapKeyListener.staticClass, global::android.text.method.MultiTapKeyListener._MultiTapKeyListener13349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MultiTapKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.MultiTapKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/MultiTapKeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
