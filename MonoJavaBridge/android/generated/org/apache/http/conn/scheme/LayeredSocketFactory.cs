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
		internal static global::MonoJavaBridge.MethodId _createSocket32290;
		global::java.net.Socket org.apache.http.conn.scheme.LayeredSocketFactory.createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket32290.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket32290 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket32290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket32291;
		global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.createSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket32291.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket32291 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "createSocket", "()Ljava/net/Socket;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_._createSocket32291)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _connectSocket32292;
		global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.scheme.LayeredSocketFactory_._connectSocket32292.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.scheme.LayeredSocketFactory_._connectSocket32292 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_._connectSocket32292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32293;
		bool org.apache.http.conn.scheme.SocketFactory.isSecure(java.net.Socket arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.scheme.LayeredSocketFactory_._isSecure32293.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.scheme.LayeredSocketFactory_._isSecure32293 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.LayeredSocketFactory_.staticClass, "isSecure", "(Ljava/net/Socket;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.LayeredSocketFactory_._isSecure32293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
