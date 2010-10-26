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
		static ConnPerRoute_()
		{
			InitJNI();
		}
		internal ConnPerRoute_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getMaxForRoute32190;
		 int org.apache.http.conn.@params.ConnPerRoute.getMaxForRoute(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRoute_._getMaxForRoute32190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRoute_.staticClass, global::org.apache.http.conn.@params.ConnPerRoute_._getMaxForRoute32190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnPerRoute_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnPerRoute"));
			global::org.apache.http.conn.@params.ConnPerRoute_._getMaxForRoute32190 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRoute_.staticClass, "getMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)I");
		}
	}
}
