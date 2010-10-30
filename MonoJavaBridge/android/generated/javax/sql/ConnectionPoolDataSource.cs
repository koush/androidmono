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
		internal static global::MonoJavaBridge.MethodId _getPooledConnection30282;
		global::javax.sql.PooledConnection javax.sql.ConnectionPoolDataSource.getPooledConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.sql.PooledConnection>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.ConnectionPoolDataSource_._getPooledConnection30282)) as javax.sql.PooledConnection;
		}
		internal static global::MonoJavaBridge.MethodId _getPooledConnection30283;
		global::javax.sql.PooledConnection javax.sql.ConnectionPoolDataSource.getPooledConnection(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.sql.PooledConnection>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.ConnectionPoolDataSource_._getPooledConnection30283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.sql.PooledConnection;
		}
		static ConnectionPoolDataSource_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.ConnectionPoolDataSource_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/ConnectionPoolDataSource"));
			global::javax.sql.ConnectionPoolDataSource_._getPooledConnection30282 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionPoolDataSource_.staticClass, "getPooledConnection", "()Ljavax/sql/PooledConnection;");
			global::javax.sql.ConnectionPoolDataSource_._getPooledConnection30283 = @__env.GetMethodIDNoThrow(global::javax.sql.ConnectionPoolDataSource_.staticClass, "getPooledConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/sql/PooledConnection;");
		}
		internal static void InitJNI()
		{
		}
	}
}
