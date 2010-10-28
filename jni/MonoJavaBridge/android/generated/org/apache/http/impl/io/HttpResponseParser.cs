namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpResponseParser : org.apache.http.impl.io.AbstractMessageParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpResponseParser()
		{
			InitJNI();
		}
		protected HttpResponseParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseHead33444;
		protected override global::org.apache.http.HttpMessage parseHead(org.apache.http.io.SessionInputBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpResponseParser._parseHead33444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpMessage;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpResponseParser.staticClass, global::org.apache.http.impl.io.HttpResponseParser._parseHead33444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpMessage;
		}
		internal static global::MonoJavaBridge.MethodId _HttpResponseParser33445;
		public HttpResponseParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.message.LineParser arg1, org.apache.http.HttpResponseFactory arg2, org.apache.http.@params.HttpParams arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.HttpResponseParser.staticClass, global::org.apache.http.impl.io.HttpResponseParser._HttpResponseParser33445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.HttpResponseParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/HttpResponseParser"));
			global::org.apache.http.impl.io.HttpResponseParser._parseHead33444 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpResponseParser.staticClass, "parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;");
			global::org.apache.http.impl.io.HttpResponseParser._HttpResponseParser33445 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpResponseParser.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/apache/http/HttpResponseFactory;Lorg/apache/http/params/HttpParams;)V");
		}
	}
}
