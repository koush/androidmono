namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyStoreException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public KeyStoreException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStoreException._m0.native == global::System.IntPtr.Zero)
				global::java.security.KeyStoreException._m0 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public KeyStoreException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStoreException._m1.native == global::System.IntPtr.Zero)
				global::java.security.KeyStoreException._m1 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public KeyStoreException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStoreException._m2.native == global::System.IntPtr.Zero)
				global::java.security.KeyStoreException._m2 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public KeyStoreException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStoreException._m3.native == global::System.IntPtr.Zero)
				global::java.security.KeyStoreException._m3 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static KeyStoreException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreException"));
		}
	}
}
