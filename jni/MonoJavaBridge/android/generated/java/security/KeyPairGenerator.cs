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
		internal static global::MonoJavaBridge.MethodId _getInstance22921;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getInstance22921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyPairGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22922;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getInstance22922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyPairGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22923;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getInstance22923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyPairGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _initialize22924;
		public virtual void initialize(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize22924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize22924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initialize22925;
		public override void initialize(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize22925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize22925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _initialize22926;
		public virtual void initialize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize22926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize22926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initialize22927;
		public override void initialize(int arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator._initialize22927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._initialize22927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22928;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._getAlgorithm22928)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getAlgorithm22928)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22929;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._getProvider22929)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._getProvider22929)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _genKeyPair22930;
		public virtual global::java.security.KeyPair genKeyPair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._genKeyPair22930)) as java.security.KeyPair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._genKeyPair22930)) as java.security.KeyPair;
		}
		internal static global::MonoJavaBridge.MethodId _generateKeyPair22931;
		public override global::java.security.KeyPair generateKeyPair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator._generateKeyPair22931)) as java.security.KeyPair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._generateKeyPair22931)) as java.security.KeyPair;
		}
		internal static global::MonoJavaBridge.MethodId _KeyPairGenerator22932;
		protected KeyPairGenerator(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._KeyPairGenerator22932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGenerator"));
			global::java.security.KeyPairGenerator._getInstance22921 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyPairGenerator;");
			global::java.security.KeyPairGenerator._getInstance22922 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyPairGenerator;");
			global::java.security.KeyPairGenerator._getInstance22923 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyPairGenerator;");
			global::java.security.KeyPairGenerator._initialize22924 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.KeyPairGenerator._initialize22925 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.KeyPairGenerator._initialize22926 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(I)V");
			global::java.security.KeyPairGenerator._initialize22927 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "initialize", "(ILjava/security/SecureRandom;)V");
			global::java.security.KeyPairGenerator._getAlgorithm22928 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.KeyPairGenerator._getProvider22929 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.KeyPairGenerator._genKeyPair22930 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "genKeyPair", "()Ljava/security/KeyPair;");
			global::java.security.KeyPairGenerator._generateKeyPair22931 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "generateKeyPair", "()Ljava/security/KeyPair;");
			global::java.security.KeyPairGenerator._KeyPairGenerator22932 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "<init>", "(Ljava/lang/String;)V");
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
