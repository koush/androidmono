namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnClickListener_))]
	public partial interface DialogInterface_OnClickListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onClick(android.content.DialogInterface arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnClickListener))]
	internal sealed partial class DialogInterface_OnClickListener_ : java.lang.Object, DialogInterface_OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DialogInterface_OnClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick3069;
		void android.content.DialogInterface_OnClickListener.onClick(android.content.DialogInterface arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.DialogInterface_OnClickListener_.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V", ref global::android.content.DialogInterface_OnClickListener_._onClick3069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static DialogInterface_OnClickListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface$OnClickListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void DialogInterface_OnClickListenerDelegate(android.content.DialogInterface arg0, int arg1);

	internal partial class DialogInterface_OnClickListenerDelegateWrapper : java.lang.Object, DialogInterface_OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialogInterface_OnClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DialogInterface_OnClickListenerDelegateWrapper3070;
		public DialogInterface_OnClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.DialogInterface_OnClickListenerDelegateWrapper._DialogInterface_OnClickListenerDelegateWrapper3070.native == global::System.IntPtr.Zero)
				global::android.content.DialogInterface_OnClickListenerDelegateWrapper._DialogInterface_OnClickListenerDelegateWrapper3070 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnClickListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.DialogInterface_OnClickListenerDelegateWrapper.staticClass, global::android.content.DialogInterface_OnClickListenerDelegateWrapper._DialogInterface_OnClickListenerDelegateWrapper3070);
			Init(@__env, handle);
		}
		static DialogInterface_OnClickListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnClickListenerDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class DialogInterface_OnClickListenerDelegateWrapper
	{
		private DialogInterface_OnClickListenerDelegate myDelegate;
		public void onClick(android.content.DialogInterface arg0, int arg1)
		{
			myDelegate(arg0, arg1);
		}
		public static implicit operator DialogInterface_OnClickListenerDelegateWrapper(DialogInterface_OnClickListenerDelegate d)
		{
			global::android.content.DialogInterface_OnClickListenerDelegateWrapper ret = new global::android.content.DialogInterface_OnClickListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
