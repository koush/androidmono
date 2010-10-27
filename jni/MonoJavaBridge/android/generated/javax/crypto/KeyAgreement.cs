namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyAgreement : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyAgreement()
		{
			InitJNI();
		}
		protected KeyAgreement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28623;
		public static global::javax.crypto.KeyAgreement getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getInstance28623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.KeyAgreement;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28624;
		public static global::javax.crypto.KeyAgreement getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getInstance28624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyAgreement;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28625;
		public static global::javax.crypto.KeyAgreement getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getInstance28625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyAgreement;
		}
		internal static global::MonoJavaBridge.MethodId _init28626;
		public virtual void init(java.security.Key arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._init28626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._init28626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28627;
		public virtual void init(java.security.Key arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._init28627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._init28627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init28628;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._init28628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._init28628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28629;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._init28629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._init28629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28630;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._getAlgorithm28630)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getAlgorithm28630)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider28631;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._getProvider28631)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getProvider28631)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _doPhase28632;
		public virtual global::java.security.Key doPhase(java.security.Key arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._doPhase28632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._doPhase28632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _generateSecret28633;
		public virtual byte[] generateSecret()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._generateSecret28633)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._generateSecret28633)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _generateSecret28634;
		public virtual int generateSecret(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._generateSecret28634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._generateSecret28634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _generateSecret28635;
		public virtual global::javax.crypto.SecretKey generateSecret(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._generateSecret28635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._generateSecret28635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
		}
		internal static global::MonoJavaBridge.MethodId _KeyAgreement28636;
		protected KeyAgreement(javax.crypto.KeyAgreementSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._KeyAgreement28636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyAgreement.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyAgreement"));
			global::javax.crypto.KeyAgreement._getInstance28623 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyAgreement;");
			global::javax.crypto.KeyAgreement._getInstance28624 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/KeyAgreement;");
			global::javax.crypto.KeyAgreement._getInstance28625 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/KeyAgreement;");
			global::javax.crypto.KeyAgreement._init28626 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyAgreement._init28627 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;)V");
			global::javax.crypto.KeyAgreement._init28628 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.KeyAgreement._init28629 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyAgreement._getAlgorithm28630 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.KeyAgreement._getProvider28631 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.KeyAgreement._doPhase28632 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "doPhase", "(Ljava/security/Key;Z)Ljava/security/Key;");
			global::javax.crypto.KeyAgreement._generateSecret28633 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "generateSecret", "()[B");
			global::javax.crypto.KeyAgreement._generateSecret28634 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "generateSecret", "([BI)I");
			global::javax.crypto.KeyAgreement._generateSecret28635 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "generateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;");
			global::javax.crypto.KeyAgreement._KeyAgreement28636 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "<init>", "(Ljavax/crypto/KeyAgreementSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
