namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAKeyGenParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAKeyGenParameterSpec()
		{
			InitJNI();
		}
		protected RSAKeyGenParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger PublicExponent
		{
			get
			{
				return getPublicExponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicExponent24047;
		public virtual global::java.math.BigInteger getPublicExponent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAKeyGenParameterSpec._getPublicExponent24047)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAKeyGenParameterSpec.staticClass, global::java.security.spec.RSAKeyGenParameterSpec._getPublicExponent24047)) as java.math.BigInteger;
		}
		public new int Keysize
		{
			get
			{
				return getKeysize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeysize24048;
		public virtual int getKeysize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.RSAKeyGenParameterSpec._getKeysize24048);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.RSAKeyGenParameterSpec.staticClass, global::java.security.spec.RSAKeyGenParameterSpec._getKeysize24048);
		}
		internal static global::MonoJavaBridge.MethodId _RSAKeyGenParameterSpec24049;
		public RSAKeyGenParameterSpec(int arg0, java.math.BigInteger arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAKeyGenParameterSpec.staticClass, global::java.security.spec.RSAKeyGenParameterSpec._RSAKeyGenParameterSpec24049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _F024050;
		public static global::java.math.BigInteger F0
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, _F024050)) as java.math.BigInteger;
			}
		}
		internal static global::MonoJavaBridge.FieldId _F424051;
		public static global::java.math.BigInteger F4
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, _F424051)) as java.math.BigInteger;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAKeyGenParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAKeyGenParameterSpec"));
			global::java.security.spec.RSAKeyGenParameterSpec._getPublicExponent24047 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAKeyGenParameterSpec._getKeysize24048 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "getKeysize", "()I");
			global::java.security.spec.RSAKeyGenParameterSpec._RSAKeyGenParameterSpec24049 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "<init>", "(ILjava/math/BigInteger;)V");
			global::java.security.spec.RSAKeyGenParameterSpec._F024050 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "F0", "Ljava/math/BigInteger;");
			global::java.security.spec.RSAKeyGenParameterSpec._F424051 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "F4", "Ljava/math/BigInteger;");
		}
	}
}
