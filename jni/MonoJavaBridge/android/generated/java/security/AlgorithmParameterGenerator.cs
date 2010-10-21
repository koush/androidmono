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
		internal static global::MonoJavaBridge.MethodId _getInstance22726;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getInstance22726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameterGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22727;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getInstance22727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.AlgorithmParameterGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22728;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getInstance22728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameterGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _init22729;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init22729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init22729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22730;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init22730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init22730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init22731;
		public virtual void init(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init22731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init22731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22732;
		public virtual void init(int arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init22732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init22732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22733;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._getAlgorithm22733)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getAlgorithm22733)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22734;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._getProvider22734)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getProvider22734)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generateParameters22735;
		public virtual global::java.security.AlgorithmParameters generateParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._generateParameters22735)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._generateParameters22735)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _AlgorithmParameterGenerator22736;
		protected AlgorithmParameterGenerator(java.security.AlgorithmParameterGeneratorSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._AlgorithmParameterGenerator22736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameterGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameterGenerator"));
			global::java.security.AlgorithmParameterGenerator._getInstance22726 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;");
			global::java.security.AlgorithmParameterGenerator._getInstance22727 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;");
			global::java.security.AlgorithmParameterGenerator._getInstance22728 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/AlgorithmParameterGenerator;");
			global::java.security.AlgorithmParameterGenerator._init22729 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParameterGenerator._init22730 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGenerator._init22731 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(I)V");
			global::java.security.AlgorithmParameterGenerator._init22732 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(ILjava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGenerator._getAlgorithm22733 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.AlgorithmParameterGenerator._getProvider22734 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.AlgorithmParameterGenerator._generateParameters22735 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "generateParameters", "()Ljava/security/AlgorithmParameters;");
			global::java.security.AlgorithmParameterGenerator._AlgorithmParameterGenerator22736 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "<init>", "(Ljava/security/AlgorithmParameterGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
