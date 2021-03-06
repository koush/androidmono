namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.StatusLine_))]
	public interface StatusLine  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.ProtocolVersion getProtocolVersion();
		int getStatusCode();
		global::java.lang.String getReasonPhrase();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.StatusLine))]
	public sealed partial class StatusLine_ : java.lang.Object, StatusLine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StatusLine_()
		{
			InitJNI();
		}
		internal StatusLine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion16280;
		 global::org.apache.http.ProtocolVersion org.apache.http.StatusLine.getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.StatusLine_._getProtocolVersion16280)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.StatusLine_.staticClass, global::org.apache.http.StatusLine_._getProtocolVersion16280)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getStatusCode16281;
		 int org.apache.http.StatusLine.getStatusCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.StatusLine_._getStatusCode16281);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.StatusLine_.staticClass, global::org.apache.http.StatusLine_._getStatusCode16281);
		}
		internal static global::MonoJavaBridge.MethodId _getReasonPhrase16282;
		 global::java.lang.String org.apache.http.StatusLine.getReasonPhrase() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.StatusLine_._getReasonPhrase16282)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.StatusLine_.staticClass, global::org.apache.http.StatusLine_._getReasonPhrase16282)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.StatusLine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/StatusLine"));
			global::org.apache.http.StatusLine_._getProtocolVersion16280 = @__env.GetMethodIDNoThrow(global::org.apache.http.StatusLine_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.StatusLine_._getStatusCode16281 = @__env.GetMethodIDNoThrow(global::org.apache.http.StatusLine_.staticClass, "getStatusCode", "()I");
			global::org.apache.http.StatusLine_._getReasonPhrase16282 = @__env.GetMethodIDNoThrow(global::org.apache.http.StatusLine_.staticClass, "getReasonPhrase", "()Ljava/lang/String;");
		}
	}
}
