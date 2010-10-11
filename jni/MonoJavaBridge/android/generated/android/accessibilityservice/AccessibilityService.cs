namespace android.accessibilityservice
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.accessibilityservice.AccessibilityService_))]
	public abstract partial class AccessibilityService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessibilityService()
		{
			InitJNI();
		}
		protected AccessibilityService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAccessibilityEvent19;
		public abstract void onAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0);
		internal static global::MonoJavaBridge.MethodId _onInterrupt20;
		public abstract void onInterrupt();
		internal static global::MonoJavaBridge.MethodId _onServiceConnected21;
		protected virtual void onServiceConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService._onServiceConnected21);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._onServiceConnected21);
		}
		internal static global::MonoJavaBridge.MethodId _setServiceInfo22;
		public virtual void setServiceInfo(android.accessibilityservice.AccessibilityServiceInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService._setServiceInfo22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._setServiceInfo22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBind23;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService._onBind23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._onBind23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _AccessibilityService24;
		public AccessibilityService()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._AccessibilityService24);
			Init(@__env, handle);
		}
		public static global::java.lang.String SERVICE_INTERFACE
		{
			get
			{
				return "android.accessibilityservice.AccessibilityService";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accessibilityservice.AccessibilityService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accessibilityservice/AccessibilityService"));
			global::android.accessibilityservice.AccessibilityService._onAccessibilityEvent19 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "onAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.accessibilityservice.AccessibilityService._onInterrupt20 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "onInterrupt", "()V");
			global::android.accessibilityservice.AccessibilityService._onServiceConnected21 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "onServiceConnected", "()V");
			global::android.accessibilityservice.AccessibilityService._setServiceInfo22 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "setServiceInfo", "(Landroid/accessibilityservice/AccessibilityServiceInfo;)V");
			global::android.accessibilityservice.AccessibilityService._onBind23 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.accessibilityservice.AccessibilityService._AccessibilityService24 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accessibilityservice.AccessibilityService))]
	public sealed partial class AccessibilityService_ : android.accessibilityservice.AccessibilityService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessibilityService_()
		{
			InitJNI();
		}
		internal AccessibilityService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAccessibilityEvent25;
		public override void onAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService_._onAccessibilityEvent25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService_.staticClass, global::android.accessibilityservice.AccessibilityService_._onAccessibilityEvent25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterrupt26;
		public override void onInterrupt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService_._onInterrupt26);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService_.staticClass, global::android.accessibilityservice.AccessibilityService_._onInterrupt26);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accessibilityservice.AccessibilityService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accessibilityservice/AccessibilityService"));
			global::android.accessibilityservice.AccessibilityService_._onAccessibilityEvent25 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService_.staticClass, "onAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.accessibilityservice.AccessibilityService_._onInterrupt26 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService_.staticClass, "onInterrupt", "()V");
		}
	}
}
