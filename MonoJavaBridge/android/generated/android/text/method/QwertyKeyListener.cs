namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class QwertyKeyListener : android.text.method.BaseKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected QwertyKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.method.QwertyKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.QwertyKeyListener._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.QwertyKeyListener._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.QwertyKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/QwertyKeyListener;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.method.QwertyKeyListener;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.QwertyKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.QwertyKeyListener._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.QwertyKeyListener.staticClass, "getInputType", "()I", ref global::android.text.method.QwertyKeyListener._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void markAsReplaced(android.text.Spannable arg0, int arg1, int arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.QwertyKeyListener._m3.native == global::System.IntPtr.Zero)
				global::android.text.method.QwertyKeyListener._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.QwertyKeyListener.staticClass, "markAsReplaced", "(Landroid/text/Spannable;IILjava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public QwertyKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.QwertyKeyListener._m4.native == global::System.IntPtr.Zero)
				global::android.text.method.QwertyKeyListener._m4 = @__env.GetMethodIDNoThrow(global::android.text.method.QwertyKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.QwertyKeyListener.staticClass, global::android.text.method.QwertyKeyListener._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static QwertyKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.QwertyKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/QwertyKeyListener"));
		}
	}
}
