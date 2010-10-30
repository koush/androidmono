namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.Header_))]
	public partial interface Header  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
		global::org.apache.http.HeaderElement[] getElements();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.Header))]
	internal sealed partial class Header_ : java.lang.Object, Header
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Header_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.apache.http.Header.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.Header_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.Header_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.apache.http.Header.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.Header_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.Header_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::org.apache.http.HeaderElement[] org.apache.http.Header.getElements()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.Header_.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;", ref global::org.apache.http.Header_._m2) as org.apache.http.HeaderElement[];
		}
		static Header_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.Header_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/Header"));
		}
		internal static void InitJNI()
		{
		}
	}
}
