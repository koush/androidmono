namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.security.KeyFactory getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyFactory._m0.native == global::System.IntPtr.Zero)
				global::java.security.KeyFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.security.KeyFactory getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyFactory._m1.native == global::System.IntPtr.Zero)
				global::java.security.KeyFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.KeyFactory getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyFactory._m2.native == global::System.IntPtr.Zero)
				global::java.security.KeyFactory._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyFactory;
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.KeyFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.KeyFactory._m3) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyFactory.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.KeyFactory._m4) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.security.PublicKey generatePublic(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.KeyFactory.staticClass, "generatePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", ref global::java.security.KeyFactory._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PublicKey;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.security.PrivateKey generatePrivate(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PrivateKey>(this, global::java.security.KeyFactory.staticClass, "generatePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", ref global::java.security.KeyFactory._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PrivateKey;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.security.spec.KeySpec getKeySpec(java.security.Key arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.KeySpec>(this, global::java.security.KeyFactory.staticClass, "getKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", ref global::java.security.KeyFactory._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.spec.KeySpec;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.security.Key translateKey(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::java.security.KeyFactory.staticClass, "translateKey", "(Ljava/security/Key;)Ljava/security/Key;", ref global::java.security.KeyFactory._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.Key;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected KeyFactory(java.security.KeyFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyFactory._m9.native == global::System.IntPtr.Zero)
				global::java.security.KeyFactory._m9 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "<init>", "(Ljava/security/KeyFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static KeyFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyFactory"));
		}
	}
}
