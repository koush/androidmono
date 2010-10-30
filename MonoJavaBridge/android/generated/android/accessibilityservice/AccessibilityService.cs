namespace android.accessibilityservice
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.accessibilityservice.AccessibilityService_))]
	public abstract partial class AccessibilityService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccessibilityService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAccessibilityEvent1237;
		public abstract void onAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0);
		internal static global::MonoJavaBridge.MethodId _onInterrupt1238;
		public abstract void onInterrupt();
		internal static global::MonoJavaBridge.MethodId _onServiceConnected1239;
		protected virtual void onServiceConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accessibilityservice.AccessibilityService._onServiceConnected1239.native == global::System.IntPtr.Zero)
				global::android.accessibilityservice.AccessibilityService._onServiceConnected1239 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "onServiceConnected", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._onServiceConnected1239);
		}
		internal static global::MonoJavaBridge.MethodId _setServiceInfo1240;
		public virtual void setServiceInfo(android.accessibilityservice.AccessibilityServiceInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accessibilityservice.AccessibilityService._setServiceInfo1240.native == global::System.IntPtr.Zero)
				global::android.accessibilityservice.AccessibilityService._setServiceInfo1240 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "setServiceInfo", "(Landroid/accessibilityservice/AccessibilityServiceInfo;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._setServiceInfo1240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBind1241;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accessibilityservice.AccessibilityService._onBind1241.native == global::System.IntPtr.Zero)
				global::android.accessibilityservice.AccessibilityService._onBind1241 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._onBind1241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _AccessibilityService1242;
		public AccessibilityService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accessibilityservice.AccessibilityService._AccessibilityService1242.native == global::System.IntPtr.Zero)
				global::android.accessibilityservice.AccessibilityService._AccessibilityService1242 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accessibilityservice.AccessibilityService.staticClass, global::android.accessibilityservice.AccessibilityService._AccessibilityService1242);
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
		internal static global::MonoJavaBridge.MethodId _onAccessibilityEvent1244;
		public override void onAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accessibilityservice.AccessibilityService_._onAccessibilityEvent1244.native == global::System.IntPtr.Zero)
				global::android.accessibilityservice.AccessibilityService_._onAccessibilityEvent1244 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService_.staticClass, "onAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService_._onAccessibilityEvent1244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterrupt1245;
		public override void onInterrupt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accessibilityservice.AccessibilityService_._onInterrupt1245.native == global::System.IntPtr.Zero)
				global::android.accessibilityservice.AccessibilityService_._onInterrupt1245 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityService_.staticClass, "onInterrupt", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityService_._onInterrupt1245);
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
