namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SSLPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SSLPermission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLPermission._m0.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLPermission._m0 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLPermission.staticClass, global::javax.net.ssl.SSLPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SSLPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLPermission._m1.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLPermission._m1 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLPermission.staticClass, global::javax.net.ssl.SSLPermission._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SSLPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLPermission"));
		}
		internal static void InitJNI()
		{
		}
	}
}
