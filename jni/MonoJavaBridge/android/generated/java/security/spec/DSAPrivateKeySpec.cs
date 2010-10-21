namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DSAPrivateKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DSAPrivateKeySpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getP23849;
		public virtual global::java.math.BigInteger getP() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.DSAPrivateKeySpec._getP23849)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.DSAPrivateKeySpec.staticClass, global::java.security.spec.DSAPrivateKeySpec._getP23849)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger Q
		{
			get
			{
				return getQ();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQ23850;
		public virtual global::java.math.BigInteger getQ() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.DSAPrivateKeySpec._getQ23850)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.DSAPrivateKeySpec.staticClass, global::java.security.spec.DSAPrivateKeySpec._getQ23850)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getG23851;
		public virtual global::java.math.BigInteger getG() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.DSAPrivateKeySpec._getG23851)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.DSAPrivateKeySpec.staticClass, global::java.security.spec.DSAPrivateKeySpec._getG23851)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger X
		{
			get
			{
				return getX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getX23852;
		public virtual global::java.math.BigInteger getX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.DSAPrivateKeySpec._getX23852)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.DSAPrivateKeySpec.staticClass, global::java.security.spec.DSAPrivateKeySpec._getX23852)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _DSAPrivateKeySpec23853;
		public DSAPrivateKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.DSAPrivateKeySpec.staticClass, global::java.security.spec.DSAPrivateKeySpec._DSAPrivateKeySpec23853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.DSAPrivateKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/DSAPrivateKeySpec"));
			global::java.security.spec.DSAPrivateKeySpec._getP23849 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPrivateKeySpec.staticClass, "getP", "()Ljava/math/BigInteger;");
			global::java.security.spec.DSAPrivateKeySpec._getQ23850 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPrivateKeySpec.staticClass, "getQ", "()Ljava/math/BigInteger;");
			global::java.security.spec.DSAPrivateKeySpec._getG23851 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPrivateKeySpec.staticClass, "getG", "()Ljava/math/BigInteger;");
			global::java.security.spec.DSAPrivateKeySpec._getX23852 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPrivateKeySpec.staticClass, "getX", "()Ljava/math/BigInteger;");
			global::java.security.spec.DSAPrivateKeySpec._DSAPrivateKeySpec23853 = @__env.GetMethodIDNoThrow(global::java.security.spec.DSAPrivateKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
		}
	}
}
