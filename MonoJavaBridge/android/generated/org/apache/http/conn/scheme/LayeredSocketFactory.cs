namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.scheme.LayeredSocketFactory_))]
	public partial interface LayeredSocketFactory : SocketFactory
	{
		global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.scheme.LayeredSocketFactory))]
	internal sealed partial class LayeredSocketFactory_ : java.lang.Object, LayeredSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LayeredSocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.net.Socket org.apache.http.conn.scheme.LayeredSocketFactory.createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", ref global::org.apache.http.conn.scheme.LayeredSocketFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.createSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "createSocket", "()Ljava/net/Socket;", ref global::org.apache.http.conn.scheme.LayeredSocketFactory_._m1) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;", ref global::org.apache.http.conn.scheme.LayeredSocketFactory_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool org.apache.http.conn.scheme.SocketFactory.isSecure(java.net.Socket arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "isSecure", "(Ljava/net/Socket;)Z", ref global::org.apache.http.conn.scheme.LayeredSocketFactory_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static LayeredSocketFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/LayeredSocketFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
