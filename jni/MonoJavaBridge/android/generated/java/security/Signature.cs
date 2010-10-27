namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Signature_))]
	public abstract partial class Signature : java.security.SignatureSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Signature()
		{
			InitJNI();
		}
		protected Signature(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString23337;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._toString23337)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._toString23337)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23338;
		public override global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._clone23338)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._clone23338)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23339;
		public static global::java.security.Signature getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._getInstance23339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Signature;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23340;
		public static global::java.security.Signature getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._getInstance23340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Signature;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23341;
		public static global::java.security.Signature getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._getInstance23341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Signature;
		}
		internal static global::MonoJavaBridge.MethodId _verify23342;
		public virtual bool verify(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Signature._verify23342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._verify23342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify23343;
		public virtual bool verify(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Signature._verify23343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._verify23343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update23344;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._update23344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._update23344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update23345;
		public virtual void update(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._update23345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._update23345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update23346;
		public virtual void update(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._update23346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._update23346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update23347;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._update23347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._update23347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23348;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._getAlgorithm23348)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._getAlgorithm23348)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23349;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._getProvider23349)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._getProvider23349)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getParameters23350;
		public virtual global::java.security.AlgorithmParameters getParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._getParameters23350)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._getParameters23350)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _sign23351;
		public virtual int sign(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.Signature._sign23351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._sign23351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sign23352;
		public virtual byte[] sign()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._sign23352)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._sign23352)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _initVerify23353;
		public virtual void initVerify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._initVerify23353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._initVerify23353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initVerify23354;
		public virtual void initVerify(java.security.cert.Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._initVerify23354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._initVerify23354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initSign23355;
		public virtual void initSign(java.security.PrivateKey arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._initSign23355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._initSign23355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _initSign23356;
		public virtual void initSign(java.security.PrivateKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._initSign23356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._initSign23356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setParameter23357;
		public virtual void setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._setParameter23357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._setParameter23357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setParameter23358;
		public virtual void setParameter(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._setParameter23358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._setParameter23358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParameter23359;
		public virtual global::java.lang.Object getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._getParameter23359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._getParameter23359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _Signature23360;
		protected Signature(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signature.staticClass, global::java.security.Signature._Signature23360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signature.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signature"));
			global::java.security.Signature._toString23337 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Signature._clone23338 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.Signature._getInstance23339 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Signature;");
			global::java.security.Signature._getInstance23340 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/Signature;");
			global::java.security.Signature._getInstance23341 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/Signature;");
			global::java.security.Signature._verify23342 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "verify", "([B)Z");
			global::java.security.Signature._verify23343 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "verify", "([BII)Z");
			global::java.security.Signature._update23344 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "([BII)V");
			global::java.security.Signature._update23345 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.Signature._update23346 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "(B)V");
			global::java.security.Signature._update23347 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "([B)V");
			global::java.security.Signature._getAlgorithm23348 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.Signature._getProvider23349 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.Signature._getParameters23350 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getParameters", "()Ljava/security/AlgorithmParameters;");
			global::java.security.Signature._sign23351 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "sign", "([BII)I");
			global::java.security.Signature._sign23352 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "sign", "()[B");
			global::java.security.Signature._initVerify23353 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.Signature._initVerify23354 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initVerify", "(Ljava/security/cert/Certificate;)V");
			global::java.security.Signature._initSign23355 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V");
			global::java.security.Signature._initSign23356 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.Signature._setParameter23357 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.Signature._setParameter23358 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "setParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.Signature._getParameter23359 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.security.Signature._Signature23360 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Signature))]
	internal sealed partial class Signature_ : java.security.Signature
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Signature_()
		{
			InitJNI();
		}
		internal Signature_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInitVerify23361;
		protected override void engineInitVerify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineInitVerify23361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineInitVerify23361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInitSign23362;
		protected override void engineInitSign(java.security.PrivateKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineInitSign23362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineInitSign23362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSign23363;
		protected override byte[] engineSign()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature_._engineSign23363)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineSign23363)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineVerify23364;
		protected override bool engineVerify(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Signature_._engineVerify23364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineVerify23364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23365;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineUpdate23365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineUpdate23365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23366;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineUpdate23366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineUpdate23366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetParameter23367;
		protected override void engineSetParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineSetParameter23367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineSetParameter23367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameter23368;
		protected override global::java.lang.Object engineGetParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature_._engineGetParameter23368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineGetParameter23368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signature_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signature"));
			global::java.security.Signature_._engineInitVerify23361 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.Signature_._engineInitSign23362 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.Signature_._engineSign23363 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineSign", "()[B");
			global::java.security.Signature_._engineVerify23364 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineVerify", "([B)Z");
			global::java.security.Signature_._engineUpdate23365 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineUpdate", "(B)V");
			global::java.security.Signature_._engineUpdate23366 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.Signature_._engineSetParameter23367 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.Signature_._engineGetParameter23368 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
