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
			private static global::MonoJavaBridge.MethodId _m0;
			public NameNotFoundException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.pm.PackageManager.NameNotFoundException._m0.native == global::System.IntPtr.Zero)
					global::android.content.pm.PackageManager.NameNotFoundException._m0 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.NameNotFoundException.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageManager.NameNotFoundException.staticClass, global::android.content.pm.PackageManager.NameNotFoundException._m0);
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public NameNotFoundException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.pm.PackageManager.NameNotFoundException._m1.native == global::System.IntPtr.Zero)
					global::android.content.pm.PackageManager.NameNotFoundException._m1 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.NameNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageManager.NameNotFoundException.staticClass, global::android.content.pm.PackageManager.NameNotFoundException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static NameNotFoundException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.PackageManager.NameNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageManager$NameNotFoundException"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract int checkPermission(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.lang.String[] currentToCanonicalPackageNames(java.lang.String[] arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.lang.String[] canonicalToCurrentPackageNames(java.lang.String[] arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::android.content.Intent getLaunchIntentForPackage(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract int[] getPackageGids(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract global::android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract global::java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract global::java.util.List getAllPermissionGroups(int arg0);
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract global::android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract global::android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract global::android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract global::java.util.List getInstalledPackages(int arg0);
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract bool addPermission(android.content.pm.PermissionInfo arg0);
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract bool addPermissionAsync(android.content.pm.PermissionInfo arg0);
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract void removePermission(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract int checkSignatures(java.lang.String arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract int checkSignatures(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.lang.String[] getPackagesForUid(int arg0);
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract global::java.lang.String getNameForUid(int arg0);
		private static global::MonoJavaBridge.MethodId _m26;
		public abstract global::java.util.List getInstalledApplications(int arg0);
		private static global::MonoJavaBridge.MethodId _m27;
		public abstract global::java.lang.String[] getSystemSharedLibraryNames();
		private static global::MonoJavaBridge.MethodId _m28;
		public abstract global::android.content.pm.FeatureInfo[] getSystemAvailableFeatures();
		private static global::MonoJavaBridge.MethodId _m29;
		public abstract bool hasSystemFeature(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m30;
		public abstract global::java.util.List queryIntentActivities(android.content.Intent arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m31;
		public abstract global::java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3);
		private static global::MonoJavaBridge.MethodId _m32;
		public abstract global::java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m33;
		public abstract global::android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m34;
		public abstract global::java.util.List queryIntentServices(android.content.Intent arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m35;
		public abstract global::android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m36;
		public abstract global::java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m37;
		public abstract global::android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m38;
		public abstract global::java.util.List queryInstrumentation(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m39;
		public abstract global::android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0);
		private static global::MonoJavaBridge.MethodId _m40;
		public abstract global::android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0);
		private static global::MonoJavaBridge.MethodId _m41;
		public abstract global::android.graphics.drawable.Drawable getDefaultActivityIcon();
		private static global::MonoJavaBridge.MethodId _m42;
		public abstract global::android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0);
		private static global::MonoJavaBridge.MethodId _m43;
		public abstract global::android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m44;
		public abstract global::java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0);
		private static global::MonoJavaBridge.MethodId _m45;
		public abstract global::android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0);
		private static global::MonoJavaBridge.MethodId _m46;
		public abstract global::android.content.res.Resources getResourcesForApplication(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m47;
		public abstract global::android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0);
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual global::android.content.pm.PackageInfo getPackageArchiveInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager.staticClass, "getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", ref global::android.content.pm.PackageManager._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.PackageInfo;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public abstract global::java.lang.String getInstallerPackageName(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m50;
		public abstract void addPackageToPreferred(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m51;
		public abstract void removePackageFromPreferred(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m52;
		public abstract global::java.util.List getPreferredPackages(int arg0);
		private static global::MonoJavaBridge.MethodId _m53;
		public abstract void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3);
		private static global::MonoJavaBridge.MethodId _m54;
		public abstract void clearPackagePreferredActivities(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m55;
		public abstract int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2);
		private static global::MonoJavaBridge.MethodId _m56;
		public abstract void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m57;
		public abstract int getComponentEnabledSetting(android.content.ComponentName arg0);
		private static global::MonoJavaBridge.MethodId _m58;
		public abstract void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m59;
		public abstract int getApplicationEnabledSetting(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m60;
		public abstract bool isSafeMode();
		private static global::MonoJavaBridge.MethodId _m61;
		public PackageManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageManager._m61.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageManager._m61 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageManager.staticClass, global::android.content.pm.PackageManager._m61);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override int checkPermission(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageManager_.staticClass, "checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::android.content.pm.PackageManager_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::android.content.pm.PackageInfo getPackageInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", ref global::android.content.pm.PackageManager_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.PackageInfo;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;", ref global::android.content.pm.PackageManager_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.ApplicationInfo;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.CharSequence getText(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.PackageManager_.staticClass, "getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;", ref global::android.content.pm.PackageManager_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::android.content.pm.ResolveInfo resolveActivity(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", ref global::android.content.pm.PackageManager_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.ResolveInfo;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", ref global::android.content.pm.PackageManager_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::android.content.res.XmlResourceParser getXml(java.lang.String arg0, int arg1, android.content.pm.ApplicationInfo arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.pm.PackageManager_.staticClass, "getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/XmlResourceParser;", ref global::android.content.pm.PackageManager_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.content.res.XmlResourceParser;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.lang.String[] currentToCanonicalPackageNames(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.pm.PackageManager_.staticClass, "currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", ref global::android.content.pm.PackageManager_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.lang.String[] canonicalToCurrentPackageNames(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.pm.PackageManager_.staticClass, "canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", ref global::android.content.pm.PackageManager_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::android.content.Intent getLaunchIntentForPackage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;", ref global::android.content.pm.PackageManager_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int[] getPackageGids(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.content.pm.PackageManager_.staticClass, "getPackageGids", "(Ljava/lang/String;)[I", ref global::android.content.pm.PackageManager_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::android.content.pm.PermissionInfo getPermissionInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;", ref global::android.content.pm.PackageManager_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.PermissionInfo;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.util.List queryPermissionsByGroup(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::android.content.pm.PermissionGroupInfo getPermissionGroupInfo(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;", ref global::android.content.pm.PackageManager_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.PermissionGroupInfo;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::java.util.List getAllPermissionGroups(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "getAllPermissionGroups", "(I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::android.content.pm.ActivityInfo getActivityInfo(android.content.ComponentName arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", ref global::android.content.pm.PackageManager_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.ActivityInfo;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::android.content.pm.ActivityInfo getReceiverInfo(android.content.ComponentName arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", ref global::android.content.pm.PackageManager_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.ActivityInfo;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::android.content.pm.ServiceInfo getServiceInfo(android.content.ComponentName arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;", ref global::android.content.pm.PackageManager_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.ServiceInfo;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::java.util.List getInstalledPackages(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "getInstalledPackages", "(I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override bool addPermission(android.content.pm.PermissionInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.pm.PackageManager_.staticClass, "addPermission", "(Landroid/content/pm/PermissionInfo;)Z", ref global::android.content.pm.PackageManager_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override bool addPermissionAsync(android.content.pm.PermissionInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.pm.PackageManager_.staticClass, "addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z", ref global::android.content.pm.PackageManager_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override void removePermission(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageManager_.staticClass, "removePermission", "(Ljava/lang/String;)V", ref global::android.content.pm.PackageManager_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override int checkSignatures(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageManager_.staticClass, "checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I", ref global::android.content.pm.PackageManager_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override int checkSignatures(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageManager_.staticClass, "checkSignatures", "(II)I", ref global::android.content.pm.PackageManager_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override global::java.lang.String[] getPackagesForUid(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.pm.PackageManager_.staticClass, "getPackagesForUid", "(I)[Ljava/lang/String;", ref global::android.content.pm.PackageManager_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override global::java.lang.String getNameForUid(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PackageManager_.staticClass, "getNameForUid", "(I)Ljava/lang/String;", ref global::android.content.pm.PackageManager_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override global::java.util.List getInstalledApplications(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "getInstalledApplications", "(I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override global::java.lang.String[] getSystemSharedLibraryNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.pm.PackageManager_.staticClass, "getSystemSharedLibraryNames", "()[Ljava/lang/String;", ref global::android.content.pm.PackageManager_._m27) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override global::android.content.pm.FeatureInfo[] getSystemAvailableFeatures()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.content.pm.FeatureInfo>(this, global::android.content.pm.PackageManager_.staticClass, "getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;", ref global::android.content.pm.PackageManager_._m28) as android.content.pm.FeatureInfo[];
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override bool hasSystemFeature(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.pm.PackageManager_.staticClass, "hasSystemFeature", "(Ljava/lang/String;)Z", ref global::android.content.pm.PackageManager_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override global::java.util.List queryIntentActivities(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override global::java.util.List queryIntentActivityOptions(android.content.ComponentName arg0, android.content.Intent[] arg1, android.content.Intent arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override global::java.util.List queryBroadcastReceivers(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public override global::android.content.pm.ResolveInfo resolveService(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", ref global::android.content.pm.PackageManager_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.ResolveInfo;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public override global::java.util.List queryIntentServices(android.content.Intent arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public override global::android.content.pm.ProviderInfo resolveContentProvider(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.pm.ProviderInfo>(this, global::android.content.pm.PackageManager_.staticClass, "resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;", ref global::android.content.pm.PackageManager_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.ProviderInfo;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public override global::java.util.List queryContentProviders(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public override global::android.content.pm.InstrumentationInfo getInstrumentationInfo(android.content.ComponentName arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;", ref global::android.content.pm.PackageManager_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.pm.InstrumentationInfo;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public override global::java.util.List queryInstrumentation(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", ref global::android.content.pm.PackageManager_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public override global::android.graphics.drawable.Drawable getActivityIcon(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", ref global::android.content.pm.PackageManager_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public override global::android.graphics.drawable.Drawable getDefaultActivityIcon()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;", ref global::android.content.pm.PackageManager_._m41) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(android.content.pm.ApplicationInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", ref global::android.content.pm.PackageManager_._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public override global::android.graphics.drawable.Drawable getApplicationIcon(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", ref global::android.content.pm.PackageManager_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public override global::java.lang.CharSequence getApplicationLabel(android.content.pm.ApplicationInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.pm.PackageManager_.staticClass, "getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;", ref global::android.content.pm.PackageManager_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public override global::android.content.res.Resources getResourcesForActivity(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;", ref global::android.content.pm.PackageManager_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.Resources;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public override global::android.content.res.Resources getResourcesForApplication(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;", ref global::android.content.pm.PackageManager_._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.Resources;
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public override global::android.content.res.Resources getResourcesForApplication(android.content.pm.ApplicationInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.PackageManager_.staticClass, "getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;", ref global::android.content.pm.PackageManager_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.Resources;
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public override global::java.lang.String getInstallerPackageName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PackageManager_.staticClass, "getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.pm.PackageManager_._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public override void addPackageToPreferred(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageManager_.staticClass, "addPackageToPreferred", "(Ljava/lang/String;)V", ref global::android.content.pm.PackageManager_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public override void removePackageFromPreferred(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageManager_.staticClass, "removePackageFromPreferred", "(Ljava/lang/String;)V", ref global::android.content.pm.PackageManager_._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public override global::java.util.List getPreferredPackages(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.content.pm.PackageManager_.staticClass, "getPreferredPackages", "(I)Ljava/util/List;", ref global::android.content.pm.PackageManager_._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public override void addPreferredActivity(android.content.IntentFilter arg0, int arg1, android.content.ComponentName[] arg2, android.content.ComponentName arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageManager_.staticClass, "addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/ComponentName;)V", ref global::android.content.pm.PackageManager_._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public override void clearPackagePreferredActivities(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageManager_.staticClass, "clearPackagePreferredActivities", "(Ljava/lang/String;)V", ref global::android.content.pm.PackageManager_._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public override int getPreferredActivities(java.util.List arg0, java.util.List arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageManager_.staticClass, "getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I", ref global::android.content.pm.PackageManager_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public override void setComponentEnabledSetting(android.content.ComponentName arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageManager_.staticClass, "setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V", ref global::android.content.pm.PackageManager_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public override int getComponentEnabledSetting(android.content.ComponentName arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageManager_.staticClass, "getComponentEnabledSetting", "(Landroid/content/ComponentName;)I", ref global::android.content.pm.PackageManager_._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public override void setApplicationEnabledSetting(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageManager_.staticClass, "setApplicationEnabledSetting", "(Ljava/lang/String;II)V", ref global::android.content.pm.PackageManager_._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public override int getApplicationEnabledSetting(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageManager_.staticClass, "getApplicationEnabledSetting", "(Ljava/lang/String;)I", ref global::android.content.pm.PackageManager_._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public override bool isSafeMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.pm.PackageManager_.staticClass, "isSafeMode", "()Z", ref global::android.content.pm.PackageManager_._m59);
		}
		static PackageManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
