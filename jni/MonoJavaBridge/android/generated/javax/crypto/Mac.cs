namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Mac : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Mac()
		{
			InitJNI();
		}
		protected Mac(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone22657;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._clone22657)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._clone22657)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22658;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getInstance22658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Mac;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22659;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getInstance22659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Mac;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22660;
		public static global::javax.crypto.Mac getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getInstance22660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.Mac;
		}
		internal static global::MonoJavaBridge.MethodId _init22661;
		public virtual void init(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._init22661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._init22661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22662;
		public virtual void init(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._init22662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._init22662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _reset22663;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._reset22663);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._reset22663);
		}
		internal static global::MonoJavaBridge.MethodId _update22664;
		public virtual void update(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._update22664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._update22664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update22665;
		public virtual void update(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._update22665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._update22665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update22666;
		public virtual void update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._update22666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._update22666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update22667;
		public virtual void update(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._update22667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._update22667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22668;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._getAlgorithm22668)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getAlgorithm22668)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22669;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._getProvider22669)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getProvider22669)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22670;
		public virtual byte[] doFinal(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._doFinal22670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._doFinal22670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22671;
		public virtual byte[] doFinal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Mac._doFinal22671)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._doFinal22671)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22672;
		public virtual void doFinal(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Mac._doFinal22672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._doFinal22672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int MacLength
		{
			get
			{
				return getMacLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMacLength22673;
		public virtual int getMacLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Mac._getMacLength22673);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Mac.staticClass, global::javax.crypto.Mac._getMacLength22673);
		}
		internal static global::MonoJavaBridge.MethodId _Mac22674;
		protected Mac(javax.crypto.MacSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.Mac.staticClass, global::javax.crypto.Mac._Mac22674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.Mac.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/Mac"));
			global::javax.crypto.Mac._clone22657 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.crypto.Mac._getInstance22658 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Mac;");
			global::javax.crypto.Mac._getInstance22659 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Mac;");
			global::javax.crypto.Mac._getInstance22660 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Mac;");
			global::javax.crypto.Mac._init22661 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "init", "(Ljava/security/Key;)V");
			global::javax.crypto.Mac._init22662 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.Mac._reset22663 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "reset", "()V");
			global::javax.crypto.Mac._update22664 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "update", "(B)V");
			global::javax.crypto.Mac._update22665 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "update", "([B)V");
			global::javax.crypto.Mac._update22666 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "update", "([BII)V");
			global::javax.crypto.Mac._update22667 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "update", "(Ljava/nio/ByteBuffer;)V");
			global::javax.crypto.Mac._getAlgorithm22668 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.Mac._getProvider22669 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.Mac._doFinal22670 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "doFinal", "([B)[B");
			global::javax.crypto.Mac._doFinal22671 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "doFinal", "()[B");
			global::javax.crypto.Mac._doFinal22672 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "doFinal", "([BI)V");
			global::javax.crypto.Mac._getMacLength22673 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "getMacLength", "()I");
			global::javax.crypto.Mac._Mac22674 = @__env.GetMethodIDNoThrow(global::javax.crypto.Mac.staticClass, "<init>", "(Ljavax/crypto/MacSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
