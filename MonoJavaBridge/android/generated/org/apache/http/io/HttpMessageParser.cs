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
		internal static global::MonoJavaBridge.MethodId _parse33467;
		global::org.apache.http.HttpMessage org.apache.http.io.HttpMessageParser.parse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.io.HttpMessageParser_._parse33467.native == global::System.IntPtr.Zero)
				global::org.apache.http.io.HttpMessageParser_._parse33467 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.HttpMessageParser_.staticClass, "parse", "()Lorg/apache/http/HttpMessage;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.io.HttpMessageParser_._parse33467)) as org.apache.http.HttpMessage;
		}
		static HttpMessageParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.HttpMessageParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/HttpMessageParser"));
		}
		internal static void InitJNI()
		{
		}
	}
}
