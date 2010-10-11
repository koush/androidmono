namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_))]
	public interface DialogInterface  : global::MonoJavaBridge.IJavaObject 
	{
		void cancel();
		void dismiss();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface))]
	public sealed partial class DialogInterface_ : java.lang.Object, DialogInterface
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_()
		{
			InitJNI();
		}
		internal DialogInterface_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel1515;
		 void android.content.DialogInterface.cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.DialogInterface_._cancel1515);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.DialogInterface_.staticClass, global::android.content.DialogInterface_._cancel1515);
		}
		internal static global::MonoJavaBridge.MethodId _dismiss1516;
		 void android.content.DialogInterface.dismiss() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.DialogInterface_._dismiss1516);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.DialogInterface_.staticClass, global::android.content.DialogInterface_._dismiss1516);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface"));
			global::android.content.DialogInterface_._cancel1515 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_.staticClass, "cancel", "()V");
			global::android.content.DialogInterface_._dismiss1516 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_.staticClass, "dismiss", "()V");
		}
	}
}
