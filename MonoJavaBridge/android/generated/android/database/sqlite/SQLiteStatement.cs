namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteStatement : android.database.sqlite.SQLiteProgram
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteStatement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void execute()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, "execute", "()V", ref global::android.database.sqlite.SQLiteStatement._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual long executeInsert()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, "executeInsert", "()J", ref global::android.database.sqlite.SQLiteStatement._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual long simpleQueryForLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForLong", "()J", ref global::android.database.sqlite.SQLiteStatement._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String simpleQueryForString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForString", "()Ljava/lang/String;", ref global::android.database.sqlite.SQLiteStatement._m3) as java.lang.String;
		}
		static SQLiteStatement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteStatement.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteStatement"));
		}
		internal static void InitJNI()
		{
		}
	}
}
