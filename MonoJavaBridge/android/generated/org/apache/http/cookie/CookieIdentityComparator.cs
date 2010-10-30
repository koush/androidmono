namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CookieIdentityComparator : java.lang.Object, java.io.Serializable, java.util.Comparator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CookieIdentityComparator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compare32407;
		public virtual int compare(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.Cookie arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.CookieIdentityComparator.staticClass, global::org.apache.http.cookie.CookieIdentityComparator._compare32407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compare32408;
		public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.CookieIdentityComparator.staticClass, global::org.apache.http.cookie.CookieIdentityComparator._compare32408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _CookieIdentityComparator32409;
		public CookieIdentityComparator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.CookieIdentityComparator.staticClass, global::org.apache.http.cookie.CookieIdentityComparator._CookieIdentityComparator32409);
			Init(@__env, handle);
		}
		static CookieIdentityComparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieIdentityComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieIdentityComparator"));
			global::org.apache.http.cookie.CookieIdentityComparator._compare32407 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieIdentityComparator.staticClass, "compare", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/Cookie;)I");
			global::org.apache.http.cookie.CookieIdentityComparator._compare32408 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieIdentityComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
			global::org.apache.http.cookie.CookieIdentityComparator._CookieIdentityComparator32409 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieIdentityComparator.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
