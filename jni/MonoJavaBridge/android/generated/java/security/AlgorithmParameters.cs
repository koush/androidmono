namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlgorithmParameters : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlgorithmParameters()
		{
			InitJNI();
		}
		protected AlgorithmParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22862;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters._toString22862)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._toString22862)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22863;
		public static global::java.security.AlgorithmParameters getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._getInstance22863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22864;
		public static global::java.security.AlgorithmParameters getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._getInstance22864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance22865;
		public static global::java.security.AlgorithmParameters getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._getInstance22865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _init22866;
		public virtual void init(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameters._init22866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._init22866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22867;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameters._init22867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._init22867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init22868;
		public virtual void init(byte[] arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameters._init22868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._init22868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded22869;
		public virtual byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters._getEncoded22869)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._getEncoded22869)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded22870;
		public virtual byte[] getEncoded(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters._getEncoded22870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._getEncoded22870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm22871;
		public virtual global::java.lang.String getAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters._getAlgorithm22871)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._getAlgorithm22871)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider22872;
		public virtual global::java.security.Provider getProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters._getProvider22872)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._getProvider22872)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterSpec22873;
		public virtual global::java.security.spec.AlgorithmParameterSpec getParameterSpec(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters._getParameterSpec22873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._getParameterSpec22873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _AlgorithmParameters22874;
		protected AlgorithmParameters(java.security.AlgorithmParametersSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._AlgorithmParameters22874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameters"));
			global::java.security.AlgorithmParameters._toString22862 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.AlgorithmParameters._getInstance22863 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameters;");
			global::java.security.AlgorithmParameters._getInstance22864 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/AlgorithmParameters;");
			global::java.security.AlgorithmParameters._getInstance22865 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/AlgorithmParameters;");
			global::java.security.AlgorithmParameters._init22866 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "init", "([B)V");
			global::java.security.AlgorithmParameters._init22867 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParameters._init22868 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "init", "([BLjava/lang/String;)V");
			global::java.security.AlgorithmParameters._getEncoded22869 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getEncoded", "()[B");
			global::java.security.AlgorithmParameters._getEncoded22870 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getEncoded", "(Ljava/lang/String;)[B");
			global::java.security.AlgorithmParameters._getAlgorithm22871 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.AlgorithmParameters._getProvider22872 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.AlgorithmParameters._getParameterSpec22873 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::java.security.AlgorithmParameters._AlgorithmParameters22874 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "<init>", "(Ljava/security/AlgorithmParametersSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
