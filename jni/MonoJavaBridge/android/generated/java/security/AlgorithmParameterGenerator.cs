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
		internal static global::MonoJavaBridge.MethodId _getInstance22844;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getInstance22844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameterGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22845;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getInstance22845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.AlgorithmParameterGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22846;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getInstance22846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameterGenerator;
		}
		internal static global::MonoJavaBridge.MethodId _init22847;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init22847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init22847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22848;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init22848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init22848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _init22849;
		public virtual void init(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init22849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init22849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22850;
		public virtual void init(int arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._init22850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._init22850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22851;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._getAlgorithm22851)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getAlgorithm22851)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22852;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._getProvider22852)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._getProvider22852)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _generateParameters22853;
		public virtual global::java.security.AlgorithmParameters generateParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator._generateParameters22853)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._generateParameters22853)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _AlgorithmParameterGenerator22854;
		protected AlgorithmParameterGenerator(java.security.AlgorithmParameterGeneratorSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._AlgorithmParameterGenerator22854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameterGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameterGenerator"));
			global::java.security.AlgorithmParameterGenerator._getInstance22844 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;");
			global::java.security.AlgorithmParameterGenerator._getInstance22845 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;");
			global::java.security.AlgorithmParameterGenerator._getInstance22846 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/AlgorithmParameterGenerator;");
			global::java.security.AlgorithmParameterGenerator._init22847 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParameterGenerator._init22848 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGenerator._init22849 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(I)V");
			global::java.security.AlgorithmParameterGenerator._init22850 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(ILjava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGenerator._getAlgorithm22851 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.AlgorithmParameterGenerator._getProvider22852 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.AlgorithmParameterGenerator._generateParameters22853 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "generateParameters", "()Ljava/security/AlgorithmParameters;");
			global::java.security.AlgorithmParameterGenerator._AlgorithmParameterGenerator22854 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "<init>", "(Ljava/security/AlgorithmParameterGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
