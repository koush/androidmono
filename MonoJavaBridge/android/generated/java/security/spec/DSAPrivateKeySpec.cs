namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DSAPrivateKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DSAPrivateKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger P
		{
			get
			{
				return getP();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.math.BigInteger getP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.DSAPrivateKeySpec.staticClass, "getP", "()Ljava/math/BigInteger;", ref global::java.security.spec.DSAPrivateKeySpec._m0) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger Q
		{
			get
			{
				return getQ();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.math.BigInteger getQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.DSAPrivateKeySpec.staticClass, "getQ", "()Ljava/math/BigInteger;", ref global::java.security.spec.DSAPrivateKeySpec._m1) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.math.BigInteger getG()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.DSAPrivateKeySpec.staticClass, "getG", "()Ljava/math/BigInteger;", ref global::java.security.spec.DSAPrivateKeySpec._m2) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger X
		{
			get
			{
				return getX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.math.BigInteger getX()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.DSAPrivateKeySpec.staticClass, "getX", "()Ljava/math/BigInteger;", ref global::java.security.spec.DSAPrivateKeySpec._m3) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public DSAPrivateKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.DSAPrivateKeySpec._m4.native == global::System.IntPtr.Zero)
				global::java.security.spec.DSAPrivateKeySpec._m4 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPrivateKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.DSAPrivateKeySpec.staticClass, global::java.security.spec.DSAPrivateKeySpec._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static DSAPrivateKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.DSAPrivateKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/DSAPrivateKeySpec"));
		}
	}
}
