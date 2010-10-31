namespace android.view.accessibility
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.accessibility.AccessibilityEventSource_))]
	public partial interface AccessibilityEventSource  : global::MonoJavaBridge.IJavaObject 
	{
		void sendAccessibilityEvent(int arg0);
		void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.accessibility.AccessibilityEventSource))]
	internal sealed partial class AccessibilityEventSource_ : java.lang.Object, AccessibilityEventSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccessibilityEventSource_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.view.accessibility.AccessibilityEventSource.sendAccessibilityEvent(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEventSource_.staticClass, "sendAccessibilityEvent", "(I)V", ref global::android.view.accessibility.AccessibilityEventSource_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.view.accessibility.AccessibilityEventSource.sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.accessibility.AccessibilityEventSource_.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V", ref global::android.view.accessibility.AccessibilityEventSource_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AccessibilityEventSource_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.accessibility.AccessibilityEventSource_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/accessibility/AccessibilityEventSource"));
		}
	}
}
