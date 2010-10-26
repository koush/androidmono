namespace org.apache.http.auth.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthParamBean()
		{
			InitJNI();
		}
		protected AuthParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCredentialCharset31859;
		public virtual void setCredentialCharset(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.@params.AuthParamBean._setCredentialCharset31859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.@params.AuthParamBean.staticClass, global::org.apache.http.auth.@params.AuthParamBean._setCredentialCharset31859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AuthParamBean31860;
		public AuthParamBean(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.@params.AuthParamBean.staticClass, global::org.apache.http.auth.@params.AuthParamBean._AuthParamBean31860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.@params.AuthParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/params/AuthParamBean"));
			global::org.apache.http.auth.@params.AuthParamBean._setCredentialCharset31859 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.@params.AuthParamBean.staticClass, "setCredentialCharset", "(Ljava/lang/String;)V");
			global::org.apache.http.auth.@params.AuthParamBean._AuthParamBean31860 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.@params.AuthParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
		}
	}
}
