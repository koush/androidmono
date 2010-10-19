namespace org.apache.http.auth.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.auth.@params.AuthPNames_))]
	public interface AuthPNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.auth.@params.AuthPNames))]
	public sealed partial class AuthPNames_ : java.lang.Object, AuthPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthPNames_()
		{
			InitJNI();
		}
		internal AuthPNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.@params.AuthPNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/@params/AuthPNames"));
		}
	}
}
