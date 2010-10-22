namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.ClientConnectionManagerFactory_))]
	public partial interface ClientConnectionManagerFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.conn.ClientConnectionManager newInstance(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ClientConnectionManagerFactory))]
	public sealed partial class ClientConnectionManagerFactory_ : java.lang.Object, ClientConnectionManagerFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientConnectionManagerFactory_()
		{
			InitJNI();
		}
		internal ClientConnectionManagerFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance31963;
		 global::org.apache.http.conn.ClientConnectionManager org.apache.http.conn.ClientConnectionManagerFactory.newInstance(org.apache.http.@params.HttpParams arg0, org.apache.http.conn.scheme.SchemeRegistry arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManagerFactory_._newInstance31963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ClientConnectionManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ClientConnectionManagerFactory_.staticClass, global::org.apache.http.conn.ClientConnectionManagerFactory_._newInstance31963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ClientConnectionManager;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ClientConnectionManagerFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ClientConnectionManagerFactory"));
			global::org.apache.http.conn.ClientConnectionManagerFactory_._newInstance31963 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ClientConnectionManagerFactory_.staticClass, "newInstance", "(Lorg/apache/http/@params/HttpParams;Lorg/apache/http/conn/scheme/SchemeRegistry;)Lorg/apache/http/conn/ClientConnectionManager;");
		}
	}
}
