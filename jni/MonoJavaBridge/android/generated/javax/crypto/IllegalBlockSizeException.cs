namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalBlockSizeException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalBlockSizeException()
		{
			InitJNI();
		}
		protected IllegalBlockSizeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IllegalBlockSizeException28621;
		public IllegalBlockSizeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.IllegalBlockSizeException.staticClass, global::javax.crypto.IllegalBlockSizeException._IllegalBlockSizeException28621);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IllegalBlockSizeException28622;
		public IllegalBlockSizeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.IllegalBlockSizeException.staticClass, global::javax.crypto.IllegalBlockSizeException._IllegalBlockSizeException28622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.IllegalBlockSizeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/IllegalBlockSizeException"));
			global::javax.crypto.IllegalBlockSizeException._IllegalBlockSizeException28621 = @__env.GetMethodIDNoThrow(global::javax.crypto.IllegalBlockSizeException.staticClass, "<init>", "()V");
			global::javax.crypto.IllegalBlockSizeException._IllegalBlockSizeException28622 = @__env.GetMethodIDNoThrow(global::javax.crypto.IllegalBlockSizeException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
