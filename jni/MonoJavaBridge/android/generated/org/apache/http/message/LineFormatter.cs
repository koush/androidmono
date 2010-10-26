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
		static LineFormatter_()
		{
			InitJNI();
		}
		internal LineFormatter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _formatHeader33697;
		 global::org.apache.http.util.CharArrayBuffer org.apache.http.message.LineFormatter.formatHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.Header arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.LineFormatter_._formatHeader33697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.LineFormatter_.staticClass, global::org.apache.http.message.LineFormatter_._formatHeader33697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _appendProtocolVersion33698;
		 global::org.apache.http.util.CharArrayBuffer org.apache.http.message.LineFormatter.appendProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.ProtocolVersion arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.LineFormatter_._appendProtocolVersion33698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.LineFormatter_.staticClass, global::org.apache.http.message.LineFormatter_._appendProtocolVersion33698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatRequestLine33699;
		 global::org.apache.http.util.CharArrayBuffer org.apache.http.message.LineFormatter.formatRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.RequestLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.LineFormatter_._formatRequestLine33699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.LineFormatter_.staticClass, global::org.apache.http.message.LineFormatter_._formatRequestLine33699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatStatusLine33700;
		 global::org.apache.http.util.CharArrayBuffer org.apache.http.message.LineFormatter.formatStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.StatusLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.LineFormatter_._formatStatusLine33700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.LineFormatter_.staticClass, global::org.apache.http.message.LineFormatter_._formatStatusLine33700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.LineFormatter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/LineFormatter"));
			global::org.apache.http.message.LineFormatter_._formatHeader33697 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.LineFormatter_.staticClass, "formatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.LineFormatter_._appendProtocolVersion33698 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.LineFormatter_.staticClass, "appendProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/ProtocolVersion;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.LineFormatter_._formatRequestLine33699 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.LineFormatter_.staticClass, "formatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.LineFormatter_._formatStatusLine33700 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.LineFormatter_.staticClass, "formatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)Lorg/apache/http/util/CharArrayBuffer;");
		}
	}
}
