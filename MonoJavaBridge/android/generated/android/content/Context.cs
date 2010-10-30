namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.Context_))]
	public abstract partial class Context : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Context(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader2811;
		public abstract global::java.lang.ClassLoader getClassLoader();
		internal static global::MonoJavaBridge.MethodId _checkPermission2812;
		public abstract int checkPermission(java.lang.String arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getResources2813;
		public abstract global::android.content.res.Resources getResources();
		internal static global::MonoJavaBridge.MethodId _getPackageName2814;
		public abstract global::java.lang.String getPackageName();
		internal static global::MonoJavaBridge.MethodId _getString2815;
		public virtual global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.content.Context._getString2815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString2816;
		public virtual global::java.lang.String getString(int arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", ref global::android.content.Context._getString2816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAssets2817;
		public abstract global::android.content.res.AssetManager getAssets();
		internal static global::MonoJavaBridge.MethodId _getPackageManager2818;
		public abstract global::android.content.pm.PackageManager getPackageManager();
		internal static global::MonoJavaBridge.MethodId _getContentResolver2819;
		public abstract global::android.content.ContentResolver getContentResolver();
		internal static global::MonoJavaBridge.MethodId _getMainLooper2820;
		public abstract global::android.os.Looper getMainLooper();
		internal static global::MonoJavaBridge.MethodId _getApplicationContext2821;
		public abstract global::android.content.Context getApplicationContext();
		internal static global::MonoJavaBridge.MethodId _setTheme2822;
		public abstract void setTheme(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTheme2823;
		public abstract global::android.content.res.Resources.Theme getTheme();
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo2824;
		public abstract global::android.content.pm.ApplicationInfo getApplicationInfo();
		internal static global::MonoJavaBridge.MethodId _getPackageResourcePath2825;
		public abstract global::java.lang.String getPackageResourcePath();
		internal static global::MonoJavaBridge.MethodId _getPackageCodePath2826;
		public abstract global::java.lang.String getPackageCodePath();
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences2827;
		public abstract global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _openFileInput2828;
		public abstract global::java.io.FileInputStream openFileInput(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _openFileOutput2829;
		public abstract global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _deleteFile2830;
		public abstract bool deleteFile(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath2831;
		public abstract global::java.io.File getFileStreamPath(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _fileList2832;
		public abstract global::java.lang.String[] fileList();
		internal static global::MonoJavaBridge.MethodId _getFilesDir2833;
		public abstract global::java.io.File getFilesDir();
		internal static global::MonoJavaBridge.MethodId _getExternalFilesDir2834;
		public abstract global::java.io.File getExternalFilesDir(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getCacheDir2835;
		public abstract global::java.io.File getCacheDir();
		internal static global::MonoJavaBridge.MethodId _getExternalCacheDir2836;
		public abstract global::java.io.File getExternalCacheDir();
		internal static global::MonoJavaBridge.MethodId _getDir2837;
		public abstract global::java.io.File getDir(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase2838;
		public abstract global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2);
		internal static global::MonoJavaBridge.MethodId _deleteDatabase2839;
		public abstract bool deleteDatabase(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getDatabasePath2840;
		public abstract global::java.io.File getDatabasePath(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _databaseList2841;
		public abstract global::java.lang.String[] databaseList();
		internal static global::MonoJavaBridge.MethodId _getWallpaper2842;
		public abstract global::android.graphics.drawable.Drawable getWallpaper();
		internal static global::MonoJavaBridge.MethodId _peekWallpaper2843;
		public abstract global::android.graphics.drawable.Drawable peekWallpaper();
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth2844;
		public abstract int getWallpaperDesiredMinimumWidth();
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight2845;
		public abstract int getWallpaperDesiredMinimumHeight();
		internal static global::MonoJavaBridge.MethodId _setWallpaper2846;
		public abstract void setWallpaper(android.graphics.Bitmap arg0);
		internal static global::MonoJavaBridge.MethodId _setWallpaper2847;
		public abstract void setWallpaper(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _clearWallpaper2848;
		public abstract void clearWallpaper();
		internal static global::MonoJavaBridge.MethodId _startActivity2849;
		public abstract void startActivity(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _startIntentSender2850;
		public abstract void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _sendBroadcast2851;
		public abstract void sendBroadcast(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _sendBroadcast2852;
		public abstract void sendBroadcast(android.content.Intent arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast2853;
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast2854;
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6);
		internal static global::MonoJavaBridge.MethodId _sendStickyBroadcast2855;
		public abstract void sendStickyBroadcast(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _sendStickyOrderedBroadcast2856;
		public abstract void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5);
		internal static global::MonoJavaBridge.MethodId _removeStickyBroadcast2857;
		public abstract void removeStickyBroadcast(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _registerReceiver2858;
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1);
		internal static global::MonoJavaBridge.MethodId _registerReceiver2859;
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3);
		internal static global::MonoJavaBridge.MethodId _unregisterReceiver2860;
		public abstract void unregisterReceiver(android.content.BroadcastReceiver arg0);
		internal static global::MonoJavaBridge.MethodId _startService2861;
		public abstract global::android.content.ComponentName startService(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _stopService2862;
		public abstract bool stopService(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _bindService2863;
		public abstract bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _unbindService2864;
		public abstract void unbindService(android.content.ServiceConnection arg0);
		internal static global::MonoJavaBridge.MethodId _startInstrumentation2865;
		public abstract bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2);
		internal static global::MonoJavaBridge.MethodId _getSystemService2866;
		public abstract global::java.lang.Object getSystemService(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _checkCallingPermission2867;
		public abstract int checkCallingPermission(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfPermission2868;
		public abstract int checkCallingOrSelfPermission(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _enforcePermission2869;
		public abstract void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3);
		internal static global::MonoJavaBridge.MethodId _enforceCallingPermission2870;
		public abstract void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfPermission2871;
		public abstract void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _grantUriPermission2872;
		public abstract void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _revokeUriPermission2873;
		public abstract void revokeUriPermission(android.net.Uri arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _checkUriPermission2874;
		public abstract int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5);
		internal static global::MonoJavaBridge.MethodId _checkUriPermission2875;
		public abstract int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _checkCallingUriPermission2876;
		public abstract int checkCallingUriPermission(android.net.Uri arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfUriPermission2877;
		public abstract int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission2878;
		public abstract void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4);
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission2879;
		public abstract void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6);
		internal static global::MonoJavaBridge.MethodId _enforceCallingUriPermission2880;
		public abstract void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2);
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfUriPermission2881;
		public abstract void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2);
		internal static global::MonoJavaBridge.MethodId _createPackageContext2882;
		public abstract global::android.content.Context createPackageContext(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isRestricted2883;
		public virtual bool isRestricted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context.staticClass, "isRestricted", "()Z", ref global::android.content.Context._isRestricted2883);
		}
		internal static global::MonoJavaBridge.MethodId _getText2884;
		public virtual global::java.lang.CharSequence getText(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.Context.staticClass, "getText", "(I)Ljava/lang/CharSequence;", ref global::android.content.Context._getText2884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes2885;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;", ref global::android.content.Context._obtainStyledAttributes2885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes2886;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;", ref global::android.content.Context._obtainStyledAttributes2886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes2887;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;", ref global::android.content.Context._obtainStyledAttributes2887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes2888;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;", ref global::android.content.Context._obtainStyledAttributes2888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _Context2889;
		public Context() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.Context._Context2889.native == global::System.IntPtr.Zero)
				global::android.content.Context._Context2889 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Context.staticClass, global::android.content.Context._Context2889);
			Init(@__env, handle);
		}
		public static int MODE_PRIVATE
		{
			get
			{
				return 0;
			}
		}
		public static int MODE_WORLD_READABLE
		{
			get
			{
				return 1;
			}
		}
		public static int MODE_WORLD_WRITEABLE
		{
			get
			{
				return 2;
			}
		}
		public static int MODE_APPEND
		{
			get
			{
				return 32768;
			}
		}
		public static int BIND_AUTO_CREATE
		{
			get
			{
				return 1;
			}
		}
		public static int BIND_DEBUG_UNBIND
		{
			get
			{
				return 2;
			}
		}
		public static int BIND_NOT_FOREGROUND
		{
			get
			{
				return 4;
			}
		}
		public static global::java.lang.String POWER_SERVICE
		{
			get
			{
				return "power";
			}
		}
		public static global::java.lang.String WINDOW_SERVICE
		{
			get
			{
				return "window";
			}
		}
		public static global::java.lang.String LAYOUT_INFLATER_SERVICE
		{
			get
			{
				return "layout_inflater";
			}
		}
		public static global::java.lang.String ACCOUNT_SERVICE
		{
			get
			{
				return "account";
			}
		}
		public static global::java.lang.String ACTIVITY_SERVICE
		{
			get
			{
				return "activity";
			}
		}
		public static global::java.lang.String ALARM_SERVICE
		{
			get
			{
				return "alarm";
			}
		}
		public static global::java.lang.String NOTIFICATION_SERVICE
		{
			get
			{
				return "notification";
			}
		}
		public static global::java.lang.String ACCESSIBILITY_SERVICE
		{
			get
			{
				return "accessibility";
			}
		}
		public static global::java.lang.String KEYGUARD_SERVICE
		{
			get
			{
				return "keyguard";
			}
		}
		public static global::java.lang.String LOCATION_SERVICE
		{
			get
			{
				return "location";
			}
		}
		public static global::java.lang.String SEARCH_SERVICE
		{
			get
			{
				return "search";
			}
		}
		public static global::java.lang.String SENSOR_SERVICE
		{
			get
			{
				return "sensor";
			}
		}
		public static global::java.lang.String WALLPAPER_SERVICE
		{
			get
			{
				return "wallpaper";
			}
		}
		public static global::java.lang.String VIBRATOR_SERVICE
		{
			get
			{
				return "vibrator";
			}
		}
		public static global::java.lang.String CONNECTIVITY_SERVICE
		{
			get
			{
				return "connectivity";
			}
		}
		public static global::java.lang.String WIFI_SERVICE
		{
			get
			{
				return "wifi";
			}
		}
		public static global::java.lang.String AUDIO_SERVICE
		{
			get
			{
				return "audio";
			}
		}
		public static global::java.lang.String TELEPHONY_SERVICE
		{
			get
			{
				return "phone";
			}
		}
		public static global::java.lang.String CLIPBOARD_SERVICE
		{
			get
			{
				return "clipboard";
			}
		}
		public static global::java.lang.String INPUT_METHOD_SERVICE
		{
			get
			{
				return "input_method";
			}
		}
		public static global::java.lang.String DROPBOX_SERVICE
		{
			get
			{
				return "dropbox";
			}
		}
		public static global::java.lang.String DEVICE_POLICY_SERVICE
		{
			get
			{
				return "device_policy";
			}
		}
		public static global::java.lang.String UI_MODE_SERVICE
		{
			get
			{
				return "uimode";
			}
		}
		public static int CONTEXT_INCLUDE_CODE
		{
			get
			{
				return 1;
			}
		}
		public static int CONTEXT_IGNORE_SECURITY
		{
			get
			{
				return 2;
			}
		}
		public static int CONTEXT_RESTRICTED
		{
			get
			{
				return 4;
			}
		}
		static Context()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Context.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Context"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.Context))]
	internal sealed partial class Context_ : android.content.Context
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Context_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader2923;
		public override global::java.lang.ClassLoader getClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;", ref global::android.content.Context_._getClassLoader2923) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission2924;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkPermission", "(Ljava/lang/String;II)I", ref global::android.content.Context_._checkPermission2924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getResources2925;
		public override global::android.content.res.Resources getResources()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getResources", "()Landroid/content/res/Resources;", ref global::android.content.Context_._getResources2925) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName2926;
		public override global::java.lang.String getPackageName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "getPackageName", "()Ljava/lang/String;", ref global::android.content.Context_._getPackageName2926) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAssets2927;
		public override global::android.content.res.AssetManager getAssets()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.AssetManager>(this, global::android.content.Context_.staticClass, "getAssets", "()Landroid/content/res/AssetManager;", ref global::android.content.Context_._getAssets2927) as android.content.res.AssetManager;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageManager2928;
		public override global::android.content.pm.PackageManager getPackageManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;", ref global::android.content.Context_._getPackageManager2928) as android.content.pm.PackageManager;
		}
		internal static global::MonoJavaBridge.MethodId _getContentResolver2929;
		public override global::android.content.ContentResolver getContentResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;", ref global::android.content.Context_._getContentResolver2929) as android.content.ContentResolver;
		}
		internal static global::MonoJavaBridge.MethodId _getMainLooper2930;
		public override global::android.os.Looper getMainLooper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getMainLooper", "()Landroid/os/Looper;", ref global::android.content.Context_._getMainLooper2930) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationContext2931;
		public override global::android.content.Context getApplicationContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getApplicationContext", "()Landroid/content/Context;", ref global::android.content.Context_._getApplicationContext2931) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setTheme2932;
		public override void setTheme(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "setTheme", "(I)V", ref global::android.content.Context_._setTheme2932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTheme2933;
		public override global::android.content.res.Resources.Theme getTheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.Resources.Theme>(this, global::android.content.Context_.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;", ref global::android.content.Context_._getTheme2933) as android.content.res.Resources.Theme;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo2934;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", ref global::android.content.Context_._getApplicationInfo2934) as android.content.pm.ApplicationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageResourcePath2935;
		public override global::java.lang.String getPackageResourcePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "getPackageResourcePath", "()Ljava/lang/String;", ref global::android.content.Context_._getPackageResourcePath2935) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageCodePath2936;
		public override global::java.lang.String getPackageCodePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "getPackageCodePath", "()Ljava/lang/String;", ref global::android.content.Context_._getPackageCodePath2936) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences2937;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences>(this, global::android.content.Context_.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", ref global::android.content.Context_._getSharedPreferences2937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _openFileInput2938;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", ref global::android.content.Context_._openFileInput2938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFileOutput2939;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", ref global::android.content.Context_._openFileOutput2939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _deleteFile2940;
		public override bool deleteFile(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "deleteFile", "(Ljava/lang/String;)Z", ref global::android.content.Context_._deleteFile2940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath2941;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", ref global::android.content.Context_._getFileStreamPath2941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _fileList2942;
		public override global::java.lang.String[] fileList()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "fileList", "()[Ljava/lang/String;", ref global::android.content.Context_._fileList2942) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getFilesDir2943;
		public override global::java.io.File getFilesDir()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getFilesDir", "()Ljava/io/File;", ref global::android.content.Context_._getFilesDir2943) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalFilesDir2944;
		public override global::java.io.File getExternalFilesDir(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", ref global::android.content.Context_._getExternalFilesDir2944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getCacheDir2945;
		public override global::java.io.File getCacheDir()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getCacheDir", "()Ljava/io/File;", ref global::android.content.Context_._getCacheDir2945) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalCacheDir2946;
		public override global::java.io.File getExternalCacheDir()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getExternalCacheDir", "()Ljava/io/File;", ref global::android.content.Context_._getExternalCacheDir2946) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getDir2947;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;", ref global::android.content.Context_._getDir2947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase2948;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;", ref global::android.content.Context_._openOrCreateDatabase2948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.database.sqlite.SQLiteDatabase;
		}
		public android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg2)
		{
			return openOrCreateDatabase(arg0, arg1, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _deleteDatabase2949;
		public override bool deleteDatabase(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z", ref global::android.content.Context_._deleteDatabase2949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath2950;
		public override global::java.io.File getDatabasePath(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", ref global::android.content.Context_._getDatabasePath2950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _databaseList2951;
		public override global::java.lang.String[] databaseList()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.Context_.staticClass, "databaseList", "()[Ljava/lang/String;", ref global::android.content.Context_._databaseList2951) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaper2952;
		public override global::android.graphics.drawable.Drawable getWallpaper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;", ref global::android.content.Context_._getWallpaper2952) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _peekWallpaper2953;
		public override global::android.graphics.drawable.Drawable peekWallpaper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;", ref global::android.content.Context_._peekWallpaper2953) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth2954;
		public override int getWallpaperDesiredMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "getWallpaperDesiredMinimumWidth", "()I", ref global::android.content.Context_._getWallpaperDesiredMinimumWidth2954);
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight2955;
		public override int getWallpaperDesiredMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "getWallpaperDesiredMinimumHeight", "()I", ref global::android.content.Context_._getWallpaperDesiredMinimumHeight2955);
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper2956;
		public override void setWallpaper(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V", ref global::android.content.Context_._setWallpaper2956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper2957;
		public override void setWallpaper(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V", ref global::android.content.Context_._setWallpaper2957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearWallpaper2958;
		public override void clearWallpaper()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "clearWallpaper", "()V", ref global::android.content.Context_._clearWallpaper2958);
		}
		internal static global::MonoJavaBridge.MethodId _startActivity2959;
		public override void startActivity(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "startActivity", "(Landroid/content/Intent;)V", ref global::android.content.Context_._startActivity2959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSender2960;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", ref global::android.content.Context_._startIntentSender2960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast2961;
		public override void sendBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V", ref global::android.content.Context_._sendBroadcast2961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast2962;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", ref global::android.content.Context_._sendBroadcast2962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast2963;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", ref global::android.content.Context_._sendOrderedBroadcast2963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast2964;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.content.Context_._sendOrderedBroadcast2964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyBroadcast2965;
		public override void sendStickyBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V", ref global::android.content.Context_._sendStickyBroadcast2965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyOrderedBroadcast2966;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.content.Context_._sendStickyOrderedBroadcast2966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _removeStickyBroadcast2967;
		public override void removeStickyBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V", ref global::android.content.Context_._removeStickyBroadcast2967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver2968;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;", ref global::android.content.Context_._registerReceiver2968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver2969;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", ref global::android.content.Context_._registerReceiver2969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _unregisterReceiver2970;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", ref global::android.content.Context_._unregisterReceiver2970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startService2971;
		public override global::android.content.ComponentName startService(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.content.Context_.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", ref global::android.content.Context_._startService2971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _stopService2972;
		public override bool stopService(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "stopService", "(Landroid/content/Intent;)Z", ref global::android.content.Context_._stopService2972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindService2973;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", ref global::android.content.Context_._bindService2973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unbindService2974;
		public override void unbindService(android.content.ServiceConnection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V", ref global::android.content.Context_._unbindService2974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInstrumentation2975;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.Context_.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.content.Context_._startInstrumentation2975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService2976;
		public override global::java.lang.Object getSystemService(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.content.Context_._getSystemService2976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingPermission2977;
		public override int checkCallingPermission(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I", ref global::android.content.Context_._checkCallingPermission2977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfPermission2978;
		public override int checkCallingOrSelfPermission(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I", ref global::android.content.Context_._checkCallingOrSelfPermission2978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enforcePermission2979;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", ref global::android.content.Context_._enforcePermission2979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingPermission2980;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.Context_._enforceCallingPermission2980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfPermission2981;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.Context_._enforceCallingOrSelfPermission2981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _grantUriPermission2982;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", ref global::android.content.Context_._grantUriPermission2982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _revokeUriPermission2983;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V", ref global::android.content.Context_._revokeUriPermission2983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission2984;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", ref global::android.content.Context_._checkUriPermission2984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission2985;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I", ref global::android.content.Context_._checkUriPermission2985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingUriPermission2986;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I", ref global::android.content.Context_._checkCallingUriPermission2986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfUriPermission2987;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.Context_.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", ref global::android.content.Context_._checkCallingOrSelfUriPermission2987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission2988;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", ref global::android.content.Context_._enforceUriPermission2988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission2989;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", ref global::android.content.Context_._enforceUriPermission2989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingUriPermission2990;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", ref global::android.content.Context_._enforceCallingUriPermission2990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfUriPermission2991;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.Context_.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", ref global::android.content.Context_._enforceCallingOrSelfUriPermission2991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createPackageContext2992;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.Context_.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", ref global::android.content.Context_._createPackageContext2992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Context;
		}
		static Context_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Context_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Context"));
		}
		internal static void InitJNI()
		{
		}
	}
}
