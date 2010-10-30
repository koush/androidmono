namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.DataSource_))]
	public partial interface DataSource  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.sql.Connection getConnection();
		global::java.sql.Connection getConnection(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.DataSource))]
	internal sealed partial class DataSource_ : java.lang.Object, DataSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DataSource_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.sql.Connection javax.sql.DataSource.getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::javax.sql.DataSource_.staticClass, "getConnection", "()Ljava/sql/Connection;", ref global::javax.sql.DataSource_._m0) as java.sql.Connection;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.sql.Connection javax.sql.DataSource.getConnection(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::javax.sql.DataSource_.staticClass, "getConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;", ref global::javax.sql.DataSource_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Connection;
		}
		static DataSource_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.DataSource_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/DataSource"));
		}
		internal static void InitJNI()
		{
		}
	}
}
