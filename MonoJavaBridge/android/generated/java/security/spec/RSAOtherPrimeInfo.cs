namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAOtherPrimeInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RSAOtherPrimeInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger Exponent
		{
			get
			{
				return getExponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExponent24060;
		public virtual global::java.math.BigInteger getExponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAOtherPrimeInfo._getExponent24060)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAOtherPrimeInfo.staticClass, global::java.security.spec.RSAOtherPrimeInfo._getExponent24060)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger CrtCoefficient
		{
			get
			{
				return getCrtCoefficient();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCrtCoefficient24061;
		public virtual global::java.math.BigInteger getCrtCoefficient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAOtherPrimeInfo._getCrtCoefficient24061)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAOtherPrimeInfo.staticClass, global::java.security.spec.RSAOtherPrimeInfo._getCrtCoefficient24061)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger Prime
		{
			get
			{
				return getPrime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrime24062;
		public virtual global::java.math.BigInteger getPrime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAOtherPrimeInfo._getPrime24062)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAOtherPrimeInfo.staticClass, global::java.security.spec.RSAOtherPrimeInfo._getPrime24062)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _RSAOtherPrimeInfo24063;
		public RSAOtherPrimeInfo(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAOtherPrimeInfo.staticClass, global::java.security.spec.RSAOtherPrimeInfo._RSAOtherPrimeInfo24063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RSAOtherPrimeInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAOtherPrimeInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAOtherPrimeInfo"));
			global::java.security.spec.RSAOtherPrimeInfo._getExponent24060 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAOtherPrimeInfo.staticClass, "getExponent", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAOtherPrimeInfo._getCrtCoefficient24061 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAOtherPrimeInfo.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAOtherPrimeInfo._getPrime24062 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAOtherPrimeInfo.staticClass, "getPrime", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAOtherPrimeInfo._RSAOtherPrimeInfo24063 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAOtherPrimeInfo.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
