namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteException : android.database.SQLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteException()
		{
			InitJNI();
		}
		protected SQLiteException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteException2875;
		public SQLiteException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteException.staticClass, global::android.database.sqlite.SQLiteException._SQLiteException2875);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteException2876;
		public SQLiteException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteException.staticClass, global::android.database.sqlite.SQLiteException._SQLiteException2876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteException"));
			global::android.database.sqlite.SQLiteException._SQLiteException2875 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteException._SQLiteException2876 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
