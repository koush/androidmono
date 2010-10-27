namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestTargetAuthentication : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RequestTargetAuthentication()
		{
			InitJNI();
		}
		protected RequestTargetAuthentication(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process32043;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.RequestTargetAuthentication._process32043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.RequestTargetAuthentication.staticClass, global::org.apache.http.client.protocol.RequestTargetAuthentication._process32043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestTargetAuthentication32044;
		public RequestTargetAuthentication() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.RequestTargetAuthentication.staticClass, global::org.apache.http.client.protocol.RequestTargetAuthentication._RequestTargetAuthentication32044);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.RequestTargetAuthentication.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/RequestTargetAuthentication"));
			global::org.apache.http.client.protocol.RequestTargetAuthentication._process32043 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.RequestTargetAuthentication.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.client.protocol.RequestTargetAuthentication._RequestTargetAuthentication32044 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.RequestTargetAuthentication.staticClass, "<init>", "()V");
		}
	}
}
