namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpContext_))]
	public partial interface HttpContext  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getAttribute(java.lang.String arg0);
		global::java.lang.Object removeAttribute(java.lang.String arg0);
		void setAttribute(java.lang.String arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpContext))]
	internal sealed partial class HttpContext_ : java.lang.Object, HttpContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object org.apache.http.protocol.HttpContext.getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.HttpContext_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.protocol.HttpContext_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object org.apache.http.protocol.HttpContext.removeAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.HttpContext_.staticClass, "removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.protocol.HttpContext_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.protocol.HttpContext.setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpContext_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.apache.http.protocol.HttpContext_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static HttpContext_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpContext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
