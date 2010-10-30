namespace android.app.admin
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DeviceAdminReceiver : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DeviceAdminReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", ref global::android.app.admin.DeviceAdminReceiver._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.app.admin.DevicePolicyManager getManager(android.content.Context arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, "getManager", "(Landroid/content/Context;)Landroid/app/admin/DevicePolicyManager;", ref global::android.app.admin.DeviceAdminReceiver._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.admin.DevicePolicyManager;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.content.ComponentName getWho(android.content.Context arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.admin.DeviceAdminReceiver.staticClass, "getWho", "(Landroid/content/Context;)Landroid/content/ComponentName;", ref global::android.app.admin.DeviceAdminReceiver._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onEnabled(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, "onEnabled", "(Landroid/content/Context;Landroid/content/Intent;)V", ref global::android.app.admin.DeviceAdminReceiver._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.CharSequence onDisableRequested(android.content.Context arg0, android.content.Intent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.app.admin.DeviceAdminReceiver.staticClass, "onDisableRequested", "(Landroid/content/Context;Landroid/content/Intent;)Ljava/lang/CharSequence;", ref global::android.app.admin.DeviceAdminReceiver._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onDisabled(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, "onDisabled", "(Landroid/content/Context;Landroid/content/Intent;)V", ref global::android.app.admin.DeviceAdminReceiver._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void onPasswordChanged(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordChanged", "(Landroid/content/Context;Landroid/content/Intent;)V", ref global::android.app.admin.DeviceAdminReceiver._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void onPasswordFailed(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordFailed", "(Landroid/content/Context;Landroid/content/Intent;)V", ref global::android.app.admin.DeviceAdminReceiver._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void onPasswordSucceeded(android.content.Context arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordSucceeded", "(Landroid/content/Context;Landroid/content/Intent;)V", ref global::android.app.admin.DeviceAdminReceiver._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public DeviceAdminReceiver() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminReceiver._m9.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminReceiver._m9 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._m9);
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
