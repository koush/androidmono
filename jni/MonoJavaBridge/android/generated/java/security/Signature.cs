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
		internal static global::MonoJavaBridge.MethodId _toString17618;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._toString17618)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._toString17618)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone17619;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._clone17619)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._clone17619)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17620;
		public static global::java.security.Signature getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._getInstance17620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Signature;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17621;
		public static global::java.security.Signature getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._getInstance17621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Signature;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17622;
		public static global::java.security.Signature getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.Signature.staticClass, global::java.security.Signature._getInstance17622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Signature;
		}
		internal static global::MonoJavaBridge.MethodId _verify17623;
		public virtual bool verify(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Signature._verify17623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._verify17623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify17624;
		public virtual bool verify(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Signature._verify17624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._verify17624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update17625;
		public virtual void update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._update17625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._update17625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update17626;
		public virtual void update(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._update17626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._update17626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update17627;
		public virtual void update(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._update17627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._update17627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update17628;
		public virtual void update(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._update17628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._update17628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm17629;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._getAlgorithm17629)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._getAlgorithm17629)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProvider17630;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._getProvider17630)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._getProvider17630)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getParameters17631;
		public virtual global::java.security.AlgorithmParameters getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._getParameters17631)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._getParameters17631)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _sign17632;
		public virtual int sign(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.Signature._sign17632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._sign17632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sign17633;
		public virtual byte[] sign() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._sign17633)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._sign17633)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _initVerify17634;
		public virtual void initVerify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._initVerify17634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._initVerify17634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initVerify17635;
		public virtual void initVerify(java.security.cert.Certificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._initVerify17635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._initVerify17635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _initSign17636;
		public virtual void initSign(java.security.PrivateKey arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._initSign17636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._initSign17636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _initSign17637;
		public virtual void initSign(java.security.PrivateKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._initSign17637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._initSign17637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setParameter17638;
		public virtual void setParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._setParameter17638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._setParameter17638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setParameter17639;
		public virtual void setParameter(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature._setParameter17639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._setParameter17639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParameter17640;
		public virtual global::java.lang.Object getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature._getParameter17640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature.staticClass, global::java.security.Signature._getParameter17640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _Signature17641;
		protected Signature(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Signature.staticClass, global::java.security.Signature._Signature17641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signature.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signature"));
			global::java.security.Signature._toString17618 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Signature._clone17619 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.Signature._getInstance17620 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Signature;");
			global::java.security.Signature._getInstance17621 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/Signature;");
			global::java.security.Signature._getInstance17622 = @__env.GetStaticMethodIDNoThrow(global::java.security.Signature.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/Signature;");
			global::java.security.Signature._verify17623 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "verify", "([B)Z");
			global::java.security.Signature._verify17624 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "verify", "([BII)Z");
			global::java.security.Signature._update17625 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "([BII)V");
			global::java.security.Signature._update17626 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.Signature._update17627 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "(B)V");
			global::java.security.Signature._update17628 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "update", "([B)V");
			global::java.security.Signature._getAlgorithm17629 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.Signature._getProvider17630 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.Signature._getParameters17631 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getParameters", "()Ljava/security/AlgorithmParameters;");
			global::java.security.Signature._sign17632 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "sign", "([BII)I");
			global::java.security.Signature._sign17633 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "sign", "()[B");
			global::java.security.Signature._initVerify17634 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.Signature._initVerify17635 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initVerify", "(Ljava/security/cert/Certificate;)V");
			global::java.security.Signature._initSign17636 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V");
			global::java.security.Signature._initSign17637 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "initSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.Signature._setParameter17638 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.Signature._setParameter17639 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "setParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.Signature._getParameter17640 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.security.Signature._Signature17641 = @__env.GetMethodIDNoThrow(global::java.security.Signature.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Signature))]
	public sealed partial class Signature_ : java.security.Signature
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Signature_()
		{
			InitJNI();
		}
		internal Signature_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInitVerify17642;
		protected override void engineInitVerify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineInitVerify17642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineInitVerify17642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInitSign17643;
		protected override void engineInitSign(java.security.PrivateKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineInitSign17643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineInitSign17643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSign17644;
		protected override byte[] engineSign() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature_._engineSign17644)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineSign17644)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineVerify17645;
		protected override bool engineVerify(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Signature_._engineVerify17645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineVerify17645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17646;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineUpdate17646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineUpdate17646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17647;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineUpdate17647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineUpdate17647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetParameter17648;
		protected override void engineSetParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Signature_._engineSetParameter17648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineSetParameter17648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameter17649;
		protected override global::java.lang.Object engineGetParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Signature_._engineGetParameter17649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Signature_.staticClass, global::java.security.Signature_._engineGetParameter17649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Signature_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Signature"));
			global::java.security.Signature_._engineInitVerify17642 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.Signature_._engineInitSign17643 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.Signature_._engineSign17644 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineSign", "()[B");
			global::java.security.Signature_._engineVerify17645 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineVerify", "([B)Z");
			global::java.security.Signature_._engineUpdate17646 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineUpdate", "(B)V");
			global::java.security.Signature_._engineUpdate17647 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.Signature_._engineSetParameter17648 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.Signature_._engineGetParameter17649 = @__env.GetMethodIDNoThrow(global::java.security.Signature_.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
