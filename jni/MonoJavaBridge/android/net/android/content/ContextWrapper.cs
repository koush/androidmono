namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ContextWrapper : android.content.Context
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ContextWrapper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContextWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getClassLoader1185; 
		public override java.lang.ClassLoader getClassLoader() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, _getClassLoader1185)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getClassLoader1185)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkPermission1186; 
		public override int checkPermission(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallIntMethod(this, _checkPermission1186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContextWrapper.staticClass, _checkPermission1186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getResources1187; 
		public override android.content.res.Resources getResources() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallObjectMethodPtr(this, _getResources1187)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getResources1187)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName1188; 
		public override java.lang.String getPackageName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPackageName1188)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getPackageName1188)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachBaseContext1189; 
		protected virtual void attachBaseContext(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _attachBaseContext1189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _attachBaseContext1189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseContext1190; 
		public virtual android.content.Context getBaseContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getBaseContext1190)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getBaseContext1190)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAssets1191; 
		public override android.content.res.AssetManager getAssets() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallObjectMethodPtr(this, _getAssets1191)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.AssetManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getAssets1191)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageManager1192; 
		public override android.content.pm.PackageManager getPackageManager() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.PackageManager>(@__env, @__env.CallObjectMethodPtr(this, _getPackageManager1192)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.PackageManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getPackageManager1192)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentResolver1193; 
		public override android.content.ContentResolver getContentResolver() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentResolver>(@__env, @__env.CallObjectMethodPtr(this, _getContentResolver1193)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentResolver>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getContentResolver1193)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMainLooper1194; 
		public override android.os.Looper getMainLooper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallObjectMethodPtr(this, _getMainLooper1194)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getMainLooper1194)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationContext1195; 
		public override android.content.Context getApplicationContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getApplicationContext1195)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getApplicationContext1195)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTheme1196; 
		public override void setTheme(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _setTheme1196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _setTheme1196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTheme1197; 
		public override android.content.res.Resources.Theme getTheme() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallObjectMethodPtr(this, _getTheme1197)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getTheme1197)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getApplicationInfo1198; 
		public override android.content.pm.ApplicationInfo getApplicationInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ApplicationInfo>(@__env, @__env.CallObjectMethodPtr(this, _getApplicationInfo1198)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ApplicationInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getApplicationInfo1198)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageResourcePath1199; 
		public virtual java.lang.String getPackageResourcePath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPackageResourcePath1199)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getPackageResourcePath1199)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageCodePath1200; 
		public virtual java.lang.String getPackageCodePath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPackageCodePath1200)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getPackageCodePath1200)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSharedPreferences1201; 
		public override android.content.SharedPreferences getSharedPreferences(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallObjectMethodPtr(this, _getSharedPreferences1201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getSharedPreferences1201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openFileInput1202; 
		public override java.io.FileInputStream openFileInput(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallObjectMethodPtr(this, _openFileInput1202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _openFileInput1202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openFileOutput1203; 
		public override java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallObjectMethodPtr(this, _openFileOutput1203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _openFileOutput1203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteFile1204; 
		public override bool deleteFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallBooleanMethod(this, _deleteFile1204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContextWrapper.staticClass, _deleteFile1204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFileStreamPath1205; 
		public override java.io.File getFileStreamPath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, _getFileStreamPath1205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getFileStreamPath1205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fileList1206; 
		public override java.lang.String[] fileList() 
		{ 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _fileList1206)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _fileList1206)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilesDir1207; 
		public override java.io.File getFilesDir() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, _getFilesDir1207)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getFilesDir1207)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCacheDir1208; 
		public override java.io.File getCacheDir() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, _getCacheDir1208)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getCacheDir1208)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDir1209; 
		public override java.io.File getDir(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, _getDir1209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getDir1209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase1210; 
		public override android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallObjectMethodPtr(this, _openOrCreateDatabase1210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _openOrCreateDatabase1210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteDatabase1211; 
		public override bool deleteDatabase(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallBooleanMethod(this, _deleteDatabase1211, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContextWrapper.staticClass, _deleteDatabase1211, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDatabasePath1212; 
		public override java.io.File getDatabasePath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallObjectMethodPtr(this, _getDatabasePath1212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.File>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getDatabasePath1212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _databaseList1213; 
		public override java.lang.String[] databaseList() 
		{ 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _databaseList1213)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _databaseList1213)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaper1214; 
		public override android.graphics.drawable.Drawable getWallpaper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getWallpaper1214)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getWallpaper1214)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _peekWallpaper1215; 
		public override android.graphics.drawable.Drawable peekWallpaper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _peekWallpaper1215)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _peekWallpaper1215)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumWidth1216; 
		public override int getWallpaperDesiredMinimumWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallIntMethod(this, _getWallpaperDesiredMinimumWidth1216); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContextWrapper.staticClass, _getWallpaperDesiredMinimumWidth1216); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWallpaperDesiredMinimumHeight1217; 
		public override int getWallpaperDesiredMinimumHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallIntMethod(this, _getWallpaperDesiredMinimumHeight1217); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContextWrapper.staticClass, _getWallpaperDesiredMinimumHeight1217); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1218; 
		public override void setWallpaper(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _setWallpaper1218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _setWallpaper1218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWallpaper1219; 
		public override void setWallpaper(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _setWallpaper1219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _setWallpaper1219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearWallpaper1220; 
		public override void clearWallpaper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _clearWallpaper1220); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _clearWallpaper1220); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startActivity1221; 
		public override void startActivity(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _startActivity1221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _startActivity1221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startIntentSender1222; 
		public override void startIntentSender(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _startIntentSender1222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _startIntentSender1222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1223; 
		public override void sendBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _sendBroadcast1223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _sendBroadcast1223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendBroadcast1224; 
		public override void sendBroadcast(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _sendBroadcast1224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _sendBroadcast1224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1225; 
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _sendOrderedBroadcast1225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _sendOrderedBroadcast1225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendOrderedBroadcast1226; 
		public override void sendOrderedBroadcast(android.content.Intent arg0, java.lang.String arg1, android.content.BroadcastReceiver arg2, android.os.Handler arg3, int arg4, java.lang.String arg5, android.os.Bundle arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _sendOrderedBroadcast1226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _sendOrderedBroadcast1226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyBroadcast1227; 
		public override void sendStickyBroadcast(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _sendStickyBroadcast1227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _sendStickyBroadcast1227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendStickyOrderedBroadcast1228; 
		public override void sendStickyOrderedBroadcast(android.content.Intent arg0, android.content.BroadcastReceiver arg1, android.os.Handler arg2, int arg3, java.lang.String arg4, android.os.Bundle arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _sendStickyOrderedBroadcast1228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _sendStickyOrderedBroadcast1228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeStickyBroadcast1229; 
		public override void removeStickyBroadcast(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _removeStickyBroadcast1229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _removeStickyBroadcast1229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1230; 
		public override android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _registerReceiver1230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _registerReceiver1230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerReceiver1231; 
		public override android.content.Intent registerReceiver(android.content.BroadcastReceiver arg0, android.content.IntentFilter arg1, java.lang.String arg2, android.os.Handler arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _registerReceiver1231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _registerReceiver1231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterReceiver1232; 
		public override void unregisterReceiver(android.content.BroadcastReceiver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _unregisterReceiver1232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _unregisterReceiver1232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startService1233; 
		public override android.content.ComponentName startService(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, _startService1233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _startService1233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopService1234; 
		public override bool stopService(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallBooleanMethod(this, _stopService1234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContextWrapper.staticClass, _stopService1234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bindService1235; 
		public override bool bindService(android.content.Intent arg0, android.content.ServiceConnection arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallBooleanMethod(this, _bindService1235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContextWrapper.staticClass, _bindService1235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unbindService1236; 
		public override void unbindService(android.content.ServiceConnection arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _unbindService1236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _unbindService1236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startInstrumentation1237; 
		public override bool startInstrumentation(android.content.ComponentName arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallBooleanMethod(this, _startInstrumentation1237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContextWrapper.staticClass, _startInstrumentation1237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService1238; 
		public override java.lang.Object getSystemService(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getSystemService1238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _getSystemService1238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingPermission1239; 
		public override int checkCallingPermission(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallIntMethod(this, _checkCallingPermission1239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContextWrapper.staticClass, _checkCallingPermission1239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfPermission1240; 
		public override int checkCallingOrSelfPermission(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallIntMethod(this, _checkCallingOrSelfPermission1240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContextWrapper.staticClass, _checkCallingOrSelfPermission1240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enforcePermission1241; 
		public override void enforcePermission(java.lang.String arg0, int arg1, int arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _enforcePermission1241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _enforcePermission1241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingPermission1242; 
		public override void enforceCallingPermission(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _enforceCallingPermission1242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _enforceCallingPermission1242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfPermission1243; 
		public override void enforceCallingOrSelfPermission(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _enforceCallingOrSelfPermission1243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _enforceCallingOrSelfPermission1243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _grantUriPermission1244; 
		public override void grantUriPermission(java.lang.String arg0, android.net.Uri arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _grantUriPermission1244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _grantUriPermission1244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _revokeUriPermission1245; 
		public override void revokeUriPermission(android.net.Uri arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _revokeUriPermission1245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _revokeUriPermission1245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1246; 
		public override int checkUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallIntMethod(this, _checkUriPermission1246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContextWrapper.staticClass, _checkUriPermission1246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkUriPermission1247; 
		public override int checkUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallIntMethod(this, _checkUriPermission1247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContextWrapper.staticClass, _checkUriPermission1247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingUriPermission1248; 
		public override int checkCallingUriPermission(android.net.Uri arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallIntMethod(this, _checkCallingUriPermission1248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContextWrapper.staticClass, _checkCallingUriPermission1248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkCallingOrSelfUriPermission1249; 
		public override int checkCallingOrSelfUriPermission(android.net.Uri arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallIntMethod(this, _checkCallingOrSelfUriPermission1249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContextWrapper.staticClass, _checkCallingOrSelfUriPermission1249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1250; 
		public override void enforceUriPermission(android.net.Uri arg0, int arg1, int arg2, int arg3, java.lang.String arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _enforceUriPermission1250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _enforceUriPermission1250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enforceUriPermission1251; 
		public override void enforceUriPermission(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, int arg5, java.lang.String arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _enforceUriPermission1251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _enforceUriPermission1251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingUriPermission1252; 
		public override void enforceCallingUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _enforceCallingUriPermission1252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _enforceCallingUriPermission1252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enforceCallingOrSelfUriPermission1253; 
		public override void enforceCallingOrSelfUriPermission(android.net.Uri arg0, int arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				@__env.CallVoidMethod(this, _enforceCallingOrSelfUriPermission1253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContextWrapper.staticClass, _enforceCallingOrSelfUriPermission1253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createPackageContext1254; 
		public override android.content.Context createPackageContext(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _createPackageContext1254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContextWrapper.staticClass, _createPackageContext1254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRestricted1255; 
		public override bool isRestricted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContextWrapper)) 
				return @__env.CallBooleanMethod(this, _isRestricted1255); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContextWrapper.staticClass, _isRestricted1255); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContextWrapper1256; 
		public ContextWrapper(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContextWrapper.staticClass, _ContextWrapper1256, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContextWrapper.staticClass = @__class; 
			global::android.content.ContextWrapper._getClassLoader1185 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;"); 
			global::android.content.ContextWrapper._checkPermission1186 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkPermission", "(Ljava/lang/String;II)I"); 
			global::android.content.ContextWrapper._getResources1187 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getResources", "()Landroid/content/res/Resources;"); 
			global::android.content.ContextWrapper._getPackageName1188 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageName", "()Ljava/lang/String;"); 
			global::android.content.ContextWrapper._attachBaseContext1189 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "attachBaseContext", "(Landroid/content/Context;)V"); 
			global::android.content.ContextWrapper._getBaseContext1190 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getBaseContext", "()Landroid/content/Context;"); 
			global::android.content.ContextWrapper._getAssets1191 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getAssets", "()Landroid/content/res/AssetManager;"); 
			global::android.content.ContextWrapper._getPackageManager1192 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageManager", "()Landroid/content/pm/PackageManager;"); 
			global::android.content.ContextWrapper._getContentResolver1193 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getContentResolver", "()Landroid/content/ContentResolver;"); 
			global::android.content.ContextWrapper._getMainLooper1194 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getMainLooper", "()Landroid/os/Looper;"); 
			global::android.content.ContextWrapper._getApplicationContext1195 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getApplicationContext", "()Landroid/content/Context;"); 
			global::android.content.ContextWrapper._setTheme1196 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "setTheme", "(I)V"); 
			global::android.content.ContextWrapper._getTheme1197 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;"); 
			global::android.content.ContextWrapper._getApplicationInfo1198 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;"); 
			global::android.content.ContextWrapper._getPackageResourcePath1199 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageResourcePath", "()Ljava/lang/String;"); 
			global::android.content.ContextWrapper._getPackageCodePath1200 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getPackageCodePath", "()Ljava/lang/String;"); 
			global::android.content.ContextWrapper._getSharedPreferences1201 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;"); 
			global::android.content.ContextWrapper._openFileInput1202 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;"); 
			global::android.content.ContextWrapper._openFileOutput1203 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;"); 
			global::android.content.ContextWrapper._deleteFile1204 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "deleteFile", "(Ljava/lang/String;)Z"); 
			global::android.content.ContextWrapper._getFileStreamPath1205 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;"); 
			global::android.content.ContextWrapper._fileList1206 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "fileList", "()[Ljava/lang/String;"); 
			global::android.content.ContextWrapper._getFilesDir1207 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getFilesDir", "()Ljava/io/File;"); 
			global::android.content.ContextWrapper._getCacheDir1208 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getCacheDir", "()Ljava/io/File;"); 
			global::android.content.ContextWrapper._getDir1209 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getDir", "(Ljava/lang/String;I)Ljava/io/File;"); 
			global::android.content.ContextWrapper._openOrCreateDatabase1210 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.content.ContextWrapper._deleteDatabase1211 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z"); 
			global::android.content.ContextWrapper._getDatabasePath1212 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;"); 
			global::android.content.ContextWrapper._databaseList1213 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "databaseList", "()[Ljava/lang/String;"); 
			global::android.content.ContextWrapper._getWallpaper1214 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getWallpaper", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.content.ContextWrapper._peekWallpaper1215 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "peekWallpaper", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumWidth1216 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumWidth", "()I"); 
			global::android.content.ContextWrapper._getWallpaperDesiredMinimumHeight1217 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getWallpaperDesiredMinimumHeight", "()I"); 
			global::android.content.ContextWrapper._setWallpaper1218 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Ljava/io/InputStream;)V"); 
			global::android.content.ContextWrapper._setWallpaper1219 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "setWallpaper", "(Landroid/graphics/Bitmap;)V"); 
			global::android.content.ContextWrapper._clearWallpaper1220 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "clearWallpaper", "()V"); 
			global::android.content.ContextWrapper._startActivity1221 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startActivity", "(Landroid/content/Intent;)V"); 
			global::android.content.ContextWrapper._startIntentSender1222 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V"); 
			global::android.content.ContextWrapper._sendBroadcast1223 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V"); 
			global::android.content.ContextWrapper._sendBroadcast1224 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendBroadcast", "(Landroid/content/Intent;)V"); 
			global::android.content.ContextWrapper._sendOrderedBroadcast1225 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V"); 
			global::android.content.ContextWrapper._sendOrderedBroadcast1226 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.content.ContextWrapper._sendStickyBroadcast1227 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendStickyBroadcast", "(Landroid/content/Intent;)V"); 
			global::android.content.ContextWrapper._sendStickyOrderedBroadcast1228 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.content.ContextWrapper._removeStickyBroadcast1229 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "removeStickyBroadcast", "(Landroid/content/Intent;)V"); 
			global::android.content.ContextWrapper._registerReceiver1230 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;"); 
			global::android.content.ContextWrapper._registerReceiver1231 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;"); 
			global::android.content.ContextWrapper._unregisterReceiver1232 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V"); 
			global::android.content.ContextWrapper._startService1233 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;"); 
			global::android.content.ContextWrapper._stopService1234 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "stopService", "(Landroid/content/Intent;)Z"); 
			global::android.content.ContextWrapper._bindService1235 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z"); 
			global::android.content.ContextWrapper._unbindService1236 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "unbindService", "(Landroid/content/ServiceConnection;)V"); 
			global::android.content.ContextWrapper._startInstrumentation1237 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z"); 
			global::android.content.ContextWrapper._getSystemService1238 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::android.content.ContextWrapper._checkCallingPermission1239 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingPermission", "(Ljava/lang/String;)I"); 
			global::android.content.ContextWrapper._checkCallingOrSelfPermission1240 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfPermission", "(Ljava/lang/String;)I"); 
			global::android.content.ContextWrapper._enforcePermission1241 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V"); 
			global::android.content.ContextWrapper._enforceCallingPermission1242 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.ContextWrapper._enforceCallingOrSelfPermission1243 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.ContextWrapper._grantUriPermission1244 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V"); 
			global::android.content.ContextWrapper._revokeUriPermission1245 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "revokeUriPermission", "(Landroid/net/Uri;I)V"); 
			global::android.content.ContextWrapper._checkUriPermission1246 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;III)I"); 
			global::android.content.ContextWrapper._checkUriPermission1247 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I"); 
			global::android.content.ContextWrapper._checkCallingUriPermission1248 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingUriPermission", "(Landroid/net/Uri;I)I"); 
			global::android.content.ContextWrapper._checkCallingOrSelfUriPermission1249 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I"); 
			global::android.content.ContextWrapper._enforceUriPermission1250 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V"); 
			global::android.content.ContextWrapper._enforceUriPermission1251 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V"); 
			global::android.content.ContextWrapper._enforceCallingUriPermission1252 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V"); 
			global::android.content.ContextWrapper._enforceCallingOrSelfUriPermission1253 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V"); 
			global::android.content.ContextWrapper._createPackageContext1254 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;"); 
			global::android.content.ContextWrapper._isRestricted1255 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "isRestricted", "()Z"); 
			global::android.content.ContextWrapper._ContextWrapper1256 = @__env.GetMethodID(global::android.content.ContextWrapper.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
