namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ConnectionKeepAliveStrategy_))]
	public partial interface ConnectionKeepAliveStrategy  : global::MonoJavaBridge.IJavaObject 
	{
		long getKeepAliveDuration(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ConnectionKeepAliveStrategy))]
	internal sealed partial class ConnectionKeepAliveStrategy_ : java.lang.Object, ConnectionKeepAliveStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnectionKeepAliveStrategy_()
		{
			InitJNI();
		}
		internal ConnectionKeepAliveStrategy_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getKeepAliveDuration32089;
		 long org.apache.http.conn.ConnectionKeepAliveStrategy.getKeepAliveDuration(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.conn.ConnectionKeepAliveStrategy_._getKeepAliveDuration32089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.conn.ConnectionKeepAliveStrategy_.staticClass, global::org.apache.http.conn.ConnectionKeepAliveStrategy_._getKeepAliveDuration32089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ConnectionKeepAliveStrategy_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ConnectionKeepAliveStrategy"));
			global::org.apache.http.conn.ConnectionKeepAliveStrategy_._getKeepAliveDuration32089 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ConnectionKeepAliveStrategy_.staticClass, "getKeepAliveDuration", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)J");
		}
	}
}
