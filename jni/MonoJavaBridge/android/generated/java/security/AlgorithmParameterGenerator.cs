namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlgorithmParameterGenerator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlgorithmParameterGenerator()
		{
			InitJNI();
		}
		protected AlgorithmParameterGenerator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17128;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getInstance17128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameterGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17129;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getInstance17129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.AlgorithmParameterGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17130;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getInstance17130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameterGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _init17131;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init17131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init17131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init17132;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init17132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init17132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init17133;
		public virtual void init(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init17133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init17133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init17134;
		public virtual void init(int arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init17134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init17134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm17135;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._getAlgorithm17135)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getAlgorithm17135)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider17136;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._getProvider17136)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getProvider17136)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generateParameters17137;
		public virtual global::java.security.AlgorithmParameters generateParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._generateParameters17137)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._generateParameters17137)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _AlgorithmParameterGenerator17138;
		protected AlgorithmParameterGenerator(java.security.AlgorithmParameterGeneratorSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._AlgorithmParameterGenerator17138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameterGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameterGenerator"));
			global::java.security.AlgorithmParameterGenerator._getInstance17128 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;");
			global::java.security.AlgorithmParameterGenerator._getInstance17129 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;");
			global::java.security.AlgorithmParameterGenerator._getInstance17130 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/AlgorithmParameterGenerator;");
			global::java.security.AlgorithmParameterGenerator._init17131 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParameterGenerator._init17132 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGenerator._init17133 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(I)V");
			global::java.security.AlgorithmParameterGenerator._init17134 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(ILjava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGenerator._getAlgorithm17135 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.AlgorithmParameterGenerator._getProvider17136 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.AlgorithmParameterGenerator._generateParameters17137 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "generateParameters", "()Ljava/security/AlgorithmParameters;");
			global::java.security.AlgorithmParameterGenerator._AlgorithmParameterGenerator17138 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "<init>", "(Ljava/security/AlgorithmParameterGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
