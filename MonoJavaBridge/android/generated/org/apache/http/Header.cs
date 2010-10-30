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
		internal static global::MonoJavaBridge.MethodId _getName31497;
		global::java.lang.String org.apache.http.Header.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.Header_._getName31497)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue31498;
		global::java.lang.String org.apache.http.Header.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.Header_._getValue31498)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getElements31499;
		global::org.apache.http.HeaderElement[] org.apache.http.Header.getElements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.Header_._getElements31499)) as org.apache.http.HeaderElement[];
		}
		static Header_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.Header_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/Header"));
			global::org.apache.http.Header_._getName31497 = @__env.GetMethodIDNoThrow(global::org.apache.http.Header_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.Header_._getValue31498 = @__env.GetMethodIDNoThrow(global::org.apache.http.Header_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.Header_._getElements31499 = @__env.GetMethodIDNoThrow(global::org.apache.http.Header_.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;");
		}
		internal static void InitJNI()
		{
		}
	}
}
