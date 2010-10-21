namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpExpectationVerifier_))]
	public interface HttpExpectationVerifier  : global::MonoJavaBridge.IJavaObject 
	{
		void verify(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpExpectationVerifier))]
	public sealed partial class HttpExpectationVerifier_ : java.lang.Object, HttpExpectationVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpExpectationVerifier_()
		{
			InitJNI();
		}
		internal HttpExpectationVerifier_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _verify33774;
		 void org.apache.http.protocol.HttpExpectationVerifier.verify(org.apache.http.HttpRequest arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpExpectationVerifier_._verify33774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpExpectationVerifier_.staticClass, global::org.apache.http.protocol.HttpExpectationVerifier_._verify33774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpExpectationVerifier_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpExpectationVerifier"));
			global::org.apache.http.protocol.HttpExpectationVerifier_._verify33774 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpExpectationVerifier_.staticClass, "verify", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
		}
	}
}
