namespace org.apache.http.client.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.@params.AllClientPNames_))]
	public partial interface AllClientPNames : org.apache.http.@params.CoreConnectionPNames, org.apache.http.@params.CoreProtocolPNames, ClientPNames, org.apache.http.auth.@params.AuthPNames, org.apache.http.cookie.@params.CookieSpecPNames, org.apache.http.conn.@params.ConnConnectionPNames, org.apache.http.conn.@params.ConnManagerPNames, org.apache.http.conn.@params.ConnRoutePNames
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.@params.AllClientPNames))]
	internal sealed partial class AllClientPNames_ : java.lang.Object, AllClientPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AllClientPNames_()
		{
			InitJNI();
		}
		internal AllClientPNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.AllClientPNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/params/AllClientPNames"));
		}
	}
}
