namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteFullException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteFullException()
		{
			InitJNI();
		}
		protected SQLiteFullException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteFullException4787;
		public SQLiteFullException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteFullException.staticClass, global::android.database.sqlite.SQLiteFullException._SQLiteFullException4787);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteFullException4788;
		public SQLiteFullException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteFullException.staticClass, global::android.database.sqlite.SQLiteFullException._SQLiteFullException4788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteFullException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteFullException"));
			global::android.database.sqlite.SQLiteFullException._SQLiteFullException4787 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteFullException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteFullException._SQLiteFullException4788 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteFullException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
