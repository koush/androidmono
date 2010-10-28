namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteFullException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteFullException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteFullException4805;
		public SQLiteFullException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteFullException.staticClass, global::android.database.sqlite.SQLiteFullException._SQLiteFullException4805);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteFullException4806;
		public SQLiteFullException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteFullException.staticClass, global::android.database.sqlite.SQLiteFullException._SQLiteFullException4806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SQLiteFullException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteFullException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteFullException"));
			global::android.database.sqlite.SQLiteFullException._SQLiteFullException4805 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteFullException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteFullException._SQLiteFullException4806 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteFullException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
