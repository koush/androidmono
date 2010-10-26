namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestAddCookies : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RequestAddCookies()
		{
			InitJNI();
		}
		protected RequestAddCookies(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process32037;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.RequestAddCookies._process32037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.RequestAddCookies.staticClass, global::org.apache.http.client.protocol.RequestAddCookies._process32037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestAddCookies32038;
		public RequestAddCookies()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.RequestAddCookies.staticClass, global::org.apache.http.client.protocol.RequestAddCookies._RequestAddCookies32038);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.RequestAddCookies.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/RequestAddCookies"));
			global::org.apache.http.client.protocol.RequestAddCookies._process32037 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.RequestAddCookies.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.client.protocol.RequestAddCookies._RequestAddCookies32038 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.RequestAddCookies.staticClass, "<init>", "()V");
		}
	}
}
