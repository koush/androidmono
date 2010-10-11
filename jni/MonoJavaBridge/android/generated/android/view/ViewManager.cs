namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewManager_))]
	public interface ViewManager  : global::MonoJavaBridge.IJavaObject 
	{
		void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		void removeView(android.view.View arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewManager))]
	public sealed partial class ViewManager_ : java.lang.Object, ViewManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewManager_()
		{
			InitJNI();
		}
		internal ViewManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addView9625;
		 void android.view.ViewManager.addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewManager_._addView9625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewManager_.staticClass, global::android.view.ViewManager_._addView9625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateViewLayout9626;
		 void android.view.ViewManager.updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewManager_._updateViewLayout9626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewManager_.staticClass, global::android.view.ViewManager_._updateViewLayout9626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView9627;
		 void android.view.ViewManager.removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewManager_._removeView9627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewManager_.staticClass, global::android.view.ViewManager_._removeView9627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewManager"));
			global::android.view.ViewManager_._addView9625 = @__env.GetMethodIDNoThrow(global::android.view.ViewManager_.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewManager_._updateViewLayout9626 = @__env.GetMethodIDNoThrow(global::android.view.ViewManager_.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewManager_._removeView9627 = @__env.GetMethodIDNoThrow(global::android.view.ViewManager_.staticClass, "removeView", "(Landroid/view/View;)V");
		}
	}
}
