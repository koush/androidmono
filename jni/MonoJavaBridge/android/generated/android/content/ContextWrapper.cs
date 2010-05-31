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
		internal static global::net.sf.jni4net.jni.MethodId _getClassLoader1200;
		public override global::java.lang.ClassLoader getClassLoader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getClassLoader1200));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getClassLoader1200));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkPermission1201;
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkPermission1201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkPermission1201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getResources1202;
		public override global::android.content.res.Resources getResources() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getResources1202));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getResources1202));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName1203;
		public override global::java.lang.String getPackageName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getPackageName1203));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageName1203));
		}
		internal static global::net.sf.jni4net.jni.MethodId _attachBaseContext1204;
		protected virtual void attachBaseContext(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._attachBaseContext1204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._attachBaseContext1204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseContext1205;
		public virtual global::android.content.Context getBaseContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getBaseContext1205));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getBaseContext1205));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAssets1206;
		public override global::android.content.res.AssetManager getAssets() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getAssets1206));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getAssets1206));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageManager1207;
		public override global::android.content.pm.PackageManager getPackageManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.PackageManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getPackageManager1207));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.PackageManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageManager1207));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentResolver1208;
		public override global::android.content.ContentResolver getContentResolver() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentResolver>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getContentResolver1208));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentResolver>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getContentResolver1208));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMainLooper1209;
		public override global::android.os.Looper getMainLooper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getMainLooper1209));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getMainLooper1209));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationContext1210;
		public override global::android.content.Context getApplicationContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getApplicationContext1210));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getApplicationContext1210));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTheme1211;
		public override void setTheme(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._setTheme1211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setTheme1211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTheme1212;
		public override global::android.content.res.Resources.Theme getTheme() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getTheme1212));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getTheme1212));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationInfo1213;
		public override global::android.content.pm.ApplicationInfo getApplicationInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ApplicationInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getApplicationInfo1213));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ApplicationInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getApplicationInfo1213));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageResourcePath1214;
		public virtual global::java.lang.String getPackageResourcePath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getPackageResourcePath1214));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageResourcePath1214));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageCodePath1215;
		public virtual global::java.lang.String getPackageCodePath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getPackageCodePath1215));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getPackageCodePath1215));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences1216;
		public override global::android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getSharedPreferences1216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getSharedPreferences1216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openFileInput1217;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._openFileInput1217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openFileInput1217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openFileOutput1218;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._openFileOutput1218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openFileOutput1218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteFile1219;
		public override bool deleteFile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._deleteFile1219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._deleteFile1219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFileStreamPath1220;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getFileStreamPath1220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getFileStreamPath1220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fileList1221;
		public override global::java.lang.String[] fileList() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._fileList1221));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._fileList1221));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilesDir1222;
		public override global::java.io.File getFilesDir() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getFilesDir1222));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getFilesDir1222));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCacheDir1223;
		public override global::java.io.File getCacheDir() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getCacheDir1223));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getCacheDir1223));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDir1224;
		public override global::java.io.File getDir(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getDir1224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getDir1224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase1225;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._openOrCreateDatabase1225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._openOrCreateDatabase1225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deleteDatabase1226;
		public override bool deleteDatabase(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._deleteDatabase1226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._deleteDatabase1226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDatabasePath1227;
		public override global::java.io.File getDatabasePath(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getDatabasePath1227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getDatabasePath1227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _databaseList1228;
		public override global::java.lang.String[] databaseList() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._databaseList1228));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._databaseList1228));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaper1229;
		public override global::android.graphics.drawable.Drawable getWallpaper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getWallpaper1229));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaper1229));
		}
		internal static global::net.sf.jni4net.jni.MethodId _peekWallpaper1230;
		public override global::android.graphics.drawable.Drawable peekWallpaper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._peekWallpaper1230));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._peekWallpaper1230));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumWidth1231;
		public override int getWallpaperDesiredMinimumWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1231);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1231);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumHeight1232;
		public override int getWallpaperDesiredMinimumHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1232);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1232);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1233;
		public override void setWallpaper(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._setWallpaper1233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setWallpaper1233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1234;
		public override void setWallpaper(android.graphics.Bitmap arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._setWallpaper1234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._setWallpaper1234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearWallpaper1235;
		public override void clearWallpaper() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._clearWallpaper1235);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._clearWallpaper1235);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivity1236;
		public override void startActivity(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._startActivity1236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startActivity1236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSender1237;
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._startIntentSender1237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startIntentSender1237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1238;
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendBroadcast1238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendBroadcast1238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1239;
		public override void sendBroadcast(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendBroadcast1239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendBroadcast1239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1240;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendOrderedBroadcast1240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendOrderedBroadcast1240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1241;
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendOrderedBroadcast1241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendOrderedBroadcast1241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyBroadcast1242;
		public override void sendStickyBroadcast(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendStickyBroadcast1242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendStickyBroadcast1242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyOrderedBroadcast1243;
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._sendStickyOrderedBroadcast1243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._sendStickyOrderedBroadcast1243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeStickyBroadcast1244;
		public override void removeStickyBroadcast(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._removeStickyBroadcast1244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._removeStickyBroadcast1244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1245;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._registerReceiver1245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._registerReceiver1245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1246;
		public override global::android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._registerReceiver1246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._registerReceiver1246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterReceiver1247;
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._unregisterReceiver1247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._unregisterReceiver1247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startService1248;
		public override global::android.content.ComponentName startService(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._startService1248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startService1248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopService1249;
		public override bool stopService(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._stopService1249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._stopService1249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bindService1250;
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._bindService1250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._bindService1250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unbindService1251;
		public override void unbindService(android.content.ServiceConnection arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._unbindService1251, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._unbindService1251, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startInstrumentation1252;
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._startInstrumentation1252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._startInstrumentation1252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService1253;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._getSystemService1253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._getSystemService1253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingPermission1254;
		public override int checkCallingPermission(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkCallingPermission1254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingPermission1254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfPermission1255;
		public override int checkCallingOrSelfPermission(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkCallingOrSelfPermission1255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingOrSelfPermission1255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforcePermission1256;
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforcePermission1256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforcePermission1256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingPermission1257;
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceCallingPermission1257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingPermission1257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfPermission1258;
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceCallingOrSelfPermission1258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingOrSelfPermission1258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _grantUriPermission1259;
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._grantUriPermission1259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._grantUriPermission1259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _revokeUriPermission1260;
		public override void revokeUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._revokeUriPermission1260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._revokeUriPermission1260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1261;
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkUriPermission1261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkUriPermission1261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1262;
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkUriPermission1262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkUriPermission1262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingUriPermission1263;
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkCallingUriPermission1263, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingUriPermission1263, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfUriPermission1264;
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1264, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1264, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1265;
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceUriPermission1265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceUriPermission1265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1266;
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceUriPermission1266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceUriPermission1266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingUriPermission1267;
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceCallingUriPermission1267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingUriPermission1267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfUriPermission1268;
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createPackageContext1269;
		public override global::android.content.Context createPackageContext(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContextWrapper._createPackageContext1269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._createPackageContext1269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRestricted1270;
		public override bool isRestricted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContextWrapper._isRestricted1270);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._isRestricted1270);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContextWrapper1271;
		public ContextWrapper(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContextWrapper.staticClass, global::android.content.ContextWrapper._ContextWrapper1271, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.ContextWrapper.staticClass = @__class;
			global::android.content.ContextWrapper._getClassLoader1200 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::android.content.ContextWrapper._checkPermission1201 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkPermission", "(Ljava/lang/String;II)I");
			global::android.content.ContextWrapper._getResources1202 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.ContextWrapper._getPackageName1203 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._attachBaseContext1204 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "attachBaseContext", "(Landroid/content/Context;)V");
			global::android.content.ContextWrapper._getBaseContext1205 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getBaseContext", "()Landroid/content/Context;");
			global::android.content.ContextWrapper._getAssets1206 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getAssets", "()Landroid/content/res/AssetManager;");
			global::android.content.ContextWrapper._getPackageManager1207 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;");
			global::android.content.ContextWrapper._getContentResolver1208 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;");
			global::android.content.ContextWrapper._getMainLooper1209 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getMainLooper", "()Landroid/os/Looper;");
			global::android.content.ContextWrapper._getApplicationContext1210 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getApplicationContext", "()Landroid/content/Context;");
			global::android.content.ContextWrapper._setTheme1211 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "setTheme", "(I)V");
			global::android.content.ContextWrapper._getTheme1212 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.content.ContextWrapper._getApplicationInfo1213 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;");
			global::android.content.ContextWrapper._getPackageResourcePath1214 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageResourcePath", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._getPackageCodePath1215 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageCodePath", "()Ljava/lang/String;");
			global::android.content.ContextWrapper._getSharedPreferences1216 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;");
			global::android.content.ContextWrapper._openFileInput1217 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.content.ContextWrapper._openFileOutput1218 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.content.ContextWrapper._deleteFile1219 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.content.ContextWrapper._getFileStreamPath1220 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._fileList1221 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.content.ContextWrapper._getFilesDir1222 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getFilesDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getCacheDir1223 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.content.ContextWrapper._getDir1224 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;");
			global::android.content.ContextWrapper._openOrCreateDatabase1225 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.content.ContextWrapper._deleteDatabase1226 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.content.ContextWrapper._getDatabasePath1227 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.content.ContextWrapper._databaseList1228 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.content.ContextWrapper._getWallpaper1229 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.ContextWrapper._peekWallpaper1230 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;");
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1231 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumWidth", "()I");
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1232 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumHeight", "()I");
			global::android.content.ContextWrapper._setWallpaper1233 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V");
			global::android.content.ContextWrapper._setWallpaper1234 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V");
			global::android.content.ContextWrapper._clearWallpaper1235 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "clearWallpaper", "()V");
			global::android.content.ContextWrapper._startActivity1236 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startActivity", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._startIntentSender1237 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V");
			global::android.content.ContextWrapper._sendBroadcast1238 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._sendBroadcast1239 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._sendOrderedBroadcast1240 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._sendOrderedBroadcast1241 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContextWrapper._sendStickyBroadcast1242 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._sendStickyOrderedBroadcast1243 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContextWrapper._removeStickyBroadcast1244 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V");
			global::android.content.ContextWrapper._registerReceiver1245 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::android.content.ContextWrapper._registerReceiver1246 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;");
			global::android.content.ContextWrapper._unregisterReceiver1247 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			global::android.content.ContextWrapper._startService1248 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;");
			global::android.content.ContextWrapper._stopService1249 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "stopService", "(Landroid/content/Intent;)Z");
			global::android.content.ContextWrapper._bindService1250 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z");
			global::android.content.ContextWrapper._unbindService1251 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V");
			global::android.content.ContextWrapper._startInstrumentation1252 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.content.ContextWrapper._getSystemService1253 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.ContextWrapper._checkCallingPermission1254 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I");
			global::android.content.ContextWrapper._checkCallingOrSelfPermission1255 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I");
			global::android.content.ContextWrapper._enforcePermission1256 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingPermission1257 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingOrSelfPermission1258 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContextWrapper._grantUriPermission1259 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V");
			global::android.content.ContextWrapper._revokeUriPermission1260 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V");
			global::android.content.ContextWrapper._checkUriPermission1261 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I");
			global::android.content.ContextWrapper._checkUriPermission1262 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I");
			global::android.content.ContextWrapper._checkCallingUriPermission1263 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1264 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I");
			global::android.content.ContextWrapper._enforceUriPermission1265 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceUriPermission1266 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingUriPermission1267 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1268 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V");
			global::android.content.ContextWrapper._createPackageContext1269 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;");
			global::android.content.ContextWrapper._isRestricted1270 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "isRestricted", "()Z");
			global::android.content.ContextWrapper._ContextWrapper1271 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
