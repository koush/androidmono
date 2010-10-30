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
		internal static global::MonoJavaBridge.MethodId _newInstance32082;
		global::org.apache.http.conn.ClientConnectionManager org.apache.http.conn.ClientConnectionManagerFactory.newInstance(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManagerFactory_._newInstance32082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionManager;
		}
		static ClientConnectionManagerFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionManagerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionManagerFactory"));
			global::org.apache.http.conn.ClientConnectionManagerFactory_._newInstance32082 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManagerFactory_.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnectionManager;");
		}
		internal static void InitJNI()
		{
		}
	}
}
