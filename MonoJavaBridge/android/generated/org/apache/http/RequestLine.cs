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
		internal static global::MonoJavaBridge.MethodId _getMethod31760;
		global::java.lang.String org.apache.http.RequestLine.getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.RequestLine_.staticClass, "getMethod", "()Ljava/lang/String;", ref global::org.apache.http.RequestLine_._getMethod31760) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31761;
		global::org.apache.http.ProtocolVersion org.apache.http.RequestLine.getProtocolVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.RequestLine_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.RequestLine_._getProtocolVersion31761) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getUri31762;
		global::java.lang.String org.apache.http.RequestLine.getUri()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.RequestLine_.staticClass, "getUri", "()Ljava/lang/String;", ref global::org.apache.http.RequestLine_._getUri31762) as java.lang.String;
		}
		static RequestLine_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.RequestLine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/RequestLine"));
		}
		internal static void InitJNI()
		{
		}
	}
}
