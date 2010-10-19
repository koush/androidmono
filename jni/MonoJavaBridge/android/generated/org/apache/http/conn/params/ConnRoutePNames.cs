namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.@params.ConnRoutePNames_))]
	public interface ConnRoutePNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.@params.ConnRoutePNames))]
	public sealed partial class ConnRoutePNames_ : java.lang.Object, ConnRoutePNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnRoutePNames_()
		{
			InitJNI();
		}
		internal ConnRoutePNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnRoutePNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/@params/ConnRoutePNames"));
		}
	}
}
