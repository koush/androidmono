namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnDismissListener_))]
	public interface DialogInterface_OnDismissListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onDismiss(android.content.DialogInterface arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnDismissListener))]
	public sealed partial class DialogInterface_OnDismissListener_ : java.lang.Object, DialogInterface_OnDismissListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_OnDismissListener_()
		{
			InitJNI();
		}
		internal DialogInterface_OnDismissListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onDismiss3061;
		 void android.content.DialogInterface_OnDismissListener.onDismiss(android.content.DialogInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnDismissListener_._onDismiss3061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnDismissListener_.staticClass, global::android.content.DialogInterface_OnDismissListener_._onDismiss3061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnDismissListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnDismissListener"));
			global::android.content.DialogInterface_OnDismissListener_._onDismiss3061 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnDismissListener_.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
		}
	}
}
