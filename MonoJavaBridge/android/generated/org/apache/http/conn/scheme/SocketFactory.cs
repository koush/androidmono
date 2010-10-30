namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.scheme.SocketFactory_))]
	public partial interface SocketFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.net.Socket createSocket();
		global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5);
		bool isSecure(java.net.Socket arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.scheme.SocketFactory))]
	internal sealed partial class SocketFactory_ : java.lang.Object, SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSocket32319;
		global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.createSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SocketFactory_._createSocket32319)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _connectSocket32320;
		global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SocketFactory_._connectSocket32320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32321;
		bool org.apache.http.conn.scheme.SocketFactory.isSecure(java.net.Socket arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SocketFactory_._isSecure32321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SocketFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.SocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/SocketFactory"));
			global::org.apache.http.conn.scheme.SocketFactory_._createSocket32319 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SocketFactory_.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.SocketFactory_._connectSocket32320 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SocketFactory_.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.SocketFactory_._isSecure32321 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SocketFactory_.staticClass, "isSecure", "(Ljava/net/Socket;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
