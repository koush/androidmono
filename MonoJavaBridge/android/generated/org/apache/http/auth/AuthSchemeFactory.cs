namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.auth.AuthSchemeFactory_))]
	public partial interface AuthSchemeFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.auth.AuthScheme newInstance(org.apache.http.@params.HttpParams arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.auth.AuthSchemeFactory))]
	internal sealed partial class AuthSchemeFactory_ : java.lang.Object, AuthSchemeFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AuthSchemeFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.auth.AuthScheme org.apache.http.auth.AuthSchemeFactory.newInstance(org.apache.http.@params.HttpParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.AuthScheme>(this, global::org.apache.http.auth.AuthSchemeFactory_.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;", ref global::org.apache.http.auth.AuthSchemeFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.auth.AuthScheme;
		}
		static AuthSchemeFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthSchemeFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthSchemeFactory"));
		}
	}
}
