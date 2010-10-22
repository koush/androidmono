namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnCancelListener_))]
	public partial interface DialogInterface_OnCancelListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onCancel(android.content.DialogInterface arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnCancelListener))]
	public sealed partial class DialogInterface_OnCancelListener_ : java.lang.Object, DialogInterface_OnCancelListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_OnCancelListener_()
		{
			InitJNI();
		}
		internal DialogInterface_OnCancelListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCancel3059;
		 void android.content.DialogInterface_OnCancelListener.onCancel(android.content.DialogInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnCancelListener_._onCancel3059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnCancelListener_.staticClass, global::android.content.DialogInterface_OnCancelListener_._onCancel3059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnCancelListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnCancelListener"));
			global::android.content.DialogInterface_OnCancelListener_._onCancel3059 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnCancelListener_.staticClass, "onCancel", "(Landroid/content/DialogInterface;)V");
		}
	}
}
