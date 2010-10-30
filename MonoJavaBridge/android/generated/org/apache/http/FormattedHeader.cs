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
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.util.CharArrayBuffer org.apache.http.FormattedHeader.getBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.FormattedHeader_.staticClass, "getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.FormattedHeader_._m0) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int org.apache.http.FormattedHeader.getValuePos()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.FormattedHeader_.staticClass, "getValuePos", "()I", ref global::org.apache.http.FormattedHeader_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.apache.http.Header.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.FormattedHeader_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.FormattedHeader_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String org.apache.http.Header.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.FormattedHeader_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.FormattedHeader_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::org.apache.http.HeaderElement[] org.apache.http.Header.getElements()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.FormattedHeader_.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;", ref global::org.apache.http.FormattedHeader_._m4) as org.apache.http.HeaderElement[];
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
