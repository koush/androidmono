namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.DialogInterface_OnKeyListener_))]
	public partial interface DialogInterface_OnKeyListener  : global::MonoJavaBridge.IJavaObject 
	{
		bool onKey(android.content.DialogInterface arg0, int arg1, android.view.KeyEvent arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.DialogInterface_OnKeyListener))]
	internal sealed partial class DialogInterface_OnKeyListener_ : java.lang.Object, DialogInterface_OnKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_OnKeyListener_()
		{
			InitJNI();
		}
		internal DialogInterface_OnKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKey3073;
		 bool android.content.DialogInterface_OnKeyListener.onKey(android.content.DialogInterface arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.DialogInterface_OnKeyListener_._onKey3073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.DialogInterface_OnKeyListener_.staticClass, global::android.content.DialogInterface_OnKeyListener_._onKey3073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface$OnKeyListener"));
			global::android.content.DialogInterface_OnKeyListener_._onKey3073 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnKeyListener_.staticClass, "onKey", "(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z");
		}
	}

	public delegate bool DialogInterface_OnKeyListenerDelegate(android.content.DialogInterface arg0, int arg1, android.view.KeyEvent arg2);

	internal partial class DialogInterface_OnKeyListenerDelegateWrapper : java.lang.Object, DialogInterface_OnKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DialogInterface_OnKeyListenerDelegateWrapper()
		{
			InitJNI();
		}
		protected DialogInterface_OnKeyListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DialogInterface_OnKeyListenerDelegateWrapper3074;
		public DialogInterface_OnKeyListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.DialogInterface_OnKeyListenerDelegateWrapper.staticClass, global::android.content.DialogInterface_OnKeyListenerDelegateWrapper._DialogInterface_OnKeyListenerDelegateWrapper3074);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.DialogInterface_OnKeyListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/DialogInterface_OnKeyListenerDelegateWrapper"));
			global::android.content.DialogInterface_OnKeyListenerDelegateWrapper._DialogInterface_OnKeyListenerDelegateWrapper3074 = @__env.GetMethodIDNoThrow(global::android.content.DialogInterface_OnKeyListenerDelegateWrapper.staticClass, "<init>", "()V");
		}
	}
	internal partial class DialogInterface_OnKeyListenerDelegateWrapper
	{
		private DialogInterface_OnKeyListenerDelegate myDelegate;
		public bool onKey(android.content.DialogInterface arg0, int arg1, android.view.KeyEvent arg2)
		{
			return myDelegate(arg0, arg1, arg2);
		}
		public static implicit operator DialogInterface_OnKeyListenerDelegateWrapper(DialogInterface_OnKeyListenerDelegate d)
		{
			global::android.content.DialogInterface_OnKeyListenerDelegateWrapper ret = new global::android.content.DialogInterface_OnKeyListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
