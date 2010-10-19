namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OAEPParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OAEPParameterSpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getDigestAlgorithm22765;
		public virtual global::java.lang.String getDigestAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.OAEPParameterSpec._getDigestAlgorithm22765)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.OAEPParameterSpec.staticClass, global::javax.crypto.spec.OAEPParameterSpec._getDigestAlgorithm22765)) as java.lang.String;
		}
		public new global::java.lang.String MGFAlgorithm
		{
			get
			{
				return getMGFAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMGFAlgorithm22766;
		public virtual global::java.lang.String getMGFAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.OAEPParameterSpec._getMGFAlgorithm22766)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.OAEPParameterSpec.staticClass, global::javax.crypto.spec.OAEPParameterSpec._getMGFAlgorithm22766)) as java.lang.String;
		}
		public new global::java.security.spec.AlgorithmParameterSpec MGFParameters
		{
			get
			{
				return getMGFParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMGFParameters22767;
		public virtual global::java.security.spec.AlgorithmParameterSpec getMGFParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.OAEPParameterSpec._getMGFParameters22767)) as java.security.spec.AlgorithmParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.OAEPParameterSpec.staticClass, global::javax.crypto.spec.OAEPParameterSpec._getMGFParameters22767)) as java.security.spec.AlgorithmParameterSpec;
		}
		public new global::javax.crypto.spec.PSource PSource
		{
			get
			{
				return getPSource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPSource22768;
		public virtual global::javax.crypto.spec.PSource getPSource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.OAEPParameterSpec._getPSource22768)) as javax.crypto.spec.PSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.OAEPParameterSpec.staticClass, global::javax.crypto.spec.OAEPParameterSpec._getPSource22768)) as javax.crypto.spec.PSource;
		}
		internal static global::MonoJavaBridge.MethodId _OAEPParameterSpec22769;
		public OAEPParameterSpec(java.lang.String arg0, java.lang.String arg1, java.security.spec.AlgorithmParameterSpec arg2, javax.crypto.spec.PSource arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.OAEPParameterSpec.staticClass, global::javax.crypto.spec.OAEPParameterSpec._OAEPParameterSpec22769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT22770;
		public static global::javax.crypto.spec.OAEPParameterSpec DEFAULT
		{
			get
			{
				return default(global::javax.crypto.spec.OAEPParameterSpec);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.OAEPParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/OAEPParameterSpec"));
			global::javax.crypto.spec.OAEPParameterSpec._getDigestAlgorithm22765 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getDigestAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.spec.OAEPParameterSpec._getMGFAlgorithm22766 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getMGFAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.spec.OAEPParameterSpec._getMGFParameters22767 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;");
			global::javax.crypto.spec.OAEPParameterSpec._getPSource22768 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.OAEPParameterSpec.staticClass, "getPSource", "()Ljavax/crypto/spec/PSource;");
			global::javax.crypto.spec.OAEPParameterSpec._OAEPParameterSpec22769 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.OAEPParameterSpec.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;Ljavax/crypto/spec/PSource;)V");
		}
	}
}
