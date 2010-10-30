namespace android.text.method
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.method.KeyListener_))]
	public partial interface KeyListener  : global::MonoJavaBridge.IJavaObject 
	{
		bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3);
		bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3);
		int getInputType();
		bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2);
		void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.KeyListener))]
	internal sealed partial class KeyListener_ : java.lang.Object, KeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool android.text.method.KeyListener.onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.KeyListener_.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.KeyListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool android.text.method.KeyListener.onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.KeyListener_.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.KeyListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int android.text.method.KeyListener.getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.method.KeyListener_.staticClass, "getInputType", "()I", ref global::android.text.method.KeyListener_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool android.text.method.KeyListener.onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.KeyListener_.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z", ref global::android.text.method.KeyListener_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void android.text.method.KeyListener.clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.KeyListener_.staticClass, "clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V", ref global::android.text.method.KeyListener_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static KeyListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.KeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/KeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
