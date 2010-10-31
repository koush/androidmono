namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecretKeyFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecretKeyFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.crypto.SecretKeyFactory getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SecretKeyFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.crypto.SecretKeyFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKeyFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.crypto.SecretKeyFactory getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SecretKeyFactory._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.SecretKeyFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.SecretKeyFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.crypto.SecretKeyFactory getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SecretKeyFactory._m2.native == global::System.IntPtr.Zero)
				global::javax.crypto.SecretKeyFactory._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/SecretKeyFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.SecretKeyFactory;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.SecretKeyFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.SecretKeyFactory._m3) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.SecretKeyFactory.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.crypto.SecretKeyFactory._m4) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.security.spec.KeySpec getKeySpec(javax.crypto.SecretKey arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.KeySpec>(this, global::javax.crypto.SecretKeyFactory.staticClass, "getKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", ref global::javax.crypto.SecretKeyFactory._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.spec.KeySpec;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::javax.crypto.SecretKey translateKey(javax.crypto.SecretKey arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.crypto.SecretKey>(this, global::javax.crypto.SecretKeyFactory.staticClass, "translateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;", ref global::javax.crypto.SecretKeyFactory._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.crypto.SecretKey;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::javax.crypto.SecretKey generateSecret(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.crypto.SecretKey>(this, global::javax.crypto.SecretKeyFactory.staticClass, "generateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;", ref global::javax.crypto.SecretKeyFactory._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.crypto.SecretKey;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected SecretKeyFactory(javax.crypto.SecretKeyFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SecretKeyFactory._m8.native == global::System.IntPtr.Zero)
				global::javax.crypto.SecretKeyFactory._m8 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "<init>", "(Ljavax/crypto/SecretKeyFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SecretKeyFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKeyFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKeyFactory"));
		}
	}
}
