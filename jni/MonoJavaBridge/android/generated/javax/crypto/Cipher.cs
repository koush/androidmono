namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Cipher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Cipher()
		{
			InitJNI();
		}
		protected Cipher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28372;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getInstance28372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Cipher;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28373;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getInstance28373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Cipher;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance28374;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getInstance28374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.Cipher;
		}
		internal static global::MonoJavaBridge.MethodId _init28375;
		public virtual void init(int arg0, java.security.cert.Certificate arg1, java.security.SecureRandom arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init28375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init28376;
		public virtual void init(int arg0, java.security.Key arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init28376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init28377;
		public virtual void init(int arg0, java.security.Key arg1, java.security.SecureRandom arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init28377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init28378;
		public virtual void init(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init28378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init28379;
		public virtual void init(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init28379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _init28380;
		public virtual void init(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init28380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init28381;
		public virtual void init(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init28381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _init28382;
		public virtual void init(int arg0, java.security.cert.Certificate arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init28382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init28382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wrap28383;
		public virtual byte[] wrap(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._wrap28383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._wrap28383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update28384;
		public virtual int update(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._update28384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update28385;
		public virtual int update(byte[] arg0, int arg1, int arg2, byte[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._update28385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _update28386;
		public virtual byte[] update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._update28386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update28387;
		public virtual byte[] update(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._update28387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update28388;
		public virtual int update(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._update28388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update28388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28389;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getAlgorithm28389)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getAlgorithm28389)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider28390;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getProvider28390)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getProvider28390)) as java.security.Provider;
		}
		public new global::java.security.AlgorithmParameters Parameters
		{
			get
			{
				return getParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameters28391;
		public virtual global::java.security.AlgorithmParameters getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getParameters28391)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getParameters28391)) as java.security.AlgorithmParameters;
		}
		public new int BlockSize
		{
			get
			{
				return getBlockSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBlockSize28392;
		public virtual int getBlockSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._getBlockSize28392);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getBlockSize28392);
		}
		internal static global::MonoJavaBridge.MethodId _unwrap28393;
		public virtual global::java.security.Key unwrap(byte[] arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._unwrap28393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._unwrap28393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28394;
		public virtual byte[] doFinal(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal28394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28395;
		public virtual byte[] doFinal(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal28395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28396;
		public virtual int doFinal(byte[] arg0, int arg1, int arg2, byte[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal28396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28397;
		public virtual int doFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal28397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28398;
		public virtual int doFinal(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal28398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28399;
		public virtual int doFinal(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal28399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal28400;
		public virtual byte[] doFinal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal28400)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal28400)) as byte[];
		}
		public new global::javax.crypto.ExemptionMechanism ExemptionMechanism
		{
			get
			{
				return getExemptionMechanism();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExemptionMechanism28401;
		public virtual global::javax.crypto.ExemptionMechanism getExemptionMechanism() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getExemptionMechanism28401)) as javax.crypto.ExemptionMechanism;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getExemptionMechanism28401)) as javax.crypto.ExemptionMechanism;
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIV28402;
		public virtual byte[] getIV() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getIV28402)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getIV28402)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAllowedKeyLength28403;
		public static int getMaxAllowedKeyLength(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getMaxAllowedKeyLength28403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAllowedParameterSpec28404;
		public static global::java.security.spec.AlgorithmParameterSpec getMaxAllowedParameterSpec(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getMaxAllowedParameterSpec28404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputSize28405;
		public virtual int getOutputSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._getOutputSize28405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getOutputSize28405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Cipher28406;
		protected Cipher(javax.crypto.CipherSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._Cipher28406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int ENCRYPT_MODE
		{
			get
			{
				return 1;
			}
		}
		public static int DECRYPT_MODE
		{
			get
			{
				return 2;
			}
		}
		public static int WRAP_MODE
		{
			get
			{
				return 3;
			}
		}
		public static int UNWRAP_MODE
		{
			get
			{
				return 4;
			}
		}
		public static int PUBLIC_KEY
		{
			get
			{
				return 1;
			}
		}
		public static int PRIVATE_KEY
		{
			get
			{
				return 2;
			}
		}
		public static int SECRET_KEY
		{
			get
			{
				return 3;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.Cipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/Cipher"));
			global::javax.crypto.Cipher._getInstance28372 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Cipher;");
			global::javax.crypto.Cipher._getInstance28373 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Cipher;");
			global::javax.crypto.Cipher._getInstance28374 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Cipher;");
			global::javax.crypto.Cipher._init28375 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/cert/Certificate;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init28376 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;)V");
			global::javax.crypto.Cipher._init28377 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init28378 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.Cipher._init28379 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init28380 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;)V");
			global::javax.crypto.Cipher._init28381 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init28382 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/cert/Certificate;)V");
			global::javax.crypto.Cipher._wrap28383 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "wrap", "(Ljava/security/Key;)[B");
			global::javax.crypto.Cipher._update28384 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([BII[BI)I");
			global::javax.crypto.Cipher._update28385 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([BII[B)I");
			global::javax.crypto.Cipher._update28386 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([BII)[B");
			global::javax.crypto.Cipher._update28387 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([B)[B");
			global::javax.crypto.Cipher._update28388 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.Cipher._getAlgorithm28389 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.Cipher._getProvider28390 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.Cipher._getParameters28391 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getParameters", "()Ljava/security/AlgorithmParameters;");
			global::javax.crypto.Cipher._getBlockSize28392 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getBlockSize", "()I");
			global::javax.crypto.Cipher._unwrap28393 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "unwrap", "([BLjava/lang/String;I)Ljava/security/Key;");
			global::javax.crypto.Cipher._doFinal28394 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([B)[B");
			global::javax.crypto.Cipher._doFinal28395 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BII)[B");
			global::javax.crypto.Cipher._doFinal28396 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BII[B)I");
			global::javax.crypto.Cipher._doFinal28397 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BII[BI)I");
			global::javax.crypto.Cipher._doFinal28398 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.Cipher._doFinal28399 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BI)I");
			global::javax.crypto.Cipher._doFinal28400 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "()[B");
			global::javax.crypto.Cipher._getExemptionMechanism28401 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getExemptionMechanism", "()Ljavax/crypto/ExemptionMechanism;");
			global::javax.crypto.Cipher._getIV28402 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getIV", "()[B");
			global::javax.crypto.Cipher._getMaxAllowedKeyLength28403 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getMaxAllowedKeyLength", "(Ljava/lang/String;)I");
			global::javax.crypto.Cipher._getMaxAllowedParameterSpec28404 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getMaxAllowedParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::javax.crypto.Cipher._getOutputSize28405 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getOutputSize", "(I)I");
			global::javax.crypto.Cipher._Cipher28406 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "<init>", "(Ljavax/crypto/CipherSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
