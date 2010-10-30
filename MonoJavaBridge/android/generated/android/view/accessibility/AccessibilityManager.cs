namespace android.view.accessibility
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessibilityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccessibilityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _interrupt15559;
		public void interrupt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.accessibility.AccessibilityManager._interrupt15559.native == global::System.IntPtr.Zero)
				global::android.view.accessibility.AccessibilityManager._interrupt15559 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "interrupt", "()V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._interrupt15559);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled15560;
		public bool isEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.accessibility.AccessibilityManager._isEnabled15560.native == global::System.IntPtr.Zero)
				global::android.view.accessibility.AccessibilityManager._isEnabled15560 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "isEnabled", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._isEnabled15560);
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEvent15561;
		public void sendAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent15561.native == global::System.IntPtr.Zero)
				global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent15561 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent15561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List AccessibilityServiceList
		{
			get
			{
				return getAccessibilityServiceList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAccessibilityServiceList15562;
		public global::java.util.List getAccessibilityServiceList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList15562.native == global::System.IntPtr.Zero)
				global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList15562 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "getAccessibilityServiceList", "()Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList15562)) as java.util.List;
		}
		static AccessibilityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.accessibility.AccessibilityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/accessibility/AccessibilityManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
