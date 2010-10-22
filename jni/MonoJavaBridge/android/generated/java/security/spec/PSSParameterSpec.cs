namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PSSParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PSSParameterSpec()
		{
			InitJNI();
		}
		protected PSSParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String DigestAlgorithm
		{
			get
			{
				return getDigestAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDigestAlgorithm23920;
		public virtual global::java.lang.String getDigestAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec._getDigestAlgorithm23920)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._getDigestAlgorithm23920)) as java.lang.String;
		}
		public new global::java.lang.String MGFAlgorithm
		{
			get
			{
				return getMGFAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMGFAlgorithm23921;
		public virtual global::java.lang.String getMGFAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec._getMGFAlgorithm23921)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._getMGFAlgorithm23921)) as java.lang.String;
		}
		public new global::java.security.spec.AlgorithmParameterSpec MGFParameters
		{
			get
			{
				return getMGFParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMGFParameters23922;
		public virtual global::java.security.spec.AlgorithmParameterSpec getMGFParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec._getMGFParameters23922)) as java.security.spec.AlgorithmParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._getMGFParameters23922)) as java.security.spec.AlgorithmParameterSpec;
		}
		public new int SaltLength
		{
			get
			{
				return getSaltLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSaltLength23923;
		public virtual int getSaltLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec._getSaltLength23923);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._getSaltLength23923);
		}
		public new int TrailerField
		{
			get
			{
				return getTrailerField();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrailerField23924;
		public virtual int getTrailerField() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec._getTrailerField23924);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._getTrailerField23924);
		}
		internal static global::MonoJavaBridge.MethodId _PSSParameterSpec23925;
		public PSSParameterSpec(java.lang.String arg0, java.lang.String arg1, java.security.spec.AlgorithmParameterSpec arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._PSSParameterSpec23925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PSSParameterSpec23926;
		public PSSParameterSpec(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._PSSParameterSpec23926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT23927;
		public static global::java.security.spec.PSSParameterSpec DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.PSSParameterSpec.staticClass, _DEFAULT23927)) as java.security.spec.PSSParameterSpec;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.PSSParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/PSSParameterSpec"));
			global::java.security.spec.PSSParameterSpec._getDigestAlgorithm23920 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "getDigestAlgorithm", "()Ljava/lang/String;");
			global::java.security.spec.PSSParameterSpec._getMGFAlgorithm23921 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "getMGFAlgorithm", "()Ljava/lang/String;");
			global::java.security.spec.PSSParameterSpec._getMGFParameters23922 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;");
			global::java.security.spec.PSSParameterSpec._getSaltLength23923 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "getSaltLength", "()I");
			global::java.security.spec.PSSParameterSpec._getTrailerField23924 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "getTrailerField", "()I");
			global::java.security.spec.PSSParameterSpec._PSSParameterSpec23925 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;II)V");
			global::java.security.spec.PSSParameterSpec._PSSParameterSpec23926 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "<init>", "(I)V");
			global::java.security.spec.PSSParameterSpec._DEFAULT23927 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "DEFAULT", "Ljava/security/spec/PSSParameterSpec;");
		}
	}
}
