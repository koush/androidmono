namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.message.HeaderValueFormatter_))]
	public partial interface HeaderValueFormatter  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.util.CharArrayBuffer formatElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement[] arg1, bool arg2);
		global::org.apache.http.util.CharArrayBuffer formatHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement arg1, bool arg2);
		global::org.apache.http.util.CharArrayBuffer formatParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair[] arg1, bool arg2);
		global::org.apache.http.util.CharArrayBuffer formatNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair arg1, bool arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.message.HeaderValueFormatter))]
	internal sealed partial class HeaderValueFormatter_ : java.lang.Object, HeaderValueFormatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HeaderValueFormatter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.HeaderValueFormatter.formatElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement[] arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.HeaderValueFormatter_.staticClass, "formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.HeaderValueFormatter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.HeaderValueFormatter.formatHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.HeaderValueFormatter_.staticClass, "formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.HeaderValueFormatter_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.HeaderValueFormatter.formatParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair[] arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.HeaderValueFormatter_.staticClass, "formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.HeaderValueFormatter_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.HeaderValueFormatter.formatNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.HeaderValueFormatter_.staticClass, "formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.HeaderValueFormatter_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.util.CharArrayBuffer;
		}
		static HeaderValueFormatter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.HeaderValueFormatter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/HeaderValueFormatter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
