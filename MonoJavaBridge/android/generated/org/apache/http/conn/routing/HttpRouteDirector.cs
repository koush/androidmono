namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.routing.HttpRouteDirector_))]
	public partial interface HttpRouteDirector  : global::MonoJavaBridge.IJavaObject 
	{
		int nextStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.routing.HttpRouteDirector))]
	internal sealed partial class HttpRouteDirector_ : java.lang.Object, HttpRouteDirector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRouteDirector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _nextStep32239;
		int org.apache.http.conn.routing.HttpRouteDirector.nextStep(org.apache.http.conn.routing.RouteInfo arg0, org.apache.http.conn.routing.RouteInfo arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.routing.HttpRouteDirector_.staticClass, "nextStep", "(Lorg/apache/http/conn/routing/RouteInfo;Lorg/apache/http/conn/routing/RouteInfo;)I", ref global::org.apache.http.conn.routing.HttpRouteDirector_._nextStep32239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static HttpRouteDirector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.routing.HttpRouteDirector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/routing/HttpRouteDirector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
