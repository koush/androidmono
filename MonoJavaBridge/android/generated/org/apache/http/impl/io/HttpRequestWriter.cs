namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRequestWriter : org.apache.http.impl.io.AbstractMessageWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpRequestWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeHeadLine33442;
		protected override void writeHeadLine(org.apache.http.HttpMessage arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpRequestWriter._writeHeadLine33442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.HttpRequestWriter.staticClass, global::org.apache.http.impl.io.HttpRequestWriter._writeHeadLine33442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpRequestWriter33443;
		public HttpRequestWriter(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.message.LineFormatter arg1, org.apache.http.@params.HttpParams arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.HttpRequestWriter.staticClass, global::org.apache.http.impl.io.HttpRequestWriter._HttpRequestWriter33443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static HttpRequestWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.HttpRequestWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/HttpRequestWriter"));
			global::org.apache.http.impl.io.HttpRequestWriter._writeHeadLine33442 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpRequestWriter.staticClass, "writeHeadLine", "(Lorg/apache/http/HttpMessage;)V");
			global::org.apache.http.impl.io.HttpRequestWriter._HttpRequestWriter33443 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.HttpRequestWriter.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/message/LineFormatter;Lorg/apache/http/params/HttpParams;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
