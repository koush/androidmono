namespace android.view.accessibility
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.accessibility.AccessibilityEventSource_))]
	public interface AccessibilityEventSource  : global::MonoJavaBridge.IJavaObject 
	{
		void sendAccessibilityEvent(int arg0);
		void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.accessibility.AccessibilityEventSource))]
	public sealed partial class AccessibilityEventSource_ : java.lang.Object, AccessibilityEventSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessibilityEventSource_()
		{
			InitJNI();
		}
		internal AccessibilityEventSource_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEvent9882;
		 void android.view.accessibility.AccessibilityEventSource.sendAccessibilityEvent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEventSource_._sendAccessibilityEvent9882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEventSource_.staticClass, global::android.view.accessibility.AccessibilityEventSource_._sendAccessibilityEvent9882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEventUnchecked9883;
		 void android.view.accessibility.AccessibilityEventSource.sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEventSource_._sendAccessibilityEventUnchecked9883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityEventSource_.staticClass, global::android.view.accessibility.AccessibilityEventSource_._sendAccessibilityEventUnchecked9883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.accessibility.AccessibilityEventSource_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/accessibility/AccessibilityEventSource"));
			global::android.view.accessibility.AccessibilityEventSource_._sendAccessibilityEvent9882 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEventSource_.staticClass, "sendAccessibilityEvent", "(I)V");
			global::android.view.accessibility.AccessibilityEventSource_._sendAccessibilityEventUnchecked9883 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityEventSource_.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V");
		}
	}
}
