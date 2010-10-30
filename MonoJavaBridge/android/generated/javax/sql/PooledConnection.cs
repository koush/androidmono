namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.PooledConnection_))]
	public partial interface PooledConnection  : global::MonoJavaBridge.IJavaObject 
	{
		void close();
		global::java.sql.Connection getConnection();
		void addConnectionEventListener(javax.sql.ConnectionEventListener arg0);
		void removeConnectionEventListener(javax.sql.ConnectionEventListener arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.PooledConnection))]
	internal sealed partial class PooledConnection_ : java.lang.Object, PooledConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PooledConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.sql.PooledConnection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.PooledConnection_.staticClass, "close", "()V", ref global::javax.sql.PooledConnection_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.sql.Connection javax.sql.PooledConnection.getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::javax.sql.PooledConnection_.staticClass, "getConnection", "()Ljava/sql/Connection;", ref global::javax.sql.PooledConnection_._m1) as java.sql.Connection;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.sql.PooledConnection.addConnectionEventListener(javax.sql.ConnectionEventListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.PooledConnection_.staticClass, "addConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", ref global::javax.sql.PooledConnection_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void javax.sql.PooledConnection.removeConnectionEventListener(javax.sql.ConnectionEventListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.PooledConnection_.staticClass, "removeConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", ref global::javax.sql.PooledConnection_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static PooledConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.PooledConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/PooledConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
