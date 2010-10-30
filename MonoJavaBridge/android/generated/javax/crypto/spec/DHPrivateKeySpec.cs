namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DHPrivateKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DHPrivateKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger P
		{
			get
			{
				return getP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getP28775;
		public virtual global::java.math.BigInteger getP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.DHPrivateKeySpec.staticClass, "getP", "()Ljava/math/BigInteger;", ref global::javax.crypto.spec.DHPrivateKeySpec._getP28775) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getG28776;
		public virtual global::java.math.BigInteger getG()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.DHPrivateKeySpec.staticClass, "getG", "()Ljava/math/BigInteger;", ref global::javax.crypto.spec.DHPrivateKeySpec._getG28776) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger X
		{
			get
			{
				return getX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getX28777;
		public virtual global::java.math.BigInteger getX()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.DHPrivateKeySpec.staticClass, "getX", "()Ljava/math/BigInteger;", ref global::javax.crypto.spec.DHPrivateKeySpec._getX28777) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _DHPrivateKeySpec28778;
		public DHPrivateKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DHPrivateKeySpec._DHPrivateKeySpec28778.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DHPrivateKeySpec._DHPrivateKeySpec28778 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPrivateKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHPrivateKeySpec.staticClass, global::javax.crypto.spec.DHPrivateKeySpec._DHPrivateKeySpec28778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static DHPrivateKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DHPrivateKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DHPrivateKeySpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
