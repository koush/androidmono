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
		static DialogInterface_OnCancelListener_()
		{
			InitJNI();
		}
		internal DialogInterface_OnCancelListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCancel3067;
		 void android.content.DialogInterface_OnCancelListener.onCancel(android.content.DialogInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnCancelListener_._onCancel3067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.DialogInterface_OnCancelListener_.staticClass, global::android.content.DialogInterface_OnCancelListener_._onCancel3067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnCancelListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface$OnCancelListener"));
			global::android.content.DialogInterface_OnCancelListener_._onCancel3067 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnCancelListener_.staticClass, "onCancel", "(Landroid/content/DialogInterface;)V");
		}
	}

	public delegate void DialogInterface_OnCancelListenerDelegate(android.content.DialogInterface arg0);

	internal partial class DialogInterface_OnCancelListenerDelegateWrapper : java.lang.Object, DialogInterface_OnCancelListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_OnCancelListenerDelegateWrapper()
		{
			InitJNI();
		}
		protected DialogInterface_OnCancelListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DialogInterface_OnCancelListenerDelegateWrapper3068;
		public DialogInterface_OnCancelListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.DialogInterface_OnCancelListenerDelegateWrapper.staticClass, global::android.content.DialogInterface_OnCancelListenerDelegateWrapper._DialogInterface_OnCancelListenerDelegateWrapper3068);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnCancelListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnCancelListenerDelegateWrapper"));
			global::android.content.DialogInterface_OnCancelListenerDelegateWrapper._DialogInterface_OnCancelListenerDelegateWrapper3068 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnCancelListenerDelegateWrapper.staticClass, "<init>", "()V");
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
