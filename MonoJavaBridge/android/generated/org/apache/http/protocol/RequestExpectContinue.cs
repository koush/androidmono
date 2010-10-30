namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestExpectContinue : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RequestExpectContinue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33942;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.RequestExpectContinue._process33942.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.RequestExpectContinue._process33942 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestExpectContinue.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.RequestExpectContinue.staticClass, global::org.apache.http.protocol.RequestExpectContinue._process33942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestExpectContinue33943;
		public RequestExpectContinue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.RequestExpectContinue._RequestExpectContinue33943.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.RequestExpectContinue._RequestExpectContinue33943 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestExpectContinue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.RequestExpectContinue.staticClass, global::org.apache.http.protocol.RequestExpectContinue._RequestExpectContinue33943);
			Init(@__env, handle);
		}
		static RequestExpectContinue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.RequestExpectContinue.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/RequestExpectContinue"));
		}
		internal static void InitJNI()
		{
		}
	}
}
