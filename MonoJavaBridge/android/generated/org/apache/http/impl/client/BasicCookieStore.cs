namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicCookieStore : java.lang.Object, org.apache.http.client.CookieStore
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicCookieStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.impl.client.BasicCookieStore._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, "clear", "()V", ref global::org.apache.http.impl.client.BasicCookieStore._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void addCookie(org.apache.http.cookie.Cookie arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, "addCookie", "(Lorg/apache/http/cookie/Cookie;)V", ref global::org.apache.http.impl.client.BasicCookieStore._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Cookies
		{
			get
			{
				return getCookies();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.List getCookies()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, "getCookies", "()Ljava/util/List;", ref global::org.apache.http.impl.client.BasicCookieStore._m3) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool clearExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, "clearExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.impl.client.BasicCookieStore._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void addCookies(org.apache.http.cookie.Cookie[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCookieStore.staticClass, "addCookies", "([Lorg/apache/http/cookie/Cookie;)V", ref global::org.apache.http.impl.client.BasicCookieStore._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public BasicCookieStore() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.BasicCookieStore._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.BasicCookieStore._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCookieStore.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.BasicCookieStore.staticClass, global::org.apache.http.impl.client.BasicCookieStore._m6);
			Init(@__env, handle);
		}
		static BasicCookieStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.BasicCookieStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/BasicCookieStore"));
		}
		internal static void InitJNI()
		{
		}
	}
}
