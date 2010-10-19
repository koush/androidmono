namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ClientConnectionOperator_))]
	public interface ClientConnectionOperator  : global::MonoJavaBridge.IJavaObject 
	{
		void openConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, java.net.InetAddress arg2, org.apache.http.protocol.HttpContext arg3, org.apache.http.@params.HttpParams arg4);
		global::org.apache.http.conn.OperatedClientConnection createConnection();
		void updateSecureConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, org.apache.http.protocol.HttpContext arg2, org.apache.http.@params.HttpParams arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ClientConnectionOperator))]
	public sealed partial class ClientConnectionOperator_ : java.lang.Object, ClientConnectionOperator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientConnectionOperator_()
		{
			InitJNI();
		}
		internal ClientConnectionOperator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _openConnection25382;
		 void org.apache.http.conn.ClientConnectionOperator.openConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, java.net.InetAddress arg2, org.apache.http.protocol.HttpContext arg3, org.apache.http.@params.HttpParams arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionOperator_._openConnection25382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionOperator_.staticClass, global::org.apache.http.conn.ClientConnectionOperator_._openConnection25382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _createConnection25383;
		 global::org.apache.http.conn.OperatedClientConnection org.apache.http.conn.ClientConnectionOperator.createConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionOperator_._createConnection25383)) as org.apache.http.conn.OperatedClientConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionOperator_.staticClass, global::org.apache.http.conn.ClientConnectionOperator_._createConnection25383)) as org.apache.http.conn.OperatedClientConnection;
		}
		internal static global::MonoJavaBridge.MethodId _updateSecureConnection25384;
		 void org.apache.http.conn.ClientConnectionOperator.updateSecureConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, org.apache.http.protocol.HttpContext arg2, org.apache.http.@params.HttpParams arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionOperator_._updateSecureConnection25384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionOperator_.staticClass, global::org.apache.http.conn.ClientConnectionOperator_._updateSecureConnection25384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionOperator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionOperator"));
			global::org.apache.http.conn.ClientConnectionOperator_._openConnection25382 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionOperator_.staticClass, "openConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.conn.ClientConnectionOperator_._createConnection25383 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionOperator_.staticClass, "createConnection", "()Lorg/apache/http/conn/OperatedClientConnection;");
			global::org.apache.http.conn.ClientConnectionOperator_._updateSecureConnection25384 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionOperator_.staticClass, "updateSecureConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
