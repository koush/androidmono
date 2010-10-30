namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DHPublicKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DHPublicKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger P
		{
			get
			{
				return getP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getP28779;
		public virtual global::java.math.BigInteger getP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DHPublicKeySpec._getP28779.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DHPublicKeySpec._getP28779 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPublicKeySpec.staticClass, "getP", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.DHPublicKeySpec.staticClass, global::javax.crypto.spec.DHPublicKeySpec._getP28779) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getG28780;
		public virtual global::java.math.BigInteger getG()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DHPublicKeySpec._getG28780.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DHPublicKeySpec._getG28780 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPublicKeySpec.staticClass, "getG", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.DHPublicKeySpec.staticClass, global::javax.crypto.spec.DHPublicKeySpec._getG28780) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger Y
		{
			get
			{
				return getY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getY28781;
		public virtual global::java.math.BigInteger getY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DHPublicKeySpec._getY28781.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DHPublicKeySpec._getY28781 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPublicKeySpec.staticClass, "getY", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.DHPublicKeySpec.staticClass, global::javax.crypto.spec.DHPublicKeySpec._getY28781) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _DHPublicKeySpec28782;
		public DHPublicKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DHPublicKeySpec._DHPublicKeySpec28782.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DHPublicKeySpec._DHPublicKeySpec28782 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPublicKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHPublicKeySpec.staticClass, global::javax.crypto.spec.DHPublicKeySpec._DHPublicKeySpec28782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static DHPublicKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DHPublicKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DHPublicKeySpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
