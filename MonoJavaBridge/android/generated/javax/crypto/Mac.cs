namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Mac : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Mac(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Mac.staticClass, "clone", "()Ljava/lang/Object;", ref global::javax.crypto.Mac._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Mac._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.Mac._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Mac;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Mac;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Mac._m2.native == global::System.IntPtr.Zero)
				global::javax.crypto.Mac._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Mac;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Mac;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Mac._m3.native == global::System.IntPtr.Zero)
				global::javax.crypto.Mac._m3 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Mac;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.Mac;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void init(java.security.Key arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "init", "(Ljava/security/Key;)V", ref global::javax.crypto.Mac._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::javax.crypto.Mac._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "reset", "()V", ref global::javax.crypto.Mac._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void update(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "update", "(B)V", ref global::javax.crypto.Mac._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "update", "([B)V", ref global::javax.crypto.Mac._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "update", "([BII)V", ref global::javax.crypto.Mac._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void update(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "update", "(Ljava/nio/ByteBuffer;)V", ref global::javax.crypto.Mac._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.Mac.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.Mac._m11) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Mac.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.crypto.Mac._m12) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual byte[] doFinal(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Mac.staticClass, "doFinal", "([B)[B", ref global::javax.crypto.Mac._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual byte[] doFinal()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Mac.staticClass, "doFinal", "()[B", ref global::javax.crypto.Mac._m14) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void doFinal(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "doFinal", "([BI)V", ref global::javax.crypto.Mac._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int MacLength
		{
			get
			{
				return getMacLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getMacLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Mac.staticClass, "getMacLength", "()I", ref global::javax.crypto.Mac._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected Mac(javax.crypto.MacSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Mac._m17.native == global::System.IntPtr.Zero)
				global::javax.crypto.Mac._m17 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "<init>", "(Ljavax/crypto/MacSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Mac()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.Mac.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/Mac"));
		}
		internal static void InitJNI()
		{
		}
	}
}
