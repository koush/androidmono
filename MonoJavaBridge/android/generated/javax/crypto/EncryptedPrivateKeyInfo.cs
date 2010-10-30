namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EncryptedPrivateKeyInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EncryptedPrivateKeyInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getEncoded", "()[B", ref global::javax.crypto.EncryptedPrivateKeyInfo._m0) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.security.spec.PKCS8EncodedKeySpec getKeySpec(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getKeySpec", "(Ljava/security/Key;)Ljava/security/spec/PKCS8EncodedKeySpec;", ref global::javax.crypto.EncryptedPrivateKeyInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.spec.PKCS8EncodedKeySpec;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.security.spec.PKCS8EncodedKeySpec getKeySpec(java.security.Key arg0, java.security.Provider arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getKeySpec", "(Ljava/security/Key;Ljava/security/Provider;)Ljava/security/spec/PKCS8EncodedKeySpec;", ref global::javax.crypto.EncryptedPrivateKeyInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.spec.PKCS8EncodedKeySpec;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.security.spec.PKCS8EncodedKeySpec getKeySpec(javax.crypto.Cipher arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getKeySpec", "(Ljavax/crypto/Cipher;)Ljava/security/spec/PKCS8EncodedKeySpec;", ref global::javax.crypto.EncryptedPrivateKeyInfo._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.spec.PKCS8EncodedKeySpec;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.spec.PKCS8EncodedKeySpec getKeySpec(java.security.Key arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getKeySpec", "(Ljava/security/Key;Ljava/lang/String;)Ljava/security/spec/PKCS8EncodedKeySpec;", ref global::javax.crypto.EncryptedPrivateKeyInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.spec.PKCS8EncodedKeySpec;
		}
		public new global::java.lang.String AlgName
		{
			get
			{
				return getAlgName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getAlgName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getAlgName", "()Ljava/lang/String;", ref global::javax.crypto.EncryptedPrivateKeyInfo._m5) as java.lang.String;
		}
		public new global::java.security.AlgorithmParameters AlgParameters
		{
			get
			{
				return getAlgParameters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.security.AlgorithmParameters getAlgParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getAlgParameters", "()Ljava/security/AlgorithmParameters;", ref global::javax.crypto.EncryptedPrivateKeyInfo._m6) as java.security.AlgorithmParameters;
		}
		public new byte[] EncryptedData
		{
			get
			{
				return getEncryptedData();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual byte[] getEncryptedData()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getEncryptedData", "()[B", ref global::javax.crypto.EncryptedPrivateKeyInfo._m7) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public EncryptedPrivateKeyInfo(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.EncryptedPrivateKeyInfo._m8.native == global::System.IntPtr.Zero)
				global::javax.crypto.EncryptedPrivateKeyInfo._m8 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public EncryptedPrivateKeyInfo(java.lang.String arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.EncryptedPrivateKeyInfo._m9.native == global::System.IntPtr.Zero)
				global::javax.crypto.EncryptedPrivateKeyInfo._m9 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "<init>", "(Ljava/lang/String;[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public EncryptedPrivateKeyInfo(java.security.AlgorithmParameters arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.EncryptedPrivateKeyInfo._m10.native == global::System.IntPtr.Zero)
				global::javax.crypto.EncryptedPrivateKeyInfo._m10 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "<init>", "(Ljava/security/AlgorithmParameters;[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static EncryptedPrivateKeyInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.EncryptedPrivateKeyInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/EncryptedPrivateKeyInfo"));
		}
		internal static void InitJNI()
		{
		}
	}
}
