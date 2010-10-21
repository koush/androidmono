namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpContext_))]
	public interface HttpContext  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getAttribute(java.lang.String arg0);
		global::java.lang.Object removeAttribute(java.lang.String arg0);
		void setAttribute(java.lang.String arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpContext))]
	public sealed partial class HttpContext_ : java.lang.Object, HttpContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpContext_()
		{
			InitJNI();
		}
		internal HttpContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute33766;
		 global::java.lang.Object org.apache.http.protocol.HttpContext.getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpContext_._getAttribute33766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpContext_.staticClass, global::org.apache.http.protocol.HttpContext_._getAttribute33766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute33767;
		 global::java.lang.Object org.apache.http.protocol.HttpContext.removeAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpContext_._removeAttribute33767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpContext_.staticClass, global::org.apache.http.protocol.HttpContext_._removeAttribute33767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute33768;
		 void org.apache.http.protocol.HttpContext.setAttribute(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpContext_._setAttribute33768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpContext_.staticClass, global::org.apache.http.protocol.HttpContext_._setAttribute33768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpContext"));
			global::org.apache.http.protocol.HttpContext_._getAttribute33766 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpContext_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.HttpContext_._removeAttribute33767 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpContext_.staticClass, "removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.HttpContext_._setAttribute33768 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpContext_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
		}
	}
}
