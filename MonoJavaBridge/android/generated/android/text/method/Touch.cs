namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Touch : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Touch(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.Touch._m0.native == global::System.IntPtr.Zero)
				global::android.text.method.Touch._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.Touch.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			return @__env.CallStaticBooleanMethod(android.text.method.Touch.staticClass, global::android.text.method.Touch._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void scrollTo(android.widget.TextView arg0, android.text.Layout arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.Touch._m1.native == global::System.IntPtr.Zero)
				global::android.text.method.Touch._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.Touch.staticClass, "scrollTo", "(Landroid/widget/TextView;Landroid/text/Layout;II)V");
			@__env.CallStaticVoidMethod(android.text.method.Touch.staticClass, global::android.text.method.Touch._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int getInitialScrollX(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.Touch._m2.native == global::System.IntPtr.Zero)
				global::android.text.method.Touch._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.Touch.staticClass, "getInitialScrollX", "(Landroid/widget/TextView;Landroid/text/Spannable;)I");
			return @__env.CallStaticIntMethod(android.text.method.Touch.staticClass, global::android.text.method.Touch._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int getInitialScrollY(android.widget.TextView arg0, android.text.Spannable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.Touch._m3.native == global::System.IntPtr.Zero)
				global::android.text.method.Touch._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.Touch.staticClass, "getInitialScrollY", "(Landroid/widget/TextView;Landroid/text/Spannable;)I");
			return @__env.CallStaticIntMethod(android.text.method.Touch.staticClass, global::android.text.method.Touch._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Touch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.Touch.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/Touch"));
		}
	}
}
