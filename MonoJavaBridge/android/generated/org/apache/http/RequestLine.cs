namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.RequestLine_))]
	public partial interface RequestLine  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getMethod();
		global::org.apache.http.ProtocolVersion getProtocolVersion();
		global::java.lang.String getUri();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.RequestLine))]
	internal sealed partial class RequestLine_ : java.lang.Object, RequestLine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RequestLine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.apache.http.RequestLine.getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.RequestLine_.staticClass, "getMethod", "()Ljava/lang/String;", ref global::org.apache.http.RequestLine_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.apache.http.ProtocolVersion org.apache.http.RequestLine.getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.RequestLine_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.RequestLine_._m1) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.apache.http.RequestLine.getUri()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.RequestLine_.staticClass, "getUri", "()Ljava/lang/String;", ref global::org.apache.http.RequestLine_._m2) as java.lang.String;
		}
		static RequestLine_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.RequestLine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/RequestLine"));
		}
	}
}
