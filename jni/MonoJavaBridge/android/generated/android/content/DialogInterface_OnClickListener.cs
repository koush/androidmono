namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnClickListener_))]
	public partial interface DialogInterface_OnClickListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onClick(android.content.DialogInterface arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnClickListener))]
	public sealed partial class DialogInterface_OnClickListener_ : java.lang.Object, DialogInterface_OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_OnClickListener_()
		{
			InitJNI();
		}
		internal DialogInterface_OnClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick3060;
		 void android.content.DialogInterface_OnClickListener.onClick(android.content.DialogInterface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnClickListener_._onClick3060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnClickListener_.staticClass, global::android.content.DialogInterface_OnClickListener_._onClick3060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnClickListener"));
			global::android.content.DialogInterface_OnClickListener_._onClick3060 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnClickListener_.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
		}
	}
}
