namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECPoint : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ECPoint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.spec.ECPoint.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.spec.ECPoint._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECPoint.staticClass, "hashCode", "()I", ref global::java.security.spec.ECPoint._m1);
		}
		public new global::java.math.BigInteger AffineX
		{
			get
			{
				return getAffineX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.math.BigInteger getAffineX()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECPoint.staticClass, "getAffineX", "()Ljava/math/BigInteger;", ref global::java.security.spec.ECPoint._m2) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger AffineY
		{
			get
			{
				return getAffineY();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.math.BigInteger getAffineY()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECPoint.staticClass, "getAffineY", "()Ljava/math/BigInteger;", ref global::java.security.spec.ECPoint._m3) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ECPoint(java.math.BigInteger arg0, java.math.BigInteger arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECPoint._m4.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECPoint._m4 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPoint.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECPoint.staticClass, global::java.security.spec.ECPoint._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _POINT_INFINITY6536;
		public static global::java.security.spec.ECPoint POINT_INFINITY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.ECPoint.staticClass, _POINT_INFINITY6536)) as java.security.spec.ECPoint;
			}
		}
		static ECPoint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECPoint.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECPoint"));
			global::java.security.spec.ECPoint._POINT_INFINITY6536 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.ECPoint.staticClass, "POINT_INFINITY", "Ljava/security/spec/ECPoint;");
		}
	}
}
