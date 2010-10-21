namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnMultiChoiceClickListener_))]
	public interface DialogInterface_OnMultiChoiceClickListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onClick(android.content.DialogInterface arg0, int arg1, bool arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnMultiChoiceClickListener))]
	public sealed partial class DialogInterface_OnMultiChoiceClickListener_ : java.lang.Object, DialogInterface_OnMultiChoiceClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_OnMultiChoiceClickListener_()
		{
			InitJNI();
		}
		internal DialogInterface_OnMultiChoiceClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick3063;
		 void android.content.DialogInterface_OnMultiChoiceClickListener.onClick(android.content.DialogInterface arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnMultiChoiceClickListener_._onClick3063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnMultiChoiceClickListener_.staticClass, global::android.content.DialogInterface_OnMultiChoiceClickListener_._onClick3063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnMultiChoiceClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnMultiChoiceClickListener"));
			global::android.content.DialogInterface_OnMultiChoiceClickListener_._onClick3063 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnMultiChoiceClickListener_.staticClass, "onClick", "(Landroid/content/DialogInterface;IZ)V");
		}
	}
}
