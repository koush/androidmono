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
		internal static global::net.sf.jni4net.jni.MethodId _getClassLoader1125; 
		public abstract global::java.lang.ClassLoader getClassLoader(); 
		internal static global::net.sf.jni4net.jni.MethodId _checkPermission1126; 
		public abstract int checkPermission(java.lang.String arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getResources1127; 
		public abstract global::android.content.res.Resources getResources(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName1128; 
		public abstract global::java.lang.String getPackageName(); 
		internal static global::net.sf.jni4net.jni.MethodId _getString1129; 
		public virtual global::java.lang.String getString(int arg0, java.lang.Object[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._getString1129, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._getString1129, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString1130; 
		public virtual global::java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._getString1130, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._getString1130, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAssets1131; 
		public abstract global::android.content.res.AssetManager getAssets(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageManager1132; 
		public abstract global::android.content.pm.PackageManager getPackageManager(); 
		internal static global::net.sf.jni4net.jni.MethodId _getContentResolver1133; 
		public abstract global::android.content.ContentResolver getContentResolver(); 
		internal static global::net.sf.jni4net.jni.MethodId _getMainLooper1134; 
		public abstract global::android.os.Looper getMainLooper(); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationContext1135; 
		public abstract global::android.content.Context getApplicationContext(); 
		internal static global::net.sf.jni4net.jni.MethodId _setTheme1136; 
		public abstract void setTheme(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getTheme1137; 
		public abstract global::android.content.res.Resources.Theme getTheme(); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationInfo1138; 
		public abstract global::android.content.pm.ApplicationInfo getApplicationInfo(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences1139; 
		public abstract global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _openFileInput1140; 
		public abstract global::java.io.FileInputStream openFileInput(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _openFileOutput1141; 
		public abstract global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _deleteFile1142; 
		public abstract bool deleteFile(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getFileStreamPath1143; 
		public abstract global::java.io.File getFileStreamPath(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _fileList1144; 
		public abstract global::java.lang.String[] fileList(); 
		internal static global::net.sf.jni4net.jni.MethodId _getFilesDir1145; 
		public abstract global::java.io.File getFilesDir(); 
		internal static global::net.sf.jni4net.jni.MethodId _getCacheDir1146; 
		public abstract global::java.io.File getCacheDir(); 
		internal static global::net.sf.jni4net.jni.MethodId _getDir1147; 
		public abstract global::java.io.File getDir(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase1148; 
		public abstract global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _deleteDatabase1149; 
		public abstract bool deleteDatabase(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getDatabasePath1150; 
		public abstract global::java.io.File getDatabasePath(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _databaseList1151; 
		public abstract global::java.lang.String[] databaseList(); 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaper1152; 
		public abstract global::android.graphics.drawable.Drawable getWallpaper(); 
		internal static global::net.sf.jni4net.jni.MethodId _peekWallpaper1153; 
		public abstract global::android.graphics.drawable.Drawable peekWallpaper(); 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumWidth1154; 
		public abstract int getWallpaperDesiredMinimumWidth(); 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumHeight1155; 
		public abstract int getWallpaperDesiredMinimumHeight(); 
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1156; 
		public abstract void setWallpaper(java.io.InputStream arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1157; 
		public abstract void setWallpaper(android.graphics.Bitmap arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _clearWallpaper1158; 
		public abstract void clearWallpaper(); 
		internal static global::net.sf.jni4net.jni.MethodId _startActivity1159; 
		public abstract void startActivity(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSender1160; 
		public abstract void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1161; 
		public abstract void sendBroadcast(android.content.Intent arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1162; 
		public abstract void sendBroadcast(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1163; 
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1164; 
		public abstract void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6); 
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyBroadcast1165; 
		public abstract void sendStickyBroadcast(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyOrderedBroadcast1166; 
		public abstract void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5); 
		internal static global::net.sf.jni4net.jni.MethodId _removeStickyBroadcast1167; 
		public abstract void removeStickyBroadcast(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1168; 
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1169; 
		public abstract global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterReceiver1170; 
		public abstract void unregisterReceiver(android.content.BroadcastReceiver arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _startService1171; 
		public abstract global::android.content.ComponentName startService(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _stopService1172; 
		public abstract bool stopService(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _bindService1173; 
		public abstract bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _unbindService1174; 
		public abstract void unbindService(android.content.ServiceConnection arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _startInstrumentation1175; 
		public abstract bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService1176; 
		public abstract global::java.lang.Object getSystemService(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingPermission1177; 
		public abstract int checkCallingPermission(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfPermission1178; 
		public abstract int checkCallingOrSelfPermission(java.lang.String arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _enforcePermission1179; 
		public abstract void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingPermission1180; 
		public abstract void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfPermission1181; 
		public abstract void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _grantUriPermission1182; 
		public abstract void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _revokeUriPermission1183; 
		public abstract void revokeUriPermission(android.net.Uri arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1184; 
		public abstract int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1185; 
		public abstract int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5); 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingUriPermission1186; 
		public abstract int checkCallingUriPermission(android.net.Uri arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfUriPermission1187; 
		public abstract int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1188; 
		public abstract void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1189; 
		public abstract void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingUriPermission1190; 
		public abstract void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfUriPermission1191; 
		public abstract void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _createPackageContext1192; 
		public abstract global::android.content.Context createPackageContext(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _isRestricted1193; 
		public virtual bool isRestricted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.content.Context._isRestricted1193); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.Context.staticClass, global::android.content.Context._isRestricted1193); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText1194; 
		public virtual global::java.lang.CharSequence getText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._getText1194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._getText1194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1195; 
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._obtainStyledAttributes1195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1196; 
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._obtainStyledAttributes1196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1197; 
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._obtainStyledAttributes1197, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1197, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtainStyledAttributes1198; 
		public virtual global::android.content.res.TypedArray obtainStyledAttributes(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.Context._obtainStyledAttributes1198, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.Context.staticClass, global::android.content.Context._obtainStyledAttributes1198, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Context1199; 
		public Context()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.Context.staticClass, global::android.content.Context._Context1199, this); 
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
			global::android.content.Context._getClassLoader1125 = @__env.GetMethodID(global::android.content.Context.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;"); 
			global::android.content.Context._checkPermission1126 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkPermission", "(Ljava/lang/String;II)I"); 
			global::android.content.Context._getResources1127 = @__env.GetMethodID(global::android.content.Context.staticClass, "getResources", "()Landroid/content/res/Resources;"); 
			global::android.content.Context._getPackageName1128 = @__env.GetMethodID(global::android.content.Context.staticClass, "getPackageName", "()Ljava/lang/String;"); 
			global::android.content.Context._getString1129 = @__env.GetMethodID(global::android.content.Context.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;"); 
			global::android.content.Context._getString1130 = @__env.GetMethodID(global::android.content.Context.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.content.Context._getAssets1131 = @__env.GetMethodID(global::android.content.Context.staticClass, "getAssets", "()Landroid/content/res/AssetManager;"); 
			global::android.content.Context._getPackageManager1132 = @__env.GetMethodID(global::android.content.Context.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;"); 
			global::android.content.Context._getContentResolver1133 = @__env.GetMethodID(global::android.content.Context.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;"); 
			global::android.content.Context._getMainLooper1134 = @__env.GetMethodID(global::android.content.Context.staticClass, "getMainLooper", "()Landroid/os/Looper;"); 
			global::android.content.Context._getApplicationContext1135 = @__env.GetMethodID(global::android.content.Context.staticClass, "getApplicationContext", "()Landroid/content/Context;"); 
			global::android.content.Context._setTheme1136 = @__env.GetMethodID(global::android.content.Context.staticClass, "setTheme", "(I)V"); 
			global::android.content.Context._getTheme1137 = @__env.GetMethodID(global::android.content.Context.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;"); 
			global::android.content.Context._getApplicationInfo1138 = @__env.GetMethodID(global::android.content.Context.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;"); 
			global::android.content.Context._getSharedPreferences1139 = @__env.GetMethodID(global::android.content.Context.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;"); 
			global::android.content.Context._openFileInput1140 = @__env.GetMethodID(global::android.content.Context.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;"); 
			global::android.content.Context._openFileOutput1141 = @__env.GetMethodID(global::android.content.Context.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;"); 
			global::android.content.Context._deleteFile1142 = @__env.GetMethodID(global::android.content.Context.staticClass, "deleteFile", "(Ljava/lang/String;)Z"); 
			global::android.content.Context._getFileStreamPath1143 = @__env.GetMethodID(global::android.content.Context.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;"); 
			global::android.content.Context._fileList1144 = @__env.GetMethodID(global::android.content.Context.staticClass, "fileList", "()[Ljava/lang/String;"); 
			global::android.content.Context._getFilesDir1145 = @__env.GetMethodID(global::android.content.Context.staticClass, "getFilesDir", "()Ljava/io/File;"); 
			global::android.content.Context._getCacheDir1146 = @__env.GetMethodID(global::android.content.Context.staticClass, "getCacheDir", "()Ljava/io/File;"); 
			global::android.content.Context._getDir1147 = @__env.GetMethodID(global::android.content.Context.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;"); 
			global::android.content.Context._openOrCreateDatabase1148 = @__env.GetMethodID(global::android.content.Context.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.content.Context._deleteDatabase1149 = @__env.GetMethodID(global::android.content.Context.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z"); 
			global::android.content.Context._getDatabasePath1150 = @__env.GetMethodID(global::android.content.Context.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;"); 
			global::android.content.Context._databaseList1151 = @__env.GetMethodID(global::android.content.Context.staticClass, "databaseList", "()[Ljava/lang/String;"); 
			global::android.content.Context._getWallpaper1152 = @__env.GetMethodID(global::android.content.Context.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.content.Context._peekWallpaper1153 = @__env.GetMethodID(global::android.content.Context.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.content.Context._getWallpaperDesiredMinimumWidth1154 = @__env.GetMethodID(global::android.content.Context.staticClass, "getWallpaperDesiredMinimumWidth", "()I"); 
			global::android.content.Context._getWallpaperDesiredMinimumHeight1155 = @__env.GetMethodID(global::android.content.Context.staticClass, "getWallpaperDesiredMinimumHeight", "()I"); 
			global::android.content.Context._setWallpaper1156 = @__env.GetMethodID(global::android.content.Context.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V"); 
			global::android.content.Context._setWallpaper1157 = @__env.GetMethodID(global::android.content.Context.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V"); 
			global::android.content.Context._clearWallpaper1158 = @__env.GetMethodID(global::android.content.Context.staticClass, "clearWallpaper", "()V"); 
			global::android.content.Context._startActivity1159 = @__env.GetMethodID(global::android.content.Context.staticClass, "startActivity", "(Landroid/content/Intent;)V"); 
			global::android.content.Context._startIntentSender1160 = @__env.GetMethodID(global::android.content.Context.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V"); 
			global::android.content.Context._sendBroadcast1161 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V"); 
			global::android.content.Context._sendBroadcast1162 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V"); 
			global::android.content.Context._sendOrderedBroadcast1163 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V"); 
			global::android.content.Context._sendOrderedBroadcast1164 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.content.Context._sendStickyBroadcast1165 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V"); 
			global::android.content.Context._sendStickyOrderedBroadcast1166 = @__env.GetMethodID(global::android.content.Context.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.content.Context._removeStickyBroadcast1167 = @__env.GetMethodID(global::android.content.Context.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V"); 
			global::android.content.Context._registerReceiver1168 = @__env.GetMethodID(global::android.content.Context.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;"); 
			global::android.content.Context._registerReceiver1169 = @__env.GetMethodID(global::android.content.Context.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;"); 
			global::android.content.Context._unregisterReceiver1170 = @__env.GetMethodID(global::android.content.Context.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V"); 
			global::android.content.Context._startService1171 = @__env.GetMethodID(global::android.content.Context.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;"); 
			global::android.content.Context._stopService1172 = @__env.GetMethodID(global::android.content.Context.staticClass, "stopService", "(Landroid/content/Intent;)Z"); 
			global::android.content.Context._bindService1173 = @__env.GetMethodID(global::android.content.Context.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z"); 
			global::android.content.Context._unbindService1174 = @__env.GetMethodID(global::android.content.Context.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V"); 
			global::android.content.Context._startInstrumentation1175 = @__env.GetMethodID(global::android.content.Context.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z"); 
			global::android.content.Context._getSystemService1176 = @__env.GetMethodID(global::android.content.Context.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::android.content.Context._checkCallingPermission1177 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I"); 
			global::android.content.Context._checkCallingOrSelfPermission1178 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I"); 
			global::android.content.Context._enforcePermission1179 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V"); 
			global::android.content.Context._enforceCallingPermission1180 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.Context._enforceCallingOrSelfPermission1181 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.Context._grantUriPermission1182 = @__env.GetMethodID(global::android.content.Context.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V"); 
			global::android.content.Context._revokeUriPermission1183 = @__env.GetMethodID(global::android.content.Context.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V"); 
			global::android.content.Context._checkUriPermission1184 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I"); 
			global::android.content.Context._checkUriPermission1185 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I"); 
			global::android.content.Context._checkCallingUriPermission1186 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I"); 
			global::android.content.Context._checkCallingOrSelfUriPermission1187 = @__env.GetMethodID(global::android.content.Context.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I"); 
			global::android.content.Context._enforceUriPermission1188 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V"); 
			global::android.content.Context._enforceUriPermission1189 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V"); 
			global::android.content.Context._enforceCallingUriPermission1190 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V"); 
			global::android.content.Context._enforceCallingOrSelfUriPermission1191 = @__env.GetMethodID(global::android.content.Context.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V"); 
			global::android.content.Context._createPackageContext1192 = @__env.GetMethodID(global::android.content.Context.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;"); 
			global::android.content.Context._isRestricted1193 = @__env.GetMethodID(global::android.content.Context.staticClass, "isRestricted", "()Z"); 
			global::android.content.Context._getText1194 = @__env.GetMethodID(global::android.content.Context.staticClass, "getText", "(I)Ljava/lang/CharSequence;"); 
			global::android.content.Context._obtainStyledAttributes1195 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;"); 
			global::android.content.Context._obtainStyledAttributes1196 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;"); 
			global::android.content.Context._obtainStyledAttributes1197 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;"); 
			global::android.content.Context._obtainStyledAttributes1198 = @__env.GetMethodID(global::android.content.Context.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;"); 
			global::android.content.Context._Context1199 = @__env.GetMethodID(global::android.content.Context.staticClass, "<init>", "()V"); 
		} 
	} 
} 
