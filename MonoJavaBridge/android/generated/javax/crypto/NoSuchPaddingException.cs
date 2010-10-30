namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchPaddingException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchPaddingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NoSuchPaddingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.NoSuchPaddingException._m0.native == global::System.IntPtr.Zero)
				global::javax.crypto.NoSuchPaddingException._m0 = @__env.GetMethodIDNoThrow(global::javax.crypto.NoSuchPaddingException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.NoSuchPaddingException.staticClass, global::javax.crypto.NoSuchPaddingException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NoSuchPaddingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.NoSuchPaddingException._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.NoSuchPaddingException._m1 = @__env.GetMethodIDNoThrow(global::javax.crypto.NoSuchPaddingException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.NoSuchPaddingException.staticClass, global::javax.crypto.NoSuchPaddingException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchPaddingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.NoSuchPaddingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/NoSuchPaddingException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
