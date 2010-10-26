namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedCookieException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MalformedCookieException()
		{
			InitJNI();
		}
		protected MalformedCookieException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _MalformedCookieException32432;
		public MalformedCookieException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.MalformedCookieException.staticClass, global::org.apache.http.cookie.MalformedCookieException._MalformedCookieException32432);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedCookieException32433;
		public MalformedCookieException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.MalformedCookieException.staticClass, global::org.apache.http.cookie.MalformedCookieException._MalformedCookieException32433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedCookieException32434;
		public MalformedCookieException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.MalformedCookieException.staticClass, global::org.apache.http.cookie.MalformedCookieException._MalformedCookieException32434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.MalformedCookieException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/MalformedCookieException"));
			global::org.apache.http.cookie.MalformedCookieException._MalformedCookieException32432 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.MalformedCookieException.staticClass, "<init>", "()V");
			global::org.apache.http.cookie.MalformedCookieException._MalformedCookieException32433 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.MalformedCookieException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.MalformedCookieException._MalformedCookieException32434 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.MalformedCookieException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
