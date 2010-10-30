namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Signature_))]
	public abstract partial class Signature : java.security.SignatureSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Signature(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23338;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._toString23338.native == global::System.IntPtr.Zero)
				global::java.security.Signature._toString23338 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Signature.staticClass, global::java.security.Signature._toString23338) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23339;
		public override global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._clone23339.native == global::System.IntPtr.Zero)
				global::java.security.Signature._clone23339 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._clone23339) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23340;
		public static global::java.security.Signature getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._getInstance23340.native == global::System.IntPtr.Zero)
				global::java.security.Signature._getInstance23340 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Signature;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._getInstance23340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Signature;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23341;
		public static global::java.security.Signature getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._getInstance23341.native == global::System.IntPtr.Zero)
				global::java.security.Signature._getInstance23341 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/Signature;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._getInstance23341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Signature;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23342;
		public static global::java.security.Signature getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._getInstance23342.native == global::System.IntPtr.Zero)
				global::java.security.Signature._getInstance23342 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/Signature;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._getInstance23342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Signature;
		}
		internal static global::MonoJavaBridge.MethodId _verify23343;
		public virtual bool verify(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._verify23343.native == global::System.IntPtr.Zero)
				global::java.security.Signature._verify23343 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "verify", "([B)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._verify23343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify23344;
		public virtual bool verify(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._verify23344.native == global::System.IntPtr.Zero)
				global::java.security.Signature._verify23344 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "verify", "([BII)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._verify23344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update23345;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._update23345.native == global::System.IntPtr.Zero)
				global::java.security.Signature._update23345 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "([BII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._update23345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update23346;
		public virtual void update(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._update23346.native == global::System.IntPtr.Zero)
				global::java.security.Signature._update23346 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "(Ljava/nio/ByteBuffer;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._update23346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update23347;
		public virtual void update(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._update23347.native == global::System.IntPtr.Zero)
				global::java.security.Signature._update23347 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "(B)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._update23347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update23348;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._update23348.native == global::System.IntPtr.Zero)
				global::java.security.Signature._update23348 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "([B)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._update23348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23349;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._getAlgorithm23349.native == global::System.IntPtr.Zero)
				global::java.security.Signature._getAlgorithm23349 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Signature.staticClass, global::java.security.Signature._getAlgorithm23349) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23350;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._getProvider23350.native == global::System.IntPtr.Zero)
				global::java.security.Signature._getProvider23350 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getProvider", "()Ljava/security/Provider;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._getProvider23350) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getParameters23351;
		public virtual global::java.security.AlgorithmParameters getParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._getParameters23351.native == global::System.IntPtr.Zero)
				global::java.security.Signature._getParameters23351 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getParameters", "()Ljava/security/AlgorithmParameters;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._getParameters23351) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _sign23352;
		public virtual int sign(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._sign23352.native == global::System.IntPtr.Zero)
				global::java.security.Signature._sign23352 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "sign", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._sign23352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sign23353;
		public virtual byte[] sign()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._sign23353.native == global::System.IntPtr.Zero)
				global::java.security.Signature._sign23353 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "sign", "()[B");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.Signature.staticClass, global::java.security.Signature._sign23353) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _initVerify23354;
		public virtual void initVerify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._initVerify23354.native == global::System.IntPtr.Zero)
				global::java.security.Signature._initVerify23354 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initVerify", "(Ljava/security/PublicKey;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._initVerify23354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initVerify23355;
		public virtual void initVerify(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._initVerify23355.native == global::System.IntPtr.Zero)
				global::java.security.Signature._initVerify23355 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initVerify", "(Ljava/security/cert/Certificate;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._initVerify23355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initSign23356;
		public virtual void initSign(java.security.PrivateKey arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._initSign23356.native == global::System.IntPtr.Zero)
				global::java.security.Signature._initSign23356 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._initSign23356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _initSign23357;
		public virtual void initSign(java.security.PrivateKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._initSign23357.native == global::System.IntPtr.Zero)
				global::java.security.Signature._initSign23357 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initSign", "(Ljava/security/PrivateKey;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._initSign23357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setParameter23358;
		public virtual void setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._setParameter23358.native == global::System.IntPtr.Zero)
				global::java.security.Signature._setParameter23358 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._setParameter23358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setParameter23359;
		public virtual void setParameter(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._setParameter23359.native == global::System.IntPtr.Zero)
				global::java.security.Signature._setParameter23359 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "setParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._setParameter23359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParameter23360;
		public virtual global::java.lang.Object getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._getParameter23360.native == global::System.IntPtr.Zero)
				global::java.security.Signature._getParameter23360 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Signature.staticClass, global::java.security.Signature._getParameter23360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _Signature23361;
		protected Signature(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature._Signature23361.native == global::System.IntPtr.Zero)
				global::java.security.Signature._Signature23361 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signature.staticClass, global::java.security.Signature._Signature23361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Signature()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signature.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signature"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Signature))]
	internal sealed partial class Signature_ : java.security.Signature
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Signature_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInitVerify23362;
		protected override void engineInitVerify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature_._engineInitVerify23362.native == global::System.IntPtr.Zero)
				global::java.security.Signature_._engineInitVerify23362 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineInitVerify23362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInitSign23363;
		protected override void engineInitSign(java.security.PrivateKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature_._engineInitSign23363.native == global::System.IntPtr.Zero)
				global::java.security.Signature_._engineInitSign23363 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineInitSign23363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSign23364;
		protected override byte[] engineSign()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature_._engineSign23364.native == global::System.IntPtr.Zero)
				global::java.security.Signature_._engineSign23364 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineSign", "()[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature_._engineSign23364)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineVerify23365;
		protected override bool engineVerify(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature_._engineVerify23365.native == global::System.IntPtr.Zero)
				global::java.security.Signature_._engineVerify23365 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineVerify", "([B)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Signature_._engineVerify23365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23366;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature_._engineUpdate23366.native == global::System.IntPtr.Zero)
				global::java.security.Signature_._engineUpdate23366 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineUpdate", "(B)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineUpdate23366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23367;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature_._engineUpdate23367.native == global::System.IntPtr.Zero)
				global::java.security.Signature_._engineUpdate23367 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineUpdate", "([BII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineUpdate23367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetParameter23368;
		protected override void engineSetParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature_._engineSetParameter23368.native == global::System.IntPtr.Zero)
				global::java.security.Signature_._engineSetParameter23368 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineSetParameter23368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameter23369;
		protected override global::java.lang.Object engineGetParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Signature_._engineGetParameter23369.native == global::System.IntPtr.Zero)
				global::java.security.Signature_._engineGetParameter23369 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature_._engineGetParameter23369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		static Signature_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signature_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signature"));
		}
		internal static void InitJNI()
		{
		}
	}
}
