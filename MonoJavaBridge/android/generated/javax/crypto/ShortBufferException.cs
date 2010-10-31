namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ShortBufferException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ShortBufferException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ShortBufferException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ShortBufferException._m0.native == global::System.IntPtr.Zero)
				global::javax.crypto.ShortBufferException._m0 = @__env.GetMethodIDNoThrow(global::javax.crypto.ShortBufferException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ShortBufferException.staticClass, global::javax.crypto.ShortBufferException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ShortBufferException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ShortBufferException._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.ShortBufferException._m1 = @__env.GetMethodIDNoThrow(global::javax.crypto.ShortBufferException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ShortBufferException.staticClass, global::javax.crypto.ShortBufferException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ShortBufferException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ShortBufferException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ShortBufferException"));
		}
	}
}
