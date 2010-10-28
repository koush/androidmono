namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BadPaddingException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BadPaddingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BadPaddingException28489;
		public BadPaddingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.BadPaddingException.staticClass, global::javax.crypto.BadPaddingException._BadPaddingException28489);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BadPaddingException28490;
		public BadPaddingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.BadPaddingException.staticClass, global::javax.crypto.BadPaddingException._BadPaddingException28490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BadPaddingException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.BadPaddingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/BadPaddingException"));
			global::javax.crypto.BadPaddingException._BadPaddingException28489 = @__env.GetMethodIDNoThrow(global::javax.crypto.BadPaddingException.staticClass, "<init>", "()V");
			global::javax.crypto.BadPaddingException._BadPaddingException28490 = @__env.GetMethodIDNoThrow(global::javax.crypto.BadPaddingException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
