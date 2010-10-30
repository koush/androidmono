namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HeaderElement_))]
	public partial interface HeaderElement  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
		global::org.apache.http.NameValuePair[] getParameters();
		global::org.apache.http.NameValuePair getParameter(int arg0);
		int getParameterCount();
		global::org.apache.http.NameValuePair getParameterByName(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HeaderElement))]
	internal sealed partial class HeaderElement_ : java.lang.Object, HeaderElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HeaderElement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.apache.http.HeaderElement.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.HeaderElement_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.HeaderElement_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.apache.http.HeaderElement.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.HeaderElement_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.HeaderElement_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.apache.http.NameValuePair[] org.apache.http.HeaderElement.getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.HeaderElement_.staticClass, "getParameters", "()[Lorg/apache/http/NameValuePair;", ref global::org.apache.http.HeaderElement_._m2) as org.apache.http.NameValuePair[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::org.apache.http.NameValuePair org.apache.http.HeaderElement.getParameter(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.HeaderElement_.staticClass, "getParameter", "(I)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.HeaderElement_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.NameValuePair;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int org.apache.http.HeaderElement.getParameterCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HeaderElement_.staticClass, "getParameterCount", "()I", ref global::org.apache.http.HeaderElement_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::org.apache.http.NameValuePair org.apache.http.HeaderElement.getParameterByName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.HeaderElement_.staticClass, "getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.HeaderElement_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.NameValuePair;
		}
		static HeaderElement_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HeaderElement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HeaderElement"));
		}
		internal static void InitJNI()
		{
		}
	}
}
