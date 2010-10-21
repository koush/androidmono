namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestDefaultHeaders : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RequestDefaultHeaders()
		{
			InitJNI();
		}
		protected RequestDefaultHeaders(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process31921;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.RequestDefaultHeaders._process31921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.RequestDefaultHeaders.staticClass, global::org.apache.http.client.protocol.RequestDefaultHeaders._process31921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestDefaultHeaders31922;
		public RequestDefaultHeaders()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.RequestDefaultHeaders.staticClass, global::org.apache.http.client.protocol.RequestDefaultHeaders._RequestDefaultHeaders31922);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.RequestDefaultHeaders.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/RequestDefaultHeaders"));
			global::org.apache.http.client.protocol.RequestDefaultHeaders._process31921 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.RequestDefaultHeaders.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.client.protocol.RequestDefaultHeaders._RequestDefaultHeaders31922 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.RequestDefaultHeaders.staticClass, "<init>", "()V");
		}
	}
}
