namespace android.app.admin
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DevicePolicyManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static DevicePolicyManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.admin.DevicePolicyManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.admin.DevicePolicyManager(@__env);
			}
		}
		protected DevicePolicyManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAdminActive885;
		public virtual bool isAdminActive(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.admin.DevicePolicyManager._isAdminActive885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._isAdminActive885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getActiveAdmins886;
		public virtual global::java.util.List getActiveAdmins() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DevicePolicyManager._getActiveAdmins886));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getActiveAdmins886));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeActiveAdmin887;
		public virtual void removeActiveAdmin(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager._removeActiveAdmin887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._removeActiveAdmin887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPasswordQuality888;
		public virtual void setPasswordQuality(android.content.ComponentName arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager._setPasswordQuality888, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setPasswordQuality888, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPasswordQuality889;
		public virtual int getPasswordQuality(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.admin.DevicePolicyManager._getPasswordQuality889, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getPasswordQuality889, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPasswordMinimumLength890;
		public virtual void setPasswordMinimumLength(android.content.ComponentName arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager._setPasswordMinimumLength890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setPasswordMinimumLength890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPasswordMinimumLength891;
		public virtual int getPasswordMinimumLength(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.admin.DevicePolicyManager._getPasswordMinimumLength891, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getPasswordMinimumLength891, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPasswordMaximumLength892;
		public virtual int getPasswordMaximumLength(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.admin.DevicePolicyManager._getPasswordMaximumLength892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getPasswordMaximumLength892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isActivePasswordSufficient893;
		public virtual bool isActivePasswordSufficient() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.admin.DevicePolicyManager._isActivePasswordSufficient893);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._isActivePasswordSufficient893);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFailedPasswordAttempts894;
		public virtual int getCurrentFailedPasswordAttempts() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.admin.DevicePolicyManager._getCurrentFailedPasswordAttempts894);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getCurrentFailedPasswordAttempts894);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumFailedPasswordsForWipe895;
		public virtual void setMaximumFailedPasswordsForWipe(android.content.ComponentName arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager._setMaximumFailedPasswordsForWipe895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setMaximumFailedPasswordsForWipe895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumFailedPasswordsForWipe896;
		public virtual int getMaximumFailedPasswordsForWipe(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.admin.DevicePolicyManager._getMaximumFailedPasswordsForWipe896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getMaximumFailedPasswordsForWipe896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetPassword897;
		public virtual bool resetPassword(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.admin.DevicePolicyManager._resetPassword897, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._resetPassword897, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumTimeToLock898;
		public virtual void setMaximumTimeToLock(android.content.ComponentName arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager._setMaximumTimeToLock898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setMaximumTimeToLock898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumTimeToLock899;
		public virtual long getMaximumTimeToLock(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.app.admin.DevicePolicyManager._getMaximumTimeToLock899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getMaximumTimeToLock899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _lockNow900;
		public virtual void lockNow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager._lockNow900);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._lockNow900);
		}
		internal static global::net.sf.jni4net.jni.MethodId _wipeData901;
		public virtual void wipeData(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DevicePolicyManager._wipeData901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._wipeData901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.admin.DevicePolicyManager.staticClass = @__class;
			global::android.app.admin.DevicePolicyManager._isAdminActive885 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "isAdminActive", "(Landroid/content/ComponentName;)Z");
			global::android.app.admin.DevicePolicyManager._getActiveAdmins886 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "getActiveAdmins", "()Ljava/util/List;");
			global::android.app.admin.DevicePolicyManager._removeActiveAdmin887 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "removeActiveAdmin", "(Landroid/content/ComponentName;)V");
			global::android.app.admin.DevicePolicyManager._setPasswordQuality888 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "setPasswordQuality", "(Landroid/content/ComponentName;I)V");
			global::android.app.admin.DevicePolicyManager._getPasswordQuality889 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordQuality", "(Landroid/content/ComponentName;)I");
			global::android.app.admin.DevicePolicyManager._setPasswordMinimumLength890 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "setPasswordMinimumLength", "(Landroid/content/ComponentName;I)V");
			global::android.app.admin.DevicePolicyManager._getPasswordMinimumLength891 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordMinimumLength", "(Landroid/content/ComponentName;)I");
			global::android.app.admin.DevicePolicyManager._getPasswordMaximumLength892 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordMaximumLength", "(I)I");
			global::android.app.admin.DevicePolicyManager._isActivePasswordSufficient893 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "isActivePasswordSufficient", "()Z");
			global::android.app.admin.DevicePolicyManager._getCurrentFailedPasswordAttempts894 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "getCurrentFailedPasswordAttempts", "()I");
			global::android.app.admin.DevicePolicyManager._setMaximumFailedPasswordsForWipe895 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "setMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;I)V");
			global::android.app.admin.DevicePolicyManager._getMaximumFailedPasswordsForWipe896 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "getMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;)I");
			global::android.app.admin.DevicePolicyManager._resetPassword897 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "resetPassword", "(Ljava/lang/String;I)Z");
			global::android.app.admin.DevicePolicyManager._setMaximumTimeToLock898 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "setMaximumTimeToLock", "(Landroid/content/ComponentName;J)V");
			global::android.app.admin.DevicePolicyManager._getMaximumTimeToLock899 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "getMaximumTimeToLock", "(Landroid/content/ComponentName;)J");
			global::android.app.admin.DevicePolicyManager._lockNow900 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "lockNow", "()V");
			global::android.app.admin.DevicePolicyManager._wipeData901 = @__env.GetMethodID(global::android.app.admin.DevicePolicyManager.staticClass, "wipeData", "(I)V");
		}
	}
}
