namespace android.app.admin
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DevicePolicyManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DevicePolicyManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool isAdminActive(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "isAdminActive", "(Landroid/content/ComponentName;)Z", ref global::android.app.admin.DevicePolicyManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List ActiveAdmins
		{
			get
			{
				return getActiveAdmins();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.List getActiveAdmins()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.admin.DevicePolicyManager.staticClass, "getActiveAdmins", "()Ljava/util/List;", ref global::android.app.admin.DevicePolicyManager._m1) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void removeActiveAdmin(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "removeActiveAdmin", "(Landroid/content/ComponentName;)V", ref global::android.app.admin.DevicePolicyManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setPasswordQuality(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "setPasswordQuality", "(Landroid/content/ComponentName;I)V", ref global::android.app.admin.DevicePolicyManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getPasswordQuality(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordQuality", "(Landroid/content/ComponentName;)I", ref global::android.app.admin.DevicePolicyManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setPasswordMinimumLength(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "setPasswordMinimumLength", "(Landroid/content/ComponentName;I)V", ref global::android.app.admin.DevicePolicyManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getPasswordMinimumLength(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordMinimumLength", "(Landroid/content/ComponentName;)I", ref global::android.app.admin.DevicePolicyManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getPasswordMaximumLength(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordMaximumLength", "(I)I", ref global::android.app.admin.DevicePolicyManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isActivePasswordSufficient()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "isActivePasswordSufficient", "()Z", ref global::android.app.admin.DevicePolicyManager._m8);
		}
		public new int CurrentFailedPasswordAttempts
		{
			get
			{
				return getCurrentFailedPasswordAttempts();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getCurrentFailedPasswordAttempts()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "getCurrentFailedPasswordAttempts", "()I", ref global::android.app.admin.DevicePolicyManager._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setMaximumFailedPasswordsForWipe(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "setMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;I)V", ref global::android.app.admin.DevicePolicyManager._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getMaximumFailedPasswordsForWipe(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "getMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;)I", ref global::android.app.admin.DevicePolicyManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool resetPassword(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "resetPassword", "(Ljava/lang/String;I)Z", ref global::android.app.admin.DevicePolicyManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setMaximumTimeToLock(android.content.ComponentName arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "setMaximumTimeToLock", "(Landroid/content/ComponentName;J)V", ref global::android.app.admin.DevicePolicyManager._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual long getMaximumTimeToLock(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "getMaximumTimeToLock", "(Landroid/content/ComponentName;)J", ref global::android.app.admin.DevicePolicyManager._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void lockNow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "lockNow", "()V", ref global::android.app.admin.DevicePolicyManager._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void wipeData(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, "wipeData", "(I)V", ref global::android.app.admin.DevicePolicyManager._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.String ACTION_ADD_DEVICE_ADMIN
		{
			get
			{
				return "android.app.action.ADD_DEVICE_ADMIN";
			}
		}
		public static global::java.lang.String EXTRA_DEVICE_ADMIN
		{
			get
			{
				return "android.app.extra.DEVICE_ADMIN";
			}
		}
		public static global::java.lang.String EXTRA_ADD_EXPLANATION
		{
			get
			{
				return "android.app.extra.ADD_EXPLANATION";
			}
		}
		public static global::java.lang.String ACTION_SET_NEW_PASSWORD
		{
			get
			{
				return "android.app.action.SET_NEW_PASSWORD";
			}
		}
		public static int PASSWORD_QUALITY_UNSPECIFIED
		{
			get
			{
				return 0;
			}
		}
		public static int PASSWORD_QUALITY_SOMETHING
		{
			get
			{
				return 65536;
			}
		}
		public static int PASSWORD_QUALITY_NUMERIC
		{
			get
			{
				return 131072;
			}
		}
		public static int PASSWORD_QUALITY_ALPHABETIC
		{
			get
			{
				return 262144;
			}
		}
		public static int PASSWORD_QUALITY_ALPHANUMERIC
		{
			get
			{
				return 327680;
			}
		}
		public static int RESET_PASSWORD_REQUIRE_ENTRY
		{
			get
			{
				return 1;
			}
		}
		static DevicePolicyManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.admin.DevicePolicyManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/admin/DevicePolicyManager"));
		}
	}
}
