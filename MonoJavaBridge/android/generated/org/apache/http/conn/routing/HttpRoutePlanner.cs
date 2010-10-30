namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.routing.HttpRoutePlanner_))]
	public partial interface HttpRoutePlanner  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.conn.routing.HttpRoute determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.routing.HttpRoutePlanner))]
	internal sealed partial class HttpRoutePlanner_ : java.lang.Object, HttpRoutePlanner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRoutePlanner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _determineRoute32247;
		global::org.apache.http.conn.routing.HttpRoute org.apache.http.conn.routing.HttpRoutePlanner.determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.routing.HttpRoute>(this, global::org.apache.http.conn.routing.HttpRoutePlanner_.staticClass, "determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;", ref global::org.apache.http.conn.routing.HttpRoutePlanner_._determineRoute32247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.conn.routing.HttpRoute;
		}
		static HttpRoutePlanner_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.HttpRoutePlanner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/HttpRoutePlanner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
