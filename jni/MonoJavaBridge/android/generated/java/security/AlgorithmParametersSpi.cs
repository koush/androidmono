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
		internal static global::MonoJavaBridge.MethodId _engineInit22757;
		protected abstract void engineInit(java.security.spec.AlgorithmParameterSpec arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit22758;
		protected abstract void engineInit(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit22759;
		protected abstract void engineInit(byte[] arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetParameterSpec22760;
		protected abstract global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22761;
		protected abstract byte[] engineGetEncoded();
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22762;
		protected abstract byte[] engineGetEncoded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineToString22763;
		protected abstract global::java.lang.String engineToString();
		internal static global::MonoJavaBridge.MethodId _AlgorithmParametersSpi22764;
		public AlgorithmParametersSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParametersSpi.staticClass, global::java.security.AlgorithmParametersSpi._AlgorithmParametersSpi22764);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
			global::java.security.AlgorithmParametersSpi._engineInit22757 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParametersSpi._engineInit22758 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineInit", "([B)V");
			global::java.security.AlgorithmParametersSpi._engineInit22759 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineInit", "([BLjava/lang/String;)V");
			global::java.security.AlgorithmParametersSpi._engineGetParameterSpec22760 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::java.security.AlgorithmParametersSpi._engineGetEncoded22761 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineGetEncoded", "()[B");
			global::java.security.AlgorithmParametersSpi._engineGetEncoded22762 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineGetEncoded", "(Ljava/lang/String;)[B");
			global::java.security.AlgorithmParametersSpi._engineToString22763 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "engineToString", "()Ljava/lang/String;");
			global::java.security.AlgorithmParametersSpi._AlgorithmParametersSpi22764 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _engineInit22765;
		protected override void engineInit(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineInit22765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineInit22765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22766;
		protected override void engineInit(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineInit22766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineInit22766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22767;
		protected override void engineInit(byte[] arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineInit22767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineInit22767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameterSpec22768;
		protected override global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec22768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.AlgorithmParameterSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec22768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.AlgorithmParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22769;
		protected override byte[] engineGetEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineGetEncoded22769)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineGetEncoded22769)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22770;
		protected override byte[] engineGetEncoded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineGetEncoded22770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineGetEncoded22770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineToString22771;
		protected override global::java.lang.String engineToString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_._engineToString22771)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParametersSpi_.staticClass, global::java.security.AlgorithmParametersSpi_._engineToString22771)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
			global::java.security.AlgorithmParametersSpi_._engineInit22765 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.AlgorithmParametersSpi_._engineInit22766 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([B)V");
			global::java.security.AlgorithmParametersSpi_._engineInit22767 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([BLjava/lang/String;)V");
			global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec22768 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;");
			global::java.security.AlgorithmParametersSpi_._engineGetEncoded22769 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "()[B");
			global::java.security.AlgorithmParametersSpi_._engineGetEncoded22770 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "(Ljava/lang/String;)[B");
			global::java.security.AlgorithmParametersSpi_._engineToString22771 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi_.staticClass, "engineToString", "()Ljava/lang/String;");
		}
	}
}
