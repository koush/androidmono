namespace org.apache.http.client.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.@params.ClientPNames_))]
	public interface ClientPNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.@params.ClientPNames))]
	public sealed partial class ClientPNames_ : java.lang.Object, ClientPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientPNames_()
		{
			InitJNI();
		}
		internal ClientPNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.ClientPNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/@params/ClientPNames"));
		}
	}
}
