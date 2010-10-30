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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getDigestAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getDigestAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.spec.OAEPParameterSpec._m0) as java.lang.String;
		}
		public new global::java.lang.String MGFAlgorithm
		{
			get
			{
				return getMGFAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getMGFAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getMGFAlgorithm", "()Ljava/lang/String;", ref global::javax.crypto.spec.OAEPParameterSpec._m1) as java.lang.String;
		}
		public new global::java.security.spec.AlgorithmParameterSpec MGFParameters
		{
			get
			{
				return getMGFParameters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.security.spec.AlgorithmParameterSpec getMGFParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.AlgorithmParameterSpec>(this, global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", ref global::javax.crypto.spec.OAEPParameterSpec._m2) as java.security.spec.AlgorithmParameterSpec;
		}
		public new global::javax.crypto.spec.PSource PSource
		{
			get
			{
				return getPSource();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::javax.crypto.spec.PSource getPSource()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getPSource", "()Ljavax/crypto/spec/PSource;", ref global::javax.crypto.spec.OAEPParameterSpec._m3) as javax.crypto.spec.PSource;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public OAEPParameterSpec(java.lang.String arg0, java.lang.String arg1, java.security.spec.AlgorithmParameterSpec arg2, javax.crypto.spec.PSource arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.OAEPParameterSpec._m4.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.OAEPParameterSpec._m4 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.OAEPParameterSpec.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;Ljavax/crypto/spec/PSource;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.OAEPParameterSpec.staticClass, global::javax.crypto.spec.OAEPParameterSpec._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT6726;
		public static global::javax.crypto.spec.OAEPParameterSpec DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.crypto.spec.OAEPParameterSpec.staticClass, _DEFAULT6726)) as javax.crypto.spec.OAEPParameterSpec;
			}
		}
		static OAEPParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.OAEPParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/OAEPParameterSpec"));
			global::javax.crypto.spec.OAEPParameterSpec._DEFAULT6726 = @__env.GetStaticFieldIDNoThrow(global::javax.crypto.spec.OAEPParameterSpec.staticClass, "DEFAULT", "Ljavax/crypto/spec/OAEPParameterSpec;");
		}
		internal static void InitJNI()
		{
		}
	}
}
