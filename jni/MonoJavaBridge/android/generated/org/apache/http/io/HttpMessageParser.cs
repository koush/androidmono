namespace org.apache.http.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.io.HttpMessageParser_))]
	public partial interface HttpMessageParser  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.HttpMessage parse();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.io.HttpMessageParser))]
	public sealed partial class HttpMessageParser_ : java.lang.Object, HttpMessageParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpMessageParser_()
		{
			InitJNI();
		}
		internal HttpMessageParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33348;
		 global::org.apache.http.HttpMessage org.apache.http.io.HttpMessageParser.parse() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.io.HttpMessageParser_._parse33348)) as org.apache.http.HttpMessage;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.io.HttpMessageParser_.staticClass, global::org.apache.http.io.HttpMessageParser_._parse33348)) as org.apache.http.HttpMessage;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.HttpMessageParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/HttpMessageParser"));
			global::org.apache.http.io.HttpMessageParser_._parse33348 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.HttpMessageParser_.staticClass, "parse", "()Lorg/apache/http/HttpMessage;");
		}
	}
}
