namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAPublicKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RSAPublicKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger Modulus
		{
			get
			{
				return getModulus();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.math.BigInteger getModulus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPublicKeySpec.staticClass, "getModulus", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAPublicKeySpec._m0) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PublicExponent
		{
			get
			{
				return getPublicExponent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.math.BigInteger getPublicExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPublicKeySpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAPublicKeySpec._m1) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public RSAPublicKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.RSAPublicKeySpec._m2.native == global::System.IntPtr.Zero)
				global::java.security.spec.RSAPublicKeySpec._m2 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPublicKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAPublicKeySpec.staticClass, global::java.security.spec.RSAPublicKeySpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RSAPublicKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAPublicKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAPublicKeySpec"));
		}
	}
}
