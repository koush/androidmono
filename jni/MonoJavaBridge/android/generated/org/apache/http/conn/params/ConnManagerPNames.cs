namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.@params.ConnManagerPNames_))]
	public partial interface ConnManagerPNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.@params.ConnManagerPNames))]
	internal sealed partial class ConnManagerPNames_ : java.lang.Object, ConnManagerPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ConnManagerPNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ConnManagerPNames_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnManagerPNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnManagerPNames"));
		}
		internal static void InitJNI()
		{
		}
	}
}
