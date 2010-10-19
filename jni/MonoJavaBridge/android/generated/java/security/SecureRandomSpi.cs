namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.SecureRandomSpi_))]
	public abstract partial class SecureRandomSpi : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecureRandomSpi()
		{
			InitJNI();
		}
		protected SecureRandomSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineSetSeed17598;
		protected abstract void engineSetSeed(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineNextBytes17599;
		protected abstract void engineNextBytes(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateSeed17600;
		protected abstract byte[] engineGenerateSeed(int arg0);
		internal static global::MonoJavaBridge.MethodId _SecureRandomSpi17601;
		public SecureRandomSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureRandomSpi.staticClass, global::java.security.SecureRandomSpi._SecureRandomSpi17601);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SecureRandomSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SecureRandomSpi"));
			global::java.security.SecureRandomSpi._engineSetSeed17598 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandomSpi.staticClass, "engineSetSeed", "([B)V");
			global::java.security.SecureRandomSpi._engineNextBytes17599 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandomSpi.staticClass, "engineNextBytes", "([B)V");
			global::java.security.SecureRandomSpi._engineGenerateSeed17600 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandomSpi.staticClass, "engineGenerateSeed", "(I)[B");
			global::java.security.SecureRandomSpi._SecureRandomSpi17601 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandomSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.SecureRandomSpi))]
	public sealed partial class SecureRandomSpi_ : java.security.SecureRandomSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecureRandomSpi_()
		{
			InitJNI();
		}
		internal SecureRandomSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineSetSeed17602;
		protected override void engineSetSeed(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SecureRandomSpi_._engineSetSeed17602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SecureRandomSpi_.staticClass, global::java.security.SecureRandomSpi_._engineSetSeed17602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineNextBytes17603;
		protected override void engineNextBytes(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SecureRandomSpi_._engineNextBytes17603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SecureRandomSpi_.staticClass, global::java.security.SecureRandomSpi_._engineNextBytes17603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSeed17604;
		protected override byte[] engineGenerateSeed(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SecureRandomSpi_._engineGenerateSeed17604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SecureRandomSpi_.staticClass, global::java.security.SecureRandomSpi_._engineGenerateSeed17604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SecureRandomSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SecureRandomSpi"));
			global::java.security.SecureRandomSpi_._engineSetSeed17602 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandomSpi_.staticClass, "engineSetSeed", "([B)V");
			global::java.security.SecureRandomSpi_._engineNextBytes17603 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandomSpi_.staticClass, "engineNextBytes", "([B)V");
			global::java.security.SecureRandomSpi_._engineGenerateSeed17604 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandomSpi_.staticClass, "engineGenerateSeed", "(I)[B");
		}
	}
}
