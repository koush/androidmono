namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.protocol.ClientContext_))]
	public partial interface ClientContext  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.protocol.ClientContext))]
	public sealed partial class ClientContext_ : java.lang.Object, ClientContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientContext_()
		{
			InitJNI();
		}
		internal ClientContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.ClientContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/ClientContext"));
		}
	}
}
