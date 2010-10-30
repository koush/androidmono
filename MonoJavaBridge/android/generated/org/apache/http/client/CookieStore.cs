namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.CookieStore_))]
	public partial interface CookieStore  : global::MonoJavaBridge.IJavaObject 
	{
		void clear();
		void addCookie(org.apache.http.cookie.Cookie arg0);
		global::java.util.List getCookies();
		bool clearExpired(java.util.Date arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.CookieStore))]
	internal sealed partial class CookieStore_ : java.lang.Object, CookieStore
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieStore_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear31874;
		void org.apache.http.client.CookieStore.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.CookieStore_.staticClass, "clear", "()V", ref global::org.apache.http.client.CookieStore_._clear31874);
		}
		internal static global::MonoJavaBridge.MethodId _addCookie31875;
		void org.apache.http.client.CookieStore.addCookie(org.apache.http.cookie.Cookie arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.CookieStore_.staticClass, "addCookie", "(Lorg/apache/http/cookie/Cookie;)V", ref global::org.apache.http.client.CookieStore_._addCookie31875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCookies31876;
		global::java.util.List org.apache.http.client.CookieStore.getCookies()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.client.CookieStore_.staticClass, "getCookies", "()Ljava/util/List;", ref global::org.apache.http.client.CookieStore_._getCookies31876) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _clearExpired31877;
		bool org.apache.http.client.CookieStore.clearExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.client.CookieStore_.staticClass, "clearExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.client.CookieStore_._clearExpired31877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CookieStore_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.CookieStore_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/CookieStore"));
		}
		internal static void InitJNI()
		{
		}
	}
}
