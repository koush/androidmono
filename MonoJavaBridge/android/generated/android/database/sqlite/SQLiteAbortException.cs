namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteAbortException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteAbortException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteAbortException4704;
		public SQLiteAbortException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteAbortException.staticClass, global::android.database.sqlite.SQLiteAbortException._SQLiteAbortException4704);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteAbortException4705;
		public SQLiteAbortException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteAbortException.staticClass, global::android.database.sqlite.SQLiteAbortException._SQLiteAbortException4705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SQLiteAbortException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteAbortException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteAbortException"));
			global::android.database.sqlite.SQLiteAbortException._SQLiteAbortException4704 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteAbortException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteAbortException._SQLiteAbortException4705 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteAbortException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
