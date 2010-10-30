namespace android.app.admin
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DeviceAdminReceiver : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DeviceAdminReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive2253;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._onReceive2253.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._onReceive2253 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onReceive2253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getManager2254;
		public virtual global::android.app.admin.DevicePolicyManager getManager(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._getManager2254.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._getManager2254 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "getManager", "(Landroid/content/Context;)Landroid/app/admin/DevicePolicyManager;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._getManager2254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.admin.DevicePolicyManager;
		}
		internal static global::MonoJavaBridge.MethodId _getWho2255;
		public virtual global::android.content.ComponentName getWho(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._getWho2255.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._getWho2255 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "getWho", "(Landroid/content/Context;)Landroid/content/ComponentName;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._getWho2255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _onEnabled2256;
		public virtual void onEnabled(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._onEnabled2256.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._onEnabled2256 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onEnabled", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onEnabled2256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onDisableRequested2257;
		public virtual global::java.lang.CharSequence onDisableRequested(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._onDisableRequested2257.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._onDisableRequested2257 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onDisableRequested", "(Landroid/content/Context;Landroid/content/Intent;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onDisableRequested2257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onDisabled2258;
		public virtual void onDisabled(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._onDisabled2258.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._onDisabled2258 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onDisabled", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onDisabled2258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPasswordChanged2259;
		public virtual void onPasswordChanged(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._onPasswordChanged2259.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._onPasswordChanged2259 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordChanged", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onPasswordChanged2259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPasswordFailed2260;
		public virtual void onPasswordFailed(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._onPasswordFailed2260.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._onPasswordFailed2260 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordFailed", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onPasswordFailed2260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPasswordSucceeded2261;
		public virtual void onPasswordSucceeded(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._onPasswordSucceeded2261.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._onPasswordSucceeded2261 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordSucceeded", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onPasswordSucceeded2261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DeviceAdminReceiver2262;
		public DeviceAdminReceiver() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._DeviceAdminReceiver2262.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._DeviceAdminReceiver2262 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._DeviceAdminReceiver2262);
			Init(@__env, handle);
		}
		public static global::java.lang.String ACTION_DEVICE_ADMIN_ENABLED
		{
			get
			{
				return "android.app.action.DEVICE_ADMIN_ENABLED";
			}
		}
		public static global::java.lang.String ACTION_DEVICE_ADMIN_DISABLE_REQUESTED
		{
			get
			{
				return "android.app.action.DEVICE_ADMIN_DISABLE_REQUESTED";
			}
		}
		public static global::java.lang.String EXTRA_DISABLE_WARNING
		{
			get
			{
				return "android.app.extra.DISABLE_WARNING";
			}
		}
		public static global::java.lang.String ACTION_DEVICE_ADMIN_DISABLED
		{
			get
			{
				return "android.app.action.DEVICE_ADMIN_DISABLED";
			}
		}
		public static global::java.lang.String ACTION_PASSWORD_CHANGED
		{
			get
			{
				return "android.app.action.ACTION_PASSWORD_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_PASSWORD_FAILED
		{
			get
			{
				return "android.app.action.ACTION_PASSWORD_FAILED";
			}
		}
		public static global::java.lang.String ACTION_PASSWORD_SUCCEEDED
		{
			get
			{
				return "android.app.action.ACTION_PASSWORD_SUCCEEDED";
			}
		}
		public static global::java.lang.String DEVICE_ADMIN_META_DATA
		{
			get
			{
				return "android.app.device_admin";
			}
		}
		static DeviceAdminReceiver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.admin.DeviceAdminReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/admin/DeviceAdminReceiver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
