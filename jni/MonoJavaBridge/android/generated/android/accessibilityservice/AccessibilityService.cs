namespace android.accessibilityservice
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AccessibilityService : android.app.Service
	{
		internal new static global::java.lang.Class staticClass;
		static AccessibilityService()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.accessibilityservice.AccessibilityService), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AccessibilityService(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAccessibilityEvent19;
		public abstract void onAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _onInterrupt20;
		public abstract void onInterrupt();
		internal static global::net.sf.jni4net.jni.MethodId _onServiceConnected21;
		protected virtual void onServiceConnected() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accessibilityservice.AccessibilityService._onServiceConnected21);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._onServiceConnected21);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setServiceInfo22;
		public virtual void setServiceInfo(android.accessibilityservice.AccessibilityServiceInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.accessibilityservice.AccessibilityService._setServiceInfo22, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._setServiceInfo22, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBind23;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.accessibilityservice.AccessibilityService._onBind23, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._onBind23, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AccessibilityService24;
		public AccessibilityService()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._AccessibilityService24, this);
		}
		public static global::java.lang.String SERVICE_INTERFACE
		{
			get
			{
				return "android.accessibilityservice.AccessibilityService";
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.accessibilityservice.AccessibilityService.staticClass = @__class;
			global::android.accessibilityservice.AccessibilityService._onAccessibilityEvent19 = @__env.GetMethodID(global::android.accessibilityservice.AccessibilityService.staticClass, "onAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.accessibilityservice.AccessibilityService._onInterrupt20 = @__env.GetMethodID(global::android.accessibilityservice.AccessibilityService.staticClass, "onInterrupt", "()V");
			global::android.accessibilityservice.AccessibilityService._onServiceConnected21 = @__env.GetMethodID(global::android.accessibilityservice.AccessibilityService.staticClass, "onServiceConnected", "()V");
			global::android.accessibilityservice.AccessibilityService._setServiceInfo22 = @__env.GetMethodID(global::android.accessibilityservice.AccessibilityService.staticClass, "setServiceInfo", "(Landroid/accessibilityservice/AccessibilityServiceInfo;)V");
			global::android.accessibilityservice.AccessibilityService._onBind23 = @__env.GetMethodID(global::android.accessibilityservice.AccessibilityService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.accessibilityservice.AccessibilityService._AccessibilityService24 = @__env.GetMethodID(global::android.accessibilityservice.AccessibilityService.staticClass, "<init>", "()V");
		}
	}
}
