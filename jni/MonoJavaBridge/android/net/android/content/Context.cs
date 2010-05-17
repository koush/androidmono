namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Context : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Context() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.Context), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Context(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClassLoader1110; 
		public abstract java.lang.ClassLoader getClassLoader(); 
		internal static global::net.sf.jni4net.jni.MethodId _checkPermission1111; 
		public abstract int checkPermission(java.lang.String arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getResources1112; 
		public abstract android.content.res.Resources getResources(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName1113; 
		public abstract java.lang.String getPackageName(); 
		internal static global::net.sf.jni4net.jni.MethodId _getString1114; 
		public virtual java.lang.String getString(int arg0, java.lang.Object[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Context)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString1114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Context.staticClass, _getString1114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString1115; 
		public virtual java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Context)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString1115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Context.staticClass, _getString1115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAssets1116; 
		public abstract android.content.res.AssetManager getAssets(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageManager1117; 
		public abstract android.content.pm.PackageManager getPackageManager(); 
		internal static global::net.sf.jni4net.jni.MethodId _getContentResolver1118; 
		public abstract android.content.ContentResolver getContentResolver(); 
		internal static global::net.sf.jni4net.jni.MethodId _getMainLooper1119; 
		public abstract android.os.Looper getMainLooper(); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationContext1120; 
		public abstract android.content.Context getApplicationContext(); 
		internal static global::net.sf.jni4net.jni.MethodId _setTheme1121; 
		public abstract void setTheme(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getTheme1122; 
		public abstract android.content.res.Resources.Theme getTheme(); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationInfo1123; 
		public abstract android.content.pm.ApplicationInfo getApplicationInfo(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences1124; 
		public abstract android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _openFileInput1125; 
		public abstract java.io.FileInputStream openFileInput(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _openFileOutput1126; 
		public abstract java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _deleteFile1127; 
		public abstract bool deleteFile(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getFileStreamPath1128; 
		public abstract java.io.File getFileStreamPath(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _fileList1129; 
		public abstract java.lang.String[] fileList(); 
		internal static global::net.sf.jni4net.jni.MethodId _getFilesDir1130; 
		public abstract java.io.File getFilesDir(); 
		internal static global::net.sf.jni4net.jni.MethodId _getCacheDir1131; 
		public abstract java.io.File getCacheDir(); 
		internal static global::net.sf.jni4net.jni.MethodId _getDir1132; 
		public abstract java.io.File getDir(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase1133; 
		public abstract android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _deleteDatabase1134; 
		public abstract bool deleteDatabase(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getDatabasePath1135; 
		public abstract java.io.File getDatabasePath(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _databaseList1136; 
		public abstract java.lang.String[] databaseList(); 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaper1137; 
		public abstract android.graphics.drawable.Drawable getWallpaper(); 
		internal static global::net.sf.jni4net.jni.MethodId _peekWallpaper1138; 
		public abstract android.graphics.drawable.Drawable peekWallpaper(); 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumWidth1139; 
		public abstract int getWallpaperDesiredMinimumWidth(); 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumHeight1140; 
		public abstract int getWallpaperDesiredMinimumHeight(); 
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1141; 
		public abstract void setWallpaper(java.io.InputStream arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1142; 
		public abstract void setWallpaper(android.graphics.Bitmap arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _clearWallpaper1143; 
		public abstract void clearWallpaper(); 
		internal static global::net.sf.jni4net.jni.MethodId _startActivity1144; 
		public abstract void startActivity(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSender1145; 
		public abstract void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1146; 
		public abstract void sendBroadcast(android.content.Intent arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1147; 
		public abstract void sendBroadcast(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1148; 
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1149; 
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6); 
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyBroadcast1150; 
		public abstract void sendStickyBroadcast(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyOrderedBroadcast1151; 
		public abstract void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5); 
		internal static global::net.sf.jni4net.jni.MethodId _removeStickyBroadcast1152; 
		public abstract void removeStickyBroadcast(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1153; 
		public abstract android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1154; 
		public abstract android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterReceiver1155; 
		public abstract void unregisterReceiver(android.content.BroadcastReceiver arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _startService1156; 
		public abstract android.content.ComponentName startService(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _stopService1157; 
		public abstract bool stopService(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _bindService1158; 
		public abstract bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _unbindService1159; 
		public abstract void unbindService(android.content.ServiceConnection arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _startInstrumentation1160; 
		public abstract bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService1161; 
		public abstract java.lang.Object getSystemService(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingPermission1162; 
		public abstract int checkCallingPermission(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfPermission1163; 
		public abstract int checkCallingOrSelfPermission(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _enforcePermission1164; 
		public abstract void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingPermission1165; 
		public abstract void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfPermission1166; 
		public abstract void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _grantUriPermission1167; 
		public abstract void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _revokeUriPermission1168; 
		public abstract void revokeUriPermission(android.net.Uri arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1169; 
		public abstract int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1170; 
		public abstract int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5); 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingUriPermission1171; 
		public abstract int checkCallingUriPermission(android.net.Uri arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfUriPermission1172; 
		public abstract int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1173; 
		public abstract void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1174; 
		public abstract void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingUriPermission1175; 
		public abstract void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfUriPermission1176; 
		public abstract void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _createPackageContext1177; 
		public abstract android.content.Context createPackageContext(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _isRestricted1178; 
		public virtual bool isRestricted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Context)) 
				return @__env.CallBooleanMethod(this, _isRestricted1178); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.Context.staticClass, _isRestricted1178); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText1179; 
		public virtual java.lang.CharSequence getText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Context)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getText1179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Context.staticClass, _getText1179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1180; 
		public virtual android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Context)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _obtainStyledAttributes1180, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Context.staticClass, _obtainStyledAttributes1180, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1181; 
		public virtual android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Context)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _obtainStyledAttributes1181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Context.staticClass, _obtainStyledAttributes1181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1182; 
		public virtual android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Context)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _obtainStyledAttributes1182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Context.staticClass, _obtainStyledAttributes1182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1183; 
		public virtual android.content.res.TypedArray obtainStyledAttributes(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Context)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _obtainStyledAttributes1183, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Context.staticClass, _obtainStyledAttributes1183, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Context1184; 
		public Context()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.Context.staticClass, _Context1184, this); 
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
		public static java.lang.String POWER_SERVICE
		{ 
			get 
			{ 
				return "power"; 
			} 
		} 
		public static java.lang.String WINDOW_SERVICE
		{ 
			get 
			{ 
				return "window"; 
			} 
		} 
		public static java.lang.String LAYOUT_INFLATER_SERVICE
		{ 
			get 
			{ 
				return "layout_inflater"; 
			} 
		} 
		public static java.lang.String ACCOUNT_SERVICE
		{ 
			get 
			{ 
				return "account"; 
			} 
		} 
		public static java.lang.String ACTIVITY_SERVICE
		{ 
			get 
			{ 
				return "activity"; 
			} 
		} 
		public static java.lang.String ALARM_SERVICE
		{ 
			get 
			{ 
				return "alarm"; 
			} 
		} 
		public static java.lang.String NOTIFICATION_SERVICE
		{ 
			get 
			{ 
				return "notification"; 
			} 
		} 
		public static java.lang.String ACCESSIBILITY_SERVICE
		{ 
			get 
			{ 
				return "accessibility"; 
			} 
		} 
		public static java.lang.String KEYGUARD_SERVICE
		{ 
			get 
			{ 
				return "keyguard"; 
			} 
		} 
		public static java.lang.String LOCATION_SERVICE
		{ 
			get 
			{ 
				return "location"; 
			} 
		} 
		public static java.lang.String SEARCH_SERVICE
		{ 
			get 
			{ 
				return "search"; 
			} 
		} 
		public static java.lang.String SENSOR_SERVICE
		{ 
			get 
			{ 
				return "sensor"; 
			} 
		} 
		public static java.lang.String WALLPAPER_SERVICE
		{ 
			get 
			{ 
				return "wallpaper"; 
			} 
		} 
		public static java.lang.String VIBRATOR_SERVICE
		{ 
			get 
			{ 
				return "vibrator"; 
			} 
		} 
		public static java.lang.String CONNECTIVITY_SERVICE
		{ 
			get 
			{ 
				return "connectivity"; 
			} 
		} 
		public static java.lang.String WIFI_SERVICE
		{ 
			get 
			{ 
				return "wifi"; 
			} 
		} 
		public static java.lang.String AUDIO_SERVICE
		{ 
			get 
			{ 
				return "audio"; 
			} 
		} 
		public static java.lang.String TELEPHONY_SERVICE
		{ 
			get 
			{ 
				return "phone"; 
			} 
		} 
		public static java.lang.String CLIPBOARD_SERVICE
		{ 
			get 
			{ 
				return "clipboard"; 
			} 
		} 
		public static java.lang.String INPUT_METHOD_SERVICE
		{ 
			get 
			{ 
				return "input_method"; 
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
			global::android.content.Context._getClassLoader1110 = @__env.GetMethodID(global::android.content.Context.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;"); 
			global::android.content.Context._checkPermission1111 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkPermission", "(Ljava/lang/String;II)I"); 
			global::android.content.Context._getResources1112 = @__env.GetMethodID(global::android.content.Context.staticClass, "getResources", "()Landroid/content/res/Resources;"); 
			global::android.content.Context._getPackageName1113 = @__env.GetMethodID(global::android.content.Context.staticClass, "getPackageName", "()Ljava/lang/String;"); 
			global::android.content.Context._getString1114 = @__env.GetMethodID(global::android.content.Context.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;"); 
			global::android.content.Context._getString1115 = @__env.GetMethodID(global::android.content.Context.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.content.Context._getAssets1116 = @__env.GetMethodID(global::android.content.Context.staticClass, "getAssets", "()Landroid/content/res/AssetManager;"); 
			global::android.content.Context._getPackageManager1117 = @__env.GetMethodID(global::android.content.Context.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;"); 
			global::android.content.Context._getContentResolver1118 = @__env.GetMethodID(global::android.content.Context.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;"); 
			global::android.content.Context._getMainLooper1119 = @__env.GetMethodID(global::android.content.Context.staticClass, "getMainLooper", "()Landroid/os/Looper;"); 
			global::android.content.Context._getApplicationContext1120 = @__env.GetMethodID(global::android.content.Context.staticClass, "getApplicationContext", "()Landroid/content/Context;"); 
			global::android.content.Context._setTheme1121 = @__env.GetMethodID(global::android.content.Context.staticClass, "setTheme", "(I)V"); 
			global::android.content.Context._getTheme1122 = @__env.GetMethodID(global::android.content.Context.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;"); 
			global::android.content.Context._getApplicationInfo1123 = @__env.GetMethodID(global::android.content.Context.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;"); 
			global::android.content.Context._getSharedPreferences1124 = @__env.GetMethodID(global::android.content.Context.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;"); 
			global::android.content.Context._openFileInput1125 = @__env.GetMethodID(global::android.content.Context.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;"); 
			global::android.content.Context._openFileOutput1126 = @__env.GetMethodID(global::android.content.Context.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;"); 
			global::android.content.Context._deleteFile1127 = @__env.GetMethodID(global::android.content.Context.staticClass, "deleteFile", "(Ljava/lang/String;)Z"); 
			global::android.content.Context._getFileStreamPath1128 = @__env.GetMethodID(global::android.content.Context.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;"); 
			global::android.content.Context._fileList1129 = @__env.GetMethodID(global::android.content.Context.staticClass, "fileList", "()[Ljava/lang/String;"); 
			global::android.content.Context._getFilesDir1130 = @__env.GetMethodID(global::android.content.Context.staticClass, "getFilesDir", "()Ljava/io/File;"); 
			global::android.content.Context._getCacheDir1131 = @__env.GetMethodID(global::android.content.Context.staticClass, "getCacheDir", "()Ljava/io/File;"); 
			global::android.content.Context._getDir1132 = @__env.GetMethodID(global::android.content.Context.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;"); 
			global::android.content.Context._openOrCreateDatabase1133 = @__env.GetMethodID(global::android.content.Context.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.content.Context._deleteDatabase1134 = @__env.GetMethodID(global::android.content.Context.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z"); 
			global::android.content.Context._getDatabasePath1135 = @__env.GetMethodID(global::android.content.Context.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;"); 
			global::android.content.Context._databaseList1136 = @__env.GetMethodID(global::android.content.Context.staticClass, "databaseList", "()[Ljava/lang/String;"); 
			global::android.content.Context._getWallpaper1137 = @__env.GetMethodID(global::android.content.Context.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.content.Context._peekWallpaper1138 = @__env.GetMethodID(global::android.content.Context.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.content.Context._getWallpaperDesiredMinimumWidth1139 = @__env.GetMethodID(global::android.content.Context.staticClass, "getWallpaperDesiredMinimumWidth", "()I"); 
			global::android.content.Context._getWallpaperDesiredMinimumHeight1140 = @__env.GetMethodID(global::android.content.Context.staticClass, "getWallpaperDesiredMinimumHeight", "()I"); 
			global::android.content.Context._setWallpaper1141 = @__env.GetMethodID(global::android.content.Context.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V"); 
			global::android.content.Context._setWallpaper1142 = @__env.GetMethodID(global::android.content.Context.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V"); 
			global::android.content.Context._clearWallpaper1143 = @__env.GetMethodID(global::android.content.Context.staticClass, "clearWallpaper", "()V"); 
			global::android.content.Context._startActivity1144 = @__env.GetMethodID(global::android.content.Context.staticClass, "startActivity", "(Landroid/content/Intent;)V"); 
			global::android.content.Context._startIntentSender1145 = @__env.GetMethodID(global::android.content.Context.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V"); 
			global::android.content.Context._sendBroadcast1146 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V"); 
			global::android.content.Context._sendBroadcast1147 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V"); 
			global::android.content.Context._sendOrderedBroadcast1148 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V"); 
			global::android.content.Context._sendOrderedBroadcast1149 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.content.Context._sendStickyBroadcast1150 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V"); 
			global::android.content.Context._sendStickyOrderedBroadcast1151 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.content.Context._removeStickyBroadcast1152 = @__env.GetMethodID(global::android.content.Context.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V"); 
			global::android.content.Context._registerReceiver1153 = @__env.GetMethodID(global::android.content.Context.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;"); 
			global::android.content.Context._registerReceiver1154 = @__env.GetMethodID(global::android.content.Context.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;"); 
			global::android.content.Context._unregisterReceiver1155 = @__env.GetMethodID(global::android.content.Context.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V"); 
			global::android.content.Context._startService1156 = @__env.GetMethodID(global::android.content.Context.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;"); 
			global::android.content.Context._stopService1157 = @__env.GetMethodID(global::android.content.Context.staticClass, "stopService", "(Landroid/content/Intent;)Z"); 
			global::android.content.Context._bindService1158 = @__env.GetMethodID(global::android.content.Context.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z"); 
			global::android.content.Context._unbindService1159 = @__env.GetMethodID(global::android.content.Context.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V"); 
			global::android.content.Context._startInstrumentation1160 = @__env.GetMethodID(global::android.content.Context.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z"); 
			global::android.content.Context._getSystemService1161 = @__env.GetMethodID(global::android.content.Context.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::android.content.Context._checkCallingPermission1162 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I"); 
			global::android.content.Context._checkCallingOrSelfPermission1163 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I"); 
			global::android.content.Context._enforcePermission1164 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V"); 
			global::android.content.Context._enforceCallingPermission1165 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.Context._enforceCallingOrSelfPermission1166 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.Context._grantUriPermission1167 = @__env.GetMethodID(global::android.content.Context.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V"); 
			global::android.content.Context._revokeUriPermission1168 = @__env.GetMethodID(global::android.content.Context.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V"); 
			global::android.content.Context._checkUriPermission1169 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I"); 
			global::android.content.Context._checkUriPermission1170 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I"); 
			global::android.content.Context._checkCallingUriPermission1171 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I"); 
			global::android.content.Context._checkCallingOrSelfUriPermission1172 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I"); 
			global::android.content.Context._enforceUriPermission1173 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V"); 
			global::android.content.Context._enforceUriPermission1174 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V"); 
			global::android.content.Context._enforceCallingUriPermission1175 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V"); 
			global::android.content.Context._enforceCallingOrSelfUriPermission1176 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V"); 
			global::android.content.Context._createPackageContext1177 = @__env.GetMethodID(global::android.content.Context.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;"); 
			global::android.content.Context._isRestricted1178 = @__env.GetMethodID(global::android.content.Context.staticClass, "isRestricted", "()Z"); 
			global::android.content.Context._getText1179 = @__env.GetMethodID(global::android.content.Context.staticClass, "getText", "(I)Ljava/lang/CharSequence;"); 
			global::android.content.Context._obtainStyledAttributes1180 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;"); 
			global::android.content.Context._obtainStyledAttributes1181 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;"); 
			global::android.content.Context._obtainStyledAttributes1182 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;"); 
			global::android.content.Context._obtainStyledAttributes1183 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;"); 
			global::android.content.Context._Context1184 = @__env.GetMethodID(global::android.content.Context.staticClass, "<init>", "()V"); 
		} 
	} 
} 
