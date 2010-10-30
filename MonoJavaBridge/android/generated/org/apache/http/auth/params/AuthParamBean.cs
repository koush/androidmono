namespace org.apache.http.auth.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String CredentialCharset
		{
			set
			{
				setCredentialCharset(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setCredentialCharset(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.auth.@params.AuthParamBean.staticClass, "setCredentialCharset", "(Ljava/lang/String;)V", ref global::org.apache.http.auth.@params.AuthParamBean._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AuthParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.@params.AuthParamBean._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.@params.AuthParamBean._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.@params.AuthParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.@params.AuthParamBean.staticClass, global::org.apache.http.auth.@params.AuthParamBean._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AuthParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.@params.AuthParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/params/AuthParamBean"));
		}
		internal static void InitJNI()
		{
		}
	}
}
