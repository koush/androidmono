namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.AlgorithmParametersSpi_))]
	public abstract partial class AlgorithmParametersSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlgorithmParametersSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22876;
		protected abstract void engineInit(java.security.spec.AlgorithmParameterSpec arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit22877;
		protected abstract void engineInit(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit22878;
		protected abstract void engineInit(byte[] arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetParameterSpec22879;
		protected abstract global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22880;
		protected abstract byte[] engineGetEncoded();
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22881;
		protected abstract byte[] engineGetEncoded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineToString22882;
		protected abstract global::java.lang.String engineToString();
		internal static global::MonoJavaBridge.MethodId _AlgorithmParametersSpi22883;
		public AlgorithmParametersSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParametersSpi.staticClass, global::java.security.AlgorithmParametersSpi._AlgorithmParametersSpi22883);
			Init(@__env, handle);
		}
		static AlgorithmParametersSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
			global::java.security.AlgorithmParametersSpi._engineInit22876 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParametersSpi._engineInit22877 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineInit", "([B)V");
			global::java.security.AlgorithmParametersSpi._engineInit22878 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineInit", "([BLjava/lang/String;)V");
			global::java.security.AlgorithmParametersSpi._engineGetParameterSpec22879 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::java.security.AlgorithmParametersSpi._engineGetEncoded22880 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineGetEncoded", "()[B");
			global::java.security.AlgorithmParametersSpi._engineGetEncoded22881 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineGetEncoded", "(Ljava/lang/String;)[B");
			global::java.security.AlgorithmParametersSpi._engineToString22882 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineToString", "()Ljava/lang/String;");
			global::java.security.AlgorithmParametersSpi._AlgorithmParametersSpi22883 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.AlgorithmParametersSpi))]
	internal sealed partial class AlgorithmParametersSpi_ : java.security.AlgorithmParametersSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AlgorithmParametersSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22884;
		protected override void engineInit(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineInit22884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineInit22884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22885;
		protected override void engineInit(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineInit22885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineInit22885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22886;
		protected override void engineInit(byte[] arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineInit22886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineInit22886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameterSpec22887;
		protected override global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec22887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec22887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22888;
		protected override byte[] engineGetEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineGetEncoded22888)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineGetEncoded22888)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22889;
		protected override byte[] engineGetEncoded(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineGetEncoded22889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineGetEncoded22889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineToString22890;
		protected override global::java.lang.String engineToString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineToString22890)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineToString22890)) as java.lang.String;
		}
		static AlgorithmParametersSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
			global::java.security.AlgorithmParametersSpi_._engineInit22884 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParametersSpi_._engineInit22885 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([B)V");
			global::java.security.AlgorithmParametersSpi_._engineInit22886 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([BLjava/lang/String;)V");
			global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec22887 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::java.security.AlgorithmParametersSpi_._engineGetEncoded22888 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "()[B");
			global::java.security.AlgorithmParametersSpi_._engineGetEncoded22889 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "(Ljava/lang/String;)[B");
			global::java.security.AlgorithmParametersSpi_._engineToString22890 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineToString", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
