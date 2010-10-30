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
		internal static global::MonoJavaBridge.MethodId _newInstance32425;
		global::org.apache.http.cookie.CookieSpec org.apache.http.cookie.CookieSpecFactory.newInstance(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpecFactory_._newInstance32425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieSpec;
		}
		static CookieSpecFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieSpecFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieSpecFactory"));
			global::org.apache.http.cookie.CookieSpecFactory_._newInstance32425 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpecFactory_.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;");
		}
		internal static void InitJNI()
		{
		}
	}
}
