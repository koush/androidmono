namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DSAParameterSpec : java.lang.Object, AlgorithmParameterSpec, java.security.interfaces.DSAParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DSAParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger P
		{
			get
			{
				return getP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getP23964;
		public virtual global::java.math.BigInteger getP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.DSAParameterSpec.staticClass, "getP", "()Ljava/math/BigInteger;", ref global::java.security.spec.DSAParameterSpec._getP23964) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger Q
		{
			get
			{
				return getQ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQ23965;
		public virtual global::java.math.BigInteger getQ()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.DSAParameterSpec.staticClass, "getQ", "()Ljava/math/BigInteger;", ref global::java.security.spec.DSAParameterSpec._getQ23965) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getG23966;
		public virtual global::java.math.BigInteger getG()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.DSAParameterSpec.staticClass, "getG", "()Ljava/math/BigInteger;", ref global::java.security.spec.DSAParameterSpec._getG23966) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _DSAParameterSpec23967;
		public DSAParameterSpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.DSAParameterSpec._DSAParameterSpec23967.native == global::System.IntPtr.Zero)
				global::java.security.spec.DSAParameterSpec._DSAParameterSpec23967 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAParameterSpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.DSAParameterSpec.staticClass, global::java.security.spec.DSAParameterSpec._DSAParameterSpec23967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static DSAParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.DSAParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/DSAParameterSpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
