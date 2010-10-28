namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.pm.PackageManager_))]
	public abstract partial class PackageManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PackageManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class NameNotFoundException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected NameNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _NameNotFoundException3793;
			public NameNotFoundException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageManager.NameNotFoundException.staticClass, global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException3793);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _NameNotFoundException3794;
			public NameNotFoundException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageManager.NameNotFoundException.staticClass, global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException3794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static NameNotFoundException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.PackageManager.NameNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageManager$NameNotFoundException"));
				global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException3793 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.NameNotFoundException.staticClass, "<init>", "()V");
				global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException3794 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.NameNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission3795;
		public abstract int checkPermission(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getPackageInfo3796;
		public abstract global::android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo3797;
		public abstract global::android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getText3798;
		public abstract global::java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2);
		internal static global::MonoJavaBridge.MethodId _resolveActivity3799;
		public abstract global::android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getDrawable3800;
		public abstract global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2);
		internal static global::MonoJavaBridge.MethodId _getXml3801;
		public abstract global::android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2);
		internal static global::MonoJavaBridge.MethodId _currentToCanonicalPackageNames3802;
		public abstract global::java.lang.String[] currentToCanonicalPackageNames(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _canonicalToCurrentPackageNames3803;
		public abstract global::java.lang.String[] canonicalToCurrentPackageNames(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getLaunchIntentForPackage3804;
		public abstract global::android.content.Intent getLaunchIntentForPackage(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getPackageGids3805;
		public abstract int[] getPackageGids(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getPermissionInfo3806;
		public abstract global::android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryPermissionsByGroup3807;
		public abstract global::java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getPermissionGroupInfo3808;
		public abstract global::android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getAllPermissionGroups3809;
		public abstract global::java.util.List getAllPermissionGroups(int arg0);
		internal static global::MonoJavaBridge.MethodId _getActivityInfo3810;
		public abstract global::android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getReceiverInfo3811;
		public abstract global::android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getServiceInfo3812;
		public abstract global::android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getInstalledPackages3813;
		public abstract global::java.util.List getInstalledPackages(int arg0);
		internal static global::MonoJavaBridge.MethodId _addPermission3814;
		public abstract bool addPermission(android.content.pm.PermissionInfo arg0);
		internal static global::MonoJavaBridge.MethodId _addPermissionAsync3815;
		public abstract bool addPermissionAsync(android.content.pm.PermissionInfo arg0);
		internal static global::MonoJavaBridge.MethodId _removePermission3816;
		public abstract void removePermission(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _checkSignatures3817;
		public abstract int checkSignatures(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _checkSignatures3818;
		public abstract int checkSignatures(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getPackagesForUid3819;
		public abstract global::java.lang.String[] getPackagesForUid(int arg0);
		internal static global::MonoJavaBridge.MethodId _getNameForUid3820;
		public abstract global::java.lang.String getNameForUid(int arg0);
		internal static global::MonoJavaBridge.MethodId _getInstalledApplications3821;
		public abstract global::java.util.List getInstalledApplications(int arg0);
		internal static global::MonoJavaBridge.MethodId _getSystemSharedLibraryNames3822;
		public abstract global::java.lang.String[] getSystemSharedLibraryNames();
		internal static global::MonoJavaBridge.MethodId _getSystemAvailableFeatures3823;
		public abstract global::android.content.pm.FeatureInfo[] getSystemAvailableFeatures();
		internal static global::MonoJavaBridge.MethodId _hasSystemFeature3824;
		public abstract bool hasSystemFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _queryIntentActivities3825;
		public abstract global::java.util.List queryIntentActivities(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryIntentActivityOptions3826;
		public abstract global::java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _queryBroadcastReceivers3827;
		public abstract global::java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _resolveService3828;
		public abstract global::android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryIntentServices3829;
		public abstract global::java.util.List queryIntentServices(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _resolveContentProvider3830;
		public abstract global::android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryContentProviders3831;
		public abstract global::java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getInstrumentationInfo3832;
		public abstract global::android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryInstrumentation3833;
		public abstract global::java.util.List queryInstrumentation(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getActivityIcon3834;
		public abstract global::android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _getActivityIcon3835;
		public abstract global::android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0);
		internal static global::MonoJavaBridge.MethodId _getDefaultActivityIcon3836;
		public abstract global::android.graphics.drawable.Drawable getDefaultActivityIcon();
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon3837;
		public abstract global::android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0);
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon3838;
		public abstract global::android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getApplicationLabel3839;
		public abstract global::java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0);
		internal static global::MonoJavaBridge.MethodId _getResourcesForActivity3840;
		public abstract global::android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0);
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication3841;
		public abstract global::android.content.res.Resources getResourcesForApplication(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication3842;
		public abstract global::android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0);
		internal static global::MonoJavaBridge.MethodId _getPackageArchiveInfo3843;
		public virtual global::android.content.pm.PackageInfo getPackageArchiveInfo(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager._getPackageArchiveInfo3843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager.staticClass, global::android.content.pm.PackageManager._getPackageArchiveInfo3843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstallerPackageName3844;
		public abstract global::java.lang.String getInstallerPackageName(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _addPackageToPreferred3845;
		public abstract void addPackageToPreferred(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removePackageFromPreferred3846;
		public abstract void removePackageFromPreferred(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getPreferredPackages3847;
		public abstract global::java.util.List getPreferredPackages(int arg0);
		internal static global::MonoJavaBridge.MethodId _addPreferredActivity3848;
		public abstract void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3);
		internal static global::MonoJavaBridge.MethodId _clearPackagePreferredActivities3849;
		public abstract void clearPackagePreferredActivities(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getPreferredActivities3850;
		public abstract int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2);
		internal static global::MonoJavaBridge.MethodId _setComponentEnabledSetting3851;
		public abstract void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getComponentEnabledSetting3852;
		public abstract int getComponentEnabledSetting(android.content.ComponentName arg0);
		internal static global::MonoJavaBridge.MethodId _setApplicationEnabledSetting3853;
		public abstract void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getApplicationEnabledSetting3854;
		public abstract int getApplicationEnabledSetting(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _isSafeMode3855;
		public abstract bool isSafeMode();
		internal static global::MonoJavaBridge.MethodId _PackageManager3856;
		public PackageManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageManager.staticClass, global::android.content.pm.PackageManager._PackageManager3856);
			Init(@__env, handle);
		}
		public static int GET_ACTIVITIES
		{
			get
			{
				return 1;
			}
		}
		public static int GET_RECEIVERS
		{
			get
			{
				return 2;
			}
		}
		public static int GET_SERVICES
		{
			get
			{
				return 4;
			}
		}
		public static int GET_PROVIDERS
		{
			get
			{
				return 8;
			}
		}
		public static int GET_INSTRUMENTATION
		{
			get
			{
				return 16;
			}
		}
		public static int GET_INTENT_FILTERS
		{
			get
			{
				return 32;
			}
		}
		public static int GET_SIGNATURES
		{
			get
			{
				return 64;
			}
		}
		public static int GET_RESOLVED_FILTER
		{
			get
			{
				return 64;
			}
		}
		public static int GET_META_DATA
		{
			get
			{
				return 128;
			}
		}
		public static int GET_GIDS
		{
			get
			{
				return 256;
			}
		}
		public static int GET_DISABLED_COMPONENTS
		{
			get
			{
				return 512;
			}
		}
		public static int GET_SHARED_LIBRARY_FILES
		{
			get
			{
				return 1024;
			}
		}
		public static int GET_URI_PERMISSION_PATTERNS
		{
			get
			{
				return 2048;
			}
		}
		public static int GET_PERMISSIONS
		{
			get
			{
				return 4096;
			}
		}
		public static int GET_UNINSTALLED_PACKAGES
		{
			get
			{
				return 8192;
			}
		}
		public static int GET_CONFIGURATIONS
		{
			get
			{
				return 16384;
			}
		}
		public static int MATCH_DEFAULT_ONLY
		{
			get
			{
				return 65536;
			}
		}
		public static int PERMISSION_GRANTED
		{
			get
			{
				return 0;
			}
		}
		public static int PERMISSION_DENIED
		{
			get
			{
				return -1;
			}
		}
		public static int SIGNATURE_MATCH
		{
			get
			{
				return 0;
			}
		}
		public static int SIGNATURE_NEITHER_SIGNED
		{
			get
			{
				return 1;
			}
		}
		public static int SIGNATURE_FIRST_NOT_SIGNED
		{
			get
			{
				return -1;
			}
		}
		public static int SIGNATURE_SECOND_NOT_SIGNED
		{
			get
			{
				return -2;
			}
		}
		public static int SIGNATURE_NO_MATCH
		{
			get
			{
				return -3;
			}
		}
		public static int SIGNATURE_UNKNOWN_PACKAGE
		{
			get
			{
				return -4;
			}
		}
		public static int COMPONENT_ENABLED_STATE_DEFAULT
		{
			get
			{
				return 0;
			}
		}
		public static int COMPONENT_ENABLED_STATE_ENABLED
		{
			get
			{
				return 1;
			}
		}
		public static int COMPONENT_ENABLED_STATE_DISABLED
		{
			get
			{
				return 2;
			}
		}
		public static int DONT_KILL_APP
		{
			get
			{
				return 1;
			}
		}
		public static global::java.lang.String FEATURE_BLUETOOTH
		{
			get
			{
				return "android.hardware.bluetooth";
			}
		}
		public static global::java.lang.String FEATURE_CAMERA
		{
			get
			{
				return "android.hardware.camera";
			}
		}
		public static global::java.lang.String FEATURE_CAMERA_AUTOFOCUS
		{
			get
			{
				return "android.hardware.camera.autofocus";
			}
		}
		public static global::java.lang.String FEATURE_CAMERA_FLASH
		{
			get
			{
				return "android.hardware.camera.flash";
			}
		}
		public static global::java.lang.String FEATURE_LOCATION
		{
			get
			{
				return "android.hardware.location";
			}
		}
		public static global::java.lang.String FEATURE_LOCATION_GPS
		{
			get
			{
				return "android.hardware.location.gps";
			}
		}
		public static global::java.lang.String FEATURE_LOCATION_NETWORK
		{
			get
			{
				return "android.hardware.location.network";
			}
		}
		public static global::java.lang.String FEATURE_MICROPHONE
		{
			get
			{
				return "android.hardware.microphone";
			}
		}
		public static global::java.lang.String FEATURE_SENSOR_COMPASS
		{
			get
			{
				return "android.hardware.sensor.compass";
			}
		}
		public static global::java.lang.String FEATURE_SENSOR_ACCELEROMETER
		{
			get
			{
				return "android.hardware.sensor.accelerometer";
			}
		}
		public static global::java.lang.String FEATURE_SENSOR_LIGHT
		{
			get
			{
				return "android.hardware.sensor.light";
			}
		}
		public static global::java.lang.String FEATURE_SENSOR_PROXIMITY
		{
			get
			{
				return "android.hardware.sensor.proximity";
			}
		}
		public static global::java.lang.String FEATURE_TELEPHONY
		{
			get
			{
				return "android.hardware.telephony";
			}
		}
		public static global::java.lang.String FEATURE_TELEPHONY_CDMA
		{
			get
			{
				return "android.hardware.telephony.cdma";
			}
		}
		public static global::java.lang.String FEATURE_TELEPHONY_GSM
		{
			get
			{
				return "android.hardware.telephony.gsm";
			}
		}
		public static global::java.lang.String FEATURE_TOUCHSCREEN
		{
			get
			{
				return "android.hardware.touchscreen";
			}
		}
		public static global::java.lang.String FEATURE_TOUCHSCREEN_MULTITOUCH
		{
			get
			{
				return "android.hardware.touchscreen.multitouch";
			}
		}
		public static global::java.lang.String FEATURE_TOUCHSCREEN_MULTITOUCH_DISTINCT
		{
			get
			{
				return "android.hardware.touchscreen.multitouch.distinct";
			}
		}
		public static global::java.lang.String FEATURE_LIVE_WALLPAPER
		{
			get
			{
				return "android.software.live_wallpaper";
			}
		}
		public static global::java.lang.String FEATURE_WIFI
		{
			get
			{
				return "android.hardware.wifi";
			}
		}
		static PackageManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageManager"));
			global::android.content.pm.PackageManager._checkPermission3795 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager._getPackageInfo3796 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.content.pm.PackageManager._getApplicationInfo3797 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.PackageManager._getText3798 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageManager._resolveActivity3799 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.content.pm.PackageManager._getDrawable3800 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getXml3801 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/XmlResourceParser;");
			global::android.content.pm.PackageManager._currentToCanonicalPackageNames3802 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.pm.PackageManager._canonicalToCurrentPackageNames3803 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.pm.PackageManager._getLaunchIntentForPackage3804 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.pm.PackageManager._getPackageGids3805 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPackageGids", "(Ljava/lang/String;)[I");
			global::android.content.pm.PackageManager._getPermissionInfo3806 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;");
			global::android.content.pm.PackageManager._queryPermissionsByGroup3807 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._getPermissionGroupInfo3808 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;");
			global::android.content.pm.PackageManager._getAllPermissionGroups3809 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getAllPermissionGroups", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager._getActivityInfo3810 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageManager._getReceiverInfo3811 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageManager._getServiceInfo3812 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.PackageManager._getInstalledPackages3813 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getInstalledPackages", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager._addPermission3814 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "addPermission", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.content.pm.PackageManager._addPermissionAsync3815 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.content.pm.PackageManager._removePermission3816 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "removePermission", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager._checkSignatures3817 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager._checkSignatures3818 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "checkSignatures", "(II)I");
			global::android.content.pm.PackageManager._getPackagesForUid3819 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPackagesForUid", "(I)[Ljava/lang/String;");
			global::android.content.pm.PackageManager._getNameForUid3820 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getNameForUid", "(I)Ljava/lang/String;");
			global::android.content.pm.PackageManager._getInstalledApplications3821 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getInstalledApplications", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager._getSystemSharedLibraryNames3822 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getSystemSharedLibraryNames", "()[Ljava/lang/String;");
			global::android.content.pm.PackageManager._getSystemAvailableFeatures3823 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;");
			global::android.content.pm.PackageManager._hasSystemFeature3824 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "hasSystemFeature", "(Ljava/lang/String;)Z");
			global::android.content.pm.PackageManager._queryIntentActivities3825 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._queryIntentActivityOptions3826 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._queryBroadcastReceivers3827 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._resolveService3828 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.content.pm.PackageManager._queryIntentServices3829 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._resolveContentProvider3830 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;");
			global::android.content.pm.PackageManager._queryContentProviders3831 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;");
			global::android.content.pm.PackageManager._getInstrumentationInfo3832 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;");
			global::android.content.pm.PackageManager._queryInstrumentation3833 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._getActivityIcon3834 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getActivityIcon3835 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getDefaultActivityIcon3836 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getApplicationIcon3837 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getApplicationIcon3838 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getApplicationLabel3839 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageManager._getResourcesForActivity3840 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager._getResourcesForApplication3841 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager._getResourcesForApplication3842 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager._getPackageArchiveInfo3843 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.content.pm.PackageManager._getInstallerPackageName3844 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.pm.PackageManager._addPackageToPreferred3845 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "addPackageToPreferred", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager._removePackageFromPreferred3846 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "removePackageFromPreferred", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager._getPreferredPackages3847 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPreferredPackages", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager._addPreferredActivity3848 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/ComponentName;)V");
			global::android.content.pm.PackageManager._clearPackagePreferredActivities3849 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "clearPackagePreferredActivities", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager._getPreferredActivities3850 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager._setComponentEnabledSetting3851 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V");
			global::android.content.pm.PackageManager._getComponentEnabledSetting3852 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getComponentEnabledSetting", "(Landroid/content/ComponentName;)I");
			global::android.content.pm.PackageManager._setApplicationEnabledSetting3853 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "setApplicationEnabledSetting", "(Ljava/lang/String;II)V");
			global::android.content.pm.PackageManager._getApplicationEnabledSetting3854 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationEnabledSetting", "(Ljava/lang/String;)I");
			global::android.content.pm.PackageManager._isSafeMode3855 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "isSafeMode", "()Z");
			global::android.content.pm.PackageManager._PackageManager3856 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.pm.PackageManager))]
	internal sealed partial class PackageManager_ : android.content.pm.PackageManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PackageManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission3906;
		public override int checkPermission(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._checkPermission3906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._checkPermission3906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackageInfo3907;
		public override global::android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPackageInfo3907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPackageInfo3907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo3908;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationInfo3908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ApplicationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationInfo3908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ApplicationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getText3909;
		public override global::java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getText3909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getText3909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivity3910;
		public override global::android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._resolveActivity3910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._resolveActivity3910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable3911;
		public override global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getDrawable3911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getDrawable3911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getXml3912;
		public override global::android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getXml3912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getXml3912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _currentToCanonicalPackageNames3913;
		public override global::java.lang.String[] currentToCanonicalPackageNames(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._currentToCanonicalPackageNames3913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._currentToCanonicalPackageNames3913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _canonicalToCurrentPackageNames3914;
		public override global::java.lang.String[] canonicalToCurrentPackageNames(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._canonicalToCurrentPackageNames3914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._canonicalToCurrentPackageNames3914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getLaunchIntentForPackage3915;
		public override global::android.content.Intent getLaunchIntentForPackage(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getLaunchIntentForPackage3915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getLaunchIntentForPackage3915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageGids3916;
		public override int[] getPackageGids(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPackageGids3916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPackageGids3916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionInfo3917;
		public override global::android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPermissionInfo3917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPermissionInfo3917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryPermissionsByGroup3918;
		public override global::java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryPermissionsByGroup3918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryPermissionsByGroup3918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionGroupInfo3919;
		public override global::android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPermissionGroupInfo3919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionGroupInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPermissionGroupInfo3919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionGroupInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAllPermissionGroups3920;
		public override global::java.util.List getAllPermissionGroups(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getAllPermissionGroups3920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getAllPermissionGroups3920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityInfo3921;
		public override global::android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getActivityInfo3921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getActivityInfo3921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getReceiverInfo3922;
		public override global::android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getReceiverInfo3922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getReceiverInfo3922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getServiceInfo3923;
		public override global::android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getServiceInfo3923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ServiceInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getServiceInfo3923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ServiceInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledPackages3924;
		public override global::java.util.List getInstalledPackages(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getInstalledPackages3924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getInstalledPackages3924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPermission3925;
		public override bool addPermission(android.content.pm.PermissionInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_._addPermission3925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._addPermission3925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPermissionAsync3926;
		public override bool addPermissionAsync(android.content.pm.PermissionInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_._addPermissionAsync3926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._addPermissionAsync3926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePermission3927;
		public override void removePermission(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._removePermission3927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._removePermission3927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures3928;
		public override int checkSignatures(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._checkSignatures3928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._checkSignatures3928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures3929;
		public override int checkSignatures(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._checkSignatures3929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._checkSignatures3929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackagesForUid3930;
		public override global::java.lang.String[] getPackagesForUid(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPackagesForUid3930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPackagesForUid3930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getNameForUid3931;
		public override global::java.lang.String getNameForUid(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getNameForUid3931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getNameForUid3931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledApplications3932;
		public override global::java.util.List getInstalledApplications(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getInstalledApplications3932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getInstalledApplications3932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemSharedLibraryNames3933;
		public override global::java.lang.String[] getSystemSharedLibraryNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getSystemSharedLibraryNames3933)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getSystemSharedLibraryNames3933)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSystemAvailableFeatures3934;
		public override global::android.content.pm.FeatureInfo[] getSystemAvailableFeatures()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getSystemAvailableFeatures3934)) as android.content.pm.FeatureInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getSystemAvailableFeatures3934)) as android.content.pm.FeatureInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _hasSystemFeature3935;
		public override bool hasSystemFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_._hasSystemFeature3935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._hasSystemFeature3935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivities3936;
		public override global::java.util.List queryIntentActivities(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryIntentActivities3936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryIntentActivities3936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivityOptions3937;
		public override global::java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryIntentActivityOptions3937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryIntentActivityOptions3937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryBroadcastReceivers3938;
		public override global::java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryBroadcastReceivers3938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryBroadcastReceivers3938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveService3939;
		public override global::android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._resolveService3939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._resolveService3939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentServices3940;
		public override global::java.util.List queryIntentServices(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryIntentServices3940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryIntentServices3940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveContentProvider3941;
		public override global::android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.pm.ProviderInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._resolveContentProvider3941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ProviderInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.pm.ProviderInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._resolveContentProvider3941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ProviderInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryContentProviders3942;
		public override global::java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryContentProviders3942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryContentProviders3942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getInstrumentationInfo3943;
		public override global::android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getInstrumentationInfo3943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.InstrumentationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getInstrumentationInfo3943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.InstrumentationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryInstrumentation3944;
		public override global::java.util.List queryInstrumentation(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryInstrumentation3944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryInstrumentation3944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon3945;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getActivityIcon3945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getActivityIcon3945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon3946;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getActivityIcon3946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getActivityIcon3946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultActivityIcon3947;
		public override global::android.graphics.drawable.Drawable getDefaultActivityIcon()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getDefaultActivityIcon3947)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getDefaultActivityIcon3947)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon3948;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationIcon3948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationIcon3948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon3949;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationIcon3949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationIcon3949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationLabel3950;
		public override global::java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationLabel3950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationLabel3950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForActivity3951;
		public override global::android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getResourcesForActivity3951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getResourcesForActivity3951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication3952;
		public override global::android.content.res.Resources getResourcesForApplication(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getResourcesForApplication3952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getResourcesForApplication3952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication3953;
		public override global::android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getResourcesForApplication3953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getResourcesForApplication3953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getInstallerPackageName3954;
		public override global::java.lang.String getInstallerPackageName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getInstallerPackageName3954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getInstallerPackageName3954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addPackageToPreferred3955;
		public override void addPackageToPreferred(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._addPackageToPreferred3955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._addPackageToPreferred3955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePackageFromPreferred3956;
		public override void removePackageFromPreferred(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._removePackageFromPreferred3956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._removePackageFromPreferred3956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredPackages3957;
		public override global::java.util.List getPreferredPackages(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPreferredPackages3957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPreferredPackages3957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPreferredActivity3958;
		public override void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._addPreferredActivity3958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._addPreferredActivity3958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clearPackagePreferredActivities3959;
		public override void clearPackagePreferredActivities(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._clearPackagePreferredActivities3959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._clearPackagePreferredActivities3959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredActivities3960;
		public override int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPreferredActivities3960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPreferredActivities3960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setComponentEnabledSetting3961;
		public override void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._setComponentEnabledSetting3961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._setComponentEnabledSetting3961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getComponentEnabledSetting3962;
		public override int getComponentEnabledSetting(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getComponentEnabledSetting3962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getComponentEnabledSetting3962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setApplicationEnabledSetting3963;
		public override void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._setApplicationEnabledSetting3963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._setApplicationEnabledSetting3963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationEnabledSetting3964;
		public override int getApplicationEnabledSetting(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationEnabledSetting3964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationEnabledSetting3964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSafeMode3965;
		public override bool isSafeMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_._isSafeMode3965);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._isSafeMode3965);
		}
		static PackageManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageManager"));
			global::android.content.pm.PackageManager_._checkPermission3906 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager_._getPackageInfo3907 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.content.pm.PackageManager_._getApplicationInfo3908 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.PackageManager_._getText3909 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageManager_._resolveActivity3910 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.content.pm.PackageManager_._getDrawable3911 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getXml3912 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/XmlResourceParser;");
			global::android.content.pm.PackageManager_._currentToCanonicalPackageNames3913 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.pm.PackageManager_._canonicalToCurrentPackageNames3914 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.pm.PackageManager_._getLaunchIntentForPackage3915 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.pm.PackageManager_._getPackageGids3916 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPackageGids", "(Ljava/lang/String;)[I");
			global::android.content.pm.PackageManager_._getPermissionInfo3917 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;");
			global::android.content.pm.PackageManager_._queryPermissionsByGroup3918 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getPermissionGroupInfo3919 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;");
			global::android.content.pm.PackageManager_._getAllPermissionGroups3920 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getAllPermissionGroups", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getActivityInfo3921 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageManager_._getReceiverInfo3922 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageManager_._getServiceInfo3923 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.PackageManager_._getInstalledPackages3924 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getInstalledPackages", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._addPermission3925 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "addPermission", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.content.pm.PackageManager_._addPermissionAsync3926 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.content.pm.PackageManager_._removePermission3927 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "removePermission", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager_._checkSignatures3928 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager_._checkSignatures3929 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "checkSignatures", "(II)I");
			global::android.content.pm.PackageManager_._getPackagesForUid3930 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPackagesForUid", "(I)[Ljava/lang/String;");
			global::android.content.pm.PackageManager_._getNameForUid3931 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getNameForUid", "(I)Ljava/lang/String;");
			global::android.content.pm.PackageManager_._getInstalledApplications3932 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getInstalledApplications", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getSystemSharedLibraryNames3933 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getSystemSharedLibraryNames", "()[Ljava/lang/String;");
			global::android.content.pm.PackageManager_._getSystemAvailableFeatures3934 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;");
			global::android.content.pm.PackageManager_._hasSystemFeature3935 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "hasSystemFeature", "(Ljava/lang/String;)Z");
			global::android.content.pm.PackageManager_._queryIntentActivities3936 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._queryIntentActivityOptions3937 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._queryBroadcastReceivers3938 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._resolveService3939 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.content.pm.PackageManager_._queryIntentServices3940 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._resolveContentProvider3941 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;");
			global::android.content.pm.PackageManager_._queryContentProviders3942 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getInstrumentationInfo3943 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;");
			global::android.content.pm.PackageManager_._queryInstrumentation3944 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getActivityIcon3945 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getActivityIcon3946 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getDefaultActivityIcon3947 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getApplicationIcon3948 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getApplicationIcon3949 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getApplicationLabel3950 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageManager_._getResourcesForActivity3951 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager_._getResourcesForApplication3952 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager_._getResourcesForApplication3953 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager_._getInstallerPackageName3954 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.pm.PackageManager_._addPackageToPreferred3955 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "addPackageToPreferred", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager_._removePackageFromPreferred3956 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "removePackageFromPreferred", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager_._getPreferredPackages3957 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPreferredPackages", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._addPreferredActivity3958 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/ComponentName;)V");
			global::android.content.pm.PackageManager_._clearPackagePreferredActivities3959 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "clearPackagePreferredActivities", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager_._getPreferredActivities3960 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager_._setComponentEnabledSetting3961 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V");
			global::android.content.pm.PackageManager_._getComponentEnabledSetting3962 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getComponentEnabledSetting", "(Landroid/content/ComponentName;)I");
			global::android.content.pm.PackageManager_._setApplicationEnabledSetting3963 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "setApplicationEnabledSetting", "(Ljava/lang/String;II)V");
			global::android.content.pm.PackageManager_._getApplicationEnabledSetting3964 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationEnabledSetting", "(Ljava/lang/String;)I");
			global::android.content.pm.PackageManager_._isSafeMode3965 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "isSafeMode", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
