namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.message.LineParser_))]
	public partial interface LineParser  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.Header parseHeader(org.apache.http.util.CharArrayBuffer arg0);
		global::org.apache.http.ProtocolVersion parseProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
		bool hasProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
		global::org.apache.http.RequestLine parseRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
		global::org.apache.http.StatusLine parseStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.message.LineParser))]
	internal sealed partial class LineParser_ : java.lang.Object, LineParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LineParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.Header org.apache.http.message.LineParser.parseHeader(org.apache.http.util.CharArrayBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.LineParser_.staticClass, "parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/Header;", ref global::org.apache.http.message.LineParser_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.apache.http.ProtocolVersion org.apache.http.message.LineParser.parseProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.LineParser_.staticClass, "parseProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.message.LineParser_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool org.apache.http.message.LineParser.hasProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.LineParser_.staticClass, "hasProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Z", ref global::org.apache.http.message.LineParser_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::org.apache.http.RequestLine org.apache.http.message.LineParser.parseRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.message.LineParser_.staticClass, "parseRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/RequestLine;", ref global::org.apache.http.message.LineParser_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.RequestLine;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.apache.http.StatusLine org.apache.http.message.LineParser.parseStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.StatusLine>(this, global::org.apache.http.message.LineParser_.staticClass, "parseStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/StatusLine;", ref global::org.apache.http.message.LineParser_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.StatusLine;
		}
		static LineParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.LineParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/LineParser"));
		}
		internal static void InitJNI()
		{
		}
	}
}
