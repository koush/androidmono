namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteDiskIOException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteDiskIOException()
		{
			InitJNI();
		}
		protected SQLiteDiskIOException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteDiskIOException4799;
		public SQLiteDiskIOException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDiskIOException.staticClass, global::android.database.sqlite.SQLiteDiskIOException._SQLiteDiskIOException4799);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteDiskIOException4800;
		public SQLiteDiskIOException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDiskIOException.staticClass, global::android.database.sqlite.SQLiteDiskIOException._SQLiteDiskIOException4800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteDiskIOException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDiskIOException"));
			global::android.database.sqlite.SQLiteDiskIOException._SQLiteDiskIOException4799 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDiskIOException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteDiskIOException._SQLiteDiskIOException4800 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDiskIOException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
