namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SQLiteDoneException : android.database.sqlite.SQLiteException
	{
		internal new static global::java.lang.Class staticClass;
		static SQLiteDoneException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteDoneException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.sqlite.SQLiteDoneException(@__env);
			}
		}
		protected SQLiteDoneException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteDoneException2703;
		public SQLiteDoneException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteDoneException.staticClass, global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException2703, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteDoneException2704;
		public SQLiteDoneException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteDoneException.staticClass, global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException2704, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteDoneException.staticClass = @__class;
			global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException2703 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDoneException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteDoneException._SQLiteDoneException2704 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDoneException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
