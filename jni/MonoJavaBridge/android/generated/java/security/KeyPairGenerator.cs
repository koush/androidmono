namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyPairGenerator_))]
	public abstract partial class KeyPairGenerator : java.security.KeyPairGeneratorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyPairGenerator()
		{
			InitJNI();
		}
		protected KeyPairGenerator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23039;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getInstance23039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyPairGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23040;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getInstance23040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyPairGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23041;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getInstance23041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyPairGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _initialize23042;
		public virtual void initialize(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize23042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize23042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initialize23043;
		public override void initialize(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize23043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize23043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _initialize23044;
		public virtual void initialize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize23044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize23044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initialize23045;
		public override void initialize(int arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize23045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize23045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23046;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._getAlgorithm23046)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getAlgorithm23046)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23047;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._getProvider23047)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getProvider23047)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _genKeyPair23048;
		public virtual global::java.security.KeyPair genKeyPair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyPair>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._genKeyPair23048)) as java.security.KeyPair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyPair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._genKeyPair23048)) as java.security.KeyPair;
		}
		internal static global::MonoJavaBridge.MethodId _generateKeyPair23049;
		public override global::java.security.KeyPair generateKeyPair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyPair>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._generateKeyPair23049)) as java.security.KeyPair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyPair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._generateKeyPair23049)) as java.security.KeyPair;
		}
		internal static global::MonoJavaBridge.MethodId _KeyPairGenerator23050;
		protected KeyPairGenerator(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._KeyPairGenerator23050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGenerator"));
			global::java.security.KeyPairGenerator._getInstance23039 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyPairGenerator;");
			global::java.security.KeyPairGenerator._getInstance23040 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyPairGenerator;");
			global::java.security.KeyPairGenerator._getInstance23041 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyPairGenerator;");
			global::java.security.KeyPairGenerator._initialize23042 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.KeyPairGenerator._initialize23043 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.KeyPairGenerator._initialize23044 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(I)V");
			global::java.security.KeyPairGenerator._initialize23045 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(ILjava/security/SecureRandom;)V");
			global::java.security.KeyPairGenerator._getAlgorithm23046 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.KeyPairGenerator._getProvider23047 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.KeyPairGenerator._genKeyPair23048 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "genKeyPair", "()Ljava/security/KeyPair;");
			global::java.security.KeyPairGenerator._generateKeyPair23049 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "generateKeyPair", "()Ljava/security/KeyPair;");
			global::java.security.KeyPairGenerator._KeyPairGenerator23050 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyPairGenerator))]
	internal sealed partial class KeyPairGenerator_ : java.security.KeyPairGenerator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyPairGenerator_()
		{
			InitJNI();
		}
		internal KeyPairGenerator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGenerator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGenerator"));
		}
	}
}
