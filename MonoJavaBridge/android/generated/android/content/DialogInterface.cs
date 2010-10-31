namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_))]
	public partial interface DialogInterface  : global::MonoJavaBridge.IJavaObject 
	{
		void cancel();
		void dismiss();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface))]
	internal sealed partial class DialogInterface_ : java.lang.Object, DialogInterface
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DialogInterface_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.content.DialogInterface.cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.DialogInterface_.staticClass, "cancel", "()V", ref global::android.content.DialogInterface_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.content.DialogInterface.dismiss()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.DialogInterface_.staticClass, "dismiss", "()V", ref global::android.content.DialogInterface_._m1);
		}
		static DialogInterface_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface"));
		}
	}
}
