namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.@params.ConnConnectionPNames_))]
	public partial interface ConnConnectionPNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.@params.ConnConnectionPNames))]
	public sealed partial class ConnConnectionPNames_ : java.lang.Object, ConnConnectionPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnConnectionPNames_()
		{
			InitJNI();
		}
		internal ConnConnectionPNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnConnectionPNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/@params/ConnConnectionPNames"));
		}
	}
}
