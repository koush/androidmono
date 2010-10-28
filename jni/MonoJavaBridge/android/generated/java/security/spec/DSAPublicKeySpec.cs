namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DSAPublicKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DSAPublicKeySpec()
		{
			InitJNI();
		}
		protected DSAPublicKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger P
		{
			get
			{
				return getP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getP23973;
		public virtual global::java.math.BigInteger getP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.DSAPublicKeySpec._getP23973)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.DSAPublicKeySpec.staticClass, global::java.security.spec.DSAPublicKeySpec._getP23973)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger Q
		{
			get
			{
				return getQ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQ23974;
		public virtual global::java.math.BigInteger getQ()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.DSAPublicKeySpec._getQ23974)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.DSAPublicKeySpec.staticClass, global::java.security.spec.DSAPublicKeySpec._getQ23974)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getG23975;
		public virtual global::java.math.BigInteger getG()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.DSAPublicKeySpec._getG23975)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.DSAPublicKeySpec.staticClass, global::java.security.spec.DSAPublicKeySpec._getG23975)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger Y
		{
			get
			{
				return getY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getY23976;
		public virtual global::java.math.BigInteger getY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.DSAPublicKeySpec._getY23976)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.DSAPublicKeySpec.staticClass, global::java.security.spec.DSAPublicKeySpec._getY23976)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _DSAPublicKeySpec23977;
		public DSAPublicKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.DSAPublicKeySpec.staticClass, global::java.security.spec.DSAPublicKeySpec._DSAPublicKeySpec23977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.DSAPublicKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/DSAPublicKeySpec"));
			global::java.security.spec.DSAPublicKeySpec._getP23973 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPublicKeySpec.staticClass, "getP", "()Ljava/math/BigInteger;");
			global::java.security.spec.DSAPublicKeySpec._getQ23974 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPublicKeySpec.staticClass, "getQ", "()Ljava/math/BigInteger;");
			global::java.security.spec.DSAPublicKeySpec._getG23975 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPublicKeySpec.staticClass, "getG", "()Ljava/math/BigInteger;");
			global::java.security.spec.DSAPublicKeySpec._getY23976 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPublicKeySpec.staticClass, "getY", "()Ljava/math/BigInteger;");
			global::java.security.spec.DSAPublicKeySpec._DSAPublicKeySpec23977 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPublicKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
		}
	}
}
