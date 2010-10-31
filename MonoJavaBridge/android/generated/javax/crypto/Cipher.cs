namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Cipher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Cipher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Cipher._m0.native == global::System.IntPtr.Zero)
				global::javax.crypto.Cipher._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Cipher;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Cipher;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Cipher._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.Cipher._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Cipher;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Cipher;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Cipher._m2.native == global::System.IntPtr.Zero)
				global::javax.crypto.Cipher._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Cipher;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.Cipher;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void init(int arg0, java.security.cert.Certificate arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/cert/Certificate;Ljava/security/SecureRandom;)V", ref global::javax.crypto.Cipher._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void init(int arg0, java.security.Key arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;)V", ref global::javax.crypto.Cipher._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void init(int arg0, java.security.Key arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/SecureRandom;)V", ref global::javax.crypto.Cipher._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void init(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::javax.crypto.Cipher._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void init(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::javax.crypto.Cipher._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void init(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;)V", ref global::javax.crypto.Cipher._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void init(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V", ref global::javax.crypto.Cipher._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void init(int arg0, java.security.cert.Certificate arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/cert/Certificate;)V", ref global::javax.crypto.Cipher._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual byte[] wrap(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Cipher.staticClass, "wrap", "(Ljava/security/Key;)[B", ref global::javax.crypto.Cipher._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int update(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, "update", "([BII[BI)I", ref global::javax.crypto.Cipher._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int update(byte[] arg0, int arg1, int arg2, byte[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, "update", "([BII[B)I", ref global::javax.crypto.Cipher._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual byte[] update(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Cipher.staticClass, "update", "([BII)[B", ref global::javax.crypto.Cipher._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual byte[] update(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Cipher.staticClass, "update", "([B)[B", ref global::javax.crypto.Cipher._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int update(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, "update", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", ref global::javax.crypto.Cipher._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.Cipher.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.Cipher._m17) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.crypto.Cipher._m18) as java.security.Provider;
		}
		public new global::java.security.AlgorithmParameters Parameters
		{
			get
			{
				return getParameters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.security.AlgorithmParameters getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, "getParameters", "()Ljava/security/AlgorithmParameters;", ref global::javax.crypto.Cipher._m19) as java.security.AlgorithmParameters;
		}
		public new int BlockSize
		{
			get
			{
				return getBlockSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int getBlockSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, "getBlockSize", "()I", ref global::javax.crypto.Cipher._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.security.Key unwrap(byte[] arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::javax.crypto.Cipher.staticClass, "unwrap", "([BLjava/lang/String;I)Ljava/security/Key;", ref global::javax.crypto.Cipher._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.security.Key;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual byte[] doFinal(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Cipher.staticClass, "doFinal", "([B)[B", ref global::javax.crypto.Cipher._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual byte[] doFinal(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Cipher.staticClass, "doFinal", "([BII)[B", ref global::javax.crypto.Cipher._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int doFinal(byte[] arg0, int arg1, int arg2, byte[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, "doFinal", "([BII[B)I", ref global::javax.crypto.Cipher._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int doFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, "doFinal", "([BII[BI)I", ref global::javax.crypto.Cipher._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int doFinal(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, "doFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", ref global::javax.crypto.Cipher._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int doFinal(byte[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, "doFinal", "([BI)I", ref global::javax.crypto.Cipher._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual byte[] doFinal()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Cipher.staticClass, "doFinal", "()[B", ref global::javax.crypto.Cipher._m28) as byte[];
		}
		public new global::javax.crypto.ExemptionMechanism ExemptionMechanism
		{
			get
			{
				return getExemptionMechanism();
			}
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::javax.crypto.ExemptionMechanism getExemptionMechanism()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, "getExemptionMechanism", "()Ljavax/crypto/ExemptionMechanism;", ref global::javax.crypto.Cipher._m29) as javax.crypto.ExemptionMechanism;
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual byte[] getIV()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Cipher.staticClass, "getIV", "()[B", ref global::javax.crypto.Cipher._m30) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static int getMaxAllowedKeyLength(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Cipher._m31.native == global::System.IntPtr.Zero)
				global::javax.crypto.Cipher._m31 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getMaxAllowedKeyLength", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static global::java.security.spec.AlgorithmParameterSpec getMaxAllowedParameterSpec(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Cipher._m32.native == global::System.IntPtr.Zero)
				global::javax.crypto.Cipher._m32 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getMaxAllowedParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/AlgorithmParameterSpec;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual int getOutputSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, "getOutputSize", "(I)I", ref global::javax.crypto.Cipher._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		protected Cipher(javax.crypto.CipherSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Cipher._m34.native == global::System.IntPtr.Zero)
				global::javax.crypto.Cipher._m34 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "<init>", "(Ljavax/crypto/CipherSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int ENCRYPT_MODE
		{
			get
			{
				return 1;
			}
		}
		public static int DECRYPT_MODE
		{
			get
			{
				return 2;
			}
		}
		public static int WRAP_MODE
		{
			get
			{
				return 3;
			}
		}
		public static int UNWRAP_MODE
		{
			get
			{
				return 4;
			}
		}
		public static int PUBLIC_KEY
		{
			get
			{
				return 1;
			}
		}
		public static int PRIVATE_KEY
		{
			get
			{
				return 2;
			}
		}
		public static int SECRET_KEY
		{
			get
			{
				return 3;
			}
		}
		static Cipher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.Cipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/Cipher"));
		}
	}
}
