namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OAEPParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OAEPParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String DigestAlgorithm
		{
			get
			{
				return getDigestAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDigestAlgorithm28786;
		public virtual global::java.lang.String getDigestAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getDigestAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.spec.OAEPParameterSpec._getDigestAlgorithm28786) as java.lang.String;
		}
		public new global::java.lang.String MGFAlgorithm
		{
			get
			{
				return getMGFAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMGFAlgorithm28787;
		public virtual global::java.lang.String getMGFAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getMGFAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.spec.OAEPParameterSpec._getMGFAlgorithm28787) as java.lang.String;
		}
		public new global::java.security.spec.AlgorithmParameterSpec MGFParameters
		{
			get
			{
				return getMGFParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMGFParameters28788;
		public virtual global::java.security.spec.AlgorithmParameterSpec getMGFParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.AlgorithmParameterSpec>(this, global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", ref global::javax.crypto.spec.OAEPParameterSpec._getMGFParameters28788) as java.security.spec.AlgorithmParameterSpec;
		}
		public new global::javax.crypto.spec.PSource PSource
		{
			get
			{
				return getPSource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPSource28789;
		public virtual global::javax.crypto.spec.PSource getPSource()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getPSource", "()Ljavax/crypto/spec/PSource;", ref global::javax.crypto.spec.OAEPParameterSpec._getPSource28789) as javax.crypto.spec.PSource;
		}
		internal static global::MonoJavaBridge.MethodId _OAEPParameterSpec28790;
		public OAEPParameterSpec(java.lang.String arg0, java.lang.String arg1, java.security.spec.AlgorithmParameterSpec arg2, javax.crypto.spec.PSource arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.OAEPParameterSpec._OAEPParameterSpec28790.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.OAEPParameterSpec._OAEPParameterSpec28790 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.OAEPParameterSpec.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;Ljavax/crypto/spec/PSource;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.OAEPParameterSpec.staticClass, global::javax.crypto.spec.OAEPParameterSpec._OAEPParameterSpec28790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT28791;
		public static global::javax.crypto.spec.OAEPParameterSpec DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.crypto.spec.OAEPParameterSpec.staticClass, _DEFAULT28791)) as javax.crypto.spec.OAEPParameterSpec;
			}
		}
		static OAEPParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.OAEPParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/OAEPParameterSpec"));
			global::javax.crypto.spec.OAEPParameterSpec._DEFAULT28791 = @__env.GetStaticFieldIDNoThrow(global::javax.crypto.spec.OAEPParameterSpec.staticClass, "DEFAULT", "Ljavax/crypto/spec/OAEPParameterSpec;");
		}
		internal static void InitJNI()
		{
		}
	}
}
