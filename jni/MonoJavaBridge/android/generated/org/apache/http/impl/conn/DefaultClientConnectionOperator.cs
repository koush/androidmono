namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultClientConnectionOperator : java.lang.Object, org.apache.http.conn.ClientConnectionOperator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultClientConnectionOperator()
		{
			InitJNI();
		}
		protected DefaultClientConnectionOperator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _openConnection33039;
		public virtual void openConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, java.net.InetAddress arg2, org.apache.http.protocol.HttpContext arg3, org.apache.http.@params.HttpParams arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._openConnection33039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._openConnection33039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _createConnection33040;
		public virtual global::org.apache.http.conn.OperatedClientConnection createConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._createConnection33040)) as org.apache.http.conn.OperatedClientConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._createConnection33040)) as org.apache.http.conn.OperatedClientConnection;
		}
		internal static global::MonoJavaBridge.MethodId _updateSecureConnection33041;
		public virtual void updateSecureConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, org.apache.http.protocol.HttpContext arg2, org.apache.http.@params.HttpParams arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._updateSecureConnection33041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._updateSecureConnection33041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _prepareSocket33042;
		protected virtual void prepareSocket(java.net.Socket arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._prepareSocket33042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._prepareSocket33042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _DefaultClientConnectionOperator33043;
		public DefaultClientConnectionOperator(org.apache.http.conn.scheme.SchemeRegistry arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._DefaultClientConnectionOperator33043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/DefaultClientConnectionOperator"));
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._openConnection33039 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "openConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._createConnection33040 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "createConnection", "()Lorg/apache/http/conn/OperatedClientConnection;");
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._updateSecureConnection33041 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "updateSecureConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._prepareSocket33042 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "prepareSocket", "(Ljava/net/Socket;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._DefaultClientConnectionOperator33043 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)V");
		}
	}
}
