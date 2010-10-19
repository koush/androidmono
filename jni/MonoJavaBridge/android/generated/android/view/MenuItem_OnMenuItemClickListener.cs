namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.MenuItem_OnMenuItemClickListener_))]
	public interface MenuItem_OnMenuItemClickListener  : global::MonoJavaBridge.IJavaObject 
	{
		bool onMenuItemClick(android.view.MenuItem arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.MenuItem_OnMenuItemClickListener))]
	public sealed partial class MenuItem_OnMenuItemClickListener_ : java.lang.Object, MenuItem_OnMenuItemClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MenuItem_OnMenuItemClickListener_()
		{
			InitJNI();
		}
		internal MenuItem_OnMenuItemClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onMenuItemClick9432;
		 bool android.view.MenuItem_OnMenuItemClickListener.onMenuItemClick(android.view.MenuItem arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.MenuItem_OnMenuItemClickListener_._onMenuItemClick9432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.MenuItem_OnMenuItemClickListener_.staticClass, global::android.view.MenuItem_OnMenuItemClickListener_._onMenuItemClick9432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuItem_OnMenuItemClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuItem_OnMenuItemClickListener"));
			global::android.view.MenuItem_OnMenuItemClickListener_._onMenuItemClick9432 = @__env.GetMethodIDNoThrow(global::android.view.MenuItem_OnMenuItemClickListener_.staticClass, "onMenuItemClick", "(Landroid/view/MenuItem;)Z");
		}
	}
}
