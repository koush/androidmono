namespace org.apache.http.conn.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BrowserCompatHostnameVerifier : org.apache.http.conn.ssl.AbstractVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BrowserCompatHostnameVerifier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", ref global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public BrowserCompatHostnameVerifier() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._m2);
			Init(@__env, handle);
		}
		static BrowserCompatHostnameVerifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/BrowserCompatHostnameVerifier"));
		}
	}
}
