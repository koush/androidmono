namespace android.text.method
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.method.KeyListener_))]
	public interface KeyListener  : global::MonoJavaBridge.IJavaObject 
	{
		bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3);
		bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3);
		int getInputType();
		bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2);
		void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.KeyListener))]
	public sealed partial class KeyListener_ : java.lang.Object, KeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyListener_()
		{
			InitJNI();
		}
		internal KeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown8621;
		 bool android.text.method.KeyListener.onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.KeyListener_._onKeyDown8621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.KeyListener_.staticClass, global::android.text.method.KeyListener_._onKeyDown8621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp8622;
		 bool android.text.method.KeyListener.onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.KeyListener_._onKeyUp8622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.KeyListener_.staticClass, global::android.text.method.KeyListener_._onKeyUp8622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getInputType8623;
		 int android.text.method.KeyListener.getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.KeyListener_._getInputType8623);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.KeyListener_.staticClass, global::android.text.method.KeyListener_._getInputType8623);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyOther8624;
		 bool android.text.method.KeyListener.onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.KeyListener_._onKeyOther8624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.KeyListener_.staticClass, global::android.text.method.KeyListener_._onKeyOther8624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyState8625;
		 void android.text.method.KeyListener.clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.KeyListener_._clearMetaKeyState8625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.KeyListener_.staticClass, global::android.text.method.KeyListener_._clearMetaKeyState8625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.KeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/KeyListener"));
			global::android.text.method.KeyListener_._onKeyDown8621 = @__env.GetMethodIDNoThrow(global::android.text.method.KeyListener_.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.KeyListener_._onKeyUp8622 = @__env.GetMethodIDNoThrow(global::android.text.method.KeyListener_.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.KeyListener_._getInputType8623 = @__env.GetMethodIDNoThrow(global::android.text.method.KeyListener_.staticClass, "getInputType", "()I");
			global::android.text.method.KeyListener_._onKeyOther8624 = @__env.GetMethodIDNoThrow(global::android.text.method.KeyListener_.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.KeyListener_._clearMetaKeyState8625 = @__env.GetMethodIDNoThrow(global::android.text.method.KeyListener_.staticClass, "clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V");
		}
	}
}
