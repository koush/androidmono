namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ClientConnectionManager_))]
	public partial interface ClientConnectionManager  : global::MonoJavaBridge.IJavaObject 
	{
		void shutdown();
		global::org.apache.http.conn.scheme.SchemeRegistry getSchemeRegistry();
		global::org.apache.http.conn.ClientConnectionRequest requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1);
		void releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1);
		void closeExpiredConnections();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ClientConnectionManager))]
	internal sealed partial class ClientConnectionManager_ : java.lang.Object, ClientConnectionManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ClientConnectionManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.conn.ClientConnectionManager.shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ClientConnectionManager_.staticClass, "shutdown", "()V", ref global::org.apache.http.conn.ClientConnectionManager_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.apache.http.conn.scheme.SchemeRegistry org.apache.http.conn.ClientConnectionManager.getSchemeRegistry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.scheme.SchemeRegistry>(this, global::org.apache.http.conn.ClientConnectionManager_.staticClass, "getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;", ref global::org.apache.http.conn.ClientConnectionManager_._m1) as org.apache.http.conn.scheme.SchemeRegistry;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.apache.http.conn.ClientConnectionRequest org.apache.http.conn.ClientConnectionManager.requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionRequest>(this, global::org.apache.http.conn.ClientConnectionManager_.staticClass, "requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;", ref global::org.apache.http.conn.ClientConnectionManager_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.conn.ClientConnectionRequest;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void org.apache.http.conn.ClientConnectionManager.releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ClientConnectionManager_.staticClass, "releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.conn.ClientConnectionManager_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.apache.http.conn.ClientConnectionManager.closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ClientConnectionManager_.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V", ref global::org.apache.http.conn.ClientConnectionManager_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.apache.http.conn.ClientConnectionManager.closeExpiredConnections()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ClientConnectionManager_.staticClass, "closeExpiredConnections", "()V", ref global::org.apache.http.conn.ClientConnectionManager_._m5);
		}
		static ClientConnectionManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionManager"));
		}
	}
}
