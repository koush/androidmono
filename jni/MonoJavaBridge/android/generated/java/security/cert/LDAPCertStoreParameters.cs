namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LDAPCertStoreParameters : java.lang.Object, CertStoreParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LDAPCertStoreParameters()
		{
			InitJNI();
		}
		protected LDAPCertStoreParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23500;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.LDAPCertStoreParameters._toString23500)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._toString23500)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23501;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.LDAPCertStoreParameters._clone23501)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._clone23501)) as java.lang.Object;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort23502;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.LDAPCertStoreParameters._getPort23502);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._getPort23502);
		}
		public new global::java.lang.String ServerName
		{
			get
			{
				return getServerName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServerName23503;
		public virtual global::java.lang.String getServerName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.LDAPCertStoreParameters._getServerName23503)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._getServerName23503)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _LDAPCertStoreParameters23504;
		public LDAPCertStoreParameters(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LDAPCertStoreParameters23505;
		public LDAPCertStoreParameters(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LDAPCertStoreParameters23506;
		public LDAPCertStoreParameters()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.LDAPCertStoreParameters.staticClass, global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23506);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.LDAPCertStoreParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/LDAPCertStoreParameters"));
			global::java.security.cert.LDAPCertStoreParameters._toString23500 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.cert.LDAPCertStoreParameters._clone23501 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.cert.LDAPCertStoreParameters._getPort23502 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "getPort", "()I");
			global::java.security.cert.LDAPCertStoreParameters._getServerName23503 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "getServerName", "()Ljava/lang/String;");
			global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23504 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23505 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.cert.LDAPCertStoreParameters._LDAPCertStoreParameters23506 = @__env.GetMethodIDNoThrow(global::java.security.cert.LDAPCertStoreParameters.staticClass, "<init>", "()V");
		}
	}
}
