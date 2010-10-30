namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.FormattedHeader_))]
	public partial interface FormattedHeader : Header
	{
		global::org.apache.http.util.CharArrayBuffer getBuffer();
		int getValuePos();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.FormattedHeader))]
	internal sealed partial class FormattedHeader_ : java.lang.Object, FormattedHeader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FormattedHeader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBuffer31492;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.FormattedHeader.getBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.FormattedHeader_.staticClass, "getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.FormattedHeader_._getBuffer31492) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getValuePos31493;
		int org.apache.http.FormattedHeader.getValuePos()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.FormattedHeader_.staticClass, "getValuePos", "()I", ref global::org.apache.http.FormattedHeader_._getValuePos31493);
		}
		internal static global::MonoJavaBridge.MethodId _getName31494;
		global::java.lang.String org.apache.http.Header.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.FormattedHeader_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.FormattedHeader_._getName31494) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue31495;
		global::java.lang.String org.apache.http.Header.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.FormattedHeader_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.FormattedHeader_._getValue31495) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getElements31496;
		global::org.apache.http.HeaderElement[] org.apache.http.Header.getElements()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.FormattedHeader_.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;", ref global::org.apache.http.FormattedHeader_._getElements31496) as org.apache.http.HeaderElement[];
		}
		static FormattedHeader_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.FormattedHeader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/FormattedHeader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
