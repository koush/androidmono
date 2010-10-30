namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteDatabaseCorruptException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteDatabaseCorruptException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SQLiteDatabaseCorruptException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDatabaseCorruptException._m0.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDatabaseCorruptException._m0 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, global::android.database.sqlite.SQLiteDatabaseCorruptException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SQLiteDatabaseCorruptException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDatabaseCorruptException._m1.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDatabaseCorruptException._m1 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, global::android.database.sqlite.SQLiteDatabaseCorruptException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SQLiteDatabaseCorruptException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteDatabaseCorruptException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabaseCorruptException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
