namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.pm.PackageManager_))]
	public abstract partial class PackageManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PackageManager()
		{
			InitJNI();
		}
		protected PackageManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class NameNotFoundException : android.util.AndroidException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static NameNotFoundException()
			{
				InitJNI();
			}
			protected NameNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _NameNotFoundException1980;
			public NameNotFoundException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageManager.NameNotFoundException.staticClass, global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException1980);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _NameNotFoundException1981;
			public NameNotFoundException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageManager.NameNotFoundException.staticClass, global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException1981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.PackageManager.NameNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageManager$NameNotFoundException"));
				global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException1980 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.NameNotFoundException.staticClass, "<init>", "()V");
				global::android.content.pm.PackageManager.NameNotFoundException._NameNotFoundException1981 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.NameNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission1982;
		public abstract int checkPermission(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getPackageInfo1983;
		public abstract global::android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo1984;
		public abstract global::android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getText1985;
		public abstract global::java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2);
		internal static global::MonoJavaBridge.MethodId _resolveActivity1986;
		public abstract global::android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getDrawable1987;
		public abstract global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2);
		internal static global::MonoJavaBridge.MethodId _getXml1988;
		public abstract global::android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2);
		internal static global::MonoJavaBridge.MethodId _currentToCanonicalPackageNames1989;
		public abstract global::java.lang.String[] currentToCanonicalPackageNames(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _canonicalToCurrentPackageNames1990;
		public abstract global::java.lang.String[] canonicalToCurrentPackageNames(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getLaunchIntentForPackage1991;
		public abstract global::android.content.Intent getLaunchIntentForPackage(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getPackageGids1992;
		public abstract int[] getPackageGids(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getPermissionInfo1993;
		public abstract global::android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryPermissionsByGroup1994;
		public abstract global::java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getPermissionGroupInfo1995;
		public abstract global::android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getAllPermissionGroups1996;
		public abstract global::java.util.List getAllPermissionGroups(int arg0);
		internal static global::MonoJavaBridge.MethodId _getActivityInfo1997;
		public abstract global::android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getReceiverInfo1998;
		public abstract global::android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getServiceInfo1999;
		public abstract global::android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getInstalledPackages2000;
		public abstract global::java.util.List getInstalledPackages(int arg0);
		internal static global::MonoJavaBridge.MethodId _addPermission2001;
		public abstract bool addPermission(android.content.pm.PermissionInfo arg0);
		internal static global::MonoJavaBridge.MethodId _addPermissionAsync2002;
		public abstract bool addPermissionAsync(android.content.pm.PermissionInfo arg0);
		internal static global::MonoJavaBridge.MethodId _removePermission2003;
		public abstract void removePermission(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _checkSignatures2004;
		public abstract int checkSignatures(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _checkSignatures2005;
		public abstract int checkSignatures(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getPackagesForUid2006;
		public abstract global::java.lang.String[] getPackagesForUid(int arg0);
		internal static global::MonoJavaBridge.MethodId _getNameForUid2007;
		public abstract global::java.lang.String getNameForUid(int arg0);
		internal static global::MonoJavaBridge.MethodId _getInstalledApplications2008;
		public abstract global::java.util.List getInstalledApplications(int arg0);
		internal static global::MonoJavaBridge.MethodId _getSystemSharedLibraryNames2009;
		public abstract global::java.lang.String[] getSystemSharedLibraryNames();
		internal static global::MonoJavaBridge.MethodId _getSystemAvailableFeatures2010;
		public abstract global::android.content.pm.FeatureInfo[] getSystemAvailableFeatures();
		internal static global::MonoJavaBridge.MethodId _hasSystemFeature2011;
		public abstract bool hasSystemFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _queryIntentActivities2012;
		public abstract global::java.util.List queryIntentActivities(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryIntentActivityOptions2013;
		public abstract global::java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _queryBroadcastReceivers2014;
		public abstract global::java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _resolveService2015;
		public abstract global::android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryIntentServices2016;
		public abstract global::java.util.List queryIntentServices(android.content.Intent arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _resolveContentProvider2017;
		public abstract global::android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryContentProviders2018;
		public abstract global::java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getInstrumentationInfo2019;
		public abstract global::android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _queryInstrumentation2020;
		public abstract global::java.util.List queryInstrumentation(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getActivityIcon2021;
		public abstract global::android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _getActivityIcon2022;
		public abstract global::android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0);
		internal static global::MonoJavaBridge.MethodId _getDefaultActivityIcon2023;
		public abstract global::android.graphics.drawable.Drawable getDefaultActivityIcon();
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon2024;
		public abstract global::android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0);
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon2025;
		public abstract global::android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getApplicationLabel2026;
		public abstract global::java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0);
		internal static global::MonoJavaBridge.MethodId _getResourcesForActivity2027;
		public abstract global::android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0);
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication2028;
		public abstract global::android.content.res.Resources getResourcesForApplication(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication2029;
		public abstract global::android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0);
		internal static global::MonoJavaBridge.MethodId _getPackageArchiveInfo2030;
		public virtual global::android.content.pm.PackageInfo getPackageArchiveInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager._getPackageArchiveInfo2030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager.staticClass, global::android.content.pm.PackageManager._getPackageArchiveInfo2030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstallerPackageName2031;
		public abstract global::java.lang.String getInstallerPackageName(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _addPackageToPreferred2032;
		public abstract void addPackageToPreferred(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _removePackageFromPreferred2033;
		public abstract void removePackageFromPreferred(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getPreferredPackages2034;
		public abstract global::java.util.List getPreferredPackages(int arg0);
		internal static global::MonoJavaBridge.MethodId _addPreferredActivity2035;
		public abstract void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3);
		internal static global::MonoJavaBridge.MethodId _clearPackagePreferredActivities2036;
		public abstract void clearPackagePreferredActivities(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getPreferredActivities2037;
		public abstract int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2);
		internal static global::MonoJavaBridge.MethodId _setComponentEnabledSetting2038;
		public abstract void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getComponentEnabledSetting2039;
		public abstract int getComponentEnabledSetting(android.content.ComponentName arg0);
		internal static global::MonoJavaBridge.MethodId _setApplicationEnabledSetting2040;
		public abstract void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getApplicationEnabledSetting2041;
		public abstract int getApplicationEnabledSetting(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _isSafeMode2042;
		public abstract bool isSafeMode();
		internal static global::MonoJavaBridge.MethodId _PackageManager2043;
		public PackageManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageManager.staticClass, global::android.content.pm.PackageManager._PackageManager2043);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageManager"));
			global::android.content.pm.PackageManager._checkPermission1982 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager._getPackageInfo1983 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.content.pm.PackageManager._getApplicationInfo1984 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.PackageManager._getText1985 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageManager._resolveActivity1986 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.content.pm.PackageManager._getDrawable1987 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getXml1988 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/XmlResourceParser;");
			global::android.content.pm.PackageManager._currentToCanonicalPackageNames1989 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.pm.PackageManager._canonicalToCurrentPackageNames1990 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.pm.PackageManager._getLaunchIntentForPackage1991 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.pm.PackageManager._getPackageGids1992 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPackageGids", "(Ljava/lang/String;)[I");
			global::android.content.pm.PackageManager._getPermissionInfo1993 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;");
			global::android.content.pm.PackageManager._queryPermissionsByGroup1994 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._getPermissionGroupInfo1995 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;");
			global::android.content.pm.PackageManager._getAllPermissionGroups1996 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getAllPermissionGroups", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager._getActivityInfo1997 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageManager._getReceiverInfo1998 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageManager._getServiceInfo1999 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.PackageManager._getInstalledPackages2000 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getInstalledPackages", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager._addPermission2001 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "addPermission", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.content.pm.PackageManager._addPermissionAsync2002 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.content.pm.PackageManager._removePermission2003 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "removePermission", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager._checkSignatures2004 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager._checkSignatures2005 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "checkSignatures", "(II)I");
			global::android.content.pm.PackageManager._getPackagesForUid2006 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPackagesForUid", "(I)[Ljava/lang/String;");
			global::android.content.pm.PackageManager._getNameForUid2007 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getNameForUid", "(I)Ljava/lang/String;");
			global::android.content.pm.PackageManager._getInstalledApplications2008 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getInstalledApplications", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager._getSystemSharedLibraryNames2009 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getSystemSharedLibraryNames", "()[Ljava/lang/String;");
			global::android.content.pm.PackageManager._getSystemAvailableFeatures2010 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;");
			global::android.content.pm.PackageManager._hasSystemFeature2011 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "hasSystemFeature", "(Ljava/lang/String;)Z");
			global::android.content.pm.PackageManager._queryIntentActivities2012 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._queryIntentActivityOptions2013 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._queryBroadcastReceivers2014 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._resolveService2015 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.content.pm.PackageManager._queryIntentServices2016 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._resolveContentProvider2017 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;");
			global::android.content.pm.PackageManager._queryContentProviders2018 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;");
			global::android.content.pm.PackageManager._getInstrumentationInfo2019 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;");
			global::android.content.pm.PackageManager._queryInstrumentation2020 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.content.pm.PackageManager._getActivityIcon2021 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getActivityIcon2022 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getDefaultActivityIcon2023 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getApplicationIcon2024 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getApplicationIcon2025 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager._getApplicationLabel2026 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageManager._getResourcesForActivity2027 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager._getResourcesForApplication2028 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager._getResourcesForApplication2029 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager._getPackageArchiveInfo2030 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.content.pm.PackageManager._getInstallerPackageName2031 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.pm.PackageManager._addPackageToPreferred2032 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "addPackageToPreferred", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager._removePackageFromPreferred2033 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "removePackageFromPreferred", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager._getPreferredPackages2034 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPreferredPackages", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager._addPreferredActivity2035 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/ComponentName;)V");
			global::android.content.pm.PackageManager._clearPackagePreferredActivities2036 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "clearPackagePreferredActivities", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager._getPreferredActivities2037 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager._setComponentEnabledSetting2038 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V");
			global::android.content.pm.PackageManager._getComponentEnabledSetting2039 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getComponentEnabledSetting", "(Landroid/content/ComponentName;)I");
			global::android.content.pm.PackageManager._setApplicationEnabledSetting2040 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "setApplicationEnabledSetting", "(Ljava/lang/String;II)V");
			global::android.content.pm.PackageManager._getApplicationEnabledSetting2041 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "getApplicationEnabledSetting", "(Ljava/lang/String;)I");
			global::android.content.pm.PackageManager._isSafeMode2042 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "isSafeMode", "()Z");
			global::android.content.pm.PackageManager._PackageManager2043 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.pm.PackageManager))]
	public sealed partial class PackageManager_ : android.content.pm.PackageManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PackageManager_()
		{
			InitJNI();
		}
		internal PackageManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission2044;
		public override int checkPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._checkPermission2044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._checkPermission2044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackageInfo2045;
		public override global::android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPackageInfo2045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPackageInfo2045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PackageInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo2046;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationInfo2046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ApplicationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationInfo2046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ApplicationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getText2047;
		public override global::java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getText2047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getText2047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivity2048;
		public override global::android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._resolveActivity2048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._resolveActivity2048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable2049;
		public override global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getDrawable2049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getDrawable2049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getXml2050;
		public override global::android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getXml2050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getXml2050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _currentToCanonicalPackageNames2051;
		public override global::java.lang.String[] currentToCanonicalPackageNames(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._currentToCanonicalPackageNames2051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._currentToCanonicalPackageNames2051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _canonicalToCurrentPackageNames2052;
		public override global::java.lang.String[] canonicalToCurrentPackageNames(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._canonicalToCurrentPackageNames2052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._canonicalToCurrentPackageNames2052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getLaunchIntentForPackage2053;
		public override global::android.content.Intent getLaunchIntentForPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getLaunchIntentForPackage2053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getLaunchIntentForPackage2053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageGids2054;
		public override int[] getPackageGids(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPackageGids2054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPackageGids2054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionInfo2055;
		public override global::android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPermissionInfo2055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPermissionInfo2055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryPermissionsByGroup2056;
		public override global::java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryPermissionsByGroup2056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryPermissionsByGroup2056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissionGroupInfo2057;
		public override global::android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPermissionGroupInfo2057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionGroupInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPermissionGroupInfo2057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.PermissionGroupInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getAllPermissionGroups2058;
		public override global::java.util.List getAllPermissionGroups(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getAllPermissionGroups2058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getAllPermissionGroups2058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityInfo2059;
		public override global::android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getActivityInfo2059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getActivityInfo2059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getReceiverInfo2060;
		public override global::android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getReceiverInfo2060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getReceiverInfo2060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getServiceInfo2061;
		public override global::android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getServiceInfo2061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ServiceInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getServiceInfo2061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ServiceInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledPackages2062;
		public override global::java.util.List getInstalledPackages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getInstalledPackages2062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getInstalledPackages2062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPermission2063;
		public override bool addPermission(android.content.pm.PermissionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_._addPermission2063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._addPermission2063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addPermissionAsync2064;
		public override bool addPermissionAsync(android.content.pm.PermissionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_._addPermissionAsync2064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._addPermissionAsync2064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePermission2065;
		public override void removePermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._removePermission2065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._removePermission2065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures2066;
		public override int checkSignatures(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._checkSignatures2066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._checkSignatures2066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkSignatures2067;
		public override int checkSignatures(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._checkSignatures2067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._checkSignatures2067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPackagesForUid2068;
		public override global::java.lang.String[] getPackagesForUid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPackagesForUid2068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPackagesForUid2068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getNameForUid2069;
		public override global::java.lang.String getNameForUid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getNameForUid2069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getNameForUid2069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstalledApplications2070;
		public override global::java.util.List getInstalledApplications(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getInstalledApplications2070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getInstalledApplications2070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemSharedLibraryNames2071;
		public override global::java.lang.String[] getSystemSharedLibraryNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getSystemSharedLibraryNames2071)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getSystemSharedLibraryNames2071)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSystemAvailableFeatures2072;
		public override global::android.content.pm.FeatureInfo[] getSystemAvailableFeatures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getSystemAvailableFeatures2072)) as android.content.pm.FeatureInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.pm.FeatureInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getSystemAvailableFeatures2072)) as android.content.pm.FeatureInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _hasSystemFeature2073;
		public override bool hasSystemFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_._hasSystemFeature2073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._hasSystemFeature2073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivities2074;
		public override global::java.util.List queryIntentActivities(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryIntentActivities2074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryIntentActivities2074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentActivityOptions2075;
		public override global::java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryIntentActivityOptions2075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryIntentActivityOptions2075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _queryBroadcastReceivers2076;
		public override global::java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryBroadcastReceivers2076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryBroadcastReceivers2076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveService2077;
		public override global::android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._resolveService2077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._resolveService2077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ResolveInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryIntentServices2078;
		public override global::java.util.List queryIntentServices(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryIntentServices2078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryIntentServices2078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _resolveContentProvider2079;
		public override global::android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._resolveContentProvider2079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ProviderInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._resolveContentProvider2079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ProviderInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryContentProviders2080;
		public override global::java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryContentProviders2080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryContentProviders2080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getInstrumentationInfo2081;
		public override global::android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getInstrumentationInfo2081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.InstrumentationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getInstrumentationInfo2081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.InstrumentationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _queryInstrumentation2082;
		public override global::java.util.List queryInstrumentation(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._queryInstrumentation2082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._queryInstrumentation2082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon2083;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getActivityIcon2083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getActivityIcon2083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getActivityIcon2084;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getActivityIcon2084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getActivityIcon2084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultActivityIcon2085;
		public override global::android.graphics.drawable.Drawable getDefaultActivityIcon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getDefaultActivityIcon2085)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getDefaultActivityIcon2085)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon2086;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationIcon2086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationIcon2086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationIcon2087;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationIcon2087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationIcon2087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationLabel2088;
		public override global::java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationLabel2088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationLabel2088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForActivity2089;
		public override global::android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getResourcesForActivity2089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getResourcesForActivity2089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication2090;
		public override global::android.content.res.Resources getResourcesForApplication(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getResourcesForApplication2090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getResourcesForApplication2090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getResourcesForApplication2091;
		public override global::android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getResourcesForApplication2091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getResourcesForApplication2091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getInstallerPackageName2092;
		public override global::java.lang.String getInstallerPackageName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getInstallerPackageName2092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getInstallerPackageName2092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addPackageToPreferred2093;
		public override void addPackageToPreferred(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._addPackageToPreferred2093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._addPackageToPreferred2093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removePackageFromPreferred2094;
		public override void removePackageFromPreferred(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._removePackageFromPreferred2094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._removePackageFromPreferred2094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredPackages2095;
		public override global::java.util.List getPreferredPackages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPreferredPackages2095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPreferredPackages2095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _addPreferredActivity2096;
		public override void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._addPreferredActivity2096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._addPreferredActivity2096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _clearPackagePreferredActivities2097;
		public override void clearPackagePreferredActivities(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._clearPackagePreferredActivities2097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._clearPackagePreferredActivities2097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPreferredActivities2098;
		public override int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getPreferredActivities2098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getPreferredActivities2098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setComponentEnabledSetting2099;
		public override void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._setComponentEnabledSetting2099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._setComponentEnabledSetting2099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getComponentEnabledSetting2100;
		public override int getComponentEnabledSetting(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getComponentEnabledSetting2100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getComponentEnabledSetting2100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setApplicationEnabledSetting2101;
		public override void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_._setApplicationEnabledSetting2101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._setApplicationEnabledSetting2101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationEnabledSetting2102;
		public override int getApplicationEnabledSetting(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_._getApplicationEnabledSetting2102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._getApplicationEnabledSetting2102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSafeMode2103;
		public override bool isSafeMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_._isSafeMode2103);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.PackageManager_.staticClass, global::android.content.pm.PackageManager_._isSafeMode2103);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageManager"));
			global::android.content.pm.PackageManager_._checkPermission2044 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager_._getPackageInfo2045 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;");
			global::android.content.pm.PackageManager_._getApplicationInfo2046 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;");
			global::android.content.pm.PackageManager_._getText2047 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageManager_._resolveActivity2048 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.content.pm.PackageManager_._getDrawable2049 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getXml2050 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/XmlResourceParser;");
			global::android.content.pm.PackageManager_._currentToCanonicalPackageNames2051 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.pm.PackageManager_._canonicalToCurrentPackageNames2052 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.pm.PackageManager_._getLaunchIntentForPackage2053 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.pm.PackageManager_._getPackageGids2054 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPackageGids", "(Ljava/lang/String;)[I");
			global::android.content.pm.PackageManager_._getPermissionInfo2055 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;");
			global::android.content.pm.PackageManager_._queryPermissionsByGroup2056 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getPermissionGroupInfo2057 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;");
			global::android.content.pm.PackageManager_._getAllPermissionGroups2058 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getAllPermissionGroups", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getActivityInfo2059 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageManager_._getReceiverInfo2060 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.pm.PackageManager_._getServiceInfo2061 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;");
			global::android.content.pm.PackageManager_._getInstalledPackages2062 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getInstalledPackages", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._addPermission2063 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "addPermission", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.content.pm.PackageManager_._addPermissionAsync2064 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z");
			global::android.content.pm.PackageManager_._removePermission2065 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "removePermission", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager_._checkSignatures2066 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager_._checkSignatures2067 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "checkSignatures", "(II)I");
			global::android.content.pm.PackageManager_._getPackagesForUid2068 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPackagesForUid", "(I)[Ljava/lang/String;");
			global::android.content.pm.PackageManager_._getNameForUid2069 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getNameForUid", "(I)Ljava/lang/String;");
			global::android.content.pm.PackageManager_._getInstalledApplications2070 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getInstalledApplications", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getSystemSharedLibraryNames2071 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getSystemSharedLibraryNames", "()[Ljava/lang/String;");
			global::android.content.pm.PackageManager_._getSystemAvailableFeatures2072 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;");
			global::android.content.pm.PackageManager_._hasSystemFeature2073 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "hasSystemFeature", "(Ljava/lang/String;)Z");
			global::android.content.pm.PackageManager_._queryIntentActivities2074 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._queryIntentActivityOptions2075 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._queryBroadcastReceivers2076 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._resolveService2077 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;");
			global::android.content.pm.PackageManager_._queryIntentServices2078 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._resolveContentProvider2079 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;");
			global::android.content.pm.PackageManager_._queryContentProviders2080 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getInstrumentationInfo2081 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;");
			global::android.content.pm.PackageManager_._queryInstrumentation2082 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._getActivityIcon2083 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getActivityIcon2084 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getDefaultActivityIcon2085 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getApplicationIcon2086 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getApplicationIcon2087 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageManager_._getApplicationLabel2088 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageManager_._getResourcesForActivity2089 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager_._getResourcesForApplication2090 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager_._getResourcesForApplication2091 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;");
			global::android.content.pm.PackageManager_._getInstallerPackageName2092 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.pm.PackageManager_._addPackageToPreferred2093 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "addPackageToPreferred", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager_._removePackageFromPreferred2094 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "removePackageFromPreferred", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager_._getPreferredPackages2095 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPreferredPackages", "(I)Ljava/util/List;");
			global::android.content.pm.PackageManager_._addPreferredActivity2096 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/ComponentName;)V");
			global::android.content.pm.PackageManager_._clearPackagePreferredActivities2097 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "clearPackagePreferredActivities", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageManager_._getPreferredActivities2098 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I");
			global::android.content.pm.PackageManager_._setComponentEnabledSetting2099 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V");
			global::android.content.pm.PackageManager_._getComponentEnabledSetting2100 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getComponentEnabledSetting", "(Landroid/content/ComponentName;)I");
			global::android.content.pm.PackageManager_._setApplicationEnabledSetting2101 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "setApplicationEnabledSetting", "(Ljava/lang/String;II)V");
			global::android.content.pm.PackageManager_._getApplicationEnabledSetting2102 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "getApplicationEnabledSetting", "(Ljava/lang/String;)I");
			global::android.content.pm.PackageManager_._isSafeMode2103 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager_.staticClass, "isSafeMode", "()Z");
		}
	}
}
