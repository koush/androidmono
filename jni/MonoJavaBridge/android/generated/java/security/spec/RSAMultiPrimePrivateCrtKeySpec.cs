namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAMultiPrimePrivateCrtKeySpec : java.security.spec.RSAPrivateKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAMultiPrimePrivateCrtKeySpec()
		{
			InitJNI();
		}
		protected RSAMultiPrimePrivateCrtKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger PublicExponent
		{
			get
			{
				return getPublicExponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent24052;
		public virtual global::java.math.BigInteger getPublicExponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPublicExponent24052)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPublicExponent24052)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeP
		{
			get
			{
				return getPrimeP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeP24053;
		public virtual global::java.math.BigInteger getPrimeP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeP24053)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeP24053)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeQ
		{
			get
			{
				return getPrimeQ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeQ24054;
		public virtual global::java.math.BigInteger getPrimeQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeQ24054)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeQ24054)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeExponentP
		{
			get
			{
				return getPrimeExponentP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentP24055;
		public virtual global::java.math.BigInteger getPrimeExponentP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeExponentP24055)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeExponentP24055)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeExponentQ
		{
			get
			{
				return getPrimeExponentQ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentQ24056;
		public virtual global::java.math.BigInteger getPrimeExponentQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeExponentQ24056)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeExponentQ24056)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger CrtCoefficient
		{
			get
			{
				return getCrtCoefficient();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCrtCoefficient24057;
		public virtual global::java.math.BigInteger getCrtCoefficient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getCrtCoefficient24057)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getCrtCoefficient24057)) as java.math.BigInteger;
		}
		public new global::java.security.spec.RSAOtherPrimeInfo[] OtherPrimeInfo
		{
			get
			{
				return getOtherPrimeInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOtherPrimeInfo24058;
		public virtual global::java.security.spec.RSAOtherPrimeInfo[] getOtherPrimeInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.spec.RSAOtherPrimeInfo>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getOtherPrimeInfo24058)) as java.security.spec.RSAOtherPrimeInfo[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.spec.RSAOtherPrimeInfo>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getOtherPrimeInfo24058)) as java.security.spec.RSAOtherPrimeInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _RSAMultiPrimePrivateCrtKeySpec24059;
		public RSAMultiPrimePrivateCrtKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigInteger arg6, java.math.BigInteger arg7, java.security.spec.RSAOtherPrimeInfo[] arg8) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._RSAMultiPrimePrivateCrtKeySpec24059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAMultiPrimePrivateCrtKeySpec"));
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPublicExponent24052 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeP24053 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPrimeP", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeQ24054 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeExponentP24055 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getPrimeExponentQ24056 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getCrtCoefficient24057 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._getOtherPrimeInfo24058 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;");
			global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec._RSAMultiPrimePrivateCrtKeySpec24059 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAMultiPrimePrivateCrtKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;[Ljava/security/spec/RSAOtherPrimeInfo;)V");
		}
	}
}
