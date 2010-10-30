namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecureRandom : java.util.Random
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecureRandom(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _next23304;
		protected sealed override int next(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._next23304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23305;
		public static global::java.security.SecureRandom getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getInstance23305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.SecureRandom;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23306;
		public static global::java.security.SecureRandom getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getInstance23306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.SecureRandom;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23307;
		public static global::java.security.SecureRandom getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getInstance23307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.SecureRandom;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23308;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getAlgorithm23308)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23309;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getProvider23309)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _nextBytes23310;
		public override void nextBytes(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._nextBytes23310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeed23311;
		public override void setSeed(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._setSeed23311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeed23312;
		public virtual void setSeed(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._setSeed23312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSeed23313;
		public static byte[] getSeed(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getSeed23313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _generateSeed23314;
		public virtual byte[] generateSeed(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._generateSeed23314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _SecureRandom23315;
		public SecureRandom(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._SecureRandom23315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SecureRandom23316;
		public SecureRandom() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._SecureRandom23316);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SecureRandom23317;
		protected SecureRandom(java.security.SecureRandomSpi arg0, java.security.Provider arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._SecureRandom23317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SecureRandom()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SecureRandom.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SecureRandom"));
			global::java.security.SecureRandom._next23304 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "next", "(I)I");
			global::java.security.SecureRandom._getInstance23305 = @__env.GetStaticMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/SecureRandom;");
			global::java.security.SecureRandom._getInstance23306 = @__env.GetStaticMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/SecureRandom;");
			global::java.security.SecureRandom._getInstance23307 = @__env.GetStaticMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/SecureRandom;");
			global::java.security.SecureRandom._getAlgorithm23308 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.SecureRandom._getProvider23309 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.SecureRandom._nextBytes23310 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "nextBytes", "([B)V");
			global::java.security.SecureRandom._setSeed23311 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "setSeed", "(J)V");
			global::java.security.SecureRandom._setSeed23312 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "setSeed", "([B)V");
			global::java.security.SecureRandom._getSeed23313 = @__env.GetStaticMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getSeed", "(I)[B");
			global::java.security.SecureRandom._generateSeed23314 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "generateSeed", "(I)[B");
			global::java.security.SecureRandom._SecureRandom23315 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "<init>", "([B)V");
			global::java.security.SecureRandom._SecureRandom23316 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "<init>", "()V");
			global::java.security.SecureRandom._SecureRandom23317 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "<init>", "(Ljava/security/SecureRandomSpi;Ljava/security/Provider;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
