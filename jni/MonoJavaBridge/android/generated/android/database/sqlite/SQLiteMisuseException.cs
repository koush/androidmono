namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteMisuseException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteMisuseException()
		{
			InitJNI();
		}
		protected SQLiteMisuseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteMisuseException2879;
		public SQLiteMisuseException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteMisuseException.staticClass, global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException2879);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteMisuseException2880;
		public SQLiteMisuseException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteMisuseException.staticClass, global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException2880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteMisuseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteMisuseException"));
			global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException2879 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteMisuseException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException2880 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteMisuseException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
