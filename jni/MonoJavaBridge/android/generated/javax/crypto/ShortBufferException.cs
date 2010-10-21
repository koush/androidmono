namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ShortBufferException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ShortBufferException()
		{
			InitJNI();
		}
		protected ShortBufferException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ShortBufferException28615;
		public ShortBufferException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ShortBufferException.staticClass, global::javax.crypto.ShortBufferException._ShortBufferException28615);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ShortBufferException28616;
		public ShortBufferException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ShortBufferException.staticClass, global::javax.crypto.ShortBufferException._ShortBufferException28616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ShortBufferException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ShortBufferException"));
			global::javax.crypto.ShortBufferException._ShortBufferException28615 = @__env.GetMethodIDNoThrow(global::javax.crypto.ShortBufferException.staticClass, "<init>", "()V");
			global::javax.crypto.ShortBufferException._ShortBufferException28616 = @__env.GetMethodIDNoThrow(global::javax.crypto.ShortBufferException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
