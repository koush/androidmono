namespace org.apache.http.client.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookiePolicy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookiePolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::java.lang.String BROWSER_COMPATIBILITY
		{
			get
			{
				return "compatibility";
			}
		}
		public static global::java.lang.String NETSCAPE
		{
			get
			{
				return "netscape";
			}
		}
		public static global::java.lang.String RFC_2109
		{
			get
			{
				return "rfc2109";
			}
		}
		public static global::java.lang.String RFC_2965
		{
			get
			{
				return "rfc2965";
			}
		}
		public static global::java.lang.String BEST_MATCH
		{
			get
			{
				return "best-match";
			}
		}
		static CookiePolicy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.CookiePolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/params/CookiePolicy"));
		}
		internal static void InitJNI()
		{
		}
	}
}
