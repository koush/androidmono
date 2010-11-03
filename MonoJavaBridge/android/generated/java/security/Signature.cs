namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Signature_))]
	public abstract partial class Signature : java.security.SignatureSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Signature(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Signature.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.Signature._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Signature.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.Signature._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.Signature getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._m2.native == global::System.IntPtr.Zero)
				global::java.security.Signature._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Signature;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Signature;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.security.Signature getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._m3.native == global::System.IntPtr.Zero)
				global::java.security.Signature._m3 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/Signature;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Signature;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.security.Signature getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._m4.native == global::System.IntPtr.Zero)
				global::java.security.Signature._m4 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/Signature;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Signature;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool verify(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Signature.staticClass, "verify", "([B)Z", ref global::java.security.Signature._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool verify(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Signature.staticClass, "verify", "([BII)Z", ref global::java.security.Signature._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "update", "([BII)V", ref global::java.security.Signature._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void update(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "update", "(Ljava/nio/ByteBuffer;)V", ref global::java.security.Signature._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void update(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "update", "(B)V", ref global::java.security.Signature._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "update", "([B)V", ref global::java.security.Signature._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Signature.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.Signature._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Signature.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.Signature._m12) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.security.AlgorithmParameters getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Signature.staticClass, "getParameters", "()Ljava/security/AlgorithmParameters;", ref global::java.security.Signature._m13) as java.security.AlgorithmParameters;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int sign(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.Signature.staticClass, "sign", "([BII)I", ref global::java.security.Signature._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual byte[] sign()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.Signature.staticClass, "sign", "()[B", ref global::java.security.Signature._m15) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void initVerify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "initVerify", "(Ljava/security/PublicKey;)V", ref global::java.security.Signature._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void initVerify(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "initVerify", "(Ljava/security/cert/Certificate;)V", ref global::java.security.Signature._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void initSign(java.security.PrivateKey arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "initSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V", ref global::java.security.Signature._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void initSign(java.security.PrivateKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "initSign", "(Ljava/security/PrivateKey;)V", ref global::java.security.Signature._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.security.Signature._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setParameter(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, "setParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::java.security.Signature._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.lang.Object getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Signature.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.security.Signature._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected Signature(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._m23.native == global::System.IntPtr.Zero)
				global::java.security.Signature._m23 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signature.staticClass, global::java.security.Signature._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Signature()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signature.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signature"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Signature))]
	internal sealed partial class Signature_ : java.security.Signature
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Signature_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInitVerify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature_.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V", ref global::java.security.Signature_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineInitSign(java.security.PrivateKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature_.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V", ref global::java.security.Signature_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override byte[] engineSign()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.Signature_.staticClass, "engineSign", "()[B", ref global::java.security.Signature_._m2) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override bool engineVerify(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Signature_.staticClass, "engineVerify", "([B)Z", ref global::java.security.Signature_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature_.staticClass, "engineUpdate", "(B)V", ref global::java.security.Signature_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature_.staticClass, "engineUpdate", "([BII)V", ref global::java.security.Signature_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void engineSetParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature_.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.security.Signature_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override global::java.lang.Object engineGetParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Signature_.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.security.Signature_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static Signature_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signature_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signature"));
		}
	}
}
