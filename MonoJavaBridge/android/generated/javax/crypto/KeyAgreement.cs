namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyAgreement : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyAgreement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.crypto.KeyAgreement getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyAgreement._m0.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyAgreement._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyAgreement;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.KeyAgreement;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.crypto.KeyAgreement getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyAgreement._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyAgreement._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/KeyAgreement;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyAgreement;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.crypto.KeyAgreement getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyAgreement._m2.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyAgreement._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/KeyAgreement;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyAgreement;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void init(java.security.Key arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;Ljava/security/SecureRandom;)V", ref global::javax.crypto.KeyAgreement._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void init(java.security.Key arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;)V", ref global::javax.crypto.KeyAgreement._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::javax.crypto.KeyAgreement._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::javax.crypto.KeyAgreement._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.KeyAgreement.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.KeyAgreement._m7) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.KeyAgreement.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.crypto.KeyAgreement._m8) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.security.Key doPhase(java.security.Key arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::javax.crypto.KeyAgreement.staticClass, "doPhase", "(Ljava/security/Key;Z)Ljava/security/Key;", ref global::javax.crypto.KeyAgreement._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.Key;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual byte[] generateSecret()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.KeyAgreement.staticClass, "generateSecret", "()[B", ref global::javax.crypto.KeyAgreement._m10) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int generateSecret(byte[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.KeyAgreement.staticClass, "generateSecret", "([BI)I", ref global::javax.crypto.KeyAgreement._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::javax.crypto.SecretKey generateSecret(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.crypto.SecretKey>(this, global::javax.crypto.KeyAgreement.staticClass, "generateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", ref global::javax.crypto.KeyAgreement._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.crypto.SecretKey;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected KeyAgreement(javax.crypto.KeyAgreementSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyAgreement._m13.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyAgreement._m13 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "<init>", "(Ljavax/crypto/KeyAgreementSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static KeyAgreement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyAgreement.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyAgreement"));
		}
	}
}
