namespace org.apache.http.conn.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BrowserCompatHostnameVerifier : org.apache.http.conn.ssl.AbstractVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BrowserCompatHostnameVerifier()
		{
			InitJNI();
		}
		protected BrowserCompatHostnameVerifier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32217;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._toString32217)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._toString32217)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _verify32218;
		public sealed override void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._verify32218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._verify32218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _BrowserCompatHostnameVerifier32219;
		public BrowserCompatHostnameVerifier()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._BrowserCompatHostnameVerifier32219);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/BrowserCompatHostnameVerifier"));
			global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._toString32217 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._verify32218 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
			global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier._BrowserCompatHostnameVerifier32219 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.BrowserCompatHostnameVerifier.staticClass, "<init>", "()V");
		}
	}
}
