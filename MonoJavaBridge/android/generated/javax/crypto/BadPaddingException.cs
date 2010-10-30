namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BadPaddingException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BadPaddingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public BadPaddingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.BadPaddingException._m0.native == global::System.IntPtr.Zero)
				global::javax.crypto.BadPaddingException._m0 = @__env.GetMethodIDNoThrow(global::javax.crypto.BadPaddingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.BadPaddingException.staticClass, global::javax.crypto.BadPaddingException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public BadPaddingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.BadPaddingException._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.BadPaddingException._m1 = @__env.GetMethodIDNoThrow(global::javax.crypto.BadPaddingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.BadPaddingException.staticClass, global::javax.crypto.BadPaddingException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BadPaddingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.BadPaddingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/BadPaddingException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
