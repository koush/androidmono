namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestTargetHost : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RequestTargetHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33944;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.RequestTargetHost._process33944.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.RequestTargetHost._process33944 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestTargetHost.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.RequestTargetHost.staticClass, global::org.apache.http.protocol.RequestTargetHost._process33944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestTargetHost33945;
		public RequestTargetHost() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.RequestTargetHost._RequestTargetHost33945.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.RequestTargetHost._RequestTargetHost33945 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestTargetHost.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.RequestTargetHost.staticClass, global::org.apache.http.protocol.RequestTargetHost._RequestTargetHost33945);
			Init(@__env, handle);
		}
		static RequestTargetHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.RequestTargetHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/RequestTargetHost"));
		}
		internal static void InitJNI()
		{
		}
	}
}
