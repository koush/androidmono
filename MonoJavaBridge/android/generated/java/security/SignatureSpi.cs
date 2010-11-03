namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.SignatureSpi_))]
	public abstract partial class SignatureSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SignatureSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.SignatureSpi.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.SignatureSpi._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineInitVerify(java.security.PublicKey arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual void engineInitSign(java.security.PrivateKey arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SignatureSpi.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V", ref global::java.security.SignatureSpi._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract void engineInitSign(java.security.PrivateKey arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract byte[] engineSign();
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual int engineSign(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.SignatureSpi.staticClass, "engineSign", "([BII)I", ref global::java.security.SignatureSpi._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract bool engineVerify(byte[] arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual bool engineVerify(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.SignatureSpi.staticClass, "engineVerify", "([BII)Z", ref global::java.security.SignatureSpi._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected abstract void engineUpdate(byte arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SignatureSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V", ref global::java.security.SignatureSpi._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual void engineSetParameter(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SignatureSpi.staticClass, "engineSetParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::java.security.SignatureSpi._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected abstract void engineSetParameter(java.lang.String arg0, java.lang.Object arg1);
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual global::java.security.AlgorithmParameters engineGetParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.SignatureSpi.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;", ref global::java.security.SignatureSpi._m13) as java.security.AlgorithmParameters;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected abstract global::java.lang.Object engineGetParameter(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m15;
		public SignatureSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SignatureSpi._m15.native == global::System.IntPtr.Zero)
				global::java.security.SignatureSpi._m15 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._m15);
			Init(@__env, handle);
		}
		static SignatureSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.SignatureSpi))]
	internal sealed partial class SignatureSpi_ : java.security.SignatureSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SignatureSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInitVerify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SignatureSpi_.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V", ref global::java.security.SignatureSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineInitSign(java.security.PrivateKey arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SignatureSpi_.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V", ref global::java.security.SignatureSpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override byte[] engineSign()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.SignatureSpi_.staticClass, "engineSign", "()[B", ref global::java.security.SignatureSpi_._m2) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override bool engineVerify(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.SignatureSpi_.staticClass, "engineVerify", "([B)Z", ref global::java.security.SignatureSpi_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SignatureSpi_.staticClass, "engineUpdate", "(B)V", ref global::java.security.SignatureSpi_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SignatureSpi_.staticClass, "engineUpdate", "([BII)V", ref global::java.security.SignatureSpi_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void engineSetParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SignatureSpi_.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.security.SignatureSpi_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override global::java.lang.Object engineGetParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.SignatureSpi_.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::java.security.SignatureSpi_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static SignatureSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureSpi"));
		}
	}
}
