namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteDatabaseCorruptException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteDatabaseCorruptException()
		{
			InitJNI();
		}
		protected SQLiteDatabaseCorruptException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteDatabaseCorruptException4779;
		public SQLiteDatabaseCorruptException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, global::android.database.sqlite.SQLiteDatabaseCorruptException._SQLiteDatabaseCorruptException4779);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteDatabaseCorruptException4780;
		public SQLiteDatabaseCorruptException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, global::android.database.sqlite.SQLiteDatabaseCorruptException._SQLiteDatabaseCorruptException4780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteDatabaseCorruptException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabaseCorruptException"));
			global::android.database.sqlite.SQLiteDatabaseCorruptException._SQLiteDatabaseCorruptException4779 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteDatabaseCorruptException._SQLiteDatabaseCorruptException4780 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
