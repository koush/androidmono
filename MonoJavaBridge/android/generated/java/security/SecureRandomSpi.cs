namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.SecureRandomSpi_))]
	public abstract partial class SecureRandomSpi : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecureRandomSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineSetSeed23318;
		protected abstract void engineSetSeed(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineNextBytes23319;
		protected abstract void engineNextBytes(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateSeed23320;
		protected abstract byte[] engineGenerateSeed(int arg0);
		internal static global::MonoJavaBridge.MethodId _SecureRandomSpi23321;
		public SecureRandomSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecureRandomSpi._SecureRandomSpi23321.native == global::System.IntPtr.Zero)
				global::java.security.SecureRandomSpi._SecureRandomSpi23321 = @__env.GetMethodIDNoThrow(global::java.security.SecureRandomSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureRandomSpi.staticClass, global::java.security.SecureRandomSpi._SecureRandomSpi23321);
			Init(@__env, handle);
		}
		static SecureRandomSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SecureRandomSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SecureRandomSpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.SecureRandomSpi))]
	internal sealed partial class SecureRandomSpi_ : java.security.SecureRandomSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SecureRandomSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineSetSeed23322;
		protected override void engineSetSeed(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SecureRandomSpi_.staticClass, "engineSetSeed", "([B)V", ref global::java.security.SecureRandomSpi_._engineSetSeed23322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineNextBytes23323;
		protected override void engineNextBytes(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.SecureRandomSpi_.staticClass, "engineNextBytes", "([B)V", ref global::java.security.SecureRandomSpi_._engineNextBytes23323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSeed23324;
		protected override byte[] engineGenerateSeed(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.SecureRandomSpi_.staticClass, "engineGenerateSeed", "(I)[B", ref global::java.security.SecureRandomSpi_._engineGenerateSeed23324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		static SecureRandomSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SecureRandomSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SecureRandomSpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
