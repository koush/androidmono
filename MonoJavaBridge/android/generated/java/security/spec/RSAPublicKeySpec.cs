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
		internal static global::MonoJavaBridge.MethodId _getModulus24074;
		public virtual global::java.math.BigInteger getModulus()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPublicKeySpec.staticClass, global::java.security.spec.RSAPublicKeySpec._getModulus24074)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PublicExponent
		{
			get
			{
				return getPublicExponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent24075;
		public virtual global::java.math.BigInteger getPublicExponent()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAPublicKeySpec.staticClass, global::java.security.spec.RSAPublicKeySpec._getPublicExponent24075)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _RSAPublicKeySpec24076;
		public RSAPublicKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAPublicKeySpec.staticClass, global::java.security.spec.RSAPublicKeySpec._RSAPublicKeySpec24076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RSAPublicKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAPublicKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAPublicKeySpec"));
			global::java.security.spec.RSAPublicKeySpec._getModulus24074 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPublicKeySpec.staticClass, "getModulus", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPublicKeySpec._getPublicExponent24075 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPublicKeySpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPublicKeySpec._RSAPublicKeySpec24076 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPublicKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
