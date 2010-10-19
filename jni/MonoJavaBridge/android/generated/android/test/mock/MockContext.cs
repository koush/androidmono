namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockContext : android.content.Context
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MockContext()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getClassLoader7862;
		public override global::java.lang.ClassLoader getClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getClassLoader7862)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getClassLoader7862)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission7863;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContext._checkPermission7863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkPermission7863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources7864;
		public override global::android.content.res.Resources getResources() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getResources7864)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getResources7864)) as android.content.res.Resources;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName7865;
		public override global::java.lang.String getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getPackageName7865)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getPackageName7865)) as java.lang.String;
		}
		public new global::android.content.res.AssetManager Assets
		{
			get
			{
				return getAssets();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAssets7866;
		public override global::android.content.res.AssetManager getAssets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getAssets7866)) as android.content.res.AssetManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getAssets7866)) as android.content.res.AssetManager;
		}
		public new global::android.content.pm.PackageManager PackageManager
		{
			get
			{
				return getPackageManager();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageManager7867;
		public override global::android.content.pm.PackageManager getPackageManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getPackageManager7867)) as android.content.pm.PackageManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getPackageManager7867)) as android.content.pm.PackageManager;
		}
		public new global::android.content.ContentResolver ContentResolver
		{
			get
			{
				return getContentResolver();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentResolver7868;
		public override global::android.content.ContentResolver getContentResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getContentResolver7868)) as android.content.ContentResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getContentResolver7868)) as android.content.ContentResolver;
		}
		public new global::android.os.Looper MainLooper
		{
			get
			{
				return getMainLooper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMainLooper7869;
		public override global::android.os.Looper getMainLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getMainLooper7869)) as android.os.Looper;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getMainLooper7869)) as android.os.Looper;
		}
		public new global::android.content.Context ApplicationContext
		{
			get
			{
				return getApplicationContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationContext7870;
		public override global::android.content.Context getApplicationContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getApplicationContext7870)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getApplicationContext7870)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setTheme7871;
		public override void setTheme(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._setTheme7871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._setTheme7871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.Resources.Theme Theme
		{
			get
			{
				return getTheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTheme7872;
		public override global::android.content.res.Resources.Theme getTheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getTheme7872)) as android.content.res.Resources.Theme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getTheme7872)) as android.content.res.Resources.Theme;
		}
		public new global::android.content.pm.ApplicationInfo ApplicationInfo
		{
			get
			{
				return getApplicationInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getApplicationInfo7873;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getApplicationInfo7873)) as android.content.pm.ApplicationInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getApplicationInfo7873)) as android.content.pm.ApplicationInfo;
		}
		public new global::java.lang.String PackageResourcePath
		{
			get
			{
				return getPackageResourcePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageResourcePath7874;
		public override global::java.lang.String getPackageResourcePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getPackageResourcePath7874)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getPackageResourcePath7874)) as java.lang.String;
		}
		public new global::java.lang.String PackageCodePath
		{
			get
			{
				return getPackageCodePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageCodePath7875;
		public override global::java.lang.String getPackageCodePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getPackageCodePath7875)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getPackageCodePath7875)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSharedPreferences7876;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getSharedPreferences7876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getSharedPreferences7876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences;
		}
		internal static global::MonoJavaBridge.MethodId _openFileInput7877;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._openFileInput7877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._openFileInput7877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFileOutput7878;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._openFileOutput7878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._openFileOutput7878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _deleteFile7879;
		public override bool deleteFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext._deleteFile7879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._deleteFile7879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath7880;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getFileStreamPath7880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getFileStreamPath7880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _fileList7881;
		public override global::java.lang.String[] fileList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._fileList7881)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._fileList7881)) as java.lang.String[];
		}
		public new global::java.io.File FilesDir
		{
			get
			{
				return getFilesDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilesDir7882;
		public override global::java.io.File getFilesDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getFilesDir7882)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getFilesDir7882)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalFilesDir7883;
		public override global::java.io.File getExternalFilesDir(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getExternalFilesDir7883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getExternalFilesDir7883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		public new global::java.io.File CacheDir
		{
			get
			{
				return getCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheDir7884;
		public override global::java.io.File getCacheDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getCacheDir7884)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getCacheDir7884)) as java.io.File;
		}
		public new global::java.io.File ExternalCacheDir
		{
			get
			{
				return getExternalCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExternalCacheDir7885;
		public override global::java.io.File getExternalCacheDir() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getExternalCacheDir7885)) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getExternalCacheDir7885)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _getDir7886;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getDir7886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getDir7886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase7887;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._openOrCreateDatabase7887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._openOrCreateDatabase7887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _deleteDatabase7888;
		public override bool deleteDatabase(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext._deleteDatabase7888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._deleteDatabase7888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath7889;
		public override global::java.io.File getDatabasePath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getDatabasePath7889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getDatabasePath7889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _databaseList7890;
		public override global::java.lang.String[] databaseList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._databaseList7890)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._databaseList7890)) as java.lang.String[];
		}
		public new global::android.graphics.drawable.Drawable Wallpaper
		{
			get
			{
				return getWallpaper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaper7891;
		public override global::android.graphics.drawable.Drawable getWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getWallpaper7891)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getWallpaper7891)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _peekWallpaper7892;
		public override global::android.graphics.drawable.Drawable peekWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._peekWallpaper7892)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._peekWallpaper7892)) as android.graphics.drawable.Drawable;
		}
		public new int WallpaperDesiredMinimumWidth
		{
			get
			{
				return getWallpaperDesiredMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumWidth7893;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContext._getWallpaperDesiredMinimumWidth7893);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getWallpaperDesiredMinimumWidth7893);
		}
		public new int WallpaperDesiredMinimumHeight
		{
			get
			{
				return getWallpaperDesiredMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWallpaperDesiredMinimumHeight7894;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContext._getWallpaperDesiredMinimumHeight7894);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getWallpaperDesiredMinimumHeight7894);
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper7895;
		public override void setWallpaper(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._setWallpaper7895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._setWallpaper7895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWallpaper7896;
		public override void setWallpaper(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._setWallpaper7896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._setWallpaper7896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearWallpaper7897;
		public override void clearWallpaper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._clearWallpaper7897);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._clearWallpaper7897);
		}
		internal static global::MonoJavaBridge.MethodId _startActivity7898;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._startActivity7898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._startActivity7898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startIntentSender7899;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._startIntentSender7899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._startIntentSender7899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast7900;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._sendBroadcast7900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendBroadcast7900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendBroadcast7901;
		public override void sendBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._sendBroadcast7901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendBroadcast7901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast7902;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._sendOrderedBroadcast7902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendOrderedBroadcast7902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendOrderedBroadcast7903;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._sendOrderedBroadcast7903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendOrderedBroadcast7903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyBroadcast7904;
		public override void sendStickyBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._sendStickyBroadcast7904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendStickyBroadcast7904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendStickyOrderedBroadcast7905;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._sendStickyOrderedBroadcast7905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._sendStickyOrderedBroadcast7905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _removeStickyBroadcast7906;
		public override void removeStickyBroadcast(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._removeStickyBroadcast7906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._removeStickyBroadcast7906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver7907;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._registerReceiver7907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._registerReceiver7907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _registerReceiver7908;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._registerReceiver7908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._registerReceiver7908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _unregisterReceiver7909;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._unregisterReceiver7909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._unregisterReceiver7909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startService7910;
		public override global::android.content.ComponentName startService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._startService7910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._startService7910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _stopService7911;
		public override bool stopService(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext._stopService7911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._stopService7911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bindService7912;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext._bindService7912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._bindService7912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unbindService7913;
		public override void unbindService(android.content.ServiceConnection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._unbindService7913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._unbindService7913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInstrumentation7914;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext._startInstrumentation7914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._startInstrumentation7914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService7915;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._getSystemService7915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._getSystemService7915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingPermission7916;
		public override int checkCallingPermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContext._checkCallingPermission7916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkCallingPermission7916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfPermission7917;
		public override int checkCallingOrSelfPermission(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContext._checkCallingOrSelfPermission7917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkCallingOrSelfPermission7917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enforcePermission7918;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._enforcePermission7918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforcePermission7918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingPermission7919;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._enforceCallingPermission7919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceCallingPermission7919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfPermission7920;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._enforceCallingOrSelfPermission7920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceCallingOrSelfPermission7920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _grantUriPermission7921;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._grantUriPermission7921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._grantUriPermission7921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _revokeUriPermission7922;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._revokeUriPermission7922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._revokeUriPermission7922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission7923;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContext._checkUriPermission7923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkUriPermission7923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _checkUriPermission7924;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContext._checkUriPermission7924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkUriPermission7924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingUriPermission7925;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContext._checkCallingUriPermission7925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkCallingUriPermission7925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkCallingOrSelfUriPermission7926;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockContext._checkCallingOrSelfUriPermission7926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._checkCallingOrSelfUriPermission7926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission7927;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._enforceUriPermission7927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceUriPermission7927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _enforceUriPermission7928;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._enforceUriPermission7928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceUriPermission7928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingUriPermission7929;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._enforceCallingUriPermission7929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceCallingUriPermission7929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _enforceCallingOrSelfUriPermission7930;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockContext._enforceCallingOrSelfUriPermission7930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._enforceCallingOrSelfUriPermission7930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _createPackageContext7931;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockContext._createPackageContext7931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._createPackageContext7931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isRestricted7932;
		public override bool isRestricted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext._isRestricted7932);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._isRestricted7932);
		}
		internal static global::MonoJavaBridge.MethodId _MockContext7933;
		public MockContext()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockContext.staticClass, global::android.test.mock.MockContext._MockContext7933);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockContext"));
			global::android.test.mock.MockContext._getClassLoader7862 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::android.test.mock.MockContext._checkPermission7863 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkPermission", "(Ljava/lang/String;II)I");
			global::android.test.mock.MockContext._getResources7864 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.test.mock.MockContext._getPackageName7865 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.test.mock.MockContext._getAssets7866 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.test.mock.MockContext._getPackageManager7867 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;");
			global::android.test.mock.MockContext._getContentResolver7868 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			global::android.test.mock.MockContext._getMainLooper7869 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.test.mock.MockContext._getApplicationContext7870 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getApplicationContext", "()Landroid/content/Context;");
			global::android.test.mock.MockContext._setTheme7871 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "setTheme", "(I)V");
			global::android.test.mock.MockContext._getTheme7872 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.test.mock.MockContext._getApplicationInfo7873 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;");
			global::android.test.mock.MockContext._getPackageResourcePath7874 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getPackageResourcePath", "()Ljava/lang/String;");
			global::android.test.mock.MockContext._getPackageCodePath7875 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getPackageCodePath", "()Ljava/lang/String;");
			global::android.test.mock.MockContext._getSharedPreferences7876 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			global::android.test.mock.MockContext._openFileInput7877 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.test.mock.MockContext._openFileOutput7878 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.test.mock.MockContext._deleteFile7879 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.test.mock.MockContext._getFileStreamPath7880 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.test.mock.MockContext._fileList7881 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.test.mock.MockContext._getFilesDir7882 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getFilesDir", "()Ljava/io/File;");
			global::android.test.mock.MockContext._getExternalFilesDir7883 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.test.mock.MockContext._getCacheDir7884 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.test.mock.MockContext._getExternalCacheDir7885 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getExternalCacheDir", "()Ljava/io/File;");
			global::android.test.mock.MockContext._getDir7886 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			global::android.test.mock.MockContext._openOrCreateDatabase7887 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.test.mock.MockContext._deleteDatabase7888 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.test.mock.MockContext._getDatabasePath7889 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.test.mock.MockContext._databaseList7890 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.test.mock.MockContext._getWallpaper7891 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockContext._peekWallpaper7892 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.test.mock.MockContext._getWallpaperDesiredMinimumWidth7893 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.test.mock.MockContext._getWallpaperDesiredMinimumHeight7894 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.test.mock.MockContext._setWallpaper7895 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			global::android.test.mock.MockContext._setWallpaper7896 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V");
			global::android.test.mock.MockContext._clearWallpaper7897 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "clearWallpaper", "()V");
			global::android.test.mock.MockContext._startActivity7898 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.test.mock.MockContext._startIntentSender7899 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.test.mock.MockContext._sendBroadcast7900 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.test.mock.MockContext._sendBroadcast7901 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::android.test.mock.MockContext._sendOrderedBroadcast7902 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.test.mock.MockContext._sendOrderedBroadcast7903 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.test.mock.MockContext._sendStickyBroadcast7904 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.test.mock.MockContext._sendStickyOrderedBroadcast7905 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.test.mock.MockContext._removeStickyBroadcast7906 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.test.mock.MockContext._registerReceiver7907 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::android.test.mock.MockContext._registerReceiver7908 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			global::android.test.mock.MockContext._unregisterReceiver7909 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			global::android.test.mock.MockContext._startService7910 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			global::android.test.mock.MockContext._stopService7911 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "stopService", "(Landroid/content/Intent;)Z");
			global::android.test.mock.MockContext._bindService7912 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::android.test.mock.MockContext._unbindService7913 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V");
			global::android.test.mock.MockContext._startInstrumentation7914 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.test.mock.MockContext._getSystemService7915 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.test.mock.MockContext._checkCallingPermission7916 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I");
			global::android.test.mock.MockContext._checkCallingOrSelfPermission7917 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			global::android.test.mock.MockContext._enforcePermission7918 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			global::android.test.mock.MockContext._enforceCallingPermission7919 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.mock.MockContext._enforceCallingOrSelfPermission7920 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.mock.MockContext._grantUriPermission7921 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			global::android.test.mock.MockContext._revokeUriPermission7922 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			global::android.test.mock.MockContext._checkUriPermission7923 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::android.test.mock.MockContext._checkUriPermission7924 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			global::android.test.mock.MockContext._checkCallingUriPermission7925 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			global::android.test.mock.MockContext._checkCallingOrSelfUriPermission7926 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			global::android.test.mock.MockContext._enforceUriPermission7927 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			global::android.test.mock.MockContext._enforceUriPermission7928 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			global::android.test.mock.MockContext._enforceCallingUriPermission7929 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.test.mock.MockContext._enforceCallingOrSelfUriPermission7930 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.test.mock.MockContext._createPackageContext7931 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
			global::android.test.mock.MockContext._isRestricted7932 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "isRestricted", "()Z");
			global::android.test.mock.MockContext._MockContext7933 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContext.staticClass, "<init>", "()V");
		}
	}
}
