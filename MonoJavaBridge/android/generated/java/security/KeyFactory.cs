namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23014;
		public static global::java.security.KeyFactory getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getInstance23014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23015;
		public static global::java.security.KeyFactory getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getInstance23015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23016;
		public static global::java.security.KeyFactory getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getInstance23016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyFactory;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23017;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getAlgorithm23017)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23018;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getProvider23018)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generatePublic23019;
		public virtual global::java.security.PublicKey generatePublic(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._generatePublic23019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PublicKey;
		}
		internal static global::MonoJavaBridge.MethodId _generatePrivate23020;
		public virtual global::java.security.PrivateKey generatePrivate(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._generatePrivate23020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _getKeySpec23021;
		public virtual global::java.security.spec.KeySpec getKeySpec(java.security.Key arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getKeySpec23021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _translateKey23022;
		public virtual global::java.security.Key translateKey(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._translateKey23022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _KeyFactory23023;
		protected KeyFactory(java.security.KeyFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._KeyFactory23023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static KeyFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyFactory"));
			global::java.security.KeyFactory._getInstance23014 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyFactory;");
			global::java.security.KeyFactory._getInstance23015 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyFactory;");
			global::java.security.KeyFactory._getInstance23016 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyFactory;");
			global::java.security.KeyFactory._getAlgorithm23017 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.KeyFactory._getProvider23018 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.KeyFactory._generatePublic23019 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "generatePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;");
			global::java.security.KeyFactory._generatePrivate23020 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "generatePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;");
			global::java.security.KeyFactory._getKeySpec23021 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;");
			global::java.security.KeyFactory._translateKey23022 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "translateKey", "(Ljava/security/Key;)Ljava/security/Key;");
			global::java.security.KeyFactory._KeyFactory23023 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "<init>", "(Ljava/security/KeyFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
