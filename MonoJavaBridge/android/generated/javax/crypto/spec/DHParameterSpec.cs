namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DHParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DHParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.DHParameterSpec.staticClass, "getP", "()Ljava/math/BigInteger;", ref global::javax.crypto.spec.DHParameterSpec._m0) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.math.BigInteger getG()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.DHParameterSpec.staticClass, "getG", "()Ljava/math/BigInteger;", ref global::javax.crypto.spec.DHParameterSpec._m1) as java.math.BigInteger;
		}
		public new int L
		{
			get
			{
				return getL();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getL()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.DHParameterSpec.staticClass, "getL", "()I", ref global::javax.crypto.spec.DHParameterSpec._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DHParameterSpec(java.math.BigInteger arg0, java.math.BigInteger arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DHParameterSpec._m3.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DHParameterSpec._m3 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHParameterSpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHParameterSpec.staticClass, global::javax.crypto.spec.DHParameterSpec._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public DHParameterSpec(java.math.BigInteger arg0, java.math.BigInteger arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DHParameterSpec._m4.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DHParameterSpec._m4 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHParameterSpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHParameterSpec.staticClass, global::javax.crypto.spec.DHParameterSpec._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static DHParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DHParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DHParameterSpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
