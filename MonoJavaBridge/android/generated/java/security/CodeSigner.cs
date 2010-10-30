namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CodeSigner : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CodeSigner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals22919;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.CodeSigner.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.CodeSigner._equals22919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22920;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.CodeSigner.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.CodeSigner._toString22920) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22921;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.CodeSigner.staticClass, "hashCode", "()I", ref global::java.security.CodeSigner._hashCode22921);
		}
		public new global::java.security.cert.CertPath SignerCertPath
		{
			get
			{
				return getSignerCertPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSignerCertPath22922;
		public global::java.security.cert.CertPath getSignerCertPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.CodeSigner.staticClass, "getSignerCertPath", "()Ljava/security/cert/CertPath;", ref global::java.security.CodeSigner._getSignerCertPath22922) as java.security.cert.CertPath;
		}
		public new global::java.security.Timestamp Timestamp
		{
			get
			{
				return getTimestamp();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp22923;
		public global::java.security.Timestamp getTimestamp()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.security.Timestamp>(this, global::java.security.CodeSigner.staticClass, "getTimestamp", "()Ljava/security/Timestamp;", ref global::java.security.CodeSigner._getTimestamp22923) as java.security.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _CodeSigner22924;
		public CodeSigner(java.security.cert.CertPath arg0, java.security.Timestamp arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.CodeSigner._CodeSigner22924.native == global::System.IntPtr.Zero)
				global::java.security.CodeSigner._CodeSigner22924 = @__env.GetMethodIDNoThrow(global::java.security.CodeSigner.staticClass, "<init>", "(Ljava/security/cert/CertPath;Ljava/security/Timestamp;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.CodeSigner.staticClass, global::java.security.CodeSigner._CodeSigner22924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CodeSigner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.CodeSigner.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/CodeSigner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
