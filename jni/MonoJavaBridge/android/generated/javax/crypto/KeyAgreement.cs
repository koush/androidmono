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
		internal static global::MonoJavaBridge.MethodId _getInstance22609;
		public static global::javax.crypto.KeyAgreement getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getInstance22609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.KeyAgreement;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22610;
		public static global::javax.crypto.KeyAgreement getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getInstance22610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyAgreement;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22611;
		public static global::javax.crypto.KeyAgreement getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getInstance22611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyAgreement;
		}
		internal static global::MonoJavaBridge.MethodId _init22612;
		public virtual void init(java.security.Key arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._init22612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._init22612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init22613;
		public virtual void init(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._init22613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._init22613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22614;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._init22614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._init22614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init22615;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1, java.security.SecureRandom arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._init22615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._init22615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22616;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._getAlgorithm22616)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getAlgorithm22616)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22617;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._getProvider22617)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._getProvider22617)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _doPhase22618;
		public virtual global::java.security.Key doPhase(java.security.Key arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._doPhase22618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._doPhase22618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _generateSecret22619;
		public virtual byte[] generateSecret() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._generateSecret22619)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._generateSecret22619)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _generateSecret22620;
		public virtual int generateSecret(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._generateSecret22620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._generateSecret22620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _generateSecret22621;
		public virtual global::javax.crypto.SecretKey generateSecret(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement._generateSecret22621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._generateSecret22621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
		}
		internal static global::MonoJavaBridge.MethodId _KeyAgreement22622;
		protected KeyAgreement(javax.crypto.KeyAgreementSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyAgreement.staticClass, global::javax.crypto.KeyAgreement._KeyAgreement22622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyAgreement.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyAgreement"));
			global::javax.crypto.KeyAgreement._getInstance22609 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyAgreement;");
			global::javax.crypto.KeyAgreement._getInstance22610 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/KeyAgreement;");
			global::javax.crypto.KeyAgreement._getInstance22611 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/KeyAgreement;");
			global::javax.crypto.KeyAgreement._init22612 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyAgreement._init22613 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;)V");
			global::javax.crypto.KeyAgreement._init22614 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.KeyAgreement._init22615 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyAgreement._getAlgorithm22616 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.KeyAgreement._getProvider22617 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.KeyAgreement._doPhase22618 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "doPhase", "(Ljava/security/Key;Z)Ljava/security/Key;");
			global::javax.crypto.KeyAgreement._generateSecret22619 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "generateSecret", "()[B");
			global::javax.crypto.KeyAgreement._generateSecret22620 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "generateSecret", "([BI)I");
			global::javax.crypto.KeyAgreement._generateSecret22621 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "generateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;");
			global::javax.crypto.KeyAgreement._KeyAgreement22622 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreement.staticClass, "<init>", "(Ljavax/crypto/KeyAgreementSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
