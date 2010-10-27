namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.message.HeaderValueParser_))]
	public partial interface HeaderValueParser  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.HeaderElement[] parseElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
		global::org.apache.http.HeaderElement parseHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
		global::org.apache.http.NameValuePair[] parseParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
		global::org.apache.http.NameValuePair parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.message.HeaderValueParser))]
	internal sealed partial class HeaderValueParser_ : java.lang.Object, HeaderValueParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HeaderValueParser_()
		{
			InitJNI();
		}
		internal HeaderValueParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseElements33693;
		global::org.apache.http.HeaderElement[] org.apache.http.message.HeaderValueParser.parseElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueParser_._parseElements33693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueParser_.staticClass, global::org.apache.http.message.HeaderValueParser_._parseElements33693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
		}
		internal static global::MonoJavaBridge.MethodId _parseHeaderElement33694;
		global::org.apache.http.HeaderElement org.apache.http.message.HeaderValueParser.parseHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueParser_._parseHeaderElement33694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueParser_.staticClass, global::org.apache.http.message.HeaderValueParser_._parseHeaderElement33694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _parseParameters33695;
		global::org.apache.http.NameValuePair[] org.apache.http.message.HeaderValueParser.parseParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueParser_._parseParameters33695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueParser_.staticClass, global::org.apache.http.message.HeaderValueParser_._parseParameters33695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair33696;
		global::org.apache.http.NameValuePair org.apache.http.message.HeaderValueParser.parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueParser_._parseNameValuePair33696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueParser_.staticClass, global::org.apache.http.message.HeaderValueParser_._parseNameValuePair33696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.HeaderValueParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/HeaderValueParser"));
			global::org.apache.http.message.HeaderValueParser_._parseElements33693 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderValueParser_.staticClass, "parseElements", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.HeaderValueParser_._parseHeaderElement33694 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderValueParser_.staticClass, "parseHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.HeaderValueParser_._parseParameters33695 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderValueParser_.staticClass, "parseParameters", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.HeaderValueParser_._parseNameValuePair33696 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderValueParser_.staticClass, "parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/NameValuePair;");
		}
	}
}
