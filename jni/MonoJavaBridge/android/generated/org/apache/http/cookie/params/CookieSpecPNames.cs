namespace org.apache.http.cookie.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.@params.CookieSpecPNames_))]
	public partial interface CookieSpecPNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.@params.CookieSpecPNames))]
	internal sealed partial class CookieSpecPNames_ : java.lang.Object, CookieSpecPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieSpecPNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static CookieSpecPNames_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.@params.CookieSpecPNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/params/CookieSpecPNames"));
		}
		internal static void InitJNI()
		{
		}
	}
}
