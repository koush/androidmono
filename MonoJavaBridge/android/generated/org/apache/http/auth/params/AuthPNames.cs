namespace org.apache.http.auth.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.auth.@params.AuthPNames_))]
	public partial interface AuthPNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.auth.@params.AuthPNames))]
	internal sealed partial class AuthPNames_ : java.lang.Object, AuthPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AuthPNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AuthPNames_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.@params.AuthPNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/params/AuthPNames"));
		}
		internal static void InitJNI()
		{
		}
	}
}
