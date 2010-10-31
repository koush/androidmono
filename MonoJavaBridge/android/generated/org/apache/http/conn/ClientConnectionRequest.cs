namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ClientConnectionRequest_))]
	public partial interface ClientConnectionRequest  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.conn.ManagedClientConnection getConnection(long arg0, java.util.concurrent.TimeUnit arg1);
		void abortRequest();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ClientConnectionRequest))]
	internal sealed partial class ClientConnectionRequest_ : java.lang.Object, ClientConnectionRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ClientConnectionRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.conn.ManagedClientConnection org.apache.http.conn.ClientConnectionRequest.getConnection(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ManagedClientConnection>(this, global::org.apache.http.conn.ClientConnectionRequest_.staticClass, "getConnection", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/conn/ManagedClientConnection;", ref global::org.apache.http.conn.ClientConnectionRequest_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.conn.ManagedClientConnection;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.apache.http.conn.ClientConnectionRequest.abortRequest()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ClientConnectionRequest_.staticClass, "abortRequest", "()V", ref global::org.apache.http.conn.ClientConnectionRequest_._m1);
		}
		static ClientConnectionRequest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionRequest"));
		}
	}
}
