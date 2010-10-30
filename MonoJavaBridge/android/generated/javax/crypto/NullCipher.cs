namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NullCipher : javax.crypto.Cipher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NullCipher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NullCipher() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.NullCipher._m0.native == global::System.IntPtr.Zero)
				global::javax.crypto.NullCipher._m0 = @__env.GetMethodIDNoThrow(global::javax.crypto.NullCipher.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.NullCipher.staticClass, global::javax.crypto.NullCipher._m0);
			Init(@__env, handle);
		}
		static NullCipher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.NullCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/NullCipher"));
		}
		internal static void InitJNI()
		{
		}
	}
}
