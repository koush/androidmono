namespace android.app.admin
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DeviceAdminReceiver : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DeviceAdminReceiver()
		{
			InitJNI();
		}
		protected DeviceAdminReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive887;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver._onReceive887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onReceive887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getManager888;
		public virtual global::android.app.admin.DevicePolicyManager getManager(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver._getManager888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.admin.DevicePolicyManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._getManager888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.admin.DevicePolicyManager;
		}
		internal static global::MonoJavaBridge.MethodId _getWho889;
		public virtual global::android.content.ComponentName getWho(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver._getWho889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._getWho889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _onEnabled890;
		public virtual void onEnabled(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver._onEnabled890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onEnabled890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onDisableRequested891;
		public virtual global::java.lang.CharSequence onDisableRequested(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver._onDisableRequested891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onDisableRequested891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _onDisabled892;
		public virtual void onDisabled(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver._onDisabled892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onDisabled892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPasswordChanged893;
		public virtual void onPasswordChanged(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver._onPasswordChanged893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onPasswordChanged893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPasswordFailed894;
		public virtual void onPasswordFailed(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver._onPasswordFailed894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onPasswordFailed894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPasswordSucceeded895;
		public virtual void onPasswordSucceeded(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver._onPasswordSucceeded895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onPasswordSucceeded895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DeviceAdminReceiver896;
		public DeviceAdminReceiver()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._DeviceAdminReceiver896);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.admin.DeviceAdminReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/admin/DeviceAdminReceiver"));
			global::android.app.admin.DeviceAdminReceiver._onReceive887 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._getManager888 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "getManager", "(Landroid/content/Context;)Landroid/app/admin/DevicePolicyManager;");
			global::android.app.admin.DeviceAdminReceiver._getWho889 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "getWho", "(Landroid/content/Context;)Landroid/content/ComponentName;");
			global::android.app.admin.DeviceAdminReceiver._onEnabled890 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onEnabled", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._onDisableRequested891 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onDisableRequested", "(Landroid/content/Context;Landroid/content/Intent;)Ljava/lang/CharSequence;");
			global::android.app.admin.DeviceAdminReceiver._onDisabled892 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onDisabled", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._onPasswordChanged893 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordChanged", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._onPasswordFailed894 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordFailed", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._onPasswordSucceeded895 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordSucceeded", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._DeviceAdminReceiver896 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminReceiver.staticClass, "<init>", "()V");
		}
	}
}
