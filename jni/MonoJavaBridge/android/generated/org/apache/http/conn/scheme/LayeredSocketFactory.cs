namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.scheme.LayeredSocketFactory_))]
	public interface LayeredSocketFactory : SocketFactory
	{
		global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.scheme.LayeredSocketFactory))]
	public sealed partial class LayeredSocketFactory_ : java.lang.Object, LayeredSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LayeredSocketFactory_()
		{
			InitJNI();
		}
		internal LayeredSocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSocket25573;
		 global::java.net.Socket org.apache.http.conn.scheme.LayeredSocketFactory.createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket25573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket25573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket25574;
		 global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.createSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket25574)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket25574)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _connectSocket25575;
		 global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_._connectSocket25575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, global::org.apache.http.conn.scheme.LayeredSocketFactory_._connectSocket25575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25576;
		 bool org.apache.http.conn.scheme.SocketFactory.isSecure(java.net.Socket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_._isSecure25576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, global::org.apache.http.conn.scheme.LayeredSocketFactory_._isSecure25576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/LayeredSocketFactory"));
			global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket25573 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket25574 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.LayeredSocketFactory_._connectSocket25575 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/@params/HttpParams;)Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.LayeredSocketFactory_._isSecure25576 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "isSecure", "(Ljava/net/Socket;)Z");
		}
	}
}
