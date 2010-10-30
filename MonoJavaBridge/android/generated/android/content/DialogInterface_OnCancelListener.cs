namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnCancelListener_))]
	public partial interface DialogInterface_OnCancelListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onCancel(android.content.DialogInterface arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnCancelListener))]
	internal sealed partial class DialogInterface_OnCancelListener_ : java.lang.Object, DialogInterface_OnCancelListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DialogInterface_OnCancelListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.content.DialogInterface_OnCancelListener.onCancel(android.content.DialogInterface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.DialogInterface_OnCancelListener_.staticClass, "onCancel", "(Landroid/content/DialogInterface;)V", ref global::android.content.DialogInterface_OnCancelListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DialogInterface_OnCancelListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnCancelListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface$OnCancelListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void DialogInterface_OnCancelListenerDelegate(android.content.DialogInterface arg0);

	internal partial class DialogInterface_OnCancelListenerDelegateWrapper : java.lang.Object, DialogInterface_OnCancelListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialogInterface_OnCancelListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public DialogInterface_OnCancelListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.DialogInterface_OnCancelListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.content.DialogInterface_OnCancelListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnCancelListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.DialogInterface_OnCancelListenerDelegateWrapper.staticClass, global::android.content.DialogInterface_OnCancelListenerDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static DialogInterface_OnCancelListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnCancelListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnCancelListenerDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class DialogInterface_OnCancelListenerDelegateWrapper
	{
		private DialogInterface_OnCancelListenerDelegate myDelegate;
		public void onCancel(android.content.DialogInterface arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator DialogInterface_OnCancelListenerDelegateWrapper(DialogInterface_OnCancelListenerDelegate d)
		{
			global::android.content.DialogInterface_OnCancelListenerDelegateWrapper ret = new global::android.content.DialogInterface_OnCancelListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
