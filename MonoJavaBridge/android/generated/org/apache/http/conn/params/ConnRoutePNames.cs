namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.@params.ConnRoutePNames_))]
	public partial interface ConnRoutePNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.@params.ConnRoutePNames))]
	internal sealed partial class ConnRoutePNames_ : java.lang.Object, ConnRoutePNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnRoutePNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ConnRoutePNames_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnRoutePNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnRoutePNames"));
		}
	}
}
