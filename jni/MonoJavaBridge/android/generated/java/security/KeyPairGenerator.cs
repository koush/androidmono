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
		internal static global::MonoJavaBridge.MethodId _getInstance17322;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getInstance17322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyPairGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17323;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getInstance17323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyPairGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17324;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getInstance17324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyPairGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _initialize17325;
		public virtual void initialize(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize17325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize17325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initialize17326;
		public override void initialize(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize17326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize17326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _initialize17327;
		public virtual void initialize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize17327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize17327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initialize17328;
		public override void initialize(int arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize17328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize17328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm17329;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._getAlgorithm17329)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getAlgorithm17329)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider17330;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._getProvider17330)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getProvider17330)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _genKeyPair17331;
		public virtual global::java.security.KeyPair genKeyPair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._genKeyPair17331)) as java.security.KeyPair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._genKeyPair17331)) as java.security.KeyPair;
		}
		internal static global::MonoJavaBridge.MethodId _generateKeyPair17332;
		public override global::java.security.KeyPair generateKeyPair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._generateKeyPair17332)) as java.security.KeyPair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._generateKeyPair17332)) as java.security.KeyPair;
		}
		internal static global::MonoJavaBridge.MethodId _KeyPairGenerator17333;
		protected KeyPairGenerator(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._KeyPairGenerator17333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGenerator"));
			global::java.security.KeyPairGenerator._getInstance17322 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyPairGenerator;");
			global::java.security.KeyPairGenerator._getInstance17323 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyPairGenerator;");
			global::java.security.KeyPairGenerator._getInstance17324 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyPairGenerator;");
			global::java.security.KeyPairGenerator._initialize17325 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.KeyPairGenerator._initialize17326 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.KeyPairGenerator._initialize17327 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(I)V");
			global::java.security.KeyPairGenerator._initialize17328 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(ILjava/security/SecureRandom;)V");
			global::java.security.KeyPairGenerator._getAlgorithm17329 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.KeyPairGenerator._getProvider17330 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.KeyPairGenerator._genKeyPair17331 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "genKeyPair", "()Ljava/security/KeyPair;");
			global::java.security.KeyPairGenerator._generateKeyPair17332 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "generateKeyPair", "()Ljava/security/KeyPair;");
			global::java.security.KeyPairGenerator._KeyPairGenerator17333 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyPairGenerator))]
	public sealed partial class KeyPairGenerator_ : java.security.KeyPairGenerator
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
