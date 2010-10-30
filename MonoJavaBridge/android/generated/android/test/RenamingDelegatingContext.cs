namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RenamingDelegatingContext : android.content.ContextWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RenamingDelegatingContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _openFileInput12286;
		public override global::java.io.FileInputStream openFileInput(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._openFileInput12286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFileOutput12287;
		public override global::java.io.FileOutputStream openFileOutput(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._openFileOutput12287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _deleteFile12288;
		public override bool deleteFile(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._deleteFile12288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFileStreamPath12289;
		public override global::java.io.File getFileStreamPath(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._getFileStreamPath12289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _fileList12290;
		public override global::java.lang.String[] fileList()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._fileList12290)) as java.lang.String[];
		}
		public new global::java.io.File CacheDir
		{
			get
			{
				return getCacheDir();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCacheDir12291;
		public override global::java.io.File getCacheDir()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._getCacheDir12291)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase12292;
		public override global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._openOrCreateDatabase12292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
		}
		public android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, int arg1, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg2)
		{
			return openOrCreateDatabase(arg0, arg1, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _deleteDatabase12293;
		public override bool deleteDatabase(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._deleteDatabase12293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePath12294;
		public override global::java.io.File getDatabasePath(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._getDatabasePath12294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _databaseList12295;
		public override global::java.lang.String[] databaseList()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._databaseList12295)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _providerWithRenamedContext12296;
		public static global::android.content.ContentProvider providerWithRenamedContext(java.lang.Class arg0, android.content.Context arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._providerWithRenamedContext12296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.ContentProvider;
		}
		internal static global::MonoJavaBridge.MethodId _providerWithRenamedContext12297;
		public static global::android.content.ContentProvider providerWithRenamedContext(java.lang.Class arg0, android.content.Context arg1, java.lang.String arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._providerWithRenamedContext12297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.content.ContentProvider;
		}
		internal static global::MonoJavaBridge.MethodId _makeExistingFilesAndDbsAccessible12298;
		public virtual void makeExistingFilesAndDbsAccessible()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._makeExistingFilesAndDbsAccessible12298);
		}
		public new global::java.lang.String DatabasePrefix
		{
			get
			{
				return getDatabasePrefix();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDatabasePrefix12299;
		public virtual global::java.lang.String getDatabasePrefix()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._getDatabasePrefix12299)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _RenamingDelegatingContext12300;
		public RenamingDelegatingContext(android.content.Context arg0, android.content.Context arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._RenamingDelegatingContext12300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RenamingDelegatingContext12301;
		public RenamingDelegatingContext(android.content.Context arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.RenamingDelegatingContext.staticClass, global::android.test.RenamingDelegatingContext._RenamingDelegatingContext12301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RenamingDelegatingContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.RenamingDelegatingContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/RenamingDelegatingContext"));
			global::android.test.RenamingDelegatingContext._openFileInput12286 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;");
			global::android.test.RenamingDelegatingContext._openFileOutput12287 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;");
			global::android.test.RenamingDelegatingContext._deleteFile12288 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "deleteFile", "(Ljava/lang/String;)Z");
			global::android.test.RenamingDelegatingContext._getFileStreamPath12289 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.test.RenamingDelegatingContext._fileList12290 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "fileList", "()[Ljava/lang/String;");
			global::android.test.RenamingDelegatingContext._getCacheDir12291 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "getCacheDir", "()Ljava/io/File;");
			global::android.test.RenamingDelegatingContext._openOrCreateDatabase12292 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.test.RenamingDelegatingContext._deleteDatabase12293 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "deleteDatabase", "(Ljava/lang/String;)Z");
			global::android.test.RenamingDelegatingContext._getDatabasePath12294 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;");
			global::android.test.RenamingDelegatingContext._databaseList12295 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "databaseList", "()[Ljava/lang/String;");
			global::android.test.RenamingDelegatingContext._providerWithRenamedContext12296 = @__env.GetStaticMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "providerWithRenamedContext", "(Ljava/lang/Class;Landroid/content/Context;Ljava/lang/String;)Landroid/content/ContentProvider;");
			global::android.test.RenamingDelegatingContext._providerWithRenamedContext12297 = @__env.GetStaticMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "providerWithRenamedContext", "(Ljava/lang/Class;Landroid/content/Context;Ljava/lang/String;Z)Landroid/content/ContentProvider;");
			global::android.test.RenamingDelegatingContext._makeExistingFilesAndDbsAccessible12298 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "makeExistingFilesAndDbsAccessible", "()V");
			global::android.test.RenamingDelegatingContext._getDatabasePrefix12299 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "getDatabasePrefix", "()Ljava/lang/String;");
			global::android.test.RenamingDelegatingContext._RenamingDelegatingContext12300 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/Context;Ljava/lang/String;)V");
			global::android.test.RenamingDelegatingContext._RenamingDelegatingContext12301 = @__env.GetMethodIDNoThrow(global::android.test.RenamingDelegatingContext.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
