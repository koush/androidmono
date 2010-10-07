namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Context : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Context()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.Context), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Context(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getClassLoader1262;
		public abstract global::java.lang.ClassLoader getClassLoader();
		internal static global::net.sf.jni4net.jni.MethodId _checkPermission1263;
		public abstract int checkPermission(java.lang.String arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _getResources1264;
		public abstract global::android.content.res.Resources getResources();
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName1265;
		public abstract global::java.lang.String getPackageName();
		internal static global::net.sf.jni4net.jni.MethodId _getString1266;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._getString1266, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._getString1266, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString1267;
		public virtual global::java.lang.String getString(int arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._getString1267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._getString1267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAssets1268;
		public abstract global::android.content.res.AssetManager getAssets();
		internal static global::net.sf.jni4net.jni.MethodId _getPackageManager1269;
		public abstract global::android.content.pm.PackageManager getPackageManager();
		internal static global::net.sf.jni4net.jni.MethodId _getContentResolver1270;
		public abstract global::android.content.ContentResolver getContentResolver();
		internal static global::net.sf.jni4net.jni.MethodId _getMainLooper1271;
		public abstract global::android.os.Looper getMainLooper();
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationContext1272;
		public abstract global::android.content.Context getApplicationContext();
		internal static global::net.sf.jni4net.jni.MethodId _setTheme1273;
		public abstract void setTheme(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getTheme1274;
		public abstract global::android.content.res.Resources.Theme getTheme();
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationInfo1275;
		public abstract global::android.content.pm.ApplicationInfo getApplicationInfo();
		internal static global::net.sf.jni4net.jni.MethodId _getPackageResourcePath1276;
		public abstract global::java.lang.String getPackageResourcePath();
		internal static global::net.sf.jni4net.jni.MethodId _getPackageCodePath1277;
		public abstract global::java.lang.String getPackageCodePath();
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences1278;
		public abstract global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _openFileInput1279;
		public abstract global::java.io.FileInputStream openFileInput(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _openFileOutput1280;
		public abstract global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _deleteFile1281;
		public abstract bool deleteFile(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getFileStreamPath1282;
		public abstract global::java.io.File getFileStreamPath(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _fileList1283;
		public abstract global::java.lang.String[] fileList();
		internal static global::net.sf.jni4net.jni.MethodId _getFilesDir1284;
		public abstract global::java.io.File getFilesDir();
		internal static global::net.sf.jni4net.jni.MethodId _getExternalFilesDir1285;
		public abstract global::java.io.File getExternalFilesDir(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getCacheDir1286;
		public abstract global::java.io.File getCacheDir();
		internal static global::net.sf.jni4net.jni.MethodId _getExternalCacheDir1287;
		public abstract global::java.io.File getExternalCacheDir();
		internal static global::net.sf.jni4net.jni.MethodId _getDir1288;
		public abstract global::java.io.File getDir(java.lang.String arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase1289;
		public abstract global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2);
		internal static global::net.sf.jni4net.jni.MethodId _deleteDatabase1290;
		public abstract bool deleteDatabase(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getDatabasePath1291;
		public abstract global::java.io.File getDatabasePath(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _databaseList1292;
		public abstract global::java.lang.String[] databaseList();
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaper1293;
		public abstract global::android.graphics.drawable.Drawable getWallpaper();
		internal static global::net.sf.jni4net.jni.MethodId _peekWallpaper1294;
		public abstract global::android.graphics.drawable.Drawable peekWallpaper();
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumWidth1295;
		public abstract int getWallpaperDesiredMinimumWidth();
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumHeight1296;
		public abstract int getWallpaperDesiredMinimumHeight();
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1297;
		public abstract void setWallpaper(android.graphics.Bitmap arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1298;
		public abstract void setWallpaper(java.io.InputStream arg0);
		internal static global::net.sf.jni4net.jni.MethodId _clearWallpaper1299;
		public abstract void clearWallpaper();
		internal static global::net.sf.jni4net.jni.MethodId _startActivity1300;
		public abstract void startActivity(android.content.Intent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSender1301;
		public abstract void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4);
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1302;
		public abstract void sendBroadcast(android.content.Intent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1303;
		public abstract void sendBroadcast(android.content.Intent arg0, java.lang.String arg1);
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1304;
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1);
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1305;
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6);
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyBroadcast1306;
		public abstract void sendStickyBroadcast(android.content.Intent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyOrderedBroadcast1307;
		public abstract void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5);
		internal static global::net.sf.jni4net.jni.MethodId _removeStickyBroadcast1308;
		public abstract void removeStickyBroadcast(android.content.Intent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1309;
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1);
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1310;
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3);
		internal static global::net.sf.jni4net.jni.MethodId _unregisterReceiver1311;
		public abstract void unregisterReceiver(android.content.BroadcastReceiver arg0);
		internal static global::net.sf.jni4net.jni.MethodId _startService1312;
		public abstract global::android.content.ComponentName startService(android.content.Intent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _stopService1313;
		public abstract bool stopService(android.content.Intent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _bindService1314;
		public abstract bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _unbindService1315;
		public abstract void unbindService(android.content.ServiceConnection arg0);
		internal static global::net.sf.jni4net.jni.MethodId _startInstrumentation1316;
		public abstract bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2);
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService1317;
		public abstract global::java.lang.Object getSystemService(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingPermission1318;
		public abstract int checkCallingPermission(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfPermission1319;
		public abstract int checkCallingOrSelfPermission(java.lang.String arg0);
		internal static global::net.sf.jni4net.jni.MethodId _enforcePermission1320;
		public abstract void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3);
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingPermission1321;
		public abstract void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1);
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfPermission1322;
		public abstract void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1);
		internal static global::net.sf.jni4net.jni.MethodId _grantUriPermission1323;
		public abstract void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _revokeUriPermission1324;
		public abstract void revokeUriPermission(android.net.Uri arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1325;
		public abstract int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5);
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1326;
		public abstract int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3);
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingUriPermission1327;
		public abstract int checkCallingUriPermission(android.net.Uri arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfUriPermission1328;
		public abstract int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1329;
		public abstract void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4);
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1330;
		public abstract void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6);
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingUriPermission1331;
		public abstract void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2);
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfUriPermission1332;
		public abstract void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2);
		internal static global::net.sf.jni4net.jni.MethodId _createPackageContext1333;
		public abstract global::android.content.Context createPackageContext(java.lang.String arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _isRestricted1334;
		public virtual bool isRestricted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.Context._isRestricted1334);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.Context.staticClass, global::android.content.Context._isRestricted1334);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText1335;
		public virtual global::java.lang.CharSequence getText(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._getText1335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._getText1335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1336;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._obtainStyledAttributes1336, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1336, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1337;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._obtainStyledAttributes1337, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1337, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1338;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._obtainStyledAttributes1338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1339;
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._obtainStyledAttributes1339, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1339, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Context1340;
		public Context()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.Context.staticClass, global::android.content.Context._Context1340, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.Context.staticClass = @__class;
			global::android.content.Context._getClassLoader1262 = @__env.GetMethodID(global::android.content.Context.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::android.content.Context._checkPermission1263 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkPermission", "(Ljava/lang/String;II)I");
			global::android.content.Context._getResources1264 = @__env.GetMethodID(global::android.content.Context.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.Context._getPackageName1265 = @__env.GetMethodID(global::android.content.Context.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.content.Context._getString1266 = @__env.GetMethodID(global::android.content.Context.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.content.Context._getString1267 = @__env.GetMethodID(global::android.content.Context.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;");
			global::android.content.Context._getAssets1268 = @__env.GetMethodID(global::android.content.Context.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.content.Context._getPackageManager1269 = @__env.GetMethodID(global::android.content.Context.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;");
			global::android.content.Context._getContentResolver1270 = @__env.GetMethodID(global::android.content.Context.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			global::android.content.Context._getMainLooper1271 = @__env.GetMethodID(global::android.content.Context.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.content.Context._getApplicationContext1272 = @__env.GetMethodID(global::android.content.Context.staticClass, "getApplicationContext", "()Landroid/content/Context;");
			global::android.content.Context._setTheme1273 = @__env.GetMethodID(global::android.content.Context.staticClass, "setTheme", "(I)V");
			global::android.content.Context._getTheme1274 = @__env.GetMethodID(global::android.content.Context.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.content.Context._getApplicationInfo1275 = @__env.GetMethodID(global::android.content.Context.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;");
			global::android.content.Context._getPackageResourcePath1276 = @__env.GetMethodID(global::android.content.Context.staticClass, "getPackageResourcePath", "()Ljava/lang/String;");
			global::android.content.Context._getPackageCodePath1277 = @__env.GetMethodID(global::android.content.Context.staticClass, "getPackageCodePath", "()Ljava/lang/String;");
			global::android.content.Context._getSharedPreferences1278 = @__env.GetMethodID(global::android.content.Context.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			global::android.content.Context._openFileInput1279 = @__env.GetMethodID(global::android.content.Context.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.content.Context._openFileOutput1280 = @__env.GetMethodID(global::android.content.Context.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.content.Context._deleteFile1281 = @__env.GetMethodID(global::android.content.Context.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.content.Context._getFileStreamPath1282 = @__env.GetMethodID(global::android.content.Context.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.Context._fileList1283 = @__env.GetMethodID(global::android.content.Context.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.content.Context._getFilesDir1284 = @__env.GetMethodID(global::android.content.Context.staticClass, "getFilesDir", "()Ljava/io/File;");
			global::android.content.Context._getExternalFilesDir1285 = @__env.GetMethodID(global::android.content.Context.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.Context._getCacheDir1286 = @__env.GetMethodID(global::android.content.Context.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.content.Context._getExternalCacheDir1287 = @__env.GetMethodID(global::android.content.Context.staticClass, "getExternalCacheDir", "()Ljava/io/File;");
			global::android.content.Context._getDir1288 = @__env.GetMethodID(global::android.content.Context.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			global::android.content.Context._openOrCreateDatabase1289 = @__env.GetMethodID(global::android.content.Context.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.content.Context._deleteDatabase1290 = @__env.GetMethodID(global::android.content.Context.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.content.Context._getDatabasePath1291 = @__env.GetMethodID(global::android.content.Context.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.Context._databaseList1292 = @__env.GetMethodID(global::android.content.Context.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.content.Context._getWallpaper1293 = @__env.GetMethodID(global::android.content.Context.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.Context._peekWallpaper1294 = @__env.GetMethodID(global::android.content.Context.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.Context._getWallpaperDesiredMinimumWidth1295 = @__env.GetMethodID(global::android.content.Context.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.content.Context._getWallpaperDesiredMinimumHeight1296 = @__env.GetMethodID(global::android.content.Context.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.content.Context._setWallpaper1297 = @__env.GetMethodID(global::android.content.Context.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			global::android.content.Context._setWallpaper1298 = @__env.GetMethodID(global::android.content.Context.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V");
			global::android.content.Context._clearWallpaper1299 = @__env.GetMethodID(global::android.content.Context.staticClass, "clearWallpaper", "()V");
			global::android.content.Context._startActivity1300 = @__env.GetMethodID(global::android.content.Context.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.content.Context._startIntentSender1301 = @__env.GetMethodID(global::android.content.Context.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.content.Context._sendBroadcast1302 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.Context._sendBroadcast1303 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.Context._sendOrderedBroadcast1304 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.Context._sendOrderedBroadcast1305 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.Context._sendStickyBroadcast1306 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.Context._sendStickyOrderedBroadcast1307 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.Context._removeStickyBroadcast1308 = @__env.GetMethodID(global::android.content.Context.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.Context._registerReceiver1309 = @__env.GetMethodID(global::android.content.Context.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::android.content.Context._registerReceiver1310 = @__env.GetMethodID(global::android.content.Context.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			global::android.content.Context._unregisterReceiver1311 = @__env.GetMethodID(global::android.content.Context.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			global::android.content.Context._startService1312 = @__env.GetMethodID(global::android.content.Context.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			global::android.content.Context._stopService1313 = @__env.GetMethodID(global::android.content.Context.staticClass, "stopService", "(Landroid/content/Intent;)Z");
			global::android.content.Context._bindService1314 = @__env.GetMethodID(global::android.content.Context.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::android.content.Context._unbindService1315 = @__env.GetMethodID(global::android.content.Context.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V");
			global::android.content.Context._startInstrumentation1316 = @__env.GetMethodID(global::android.content.Context.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.content.Context._getSystemService1317 = @__env.GetMethodID(global::android.content.Context.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.Context._checkCallingPermission1318 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I");
			global::android.content.Context._checkCallingOrSelfPermission1319 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			global::android.content.Context._enforcePermission1320 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			global::android.content.Context._enforceCallingPermission1321 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.Context._enforceCallingOrSelfPermission1322 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.Context._grantUriPermission1323 = @__env.GetMethodID(global::android.content.Context.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			global::android.content.Context._revokeUriPermission1324 = @__env.GetMethodID(global::android.content.Context.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			global::android.content.Context._checkUriPermission1325 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			global::android.content.Context._checkUriPermission1326 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::android.content.Context._checkCallingUriPermission1327 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.Context._checkCallingOrSelfUriPermission1328 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.Context._enforceUriPermission1329 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			global::android.content.Context._enforceUriPermission1330 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			global::android.content.Context._enforceCallingUriPermission1331 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.Context._enforceCallingOrSelfUriPermission1332 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.Context._createPackageContext1333 = @__env.GetMethodID(global::android.content.Context.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
			global::android.content.Context._isRestricted1334 = @__env.GetMethodID(global::android.content.Context.staticClass, "isRestricted", "()Z");
			global::android.content.Context._getText1335 = @__env.GetMethodID(global::android.content.Context.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.content.Context._obtainStyledAttributes1336 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;");
			global::android.content.Context._obtainStyledAttributes1337 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;");
			global::android.content.Context._obtainStyledAttributes1338 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;");
			global::android.content.Context._obtainStyledAttributes1339 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;");
			global::android.content.Context._Context1340 = @__env.GetMethodID(global::android.content.Context.staticClass, "<init>", "()V");
		}
	}
}
