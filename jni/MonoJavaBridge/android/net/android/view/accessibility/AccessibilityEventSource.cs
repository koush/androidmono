namespace android.view.accessibility 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface AccessibilityEventSource 
	{ 
		void sendAccessibilityEvent(int arg0); 
		void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0); 
	} 

	public partial class AccessibilityEventSource_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __AccessibilityEventSource.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __AccessibilityEventSource : java.lang.Object, AccessibilityEventSource
	{ 
		internal static global::java.lang.Class staticClass; 
		static __AccessibilityEventSource() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.accessibility.__AccessibilityEventSource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.accessibility.__AccessibilityEventSource(@__env); 
			} 
		} 
		internal __AccessibilityEventSource(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEvent8829; 
		 void android.view.accessibility.AccessibilityEventSource.sendAccessibilityEvent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.__AccessibilityEventSource)) 
				@__env.CallVoidMethod(this, _sendAccessibilityEvent8829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.__AccessibilityEventSource.staticClass, _sendAccessibilityEvent8829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendAccessibilityEventUnchecked8830; 
		 void android.view.accessibility.AccessibilityEventSource.sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.accessibility.__AccessibilityEventSource)) 
				@__env.CallVoidMethod(this, _sendAccessibilityEventUnchecked8830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.accessibility.__AccessibilityEventSource.staticClass, _sendAccessibilityEventUnchecked8830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.accessibility.__AccessibilityEventSource.staticClass = @__class; 
			global::android.view.accessibility.__AccessibilityEventSource._sendAccessibilityEvent8829 = @__env.GetMethodID(global::android.view.accessibility.__AccessibilityEventSource.staticClass, "android.view.accessibility.AccessibilityEventSource.sendAccessibilityEvent", "(I)V"); 
			global::android.view.accessibility.__AccessibilityEventSource._sendAccessibilityEventUnchecked8830 = @__env.GetMethodID(global::android.view.accessibility.__AccessibilityEventSource.staticClass, "android.view.accessibility.AccessibilityEventSource.sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V"); 
		} 
	} 
} 
