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
		internal static global::MonoJavaBridge.MethodId _finalize22577;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._finalize22577);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._finalize22577);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName22578;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._getName22578)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getName22578)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22579;
		public static global::javax.crypto.ExemptionMechanism getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getInstance22579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.ExemptionMechanism;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22580;
		public static global::javax.crypto.ExemptionMechanism getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getInstance22580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.ExemptionMechanism;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22581;
		public static global::javax.crypto.ExemptionMechanism getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getInstance22581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.ExemptionMechanism;
		}
		internal static global::MonoJavaBridge.MethodId _init22582;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._init22582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._init22582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init22583;
		public virtual void init(java.security.Key arg0, java.security.AlgorithmParameters arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._init22583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._init22583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init22584;
		public virtual void init(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._init22584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._init22584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22585;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._getProvider22585)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getProvider22585)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputSize22586;
		public virtual int getOutputSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._getOutputSize22586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._getOutputSize22586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCryptoAllowed22587;
		public virtual bool isCryptoAllowed(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._isCryptoAllowed22587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._isCryptoAllowed22587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _genExemptionBlob22588;
		public virtual byte[] genExemptionBlob() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._genExemptionBlob22588)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._genExemptionBlob22588)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _genExemptionBlob22589;
		public virtual int genExemptionBlob(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._genExemptionBlob22589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._genExemptionBlob22589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _genExemptionBlob22590;
		public virtual int genExemptionBlob(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism._genExemptionBlob22590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._genExemptionBlob22590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ExemptionMechanism22591;
		protected ExemptionMechanism(javax.crypto.ExemptionMechanismSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanism.staticClass, global::javax.crypto.ExemptionMechanism._ExemptionMechanism22591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanism.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanism"));
			global::javax.crypto.ExemptionMechanism._finalize22577 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "finalize", "()V");
			global::javax.crypto.ExemptionMechanism._getName22578 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getName", "()Ljava/lang/String;");
			global::javax.crypto.ExemptionMechanism._getInstance22579 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;");
			global::javax.crypto.ExemptionMechanism._getInstance22580 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/ExemptionMechanism;");
			global::javax.crypto.ExemptionMechanism._getInstance22581 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;");
			global::javax.crypto.ExemptionMechanism._init22582 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.ExemptionMechanism._init22583 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "init", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V");
			global::javax.crypto.ExemptionMechanism._init22584 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "init", "(Ljava/security/Key;)V");
			global::javax.crypto.ExemptionMechanism._getProvider22585 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.ExemptionMechanism._getOutputSize22586 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "getOutputSize", "(I)I");
			global::javax.crypto.ExemptionMechanism._isCryptoAllowed22587 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "isCryptoAllowed", "(Ljava/security/Key;)Z");
			global::javax.crypto.ExemptionMechanism._genExemptionBlob22588 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "genExemptionBlob", "()[B");
			global::javax.crypto.ExemptionMechanism._genExemptionBlob22589 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "genExemptionBlob", "([B)I");
			global::javax.crypto.ExemptionMechanism._genExemptionBlob22590 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "genExemptionBlob", "([BI)I");
			global::javax.crypto.ExemptionMechanism._ExemptionMechanism22591 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanism.staticClass, "<init>", "(Ljavax/crypto/ExemptionMechanismSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
