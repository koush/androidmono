namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LDAPCertStoreParameters : java.lang.Object, CertStoreParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LDAPCertStoreParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.LDAPCertStoreParameters.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.LDAPCertStoreParameters._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.LDAPCertStoreParameters.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.LDAPCertStoreParameters._m1) as java.lang.Object;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.LDAPCertStoreParameters.staticClass, "getPort", "()I", ref global::java.security.cert.LDAPCertStoreParameters._m2);
		}
		public new global::java.lang.String ServerName
		{
			get
			{
				return getServerName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getServerName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.LDAPCertStoreParameters.staticClass, "getServerName", "()Ljava/lang/String;", ref global::java.security.cert.LDAPCertStoreParameters._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public LDAPCertStoreParameters(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.LDAPCertStoreParameters._m4.native == global::System.IntPtr.Zero)
				global::java.security.cert.LDAPCertStoreParameters._m4 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public LDAPCertStoreParameters(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.LDAPCertStoreParameters._m5.native == global::System.IntPtr.Zero)
				global::java.security.cert.LDAPCertStoreParameters._m5 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public LDAPCertStoreParameters() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.LDAPCertStoreParameters._m6.native == global::System.IntPtr.Zero)
				global::java.security.cert.LDAPCertStoreParameters._m6 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._m6);
			Init(@__env, handle);
		}
		static LDAPCertStoreParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.LDAPCertStoreParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/LDAPCertStoreParameters"));
		}
	}
}
