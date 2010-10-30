namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.auth.Credentials_))]
	public partial interface Credentials  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getPassword();
		global::java.security.Principal getUserPrincipal();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.auth.Credentials))]
	internal sealed partial class Credentials_ : java.lang.Object, Credentials
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Credentials_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPassword31826;
		global::java.lang.String org.apache.http.auth.Credentials.getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.Credentials_.staticClass, "getPassword", "()Ljava/lang/String;", ref global::org.apache.http.auth.Credentials_._getPassword31826) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getUserPrincipal31827;
		global::java.security.Principal org.apache.http.auth.Credentials.getUserPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::org.apache.http.auth.Credentials_.staticClass, "getUserPrincipal", "()Ljava/security/Principal;", ref global::org.apache.http.auth.Credentials_._getUserPrincipal31827) as java.security.Principal;
		}
		static Credentials_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.Credentials_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/Credentials"));
		}
		internal static void InitJNI()
		{
		}
	}
}
