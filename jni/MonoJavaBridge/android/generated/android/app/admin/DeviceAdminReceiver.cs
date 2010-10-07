namespace android.app.admin
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DeviceAdminReceiver : android.content.BroadcastReceiver
	{
		internal new static global::java.lang.Class staticClass;
		static DeviceAdminReceiver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.admin.DeviceAdminReceiver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.admin.DeviceAdminReceiver(@__env);
			}
		}
		protected DeviceAdminReceiver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onReceive875;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver._onReceive875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onReceive875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getManager876;
		public virtual global::android.app.admin.DevicePolicyManager getManager(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.admin.DevicePolicyManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminReceiver._getManager876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.admin.DevicePolicyManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._getManager876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWho877;
		public virtual global::android.content.ComponentName getWho(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminReceiver._getWho877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._getWho877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onEnabled878;
		public virtual void onEnabled(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver._onEnabled878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onEnabled878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDisableRequested879;
		public virtual global::java.lang.CharSequence onDisableRequested(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminReceiver._onDisableRequested879, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onDisableRequested879, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDisabled880;
		public virtual void onDisabled(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver._onDisabled880, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onDisabled880, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPasswordChanged881;
		public virtual void onPasswordChanged(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver._onPasswordChanged881, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onPasswordChanged881, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPasswordFailed882;
		public virtual void onPasswordFailed(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver._onPasswordFailed882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onPasswordFailed882, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPasswordSucceeded883;
		public virtual void onPasswordSucceeded(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DeviceAdminReceiver._onPasswordSucceeded883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._onPasswordSucceeded883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DeviceAdminReceiver884;
		public DeviceAdminReceiver()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.admin.DeviceAdminReceiver.staticClass, global::android.app.admin.DeviceAdminReceiver._DeviceAdminReceiver884, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.admin.DeviceAdminReceiver.staticClass = @__class;
			global::android.app.admin.DeviceAdminReceiver._onReceive875 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._getManager876 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "getManager", "(Landroid/content/Context;)Landroid/app/admin/DevicePolicyManager;");
			global::android.app.admin.DeviceAdminReceiver._getWho877 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "getWho", "(Landroid/content/Context;)Landroid/content/ComponentName;");
			global::android.app.admin.DeviceAdminReceiver._onEnabled878 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "onEnabled", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._onDisableRequested879 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "onDisableRequested", "(Landroid/content/Context;Landroid/content/Intent;)Ljava/lang/CharSequence;");
			global::android.app.admin.DeviceAdminReceiver._onDisabled880 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "onDisabled", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._onPasswordChanged881 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordChanged", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._onPasswordFailed882 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordFailed", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._onPasswordSucceeded883 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "onPasswordSucceeded", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.app.admin.DeviceAdminReceiver._DeviceAdminReceiver884 = @__env.GetMethodID(global::android.app.admin.DeviceAdminReceiver.staticClass, "<init>", "()V");
		}
	}
}
