namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ClientConnectionOperator_))]
	public partial interface ClientConnectionOperator  : global::MonoJavaBridge.IJavaObject 
	{
		void openConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, java.net.InetAddress arg2, org.apache.http.protocol.HttpContext arg3, org.apache.http.@params.HttpParams arg4);
		global::org.apache.http.conn.OperatedClientConnection createConnection();
		void updateSecureConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, org.apache.http.protocol.HttpContext arg2, org.apache.http.@params.HttpParams arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ClientConnectionOperator))]
	internal sealed partial class ClientConnectionOperator_ : java.lang.Object, ClientConnectionOperator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ClientConnectionOperator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.conn.ClientConnectionOperator.openConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, java.net.InetAddress arg2, org.apache.http.protocol.HttpContext arg3, org.apache.http.@params.HttpParams arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ClientConnectionOperator_.staticClass, "openConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ClientConnectionOperator_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.apache.http.conn.OperatedClientConnection org.apache.http.conn.ClientConnectionOperator.createConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.OperatedClientConnection>(this, global::org.apache.http.conn.ClientConnectionOperator_.staticClass, "createConnection", "()Lorg/apache/http/conn/OperatedClientConnection;", ref global::org.apache.http.conn.ClientConnectionOperator_._m1) as org.apache.http.conn.OperatedClientConnection;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.conn.ClientConnectionOperator.updateSecureConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, org.apache.http.protocol.HttpContext arg2, org.apache.http.@params.HttpParams arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ClientConnectionOperator_.staticClass, "updateSecureConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V", ref global::org.apache.http.conn.ClientConnectionOperator_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static ClientConnectionOperator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionOperator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionOperator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
