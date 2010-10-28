namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AUTH : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AUTH(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::java.lang.String WWW_AUTH
		{
			get
			{
				return "WWW-Authenticate";
			}
		}
		public static global::java.lang.String WWW_AUTH_RESP
		{
			get
			{
				return "Authorization";
			}
		}
		public static global::java.lang.String PROXY_AUTH
		{
			get
			{
				return "Proxy-Authenticate";
			}
		}
		public static global::java.lang.String PROXY_AUTH_RESP
		{
			get
			{
				return "Proxy-Authorization";
			}
		}
		static AUTH()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AUTH.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AUTH"));
		}
		internal static void InitJNI()
		{
		}
	}
}
