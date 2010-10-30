namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyGenerator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyGenerator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28651;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getInstance28651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28652;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getInstance28652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.KeyGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28653;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getInstance28653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _init28654;
		public virtual void init(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init28655;
		public virtual void init(int arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28656;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init28657;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28658;
		public virtual void init(java.security.SecureRandom arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init28658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28659;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getAlgorithm28659)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider28660;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getProvider28660)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generateKey28661;
		public virtual global::javax.crypto.SecretKey generateKey()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._generateKey28661)) as javax.crypto.SecretKey;
		}
		internal static global::MonoJavaBridge.MethodId _KeyGenerator28662;
		protected KeyGenerator(javax.crypto.KeyGeneratorSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._KeyGenerator28662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static KeyGenerator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyGenerator"));
			global::javax.crypto.KeyGenerator._getInstance28651 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/KeyGenerator;");
			global::javax.crypto.KeyGenerator._getInstance28652 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyGenerator;");
			global::javax.crypto.KeyGenerator._getInstance28653 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/KeyGenerator;");
			global::javax.crypto.KeyGenerator._init28654 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(I)V");
			global::javax.crypto.KeyGenerator._init28655 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(ILjava/security/SecureRandom;)V");
			global::javax.crypto.KeyGenerator._init28656 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.KeyGenerator._init28657 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGenerator._init28658 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGenerator._getAlgorithm28659 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.KeyGenerator._getProvider28660 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.KeyGenerator._generateKey28661 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "generateKey", "()Ljavax/crypto/SecretKey;");
			global::javax.crypto.KeyGenerator._KeyGenerator28662 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "<init>", "(Ljavax/crypto/KeyGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
