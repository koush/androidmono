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
		internal static global::MonoJavaBridge.MethodId _getPublicExponent18319;
		public virtual global::java.math.BigInteger getPublicExponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAKeyGenParameterSpec._getPublicExponent18319)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAKeyGenParameterSpec.staticClass, global::java.security.spec.RSAKeyGenParameterSpec._getPublicExponent18319)) as java.math.BigInteger;
		}
		public new int Keysize
		{
			get
			{
				return getKeysize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeysize18320;
		public virtual int getKeysize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.RSAKeyGenParameterSpec._getKeysize18320);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.RSAKeyGenParameterSpec.staticClass, global::java.security.spec.RSAKeyGenParameterSpec._getKeysize18320);
		}
		internal static global::MonoJavaBridge.MethodId _RSAKeyGenParameterSpec18321;
		public RSAKeyGenParameterSpec(int arg0, java.math.BigInteger arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAKeyGenParameterSpec.staticClass, global::java.security.spec.RSAKeyGenParameterSpec._RSAKeyGenParameterSpec18321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _F018322;
		public static global::java.math.BigInteger F0
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		internal static global::MonoJavaBridge.FieldId _F418323;
		public static global::java.math.BigInteger F4
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAKeyGenParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAKeyGenParameterSpec"));
			global::java.security.spec.RSAKeyGenParameterSpec._getPublicExponent18319 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "getPublicExponent", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAKeyGenParameterSpec._getKeysize18320 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "getKeysize", "()I");
			global::java.security.spec.RSAKeyGenParameterSpec._RSAKeyGenParameterSpec18321 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAKeyGenParameterSpec.staticClass, "<init>", "(ILjava/math/BigInteger;)V");
		}
	}
}
