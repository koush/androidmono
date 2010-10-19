namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DHPublicKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DHPublicKeySpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getP22758;
		public virtual global::java.math.BigInteger getP() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPublicKeySpec._getP22758)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPublicKeySpec.staticClass, global::javax.crypto.spec.DHPublicKeySpec._getP22758)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getG22759;
		public virtual global::java.math.BigInteger getG() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPublicKeySpec._getG22759)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPublicKeySpec.staticClass, global::javax.crypto.spec.DHPublicKeySpec._getG22759)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger Y
		{
			get
			{
				return getY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getY22760;
		public virtual global::java.math.BigInteger getY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPublicKeySpec._getY22760)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPublicKeySpec.staticClass, global::javax.crypto.spec.DHPublicKeySpec._getY22760)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _DHPublicKeySpec22761;
		public DHPublicKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHPublicKeySpec.staticClass, global::javax.crypto.spec.DHPublicKeySpec._DHPublicKeySpec22761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DHPublicKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DHPublicKeySpec"));
			global::javax.crypto.spec.DHPublicKeySpec._getP22758 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPublicKeySpec.staticClass, "getP", "()Ljava/math/BigInteger;");
			global::javax.crypto.spec.DHPublicKeySpec._getG22759 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPublicKeySpec.staticClass, "getG", "()Ljava/math/BigInteger;");
			global::javax.crypto.spec.DHPublicKeySpec._getY22760 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPublicKeySpec.staticClass, "getY", "()Ljava/math/BigInteger;");
			global::javax.crypto.spec.DHPublicKeySpec._DHPublicKeySpec22761 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPublicKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
		}
	}
}
