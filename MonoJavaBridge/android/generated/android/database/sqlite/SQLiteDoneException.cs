namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteDoneException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteDoneException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteDoneException4801;
		public SQLiteDoneException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException4801.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException4801 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDoneException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDoneException.staticClass, global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException4801);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteDoneException4802;
		public SQLiteDoneException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException4802.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException4802 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDoneException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDoneException.staticClass, global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException4802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SQLiteDoneException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteDoneException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDoneException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
