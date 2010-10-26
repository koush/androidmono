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
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23118;
		public KeyStoreException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23118);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23119;
		public KeyStoreException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23120;
		public KeyStoreException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23121;
		public KeyStoreException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreException"));
			global::java.security.KeyStoreException._KeyStoreException23118 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "()V");
			global::java.security.KeyStoreException._KeyStoreException23119 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreException._KeyStoreException23120 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.KeyStoreException._KeyStoreException23121 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
