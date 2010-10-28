namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.MenuItem_OnMenuItemClickListener_))]
	public partial interface MenuItem_OnMenuItemClickListener  : global::MonoJavaBridge.IJavaObject 
	{
		bool onMenuItemClick(android.view.MenuItem arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.MenuItem_OnMenuItemClickListener))]
	internal sealed partial class MenuItem_OnMenuItemClickListener_ : java.lang.Object, MenuItem_OnMenuItemClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MenuItem_OnMenuItemClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onMenuItemClick14346;
		bool android.view.MenuItem_OnMenuItemClickListener.onMenuItemClick(android.view.MenuItem arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_OnMenuItemClickListener_._onMenuItemClick14346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_OnMenuItemClickListener_.staticClass, global::android.view.MenuItem_OnMenuItemClickListener_._onMenuItemClick14346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static MenuItem_OnMenuItemClickListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuItem_OnMenuItemClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuItem$OnMenuItemClickListener"));
			global::android.view.MenuItem_OnMenuItemClickListener_._onMenuItemClick14346 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_OnMenuItemClickListener_.staticClass, "onMenuItemClick", "(Landroid/view/MenuItem;)Z");
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate bool MenuItem_OnMenuItemClickListenerDelegate(android.view.MenuItem arg0);

	internal partial class MenuItem_OnMenuItemClickListenerDelegateWrapper : java.lang.Object, MenuItem_OnMenuItemClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MenuItem_OnMenuItemClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _MenuItem_OnMenuItemClickListenerDelegateWrapper14347;
		public MenuItem_OnMenuItemClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.MenuItem_OnMenuItemClickListenerDelegateWrapper.staticClass, global::android.view.MenuItem_OnMenuItemClickListenerDelegateWrapper._MenuItem_OnMenuItemClickListenerDelegateWrapper14347);
			Init(@__env, handle);
		}
		static MenuItem_OnMenuItemClickListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuItem_OnMenuItemClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuItem_OnMenuItemClickListenerDelegateWrapper"));
			global::android.view.MenuItem_OnMenuItemClickListenerDelegateWrapper._MenuItem_OnMenuItemClickListenerDelegateWrapper14347 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_OnMenuItemClickListenerDelegateWrapper.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class MenuItem_OnMenuItemClickListenerDelegateWrapper
	{
		private MenuItem_OnMenuItemClickListenerDelegate myDelegate;
		public bool onMenuItemClick(android.view.MenuItem arg0)
		{
			return myDelegate(arg0);
		}
		public static implicit operator MenuItem_OnMenuItemClickListenerDelegateWrapper(MenuItem_OnMenuItemClickListenerDelegate d)
		{
			global::android.view.MenuItem_OnMenuItemClickListenerDelegateWrapper ret = new global::android.view.MenuItem_OnMenuItemClickListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
