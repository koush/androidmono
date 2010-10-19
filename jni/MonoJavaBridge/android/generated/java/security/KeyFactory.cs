namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyFactory()
		{
			InitJNI();
		}
		protected KeyFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17296;
		public static global::java.security.KeyFactory getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getInstance17296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17297;
		public static global::java.security.KeyFactory getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getInstance17297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17298;
		public static global::java.security.KeyFactory getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getInstance17298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyFactory;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm17299;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactory._getAlgorithm17299)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getAlgorithm17299)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider17300;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactory._getProvider17300)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getProvider17300)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generatePublic17301;
		public virtual global::java.security.PublicKey generatePublic(java.security.spec.KeySpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactory._generatePublic17301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._generatePublic17301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PublicKey;
		}
		internal static global::MonoJavaBridge.MethodId _generatePrivate17302;
		public virtual global::java.security.PrivateKey generatePrivate(java.security.spec.KeySpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactory._generatePrivate17302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PrivateKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._generatePrivate17302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _getKeySpec17303;
		public virtual global::java.security.spec.KeySpec getKeySpec(java.security.Key arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactory._getKeySpec17303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._getKeySpec17303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _translateKey17304;
		public virtual global::java.security.Key translateKey(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactory._translateKey17304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactory.staticClass, global::java.security.KeyFactory._translateKey17304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _KeyFactory17305;
		protected KeyFactory(java.security.KeyFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyFactory.staticClass, global::java.security.KeyFactory._KeyFactory17305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyFactory"));
			global::java.security.KeyFactory._getInstance17296 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyFactory;");
			global::java.security.KeyFactory._getInstance17297 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyFactory;");
			global::java.security.KeyFactory._getInstance17298 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyFactory;");
			global::java.security.KeyFactory._getAlgorithm17299 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.KeyFactory._getProvider17300 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.KeyFactory._generatePublic17301 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "generatePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;");
			global::java.security.KeyFactory._generatePrivate17302 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "generatePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;");
			global::java.security.KeyFactory._getKeySpec17303 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "getKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;");
			global::java.security.KeyFactory._translateKey17304 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "translateKey", "(Ljava/security/Key;)Ljava/security/Key;");
			global::java.security.KeyFactory._KeyFactory17305 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactory.staticClass, "<init>", "(Ljava/security/KeyFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
