namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SQLiteMisuseException : android.database.sqlite.SQLiteException
	{
		internal new static global::java.lang.Class staticClass;
		static SQLiteMisuseException()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteMisuseException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.sqlite.SQLiteMisuseException(@__env);
			}
		}
		protected SQLiteMisuseException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteMisuseException2520;
		public SQLiteMisuseException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteMisuseException.staticClass, global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException2520, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteMisuseException2521;
		public SQLiteMisuseException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteMisuseException.staticClass, global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException2521, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteMisuseException.staticClass = @__class;
			global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException2520 = @__env.GetMethodID(global::android.database.sqlite.SQLiteMisuseException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException2521 = @__env.GetMethodID(global::android.database.sqlite.SQLiteMisuseException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
