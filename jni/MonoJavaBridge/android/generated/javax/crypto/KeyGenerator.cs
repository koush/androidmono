namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyGenerator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyGenerator()
		{
			InitJNI();
		}
		protected KeyGenerator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22636;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getInstance22636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22637;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getInstance22637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.KeyGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22638;
		public static global::javax.crypto.KeyGenerator getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getInstance22638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.KeyGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _init22639;
		public virtual void init(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init22639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init22639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22640;
		public virtual void init(int arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init22640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init22640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init22641;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init22641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init22641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22642;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init22642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init22642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init22643;
		public virtual void init(java.security.SecureRandom arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._init22643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._init22643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22644;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._getAlgorithm22644)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getAlgorithm22644)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22645;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._getProvider22645)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._getProvider22645)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generateKey22646;
		public virtual global::javax.crypto.SecretKey generateKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator._generateKey22646)) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._generateKey22646)) as javax.crypto.SecretKey;
		}
		internal static global::MonoJavaBridge.MethodId _KeyGenerator22647;
		protected KeyGenerator(javax.crypto.KeyGeneratorSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyGenerator.staticClass, global::javax.crypto.KeyGenerator._KeyGenerator22647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyGenerator"));
			global::javax.crypto.KeyGenerator._getInstance22636 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/KeyGenerator;");
			global::javax.crypto.KeyGenerator._getInstance22637 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyGenerator;");
			global::javax.crypto.KeyGenerator._getInstance22638 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/KeyGenerator;");
			global::javax.crypto.KeyGenerator._init22639 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(I)V");
			global::javax.crypto.KeyGenerator._init22640 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(ILjava/security/SecureRandom;)V");
			global::javax.crypto.KeyGenerator._init22641 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.KeyGenerator._init22642 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGenerator._init22643 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "init", "(Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGenerator._getAlgorithm22644 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.KeyGenerator._getProvider22645 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.KeyGenerator._generateKey22646 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "generateKey", "()Ljavax/crypto/SecretKey;");
			global::javax.crypto.KeyGenerator._KeyGenerator22647 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGenerator.staticClass, "<init>", "(Ljavax/crypto/KeyGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
