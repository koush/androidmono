namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.NameValuePair_))]
	public partial interface NameValuePair  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.NameValuePair))]
	internal sealed partial class NameValuePair_ : java.lang.Object, NameValuePair
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NameValuePair_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.apache.http.NameValuePair.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.NameValuePair_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.NameValuePair_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.apache.http.NameValuePair.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.NameValuePair_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.NameValuePair_._m1) as java.lang.String;
		}
		static NameValuePair_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.NameValuePair_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/NameValuePair"));
		}
		internal static void InitJNI()
		{
		}
	}
}
