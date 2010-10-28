namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchPaddingException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoSuchPaddingException()
		{
			InitJNI();
		}
		protected NoSuchPaddingException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchPaddingException28705;
		public NoSuchPaddingException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.NoSuchPaddingException.staticClass, global::javax.crypto.NoSuchPaddingException._NoSuchPaddingException28705);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchPaddingException28706;
		public NoSuchPaddingException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.NoSuchPaddingException.staticClass, global::javax.crypto.NoSuchPaddingException._NoSuchPaddingException28706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.NoSuchPaddingException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/NoSuchPaddingException"));
			global::javax.crypto.NoSuchPaddingException._NoSuchPaddingException28705 = @__env.GetMethodIDNoThrow(global::javax.crypto.NoSuchPaddingException.staticClass, "<init>", "()V");
			global::javax.crypto.NoSuchPaddingException._NoSuchPaddingException28706 = @__env.GetMethodIDNoThrow(global::javax.crypto.NoSuchPaddingException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
