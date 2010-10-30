namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultResponseParser : org.apache.http.impl.io.AbstractMessageParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultResponseParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseHead33046;
		protected override global::org.apache.http.HttpMessage parseHead(org.apache.http.io.SessionInputBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpMessage>(this, global::org.apache.http.impl.conn.DefaultResponseParser.staticClass, "parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", ref global::org.apache.http.impl.conn.DefaultResponseParser._parseHead33046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpMessage;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultResponseParser33047;
		public DefaultResponseParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.message.LineParser arg1, org.apache.http.HttpResponseFactory arg2, org.apache.http.@params.HttpParams arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.DefaultResponseParser._DefaultResponseParser33047.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.DefaultResponseParser._DefaultResponseParser33047 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultResponseParser.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/apache/http/HttpResponseFactory;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.DefaultResponseParser.staticClass, global::org.apache.http.impl.conn.DefaultResponseParser._DefaultResponseParser33047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static DefaultResponseParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.DefaultResponseParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/DefaultResponseParser"));
		}
		internal static void InitJNI()
		{
		}
	}
}
