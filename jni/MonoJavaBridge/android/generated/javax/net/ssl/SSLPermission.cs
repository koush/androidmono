namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SSLPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLPermission()
		{
			InitJNI();
		}
		internal SSLPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SSLPermission23443;
		public SSLPermission(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLPermission.staticClass, global::javax.net.ssl.SSLPermission._SSLPermission23443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLPermission23444;
		public SSLPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLPermission.staticClass, global::javax.net.ssl.SSLPermission._SSLPermission23444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLPermission"));
			global::javax.net.ssl.SSLPermission._SSLPermission23443 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.net.ssl.SSLPermission._SSLPermission23444 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
