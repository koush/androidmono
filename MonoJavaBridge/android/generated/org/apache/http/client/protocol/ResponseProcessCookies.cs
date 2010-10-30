namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResponseProcessCookies : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResponseProcessCookies(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process32046;
		public virtual void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.protocol.ResponseProcessCookies._process32046.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.protocol.ResponseProcessCookies._process32046 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass, global::org.apache.http.client.protocol.ResponseProcessCookies._process32046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ResponseProcessCookies32047;
		public ResponseProcessCookies() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.protocol.ResponseProcessCookies._ResponseProcessCookies32047.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.protocol.ResponseProcessCookies._ResponseProcessCookies32047 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.ResponseProcessCookies.staticClass, global::org.apache.http.client.protocol.ResponseProcessCookies._ResponseProcessCookies32047);
			Init(@__env, handle);
		}
		static ResponseProcessCookies()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/ResponseProcessCookies"));
		}
		internal static void InitJNI()
		{
		}
	}
}
