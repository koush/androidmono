namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAPrivateCrtKeySpec : java.security.spec.RSAPrivateKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAPrivateCrtKeySpec()
		{
			InitJNI();
		}
		protected RSAPrivateCrtKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger PublicExponent
		{
			get
			{
				return getPublicExponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent24064;
		public virtual global::java.math.BigInteger getPublicExponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec._getPublicExponent24064)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, global::java.security.spec.RSAPrivateCrtKeySpec._getPublicExponent24064)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeP
		{
			get
			{
				return getPrimeP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeP24065;
		public virtual global::java.math.BigInteger getPrimeP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeP24065)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeP24065)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeQ
		{
			get
			{
				return getPrimeQ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeQ24066;
		public virtual global::java.math.BigInteger getPrimeQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeQ24066)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeQ24066)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeExponentP
		{
			get
			{
				return getPrimeExponentP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentP24067;
		public virtual global::java.math.BigInteger getPrimeExponentP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeExponentP24067)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeExponentP24067)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrimeExponentQ
		{
			get
			{
				return getPrimeExponentQ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimeExponentQ24068;
		public virtual global::java.math.BigInteger getPrimeExponentQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeExponentQ24068)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeExponentQ24068)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger CrtCoefficient
		{
			get
			{
				return getCrtCoefficient();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCrtCoefficient24069;
		public virtual global::java.math.BigInteger getCrtCoefficient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec._getCrtCoefficient24069)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, global::java.security.spec.RSAPrivateCrtKeySpec._getCrtCoefficient24069)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _RSAPrivateCrtKeySpec24070;
		public RSAPrivateCrtKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigInteger arg6, java.math.BigInteger arg7) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAPrivateCrtKeySpec.staticClass, global::java.security.spec.RSAPrivateCrtKeySpec._RSAPrivateCrtKeySpec24070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAPrivateCrtKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAPrivateCrtKeySpec"));
			global::java.security.spec.RSAPrivateCrtKeySpec._getPublicExponent24064 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeP24065 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPrimeP", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeQ24066 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPrimeQ", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeExponentP24067 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPrimeExponentP", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPrivateCrtKeySpec._getPrimeExponentQ24068 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getPrimeExponentQ", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPrivateCrtKeySpec._getCrtCoefficient24069 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "getCrtCoefficient", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPrivateCrtKeySpec._RSAPrivateCrtKeySpec24070 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateCrtKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
		}
	}
}
