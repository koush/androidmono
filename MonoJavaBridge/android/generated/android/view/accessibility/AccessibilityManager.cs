namespace android.view.accessibility
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessibilityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccessibilityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public void interrupt()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityManager.staticClass, "interrupt", "()V", ref global::android.view.accessibility.AccessibilityManager._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public bool isEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityManager.staticClass, "isEnabled", "()Z", ref global::android.view.accessibility.AccessibilityManager._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void sendAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityManager.staticClass, "sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", ref global::android.view.accessibility.AccessibilityManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List AccessibilityServiceList
		{
			get
			{
				return getAccessibilityServiceList();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.util.List getAccessibilityServiceList()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.view.accessibility.AccessibilityManager.staticClass, "getAccessibilityServiceList", "()Ljava/util/List;", ref global::android.view.accessibility.AccessibilityManager._m3) as java.util.List;
		}
		static AccessibilityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.accessibility.AccessibilityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/accessibility/AccessibilityManager"));
		}
	}
}
