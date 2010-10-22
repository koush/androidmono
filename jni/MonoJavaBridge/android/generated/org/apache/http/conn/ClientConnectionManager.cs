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
	public sealed partial class ClientConnectionManager_ : java.lang.Object, ClientConnectionManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientConnectionManager_()
		{
			InitJNI();
		}
		internal ClientConnectionManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown31957;
		 void org.apache.http.conn.ClientConnectionManager.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._shutdown31957);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_.staticClass, global::org.apache.http.conn.ClientConnectionManager_._shutdown31957);
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeRegistry31958;
		 global::org.apache.http.conn.scheme.SchemeRegistry org.apache.http.conn.ClientConnectionManager.getSchemeRegistry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.SchemeRegistry>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._getSchemeRegistry31958)) as org.apache.http.conn.scheme.SchemeRegistry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.SchemeRegistry>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_.staticClass, global::org.apache.http.conn.ClientConnectionManager_._getSchemeRegistry31958)) as org.apache.http.conn.scheme.SchemeRegistry;
		}
		internal static global::MonoJavaBridge.MethodId _requestConnection31959;
		 global::org.apache.http.conn.ClientConnectionRequest org.apache.http.conn.ClientConnectionManager.requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._requestConnection31959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_.staticClass, global::org.apache.http.conn.ClientConnectionManager_._requestConnection31959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionRequest;
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection31960;
		 void org.apache.http.conn.ClientConnectionManager.releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._releaseConnection31960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_.staticClass, global::org.apache.http.conn.ClientConnectionManager_._releaseConnection31960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeIdleConnections31961;
		 void org.apache.http.conn.ClientConnectionManager.closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._closeIdleConnections31961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_.staticClass, global::org.apache.http.conn.ClientConnectionManager_._closeIdleConnections31961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closeExpiredConnections31962;
		 void org.apache.http.conn.ClientConnectionManager.closeExpiredConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_._closeExpiredConnections31962);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManager_.staticClass, global::org.apache.http.conn.ClientConnectionManager_._closeExpiredConnections31962);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionManager"));
			global::org.apache.http.conn.ClientConnectionManager_._shutdown31957 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "shutdown", "()V");
			global::org.apache.http.conn.ClientConnectionManager_._getSchemeRegistry31958 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;");
			global::org.apache.http.conn.ClientConnectionManager_._requestConnection31959 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;");
			global::org.apache.http.conn.ClientConnectionManager_._releaseConnection31960 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.ClientConnectionManager_._closeIdleConnections31961 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.ClientConnectionManager_._closeExpiredConnections31962 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManager_.staticClass, "closeExpiredConnections", "()V");
		}
	}
}
