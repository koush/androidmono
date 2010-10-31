namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnShowListener_))]
	public partial interface DialogInterface_OnShowListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onShow(android.content.DialogInterface arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnShowListener))]
	internal sealed partial class DialogInterface_OnShowListener_ : java.lang.Object, DialogInterface_OnShowListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DialogInterface_OnShowListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.content.DialogInterface_OnShowListener.onShow(android.content.DialogInterface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.DialogInterface_OnShowListener_.staticClass, "onShow", "(Landroid/content/DialogInterface;)V", ref global::android.content.DialogInterface_OnShowListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static DialogInterface_OnShowListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnShowListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface$OnShowListener"));
		}
	}

	public delegate void DialogInterface_OnShowListenerDelegate(android.content.DialogInterface arg0);

	internal partial class DialogInterface_OnShowListenerDelegateWrapper : java.lang.Object, DialogInterface_OnShowListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialogInterface_OnShowListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public DialogInterface_OnShowListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.DialogInterface_OnShowListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
				global::android.content.DialogInterface_OnShowListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnShowListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.DialogInterface_OnShowListenerDelegateWrapper.staticClass, global::android.content.DialogInterface_OnShowListenerDelegateWrapper._m0);
			Init(@__env, handle);
		}
		static DialogInterface_OnShowListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnShowListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnShowListenerDelegateWrapper"));
		}
	}
	internal partial class DialogInterface_OnShowListenerDelegateWrapper
	{
		private DialogInterface_OnShowListenerDelegate myDelegate;
		public void onShow(android.content.DialogInterface arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator DialogInterface_OnShowListenerDelegateWrapper(DialogInterface_OnShowListenerDelegate d)
		{
			global::android.content.DialogInterface_OnShowListenerDelegateWrapper ret = new global::android.content.DialogInterface_OnShowListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
