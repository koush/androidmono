namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Cipher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Cipher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28491;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getInstance28491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Cipher;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28492;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getInstance28492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Cipher;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28493;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getInstance28493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.Cipher;
		}
		internal static global::MonoJavaBridge.MethodId _init28494;
		public virtual void init(int arg0, java.security.cert.Certificate arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init28495;
		public virtual void init(int arg0, java.security.Key arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28496;
		public virtual void init(int arg0, java.security.Key arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init28497;
		public virtual void init(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init28498;
		public virtual void init(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _init28499;
		public virtual void init(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init28500;
		public virtual void init(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _init28501;
		public virtual void init(int arg0, java.security.cert.Certificate arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wrap28502;
		public virtual byte[] wrap(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._wrap28502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update28503;
		public virtual int update(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update28504;
		public virtual int update(byte[] arg0, int arg1, int arg2, byte[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _update28505;
		public virtual byte[] update(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update28506;
		public virtual byte[] update(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update28507;
		public virtual int update(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28508;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getAlgorithm28508)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider28509;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getProvider28509)) as java.security.Provider;
		}
		public new global::java.security.AlgorithmParameters Parameters
		{
			get
			{
				return getParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameters28510;
		public virtual global::java.security.AlgorithmParameters getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getParameters28510)) as java.security.AlgorithmParameters;
		}
		public new int BlockSize
		{
			get
			{
				return getBlockSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBlockSize28511;
		public virtual int getBlockSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getBlockSize28511);
		}
		internal static global::MonoJavaBridge.MethodId _unwrap28512;
		public virtual global::java.security.Key unwrap(byte[] arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._unwrap28512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28513;
		public virtual byte[] doFinal(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28514;
		public virtual byte[] doFinal(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28515;
		public virtual int doFinal(byte[] arg0, int arg1, int arg2, byte[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28516;
		public virtual int doFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28517;
		public virtual int doFinal(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28518;
		public virtual int doFinal(byte[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28519;
		public virtual byte[] doFinal()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28519)) as byte[];
		}
		public new global::javax.crypto.ExemptionMechanism ExemptionMechanism
		{
			get
			{
				return getExemptionMechanism();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExemptionMechanism28520;
		public virtual global::javax.crypto.ExemptionMechanism getExemptionMechanism()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getExemptionMechanism28520)) as javax.crypto.ExemptionMechanism;
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIV28521;
		public virtual byte[] getIV()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getIV28521)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAllowedKeyLength28522;
		public static int getMaxAllowedKeyLength(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getMaxAllowedKeyLength28522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAllowedParameterSpec28523;
		public static global::java.security.spec.AlgorithmParameterSpec getMaxAllowedParameterSpec(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getMaxAllowedParameterSpec28523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputSize28524;
		public virtual int getOutputSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getOutputSize28524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Cipher28525;
		protected Cipher(javax.crypto.CipherSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._Cipher28525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::javax.crypto.Cipher._getInstance28491 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Cipher;");
			global::javax.crypto.Cipher._getInstance28492 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Cipher;");
			global::javax.crypto.Cipher._getInstance28493 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Cipher;");
			global::javax.crypto.Cipher._init28494 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/cert/Certificate;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init28495 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;)V");
			global::javax.crypto.Cipher._init28496 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init28497 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.Cipher._init28498 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init28499 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;)V");
			global::javax.crypto.Cipher._init28500 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init28501 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/cert/Certificate;)V");
			global::javax.crypto.Cipher._wrap28502 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "wrap", "(Ljava/security/Key;)[B");
			global::javax.crypto.Cipher._update28503 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([BII[BI)I");
			global::javax.crypto.Cipher._update28504 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([BII[B)I");
			global::javax.crypto.Cipher._update28505 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([BII)[B");
			global::javax.crypto.Cipher._update28506 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([B)[B");
			global::javax.crypto.Cipher._update28507 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.Cipher._getAlgorithm28508 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.Cipher._getProvider28509 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.Cipher._getParameters28510 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getParameters", "()Ljava/security/AlgorithmParameters;");
			global::javax.crypto.Cipher._getBlockSize28511 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getBlockSize", "()I");
			global::javax.crypto.Cipher._unwrap28512 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "unwrap", "([BLjava/lang/String;I)Ljava/security/Key;");
			global::javax.crypto.Cipher._doFinal28513 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([B)[B");
			global::javax.crypto.Cipher._doFinal28514 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BII)[B");
			global::javax.crypto.Cipher._doFinal28515 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BII[B)I");
			global::javax.crypto.Cipher._doFinal28516 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BII[BI)I");
			global::javax.crypto.Cipher._doFinal28517 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.Cipher._doFinal28518 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BI)I");
			global::javax.crypto.Cipher._doFinal28519 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "()[B");
			global::javax.crypto.Cipher._getExemptionMechanism28520 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getExemptionMechanism", "()Ljavax/crypto/ExemptionMechanism;");
			global::javax.crypto.Cipher._getIV28521 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getIV", "()[B");
			global::javax.crypto.Cipher._getMaxAllowedKeyLength28522 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getMaxAllowedKeyLength", "(Ljava/lang/String;)I");
			global::javax.crypto.Cipher._getMaxAllowedParameterSpec28523 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getMaxAllowedParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::javax.crypto.Cipher._getOutputSize28524 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getOutputSize", "(I)I");
			global::javax.crypto.Cipher._Cipher28525 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "<init>", "(Ljavax/crypto/CipherSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
