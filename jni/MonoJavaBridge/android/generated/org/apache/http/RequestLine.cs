namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.RequestLine_))]
	public interface RequestLine  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getMethod();
		global::org.apache.http.ProtocolVersion getProtocolVersion();
		global::java.lang.String getUri();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.RequestLine))]
	public sealed partial class RequestLine_ : java.lang.Object, RequestLine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RequestLine_()
		{
			InitJNI();
		}
		internal RequestLine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31641;
		 global::java.lang.String org.apache.http.RequestLine.getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.RequestLine_._getMethod31641)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.RequestLine_.staticClass, global::org.apache.http.RequestLine_._getMethod31641)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31642;
		 global::org.apache.http.ProtocolVersion org.apache.http.RequestLine.getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.RequestLine_._getProtocolVersion31642)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.RequestLine_.staticClass, global::org.apache.http.RequestLine_._getProtocolVersion31642)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getUri31643;
		 global::java.lang.String org.apache.http.RequestLine.getUri() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.RequestLine_._getUri31643)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.RequestLine_.staticClass, global::org.apache.http.RequestLine_._getUri31643)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.RequestLine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/RequestLine"));
			global::org.apache.http.RequestLine_._getMethod31641 = @__env.GetMethodIDNoThrow(global::org.apache.http.RequestLine_.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.RequestLine_._getProtocolVersion31642 = @__env.GetMethodIDNoThrow(global::org.apache.http.RequestLine_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.RequestLine_._getUri31643 = @__env.GetMethodIDNoThrow(global::org.apache.http.RequestLine_.staticClass, "getUri", "()Ljava/lang/String;");
		}
	}
}
