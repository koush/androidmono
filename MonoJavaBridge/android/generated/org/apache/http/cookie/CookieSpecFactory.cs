namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.CookieSpecFactory_))]
	public partial interface CookieSpecFactory  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.cookie.CookieSpec newInstance(org.apache.http.@params.HttpParams arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.CookieSpecFactory))]
	internal sealed partial class CookieSpecFactory_ : java.lang.Object, CookieSpecFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieSpecFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::org.apache.http.cookie.CookieSpec org.apache.http.cookie.CookieSpecFactory.newInstance(org.apache.http.@params.HttpParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.cookie.CookieSpec>(this, global::org.apache.http.cookie.CookieSpecFactory_.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", ref global::org.apache.http.cookie.CookieSpecFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.cookie.CookieSpec;
		}
		static CookieSpecFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieSpecFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieSpecFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
