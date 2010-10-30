namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestAddCookies : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RequestAddCookies(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process32038;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.RequestAddCookies.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.client.protocol.RequestAddCookies._process32038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestAddCookies32039;
		public RequestAddCookies() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.protocol.RequestAddCookies._RequestAddCookies32039.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.protocol.RequestAddCookies._RequestAddCookies32039 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.RequestAddCookies.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.RequestAddCookies.staticClass, global::org.apache.http.client.protocol.RequestAddCookies._RequestAddCookies32039);
			Init(@__env, handle);
		}
		static RequestAddCookies()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.RequestAddCookies.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/RequestAddCookies"));
		}
		internal static void InitJNI()
		{
		}
	}
}
