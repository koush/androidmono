namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ECParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger Order
		{
			get
			{
				return getOrder();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.math.BigInteger getOrder()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECParameterSpec.staticClass, "getOrder", "()Ljava/math/BigInteger;", ref global::java.security.spec.ECParameterSpec._m0) as java.math.BigInteger;
		}
		public new global::java.security.spec.EllipticCurve Curve
		{
			get
			{
				return getCurve();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.security.spec.EllipticCurve getCurve()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECParameterSpec.staticClass, "getCurve", "()Ljava/security/spec/EllipticCurve;", ref global::java.security.spec.ECParameterSpec._m1) as java.security.spec.EllipticCurve;
		}
		public new global::java.security.spec.ECPoint Generator
		{
			get
			{
				return getGenerator();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.security.spec.ECPoint getGenerator()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECParameterSpec.staticClass, "getGenerator", "()Ljava/security/spec/ECPoint;", ref global::java.security.spec.ECParameterSpec._m2) as java.security.spec.ECPoint;
		}
		public new int Cofactor
		{
			get
			{
				return getCofactor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getCofactor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECParameterSpec.staticClass, "getCofactor", "()I", ref global::java.security.spec.ECParameterSpec._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ECParameterSpec(java.security.spec.EllipticCurve arg0, java.security.spec.ECPoint arg1, java.math.BigInteger arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECParameterSpec._m4.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECParameterSpec._m4 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECParameterSpec.staticClass, "<init>", "(Ljava/security/spec/EllipticCurve;Ljava/security/spec/ECPoint;Ljava/math/BigInteger;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECParameterSpec.staticClass, global::java.security.spec.ECParameterSpec._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static ECParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECParameterSpec"));
		}
	}
}
