namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestUserAgent : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RequestUserAgent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33946;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.RequestUserAgent._process33946.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.RequestUserAgent._process33946 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestUserAgent.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.RequestUserAgent.staticClass, global::org.apache.http.protocol.RequestUserAgent._process33946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestUserAgent33947;
		public RequestUserAgent() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.RequestUserAgent._RequestUserAgent33947.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.RequestUserAgent._RequestUserAgent33947 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestUserAgent.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.RequestUserAgent.staticClass, global::org.apache.http.protocol.RequestUserAgent._RequestUserAgent33947);
			Init(@__env, handle);
		}
		static RequestUserAgent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.RequestUserAgent.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/RequestUserAgent"));
		}
		internal static void InitJNI()
		{
		}
	}
}
