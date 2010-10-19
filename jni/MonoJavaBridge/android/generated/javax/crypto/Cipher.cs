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
		internal static global::MonoJavaBridge.MethodId _getInstance22483;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getInstance22483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Cipher;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22484;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getInstance22484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.crypto.Cipher;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22485;
		public static global::javax.crypto.Cipher getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getInstance22485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.Cipher;
		}
		internal static global::MonoJavaBridge.MethodId _init22486;
		public virtual void init(int arg0, java.security.cert.Certificate arg1, java.security.SecureRandom arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init22486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init22486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init22487;
		public virtual void init(int arg0, java.security.Key arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init22487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init22487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init22488;
		public virtual void init(int arg0, java.security.Key arg1, java.security.SecureRandom arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init22488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init22488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init22489;
		public virtual void init(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init22489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init22489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init22490;
		public virtual void init(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init22490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init22490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _init22491;
		public virtual void init(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init22491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init22491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _init22492;
		public virtual void init(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init22492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init22492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _init22493;
		public virtual void init(int arg0, java.security.cert.Certificate arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.Cipher._init22493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._init22493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wrap22494;
		public virtual byte[] wrap(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._wrap22494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._wrap22494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update22495;
		public virtual int update(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._update22495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update22495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _update22496;
		public virtual int update(byte[] arg0, int arg1, int arg2, byte[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._update22496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update22496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _update22497;
		public virtual byte[] update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._update22497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update22497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update22498;
		public virtual byte[] update(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._update22498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update22498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update22499;
		public virtual int update(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._update22499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._update22499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22500;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getAlgorithm22500)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getAlgorithm22500)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22501;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getProvider22501)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getProvider22501)) as java.security.Provider;
		}
		public new global::java.security.AlgorithmParameters Parameters
		{
			get
			{
				return getParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameters22502;
		public virtual global::java.security.AlgorithmParameters getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getParameters22502)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getParameters22502)) as java.security.AlgorithmParameters;
		}
		public new int BlockSize
		{
			get
			{
				return getBlockSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBlockSize22503;
		public virtual int getBlockSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._getBlockSize22503);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getBlockSize22503);
		}
		internal static global::MonoJavaBridge.MethodId _unwrap22504;
		public virtual global::java.security.Key unwrap(byte[] arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._unwrap22504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._unwrap22504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22505;
		public virtual byte[] doFinal(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal22505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal22505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22506;
		public virtual byte[] doFinal(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal22506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal22506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22507;
		public virtual int doFinal(byte[] arg0, int arg1, int arg2, byte[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal22507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal22507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22508;
		public virtual int doFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal22508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal22508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22509;
		public virtual int doFinal(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal22509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal22509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22510;
		public virtual int doFinal(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal22510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal22510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFinal22511;
		public virtual byte[] doFinal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._doFinal22511)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._doFinal22511)) as byte[];
		}
		public new global::javax.crypto.ExemptionMechanism ExemptionMechanism
		{
			get
			{
				return getExemptionMechanism();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExemptionMechanism22512;
		public virtual global::javax.crypto.ExemptionMechanism getExemptionMechanism() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getExemptionMechanism22512)) as javax.crypto.ExemptionMechanism;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getExemptionMechanism22512)) as javax.crypto.ExemptionMechanism;
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIV22513;
		public virtual byte[] getIV() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.Cipher._getIV22513)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getIV22513)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAllowedKeyLength22514;
		public static int getMaxAllowedKeyLength(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getMaxAllowedKeyLength22514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAllowedParameterSpec22515;
		public static global::java.security.spec.AlgorithmParameterSpec getMaxAllowedParameterSpec(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallStaticObjectMethod(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getMaxAllowedParameterSpec22515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _getOutputSize22516;
		public virtual int getOutputSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.Cipher._getOutputSize22516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._getOutputSize22516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Cipher22517;
		protected Cipher(javax.crypto.CipherSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.Cipher.staticClass, global::javax.crypto.Cipher._Cipher22517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::javax.crypto.Cipher._getInstance22483 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Cipher;");
			global::javax.crypto.Cipher._getInstance22484 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Cipher;");
			global::javax.crypto.Cipher._getInstance22485 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/Cipher;");
			global::javax.crypto.Cipher._init22486 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/cert/Certificate;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init22487 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;)V");
			global::javax.crypto.Cipher._init22488 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init22489 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.Cipher._init22490 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init22491 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;)V");
			global::javax.crypto.Cipher._init22492 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V");
			global::javax.crypto.Cipher._init22493 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "init", "(ILjava/security/cert/Certificate;)V");
			global::javax.crypto.Cipher._wrap22494 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "wrap", "(Ljava/security/Key;)[B");
			global::javax.crypto.Cipher._update22495 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([BII[BI)I");
			global::javax.crypto.Cipher._update22496 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([BII[B)I");
			global::javax.crypto.Cipher._update22497 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([BII)[B");
			global::javax.crypto.Cipher._update22498 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "([B)[B");
			global::javax.crypto.Cipher._update22499 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "update", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.Cipher._getAlgorithm22500 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.Cipher._getProvider22501 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::javax.crypto.Cipher._getParameters22502 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getParameters", "()Ljava/security/AlgorithmParameters;");
			global::javax.crypto.Cipher._getBlockSize22503 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getBlockSize", "()I");
			global::javax.crypto.Cipher._unwrap22504 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "unwrap", "([BLjava/lang/String;I)Ljava/security/Key;");
			global::javax.crypto.Cipher._doFinal22505 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([B)[B");
			global::javax.crypto.Cipher._doFinal22506 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BII)[B");
			global::javax.crypto.Cipher._doFinal22507 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BII[B)I");
			global::javax.crypto.Cipher._doFinal22508 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BII[BI)I");
			global::javax.crypto.Cipher._doFinal22509 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.Cipher._doFinal22510 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "([BI)I");
			global::javax.crypto.Cipher._doFinal22511 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "doFinal", "()[B");
			global::javax.crypto.Cipher._getExemptionMechanism22512 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getExemptionMechanism", "()Ljavax/crypto/ExemptionMechanism;");
			global::javax.crypto.Cipher._getIV22513 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getIV", "()[B");
			global::javax.crypto.Cipher._getMaxAllowedKeyLength22514 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getMaxAllowedKeyLength", "(Ljava/lang/String;)I");
			global::javax.crypto.Cipher._getMaxAllowedParameterSpec22515 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getMaxAllowedParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::javax.crypto.Cipher._getOutputSize22516 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "getOutputSize", "(I)I");
			global::javax.crypto.Cipher._Cipher22517 = @__env.GetMethodIDNoThrow(global::javax.crypto.Cipher.staticClass, "<init>", "(Ljavax/crypto/CipherSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
