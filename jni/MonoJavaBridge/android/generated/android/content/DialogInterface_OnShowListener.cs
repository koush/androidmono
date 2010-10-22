namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnShowListener_))]
	public partial interface DialogInterface_OnShowListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onShow(android.content.DialogInterface arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnShowListener))]
	public sealed partial class DialogInterface_OnShowListener_ : java.lang.Object, DialogInterface_OnShowListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_OnShowListener_()
		{
			InitJNI();
		}
		internal DialogInterface_OnShowListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onShow3064;
		 void android.content.DialogInterface_OnShowListener.onShow(android.content.DialogInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnShowListener_._onShow3064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnShowListener_.staticClass, global::android.content.DialogInterface_OnShowListener_._onShow3064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnShowListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnShowListener"));
			global::android.content.DialogInterface_OnShowListener_._onShow3064 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnShowListener_.staticClass, "onShow", "(Landroid/content/DialogInterface;)V");
		}
	}
}
