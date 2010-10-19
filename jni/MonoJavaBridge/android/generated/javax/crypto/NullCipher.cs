namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NullCipher : javax.crypto.Cipher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NullCipher()
		{
			InitJNI();
		}
		protected NullCipher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NullCipher22692;
		public NullCipher()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.NullCipher.staticClass, global::javax.crypto.NullCipher._NullCipher22692);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.NullCipher.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/NullCipher"));
			global::javax.crypto.NullCipher._NullCipher22692 = @__env.GetMethodIDNoThrow(global::javax.crypto.NullCipher.staticClass, "<init>", "()V");
		}
	}
}
