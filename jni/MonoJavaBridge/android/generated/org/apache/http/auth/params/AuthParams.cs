namespace org.apache.http.auth.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AuthParams : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthParams()
		{
			InitJNI();
		}
		internal AuthParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCredentialCharset31862;
		public static void setCredentialCharset(org.apache.http.@params.HttpParams arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.auth.@params.AuthParams.staticClass, global::org.apache.http.auth.@params.AuthParams._setCredentialCharset31862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCredentialCharset31863;
		public static global::java.lang.String getCredentialCharset(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.auth.@params.AuthParams.staticClass, global::org.apache.http.auth.@params.AuthParams._getCredentialCharset31863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.@params.AuthParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/params/AuthParams"));
			global::org.apache.http.auth.@params.AuthParams._setCredentialCharset31862 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.auth.@params.AuthParams.staticClass, "setCredentialCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V");
			global::org.apache.http.auth.@params.AuthParams._getCredentialCharset31863 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.auth.@params.AuthParams.staticClass, "getCredentialCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;");
		}
	}
}
