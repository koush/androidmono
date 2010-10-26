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
		static NameValuePair_()
		{
			InitJNI();
		}
		internal NameValuePair_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName31737;
		 global::java.lang.String org.apache.http.NameValuePair.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.NameValuePair_._getName31737)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.NameValuePair_.staticClass, global::org.apache.http.NameValuePair_._getName31737)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue31738;
		 global::java.lang.String org.apache.http.NameValuePair.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.NameValuePair_._getValue31738)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.NameValuePair_.staticClass, global::org.apache.http.NameValuePair_._getValue31738)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.NameValuePair_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/NameValuePair"));
			global::org.apache.http.NameValuePair_._getName31737 = @__env.GetMethodIDNoThrow(global::org.apache.http.NameValuePair_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.NameValuePair_._getValue31738 = @__env.GetMethodIDNoThrow(global::org.apache.http.NameValuePair_.staticClass, "getValue", "()Ljava/lang/String;");
		}
	}
}
