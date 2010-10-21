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
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23000;
		public KeyStoreException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23000);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23001;
		public KeyStoreException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23002;
		public KeyStoreException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23003;
		public KeyStoreException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreException"));
			global::java.security.KeyStoreException._KeyStoreException23000 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "()V");
			global::java.security.KeyStoreException._KeyStoreException23001 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.KeyStoreException._KeyStoreException23002 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.KeyStoreException._KeyStoreException23003 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
