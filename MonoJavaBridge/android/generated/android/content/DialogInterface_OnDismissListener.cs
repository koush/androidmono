namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnDismissListener_))]
	public partial interface DialogInterface_OnDismissListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onDismiss(android.content.DialogInterface arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnDismissListener))]
	internal sealed partial class DialogInterface_OnDismissListener_ : java.lang.Object, DialogInterface_OnDismissListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DialogInterface_OnDismissListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onDismiss3071;
		void android.content.DialogInterface_OnDismissListener.onDismiss(android.content.DialogInterface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.DialogInterface_OnDismissListener_.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V", ref global::android.content.DialogInterface_OnDismissListener_._onDismiss3071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DialogInterface_OnDismissListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnDismissListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface$OnDismissListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void DialogInterface_OnDismissListenerDelegate(android.content.DialogInterface arg0);

	internal partial class DialogInterface_OnDismissListenerDelegateWrapper : java.lang.Object, DialogInterface_OnDismissListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialogInterface_OnDismissListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DialogInterface_OnDismissListenerDelegateWrapper3072;
		public DialogInterface_OnDismissListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.DialogInterface_OnDismissListenerDelegateWrapper._DialogInterface_OnDismissListenerDelegateWrapper3072.native == global::System.IntPtr.Zero)
				global::android.content.DialogInterface_OnDismissListenerDelegateWrapper._DialogInterface_OnDismissListenerDelegateWrapper3072 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnDismissListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.DialogInterface_OnDismissListenerDelegateWrapper.staticClass, global::android.content.DialogInterface_OnDismissListenerDelegateWrapper._DialogInterface_OnDismissListenerDelegateWrapper3072);
			Init(@__env, handle);
		}
		static DialogInterface_OnDismissListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnDismissListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnDismissListenerDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class DialogInterface_OnDismissListenerDelegateWrapper
	{
		private DialogInterface_OnDismissListenerDelegate myDelegate;
		public void onDismiss(android.content.DialogInterface arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator DialogInterface_OnDismissListenerDelegateWrapper(DialogInterface_OnDismissListenerDelegate d)
		{
			global::android.content.DialogInterface_OnDismissListenerDelegateWrapper ret = new global::android.content.DialogInterface_OnDismissListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
