namespace org.apache.http.client.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AuthPolicy : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthPolicy()
		{
			InitJNI();
		}
		internal AuthPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::java.lang.String NTLM
		{
			get
			{
				return "NTLM";
			}
		}
		public static global::java.lang.String DIGEST
		{
			get
			{
				return "Digest";
			}
		}
		public static global::java.lang.String BASIC
		{
			get
			{
				return "Basic";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.AuthPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/params/AuthPolicy"));
		}
	}
}
