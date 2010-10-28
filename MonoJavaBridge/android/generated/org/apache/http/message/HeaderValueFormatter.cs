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
		internal static global::MonoJavaBridge.MethodId _formatElements33690;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.HeaderValueFormatter.formatElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement[] arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueFormatter_._formatElements33690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueFormatter_.staticClass, global::org.apache.http.message.HeaderValueFormatter_._formatElements33690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatHeaderElement33691;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.HeaderValueFormatter.formatHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueFormatter_._formatHeaderElement33691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueFormatter_.staticClass, global::org.apache.http.message.HeaderValueFormatter_._formatHeaderElement33691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatParameters33692;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.HeaderValueFormatter.formatParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair[] arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueFormatter_._formatParameters33692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueFormatter_.staticClass, global::org.apache.http.message.HeaderValueFormatter_._formatParameters33692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatNameValuePair33693;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.message.HeaderValueFormatter.formatNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueFormatter_._formatNameValuePair33693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.HeaderValueFormatter_.staticClass, global::org.apache.http.message.HeaderValueFormatter_._formatNameValuePair33693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		static HeaderValueFormatter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.HeaderValueFormatter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/HeaderValueFormatter"));
			global::org.apache.http.message.HeaderValueFormatter_._formatElements33690 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderValueFormatter_.staticClass, "formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.HeaderValueFormatter_._formatHeaderElement33691 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderValueFormatter_.staticClass, "formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.HeaderValueFormatter_._formatParameters33692 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderValueFormatter_.staticClass, "formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.HeaderValueFormatter_._formatNameValuePair33693 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.HeaderValueFormatter_.staticClass, "formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;");
		}
		internal static void InitJNI()
		{
		}
	}
}