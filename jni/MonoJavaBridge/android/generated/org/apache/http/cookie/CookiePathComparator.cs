namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CookiePathComparator : java.lang.Object, java.io.Serializable, java.util.Comparator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookiePathComparator()
		{
			InitJNI();
		}
		protected CookiePathComparator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compare32415;
		public virtual int compare(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.Cookie arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookiePathComparator._compare32415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookiePathComparator.staticClass, global::org.apache.http.cookie.CookiePathComparator._compare32415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compare32416;
		public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookiePathComparator._compare32416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookiePathComparator.staticClass, global::org.apache.http.cookie.CookiePathComparator._compare32416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _CookiePathComparator32417;
		public CookiePathComparator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.CookiePathComparator.staticClass, global::org.apache.http.cookie.CookiePathComparator._CookiePathComparator32417);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookiePathComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookiePathComparator"));
			global::org.apache.http.cookie.CookiePathComparator._compare32415 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookiePathComparator.staticClass, "compare", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/Cookie;)I");
			global::org.apache.http.cookie.CookiePathComparator._compare32416 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookiePathComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
			global::org.apache.http.cookie.CookiePathComparator._CookiePathComparator32417 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookiePathComparator.staticClass, "<init>", "()V");
		}
	}
}
