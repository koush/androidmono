namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnKeyListener_))]
	public interface DialogInterface_OnKeyListener  : global::MonoJavaBridge.IJavaObject 
	{
		bool onKey(android.content.DialogInterface arg0, int arg1, android.view.KeyEvent arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnKeyListener))]
	public sealed partial class DialogInterface_OnKeyListener_ : java.lang.Object, DialogInterface_OnKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_OnKeyListener_()
		{
			InitJNI();
		}
		internal DialogInterface_OnKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKey1512;
		 bool android.content.DialogInterface_OnKeyListener.onKey(android.content.DialogInterface arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.DialogInterface_OnKeyListener_._onKey1512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.DialogInterface_OnKeyListener_.staticClass, global::android.content.DialogInterface_OnKeyListener_._onKey1512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnKeyListener"));
			global::android.content.DialogInterface_OnKeyListener_._onKey1512 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnKeyListener_.staticClass, "onKey", "(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z");
		}
	}
}
