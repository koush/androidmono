namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SQLiteStatement : android.database.sqlite.SQLiteProgram
	{
		internal new static global::java.lang.Class staticClass;
		static SQLiteStatement()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteStatement), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.sqlite.SQLiteStatement(@__env);
			}
		}
		protected SQLiteStatement(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute2757;
		public virtual void execute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteStatement._execute2757);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._execute2757);
		}
		internal static global::net.sf.jni4net.jni.MethodId _executeInsert2758;
		public virtual long executeInsert() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteStatement._executeInsert2758);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._executeInsert2758);
		}
		internal static global::net.sf.jni4net.jni.MethodId _simpleQueryForLong2759;
		public virtual long simpleQueryForLong() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteStatement._simpleQueryForLong2759);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._simpleQueryForLong2759);
		}
		internal static global::net.sf.jni4net.jni.MethodId _simpleQueryForString2760;
		public virtual global::java.lang.String simpleQueryForString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteStatement._simpleQueryForString2760));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteStatement.staticClass, global::android.database.sqlite.SQLiteStatement._simpleQueryForString2760));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteStatement.staticClass = @__class;
			global::android.database.sqlite.SQLiteStatement._execute2757 = @__env.GetMethodID(global::android.database.sqlite.SQLiteStatement.staticClass, "execute", "()V");
			global::android.database.sqlite.SQLiteStatement._executeInsert2758 = @__env.GetMethodID(global::android.database.sqlite.SQLiteStatement.staticClass, "executeInsert", "()J");
			global::android.database.sqlite.SQLiteStatement._simpleQueryForLong2759 = @__env.GetMethodID(global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForLong", "()J");
			global::android.database.sqlite.SQLiteStatement._simpleQueryForString2760 = @__env.GetMethodID(global::android.database.sqlite.SQLiteStatement.staticClass, "simpleQueryForString", "()Ljava/lang/String;");
		}
	}
}
