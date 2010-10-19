namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContextWrapper : android.content.Context
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContextWrapper()
		{
			InitJNI();
		}
		protected ContextWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			get
			{
				return getClassLoader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader1435;
		public override global::java.lang.ClassLoader getClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getClassLoader1435)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getClassLoader1435)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission1436;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkPermission1436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkPermission1436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources1437;
		public override global::android.content.res.Resources getResources() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getResources1437)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getResources1437)) as android.content.res.Resources;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName1438;
		public override global::java.lang.String getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getPackageName1438)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageName1438)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _attachBaseContext1439;
		protected virtual void attachBaseContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._attachBaseContext1439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._attachBaseContext1439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.Context BaseContext
		{
			get
			{
				return getBaseContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseContext1440;
		public virtual global::android.content.Context getBaseContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getBaseContext1440)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getBaseContext1440)) as android.content.Context;
		}
		public new global::android.content.res.AssetManager Assets
		{
			get
			{
				return getAssets();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAssets1441;
		public override global::android.content.res.AssetManager getAssets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getAssets1441)) as android.content.res.AssetManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getAssets1441)) as android.content.res.AssetManager;
		}
		public new global::android.content.pm.PackageManager PackageManager
		{
			get
			{
				return getPackageManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageManager1442;
		public override global::android.content.pm.PackageManager getPackageManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getPackageManager1442)) as android.content.pm.PackageManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageManager1442)) as android.content.pm.PackageManager;
		}
		public new global::android.content.ContentResolver ContentResolver
		{
			get
			{
				return getContentResolver();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentResolver1443;
		public override global::android.content.ContentResolver getContentResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getContentResolver1443)) as android.content.ContentResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getContentResolver1443)) as android.content.ContentResolver;
		}
		public new global::android.os.Looper MainLooper
		{
			get
			{
				return getMainLooper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMainLooper1444;
		public override global::android.os.Looper getMainLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getMainLooper1444)) as android.os.Looper;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getMainLooper1444)) as android.os.Looper;
		}
		public new global::android.content.Context ApplicationContext
		{
			get
			{
				return getApplicationContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationContext1445;
		public override global::android.content.Context getApplicationContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getApplicationContext1445)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getApplicationContext1445)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setTheme1446;
		public override void setTheme(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._setTheme1446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setTheme1446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.Resources.Theme Theme
		{
			get
			{
				return getTheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTheme1447;
		public override global::android.content.res.Resources.Theme getTheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getTheme1447)) as android.content.res.Resources.Theme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getTheme1447)) as android.content.res.Resources.Theme;
		}
		public new global::android.content.pm.ApplicationInfo ApplicationInfo
		{
			get
			{
				return getApplicationInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo1448;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getApplicationInfo1448)) as android.content.pm.ApplicationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getApplicationInfo1448)) as android.content.pm.ApplicationInfo;
		}
		public new global::java.lang.String PackageResourcePath
		{
			get
			{
				return getPackageResourcePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageResourcePath1449;
		public override global::java.lang.String getPackageResourcePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getPackageResourcePath1449)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageResourcePath1449)) as java.lang.String;
		}
		public new global::java.lang.String PackageCodePath
		{
			get
			{
				return getPackageCodePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageCodePath1450;
		public override global::java.lang.String getPackageCodePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getPackageCodePath1450)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageCodePath1450)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences1451;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getSharedPreferences1451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getSharedPreferences1451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _openFileInput1452;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._openFileInput1452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openFileInput1452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFileOutput1453;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._openFileOutput1453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openFileOutput1453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _deleteFile1454;
		public override bool deleteFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._deleteFile1454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._deleteFile1454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath1455;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getFileStreamPath1455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getFileStreamPath1455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _fileList1456;
		public override global::java.lang.String[] fileList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._fileList1456)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._fileList1456)) as java.lang.String[];
		}
		public new global::java.io.File FilesDir
		{
			get
			{
				return getFilesDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilesDir1457;
		public override global::java.io.File getFilesDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getFilesDir1457)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getFilesDir1457)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalFilesDir1458;
		public override global::java.io.File getExternalFilesDir(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getExternalFilesDir1458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getExternalFilesDir1458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		public new global::java.io.File CacheDir
		{
			get
			{
				return getCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheDir1459;
		public override global::java.io.File getCacheDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getCacheDir1459)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getCacheDir1459)) as java.io.File;
		}
		public new global::java.io.File ExternalCacheDir
		{
			get
			{
				return getExternalCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExternalCacheDir1460;
		public override global::java.io.File getExternalCacheDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getExternalCacheDir1460)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getExternalCacheDir1460)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getDir1461;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getDir1461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getDir1461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase1462;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._openOrCreateDatabase1462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openOrCreateDatabase1462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _deleteDatabase1463;
		public override bool deleteDatabase(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._deleteDatabase1463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._deleteDatabase1463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath1464;
		public override global::java.io.File getDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getDatabasePath1464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getDatabasePath1464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _databaseList1465;
		public override global::java.lang.String[] databaseList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._databaseList1465)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._databaseList1465)) as java.lang.String[];
		}
		public new global::android.graphics.drawable.Drawable Wallpaper
		{
			get
			{
				return getWallpaper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaper1466;
		public override global::android.graphics.drawable.Drawable getWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getWallpaper1466)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaper1466)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _peekWallpaper1467;
		public override global::android.graphics.drawable.Drawable peekWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._peekWallpaper1467)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._peekWallpaper1467)) as android.graphics.drawable.Drawable;
		}
		public new int WallpaperDesiredMinimumWidth
		{
			get
			{
				return getWallpaperDesiredMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth1468;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1468);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1468);
		}
		public new int WallpaperDesiredMinimumHeight
		{
			get
			{
				return getWallpaperDesiredMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight1469;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1469);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1469);
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper1470;
		public override void setWallpaper(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._setWallpaper1470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setWallpaper1470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper1471;
		public override void setWallpaper(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._setWallpaper1471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setWallpaper1471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearWallpaper1472;
		public override void clearWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._clearWallpaper1472);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._clearWallpaper1472);
		}
		internal static global::MonoJavaBridge.MethodId _startActivity1473;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._startActivity1473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startActivity1473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSender1474;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._startIntentSender1474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startIntentSender1474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast1475;
		public override void sendBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendBroadcast1475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendBroadcast1475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast1476;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendBroadcast1476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendBroadcast1476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast1477;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendOrderedBroadcast1477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendOrderedBroadcast1477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast1478;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendOrderedBroadcast1478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendOrderedBroadcast1478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyBroadcast1479;
		public override void sendStickyBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendStickyBroadcast1479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendStickyBroadcast1479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyOrderedBroadcast1480;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._sendStickyOrderedBroadcast1480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendStickyOrderedBroadcast1480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _removeStickyBroadcast1481;
		public override void removeStickyBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._removeStickyBroadcast1481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._removeStickyBroadcast1481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver1482;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._registerReceiver1482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._registerReceiver1482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver1483;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._registerReceiver1483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._registerReceiver1483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _unregisterReceiver1484;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._unregisterReceiver1484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._unregisterReceiver1484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startService1485;
		public override global::android.content.ComponentName startService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._startService1485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startService1485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _stopService1486;
		public override bool stopService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._stopService1486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._stopService1486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindService1487;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._bindService1487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._bindService1487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unbindService1488;
		public override void unbindService(android.content.ServiceConnection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._unbindService1488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._unbindService1488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInstrumentation1489;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._startInstrumentation1489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startInstrumentation1489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService1490;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._getSystemService1490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getSystemService1490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingPermission1491;
		public override int checkCallingPermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkCallingPermission1491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingPermission1491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfPermission1492;
		public override int checkCallingOrSelfPermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkCallingOrSelfPermission1492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingOrSelfPermission1492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enforcePermission1493;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforcePermission1493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforcePermission1493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingPermission1494;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceCallingPermission1494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingPermission1494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfPermission1495;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceCallingOrSelfPermission1495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingOrSelfPermission1495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _grantUriPermission1496;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._grantUriPermission1496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._grantUriPermission1496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _revokeUriPermission1497;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._revokeUriPermission1497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._revokeUriPermission1497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission1498;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkUriPermission1498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkUriPermission1498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission1499;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkUriPermission1499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkUriPermission1499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingUriPermission1500;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkCallingUriPermission1500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingUriPermission1500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfUriPermission1501;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission1502;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceUriPermission1502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceUriPermission1502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission1503;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceUriPermission1503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceUriPermission1503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingUriPermission1504;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceCallingUriPermission1504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingUriPermission1504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfUriPermission1505;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createPackageContext1506;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContextWrapper._createPackageContext1506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._createPackageContext1506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isRestricted1507;
		public override bool isRestricted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper._isRestricted1507);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._isRestricted1507);
		}
		internal static global::MonoJavaBridge.MethodId _ContextWrapper1508;
		public ContextWrapper(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._ContextWrapper1508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContextWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContextWrapper"));
			global::android.content.ContextWrapper._getClassLoader1435 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::android.content.ContextWrapper._checkPermission1436 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkPermission", "(Ljava/lang/String;II)I");
			global::android.content.ContextWrapper._getResources1437 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.ContextWrapper._getPackageName1438 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._attachBaseContext1439 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "attachBaseContext", "(Landroid/content/Context;)V");
			global::android.content.ContextWrapper._getBaseContext1440 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getBaseContext", "()Landroid/content/Context;");
			global::android.content.ContextWrapper._getAssets1441 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.content.ContextWrapper._getPackageManager1442 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;");
			global::android.content.ContextWrapper._getContentResolver1443 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			global::android.content.ContextWrapper._getMainLooper1444 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.content.ContextWrapper._getApplicationContext1445 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getApplicationContext", "()Landroid/content/Context;");
			global::android.content.ContextWrapper._setTheme1446 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "setTheme", "(I)V");
			global::android.content.ContextWrapper._getTheme1447 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.content.ContextWrapper._getApplicationInfo1448 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;");
			global::android.content.ContextWrapper._getPackageResourcePath1449 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getPackageResourcePath", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._getPackageCodePath1450 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getPackageCodePath", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._getSharedPreferences1451 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			global::android.content.ContextWrapper._openFileInput1452 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.content.ContextWrapper._openFileOutput1453 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.content.ContextWrapper._deleteFile1454 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.content.ContextWrapper._getFileStreamPath1455 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._fileList1456 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.content.ContextWrapper._getFilesDir1457 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getFilesDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getExternalFilesDir1458 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._getCacheDir1459 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getExternalCacheDir1460 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getExternalCacheDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getDir1461 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			global::android.content.ContextWrapper._openOrCreateDatabase1462 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.content.ContextWrapper._deleteDatabase1463 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.content.ContextWrapper._getDatabasePath1464 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._databaseList1465 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.content.ContextWrapper._getWallpaper1466 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.ContextWrapper._peekWallpaper1467 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1468 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1469 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.content.ContextWrapper._setWallpaper1470 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V");
			global::android.content.ContextWrapper._setWallpaper1471 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			global::android.content.ContextWrapper._clearWallpaper1472 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "clearWallpaper", "()V");
			global::android.content.ContextWrapper._startActivity1473 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._startIntentSender1474 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.content.ContextWrapper._sendBroadcast1475 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._sendBroadcast1476 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._sendOrderedBroadcast1477 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContextWrapper._sendOrderedBroadcast1478 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._sendStickyBroadcast1479 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._sendStickyOrderedBroadcast1480 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContextWrapper._removeStickyBroadcast1481 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._registerReceiver1482 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			global::android.content.ContextWrapper._registerReceiver1483 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::android.content.ContextWrapper._unregisterReceiver1484 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			global::android.content.ContextWrapper._startService1485 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			global::android.content.ContextWrapper._stopService1486 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "stopService", "(Landroid/content/Intent;)Z");
			global::android.content.ContextWrapper._bindService1487 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::android.content.ContextWrapper._unbindService1488 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V");
			global::android.content.ContextWrapper._startInstrumentation1489 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.content.ContextWrapper._getSystemService1490 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.ContextWrapper._checkCallingPermission1491 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I");
			global::android.content.ContextWrapper._checkCallingOrSelfPermission1492 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			global::android.content.ContextWrapper._enforcePermission1493 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingPermission1494 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingOrSelfPermission1495 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._grantUriPermission1496 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			global::android.content.ContextWrapper._revokeUriPermission1497 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			global::android.content.ContextWrapper._checkUriPermission1498 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::android.content.ContextWrapper._checkUriPermission1499 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			global::android.content.ContextWrapper._checkCallingUriPermission1500 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1501 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.ContextWrapper._enforceUriPermission1502 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceUriPermission1503 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingUriPermission1504 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1505 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.ContextWrapper._createPackageContext1506 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
			global::android.content.ContextWrapper._isRestricted1507 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "isRestricted", "()Z");
			global::android.content.ContextWrapper._ContextWrapper1508 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
