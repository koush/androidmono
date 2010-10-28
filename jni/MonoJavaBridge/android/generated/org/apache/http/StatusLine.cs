namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.StatusLine_))]
	public partial interface StatusLine  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.ProtocolVersion getProtocolVersion();
		int getStatusCode();
		global::java.lang.String getReasonPhrase();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.StatusLine))]
	internal sealed partial class StatusLine_ : java.lang.Object, StatusLine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StatusLine_()
		{
			InitJNI();
		}
		internal StatusLine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31763;
		global::org.apache.http.ProtocolVersion org.apache.http.StatusLine.getProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.StatusLine_._getProtocolVersion31763)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.StatusLine_.staticClass, global::org.apache.http.StatusLine_._getProtocolVersion31763)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getStatusCode31764;
		int org.apache.http.StatusLine.getStatusCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.StatusLine_._getStatusCode31764);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.StatusLine_.staticClass, global::org.apache.http.StatusLine_._getStatusCode31764);
		}
		internal static global::MonoJavaBridge.MethodId _getReasonPhrase31765;
		global::java.lang.String org.apache.http.StatusLine.getReasonPhrase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.StatusLine_._getReasonPhrase31765)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.StatusLine_.staticClass, global::org.apache.http.StatusLine_._getReasonPhrase31765)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.StatusLine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/StatusLine"));
			global::org.apache.http.StatusLine_._getProtocolVersion31763 = @__env.GetMethodIDNoThrow(global::org.apache.http.StatusLine_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.StatusLine_._getStatusCode31764 = @__env.GetMethodIDNoThrow(global::org.apache.http.StatusLine_.staticClass, "getStatusCode", "()I");
			global::org.apache.http.StatusLine_._getReasonPhrase31765 = @__env.GetMethodIDNoThrow(global::org.apache.http.StatusLine_.staticClass, "getReasonPhrase", "()Ljava/lang/String;");
		}
	}
}
