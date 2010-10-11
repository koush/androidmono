namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteDoneException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteDoneException()
		{
			InitJNI();
		}
		protected SQLiteDoneException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteDoneException2873;
		public SQLiteDoneException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDoneException.staticClass, global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException2873);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteDoneException2874;
		public SQLiteDoneException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDoneException.staticClass, global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException2874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteDoneException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDoneException"));
			global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException2873 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDoneException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException2874 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDoneException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
