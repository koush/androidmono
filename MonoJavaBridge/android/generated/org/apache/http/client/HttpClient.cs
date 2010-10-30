namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.HttpClient_))]
	public partial interface HttpClient  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.@params.HttpParams getParams();
		global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0);
		global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.protocol.HttpContext arg1);
		global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1);
		global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2);
		global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1);
		global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1, org.apache.http.protocol.HttpContext arg2);
		global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2);
		global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2, org.apache.http.protocol.HttpContext arg3);
		global::org.apache.http.conn.ClientConnectionManager getConnectionManager();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.HttpClient))]
	internal sealed partial class HttpClient_ : java.lang.Object, HttpClient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpClient_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParams31881;
		global::org.apache.http.@params.HttpParams org.apache.http.client.HttpClient.getParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.client.HttpClient_.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.client.HttpClient_._getParams31881) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _execute31882;
		global::org.apache.http.HttpResponse org.apache.http.client.HttpClient.execute(org.apache.http.client.methods.HttpUriRequest arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.client.HttpClient_.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.client.HttpClient_._execute31882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute31883;
		global::org.apache.http.HttpResponse org.apache.http.client.HttpClient.execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.client.HttpClient_.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.client.HttpClient_._execute31883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute31884;
		global::org.apache.http.HttpResponse org.apache.http.client.HttpClient.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.client.HttpClient_.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.client.HttpClient_._execute31884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute31885;
		global::org.apache.http.HttpResponse org.apache.http.client.HttpClient.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.client.HttpClient_.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.client.HttpClient_._execute31885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _execute31886;
		global::java.lang.Object org.apache.http.client.HttpClient.execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.HttpClient_.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;", ref global::org.apache.http.client.HttpClient_._execute31886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute31887;
		global::java.lang.Object org.apache.http.client.HttpClient.execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.HttpClient_.staticClass, "execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", ref global::org.apache.http.client.HttpClient_._execute31887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute31888;
		global::java.lang.Object org.apache.http.client.HttpClient.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.HttpClient_.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;", ref global::org.apache.http.client.HttpClient_._execute31888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute31889;
		global::java.lang.Object org.apache.http.client.HttpClient.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2, org.apache.http.protocol.HttpContext arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.HttpClient_.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", ref global::org.apache.http.client.HttpClient_._execute31889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getConnectionManager31890;
		global::org.apache.http.conn.ClientConnectionManager org.apache.http.client.HttpClient.getConnectionManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.conn.ClientConnectionManager>(this, global::org.apache.http.client.HttpClient_.staticClass, "getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;", ref global::org.apache.http.client.HttpClient_._getConnectionManager31890) as org.apache.http.conn.ClientConnectionManager;
		}
		static HttpClient_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.HttpClient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/HttpClient"));
		}
		internal static void InitJNI()
		{
		}
	}
}
