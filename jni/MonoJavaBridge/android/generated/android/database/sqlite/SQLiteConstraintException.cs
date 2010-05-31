namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SQLiteConstraintException : android.database.sqlite.SQLiteException
	{
		internal new static global::java.lang.Class staticClass;
		static SQLiteConstraintException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteConstraintException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.sqlite.SQLiteConstraintException(@__env);
			}
		}
		protected SQLiteConstraintException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteConstraintException2442;
		public SQLiteConstraintException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteConstraintException.staticClass, global::android.database.sqlite.SQLiteConstraintException._SQLiteConstraintException2442, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteConstraintException2443;
		public SQLiteConstraintException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteConstraintException.staticClass, global::android.database.sqlite.SQLiteConstraintException._SQLiteConstraintException2443, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteConstraintException.staticClass = @__class;
			global::android.database.sqlite.SQLiteConstraintException._SQLiteConstraintException2442 = @__env.GetMethodID(global::android.database.sqlite.SQLiteConstraintException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteConstraintException._SQLiteConstraintException2443 = @__env.GetMethodID(global::android.database.sqlite.SQLiteConstraintException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
