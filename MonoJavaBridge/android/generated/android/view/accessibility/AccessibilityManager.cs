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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityManager.staticClass, "interrupt", "()V", ref global::android.view.accessibility.AccessibilityManager._interrupt15559);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled15560;
		public bool isEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityManager.staticClass, "isEnabled", "()Z", ref global::android.view.accessibility.AccessibilityManager._isEnabled15560);
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEvent15561;
		public void sendAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityManager.staticClass, "sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", ref global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent15561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.view.accessibility.AccessibilityManager.staticClass, "getAccessibilityServiceList", "()Ljava/util/List;", ref global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList15562) as java.util.List;
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
