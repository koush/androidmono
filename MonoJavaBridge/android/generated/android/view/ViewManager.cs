namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewManager_))]
	public partial interface ViewManager  : global::MonoJavaBridge.IJavaObject 
	{
		void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		void removeView(android.view.View arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewManager))]
	internal sealed partial class ViewManager_ : java.lang.Object, ViewManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ViewManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addView15185;
		void android.view.ViewManager.addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewManager_._addView15185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewManager_.staticClass, global::android.view.ViewManager_._addView15185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateViewLayout15186;
		void android.view.ViewManager.updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewManager_._updateViewLayout15186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewManager_.staticClass, global::android.view.ViewManager_._updateViewLayout15186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView15187;
		void android.view.ViewManager.removeView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewManager_._removeView15187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewManager_.staticClass, global::android.view.ViewManager_._removeView15187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ViewManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewManager"));
			global::android.view.ViewManager_._addView15185 = @__env.GetMethodIDNoThrow(global::android.view.ViewManager_.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewManager_._updateViewLayout15186 = @__env.GetMethodIDNoThrow(global::android.view.ViewManager_.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewManager_._removeView15187 = @__env.GetMethodIDNoThrow(global::android.view.ViewManager_.staticClass, "removeView", "(Landroid/view/View;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
