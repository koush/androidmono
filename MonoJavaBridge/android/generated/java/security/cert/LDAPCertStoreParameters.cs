namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LDAPCertStoreParameters : java.lang.Object, CertStoreParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LDAPCertStoreParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23619;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.LDAPCertStoreParameters.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.cert.LDAPCertStoreParameters._toString23619) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23620;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.LDAPCertStoreParameters.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.cert.LDAPCertStoreParameters._clone23620) as java.lang.Object;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort23621;
		public virtual int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.LDAPCertStoreParameters.staticClass, "getPort", "()I", ref global::java.security.cert.LDAPCertStoreParameters._getPort23621);
		}
		public new global::java.lang.String ServerName
		{
			get
			{
				return getServerName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServerName23622;
		public virtual global::java.lang.String getServerName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.LDAPCertStoreParameters.staticClass, "getServerName", "()Ljava/lang/String;", ref global::java.security.cert.LDAPCertStoreParameters._getServerName23622) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _LDAPCertStoreParameters23623;
		public LDAPCertStoreParameters(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23623.native == global::System.IntPtr.Zero)
				global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23623 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LDAPCertStoreParameters23624;
		public LDAPCertStoreParameters(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23624.native == global::System.IntPtr.Zero)
				global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23624 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LDAPCertStoreParameters23625;
		public LDAPCertStoreParameters() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23625.native == global::System.IntPtr.Zero)
				global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23625 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23625);
			Init(@__env, handle);
		}
		static LDAPCertStoreParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.LDAPCertStoreParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/LDAPCertStoreParameters"));
		}
		internal static void InitJNI()
		{
		}
	}
}
