namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExemptionMechanism : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExemptionMechanism()
		{
			InitJNI();
		}
		protected ExemptionMechanism(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize28473;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._finalize28473);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._finalize28473);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName28474;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._getName28474)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getName28474)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28475;
		public static global::javax.crypto.ExemptionMechanism getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getInstance28475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.ExemptionMechanism;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28476;
		public static global::javax.crypto.ExemptionMechanism getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getInstance28476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.ExemptionMechanism;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28477;
		public static global::javax.crypto.ExemptionMechanism getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getInstance28477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.ExemptionMechanism;
		}
		internal static global::MonoJavaBridge.MethodId _init28478;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._init28478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._init28478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28479;
		public virtual void init(java.security.Key arg0, java.security.AlgorithmParameters arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._init28479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._init28479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28480;
		public virtual void init(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._init28480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._init28480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider28481;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._getProvider28481)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getProvider28481)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputSize28482;
		public virtual int getOutputSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._getOutputSize28482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getOutputSize28482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCryptoAllowed28483;
		public virtual bool isCryptoAllowed(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._isCryptoAllowed28483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._isCryptoAllowed28483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _genExemptionBlob28484;
		public virtual byte[] genExemptionBlob() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._genExemptionBlob28484)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._genExemptionBlob28484)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _genExemptionBlob28485;
		public virtual int genExemptionBlob(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._genExemptionBlob28485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._genExemptionBlob28485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _genExemptionBlob28486;
		public virtual int genExemptionBlob(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._genExemptionBlob28486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._genExemptionBlob28486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ExemptionMechanism28487;
		protected ExemptionMechanism(javax.crypto.ExemptionMechanismSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._ExemptionMechanism28487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanism.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanism"));
			global::javax.crypto.ExemptionMechanism._finalize28473 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "finalize", "()V");
			global::javax.crypto.ExemptionMechanism._getName28474 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getName", "()Ljava/lang/String;");
			global::javax.crypto.ExemptionMechanism._getInstance28475 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;");
			global::javax.crypto.ExemptionMechanism._getInstance28476 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/ExemptionMechanism;");
			global::javax.crypto.ExemptionMechanism._getInstance28477 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;");
			global::javax.crypto.ExemptionMechanism._init28478 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.ExemptionMechanism._init28479 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "init", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V");
			global::javax.crypto.ExemptionMechanism._init28480 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "init", "(Ljava/security/Key;)V");
			global::javax.crypto.ExemptionMechanism._getProvider28481 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.ExemptionMechanism._getOutputSize28482 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getOutputSize", "(I)I");
			global::javax.crypto.ExemptionMechanism._isCryptoAllowed28483 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "isCryptoAllowed", "(Ljava/security/Key;)Z");
			global::javax.crypto.ExemptionMechanism._genExemptionBlob28484 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "genExemptionBlob", "()[B");
			global::javax.crypto.ExemptionMechanism._genExemptionBlob28485 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "genExemptionBlob", "([B)I");
			global::javax.crypto.ExemptionMechanism._genExemptionBlob28486 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "genExemptionBlob", "([BI)I");
			global::javax.crypto.ExemptionMechanism._ExemptionMechanism28487 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "<init>", "(Ljavax/crypto/ExemptionMechanismSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
