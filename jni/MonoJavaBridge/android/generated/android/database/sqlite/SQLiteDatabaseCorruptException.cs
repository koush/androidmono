namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SQLiteDatabaseCorruptException : android.database.sqlite.SQLiteException
	{
		internal new static global::java.lang.Class staticClass;
		static SQLiteDatabaseCorruptException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteDatabaseCorruptException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.sqlite.SQLiteDatabaseCorruptException(@__env);
			}
		}
		protected SQLiteDatabaseCorruptException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteDatabaseCorruptException2699;
		public SQLiteDatabaseCorruptException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, global::android.database.sqlite.SQLiteDatabaseCorruptException._SQLiteDatabaseCorruptException2699, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteDatabaseCorruptException2700;
		public SQLiteDatabaseCorruptException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, global::android.database.sqlite.SQLiteDatabaseCorruptException._SQLiteDatabaseCorruptException2700, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteDatabaseCorruptException.staticClass = @__class;
			global::android.database.sqlite.SQLiteDatabaseCorruptException._SQLiteDatabaseCorruptException2699 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteDatabaseCorruptException._SQLiteDatabaseCorruptException2700 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabaseCorruptException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
