namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DHPrivateKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DHPrivateKeySpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getP22754;
		public virtual global::java.math.BigInteger getP() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPrivateKeySpec._getP22754)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPrivateKeySpec.staticClass, global::javax.crypto.spec.DHPrivateKeySpec._getP22754)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger G
		{
			get
			{
				return getG();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getG22755;
		public virtual global::java.math.BigInteger getG() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPrivateKeySpec._getG22755)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPrivateKeySpec.staticClass, global::javax.crypto.spec.DHPrivateKeySpec._getG22755)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger X
		{
			get
			{
				return getX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getX22756;
		public virtual global::java.math.BigInteger getX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPrivateKeySpec._getX22756)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DHPrivateKeySpec.staticClass, global::javax.crypto.spec.DHPrivateKeySpec._getX22756)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _DHPrivateKeySpec22757;
		public DHPrivateKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1, java.math.BigInteger arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DHPrivateKeySpec.staticClass, global::javax.crypto.spec.DHPrivateKeySpec._DHPrivateKeySpec22757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DHPrivateKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DHPrivateKeySpec"));
			global::javax.crypto.spec.DHPrivateKeySpec._getP22754 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPrivateKeySpec.staticClass, "getP", "()Ljava/math/BigInteger;");
			global::javax.crypto.spec.DHPrivateKeySpec._getG22755 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPrivateKeySpec.staticClass, "getG", "()Ljava/math/BigInteger;");
			global::javax.crypto.spec.DHPrivateKeySpec._getX22756 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPrivateKeySpec.staticClass, "getX", "()Ljava/math/BigInteger;");
			global::javax.crypto.spec.DHPrivateKeySpec._DHPrivateKeySpec22757 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DHPrivateKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
		}
	}
}
