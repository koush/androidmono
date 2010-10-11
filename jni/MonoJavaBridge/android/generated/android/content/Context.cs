namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.Context_))]
	public abstract partial class Context : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Context()
		{
			InitJNI();
		}
		protected Context(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader1286;
		public abstract global::java.lang.ClassLoader getClassLoader();
		internal static global::MonoJavaBridge.MethodId _checkPermission1287;
		public abstract int checkPermission(java.lang.String arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _getResources1288;
		public abstract global::android.content.res.Resources getResources();
		internal static global::MonoJavaBridge.MethodId _getPackageName1289;
		public abstract global::java.lang.String getPackageName();
		internal static global::MonoJavaBridge.MethodId _getString1290;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context._getString1290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context.staticClass, global::android.content.Context._getString1290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString1291;
		public virtual global::java.lang.String getString(int arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context._getString1291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context.staticClass, global::android.content.Context._getString1291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAssets1292;
		public abstract global::android.content.res.AssetManager getAssets();
		internal static global::MonoJavaBridge.MethodId _getPackageManager1293;
		public abstract global::android.content.pm.PackageManager getPackageManager();
		internal static global::MonoJavaBridge.MethodId _getContentResolver1294;
		public abstract global::android.content.ContentResolver getContentResolver();
		internal static global::MonoJavaBridge.MethodId _getMainLooper1295;
		public abstract global::android.os.Looper getMainLooper();
		internal static global::MonoJavaBridge.MethodId _getApplicationContext1296;
		public abstract global::android.content.Context getApplicationContext();
		internal static global::MonoJavaBridge.MethodId _setTheme1297;
		public abstract void setTheme(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTheme1298;
		public abstract global::android.content.res.Resources.Theme getTheme();
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo1299;
		public abstract global::android.content.pm.ApplicationInfo getApplicationInfo();
		internal static global::MonoJavaBridge.MethodId _getPackageResourcePath1300;
		public abstract global::java.lang.String getPackageResourcePath();
		internal static global::MonoJavaBridge.MethodId _getPackageCodePath1301;
		public abstract global::java.lang.String getPackageCodePath();
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences1302;
		public abstract global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _openFileInput1303;
		public abstract global::java.io.FileInputStream openFileInput(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _openFileOutput1304;
		public abstract global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _deleteFile1305;
		public abstract bool deleteFile(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath1306;
		public abstract global::java.io.File getFileStreamPath(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _fileList1307;
		public abstract global::java.lang.String[] fileList();
		internal static global::MonoJavaBridge.MethodId _getFilesDir1308;
		public abstract global::java.io.File getFilesDir();
		internal static global::MonoJavaBridge.MethodId _getExternalFilesDir1309;
		public abstract global::java.io.File getExternalFilesDir(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getCacheDir1310;
		public abstract global::java.io.File getCacheDir();
		internal static global::MonoJavaBridge.MethodId _getExternalCacheDir1311;
		public abstract global::java.io.File getExternalCacheDir();
		internal static global::MonoJavaBridge.MethodId _getDir1312;
		public abstract global::java.io.File getDir(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase1313;
		public abstract global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2);
		internal static global::MonoJavaBridge.MethodId _deleteDatabase1314;
		public abstract bool deleteDatabase(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getDatabasePath1315;
		public abstract global::java.io.File getDatabasePath(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _databaseList1316;
		public abstract global::java.lang.String[] databaseList();
		internal static global::MonoJavaBridge.MethodId _getWallpaper1317;
		public abstract global::android.graphics.drawable.Drawable getWallpaper();
		internal static global::MonoJavaBridge.MethodId _peekWallpaper1318;
		public abstract global::android.graphics.drawable.Drawable peekWallpaper();
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth1319;
		public abstract int getWallpaperDesiredMinimumWidth();
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight1320;
		public abstract int getWallpaperDesiredMinimumHeight();
		internal static global::MonoJavaBridge.MethodId _setWallpaper1321;
		public abstract void setWallpaper(android.graphics.Bitmap arg0);
		internal static global::MonoJavaBridge.MethodId _setWallpaper1322;
		public abstract void setWallpaper(java.io.InputStream arg0);
		internal static global::MonoJavaBridge.MethodId _clearWallpaper1323;
		public abstract void clearWallpaper();
		internal static global::MonoJavaBridge.MethodId _startActivity1324;
		public abstract void startActivity(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _startIntentSender1325;
		public abstract void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _sendBroadcast1326;
		public abstract void sendBroadcast(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _sendBroadcast1327;
		public abstract void sendBroadcast(android.content.Intent arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast1328;
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast1329;
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6);
		internal static global::MonoJavaBridge.MethodId _sendStickyBroadcast1330;
		public abstract void sendStickyBroadcast(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _sendStickyOrderedBroadcast1331;
		public abstract void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5);
		internal static global::MonoJavaBridge.MethodId _removeStickyBroadcast1332;
		public abstract void removeStickyBroadcast(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _registerReceiver1333;
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1);
		internal static global::MonoJavaBridge.MethodId _registerReceiver1334;
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3);
		internal static global::MonoJavaBridge.MethodId _unregisterReceiver1335;
		public abstract void unregisterReceiver(android.content.BroadcastReceiver arg0);
		internal static global::MonoJavaBridge.MethodId _startService1336;
		public abstract global::android.content.ComponentName startService(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _stopService1337;
		public abstract bool stopService(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _bindService1338;
		public abstract bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _unbindService1339;
		public abstract void unbindService(android.content.ServiceConnection arg0);
		internal static global::MonoJavaBridge.MethodId _startInstrumentation1340;
		public abstract bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2);
		internal static global::MonoJavaBridge.MethodId _getSystemService1341;
		public abstract global::java.lang.Object getSystemService(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _checkCallingPermission1342;
		public abstract int checkCallingPermission(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfPermission1343;
		public abstract int checkCallingOrSelfPermission(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _enforcePermission1344;
		public abstract void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3);
		internal static global::MonoJavaBridge.MethodId _enforceCallingPermission1345;
		public abstract void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfPermission1346;
		public abstract void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _grantUriPermission1347;
		public abstract void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _revokeUriPermission1348;
		public abstract void revokeUriPermission(android.net.Uri arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _checkUriPermission1349;
		public abstract int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5);
		internal static global::MonoJavaBridge.MethodId _checkUriPermission1350;
		public abstract int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _checkCallingUriPermission1351;
		public abstract int checkCallingUriPermission(android.net.Uri arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfUriPermission1352;
		public abstract int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission1353;
		public abstract void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4);
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission1354;
		public abstract void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6);
		internal static global::MonoJavaBridge.MethodId _enforceCallingUriPermission1355;
		public abstract void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2);
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfUriPermission1356;
		public abstract void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2);
		internal static global::MonoJavaBridge.MethodId _createPackageContext1357;
		public abstract global::android.content.Context createPackageContext(java.lang.String arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isRestricted1358;
		public virtual bool isRestricted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Context._isRestricted1358);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Context.staticClass, global::android.content.Context._isRestricted1358);
		}
		internal static global::MonoJavaBridge.MethodId _getText1359;
		public virtual global::java.lang.CharSequence getText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context._getText1359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context.staticClass, global::android.content.Context._getText1359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes1360;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context._obtainStyledAttributes1360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes1361;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context._obtainStyledAttributes1361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes1362;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context._obtainStyledAttributes1362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _obtainStyledAttributes1363;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context._obtainStyledAttributes1363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _Context1364;
		public Context()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Context.staticClass, global::android.content.Context._Context1364);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Context.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Context"));
			global::android.content.Context._getClassLoader1286 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::android.content.Context._checkPermission1287 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "checkPermission", "(Ljava/lang/String;II)I");
			global::android.content.Context._getResources1288 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.Context._getPackageName1289 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.content.Context._getString1290 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.content.Context._getString1291 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.content.Context._getAssets1292 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.content.Context._getPackageManager1293 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;");
			global::android.content.Context._getContentResolver1294 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			global::android.content.Context._getMainLooper1295 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.content.Context._getApplicationContext1296 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getApplicationContext", "()Landroid/content/Context;");
			global::android.content.Context._setTheme1297 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "setTheme", "(I)V");
			global::android.content.Context._getTheme1298 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.content.Context._getApplicationInfo1299 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;");
			global::android.content.Context._getPackageResourcePath1300 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getPackageResourcePath", "()Ljava/lang/String;");
			global::android.content.Context._getPackageCodePath1301 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getPackageCodePath", "()Ljava/lang/String;");
			global::android.content.Context._getSharedPreferences1302 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			global::android.content.Context._openFileInput1303 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.content.Context._openFileOutput1304 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.content.Context._deleteFile1305 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.content.Context._getFileStreamPath1306 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.Context._fileList1307 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.content.Context._getFilesDir1308 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getFilesDir", "()Ljava/io/File;");
			global::android.content.Context._getExternalFilesDir1309 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.Context._getCacheDir1310 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.content.Context._getExternalCacheDir1311 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getExternalCacheDir", "()Ljava/io/File;");
			global::android.content.Context._getDir1312 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			global::android.content.Context._openOrCreateDatabase1313 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.content.Context._deleteDatabase1314 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.content.Context._getDatabasePath1315 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.Context._databaseList1316 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.content.Context._getWallpaper1317 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.Context._peekWallpaper1318 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.Context._getWallpaperDesiredMinimumWidth1319 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.content.Context._getWallpaperDesiredMinimumHeight1320 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.content.Context._setWallpaper1321 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			global::android.content.Context._setWallpaper1322 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V");
			global::android.content.Context._clearWallpaper1323 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "clearWallpaper", "()V");
			global::android.content.Context._startActivity1324 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.content.Context._startIntentSender1325 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.content.Context._sendBroadcast1326 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.Context._sendBroadcast1327 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.Context._sendOrderedBroadcast1328 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.Context._sendOrderedBroadcast1329 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.Context._sendStickyBroadcast1330 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.Context._sendStickyOrderedBroadcast1331 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.Context._removeStickyBroadcast1332 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.Context._registerReceiver1333 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::android.content.Context._registerReceiver1334 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			global::android.content.Context._unregisterReceiver1335 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			global::android.content.Context._startService1336 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			global::android.content.Context._stopService1337 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "stopService", "(Landroid/content/Intent;)Z");
			global::android.content.Context._bindService1338 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::android.content.Context._unbindService1339 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V");
			global::android.content.Context._startInstrumentation1340 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.content.Context._getSystemService1341 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.Context._checkCallingPermission1342 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I");
			global::android.content.Context._checkCallingOrSelfPermission1343 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			global::android.content.Context._enforcePermission1344 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			global::android.content.Context._enforceCallingPermission1345 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.Context._enforceCallingOrSelfPermission1346 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.Context._grantUriPermission1347 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			global::android.content.Context._revokeUriPermission1348 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			global::android.content.Context._checkUriPermission1349 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			global::android.content.Context._checkUriPermission1350 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::android.content.Context._checkCallingUriPermission1351 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.Context._checkCallingOrSelfUriPermission1352 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.Context._enforceUriPermission1353 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			global::android.content.Context._enforceUriPermission1354 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			global::android.content.Context._enforceCallingUriPermission1355 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.Context._enforceCallingOrSelfUriPermission1356 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.Context._createPackageContext1357 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
			global::android.content.Context._isRestricted1358 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "isRestricted", "()Z");
			global::android.content.Context._getText1359 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.content.Context._obtainStyledAttributes1360 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;");
			global::android.content.Context._obtainStyledAttributes1361 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;");
			global::android.content.Context._obtainStyledAttributes1362 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;");
			global::android.content.Context._obtainStyledAttributes1363 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;");
			global::android.content.Context._Context1364 = @__env.GetMethodIDNoThrow(global::android.content.Context.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.Context))]
	public sealed partial class Context_ : android.content.Context
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Context_()
		{
			InitJNI();
		}
		internal Context_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader1365;
		public override global::java.lang.ClassLoader getClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getClassLoader1365)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getClassLoader1365)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission1366;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Context_._checkPermission1366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._checkPermission1366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getResources1367;
		public override global::android.content.res.Resources getResources() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getResources1367)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getResources1367)) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName1368;
		public override global::java.lang.String getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getPackageName1368)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getPackageName1368)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAssets1369;
		public override global::android.content.res.AssetManager getAssets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getAssets1369)) as android.content.res.AssetManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getAssets1369)) as android.content.res.AssetManager;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageManager1370;
		public override global::android.content.pm.PackageManager getPackageManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getPackageManager1370)) as android.content.pm.PackageManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getPackageManager1370)) as android.content.pm.PackageManager;
		}
		internal static global::MonoJavaBridge.MethodId _getContentResolver1371;
		public override global::android.content.ContentResolver getContentResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getContentResolver1371)) as android.content.ContentResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getContentResolver1371)) as android.content.ContentResolver;
		}
		internal static global::MonoJavaBridge.MethodId _getMainLooper1372;
		public override global::android.os.Looper getMainLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getMainLooper1372)) as android.os.Looper;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getMainLooper1372)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationContext1373;
		public override global::android.content.Context getApplicationContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getApplicationContext1373)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getApplicationContext1373)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setTheme1374;
		public override void setTheme(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._setTheme1374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._setTheme1374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTheme1375;
		public override global::android.content.res.Resources.Theme getTheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getTheme1375)) as android.content.res.Resources.Theme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getTheme1375)) as android.content.res.Resources.Theme;
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo1376;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getApplicationInfo1376)) as android.content.pm.ApplicationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getApplicationInfo1376)) as android.content.pm.ApplicationInfo;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageResourcePath1377;
		public override global::java.lang.String getPackageResourcePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getPackageResourcePath1377)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getPackageResourcePath1377)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageCodePath1378;
		public override global::java.lang.String getPackageCodePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getPackageCodePath1378)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getPackageCodePath1378)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences1379;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getSharedPreferences1379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getSharedPreferences1379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _openFileInput1380;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._openFileInput1380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._openFileInput1380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFileOutput1381;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._openFileOutput1381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._openFileOutput1381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _deleteFile1382;
		public override bool deleteFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Context_._deleteFile1382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._deleteFile1382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath1383;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getFileStreamPath1383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getFileStreamPath1383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _fileList1384;
		public override global::java.lang.String[] fileList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._fileList1384)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._fileList1384)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getFilesDir1385;
		public override global::java.io.File getFilesDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getFilesDir1385)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getFilesDir1385)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalFilesDir1386;
		public override global::java.io.File getExternalFilesDir(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getExternalFilesDir1386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getExternalFilesDir1386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getCacheDir1387;
		public override global::java.io.File getCacheDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getCacheDir1387)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getCacheDir1387)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalCacheDir1388;
		public override global::java.io.File getExternalCacheDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getExternalCacheDir1388)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getExternalCacheDir1388)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getDir1389;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getDir1389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getDir1389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase1390;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._openOrCreateDatabase1390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._openOrCreateDatabase1390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _deleteDatabase1391;
		public override bool deleteDatabase(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Context_._deleteDatabase1391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._deleteDatabase1391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath1392;
		public override global::java.io.File getDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getDatabasePath1392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getDatabasePath1392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _databaseList1393;
		public override global::java.lang.String[] databaseList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._databaseList1393)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._databaseList1393)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaper1394;
		public override global::android.graphics.drawable.Drawable getWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getWallpaper1394)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getWallpaper1394)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _peekWallpaper1395;
		public override global::android.graphics.drawable.Drawable peekWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._peekWallpaper1395)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._peekWallpaper1395)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth1396;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Context_._getWallpaperDesiredMinimumWidth1396);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getWallpaperDesiredMinimumWidth1396);
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight1397;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Context_._getWallpaperDesiredMinimumHeight1397);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getWallpaperDesiredMinimumHeight1397);
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper1398;
		public override void setWallpaper(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._setWallpaper1398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._setWallpaper1398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper1399;
		public override void setWallpaper(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._setWallpaper1399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._setWallpaper1399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearWallpaper1400;
		public override void clearWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._clearWallpaper1400);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._clearWallpaper1400);
		}
		internal static global::MonoJavaBridge.MethodId _startActivity1401;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._startActivity1401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._startActivity1401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSender1402;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._startIntentSender1402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._startIntentSender1402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast1403;
		public override void sendBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._sendBroadcast1403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._sendBroadcast1403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast1404;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._sendBroadcast1404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._sendBroadcast1404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast1405;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._sendOrderedBroadcast1405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._sendOrderedBroadcast1405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast1406;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._sendOrderedBroadcast1406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._sendOrderedBroadcast1406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyBroadcast1407;
		public override void sendStickyBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._sendStickyBroadcast1407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._sendStickyBroadcast1407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyOrderedBroadcast1408;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._sendStickyOrderedBroadcast1408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._sendStickyOrderedBroadcast1408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _removeStickyBroadcast1409;
		public override void removeStickyBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._removeStickyBroadcast1409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._removeStickyBroadcast1409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver1410;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._registerReceiver1410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._registerReceiver1410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver1411;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._registerReceiver1411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._registerReceiver1411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _unregisterReceiver1412;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._unregisterReceiver1412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._unregisterReceiver1412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startService1413;
		public override global::android.content.ComponentName startService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._startService1413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._startService1413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _stopService1414;
		public override bool stopService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Context_._stopService1414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._stopService1414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindService1415;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Context_._bindService1415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._bindService1415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unbindService1416;
		public override void unbindService(android.content.ServiceConnection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._unbindService1416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._unbindService1416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInstrumentation1417;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Context_._startInstrumentation1417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._startInstrumentation1417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService1418;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._getSystemService1418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._getSystemService1418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingPermission1419;
		public override int checkCallingPermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Context_._checkCallingPermission1419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._checkCallingPermission1419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfPermission1420;
		public override int checkCallingOrSelfPermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Context_._checkCallingOrSelfPermission1420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._checkCallingOrSelfPermission1420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enforcePermission1421;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._enforcePermission1421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._enforcePermission1421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingPermission1422;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._enforceCallingPermission1422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._enforceCallingPermission1422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfPermission1423;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._enforceCallingOrSelfPermission1423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._enforceCallingOrSelfPermission1423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _grantUriPermission1424;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._grantUriPermission1424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._grantUriPermission1424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _revokeUriPermission1425;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._revokeUriPermission1425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._revokeUriPermission1425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission1426;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Context_._checkUriPermission1426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._checkUriPermission1426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission1427;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Context_._checkUriPermission1427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._checkUriPermission1427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingUriPermission1428;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Context_._checkCallingUriPermission1428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._checkCallingUriPermission1428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfUriPermission1429;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Context_._checkCallingOrSelfUriPermission1429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._checkCallingOrSelfUriPermission1429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission1430;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._enforceUriPermission1430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._enforceUriPermission1430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission1431;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._enforceUriPermission1431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._enforceUriPermission1431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingUriPermission1432;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._enforceCallingUriPermission1432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._enforceCallingUriPermission1432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfUriPermission1433;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Context_._enforceCallingOrSelfUriPermission1433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._enforceCallingOrSelfUriPermission1433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createPackageContext1434;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Context_._createPackageContext1434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Context_.staticClass, global::android.content.Context_._createPackageContext1434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Context;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Context_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Context"));
			global::android.content.Context_._getClassLoader1365 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::android.content.Context_._checkPermission1366 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "checkPermission", "(Ljava/lang/String;II)I");
			global::android.content.Context_._getResources1367 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.Context_._getPackageName1368 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.content.Context_._getAssets1369 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.content.Context_._getPackageManager1370 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;");
			global::android.content.Context_._getContentResolver1371 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			global::android.content.Context_._getMainLooper1372 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.content.Context_._getApplicationContext1373 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getApplicationContext", "()Landroid/content/Context;");
			global::android.content.Context_._setTheme1374 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "setTheme", "(I)V");
			global::android.content.Context_._getTheme1375 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.content.Context_._getApplicationInfo1376 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;");
			global::android.content.Context_._getPackageResourcePath1377 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getPackageResourcePath", "()Ljava/lang/String;");
			global::android.content.Context_._getPackageCodePath1378 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getPackageCodePath", "()Ljava/lang/String;");
			global::android.content.Context_._getSharedPreferences1379 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			global::android.content.Context_._openFileInput1380 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.content.Context_._openFileOutput1381 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.content.Context_._deleteFile1382 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.content.Context_._getFileStreamPath1383 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.Context_._fileList1384 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.content.Context_._getFilesDir1385 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getFilesDir", "()Ljava/io/File;");
			global::android.content.Context_._getExternalFilesDir1386 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.Context_._getCacheDir1387 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.content.Context_._getExternalCacheDir1388 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getExternalCacheDir", "()Ljava/io/File;");
			global::android.content.Context_._getDir1389 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			global::android.content.Context_._openOrCreateDatabase1390 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.content.Context_._deleteDatabase1391 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.content.Context_._getDatabasePath1392 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.Context_._databaseList1393 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.content.Context_._getWallpaper1394 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.Context_._peekWallpaper1395 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.Context_._getWallpaperDesiredMinimumWidth1396 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.content.Context_._getWallpaperDesiredMinimumHeight1397 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.content.Context_._setWallpaper1398 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			global::android.content.Context_._setWallpaper1399 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V");
			global::android.content.Context_._clearWallpaper1400 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "clearWallpaper", "()V");
			global::android.content.Context_._startActivity1401 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.content.Context_._startIntentSender1402 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.content.Context_._sendBroadcast1403 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.Context_._sendBroadcast1404 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.Context_._sendOrderedBroadcast1405 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.Context_._sendOrderedBroadcast1406 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.Context_._sendStickyBroadcast1407 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.Context_._sendStickyOrderedBroadcast1408 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.Context_._removeStickyBroadcast1409 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.Context_._registerReceiver1410 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::android.content.Context_._registerReceiver1411 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			global::android.content.Context_._unregisterReceiver1412 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			global::android.content.Context_._startService1413 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			global::android.content.Context_._stopService1414 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "stopService", "(Landroid/content/Intent;)Z");
			global::android.content.Context_._bindService1415 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::android.content.Context_._unbindService1416 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V");
			global::android.content.Context_._startInstrumentation1417 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.content.Context_._getSystemService1418 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.Context_._checkCallingPermission1419 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I");
			global::android.content.Context_._checkCallingOrSelfPermission1420 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			global::android.content.Context_._enforcePermission1421 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			global::android.content.Context_._enforceCallingPermission1422 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.Context_._enforceCallingOrSelfPermission1423 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.Context_._grantUriPermission1424 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			global::android.content.Context_._revokeUriPermission1425 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			global::android.content.Context_._checkUriPermission1426 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			global::android.content.Context_._checkUriPermission1427 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::android.content.Context_._checkCallingUriPermission1428 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.Context_._checkCallingOrSelfUriPermission1429 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.Context_._enforceUriPermission1430 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			global::android.content.Context_._enforceUriPermission1431 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			global::android.content.Context_._enforceCallingUriPermission1432 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.Context_._enforceCallingOrSelfUriPermission1433 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.Context_._createPackageContext1434 = @__env.GetMethodIDNoThrow(global::android.content.Context_.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
		}
	}
}
