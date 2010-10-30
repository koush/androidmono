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
		internal static global::MonoJavaBridge.MethodId _shutdown32076;
		void org.apache.http.conn.ClientConnectionManager.shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._shutdown32076);
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeRegistry32077;
		global::org.apache.http.conn.scheme.SchemeRegistry org.apache.http.conn.ClientConnectionManager.getSchemeRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.SchemeRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._getSchemeRegistry32077)) as org.apache.http.conn.scheme.SchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _requestConnection32078;
		global::org.apache.http.conn.ClientConnectionRequest org.apache.http.conn.ClientConnectionManager.requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._requestConnection32078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionRequest;
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32079;
		void org.apache.http.conn.ClientConnectionManager.releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._releaseConnection32079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections32080;
		void org.apache.http.conn.ClientConnectionManager.closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._closeIdleConnections32080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections32081;
		void org.apache.http.conn.ClientConnectionManager.closeExpiredConnections()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._closeExpiredConnections32081);
		}
		static ClientConnectionManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionManager"));
			global::org.apache.http.conn.ClientConnectionManager_._shutdown32076 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "shutdown", "()V");
			global::org.apache.http.conn.ClientConnectionManager_._getSchemeRegistry32077 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;");
			global::org.apache.http.conn.ClientConnectionManager_._requestConnection32078 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;");
			global::org.apache.http.conn.ClientConnectionManager_._releaseConnection32079 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.ClientConnectionManager_._closeIdleConnections32080 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.ClientConnectionManager_._closeExpiredConnections32081 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "closeExpiredConnections", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
