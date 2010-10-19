namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRequestParser : org.apache.http.impl.io.AbstractMessageParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRequestParser()
		{
			InitJNI();
		}
		protected HttpRequestParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseHead26694;
		protected override global::org.apache.http.HttpMessage parseHead(org.apache.http.io.SessionInputBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpRequestParser._parseHead26694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpMessage;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpRequestParser.staticClass, global::org.apache.http.impl.io.HttpRequestParser._parseHead26694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpMessage;
		}
		internal static global::MonoJavaBridge.MethodId _HttpRequestParser26695;
		public HttpRequestParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.message.LineParser arg1, org.apache.http.HttpRequestFactory arg2, org.apache.http.@params.HttpParams arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.HttpRequestParser.staticClass, global::org.apache.http.impl.io.HttpRequestParser._HttpRequestParser26695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.HttpRequestParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/HttpRequestParser"));
			global::org.apache.http.impl.io.HttpRequestParser._parseHead26694 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpRequestParser.staticClass, "parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;");
			global::org.apache.http.impl.io.HttpRequestParser._HttpRequestParser26695 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpRequestParser.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/apache/http/HttpRequestFactory;Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
