namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpExpectationVerifier_))]
	public partial interface HttpExpectationVerifier  : global::MonoJavaBridge.IJavaObject 
	{
		void verify(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpExpectationVerifier))]
	internal sealed partial class HttpExpectationVerifier_ : java.lang.Object, HttpExpectationVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpExpectationVerifier_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void org.apache.http.protocol.HttpExpectationVerifier.verify(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpExpectationVerifier_.staticClass, "verify", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.HttpExpectationVerifier_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static HttpExpectationVerifier_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpExpectationVerifier_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpExpectationVerifier"));
		}
	}
}
