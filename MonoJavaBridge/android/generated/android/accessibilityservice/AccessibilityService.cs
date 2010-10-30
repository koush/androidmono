namespace android.accessibilityservice
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.accessibilityservice.AccessibilityService_))]
	public abstract partial class AccessibilityService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccessibilityService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void onAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void onInterrupt();
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual void onServiceConnected()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accessibilityservice.AccessibilityService.staticClass, "onServiceConnected", "()V", ref global::android.accessibilityservice.AccessibilityService._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setServiceInfo(android.accessibilityservice.AccessibilityServiceInfo arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accessibilityservice.AccessibilityService.staticClass, "setServiceInfo", "(Landroid/accessibilityservice/AccessibilityServiceInfo;)V", ref global::android.accessibilityservice.AccessibilityService._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.accessibilityservice.AccessibilityService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.accessibilityservice.AccessibilityService._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IBinder;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AccessibilityService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accessibilityservice.AccessibilityService._m5.native == global::System.IntPtr.Zero)
				global::android.accessibilityservice.AccessibilityService._m5 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._m5);
			Init(@__env, handle);
		}
		public static global::java.lang.String SERVICE_INTERFACE
		{
			get
			{
				return "android.accessibilityservice.AccessibilityService";
			}
		}
		static AccessibilityService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accessibilityservice.AccessibilityService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accessibilityservice/AccessibilityService"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.accessibilityservice.AccessibilityService))]
	internal sealed partial class AccessibilityService_ : android.accessibilityservice.AccessibilityService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AccessibilityService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accessibilityservice.AccessibilityService_.staticClass, "onAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", ref global::android.accessibilityservice.AccessibilityService_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onInterrupt()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accessibilityservice.AccessibilityService_.staticClass, "onInterrupt", "()V", ref global::android.accessibilityservice.AccessibilityService_._m1);
		}
		static AccessibilityService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accessibilityservice.AccessibilityService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accessibilityservice/AccessibilityService"));
		}
		internal static void InitJNI()
		{
		}
	}
}
