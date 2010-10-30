namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteStatement : android.database.sqlite.SQLiteProgram
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteStatement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _execute4857;
		public virtual void execute()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._execute4857);
		}
		internal static global::MonoJavaBridge.MethodId _executeInsert4858;
		public virtual long executeInsert()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._executeInsert4858);
		}
		internal static global::MonoJavaBridge.MethodId _simpleQueryForLong4859;
		public virtual long simpleQueryForLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._simpleQueryForLong4859);
		}
		internal static global::MonoJavaBridge.MethodId _simpleQueryForString4860;
		public virtual global::java.lang.String simpleQueryForString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._simpleQueryForString4860)) as java.lang.String;
		}
		static SQLiteStatement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteStatement.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteStatement"));
			global::android.database.sqlite.SQLiteStatement._execute4857 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteStatement.staticClass, "execute", "()V");
			global::android.database.sqlite.SQLiteStatement._executeInsert4858 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteStatement.staticClass, "executeInsert", "()J");
			global::android.database.sqlite.SQLiteStatement._simpleQueryForLong4859 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForLong", "()J");
			global::android.database.sqlite.SQLiteStatement._simpleQueryForString4860 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForString", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
