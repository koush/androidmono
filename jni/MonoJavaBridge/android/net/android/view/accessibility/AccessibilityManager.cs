namespace android.view.accessibility 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class AccessibilityManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AccessibilityManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.accessibility.AccessibilityManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _interrupt8192; 
		public void interrupt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityManager)) 
				@__env.CallVoidMethod(this, _interrupt8192); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityManager.staticClass, _interrupt8192); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled8193; 
		public bool isEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityManager)) 
				return @__env.CallBooleanMethod(this, _isEnabled8193); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.accessibility.AccessibilityManager.staticClass, _isEnabled8193); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEvent8194; 
		public void sendAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityManager)) 
				@__env.CallVoidMethod(this, _sendAccessibilityEvent8194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.AccessibilityManager.staticClass, _sendAccessibilityEvent8194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAccessibilityServiceList8195; 
		public java.util.List getAccessibilityServiceList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.AccessibilityManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getAccessibilityServiceList8195)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.accessibility.AccessibilityManager.staticClass, _getAccessibilityServiceList8195)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.accessibility.AccessibilityManager.staticClass = @__class; 
			global::android.view.accessibility.AccessibilityManager._interrupt8192 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityManager.staticClass, "interrupt", "()V"); 
			global::android.view.accessibility.AccessibilityManager._isEnabled8193 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityManager.staticClass, "isEnabled", "()Z"); 
			global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent8194 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityManager.staticClass, "sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V"); 
			global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList8195 = @__env.GetMethodID(global::android.view.accessibility.AccessibilityManager.staticClass, "getAccessibilityServiceList", "()Ljava/util/List;"); 
		} 
	} 
} 
