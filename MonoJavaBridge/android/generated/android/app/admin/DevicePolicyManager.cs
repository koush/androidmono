namespace android.app.admin
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DevicePolicyManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DevicePolicyManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAdminActive2271;
		public virtual bool isAdminActive(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._isAdminActive2271.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._isAdminActive2271 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "isAdminActive", "(Landroid/content/ComponentName;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._isAdminActive2271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List ActiveAdmins
		{
			get
			{
				return getActiveAdmins();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActiveAdmins2272;
		public virtual global::java.util.List getActiveAdmins()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._getActiveAdmins2272.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._getActiveAdmins2272 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getActiveAdmins", "()Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getActiveAdmins2272) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _removeActiveAdmin2273;
		public virtual void removeActiveAdmin(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._removeActiveAdmin2273.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._removeActiveAdmin2273 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "removeActiveAdmin", "(Landroid/content/ComponentName;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._removeActiveAdmin2273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPasswordQuality2274;
		public virtual void setPasswordQuality(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._setPasswordQuality2274.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._setPasswordQuality2274 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "setPasswordQuality", "(Landroid/content/ComponentName;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setPasswordQuality2274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPasswordQuality2275;
		public virtual int getPasswordQuality(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._getPasswordQuality2275.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._getPasswordQuality2275 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordQuality", "(Landroid/content/ComponentName;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getPasswordQuality2275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPasswordMinimumLength2276;
		public virtual void setPasswordMinimumLength(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._setPasswordMinimumLength2276.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._setPasswordMinimumLength2276 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "setPasswordMinimumLength", "(Landroid/content/ComponentName;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setPasswordMinimumLength2276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPasswordMinimumLength2277;
		public virtual int getPasswordMinimumLength(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._getPasswordMinimumLength2277.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._getPasswordMinimumLength2277 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordMinimumLength", "(Landroid/content/ComponentName;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getPasswordMinimumLength2277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPasswordMaximumLength2278;
		public virtual int getPasswordMaximumLength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._getPasswordMaximumLength2278.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._getPasswordMaximumLength2278 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordMaximumLength", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getPasswordMaximumLength2278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isActivePasswordSufficient2279;
		public virtual bool isActivePasswordSufficient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._isActivePasswordSufficient2279.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._isActivePasswordSufficient2279 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "isActivePasswordSufficient", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._isActivePasswordSufficient2279);
		}
		public new int CurrentFailedPasswordAttempts
		{
			get
			{
				return getCurrentFailedPasswordAttempts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFailedPasswordAttempts2280;
		public virtual int getCurrentFailedPasswordAttempts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._getCurrentFailedPasswordAttempts2280.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._getCurrentFailedPasswordAttempts2280 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getCurrentFailedPasswordAttempts", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getCurrentFailedPasswordAttempts2280);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumFailedPasswordsForWipe2281;
		public virtual void setMaximumFailedPasswordsForWipe(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._setMaximumFailedPasswordsForWipe2281.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._setMaximumFailedPasswordsForWipe2281 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "setMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setMaximumFailedPasswordsForWipe2281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFailedPasswordsForWipe2282;
		public virtual int getMaximumFailedPasswordsForWipe(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._getMaximumFailedPasswordsForWipe2282.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._getMaximumFailedPasswordsForWipe2282 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getMaximumFailedPasswordsForWipe2282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetPassword2283;
		public virtual bool resetPassword(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._resetPassword2283.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._resetPassword2283 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "resetPassword", "(Ljava/lang/String;I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._resetPassword2283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumTimeToLock2284;
		public virtual void setMaximumTimeToLock(android.content.ComponentName arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._setMaximumTimeToLock2284.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._setMaximumTimeToLock2284 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "setMaximumTimeToLock", "(Landroid/content/ComponentName;J)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setMaximumTimeToLock2284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumTimeToLock2285;
		public virtual long getMaximumTimeToLock(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._getMaximumTimeToLock2285.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._getMaximumTimeToLock2285 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getMaximumTimeToLock", "(Landroid/content/ComponentName;)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getMaximumTimeToLock2285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lockNow2286;
		public virtual void lockNow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._lockNow2286.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._lockNow2286 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "lockNow", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._lockNow2286);
		}
		internal static global::MonoJavaBridge.MethodId _wipeData2287;
		public virtual void wipeData(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DevicePolicyManager._wipeData2287.native == global::System.IntPtr.Zero)
				global::android.app.admin.DevicePolicyManager._wipeData2287 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "wipeData", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._wipeData2287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static void InitJNI()
		{
		}
	}
}
