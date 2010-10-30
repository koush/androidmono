namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.RequestDirector_))]
	public partial interface RequestDirector  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.RequestDirector))]
	internal sealed partial class RequestDirector_ : java.lang.Object, RequestDirector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RequestDirector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _execute31901;
		global::org.apache.http.HttpResponse org.apache.http.client.RequestDirector.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.client.RequestDirector_.staticClass, "execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.client.RequestDirector_._execute31901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		static RequestDirector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.RequestDirector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/RequestDirector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
