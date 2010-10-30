namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CookiePathComparator : java.lang.Object, java.io.Serializable, java.util.Comparator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CookiePathComparator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compare32416;
		public virtual int compare(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.Cookie arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.CookiePathComparator.staticClass, "compare", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/Cookie;)I", ref global::org.apache.http.cookie.CookiePathComparator._compare32416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compare32417;
		public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.CookiePathComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", ref global::org.apache.http.cookie.CookiePathComparator._compare32417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _CookiePathComparator32418;
		public CookiePathComparator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.CookiePathComparator._CookiePathComparator32418.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.CookiePathComparator._CookiePathComparator32418 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookiePathComparator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.CookiePathComparator.staticClass, global::org.apache.http.cookie.CookiePathComparator._CookiePathComparator32418);
			Init(@__env, handle);
		}
		static CookiePathComparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookiePathComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookiePathComparator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
