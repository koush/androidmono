namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PSSParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getDigestAlgorithm24039;
		public virtual global::java.lang.String getDigestAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.spec.PSSParameterSpec.staticClass, "getDigestAlgorithm", "()Ljava/lang/String;", ref global::java.security.spec.PSSParameterSpec._getDigestAlgorithm24039) as java.lang.String;
		}
		public new global::java.lang.String MGFAlgorithm
		{
			get
			{
				return getMGFAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMGFAlgorithm24040;
		public virtual global::java.lang.String getMGFAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.spec.PSSParameterSpec.staticClass, "getMGFAlgorithm", "()Ljava/lang/String;", ref global::java.security.spec.PSSParameterSpec._getMGFAlgorithm24040) as java.lang.String;
		}
		public new global::java.security.spec.AlgorithmParameterSpec MGFParameters
		{
			get
			{
				return getMGFParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMGFParameters24041;
		public virtual global::java.security.spec.AlgorithmParameterSpec getMGFParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.AlgorithmParameterSpec>(this, global::java.security.spec.PSSParameterSpec.staticClass, "getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", ref global::java.security.spec.PSSParameterSpec._getMGFParameters24041) as java.security.spec.AlgorithmParameterSpec;
		}
		public new int SaltLength
		{
			get
			{
				return getSaltLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSaltLength24042;
		public virtual int getSaltLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.PSSParameterSpec.staticClass, "getSaltLength", "()I", ref global::java.security.spec.PSSParameterSpec._getSaltLength24042);
		}
		public new int TrailerField
		{
			get
			{
				return getTrailerField();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrailerField24043;
		public virtual int getTrailerField()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.PSSParameterSpec.staticClass, "getTrailerField", "()I", ref global::java.security.spec.PSSParameterSpec._getTrailerField24043);
		}
		internal static global::MonoJavaBridge.MethodId _PSSParameterSpec24044;
		public PSSParameterSpec(java.lang.String arg0, java.lang.String arg1, java.security.spec.AlgorithmParameterSpec arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.PSSParameterSpec._PSSParameterSpec24044.native == global::System.IntPtr.Zero)
				global::java.security.spec.PSSParameterSpec._PSSParameterSpec24044 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._PSSParameterSpec24044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PSSParameterSpec24045;
		public PSSParameterSpec(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.PSSParameterSpec._PSSParameterSpec24045.native == global::System.IntPtr.Zero)
				global::java.security.spec.PSSParameterSpec._PSSParameterSpec24045 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._PSSParameterSpec24045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT24046;
		public static global::java.security.spec.PSSParameterSpec DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.PSSParameterSpec.staticClass, _DEFAULT24046)) as java.security.spec.PSSParameterSpec;
			}
		}
		static PSSParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.PSSParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/PSSParameterSpec"));
			global::java.security.spec.PSSParameterSpec._DEFAULT24046 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "DEFAULT", "Ljava/security/spec/PSSParameterSpec;");
		}
		internal static void InitJNI()
		{
		}
	}
}
