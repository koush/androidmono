namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Mac : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Mac(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone28672;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._clone28672)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._clone28672)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28673;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getInstance28673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Mac;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28674;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getInstance28674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Mac;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28675;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getInstance28675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.Mac;
		}
		internal static global::MonoJavaBridge.MethodId _init28676;
		public virtual void init(java.security.Key arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._init28676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._init28676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init28677;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._init28677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._init28677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset28678;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._reset28678);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._reset28678);
		}
		internal static global::MonoJavaBridge.MethodId _update28679;
		public virtual void update(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._update28679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._update28679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update28680;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._update28680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._update28680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update28681;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._update28681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._update28681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update28682;
		public virtual void update(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._update28682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._update28682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28683;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._getAlgorithm28683)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getAlgorithm28683)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider28684;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._getProvider28684)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getProvider28684)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28685;
		public virtual byte[] doFinal(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._doFinal28685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._doFinal28685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28686;
		public virtual byte[] doFinal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._doFinal28686)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._doFinal28686)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28687;
		public virtual void doFinal(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._doFinal28687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._doFinal28687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int MacLength
		{
			get
			{
				return getMacLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMacLength28688;
		public virtual int getMacLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Mac._getMacLength28688);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getMacLength28688);
		}
		internal static global::MonoJavaBridge.MethodId _Mac28689;
		protected Mac(javax.crypto.MacSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._Mac28689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Mac()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.Mac.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/Mac"));
			global::javax.crypto.Mac._clone28672 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.crypto.Mac._getInstance28673 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Mac;");
			global::javax.crypto.Mac._getInstance28674 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Mac;");
			global::javax.crypto.Mac._getInstance28675 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Mac;");
			global::javax.crypto.Mac._init28676 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "init", "(Ljava/security/Key;)V");
			global::javax.crypto.Mac._init28677 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.Mac._reset28678 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "reset", "()V");
			global::javax.crypto.Mac._update28679 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "update", "(B)V");
			global::javax.crypto.Mac._update28680 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "update", "([B)V");
			global::javax.crypto.Mac._update28681 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "update", "([BII)V");
			global::javax.crypto.Mac._update28682 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "update", "(Ljava/nio/ByteBuffer;)V");
			global::javax.crypto.Mac._getAlgorithm28683 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.Mac._getProvider28684 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.Mac._doFinal28685 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "doFinal", "([B)[B");
			global::javax.crypto.Mac._doFinal28686 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "doFinal", "()[B");
			global::javax.crypto.Mac._doFinal28687 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "doFinal", "([BI)V");
			global::javax.crypto.Mac._getMacLength28688 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getMacLength", "()I");
			global::javax.crypto.Mac._Mac28689 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "<init>", "(Ljavax/crypto/MacSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
