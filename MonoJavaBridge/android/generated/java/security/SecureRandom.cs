namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecureRandom : java.util.Random
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecureRandom(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected sealed override int next(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.SecureRandom.staticClass, "next", "(I)I", ref global::java.security.SecureRandom._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.security.SecureRandom getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecureRandom._m1.native == global::System.IntPtr.Zero)
				global::java.security.SecureRandom._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/SecureRandom;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.SecureRandom;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.SecureRandom getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecureRandom._m2.native == global::System.IntPtr.Zero)
				global::java.security.SecureRandom._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/SecureRandom;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.SecureRandom;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.security.SecureRandom getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecureRandom._m3.native == global::System.IntPtr.Zero)
				global::java.security.SecureRandom._m3 = @__env.GetStaticMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/SecureRandom;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.SecureRandom;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.SecureRandom.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.SecureRandom._m4) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.SecureRandom.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.SecureRandom._m5) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void nextBytes(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SecureRandom.staticClass, "nextBytes", "([B)V", ref global::java.security.SecureRandom._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setSeed(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SecureRandom.staticClass, "setSeed", "(J)V", ref global::java.security.SecureRandom._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setSeed(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SecureRandom.staticClass, "setSeed", "([B)V", ref global::java.security.SecureRandom._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static byte[] getSeed(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecureRandom._m9.native == global::System.IntPtr.Zero)
				global::java.security.SecureRandom._m9 = @__env.GetStaticMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "getSeed", "(I)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual byte[] generateSeed(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.SecureRandom.staticClass, "generateSeed", "(I)[B", ref global::java.security.SecureRandom._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public SecureRandom(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecureRandom._m11.native == global::System.IntPtr.Zero)
				global::java.security.SecureRandom._m11 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SecureRandom() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecureRandom._m12.native == global::System.IntPtr.Zero)
				global::java.security.SecureRandom._m12 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._m12);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected SecureRandom(java.security.SecureRandomSpi arg0, java.security.Provider arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecureRandom._m13.native == global::System.IntPtr.Zero)
				global::java.security.SecureRandom._m13 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandom.staticClass, "<init>", "(Ljava/security/SecureRandomSpi;Ljava/security/Provider;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SecureRandom()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SecureRandom.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SecureRandom"));
		}
	}
}
