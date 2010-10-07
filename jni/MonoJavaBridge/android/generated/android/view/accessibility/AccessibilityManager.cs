namespace android.view.accessibility
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class AccessibilityManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AccessibilityManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.accessibility.AccessibilityManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.accessibility.AccessibilityManager(@__env);
			}
		}
		internal AccessibilityManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _interrupt9537;
		public void interrupt() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityManager._interrupt9537);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._interrupt9537);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled9538;
		public bool isEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.accessibility.AccessibilityManager._isEnabled9538);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._isEnabled9538);
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEvent9539;
		public void sendAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent9539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent9539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAccessibilityServiceList9540;
		public global::java.util.List getAccessibilityServiceList() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList9540));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList9540));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.accessibility.AccessibilityManager.staticClass = @__class;
			global::android.view.accessibility.AccessibilityManager._interrupt9537 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityManager.staticClass, "interrupt", "()V");
			global::android.view.accessibility.AccessibilityManager._isEnabled9538 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityManager.staticClass, "isEnabled", "()Z");
			global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent9539 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityManager.staticClass, "sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList9540 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityManager.staticClass, "getAccessibilityServiceList", "()Ljava/util/List;");
		}
	}
}
