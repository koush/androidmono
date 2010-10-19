namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.AlgorithmParametersSpi_))]
	public abstract partial class AlgorithmParametersSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlgorithmParametersSpi()
		{
			InitJNI();
		}
		protected AlgorithmParametersSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit17159;
		protected abstract void engineInit(java.security.spec.AlgorithmParameterSpec arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit17160;
		protected abstract void engineInit(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit17161;
		protected abstract void engineInit(byte[] arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetParameterSpec17162;
		protected abstract global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded17163;
		protected abstract byte[] engineGetEncoded();
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded17164;
		protected abstract byte[] engineGetEncoded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineToString17165;
		protected abstract global::java.lang.String engineToString();
		internal static global::MonoJavaBridge.MethodId _AlgorithmParametersSpi17166;
		public AlgorithmParametersSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParametersSpi.staticClass, global::java.security.AlgorithmParametersSpi._AlgorithmParametersSpi17166);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
			global::java.security.AlgorithmParametersSpi._engineInit17159 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParametersSpi._engineInit17160 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineInit", "([B)V");
			global::java.security.AlgorithmParametersSpi._engineInit17161 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineInit", "([BLjava/lang/String;)V");
			global::java.security.AlgorithmParametersSpi._engineGetParameterSpec17162 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::java.security.AlgorithmParametersSpi._engineGetEncoded17163 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineGetEncoded", "()[B");
			global::java.security.AlgorithmParametersSpi._engineGetEncoded17164 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineGetEncoded", "(Ljava/lang/String;)[B");
			global::java.security.AlgorithmParametersSpi._engineToString17165 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineToString", "()Ljava/lang/String;");
			global::java.security.AlgorithmParametersSpi._AlgorithmParametersSpi17166 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.AlgorithmParametersSpi))]
	public sealed partial class AlgorithmParametersSpi_ : java.security.AlgorithmParametersSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlgorithmParametersSpi_()
		{
			InitJNI();
		}
		internal AlgorithmParametersSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit17167;
		protected override void engineInit(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineInit17167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineInit17167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit17168;
		protected override void engineInit(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineInit17168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineInit17168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit17169;
		protected override void engineInit(byte[] arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineInit17169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineInit17169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameterSpec17170;
		protected override global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec17170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec17170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded17171;
		protected override byte[] engineGetEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineGetEncoded17171)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineGetEncoded17171)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded17172;
		protected override byte[] engineGetEncoded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineGetEncoded17172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineGetEncoded17172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineToString17173;
		protected override global::java.lang.String engineToString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineToString17173)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineToString17173)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
			global::java.security.AlgorithmParametersSpi_._engineInit17167 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParametersSpi_._engineInit17168 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([B)V");
			global::java.security.AlgorithmParametersSpi_._engineInit17169 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([BLjava/lang/String;)V");
			global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec17170 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::java.security.AlgorithmParametersSpi_._engineGetEncoded17171 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "()[B");
			global::java.security.AlgorithmParametersSpi_._engineGetEncoded17172 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "(Ljava/lang/String;)[B");
			global::java.security.AlgorithmParametersSpi_._engineToString17173 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineToString", "()Ljava/lang/String;");
		}
	}
}
