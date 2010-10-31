namespace org.apache.http.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.io.HttpMessageParser_))]
	public partial interface HttpMessageParser  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.HttpMessage parse();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.io.HttpMessageParser))]
	internal sealed partial class HttpMessageParser_ : java.lang.Object, HttpMessageParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpMessageParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.HttpMessage org.apache.http.io.HttpMessageParser.parse()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpMessage>(this, global::org.apache.http.io.HttpMessageParser_.staticClass, "parse", "()Lorg/apache/http/HttpMessage;", ref global::org.apache.http.io.HttpMessageParser_._m0) as org.apache.http.HttpMessage;
		}
		static HttpMessageParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.HttpMessageParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/HttpMessageParser"));
		}
	}
}
