namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ContextWrapper : android.content.Context
	{
		internal new static global::java.lang.Class staticClass;
		static ContextWrapper()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.ContextWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.ContextWrapper(@__env);
			}
		}
		protected ContextWrapper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getClassLoader1341;
		public override global::java.lang.ClassLoader getClassLoader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getClassLoader1341));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getClassLoader1341));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkPermission1342;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkPermission1342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkPermission1342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResources1343;
		public override global::android.content.res.Resources getResources() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getResources1343));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getResources1343));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName1344;
		public override global::java.lang.String getPackageName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getPackageName1344));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageName1344));
		}
		internal static global::net.sf.jni4net.jni.MethodId _attachBaseContext1345;
		protected virtual void attachBaseContext(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._attachBaseContext1345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._attachBaseContext1345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseContext1346;
		public virtual global::android.content.Context getBaseContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getBaseContext1346));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getBaseContext1346));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAssets1347;
		public override global::android.content.res.AssetManager getAssets() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getAssets1347));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getAssets1347));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageManager1348;
		public override global::android.content.pm.PackageManager getPackageManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.PackageManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getPackageManager1348));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.PackageManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageManager1348));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentResolver1349;
		public override global::android.content.ContentResolver getContentResolver() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentResolver>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getContentResolver1349));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentResolver>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getContentResolver1349));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMainLooper1350;
		public override global::android.os.Looper getMainLooper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getMainLooper1350));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getMainLooper1350));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationContext1351;
		public override global::android.content.Context getApplicationContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getApplicationContext1351));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getApplicationContext1351));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTheme1352;
		public override void setTheme(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._setTheme1352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setTheme1352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTheme1353;
		public override global::android.content.res.Resources.Theme getTheme() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getTheme1353));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getTheme1353));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationInfo1354;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ApplicationInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getApplicationInfo1354));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ApplicationInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getApplicationInfo1354));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageResourcePath1355;
		public override global::java.lang.String getPackageResourcePath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getPackageResourcePath1355));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageResourcePath1355));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageCodePath1356;
		public override global::java.lang.String getPackageCodePath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getPackageCodePath1356));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageCodePath1356));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences1357;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getSharedPreferences1357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getSharedPreferences1357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openFileInput1358;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._openFileInput1358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openFileInput1358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openFileOutput1359;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._openFileOutput1359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openFileOutput1359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteFile1360;
		public override bool deleteFile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._deleteFile1360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._deleteFile1360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFileStreamPath1361;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getFileStreamPath1361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getFileStreamPath1361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fileList1362;
		public override global::java.lang.String[] fileList() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._fileList1362));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._fileList1362));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilesDir1363;
		public override global::java.io.File getFilesDir() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getFilesDir1363));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getFilesDir1363));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExternalFilesDir1364;
		public override global::java.io.File getExternalFilesDir(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getExternalFilesDir1364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getExternalFilesDir1364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCacheDir1365;
		public override global::java.io.File getCacheDir() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getCacheDir1365));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getCacheDir1365));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExternalCacheDir1366;
		public override global::java.io.File getExternalCacheDir() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getExternalCacheDir1366));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getExternalCacheDir1366));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDir1367;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getDir1367, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getDir1367, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase1368;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._openOrCreateDatabase1368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openOrCreateDatabase1368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteDatabase1369;
		public override bool deleteDatabase(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._deleteDatabase1369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._deleteDatabase1369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDatabasePath1370;
		public override global::java.io.File getDatabasePath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getDatabasePath1370, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getDatabasePath1370, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _databaseList1371;
		public override global::java.lang.String[] databaseList() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._databaseList1371));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._databaseList1371));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaper1372;
		public override global::android.graphics.drawable.Drawable getWallpaper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getWallpaper1372));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaper1372));
		}
		internal static global::net.sf.jni4net.jni.MethodId _peekWallpaper1373;
		public override global::android.graphics.drawable.Drawable peekWallpaper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._peekWallpaper1373));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._peekWallpaper1373));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumWidth1374;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1374);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1374);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumHeight1375;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1375);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1375);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1376;
		public override void setWallpaper(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._setWallpaper1376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setWallpaper1376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1377;
		public override void setWallpaper(android.graphics.Bitmap arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._setWallpaper1377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setWallpaper1377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearWallpaper1378;
		public override void clearWallpaper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._clearWallpaper1378);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._clearWallpaper1378);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivity1379;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._startActivity1379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startActivity1379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSender1380;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._startIntentSender1380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startIntentSender1380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1381;
		public override void sendBroadcast(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendBroadcast1381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendBroadcast1381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1382;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendBroadcast1382, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendBroadcast1382, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1383;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendOrderedBroadcast1383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendOrderedBroadcast1383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1384;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendOrderedBroadcast1384, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendOrderedBroadcast1384, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyBroadcast1385;
		public override void sendStickyBroadcast(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendStickyBroadcast1385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendStickyBroadcast1385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyOrderedBroadcast1386;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendStickyOrderedBroadcast1386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendStickyOrderedBroadcast1386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeStickyBroadcast1387;
		public override void removeStickyBroadcast(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._removeStickyBroadcast1387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._removeStickyBroadcast1387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1388;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._registerReceiver1388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._registerReceiver1388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1389;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._registerReceiver1389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._registerReceiver1389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterReceiver1390;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._unregisterReceiver1390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._unregisterReceiver1390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startService1391;
		public override global::android.content.ComponentName startService(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._startService1391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startService1391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopService1392;
		public override bool stopService(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._stopService1392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._stopService1392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindService1393;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._bindService1393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._bindService1393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unbindService1394;
		public override void unbindService(android.content.ServiceConnection arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._unbindService1394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._unbindService1394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startInstrumentation1395;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._startInstrumentation1395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startInstrumentation1395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService1396;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getSystemService1396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getSystemService1396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingPermission1397;
		public override int checkCallingPermission(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkCallingPermission1397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingPermission1397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfPermission1398;
		public override int checkCallingOrSelfPermission(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkCallingOrSelfPermission1398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingOrSelfPermission1398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforcePermission1399;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforcePermission1399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforcePermission1399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingPermission1400;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceCallingPermission1400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingPermission1400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfPermission1401;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceCallingOrSelfPermission1401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingOrSelfPermission1401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _grantUriPermission1402;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._grantUriPermission1402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._grantUriPermission1402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _revokeUriPermission1403;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._revokeUriPermission1403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._revokeUriPermission1403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1404;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkUriPermission1404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkUriPermission1404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1405;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkUriPermission1405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkUriPermission1405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingUriPermission1406;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkCallingUriPermission1406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingUriPermission1406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfUriPermission1407;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1408;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceUriPermission1408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceUriPermission1408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1409;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceUriPermission1409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceUriPermission1409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingUriPermission1410;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceCallingUriPermission1410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingUriPermission1410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfUriPermission1411;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createPackageContext1412;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._createPackageContext1412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._createPackageContext1412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRestricted1413;
		public override bool isRestricted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._isRestricted1413);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._isRestricted1413);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContextWrapper1414;
		public ContextWrapper(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._ContextWrapper1414, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.ContextWrapper.staticClass = @__class;
			global::android.content.ContextWrapper._getClassLoader1341 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::android.content.ContextWrapper._checkPermission1342 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkPermission", "(Ljava/lang/String;II)I");
			global::android.content.ContextWrapper._getResources1343 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.ContextWrapper._getPackageName1344 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._attachBaseContext1345 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "attachBaseContext", "(Landroid/content/Context;)V");
			global::android.content.ContextWrapper._getBaseContext1346 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getBaseContext", "()Landroid/content/Context;");
			global::android.content.ContextWrapper._getAssets1347 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.content.ContextWrapper._getPackageManager1348 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;");
			global::android.content.ContextWrapper._getContentResolver1349 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			global::android.content.ContextWrapper._getMainLooper1350 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.content.ContextWrapper._getApplicationContext1351 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getApplicationContext", "()Landroid/content/Context;");
			global::android.content.ContextWrapper._setTheme1352 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "setTheme", "(I)V");
			global::android.content.ContextWrapper._getTheme1353 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.content.ContextWrapper._getApplicationInfo1354 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;");
			global::android.content.ContextWrapper._getPackageResourcePath1355 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageResourcePath", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._getPackageCodePath1356 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageCodePath", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._getSharedPreferences1357 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			global::android.content.ContextWrapper._openFileInput1358 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.content.ContextWrapper._openFileOutput1359 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.content.ContextWrapper._deleteFile1360 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.content.ContextWrapper._getFileStreamPath1361 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._fileList1362 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.content.ContextWrapper._getFilesDir1363 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getFilesDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getExternalFilesDir1364 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._getCacheDir1365 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getExternalCacheDir1366 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getExternalCacheDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getDir1367 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			global::android.content.ContextWrapper._openOrCreateDatabase1368 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.content.ContextWrapper._deleteDatabase1369 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.content.ContextWrapper._getDatabasePath1370 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._databaseList1371 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.content.ContextWrapper._getWallpaper1372 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.ContextWrapper._peekWallpaper1373 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1374 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1375 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.content.ContextWrapper._setWallpaper1376 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V");
			global::android.content.ContextWrapper._setWallpaper1377 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			global::android.content.ContextWrapper._clearWallpaper1378 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "clearWallpaper", "()V");
			global::android.content.ContextWrapper._startActivity1379 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._startIntentSender1380 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.content.ContextWrapper._sendBroadcast1381 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._sendBroadcast1382 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._sendOrderedBroadcast1383 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContextWrapper._sendOrderedBroadcast1384 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._sendStickyBroadcast1385 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._sendStickyOrderedBroadcast1386 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContextWrapper._removeStickyBroadcast1387 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._registerReceiver1388 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			global::android.content.ContextWrapper._registerReceiver1389 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::android.content.ContextWrapper._unregisterReceiver1390 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			global::android.content.ContextWrapper._startService1391 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			global::android.content.ContextWrapper._stopService1392 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "stopService", "(Landroid/content/Intent;)Z");
			global::android.content.ContextWrapper._bindService1393 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::android.content.ContextWrapper._unbindService1394 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V");
			global::android.content.ContextWrapper._startInstrumentation1395 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.content.ContextWrapper._getSystemService1396 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.ContextWrapper._checkCallingPermission1397 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I");
			global::android.content.ContextWrapper._checkCallingOrSelfPermission1398 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			global::android.content.ContextWrapper._enforcePermission1399 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingPermission1400 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingOrSelfPermission1401 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._grantUriPermission1402 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			global::android.content.ContextWrapper._revokeUriPermission1403 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			global::android.content.ContextWrapper._checkUriPermission1404 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::android.content.ContextWrapper._checkUriPermission1405 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			global::android.content.ContextWrapper._checkCallingUriPermission1406 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1407 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.ContextWrapper._enforceUriPermission1408 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceUriPermission1409 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingUriPermission1410 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1411 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.ContextWrapper._createPackageContext1412 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
			global::android.content.ContextWrapper._isRestricted1413 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "isRestricted", "()Z");
			global::android.content.ContextWrapper._ContextWrapper1414 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
