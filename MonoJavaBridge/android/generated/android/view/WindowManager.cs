namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.WindowManager_))]
	public partial interface WindowManager : ViewManager
	{
		global::android.view.Display getDefaultDisplay();
		void removeViewImmediate(android.view.View arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.WindowManager))]
	internal sealed partial class WindowManager_ : java.lang.Object, WindowManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal WindowManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultDisplay15501;
		global::android.view.Display android.view.WindowManager.getDefaultDisplay()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.WindowManager_.staticClass, "getDefaultDisplay", "()Landroid/view/Display;", ref global::android.view.WindowManager_._getDefaultDisplay15501) as android.view.Display;
		}
		internal static global::MonoJavaBridge.MethodId _removeViewImmediate15502;
		void android.view.WindowManager.removeViewImmediate(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.WindowManager_.staticClass, "removeViewImmediate", "(Landroid/view/View;)V", ref global::android.view.WindowManager_._removeViewImmediate15502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView15503;
		void android.view.ViewManager.addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.WindowManager_.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.WindowManager_._addView15503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateViewLayout15504;
		void android.view.ViewManager.updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.WindowManager_.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.WindowManager_._updateViewLayout15504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView15505;
		void android.view.ViewManager.removeView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.WindowManager_.staticClass, "removeView", "(Landroid/view/View;)V", ref global::android.view.WindowManager_._removeView15505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static WindowManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.WindowManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/WindowManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
