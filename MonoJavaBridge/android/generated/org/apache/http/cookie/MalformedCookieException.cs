namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedCookieException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MalformedCookieException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public MalformedCookieException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.MalformedCookieException._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.MalformedCookieException._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.MalformedCookieException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.MalformedCookieException.staticClass, global::org.apache.http.cookie.MalformedCookieException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public MalformedCookieException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.MalformedCookieException._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.MalformedCookieException._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.MalformedCookieException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.MalformedCookieException.staticClass, global::org.apache.http.cookie.MalformedCookieException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public MalformedCookieException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.MalformedCookieException._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.MalformedCookieException._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.MalformedCookieException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.MalformedCookieException.staticClass, global::org.apache.http.cookie.MalformedCookieException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MalformedCookieException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.MalformedCookieException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/MalformedCookieException"));
		}
	}
}
