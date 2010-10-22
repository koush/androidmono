namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPathBuilder()
		{
			InitJNI();
		}
		protected CertPathBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23376;
		public static global::java.security.cert.CertPathBuilder getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._getInstance23376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23377;
		public static global::java.security.cert.CertPathBuilder getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._getInstance23377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23378;
		public static global::java.security.cert.CertPathBuilder getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._getInstance23378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPathBuilder;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23379;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilder._getAlgorithm23379)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._getAlgorithm23379)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23380;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilder._getProvider23380)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._getProvider23380)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _build23381;
		public virtual global::java.security.cert.CertPathBuilderResult build(java.security.cert.CertPathParameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertPathBuilderResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilder._build23381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPathBuilderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertPathBuilderResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._build23381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPathBuilderResult;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultType23382;
		public static global::java.lang.String getDefaultType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._getDefaultType23382)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _CertPathBuilder23383;
		protected CertPathBuilder(java.security.cert.CertPathBuilderSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._CertPathBuilder23383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilder"));
			global::java.security.cert.CertPathBuilder._getInstance23376 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertPathBuilder;");
			global::java.security.cert.CertPathBuilder._getInstance23377 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertPathBuilder;");
			global::java.security.cert.CertPathBuilder._getInstance23378 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertPathBuilder;");
			global::java.security.cert.CertPathBuilder._getAlgorithm23379 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.cert.CertPathBuilder._getProvider23380 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.cert.CertPathBuilder._build23381 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "build", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResult;");
			global::java.security.cert.CertPathBuilder._getDefaultType23382 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getDefaultType", "()Ljava/lang/String;");
			global::java.security.cert.CertPathBuilder._CertPathBuilder23383 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "<init>", "(Ljava/security/cert/CertPathBuilderSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
