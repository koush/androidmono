namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.message.LineFormatter_))]
	public partial interface LineFormatter  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.util.CharArrayBuffer formatHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.Header arg1);
		global::org.apache.http.util.CharArrayBuffer appendProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.ProtocolVersion arg1);
		global::org.apache.http.util.CharArrayBuffer formatRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.RequestLine arg1);
		global::org.apache.http.util.CharArrayBuffer formatStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.StatusLine arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.message.LineFormatter))]
	internal sealed partial class LineFormatter_ : java.lang.Object, LineFormatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LineFormatter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _formatHeader33698;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.LineFormatter.formatHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.Header arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.LineFormatter_.staticClass, "formatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.LineFormatter_._formatHeader33698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _appendProtocolVersion33699;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.LineFormatter.appendProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.ProtocolVersion arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.LineFormatter_.staticClass, "appendProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/ProtocolVersion;)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.LineFormatter_._appendProtocolVersion33699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatRequestLine33700;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.LineFormatter.formatRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.RequestLine arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.LineFormatter_.staticClass, "formatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.LineFormatter_._formatRequestLine33700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatStatusLine33701;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.LineFormatter.formatStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.StatusLine arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.LineFormatter_.staticClass, "formatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.LineFormatter_._formatStatusLine33701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.util.CharArrayBuffer;
		}
		static LineFormatter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.LineFormatter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/LineFormatter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
