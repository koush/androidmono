namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnMultiChoiceClickListener_))]
	public partial interface DialogInterface_OnMultiChoiceClickListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onClick(android.content.DialogInterface arg0, int arg1, bool arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnMultiChoiceClickListener))]
	internal sealed partial class DialogInterface_OnMultiChoiceClickListener_ : java.lang.Object, DialogInterface_OnMultiChoiceClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DialogInterface_OnMultiChoiceClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick3075;
		void android.content.DialogInterface_OnMultiChoiceClickListener.onClick(android.content.DialogInterface arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.DialogInterface_OnMultiChoiceClickListener_.staticClass, "onClick", "(Landroid/content/DialogInterface;IZ)V", ref global::android.content.DialogInterface_OnMultiChoiceClickListener_._onClick3075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static DialogInterface_OnMultiChoiceClickListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnMultiChoiceClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface$OnMultiChoiceClickListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void DialogInterface_OnMultiChoiceClickListenerDelegate(android.content.DialogInterface arg0, int arg1, bool arg2);

	internal partial class DialogInterface_OnMultiChoiceClickListenerDelegateWrapper : java.lang.Object, DialogInterface_OnMultiChoiceClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DialogInterface_OnMultiChoiceClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DialogInterface_OnMultiChoiceClickListenerDelegateWrapper3076;
		public DialogInterface_OnMultiChoiceClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper._DialogInterface_OnMultiChoiceClickListenerDelegateWrapper3076.native == global::System.IntPtr.Zero)
				global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper._DialogInterface_OnMultiChoiceClickListenerDelegateWrapper3076 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper.staticClass, global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper._DialogInterface_OnMultiChoiceClickListenerDelegateWrapper3076);
			Init(@__env, handle);
		}
		static DialogInterface_OnMultiChoiceClickListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnMultiChoiceClickListenerDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class DialogInterface_OnMultiChoiceClickListenerDelegateWrapper
	{
		private DialogInterface_OnMultiChoiceClickListenerDelegate myDelegate;
		public void onClick(android.content.DialogInterface arg0, int arg1, bool arg2)
		{
			myDelegate(arg0, arg1, arg2);
		}
		public static implicit operator DialogInterface_OnMultiChoiceClickListenerDelegateWrapper(DialogInterface_OnMultiChoiceClickListenerDelegate d)
		{
			global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper ret = new global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
