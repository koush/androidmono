namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ECParameterSpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getOrder23995;
		public virtual global::java.math.BigInteger getOrder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECParameterSpec._getOrder23995)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECParameterSpec.staticClass, global::java.security.spec.ECParameterSpec._getOrder23995)) as java.math.BigInteger;
		}
		public new global::java.security.spec.EllipticCurve Curve
		{
			get
			{
				return getCurve();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurve23996;
		public virtual global::java.security.spec.EllipticCurve getCurve()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECParameterSpec._getCurve23996)) as java.security.spec.EllipticCurve;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECParameterSpec.staticClass, global::java.security.spec.ECParameterSpec._getCurve23996)) as java.security.spec.EllipticCurve;
		}
		public new global::java.security.spec.ECPoint Generator
		{
			get
			{
				return getGenerator();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenerator23997;
		public virtual global::java.security.spec.ECPoint getGenerator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECParameterSpec._getGenerator23997)) as java.security.spec.ECPoint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECParameterSpec.staticClass, global::java.security.spec.ECParameterSpec._getGenerator23997)) as java.security.spec.ECPoint;
		}
		public new int Cofactor
		{
			get
			{
				return getCofactor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCofactor23998;
		public virtual int getCofactor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECParameterSpec._getCofactor23998);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECParameterSpec.staticClass, global::java.security.spec.ECParameterSpec._getCofactor23998);
		}
		internal static global::MonoJavaBridge.MethodId _ECParameterSpec23999;
		public ECParameterSpec(java.security.spec.EllipticCurve arg0, java.security.spec.ECPoint arg1, java.math.BigInteger arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECParameterSpec.staticClass, global::java.security.spec.ECParameterSpec._ECParameterSpec23999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECParameterSpec"));
			global::java.security.spec.ECParameterSpec._getOrder23995 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECParameterSpec.staticClass, "getOrder", "()Ljava/math/BigInteger;");
			global::java.security.spec.ECParameterSpec._getCurve23996 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECParameterSpec.staticClass, "getCurve", "()Ljava/security/spec/EllipticCurve;");
			global::java.security.spec.ECParameterSpec._getGenerator23997 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECParameterSpec.staticClass, "getGenerator", "()Ljava/security/spec/ECPoint;");
			global::java.security.spec.ECParameterSpec._getCofactor23998 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECParameterSpec.staticClass, "getCofactor", "()I");
			global::java.security.spec.ECParameterSpec._ECParameterSpec23999 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECParameterSpec.staticClass, "<init>", "(Ljava/security/spec/EllipticCurve;Ljava/security/spec/ECPoint;Ljava/math/BigInteger;I)V");
		}
	}
}
