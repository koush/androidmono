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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Mac.staticClass, "clone", "()Ljava/lang/Object;", ref global::javax.crypto.Mac._clone28672) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28673;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Mac._getInstance28673.native == global::System.IntPtr.Zero)
				global::javax.crypto.Mac._getInstance28673 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Mac;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getInstance28673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Mac;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28674;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Mac._getInstance28674.native == global::System.IntPtr.Zero)
				global::javax.crypto.Mac._getInstance28674 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Mac;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getInstance28674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Mac;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28675;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Mac._getInstance28675.native == global::System.IntPtr.Zero)
				global::javax.crypto.Mac._getInstance28675 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Mac;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getInstance28675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.Mac;
		}
		internal static global::MonoJavaBridge.MethodId _init28676;
		public virtual void init(java.security.Key arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "init", "(Ljava/security/Key;)V", ref global::javax.crypto.Mac._init28676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init28677;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::javax.crypto.Mac._init28677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset28678;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "reset", "()V", ref global::javax.crypto.Mac._reset28678);
		}
		internal static global::MonoJavaBridge.MethodId _update28679;
		public virtual void update(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "update", "(B)V", ref global::javax.crypto.Mac._update28679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update28680;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "update", "([B)V", ref global::javax.crypto.Mac._update28680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update28681;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "update", "([BII)V", ref global::javax.crypto.Mac._update28681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update28682;
		public virtual void update(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "update", "(Ljava/nio/ByteBuffer;)V", ref global::javax.crypto.Mac._update28682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.Mac.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.Mac._getAlgorithm28683) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.Mac.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::javax.crypto.Mac._getProvider28684) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28685;
		public virtual byte[] doFinal(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Mac.staticClass, "doFinal", "([B)[B", ref global::javax.crypto.Mac._doFinal28685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28686;
		public virtual byte[] doFinal()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.Mac.staticClass, "doFinal", "()[B", ref global::javax.crypto.Mac._doFinal28686) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28687;
		public virtual void doFinal(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.Mac.staticClass, "doFinal", "([BI)V", ref global::javax.crypto.Mac._doFinal28687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.Mac.staticClass, "getMacLength", "()I", ref global::javax.crypto.Mac._getMacLength28688);
		}
		internal static global::MonoJavaBridge.MethodId _Mac28689;
		protected Mac(javax.crypto.MacSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.Mac._Mac28689.native == global::System.IntPtr.Zero)
				global::javax.crypto.Mac._Mac28689 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "<init>", "(Ljavax/crypto/MacSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._Mac28689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
