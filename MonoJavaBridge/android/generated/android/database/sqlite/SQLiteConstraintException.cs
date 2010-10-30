namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteConstraintException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteConstraintException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SQLiteConstraintException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteConstraintException._m0.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteConstraintException._m0 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteConstraintException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteConstraintException.staticClass, global::android.database.sqlite.SQLiteConstraintException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SQLiteConstraintException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteConstraintException._m1.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteConstraintException._m1 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteConstraintException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteConstraintException.staticClass, global::android.database.sqlite.SQLiteConstraintException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SQLiteConstraintException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteConstraintException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteConstraintException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
