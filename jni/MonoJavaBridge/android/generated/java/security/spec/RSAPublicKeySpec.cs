namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAPublicKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAPublicKeySpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getModulus23955;
		public virtual global::java.math.BigInteger getModulus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPublicKeySpec._getModulus23955)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPublicKeySpec.staticClass, global::java.security.spec.RSAPublicKeySpec._getModulus23955)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PublicExponent
		{
			get
			{
				return getPublicExponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent23956;
		public virtual global::java.math.BigInteger getPublicExponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPublicKeySpec._getPublicExponent23956)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPublicKeySpec.staticClass, global::java.security.spec.RSAPublicKeySpec._getPublicExponent23956)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _RSAPublicKeySpec23957;
		public RSAPublicKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAPublicKeySpec.staticClass, global::java.security.spec.RSAPublicKeySpec._RSAPublicKeySpec23957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAPublicKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAPublicKeySpec"));
			global::java.security.spec.RSAPublicKeySpec._getModulus23955 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPublicKeySpec.staticClass, "getModulus", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPublicKeySpec._getPublicExponent23956 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPublicKeySpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPublicKeySpec._RSAPublicKeySpec23957 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPublicKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
		}
	}
}
