namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyGenerator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyGenerator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyGenerator._m0.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyGenerator._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/KeyGenerator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyGenerator;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyGenerator._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyGenerator._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyGenerator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.KeyGenerator;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyGenerator._m2.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyGenerator._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/KeyGenerator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyGenerator;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void init(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, "init", "(I)V", ref global::javax.crypto.KeyGenerator._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void init(int arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, "init", "(ILjava/security/SecureRandom;)V", ref global::javax.crypto.KeyGenerator._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::javax.crypto.KeyGenerator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::javax.crypto.KeyGenerator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void init(java.security.SecureRandom arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/SecureRandom;)V", ref global::javax.crypto.KeyGenerator._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.KeyGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.KeyGenerator._m8) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.KeyGenerator.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.crypto.KeyGenerator._m9) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::javax.crypto.SecretKey generateKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.crypto.SecretKey>(this, global::javax.crypto.KeyGenerator.staticClass, "generateKey", "()Ljavax/crypto/SecretKey;", ref global::javax.crypto.KeyGenerator._m10) as javax.crypto.SecretKey;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected KeyGenerator(javax.crypto.KeyGeneratorSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyGenerator._m11.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyGenerator._m11 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "<init>", "(Ljavax/crypto/KeyGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static KeyGenerator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyGenerator"));
		}
	}
}
