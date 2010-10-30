namespace android.net.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SslError : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SslError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.http.SslError.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.http.SslError._m0) as java.lang.String;
		}
		public new global::android.net.http.SslCertificate Certificate
		{
			get
			{
				return getCertificate();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.net.http.SslCertificate getCertificate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.http.SslError.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;", ref global::android.net.http.SslError._m1) as android.net.http.SslCertificate;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool hasError(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.http.SslError.staticClass, "hasError", "(I)Z", ref global::android.net.http.SslError._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool addError(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.http.SslError.staticClass, "addError", "(I)Z", ref global::android.net.http.SslError._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int PrimaryError
		{
			get
			{
				return getPrimaryError();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getPrimaryError()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.http.SslError.staticClass, "getPrimaryError", "()I", ref global::android.net.http.SslError._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SslError(int arg0, android.net.http.SslCertificate arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.SslError._m5.native == global::System.IntPtr.Zero)
				global::android.net.http.SslError._m5 = @__env.GetMethodIDNoThrow(global::android.net.http.SslError.staticClass, "<init>", "(ILandroid/net/http/SslCertificate;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslError.staticClass, global::android.net.http.SslError._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public SslError(int arg0, java.security.cert.X509Certificate arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.http.SslError._m6.native == global::System.IntPtr.Zero)
				global::android.net.http.SslError._m6 = @__env.GetMethodIDNoThrow(global::android.net.http.SslError.staticClass, "<init>", "(ILjava/security/cert/X509Certificate;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslError.staticClass, global::android.net.http.SslError._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int SSL_NOTYETVALID
		{
			get
			{
				return 0;
			}
		}
		public static int SSL_EXPIRED
		{
			get
			{
				return 1;
			}
		}
		public static int SSL_IDMISMATCH
		{
			get
			{
				return 2;
			}
		}
		public static int SSL_UNTRUSTED
		{
			get
			{
				return 3;
			}
		}
		public static int SSL_MAX_ERROR
		{
			get
			{
				return 4;
			}
		}
		static SslError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.http.SslError.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
