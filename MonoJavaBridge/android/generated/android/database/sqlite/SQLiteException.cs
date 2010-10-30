namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteException : android.database.SQLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteException4803;
		public SQLiteException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteException._SQLiteException4803.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteException._SQLiteException4803 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteException.staticClass, global::android.database.sqlite.SQLiteException._SQLiteException4803);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteException4804;
		public SQLiteException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteException._SQLiteException4804.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteException._SQLiteException4804 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteException.staticClass, global::android.database.sqlite.SQLiteException._SQLiteException4804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SQLiteException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
