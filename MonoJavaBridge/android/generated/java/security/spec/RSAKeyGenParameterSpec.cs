namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAKeyGenParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.math.BigInteger getPublicExponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;", ref global::java.security.spec.RSAKeyGenParameterSpec._m0) as java.math.BigInteger;
		}
		public new int Keysize
		{
			get
			{
				return getKeysize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getKeysize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "getKeysize", "()I", ref global::java.security.spec.RSAKeyGenParameterSpec._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public RSAKeyGenParameterSpec(int arg0, java.math.BigInteger arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.RSAKeyGenParameterSpec._m2.native == global::System.IntPtr.Zero)
				global::java.security.spec.RSAKeyGenParameterSpec._m2 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "<init>", "(ILjava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAKeyGenParameterSpec.staticClass, global::java.security.spec.RSAKeyGenParameterSpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _F06542;
		public static global::java.math.BigInteger F0
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, _F06542)) as java.math.BigInteger;
			}
		}
		internal static global::MonoJavaBridge.FieldId _F46543;
		public static global::java.math.BigInteger F4
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, _F46543)) as java.math.BigInteger;
			}
		}
		static RSAKeyGenParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAKeyGenParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAKeyGenParameterSpec"));
			global::java.security.spec.RSAKeyGenParameterSpec._F06542 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "F0", "Ljava/math/BigInteger;");
			global::java.security.spec.RSAKeyGenParameterSpec._F46543 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "F4", "Ljava/math/BigInteger;");
		}
	}
}
