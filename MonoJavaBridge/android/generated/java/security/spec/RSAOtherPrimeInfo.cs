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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.math.BigInteger getExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAOtherPrimeInfo.staticClass, "getExponent", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAOtherPrimeInfo._m0) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger CrtCoefficient
		{
			get
			{
				return getCrtCoefficient();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.math.BigInteger getCrtCoefficient()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAOtherPrimeInfo.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAOtherPrimeInfo._m1) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger Prime
		{
			get
			{
				return getPrime();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.math.BigInteger getPrime()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAOtherPrimeInfo.staticClass, "getPrime", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAOtherPrimeInfo._m2) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public RSAOtherPrimeInfo(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.RSAOtherPrimeInfo._m3.native == global::System.IntPtr.Zero)
				global::java.security.spec.RSAOtherPrimeInfo._m3 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAOtherPrimeInfo.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAOtherPrimeInfo.staticClass, global::java.security.spec.RSAOtherPrimeInfo._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RSAOtherPrimeInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAOtherPrimeInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAOtherPrimeInfo"));
		}
	}
}
