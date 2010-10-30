namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ClientConnectionManagerFactory_))]
	public partial interface ClientConnectionManagerFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.conn.ClientConnectionManager newInstance(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ClientConnectionManagerFactory))]
	internal sealed partial class ClientConnectionManagerFactory_ : java.lang.Object, ClientConnectionManagerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ClientConnectionManagerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.conn.ClientConnectionManager org.apache.http.conn.ClientConnectionManagerFactory.newInstance(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::org.apache.http.conn.ClientConnectionManagerFactory_.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnectionManager;", ref global::org.apache.http.conn.ClientConnectionManagerFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.conn.ClientConnectionManager;
		}
		static ClientConnectionManagerFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionManagerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionManagerFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
