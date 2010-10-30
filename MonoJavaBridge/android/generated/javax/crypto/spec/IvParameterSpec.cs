namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IvParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IvParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIV28783;
		public virtual byte[] getIV()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.IvParameterSpec.staticClass, "getIV", "()[B", ref global::javax.crypto.spec.IvParameterSpec._getIV28783) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _IvParameterSpec28784;
		public IvParameterSpec(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.IvParameterSpec._IvParameterSpec28784.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.IvParameterSpec._IvParameterSpec28784 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.IvParameterSpec.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.IvParameterSpec.staticClass, global::javax.crypto.spec.IvParameterSpec._IvParameterSpec28784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IvParameterSpec28785;
		public IvParameterSpec(byte[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.IvParameterSpec._IvParameterSpec28785.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.IvParameterSpec._IvParameterSpec28785 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.IvParameterSpec.staticClass, "<init>", "([BII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.IvParameterSpec.staticClass, global::javax.crypto.spec.IvParameterSpec._IvParameterSpec28785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static IvParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.IvParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/IvParameterSpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
