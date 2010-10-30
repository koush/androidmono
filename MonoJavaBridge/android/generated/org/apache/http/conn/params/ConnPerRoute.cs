namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.@params.ConnPerRoute_))]
	public partial interface ConnPerRoute  : global::MonoJavaBridge.IJavaObject 
	{
		int getMaxForRoute(org.apache.http.conn.routing.HttpRoute arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.@params.ConnPerRoute))]
	internal sealed partial class ConnPerRoute_ : java.lang.Object, ConnPerRoute
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnPerRoute_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getMaxForRoute32191;
		int org.apache.http.conn.@params.ConnPerRoute.getMaxForRoute(org.apache.http.conn.routing.HttpRoute arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.@params.ConnPerRoute_.staticClass, "getMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)I", ref global::org.apache.http.conn.@params.ConnPerRoute_._getMaxForRoute32191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ConnPerRoute_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnPerRoute_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnPerRoute"));
		}
		internal static void InitJNI()
		{
		}
	}
}
