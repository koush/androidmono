namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EllipticCurve : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EllipticCurve(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.spec.EllipticCurve.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.spec.EllipticCurve._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.EllipticCurve.staticClass, "hashCode", "()I", ref global::java.security.spec.EllipticCurve._m1);
		}
		public new global::java.security.spec.ECField Field
		{
			get
			{
				return getField();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.security.spec.ECField getField()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.ECField>(this, global::java.security.spec.EllipticCurve.staticClass, "getField", "()Ljava/security/spec/ECField;", ref global::java.security.spec.EllipticCurve._m2) as java.security.spec.ECField;
		}
		public new byte[] Seed
		{
			get
			{
				return getSeed();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual byte[] getSeed()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.spec.EllipticCurve.staticClass, "getSeed", "()[B", ref global::java.security.spec.EllipticCurve._m3) as byte[];
		}
		public new global::java.math.BigInteger A
		{
			get
			{
				return getA();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.math.BigInteger getA()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.EllipticCurve.staticClass, "getA", "()Ljava/math/BigInteger;", ref global::java.security.spec.EllipticCurve._m4) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger B
		{
			get
			{
				return getB();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.math.BigInteger getB()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.EllipticCurve.staticClass, "getB", "()Ljava/math/BigInteger;", ref global::java.security.spec.EllipticCurve._m5) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public EllipticCurve(java.security.spec.ECField arg0, java.math.BigInteger arg1, java.math.BigInteger arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._m6.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._m6 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public EllipticCurve(java.security.spec.ECField arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, byte[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._m7.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._m7 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static EllipticCurve()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EllipticCurve.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EllipticCurve"));
		}
	}
}
