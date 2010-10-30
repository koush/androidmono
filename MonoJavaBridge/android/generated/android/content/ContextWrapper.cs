namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContextWrapper : android.content.Context
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.ClassLoader getClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;", ref global::android.content.ContextWrapper._m0) as java.lang.ClassLoader;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContextWrapper.staticClass, "checkPermission", "(Ljava/lang/String;II)I", ref global::android.content.ContextWrapper._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.content.res.Resources getResources()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getResources", "()Landroid/content/res/Resources;", ref global::android.content.ContextWrapper._m2) as android.content.res.Resources;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String getPackageName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContextWrapper.staticClass, "getPackageName", "()Ljava/lang/String;", ref global::android.content.ContextWrapper._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void attachBaseContext(android.content.Context arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "attachBaseContext", "(Landroid/content/Context;)V", ref global::android.content.ContextWrapper._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.Context BaseContext
		{
			get
			{
				return getBaseContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.content.Context getBaseContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getBaseContext", "()Landroid/content/Context;", ref global::android.content.ContextWrapper._m5) as android.content.Context;
		}
		public new global::android.content.res.AssetManager Assets
		{
			get
			{
				return getAssets();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::android.content.res.AssetManager getAssets()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.AssetManager>(this, global::android.content.ContextWrapper.staticClass, "getAssets", "()Landroid/content/res/AssetManager;", ref global::android.content.ContextWrapper._m6) as android.content.res.AssetManager;
		}
		public new global::android.content.pm.PackageManager PackageManager
		{
			get
			{
				return getPackageManager();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::android.content.pm.PackageManager getPackageManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;", ref global::android.content.ContextWrapper._m7) as android.content.pm.PackageManager;
		}
		public new global::android.content.ContentResolver ContentResolver
		{
			get
			{
				return getContentResolver();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::android.content.ContentResolver getContentResolver()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;", ref global::android.content.ContextWrapper._m8) as android.content.ContentResolver;
		}
		public new global::android.os.Looper MainLooper
		{
			get
			{
				return getMainLooper();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::android.os.Looper getMainLooper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getMainLooper", "()Landroid/os/Looper;", ref global::android.content.ContextWrapper._m9) as android.os.Looper;
		}
		public new global::android.content.Context ApplicationContext
		{
			get
			{
				return getApplicationContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::android.content.Context getApplicationContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getApplicationContext", "()Landroid/content/Context;", ref global::android.content.ContextWrapper._m10) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override void setTheme(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "setTheme", "(I)V", ref global::android.content.ContextWrapper._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.Resources.Theme Theme
		{
			get
			{
				return getTheme();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::android.content.res.Resources.Theme getTheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.Resources.Theme>(this, global::android.content.ContextWrapper.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;", ref global::android.content.ContextWrapper._m12) as android.content.res.Resources.Theme;
		}
		public new global::android.content.pm.ApplicationInfo ApplicationInfo
		{
			get
			{
				return getApplicationInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", ref global::android.content.ContextWrapper._m13) as android.content.pm.ApplicationInfo;
		}
		public new global::java.lang.String PackageResourcePath
		{
			get
			{
				return getPackageResourcePath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::java.lang.String getPackageResourcePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContextWrapper.staticClass, "getPackageResourcePath", "()Ljava/lang/String;", ref global::android.content.ContextWrapper._m14) as java.lang.String;
		}
		public new global::java.lang.String PackageCodePath
		{
			get
			{
				return getPackageCodePath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.lang.String getPackageCodePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContextWrapper.staticClass, "getPackageCodePath", "()Ljava/lang/String;", ref global::android.content.ContextWrapper._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences>(this, global::android.content.ContextWrapper.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", ref global::android.content.ContextWrapper._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.SharedPreferences;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", ref global::android.content.ContextWrapper._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.FileInputStream;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", ref global::android.content.ContextWrapper._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.FileOutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override bool deleteFile(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContextWrapper.staticClass, "deleteFile", "(Ljava/lang/String;)Z", ref global::android.content.ContextWrapper._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", ref global::android.content.ContextWrapper._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override global::java.lang.String[] fileList()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.ContextWrapper.staticClass, "fileList", "()[Ljava/lang/String;", ref global::android.content.ContextWrapper._m21) as java.lang.String[];
		}
		public new global::java.io.File FilesDir
		{
			get
			{
				return getFilesDir();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override global::java.io.File getFilesDir()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getFilesDir", "()Ljava/io/File;", ref global::android.content.ContextWrapper._m22) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override global::java.io.File getExternalFilesDir(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", ref global::android.content.ContextWrapper._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		public new global::java.io.File CacheDir
		{
			get
			{
				return getCacheDir();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override global::java.io.File getCacheDir()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getCacheDir", "()Ljava/io/File;", ref global::android.content.ContextWrapper._m24) as java.io.File;
		}
		public new global::java.io.File ExternalCacheDir
		{
			get
			{
				return getExternalCacheDir();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override global::java.io.File getExternalCacheDir()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getExternalCacheDir", "()Ljava/io/File;", ref global::android.content.ContextWrapper._m25) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;", ref global::android.content.ContextWrapper._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;", ref global::android.content.ContextWrapper._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.database.sqlite.SQLiteDatabase;
		}
		public android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg2)
		{
			return openOrCreateDatabase(arg0, arg1, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override bool deleteDatabase(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContextWrapper.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z", ref global::android.content.ContextWrapper._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override global::java.io.File getDatabasePath(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", ref global::android.content.ContextWrapper._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.File;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override global::java.lang.String[] databaseList()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.ContextWrapper.staticClass, "databaseList", "()[Ljava/lang/String;", ref global::android.content.ContextWrapper._m30) as java.lang.String[];
		}
		public new global::android.graphics.drawable.Drawable Wallpaper
		{
			get
			{
				return getWallpaper();
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override global::android.graphics.drawable.Drawable getWallpaper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;", ref global::android.content.ContextWrapper._m31) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override global::android.graphics.drawable.Drawable peekWallpaper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;", ref global::android.content.ContextWrapper._m32) as android.graphics.drawable.Drawable;
		}
		public new int WallpaperDesiredMinimumWidth
		{
			get
			{
				return getWallpaperDesiredMinimumWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public override int getWallpaperDesiredMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumWidth", "()I", ref global::android.content.ContextWrapper._m33);
		}
		public new int WallpaperDesiredMinimumHeight
		{
			get
			{
				return getWallpaperDesiredMinimumHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public override int getWallpaperDesiredMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumHeight", "()I", ref global::android.content.ContextWrapper._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public override void setWallpaper(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V", ref global::android.content.ContextWrapper._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public override void setWallpaper(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V", ref global::android.content.ContextWrapper._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public override void clearWallpaper()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "clearWallpaper", "()V", ref global::android.content.ContextWrapper._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public override void startActivity(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "startActivity", "(Landroid/content/Intent;)V", ref global::android.content.ContextWrapper._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", ref global::android.content.ContextWrapper._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public override void sendBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V", ref global::android.content.ContextWrapper._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", ref global::android.content.ContextWrapper._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.content.ContextWrapper._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", ref global::android.content.ContextWrapper._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public override void sendStickyBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V", ref global::android.content.ContextWrapper._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.content.ContextWrapper._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public override void removeStickyBroadcast(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V", ref global::android.content.ContextWrapper._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", ref global::android.content.ContextWrapper._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;", ref global::android.content.ContextWrapper._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Intent;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", ref global::android.content.ContextWrapper._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public override global::android.content.ComponentName startService(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.content.ContextWrapper.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", ref global::android.content.ContextWrapper._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public override bool stopService(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContextWrapper.staticClass, "stopService", "(Landroid/content/Intent;)Z", ref global::android.content.ContextWrapper._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContextWrapper.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", ref global::android.content.ContextWrapper._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public override void unbindService(android.content.ServiceConnection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V", ref global::android.content.ContextWrapper._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContextWrapper.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.content.ContextWrapper._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public override global::java.lang.Object getSystemService(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.content.ContextWrapper._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public override int checkCallingPermission(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContextWrapper.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I", ref global::android.content.ContextWrapper._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public override int checkCallingOrSelfPermission(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I", ref global::android.content.ContextWrapper._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", ref global::android.content.ContextWrapper._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.ContextWrapper._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.ContextWrapper._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", ref global::android.content.ContextWrapper._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V", ref global::android.content.ContextWrapper._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I", ref global::android.content.ContextWrapper._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", ref global::android.content.ContextWrapper._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContextWrapper.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I", ref global::android.content.ContextWrapper._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", ref global::android.content.ContextWrapper._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", ref global::android.content.ContextWrapper._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", ref global::android.content.ContextWrapper._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", ref global::android.content.ContextWrapper._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", ref global::android.content.ContextWrapper._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContextWrapper.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", ref global::android.content.ContextWrapper._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public override bool isRestricted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContextWrapper.staticClass, "isRestricted", "()Z", ref global::android.content.ContextWrapper._m72);
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public ContextWrapper(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContextWrapper._m73.native == global::System.IntPtr.Zero)
				global::android.content.ContextWrapper._m73 = @__env.GetMethodIDNoThrow(global::android.content.ContextWrapper.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ContextWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContextWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContextWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
