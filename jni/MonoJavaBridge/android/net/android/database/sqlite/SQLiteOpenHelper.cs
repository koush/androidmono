namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SQLiteOpenHelper : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SQLiteOpenHelper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteOpenHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SQLiteOpenHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2522; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteOpenHelper)) 
				@__env.CallVoidMethod(this, _close2522); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteOpenHelper.staticClass, _close2522); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate2523; 
		public abstract void onCreate(android.database.sqlite.SQLiteDatabase arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getWritableDatabase2524; 
		public virtual android.database.sqlite.SQLiteDatabase getWritableDatabase() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteOpenHelper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallObjectMethodPtr(this, _getWritableDatabase2524)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteOpenHelper.staticClass, _getWritableDatabase2524)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReadableDatabase2525; 
		public virtual android.database.sqlite.SQLiteDatabase getReadableDatabase() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteOpenHelper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallObjectMethodPtr(this, _getReadableDatabase2525)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.sqlite.SQLiteOpenHelper.staticClass, _getReadableDatabase2525)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpgrade2526; 
		public abstract void onUpgrade(android.database.sqlite.SQLiteDatabase arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _onOpen2527; 
		public virtual void onOpen(android.database.sqlite.SQLiteDatabase arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteOpenHelper)) 
				@__env.CallVoidMethod(this, _onOpen2527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteOpenHelper.staticClass, _onOpen2527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteOpenHelper2528; 
		public SQLiteOpenHelper(android.content.Context arg0, java.lang.String arg1, android.database.sqlite.SQLiteDatabase.CursorFactory arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteOpenHelper.staticClass, _SQLiteOpenHelper2528, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteOpenHelper.staticClass = @__class; 
			global::android.database.sqlite.SQLiteOpenHelper._close2522 = @__env.GetMethodID(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "close", "()V"); 
			global::android.database.sqlite.SQLiteOpenHelper._onCreate2523 = @__env.GetMethodID(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V"); 
			global::android.database.sqlite.SQLiteOpenHelper._getWritableDatabase2524 = @__env.GetMethodID(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.database.sqlite.SQLiteOpenHelper._getReadableDatabase2525 = @__env.GetMethodID(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;"); 
			global::android.database.sqlite.SQLiteOpenHelper._onUpgrade2526 = @__env.GetMethodID(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V"); 
			global::android.database.sqlite.SQLiteOpenHelper._onOpen2527 = @__env.GetMethodID(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "onOpen", "(Landroid/database/sqlite/SQLiteDatabase;)V"); 
			global::android.database.sqlite.SQLiteOpenHelper._SQLiteOpenHelper2528 = @__env.GetMethodID(global::android.database.sqlite.SQLiteOpenHelper.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)V"); 
		} 
	} 
} 
