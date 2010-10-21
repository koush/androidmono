namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpHostConnectException : java.net.ConnectException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpHostConnectException()
		{
			InitJNI();
		}
		protected HttpHostConnectException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.HttpHost Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost31991;
		public virtual global::org.apache.http.HttpHost getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.HttpHostConnectException._getHost31991)) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.HttpHostConnectException.staticClass, global::org.apache.http.conn.HttpHostConnectException._getHost31991)) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _HttpHostConnectException31992;
		public HttpHostConnectException(org.apache.http.HttpHost arg0, java.net.ConnectException arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.HttpHostConnectException.staticClass, global::org.apache.http.conn.HttpHostConnectException._HttpHostConnectException31992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.HttpHostConnectException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/HttpHostConnectException"));
			global::org.apache.http.conn.HttpHostConnectException._getHost31991 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.HttpHostConnectException.staticClass, "getHost", "()Lorg/apache/http/HttpHost;");
			global::org.apache.http.conn.HttpHostConnectException._HttpHostConnectException31992 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.HttpHostConnectException.staticClass, "<init>", "(Lorg/apache/http/HttpHost;Ljava/net/ConnectException;)V");
		}
	}
}
