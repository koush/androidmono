namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestProxyAuthentication : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RequestProxyAuthentication(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.RequestProxyAuthentication.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.client.protocol.RequestProxyAuthentication._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public RequestProxyAuthentication() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.protocol.RequestProxyAuthentication._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.protocol.RequestProxyAuthentication._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.RequestProxyAuthentication.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.RequestProxyAuthentication.staticClass, global::org.apache.http.client.protocol.RequestProxyAuthentication._m1);
			Init(@__env, handle);
		}
		static RequestProxyAuthentication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.RequestProxyAuthentication.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/RequestProxyAuthentication"));
		}
	}
}
