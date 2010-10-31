namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.ConnectionPoolDataSource_))]
	public partial interface ConnectionPoolDataSource  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.sql.PooledConnection getPooledConnection();
		global::javax.sql.PooledConnection getPooledConnection(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.ConnectionPoolDataSource))]
	internal sealed partial class ConnectionPoolDataSource_ : java.lang.Object, ConnectionPoolDataSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnectionPoolDataSource_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::javax.sql.PooledConnection javax.sql.ConnectionPoolDataSource.getPooledConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.sql.PooledConnection>(this, global::javax.sql.ConnectionPoolDataSource_.staticClass, "getPooledConnection", "()Ljavax/sql/PooledConnection;", ref global::javax.sql.ConnectionPoolDataSource_._m0) as javax.sql.PooledConnection;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::javax.sql.PooledConnection javax.sql.ConnectionPoolDataSource.getPooledConnection(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.sql.PooledConnection>(this, global::javax.sql.ConnectionPoolDataSource_.staticClass, "getPooledConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/sql/PooledConnection;", ref global::javax.sql.ConnectionPoolDataSource_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.sql.PooledConnection;
		}
		static ConnectionPoolDataSource_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.ConnectionPoolDataSource_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/ConnectionPoolDataSource"));
		}
	}
}
