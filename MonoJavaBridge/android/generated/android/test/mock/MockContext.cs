namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockContext : android.content.Context
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MockContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			get
			{
				return getClassLoader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader12398;
		public override global::java.lang.ClassLoader getClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getClassLoader12398.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getClassLoader12398 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getClassLoader12398) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission12399;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._checkPermission12399.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._checkPermission12399 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkPermission", "(Ljava/lang/String;II)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkPermission12399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources12400;
		public override global::android.content.res.Resources getResources()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getResources12400.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getResources12400 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getResources", "()Landroid/content/res/Resources;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getResources12400) as android.content.res.Resources;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName12401;
		public override global::java.lang.String getPackageName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getPackageName12401.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getPackageName12401 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getPackageName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getPackageName12401) as java.lang.String;
		}
		public new global::android.content.res.AssetManager Assets
		{
			get
			{
				return getAssets();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAssets12402;
		public override global::android.content.res.AssetManager getAssets()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getAssets12402.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getAssets12402 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.AssetManager>(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getAssets12402) as android.content.res.AssetManager;
		}
		public new global::android.content.pm.PackageManager PackageManager
		{
			get
			{
				return getPackageManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageManager12403;
		public override global::android.content.pm.PackageManager getPackageManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getPackageManager12403.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getPackageManager12403 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getPackageManager12403) as android.content.pm.PackageManager;
		}
		public new global::android.content.ContentResolver ContentResolver
		{
			get
			{
				return getContentResolver();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentResolver12404;
		public override global::android.content.ContentResolver getContentResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getContentResolver12404.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getContentResolver12404 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getContentResolver12404) as android.content.ContentResolver;
		}
		public new global::android.os.Looper MainLooper
		{
			get
			{
				return getMainLooper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMainLooper12405;
		public override global::android.os.Looper getMainLooper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getMainLooper12405.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getMainLooper12405 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getMainLooper12405) as android.os.Looper;
		}
		public new global::android.content.Context ApplicationContext
		{
			get
			{
				return getApplicationContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationContext12406;
		public override global::android.content.Context getApplicationContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getApplicationContext12406.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getApplicationContext12406 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getApplicationContext", "()Landroid/content/Context;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getApplicationContext12406) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setTheme12407;
		public override void setTheme(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._setTheme12407.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._setTheme12407 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "setTheme", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._setTheme12407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.Resources.Theme Theme
		{
			get
			{
				return getTheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTheme12408;
		public override global::android.content.res.Resources.Theme getTheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getTheme12408.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getTheme12408 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.Resources.Theme>(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getTheme12408) as android.content.res.Resources.Theme;
		}
		public new global::android.content.pm.ApplicationInfo ApplicationInfo
		{
			get
			{
				return getApplicationInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo12409;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getApplicationInfo12409.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getApplicationInfo12409 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getApplicationInfo12409) as android.content.pm.ApplicationInfo;
		}
		public new global::java.lang.String PackageResourcePath
		{
			get
			{
				return getPackageResourcePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageResourcePath12410;
		public override global::java.lang.String getPackageResourcePath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getPackageResourcePath12410.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getPackageResourcePath12410 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getPackageResourcePath", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getPackageResourcePath12410) as java.lang.String;
		}
		public new global::java.lang.String PackageCodePath
		{
			get
			{
				return getPackageCodePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageCodePath12411;
		public override global::java.lang.String getPackageCodePath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getPackageCodePath12411.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getPackageCodePath12411 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getPackageCodePath", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getPackageCodePath12411) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences12412;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getSharedPreferences12412.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getSharedPreferences12412 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences>(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getSharedPreferences12412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _openFileInput12413;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._openFileInput12413.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._openFileInput12413 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._openFileInput12413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFileOutput12414;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._openFileOutput12414.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._openFileOutput12414 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._openFileOutput12414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _deleteFile12415;
		public override bool deleteFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._deleteFile12415.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._deleteFile12415 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._deleteFile12415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath12416;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getFileStreamPath12416.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getFileStreamPath12416 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getFileStreamPath12416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _fileList12417;
		public override global::java.lang.String[] fileList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._fileList12417.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._fileList12417 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "fileList", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._fileList12417) as java.lang.String[];
		}
		public new global::java.io.File FilesDir
		{
			get
			{
				return getFilesDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilesDir12418;
		public override global::java.io.File getFilesDir()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getFilesDir12418.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getFilesDir12418 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getFilesDir", "()Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getFilesDir12418) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalFilesDir12419;
		public override global::java.io.File getExternalFilesDir(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getExternalFilesDir12419.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getExternalFilesDir12419 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getExternalFilesDir12419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		public new global::java.io.File CacheDir
		{
			get
			{
				return getCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheDir12420;
		public override global::java.io.File getCacheDir()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getCacheDir12420.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getCacheDir12420 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getCacheDir", "()Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getCacheDir12420) as java.io.File;
		}
		public new global::java.io.File ExternalCacheDir
		{
			get
			{
				return getExternalCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExternalCacheDir12421;
		public override global::java.io.File getExternalCacheDir()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getExternalCacheDir12421.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getExternalCacheDir12421 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getExternalCacheDir", "()Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getExternalCacheDir12421) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getDir12422;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getDir12422.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getDir12422 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getDir12422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase12423;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._openOrCreateDatabase12423.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._openOrCreateDatabase12423 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._openOrCreateDatabase12423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.database.sqlite.SQLiteDatabase;
		}
		public android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg2)
		{
			return openOrCreateDatabase(arg0, arg1, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _deleteDatabase12424;
		public override bool deleteDatabase(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._deleteDatabase12424.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._deleteDatabase12424 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._deleteDatabase12424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath12425;
		public override global::java.io.File getDatabasePath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getDatabasePath12425.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getDatabasePath12425 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getDatabasePath12425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _databaseList12426;
		public override global::java.lang.String[] databaseList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._databaseList12426.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._databaseList12426 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "databaseList", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._databaseList12426) as java.lang.String[];
		}
		public new global::android.graphics.drawable.Drawable Wallpaper
		{
			get
			{
				return getWallpaper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaper12427;
		public override global::android.graphics.drawable.Drawable getWallpaper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getWallpaper12427.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getWallpaper12427 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getWallpaper12427) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _peekWallpaper12428;
		public override global::android.graphics.drawable.Drawable peekWallpaper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._peekWallpaper12428.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._peekWallpaper12428 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._peekWallpaper12428) as android.graphics.drawable.Drawable;
		}
		public new int WallpaperDesiredMinimumWidth
		{
			get
			{
				return getWallpaperDesiredMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth12429;
		public override int getWallpaperDesiredMinimumWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getWallpaperDesiredMinimumWidth12429.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getWallpaperDesiredMinimumWidth12429 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getWallpaperDesiredMinimumWidth12429);
		}
		public new int WallpaperDesiredMinimumHeight
		{
			get
			{
				return getWallpaperDesiredMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight12430;
		public override int getWallpaperDesiredMinimumHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getWallpaperDesiredMinimumHeight12430.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getWallpaperDesiredMinimumHeight12430 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getWallpaperDesiredMinimumHeight12430);
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper12431;
		public override void setWallpaper(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._setWallpaper12431.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._setWallpaper12431 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._setWallpaper12431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper12432;
		public override void setWallpaper(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._setWallpaper12432.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._setWallpaper12432 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._setWallpaper12432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearWallpaper12433;
		public override void clearWallpaper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._clearWallpaper12433.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._clearWallpaper12433 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "clearWallpaper", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._clearWallpaper12433);
		}
		internal static global::MonoJavaBridge.MethodId _startActivity12434;
		public override void startActivity(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._startActivity12434.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._startActivity12434 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._startActivity12434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSender12435;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._startIntentSender12435.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._startIntentSender12435 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._startIntentSender12435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast12436;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._sendBroadcast12436.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._sendBroadcast12436 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendBroadcast12436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast12437;
		public override void sendBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._sendBroadcast12437.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._sendBroadcast12437 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendBroadcast12437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast12438;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._sendOrderedBroadcast12438.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._sendOrderedBroadcast12438 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendOrderedBroadcast12438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast12439;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._sendOrderedBroadcast12439.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._sendOrderedBroadcast12439 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendOrderedBroadcast12439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyBroadcast12440;
		public override void sendStickyBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._sendStickyBroadcast12440.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._sendStickyBroadcast12440 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendStickyBroadcast12440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyOrderedBroadcast12441;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._sendStickyOrderedBroadcast12441.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._sendStickyOrderedBroadcast12441 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendStickyOrderedBroadcast12441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _removeStickyBroadcast12442;
		public override void removeStickyBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._removeStickyBroadcast12442.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._removeStickyBroadcast12442 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._removeStickyBroadcast12442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver12443;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._registerReceiver12443.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._registerReceiver12443 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._registerReceiver12443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver12444;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._registerReceiver12444.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._registerReceiver12444 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._registerReceiver12444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _unregisterReceiver12445;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._unregisterReceiver12445.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._unregisterReceiver12445 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._unregisterReceiver12445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startService12446;
		public override global::android.content.ComponentName startService(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._startService12446.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._startService12446 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._startService12446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _stopService12447;
		public override bool stopService(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._stopService12447.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._stopService12447 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "stopService", "(Landroid/content/Intent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._stopService12447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindService12448;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._bindService12448.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._bindService12448 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._bindService12448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unbindService12449;
		public override void unbindService(android.content.ServiceConnection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._unbindService12449.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._unbindService12449 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._unbindService12449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInstrumentation12450;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._startInstrumentation12450.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._startInstrumentation12450 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._startInstrumentation12450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService12451;
		public override global::java.lang.Object getSystemService(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._getSystemService12451.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._getSystemService12451 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getSystemService12451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingPermission12452;
		public override int checkCallingPermission(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._checkCallingPermission12452.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._checkCallingPermission12452 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkCallingPermission12452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfPermission12453;
		public override int checkCallingOrSelfPermission(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._checkCallingOrSelfPermission12453.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._checkCallingOrSelfPermission12453 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkCallingOrSelfPermission12453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enforcePermission12454;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._enforcePermission12454.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._enforcePermission12454 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforcePermission12454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingPermission12455;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._enforceCallingPermission12455.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._enforceCallingPermission12455 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceCallingPermission12455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfPermission12456;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._enforceCallingOrSelfPermission12456.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._enforceCallingOrSelfPermission12456 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceCallingOrSelfPermission12456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _grantUriPermission12457;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._grantUriPermission12457.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._grantUriPermission12457 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._grantUriPermission12457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _revokeUriPermission12458;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._revokeUriPermission12458.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._revokeUriPermission12458 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._revokeUriPermission12458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission12459;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._checkUriPermission12459.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._checkUriPermission12459 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkUriPermission12459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission12460;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._checkUriPermission12460.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._checkUriPermission12460 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkUriPermission12460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingUriPermission12461;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._checkCallingUriPermission12461.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._checkCallingUriPermission12461 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkCallingUriPermission12461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfUriPermission12462;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._checkCallingOrSelfUriPermission12462.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._checkCallingOrSelfUriPermission12462 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkCallingOrSelfUriPermission12462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission12463;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._enforceUriPermission12463.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._enforceUriPermission12463 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceUriPermission12463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission12464;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._enforceUriPermission12464.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._enforceUriPermission12464 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceUriPermission12464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingUriPermission12465;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._enforceCallingUriPermission12465.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._enforceCallingUriPermission12465 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceCallingUriPermission12465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfUriPermission12466;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._enforceCallingOrSelfUriPermission12466.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._enforceCallingOrSelfUriPermission12466 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceCallingOrSelfUriPermission12466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createPackageContext12467;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._createPackageContext12467.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._createPackageContext12467 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._createPackageContext12467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isRestricted12468;
		public override bool isRestricted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._isRestricted12468.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._isRestricted12468 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "isRestricted", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._isRestricted12468);
		}
		internal static global::MonoJavaBridge.MethodId _MockContext12469;
		public MockContext() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContext._MockContext12469.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContext._MockContext12469 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._MockContext12469);
			Init(@__env, handle);
		}
		static MockContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockContext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
