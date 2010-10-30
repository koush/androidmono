namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpResponseWriter : org.apache.http.impl.io.AbstractMessageWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpResponseWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeHeadLine33446;
		protected override void writeHeadLine(org.apache.http.HttpMessage arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.HttpResponseWriter.staticClass, global::org.apache.http.impl.io.HttpResponseWriter._writeHeadLine33446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpResponseWriter33447;
		public HttpResponseWriter(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.message.LineFormatter arg1, org.apache.http.@params.HttpParams arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.HttpResponseWriter.staticClass, global::org.apache.http.impl.io.HttpResponseWriter._HttpResponseWriter33447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static HttpResponseWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.HttpResponseWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/HttpResponseWriter"));
			global::org.apache.http.impl.io.HttpResponseWriter._writeHeadLine33446 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpResponseWriter.staticClass, "writeHeadLine", "(Lorg/apache/http/HttpMessage;)V");
			global::org.apache.http.impl.io.HttpResponseWriter._HttpResponseWriter33447 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpResponseWriter.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/message/LineFormatter;Lorg/apache/http/params/HttpParams;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
