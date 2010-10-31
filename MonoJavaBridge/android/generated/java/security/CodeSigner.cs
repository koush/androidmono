namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CodeSigner : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CodeSigner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.CodeSigner.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.CodeSigner._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.CodeSigner.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.CodeSigner._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.CodeSigner.staticClass, "hashCode", "()I", ref global::java.security.CodeSigner._m2);
		}
		public new global::java.security.cert.CertPath SignerCertPath
		{
			get
			{
				return getSignerCertPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.security.cert.CertPath getSignerCertPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.CodeSigner.staticClass, "getSignerCertPath", "()Ljava/security/cert/CertPath;", ref global::java.security.CodeSigner._m3) as java.security.cert.CertPath;
		}
		public new global::java.security.Timestamp Timestamp
		{
			get
			{
				return getTimestamp();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.security.Timestamp getTimestamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.security.Timestamp>(this, global::java.security.CodeSigner.staticClass, "getTimestamp", "()Ljava/security/Timestamp;", ref global::java.security.CodeSigner._m4) as java.security.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public CodeSigner(java.security.cert.CertPath arg0, java.security.Timestamp arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSigner._m5.native == global::System.IntPtr.Zero)
				global::java.security.CodeSigner._m5 = @__env.GetMethodIDNoThrow(global::java.security.CodeSigner.staticClass, "<init>", "(Ljava/security/cert/CertPath;Ljava/security/Timestamp;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSigner.staticClass, global::java.security.CodeSigner._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CodeSigner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.CodeSigner.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/CodeSigner"));
		}
	}
}
