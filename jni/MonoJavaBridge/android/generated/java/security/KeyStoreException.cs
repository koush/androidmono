namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyStoreException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyStoreException()
		{
			InitJNI();
		}
		protected KeyStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException17401;
		public KeyStoreException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException17401);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException17402;
		public KeyStoreException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException17402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException17403;
		public KeyStoreException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException17403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException17404;
		public KeyStoreException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException17404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreException"));
			global::java.security.KeyStoreException._KeyStoreException17401 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "()V");
			global::java.security.KeyStoreException._KeyStoreException17402 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreException._KeyStoreException17403 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.KeyStoreException._KeyStoreException17404 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
