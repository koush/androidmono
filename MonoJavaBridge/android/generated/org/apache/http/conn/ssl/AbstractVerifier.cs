namespace org.apache.http.conn.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.conn.ssl.AbstractVerifier_))]
	public abstract partial class AbstractVerifier : java.lang.Object, X509HostnameVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractVerifier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void verify(java.lang.String arg0, javax.net.ssl.SSLSocket arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSocket;)V", ref global::org.apache.http.conn.ssl.AbstractVerifier._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z", ref global::org.apache.http.conn.ssl.AbstractVerifier._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void verify(java.lang.String arg0, java.security.cert.X509Certificate arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)V", ref global::org.apache.http.conn.ssl.AbstractVerifier._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Z)V", ref global::org.apache.http.conn.ssl.AbstractVerifier._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static bool acceptableCountryWildcard(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.AbstractVerifier._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.AbstractVerifier._m5 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "acceptableCountryWildcard", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.String[] getCNs(java.security.cert.X509Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.AbstractVerifier._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.AbstractVerifier._m6 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "getCNs", "(Ljava/security/cert/X509Certificate;)[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.String[] getDNSSubjectAlts(java.security.cert.X509Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.AbstractVerifier._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.AbstractVerifier._m7 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "getDNSSubjectAlts", "(Ljava/security/cert/X509Certificate;)[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static int countDots(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.AbstractVerifier._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.AbstractVerifier._m8 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "countDots", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public AbstractVerifier() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.ssl.AbstractVerifier._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.ssl.AbstractVerifier._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._m9);
			Init(@__env, handle);
		}
		static AbstractVerifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.AbstractVerifier.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/AbstractVerifier"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ssl.AbstractVerifier))]
	internal sealed partial class AbstractVerifier_ : org.apache.http.conn.ssl.AbstractVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractVerifier_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.ssl.AbstractVerifier_.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", ref global::org.apache.http.conn.ssl.AbstractVerifier_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static AbstractVerifier_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.AbstractVerifier_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/AbstractVerifier"));
		}
	}
}
