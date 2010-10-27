namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecretKeyFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecretKeyFactory()
		{
			InitJNI();
		}
		protected SecretKeyFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28717;
		public static global::javax.crypto.SecretKeyFactory getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._getInstance28717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKeyFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28718;
		public static global::javax.crypto.SecretKeyFactory getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._getInstance28718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.SecretKeyFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28719;
		public static global::javax.crypto.SecretKeyFactory getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._getInstance28719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.SecretKeyFactory;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28720;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory._getAlgorithm28720)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._getAlgorithm28720)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider28721;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory._getProvider28721)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._getProvider28721)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getKeySpec28722;
		public virtual global::java.security.spec.KeySpec getKeySpec(javax.crypto.SecretKey arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory._getKeySpec28722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._getKeySpec28722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _translateKey28723;
		public virtual global::javax.crypto.SecretKey translateKey(javax.crypto.SecretKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory._translateKey28723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._translateKey28723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
		}
		internal static global::MonoJavaBridge.MethodId _generateSecret28724;
		public virtual global::javax.crypto.SecretKey generateSecret(java.security.spec.KeySpec arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory._generateSecret28724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._generateSecret28724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
		}
		internal static global::MonoJavaBridge.MethodId _SecretKeyFactory28725;
		protected SecretKeyFactory(javax.crypto.SecretKeyFactorySpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.SecretKeyFactory.staticClass, global::javax.crypto.SecretKeyFactory._SecretKeyFactory28725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKeyFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKeyFactory"));
			global::javax.crypto.SecretKeyFactory._getInstance28717 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;");
			global::javax.crypto.SecretKeyFactory._getInstance28718 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;");
			global::javax.crypto.SecretKeyFactory._getInstance28719 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/SecretKeyFactory;");
			global::javax.crypto.SecretKeyFactory._getAlgorithm28720 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.SecretKeyFactory._getProvider28721 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.SecretKeyFactory._getKeySpec28722 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "getKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;");
			global::javax.crypto.SecretKeyFactory._translateKey28723 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "translateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;");
			global::javax.crypto.SecretKeyFactory._generateSecret28724 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "generateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;");
			global::javax.crypto.SecretKeyFactory._SecretKeyFactory28725 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactory.staticClass, "<init>", "(Ljavax/crypto/SecretKeyFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
